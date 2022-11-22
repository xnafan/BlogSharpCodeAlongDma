using BlogSharpDataAccessLayer.Model;
using System;
using System.Collections.Generic;
using System.Data;
using System.Data.SqlClient;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using Dapper;

namespace BlogSharpDataAccessLayer;

public class BlogPostDao : IBlogPostDao
{
   
    private readonly string _connectionString;

    public BlogPostDao(string connectionString)
    {
        _connectionString = connectionString;
    }

    public bool Delete(int postId)
    {
        throw new NotImplementedException();
    }

    public IEnumerable<BlogPost> GetAll()
    {
        string getAllSql = "SELECT * FROM blogpost";      
        return CreateConnection().Query<BlogPost>(getAllSql);
    }

    public BlogPost GetById(int id)
    {
        throw new NotImplementedException();
    }

    public bool Insert(BlogPost post)
    {
        throw new NotImplementedException();
    }

    public BlogPost Update(BlogPost post)
    {
        throw new NotImplementedException();
    }


    private IDbConnection CreateConnection()
    {
        return new SqlConnection(_connectionString);
    }
}
