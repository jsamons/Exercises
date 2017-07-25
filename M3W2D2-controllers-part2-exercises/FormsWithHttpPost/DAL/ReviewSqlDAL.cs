using System;
using System.Collections.Generic;
using System.Linq;
using System.Web;
using FormsWithHttpPost.Models;
using System.Web.Configuration;
using System.Data.SqlClient;

namespace FormsWithHttpPost.DAL
{
    public class ReviewSqlDAL : IReviewDAL
    {
        public string connectionString = @"Data Source=localhost\sqlexpress;Initial Catalog=squirrel;Integrated Security=True";
        public const string SQL_GetAllReviews = @"select * from reviews";
        public const string SQL_SaveNewReview = @"insert into reviews values (@username, @rating, @review_title, @review_text, @review_date)";

        public List<Review> GetAllReviews()
        {
            List<Review> reviews = new List<Review>();

            try
            {
                

                using (SqlConnection conn = new SqlConnection(connectionString))
                {
                    conn.Open();
                    SqlCommand cmd = new SqlCommand(SQL_GetAllReviews, conn);
                    SqlDataReader reader= cmd.ExecuteReader();
                    while(reader.Read())
                    {
                        Review review = new Review();
                        review.Id = Convert.ToInt32(reader["review_id"]);
                        review.Username = Convert.ToString(reader["username"]);
                        review.Title = Convert.ToString(reader["review_title"]);
                        review.Message = Convert.ToString(reader["review_text"]);
                        review.ReviewDate = Convert.ToDateTime(reader["review_date"]);
                        review.Rating = Convert.ToInt32(reader["rating"]);
                        reviews.Add(review);

                    }
                    return reviews;
                }
            }
            catch (Exception)
            {
                throw;
            }
        }

        public bool SaveReview(Review newReview)
        {
            try
            {
                using (SqlConnection conn = new SqlConnection(connectionString))
                {
                    conn.Open();
                    SqlCommand cmd = new SqlCommand(SQL_SaveNewReview, conn);
                    cmd.Parameters.AddWithValue(@"username", newReview.Username);
                    cmd.Parameters.AddWithValue(@"rating", newReview.Rating);
                    cmd.Parameters.AddWithValue(@"review_title", newReview.Title);
                    cmd.Parameters.AddWithValue(@"review_text", newReview.Message);
                    cmd.Parameters.AddWithValue(@"review_date", DateTime.Today);
                    int rowsAffected= cmd.ExecuteNonQuery();
                    return (rowsAffected > 0);
                }
            }
            catch(Exception)
            {
                throw;
            }
        }
    }
}