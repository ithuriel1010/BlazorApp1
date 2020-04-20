using System;
using System.Linq;

namespace EFGetStarted
{
    public class Program
    {
        public void CreateRespondent(Respondent respondent)
        {
            using (var db = new BloggingContext())
            {
                db.Add(respondent);
                db.SaveChanges();
            }                
        }

        public void GetData()
        {
            using (var db = new BloggingContext())
            {
                var wykszt = db.Respondent.Select(x => x.Wyksztalcenie).ToList();
            }
        }

        
        static void Main()
        {
            using (var db = new BloggingContext())
            {
                // Create
                Console.WriteLine("Inserting a new blog");
                db.Add(new Blog { Url = "http://blogs.msdn.com/adonet" });
                db.SaveChanges();
                

                // Read
                Console.WriteLine("Querying for a blog");
                var blog = db.Blogs
                    .OrderBy(b => b.BlogId)
                    .First();

                // Update
                Console.WriteLine("Updating the blog and adding a post");
                blog.Url = "https://devblogs.microsoft.com/dotnet";
                blog.Posts.Add(
                    new Post
                    {
                        Title = "Hello World",
                        Content = "I wrote an app using EF Core!"
                    });
                db.SaveChanges();

                // Delete
                Console.WriteLine("Delete the blog");
                db.Remove(blog);
                db.SaveChanges();
            }
        }
    }
}