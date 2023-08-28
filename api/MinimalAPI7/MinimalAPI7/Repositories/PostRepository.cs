using Microsoft.EntityFrameworkCore;
using MinimalAPI7.Database.Context;
using MinimalAPI7.Models;

namespace MinimalAPI7.Repositories
{
    public class PostRepository
    {
        public async Task<List<Post>> GetPostsAsync()
        {
            using(var db = new SQLiteContext())
            {
                return await db.Posts.ToListAsync();
            }
        }

        public async Task<Post> GetPostByIdAsync(int Id)
        {
            using(var db = new SQLiteContext())
            {
                return await db.Posts.FirstOrDefaultAsync(post => post.Id == Id);
            }
        }

        public async Task<bool> CreatePostAsync(Post post)
        {
            using (var db = new SQLiteContext())
            {
                try
                {
                    Post newPost = new Post
                    {
                        Title = post.Title,
                        Content = post.Content,
                        CreatedAt = DateTime.Now,
                    };
                    
                    await db.Posts.AddAsync(newPost);

                    return await db.SaveChangesAsync() >= 1;

                }catch(Exception ex)
                {
                    return false;
                }

            }
        }

        public async Task<bool> UpdatePostAsync(Post post)
        {
            using(var db = new SQLiteContext())
            {
                try
                {
                    Post postToUpdate = new Post()
                    {
                        Id = post.Id,
                        Title = post.Title,
                        Content = post.Content,
                        UpdatedAt = DateTime.Now,
                    };

                    db.Posts.Update(postToUpdate);

                    return await db.SaveChangesAsync() >= 1;
                }
                catch(Exception ex)
                {
                    return false;
                }
            }
        }

        public async Task<bool> DeletePostAsync(int Id)
        {
            using(var db = new SQLiteContext())
            {
                try
                {
                    Post postToDelete = await GetPostByIdAsync(Id);
                    db.Posts.Remove(postToDelete);

                    return (await db.SaveChangesAsync() >= 1);

                }
                catch(Exception ex)
                {
                    return false;
                }
            }
        }
    }
}
