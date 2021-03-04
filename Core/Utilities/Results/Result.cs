//Created By Engin Yenice
//enginyenice2626@gmail.com

namespace Core.Utilities.Results
{
    public class Result : IResult
    {
        public Result(bool success, string message) : this(success)
        {
            Message = message;
        }

        public Result(bool success)
        {
            Success = success;
        }

        public string Message { get; set; }
        public bool Success { get; set; }
    }
}