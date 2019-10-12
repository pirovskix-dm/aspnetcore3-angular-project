using Microsoft.AspNetCore.Mvc;

namespace ExploringTheCore.Core.Contracts.Exceptions
{
    public interface IApiException
    {
        IActionResult GetResult();
    }
}
