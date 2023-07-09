using System.ComponentModel.DataAnnotations;

namespace IMF.CoreBusiness
{
    public class Inventory
    {
        [Key]
        public int InventoryId { get; set; }

        [Required]
        [StringLength(100)]
        public string InventoryName { get; set; } = string.Empty;

		[Required]
		[Range(1, int.MaxValue, ErrorMessage = "Quantity must be greater than zero")]
        public int Quantity { get; set; }

		[Required]
		[Range(1, int.MaxValue, ErrorMessage = "Price must be greater than zero")]
        public double Price { get; set; }
    }
}