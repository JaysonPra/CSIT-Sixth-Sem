using WebApplication1.Interfaces;
using WebApplication1.Models;
using Microsoft.Data.SqlClient;

namespace WebApplication1.Repositories
{
    public class BookRepository: IBookRepository
    {
        string conStr = "Server=localhost;Database=testdb;Trust Server Certificate=true;Integrated Security=true;";

        SqlConnection conn = null;
        SqlCommand cmd = null;

        public int AddBook(Book book)
        {
            using (conn = new SqlConnection(conStr))
            {
                conn.Open();

                string insertQuery = "INSERT INTO books(title, price) VALUES(@Title, @Price)";
                cmd = new SqlCommand(insertQuery, conn);
                cmd.Parameters.AddWithValue("@Title", book.Title);
                cmd.Parameters.AddWithValue("@Price", book.Price);
                
                return cmd.ExecuteNonQuery();
            }
        }
    }
}