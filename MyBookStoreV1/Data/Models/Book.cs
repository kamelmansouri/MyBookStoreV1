using System.ComponentModel.DataAnnotations;

namespace MyBookStoreV1.Data.Models
{
    public class Book
    {
        [Key]
        public int Id { get; set; }
        public string Title { get; set; }
        public string? Description { get; set; }
        public bool IsRead { get; set; }
        public DateTime? DateRead { get; set; }
        public int? Rate { get; set; }
        public string? CoverURL { get; set; }
        public string? Genre { get; set; }
        public DateTime DateAdd { get; set; }

    }
}
