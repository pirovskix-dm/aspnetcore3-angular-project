using ExploringTheCore.Core.Exceptions.Errors;

namespace ExploringTheCore.Core.Exceptions
{
    public class ApiNotFoundException : BaseApiException
    {
        public ApiNotFoundException(string message)
            : base(new ApiError404(message))
        {

        }
    }
}
