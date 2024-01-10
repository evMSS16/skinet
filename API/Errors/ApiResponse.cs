namespace API.Errors
{
    public class ApiResponse
    {
#pragma warning disable CS8625 // Cannot convert null literal to non-nullable reference type.
        public ApiResponse(int statusCode, string message = null)
#pragma warning restore CS8625 // Cannot convert null literal to non-nullable reference type.
        {
            StatusCode = statusCode;
            Message = message ?? GetDefaultMessageForStatusCode(statusCode);
        }

        public int StatusCode { get; set; }
        public string Message { get; set; }

        private string GetDefaultMessageForStatusCode(int statusCode)
        {
            return statusCode switch
            {
                400 => "A bad request, you have made",
                401 => "Authorized, you are not",
                404 => "Resource found, it was not",
                500 => "Errors are the path to the dark side. Errors lead to anger. Anger leads to hate.  Hate leads to career change.",
                _ => null
            };
        }
    }
}