using System;
using System.Net;
using System.Net.Http;
using System.Net.Http.Formatting;
using System.Web.Http.Filters;

namespace AspNetWebApi.ApiGee.Filters
{
	/// <summary>
	/// Filter to encapsulate any success in a response with 200 status code.
	/// <remarks>
	/// This filters is about this part of Apigee - Web API Design:
	/// Start by using the following 3 codes.
	///	• 200 - OK
	/// </remarks>
	/// </summary>
    [AttributeUsage(AttributeTargets.Class | AttributeTargets.Method, Inherited = false, AllowMultiple = false)]
    public class SuccessHandlingFilterAttribute : ActionFilterAttribute
    {      
		/// <summary>
		/// Raises the action executed event.
		/// </summary>
		/// <param name="filterContext">Filter context.</param>
        public override void OnActionExecuted(HttpActionExecutedContext filterContext)
        {
            if (filterContext.Response != null && filterContext.Response.IsSuccessStatusCode)
            {
                filterContext.Response = filterContext.Request.CreateResponse(HttpStatusCode.OK, filterContext.Response.Content, new JsonMediaTypeFormatter());
            }
        }
    }
}