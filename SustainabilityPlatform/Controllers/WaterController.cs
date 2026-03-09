using Microsoft.AspNetCore.Http;
using Microsoft.AspNetCore.Mvc;
using Microsoft.EntityFrameworkCore;
using SustainabilityPlatform.Data;
using SustainabilityPlatform.Model;

namespace SustainabilityPlatform.Controllers
{
    [Route("api/[controller]")]
    [ApiController]
    public class WaterController : ControllerBase
    {
        private readonly AppDbContext _context;

        public WaterController(AppDbContext context)
        {
            _context = context;
        }

        [HttpGet]
        public async Task<ActionResult<IEnumerable<WaterUsage>>> GetWaterUsage()
        {
            return await _context.WaterUsages.ToListAsync();
        }

        [HttpPost]
        public async Task<ActionResult<WaterUsage>> AddWaterUsage(WaterUsage usage)
        {
            _context.WaterUsages.Add(usage);
            await _context.SaveChangesAsync();
            return Ok(usage);
        }
    }
}