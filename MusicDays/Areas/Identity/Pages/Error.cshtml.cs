using System.Diagnostics;
using Microsoft.AspNetCore.Authorization;
using Microsoft.AspNetCore.Diagnostics;
using Microsoft.AspNetCore.Mvc;
using Microsoft.AspNetCore.Mvc.RazorPages;

namespace MusicDays.Areas.Identity.Pages
{
    [AllowAnonymous]
    [ResponseCache(Duration = 0, Location = ResponseCacheLocation.None, NoStore = true)]
    public class ErrorModel : PageModel
    {
        public string RequestId { get; set; }
        public int iStatusCode { get; set; }
        public string Message { get; set; }
        public string StackTrace { get; set; }

        public bool ShowRequestId => !string.IsNullOrEmpty(RequestId);

        public void OnGet()
        {
            RequestId = Activity.Current?.Id ?? HttpContext.TraceIdentifier;
            // Get the details of the exception that occurred
            var exception = HttpContext.Features.Get<IExceptionHandlerFeature>();

            iStatusCode = HttpContext.Response.StatusCode;
            Message = exception.Error.Message;
            StackTrace = exception.Error.StackTrace;

        }
    }
}
