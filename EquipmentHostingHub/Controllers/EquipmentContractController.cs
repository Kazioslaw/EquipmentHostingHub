using EquipmentHostingHub.Data;
using EquipmentHostingHub.DTOs;
using EquipmentHostingHub.Models;
using Microsoft.AspNetCore.Mvc;
using Microsoft.EntityFrameworkCore;

namespace EquipmentHostingHub.Controllers
{
	[Route("api/[controller]")]
	[ApiController]
	public class EquipmentContractController : ControllerBase
	{
		private EquipmentHostingHubContext _context;

		public EquipmentContractController(EquipmentHostingHubContext context)
		{
			_context = context;
		}

		[HttpGet]
		public async Task<IActionResult> GetEquipmentContracts()
		{
			var equipmentContracts = await _context.EquipmentContracts.Include(ec => ec.ProcessEquipment).Include(ec => ec.ProductionFacility).Select(ec => new
			{
				ContractorName = ec.Name,
				ProductionFacility = ec.ProductionFacility.Name,
				ProcessEqupment = ec.ProcessEquipment.Name,
				EqupmentQuantity = ec.Quantity
			}).ToListAsync();

			return Ok(equipmentContracts);

		}

		[HttpPost]
		public async Task<IActionResult> CreateEquipmentContract(EquipmentContractDTO contract)
		{
			var productionFacilityList = await _context.ProductionFacilities.ToListAsync();
			var processEquipmentList = await _context.ProcessEquipments.ToListAsync();
			var productionFacility = productionFacilityList.FirstOrDefault(pf => pf.Code == contract.ProductionFacilityCode);
			var processEquipment = processEquipmentList.FirstOrDefault(pe => pe.Code == contract.ProcessEquipmentCode);
			var actualContracts = await _context.EquipmentContracts.Where(ec => ec.ProductionFacility.Code == contract.ProductionFacilityCode).ToListAsync();

			if (productionFacility == null || processEquipment == null)
			{
				return NotFound("This facility or equipment is not found");
			}

			if ((processEquipment.Area * contract.Quantity) > productionFacility.Area || (processEquipment.Area * contract.Quantity) > (productionFacility.Area - actualContracts.Sum(e => e.ProcessEquipment.Area * e.Quantity)))
			{
				return BadRequest("This amount of equipment is not possible to place in this facility");
			}

			var newContract = new EquipmentContract
			{
				Name = contract.Name,
				ProcessEquipmentID = processEquipment.ID,
				ProcessEquipment = processEquipment,
				ProductionFacilityID = productionFacility.ID,
				ProductionFacility = productionFacility,
				Quantity = contract.Quantity

			};

			await _context.EquipmentContracts.AddAsync(newContract);
			await _context.SaveChangesAsync();
			return Ok("Successfully created a contract");
		}
	}
}
