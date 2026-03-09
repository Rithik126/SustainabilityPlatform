using Microsoft.AspNetCore.Http;
using Microsoft.AspNetCore.Mvc;
using Microsoft.EntityFrameworkCore;
using SustainabilityPlatform.Data;
using SustainabilityPlatform.Model;

namespace SustainabilityPlatform.Controllers
{
    [Route("api/[controller]")]
    [ApiController]
    public class AppliancesController : ControllerBase
    {
        private readonly AppDbContext _context;

        public AppliancesController(AppDbContext context)
        {
            _context = context;
        }

        [HttpGet]
        public async Task<ActionResult<IEnumerable<Appliance>>> GetAppliances()
        {
            return await _context.Appliances.ToListAsync();
        }

        [HttpPost]
        public async Task<ActionResult<Appliance>> AddAppliance(Appliance appliance)
        {
            _context.Appliances.Add(appliance);
            await _context.SaveChangesAsync();
            return Ok(appliance);
        }
    }
}
