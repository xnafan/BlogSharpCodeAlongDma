
using BlogSharpCodeAlongDmaWeb.Models;
using RestSharp;

namespace BlogSharpCodeAlongDmaWeb.RestClient
{
    public class BlogPostClient
    {
        RestSharp.RestClient _client = new ("https://localhost:7101/api/BlogPost");


        public IEnumerable<BlogPostDto>? GetAllBlogPosts()
        {
            return _client.Get<IEnumerable<BlogPostDto>>(new RestRequest());
        }

    }
}
