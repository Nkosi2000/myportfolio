using System.ComponentModel.DataAnnotations;
using System.ComponentModel.DataAnnotations.Schema;

namespace myportfolio.Models
{
    [Table("UsersWhoReachedOut")]
    public class UsersWhoReachedOut
    {
        [Key] // Add this line to specify the primary key
        [Column("id")]
        public int Id { get; set; }

        [Column("name")]
        public string? Name { get; set; }

        [Column("email")]
        public string? Email { get; set; }

        [Column("message")]
        public string? Message { get; set; }
    }
}
