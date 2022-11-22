using BlogSharpDataAccessLayer.Model;

namespace BlogSharpDataAccessLayer
{
    public interface IBlogPostDao
    {
        IEnumerable<BlogPost> GetAll();
        BlogPost GetById(int id);
        bool Insert(BlogPost post);
        BlogPost Update(BlogPost post);
        bool Delete(int postId);
    }


}