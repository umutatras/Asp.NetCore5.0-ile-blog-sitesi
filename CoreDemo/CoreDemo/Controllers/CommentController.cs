using BusinessLayer.Concrete;
using DataAccessLayer.EntityFramework;
using EntityLayer.Concrete;
using Microsoft.AspNetCore.Authorization;
using Microsoft.AspNetCore.Mvc;
using System;

namespace CoreDemo.Views
{
    [AllowAnonymous]
    public class CommentController : Controller
    {
        CommentManager cm = new CommentManager(new EfCommentRepository());
        public IActionResult Index()
        {
            return View();
        }
        [HttpGet]
        public PartialViewResult PartialAddcomment()
        {
            return PartialView();   
        }
        [HttpPost]
        public PartialViewResult PartialAddcomment(Comment p)
        {
            p.CommentDate=DateTime.Parse(DateTime.Now.ToShortDateString()); 
            p.BlogID = 2;
            p.CommentStatus = true;
            cm.CommentAdd(p);
            return PartialView();
        }
        public PartialViewResult CommentListByBlog(int id)
        {
            var values=cm.GetList(id);
            return PartialView(values);
        }
    }
}
