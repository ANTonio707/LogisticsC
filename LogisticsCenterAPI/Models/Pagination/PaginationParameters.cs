namespace LogisticsCenterAPI.Models.Pagination
{
    public class PaginationParameters
    {
        const int maxPageSize = 50;
        public int PageNumber { set; get; } = 1;
        private int _pageSize = 20;
        public int PageSize
        {
            get { return _pageSize; }
            set { _pageSize = (value > maxPageSize) ? maxPageSize : value; }
        }
    }
}
