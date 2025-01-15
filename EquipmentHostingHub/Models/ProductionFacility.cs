using System.ComponentModel.DataAnnotations;

namespace EquipmentHostingHub.Models
{
	public class ProductionFacility
	{
		[Key]
		public int ID { get; set; }
		[Required]
		public string Name { get; set; }
		[Required]
		public decimal Area { get; set; }
	}
}
