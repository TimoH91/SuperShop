using System.Diagnostics.Eventing.Reader;

namespace SuperShop.Helpers
{
    public class Response
    {
        public bool IsSuccess { get; set; }
        public string Message { get; set; }

        public object Results;
    }
}
