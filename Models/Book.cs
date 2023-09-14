using System.ComponentModel.DataAnnotations.Schema;
using System.ComponentModel.DataAnnotations;

namespace Assign4.Models
{
    [Table("Book")]
    public class Book
    {
        [Key]
        public int Id { get; set; }
        public string Name { get; set; }
        public string Genre { get; set; }
    }
}
