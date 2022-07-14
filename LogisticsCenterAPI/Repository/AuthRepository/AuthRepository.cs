using Caucedo.ActiveDirectoryServices.Service;
using LogisticsCenterAPI.Data;
using LogisticsCenterMODELS.Models;
using Microsoft.EntityFrameworkCore;
using Microsoft.Extensions.Configuration;
using System.Linq;
using System.Threading.Tasks;

namespace LogisticsCenterAPI.Repository.AuthRepository
{
    public class AuthRepository : IAuthRepository
    {
        private readonly  ApplicationDbContext _dbContext;
        private IConfiguration _config;
        public AuthRepository( ApplicationDbContext applicationDbContext, IConfiguration configuration) {
            _dbContext = applicationDbContext;
            this._config = configuration;
        }
        //public async Task<User> Login(string Username, string password)
        //{
        //    var user = await _dbContext.user.FirstOrDefaultAsync(x => x.Username == Username);
        //    if (user == null)
        //    {
        //        return null;
        //    }
        //    if (!VerifyPasswordHash(Username, user.PasswordHash, user.PasswordSalt))
        //    {
        //        return null;
        //    }
        //    return user;
        //}
        //public bool VerifyPasswordHash(string password, byte[] passwordHash, byte[] passwordSalt)
        //{
        //    using (var hmac = new System.Security.Cryptography.HMACSHA512(passwordSalt))
        //    {
        //        var computedHash = hmac.ComputeHash(System.Text.Encoding.UTF8.GetBytes(password));
        //        for (int i = 0; i < computedHash.Length; i++)
        //        {
        //            if (computedHash[i] != passwordHash[i])
        //            {
        //                return false;
        //            }
        //        }
        //    }
        //    return true;
        //}
        //public async Task<User> Register(User user, string password)
        //{
        //    byte[] passwordHash;
        //    byte[] passworldSalt;

        //    CreatePasswordHash(password, out passwordHash, out passworldSalt);
        //    user.PasswordHash = passwordHash;
        //    user.PasswordSalt = passworldSalt;

        //    await _dbContext.user.AddAsync(user);
        //    await _dbContext.SaveChangesAsync();

        //    return user;
        //}

        //private void CreatePasswordHash(string password, out byte[] passwordHash, out byte[] passwordSalt) 
        //{
        //    using (var hmac = new System.Security.Cryptography.HMACSHA512()) 
        //    {
        //        passwordSalt = hmac.Key;
        //        passwordHash = hmac.ComputeHash(System.Text.Encoding.UTF8.GetBytes(password));
        //    }
        //}
        //public async Task<bool> ValitedExitenceUser(string UserName)
        //{
        //    if (await _dbContext.user.AnyAsync(x => x.Username == UserName))
        //        return true;
            
        //    return false;
        //}

        /*--------------------------------------------------------------*/
        public async Task<User> LoginWithActDirect(string UserName, string Password)
        {
            string LDAP_Connection = _config.GetSection("LDAP_Connection").Value;
            string DomainUser =  _config.GetSection("DomainUser").Value;
            string UserPassword = _config.GetSection("UserPassword").Value;
            string GroupAdministrationAccess = _config.GetSection("GroupAdministrationAccess").Value;
            string GroupbillersAccess = _config.GetSection("GroupbillersAccess").Value;
            User user = new User();
          
                ActiveDirectoryServices activeDirectoryServices = new ActiveDirectoryServices(LDAP_Connection, DomainUser, UserPassword);

                var oUser = await Task.FromResult(activeDirectoryServices.IsUserValidCredientials(UserName, Password));

                if (oUser)
                {

                    var userActD = activeDirectoryServices.GetUser(UserName);
                    var isVaildGroupAdministration = userActD.Groups.Where(u => u.GroupName.Equals(GroupAdministrationAccess)).FirstOrDefault();
                    var isValidGroupbillersAccess = userActD.Groups.Where(u => u.GroupName.Equals(GroupbillersAccess)).FirstOrDefault();

                    if (isVaildGroupAdministration != null || isValidGroupbillersAccess != null)
                    {
                        string group = " ";
                    if (isVaildGroupAdministration != null)
                        group = isVaildGroupAdministration.GroupName;
                    else
                        group = isValidGroupbillersAccess.GroupName;
                        
                    user = new User()
                        {
                            Username = UserName,
                            FullName = userActD.FullName,
                            FirstName = userActD.FirstName,
                            JobFunction = userActD.JobFunction,
                            GroupAccess = group
                    };
                        return user;
                    }
                    return user = null;
                }
            return user = null;
        }
    }
}
