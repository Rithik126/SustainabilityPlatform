using Microsoft.AspNetCore.Http;
using Microsoft.AspNetCore.Mvc;
using Microsoft.EntityFrameworkCore;
using SustainabilityPlatform.Data;
using SustainabilityPlatform.Model;

namespace SustainabilityPlatform.Controllers
{
    [Route("api/[controller]")]
    [ApiController]
    public class EnergyController : ControllerBase
    {
        private readonly AppDbContext _context;

        public EnergyController(AppDbContext context)
        {
            _context = context;
        }

        [HttpGet]
        public async Task<ActionResult<IEnumerable<EnergyUsage>>> GetEnergyUsage()
        {
            return await _context.EnergyUsages.ToListAsync();
        }

        [HttpPost]
        public async Task<ActionResult<EnergyUsage>> AddEnergyUsage(EnergyUsage usage)
        {
            _context.EnergyUsages.Add(usage);
            await _context.SaveChangesAsync();
            return Ok(usage);
        }
    }
}