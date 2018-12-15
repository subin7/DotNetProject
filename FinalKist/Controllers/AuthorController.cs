using System;
using System.Collections.Generic;
using System.Linq;
using System.Web;
using System.Web.Mvc;
using FinalKist.Models.Entity;
using FinalKist.Models.Manager;
using FinalKist.Models.DAL;
namespace FinalKist.Controllers
{
    public class AuthorController : Controller
    {
        // GET: Author
        public ActionResult Index()
        {
            return View(ManagerAuthor.GetAuthors());
        }


        public ActionResult Create()
        {
            return View();
        } 
        public ActionResult ShowData()
        {
            List<Author> authors = new List<Author>();
            using (LMSEntities dbe = new LMSEntities())
            {
                authors = dbe.Authors.ToList();
            }
                return View(authors);
        }

        public ActionResult Edit(string id)
        {
            if (string.IsNullOrEmpty(id))
            {
                return RedirectToAction("Index", "Author", null);
            }
            return View(ManagerAuthor.DetailAuthor(id));
        }

        [HttpPost]
        public ActionResult Edit(AuthorEntity detail)
        {
            ManagerAuthor.EditAuthor(detail);
            return RedirectToAction("Index", "Author", null);
        }

        [HttpPost]
        public ActionResult SaveAuthor(AuthorEntity detail)
        {
            ManagerAuthor.SaveAuthor(detail);
            return RedirectToAction("Index", "Author", null);
        }

        
        public ActionResult DeleteAuthor(string id)
        {
            if (string.IsNullOrEmpty(id))
            {
                return RedirectToAction("Index", "Author", null);
            }
            ManagerAuthor.DelAuthor(id);
            return RedirectToAction("Index", "Author", null);
        }

        public ActionResult Details(string id)
        {
            if(string.IsNullOrEmpty(id))
            {
                return RedirectToAction("Index", "Author", null);
            }
            return View(ManagerAuthor.DetailAuthor(id));
        }
    }
}