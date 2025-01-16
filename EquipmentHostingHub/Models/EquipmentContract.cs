using System.ComponentModel.DataAnnotations;

namespace EquipmentHostingHub.Models
{
	public class EquipmentContract
	{
		[Key]
		public int ID { get; set; }
		[Required]
		[Display(Name = "Contractor name")]
		public string Name { get; set; }
		public int Quantity { get; set; }
		public int ProcessEquipmentID { get; set; }
		public ProcessEquipment ProcessEquipment { get; set; }

		public int ProductionFacilityID { get; set; }
		public ProductionFacility ProductionFacility { get; set; }
	}
}
