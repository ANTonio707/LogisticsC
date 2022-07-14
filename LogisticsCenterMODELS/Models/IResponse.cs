

namespace LogisticsCenterMODELS.Models
{
    public interface IResponse<T>
    {
        string Message { get; set; }
        bool IsSuccess { get; set; }
        string StatusCode { get; set; }
        T Body { get; set; }
    }
}
