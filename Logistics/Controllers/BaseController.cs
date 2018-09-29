using Logistics.Exceptions;
using Logistics.Helpers;
using System.Web.Mvc;

namespace Logistics.Controllers
{
    public class BaseController : Controller
    {
        protected override void OnActionExecuted(ActionExecutedContext filterContext)
        {
            //base.OnActionExecuted(filterContext);
            //if (filterContext.ActionDescriptor.ActionName != "NotAuthorized" &&
            //    filterContext.ActionDescriptor.ActionName != "Error")
            //{
            //    AuthenticateUser(filterContext.ActionDescriptor.ControllerDescriptor.ControllerName, filterContext.ActionDescriptor.ActionName);
            //}
            try
            {
                AuthenticateUser();
            }
            catch (SessionExpiredException exc)
            {
                filterContext.Result = RedirectToAction("Index", "Login");
            }
        }

        protected void AuthenticateUser()
        {
            if (SessionHelper.SatisUser == null)
                throw new SessionExpiredException();
        }
    }
}