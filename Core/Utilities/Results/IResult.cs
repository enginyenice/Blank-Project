//Created By Engin Yenice
//enginyenice2626@gmail.com

namespace Core.Utilities.Results
{
    public interface IResult
    {
        public string Message { get; set; }
        public bool Success { get; set; }
    }
}