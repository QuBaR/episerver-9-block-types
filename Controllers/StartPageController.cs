using System;
using System.Collections.Generic;
using System.Linq;
using System.Web;
using System.Web.Mvc;
using System.Web.WebPages;
using EPiServer.Web.Mvc;
using StartPage = episerver9_tutorial.Models.Pages.StartPage;

namespace episerver9_tutorial.Controllers
{
    public class StartPageController : PageController<StartPage>
    {
        // GET: StartPage
        public ActionResult Index(StartPage currentPage)
        {
            return View(currentPage);
        }
    }
}