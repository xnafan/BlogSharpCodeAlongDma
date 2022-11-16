using BlogSharpCodeAlongDmaWeb.Models;
using Microsoft.AspNetCore.Http;
using Microsoft.AspNetCore.Mvc;

namespace BlogSharpCodeAlongDmaWeb.Controllers;
public class BlogPostController : Controller
{
    static List<BlogPost> _blogPosts = new List<BlogPost>() {
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
    public ActionResult Details(int id)
    {
        return View(_blogPosts.First(blogPost => blogPost.Id == id));
    }
    public ActionResult Create()
    {
        return View();
    }
    [HttpPost]
    [ValidateAntiForgeryToken]
    public ActionResult Create(BlogPost blogPost)
    {
        try
        {
            blogPost.Id = _blogPosts.Max(blogPost => blogPost.Id)+1;
            blogPost.CreationDate = DateTime.Now;
            _blogPosts.Add(blogPost);

            return RedirectToAction(nameof(Index));
        }
        catch
        {
            return View();
        }
    }
    public ActionResult Edit(int id)
    {
        return View(_blogPosts.First(blogPost => blogPost.Id == id));
    }


    [HttpPost]
    [ValidateAntiForgeryToken]
    public ActionResult Edit(BlogPost editedBlogPost)
    {
        try
        {
            var blogPost = _blogPosts.First(blogPost=>blogPost.Id == editedBlogPost.Id);
            blogPost.Title = editedBlogPost.Title;
            blogPost.Content = editedBlogPost.Content;
            return RedirectToAction(nameof(Index));
        }
        catch
        {
            return View();
        }
    }
    public ActionResult Delete(int id)
    {
        return View(_blogPosts.First(blogPost => blogPost.Id == id));
    }

    [HttpPost]
    [ValidateAntiForgeryToken]
    public ActionResult Delete(BlogPost deletedBlogPost)
    {
        try
        {
            _blogPosts.RemoveAll(blogPost => blogPost.Id == deletedBlogPost.Id);
            return RedirectToAction(nameof(Index));
        }
        catch
        {
            return View();
        }
    }
}
