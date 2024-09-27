using Microsoft.AspNetCore.Mvc;
using Umbraco.Cms.Core.Cache;
using Umbraco.Cms.Core.Logging;
using Umbraco.Cms.Core.Routing;
using Umbraco.Cms.Core.Services;
using Umbraco.Cms.Core.Web;
using Umbraco.Cms.Infrastructure.Persistence;
using Umbraco.Cms.Web.Website.Controllers;
using Umbrella.Models;

namespace Umbrella.Controllers
{
	public class ServiceItemSurfaceController : SurfaceController
	{
		public ServiceItemSurfaceController(IUmbracoContextAccessor umbracoContextAccessor, IUmbracoDatabaseFactory databaseFactory, ServiceContext services, AppCaches appCaches, IProfilingLogger profilingLogger, IPublishedUrlProvider publishedUrlProvider) : base(umbracoContextAccessor, databaseFactory, services, appCaches, profilingLogger, publishedUrlProvider)
		{
		}

		public IActionResult HandleSubmit(ServiceItemModel form)
		{
			if (!ModelState.IsValid)
			{
				ViewData["name"] = form.Name;
				ViewData["email"] = form.Email;
                ViewData["message"] = form.Message;
				

				ViewData["error_name"] = string.IsNullOrEmpty(form.Name) ? "Name is required" : null;
				ViewData["error_email"] = string.IsNullOrEmpty(form.Email) ? "Email is required" : null;
                ViewData["error_message"] = string.IsNullOrEmpty(form.Message) ? "Message is required" : null;
			

				return CurrentUmbracoPage();
			}

			TempData["success"] = "Form submitted successfully";

			TempData.Remove("name");
			TempData.Remove("email");
            TempData.Remove("message");
			
			return RedirectToCurrentUmbracoPage();
		}
	}
}
