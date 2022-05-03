using System.ComponentModel.DataAnnotations;
using System.ComponentModel.DataAnnotations.Schema;

namespace DorsetCollegeOnlineStore.Models
{
    public class Product
    {
        public int Id { get; set; }
        public string? Title { get; set; }
        [Column(TypeName = "decimal(18, 2)")] 
        public decimal Price { get; set; }
        public string? Description { get; set; }
        public string? Category { get; set; }
        public string? Image { get; set; }
        public double? Rate { get; set; }
        public int? Count { get; set; }
        
        // [DataType(DataType.Date)]
        // public DateTime ReleaseDate { get; set; }
    }
}