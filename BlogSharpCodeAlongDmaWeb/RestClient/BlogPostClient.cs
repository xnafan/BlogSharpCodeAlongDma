
using BlogSharpCodeAlongDmaWeb.Models;
using RestSharp;

namespace BlogSharpCodeAlongDmaWeb.RestClient
{
    public class BlogPostClient
    {
        RestSharp.RestClient _client;

        public BlogPostClient(string baseUrl) => _client = new RestSharp.RestClient(baseUrl);

        public IEnumerable<BlogPostDto>? GetAllBlogPosts()
        {
            return _client.Get<IEnumerable<BlogPostDto>>(new RestRequest());
        }

    }
}
