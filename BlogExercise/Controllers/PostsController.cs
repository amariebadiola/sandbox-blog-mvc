using System;
using System.Collections.Generic;
using System.Linq;
using System.Web;
using System.Web.Mvc;

using Entities = BlogExercise.Common.Entities;

namespace BlogExercise.Controllers
{
    public class PostsController : Controller
    {
        //
        // GET: /Posts/

        public ActionResult Index()
        {
            return RedirectToAction("Index", "Home");
        }

        public ActionResult Add()
        {
            return View();
        }

        [HttpPost]
        public ActionResult Add(Entities.BlogPost post)
        {
            return View();
        }
    }
}
