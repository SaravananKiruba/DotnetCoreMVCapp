using System.ComponentModel.DataAnnotations;
using System.ComponentModel.DataAnnotations.Schema;

namespace DotnetCoreMVCapp.Models
{
    public class Product
    {
        [Key]
        public int ProductID { get; set; }

        
        [Column(TypeName ="nvarchar(100)")]

        [Required]
        public string ProductName { get; set; }

        [Required]
        public int Price { get; set; }
    }
}
