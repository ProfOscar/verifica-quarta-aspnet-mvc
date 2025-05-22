using Microsoft.AspNetCore.Mvc;
using VerificaQuarta.Models;

namespace VerificaQuarta.Controllers
{
    public class CorsiController:Controller
    {
        private string connStr;
        private Database _db;

        public CorsiController(IConfiguration configuration)
        {
            connStr = configuration.GetConnectionString("DefaultConnection");
            _db = new Database(connStr);
        }

        public IActionResult Index()
        {
            List<Course> courses = new List<Course>();
            string query = @"SELECT Id, Title, Author, Rating, CurrentPrice_Amount, CurrentPrice_Currency FROM Courses";
            using var reader = _db.ExecuteReader(query);
            while (reader.Read())
            {
                courses.Add(new Course
                {
                    Id = reader.GetInt32(0),
                    Title = reader.GetString(1),
                    Author = reader.GetString(2),
                    Rating = reader.GetDouble(3),
                    CurrentPrice_Amount = reader.GetDouble(4),
                    CurrentPrice_Currency = reader.GetString(5),
                });
            }
            return View(courses);
        }
    }
}
