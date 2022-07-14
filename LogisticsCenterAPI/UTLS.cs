using LogisticsCenterAPI.Data;
using LogisticsCenterMODELS.Models;
using Microsoft.Extensions.Configuration;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Threading.Tasks;

namespace LogisticsCenterAPI
{
    public class UTLS
    {
        private IConfiguration _config;
        public ApplicationDbContext db;
        public UTLS(
            IConfiguration configuration,
            ApplicationDbContext applicationDbContext)
        {
            db = applicationDbContext;
            _config = configuration;
        }
        public bool IsValidFile(string fileName)
        {
             
            var FilesValids = _config.GetSection("FilesValids").Value;
           

            string[] AllowedFiles = FilesValids.ToString().Split(",");
            string[] type = fileName.Split('.');
            

            for (int i = 0; i < AllowedFiles.Length; i++)
            {
                if (type[1] == AllowedFiles[i])
                {
                    return true;
                }
            }
            return false;
        }

        public string FileConvert(InvoiceDTO invoiceDTO, string PathFolder) 
        {
            string[] i = invoiceDTO.FileName.Split('.');
            var path = $"{PathFolder}/{invoiceDTO.No_Invoice}-{invoiceDTO.Supplier}-{DateTime.Now.ToString("yyyy-MM-dd-hh-mm-ss:ffff")}.{i[1]}";
            var fs = System.IO.File.Create(path);
            fs.Write(invoiceDTO.FileContent, 0,
            invoiceDTO.FileContent.Length);
            fs.Close();

            return path;
        }
        public bool IsValidRecord(string supplier, string No_invoice) 
        {
            if (db.Invoice.FirstOrDefault(c => c.Supplier == supplier && c.No_Invoice == No_invoice) == null)
            {
                return true;
            }  
            return false;
        }

        //void CallProcedure(List<Invoice> invoices)
        //{
        //    var lls = db.Invoice.
        //}
        public static string ConvertImageToByteStringFromImagePath(string imagePath)
        {
            //string imagePath = @"\\192.168.6.99\c$\WebImages\SuministrosImg\cajas.jpg";

            try
            {
                byte[] imageArray = System.IO.File.ReadAllBytes(imagePath);
                string base64ImageRepresentation = Convert.ToBase64String(imageArray);
                return base64ImageRepresentation;
            }
            catch (Exception ex)
            {
                return string.Empty;
            }
        }

      
    }
}
