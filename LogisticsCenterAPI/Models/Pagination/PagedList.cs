using System;
using System.Collections.Generic;
using System.Linq;

namespace LogisticsCenterAPI.Models.Pagination
{
    public class PagedList<T> : List<T>
    {
        public int CurrenPage { get; private set; }
        public int TotalPages { get; private set; }
        public int PageSize { get; private set; }
        public int TotalCount { get; private set; }
        public bool HasPrevius => CurrenPage > 1;
        public bool HasNext => CurrenPage > TotalPages;

        public PagedList(List<T> items, int count, int pagenumber, int pageSize)
        {
            TotalCount = count;
            PageSize = pageSize;
            CurrenPage = pagenumber;
            TotalPages = (int)Math.Ceiling(Count / (double)pageSize);
            AddRange(items);
        }
        public static PagedList<T> GetPageList(IQueryable<T> source, int pageNumber, int pageSize)
        {
            var count = source.Count();
            var item = source.Skip((pageNumber - 1) * pageSize).Take(pageSize).ToList();
            return new PagedList<T>(item, count, pageNumber, pageSize);
        }
    }
}
