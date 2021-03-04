//Created By Engin Yenice
//enginyenice2626@gmail.com

namespace Core.Utilities.Results
{
    public interface IDataResult<T> : IResult
    {
        public T Data { get; set; }
    }
}