
using System.ComponentModel.DataAnnotations;


namespace MauiSqLiteConnection.Models
{
    public class Employee
    {
        [Key]
        public string Id { get; set; }

        public string Name { get; set; }

        public string Email { get; set; }
    }
}
