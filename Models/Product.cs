using System.ComponentModel.DataAnnotations;
using System.ComponentModel.DataAnnotations.Schema;

namespace DotnetCoreMVCapp.Models
{
    public class Product
    {
        [Key]
        public int ProductID { get; set; }

        public Guid ProductGuid { get; set; } = Guid.NewGuid();

        [Column(TypeName ="nvarchar(100)")]

        [Required]
        public string ProductName { get; set; }

        [Required]
        public int Price { get; set; }
    }
}
