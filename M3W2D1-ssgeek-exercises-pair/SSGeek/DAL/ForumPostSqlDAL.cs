using System;
using System.Collections.Generic;
using System.Linq;
using System.Web;
using SSGeek.Models;
using System.Data.SqlClient;

namespace SSGeek.DAL
{
    public class ForumPostSqlDAL
    {
        private string connectionString = @"Data Source=localhost\sqlexpress;Initial Catalog = SSGeek; Integrated Security = True";
        private const string SQL_GetForumPosts = "select * from forum_post";
        private const string SQL_SubmitForumPosts = "insert into forum_post values(@username, @subject, @message, @post_date)";

        public List<ForumPost> GetAllPosts()
        {
            List<ForumPost> forumPosts = new List<ForumPost>();

            try
            {
                using (SqlConnection connection = new SqlConnection(connectionString))
                {
                    connection.Open();

                    SqlCommand cmd = new SqlCommand(SQL_GetForumPosts, connection);
                    SqlDataReader reader = cmd.ExecuteReader();

                    while(reader.Read())
                    {
                        ForumPost fp = new ForumPost();
                        fp.Id = Convert.ToInt32(reader["id"]);
                        fp.Username = Convert.ToString(reader["username"]);
                        fp.Subject = Convert.ToString(reader["subject"]);
                        fp.Message = Convert.ToString(reader["message"]);
                        fp.PostDate = Convert.ToDateTime(reader["post_date"]);

                        forumPosts.Add(fp);
                    }

                    return forumPosts;
                }
            }
            catch(Exception)
            {
                throw;
            }         
        }

        public bool SaveNewPost(ForumPost post)
        {
            try
            {
                using (SqlConnection connection = new SqlConnection(connectionString))
                {
                    connection.Open();
                    SqlCommand cmd = new SqlCommand(SQL_SubmitForumPosts, connection);
                    cmd.Parameters.AddWithValue("@username", post.Username);
                    cmd.Parameters.AddWithValue("@subject", post.Subject);
                    cmd.Parameters.AddWithValue("@message", post.Message);
                    cmd.Parameters.AddWithValue("@post_date", DateTime.Now);

                    int rowsAffected = cmd.ExecuteNonQuery();
                    return (rowsAffected > 0);
                }
            }
            catch (Exception)
            {
                throw new NotImplementedException();
            }          
        }
    }
}