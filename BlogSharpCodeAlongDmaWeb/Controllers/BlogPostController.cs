using BlogSharpCodeAlongDmaWeb.Models;
using Microsoft.AspNetCore.Http;
using Microsoft.AspNetCore.Mvc;

namespace BlogSharpCodeAlongDmaWeb.Controllers;
public class BlogPostController : Controller
{
    List<BlogPost> _blogPosts = new List<BlogPost>() {
            new BlogPost() {Id=1, Title="Awesome blogpost",
                Content="Also some awesome content",
                CreationDate = DateTime.Now.AddDays(-3) },
            new BlogPost() {Id=2, Title="Another blogpost",
                Content="More awesome content",
                CreationDate = DateTime.Now.AddDays(-2) },
            new BlogPost() {Id=3, Title="Baaad blogpost",
                Content="Shitty content",
                CreationDate = DateTime.Now.AddDays(-1) },


        };
    public ActionResult Index() => View(_blogPosts);

    // GET: BlogPostController/Details/5
    public ActionResult Details(int id)
    {
        return View();
    }

    // GET: BlogPostController/Create
    public ActionResult Create()
    {
        return View();
    }

    // POST: BlogPostController/Create
    [HttpPost]
    [ValidateAntiForgeryToken]
    public ActionResult Create(IFormCollection collection)
    {
        try
        {
            return RedirectToAction(nameof(Index));
        }
        catch
        {
            return View();
        }
    }

    // GET: BlogPostController/Edit/5
    public ActionResult Edit(int id)
    {
        return View();
    }

    // POST: BlogPostController/Edit/5
    [HttpPost]
    [ValidateAntiForgeryToken]
    public ActionResult Edit(int id, IFormCollection collection)
    {
        try
        {
            return RedirectToAction(nameof(Index));
        }
        catch
        {
            return View();
        }
    }

    // GET: BlogPostController/Delete/5
    public ActionResult Delete(int id)
    {
        return View();
    }

    // POST: BlogPostController/Delete/5
    [HttpPost]
    [ValidateAntiForgeryToken]
    public ActionResult Delete(int id, IFormCollection collection)
    {
        try
        {
            return RedirectToAction(nameof(Index));
        }
        catch
        {
            return View();
        }
    }
}
