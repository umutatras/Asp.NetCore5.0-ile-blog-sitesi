using BusinessLayer.Concrete;
using DataAccessLayer.EntityFramework;
using Microsoft.AspNetCore.Mvc;

namespace CoreDemo.Areas.Admin.Controllers
{
    [Area("Admin")]
    public class AdminBlogController : Controller
    {
        BlogManager blogManageR=new BlogManager(new EfBlogRepository());
        public IActionResult Index()
        {
            var values = blogManageR.GetBlogListWithCategory();
            return View(values);
        }
    }
}
