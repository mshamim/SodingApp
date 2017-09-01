using System.Web.Mvc;
using System.Web.Routing;

namespace SodingApp.Controllers
{
    [HandleError]
    public class ControllerBase : Controller
    {
        protected override void Initialize(RequestContext requestContext)
        {
            base.Initialize(requestContext);
        }

        #region Set Error And Success Messages
        protected void SetSuccessMessage(string message, params string[] args)
        {
            TempData["SuccessMessage"] = string.Format(message, args);
        }

        protected void SetErrorMessage(string message, params string[] args)
        {
            TempData["ErrorMessage"] = string.Format(message, args);
        }
        #endregion
    }
}