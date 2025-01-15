using System.ComponentModel.DataAnnotations;

namespace EquipmentHostingHub.Models
{
	public class EquipementContract
	{
		[Key]
		public int ID { get; set; }
		[Required]
		[Display(Name = "Contractor name")]
		public string Name { get; set; }
		public int Quantity { get; set; }
		public int ProcessEquipementID { get; set; }
		public ProcessEquipement ProcessEquipement { get; set; }

		public int ProductionFacilityID { get; set; }
		public ProductionFacility ProductionFacility { get; set; }
	}
}
