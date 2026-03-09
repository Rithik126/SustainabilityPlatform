using Microsoft.AspNetCore.Http;
using Microsoft.AspNetCore.Mvc;
using Microsoft.EntityFrameworkCore;
using SustainabilityPlatform.Data;
using SustainabilityPlatform.Model;

namespace SustainabilityPlatform.Controllers
{
    [Route("api/[controller]")]
    [ApiController]
    public class AlertsController : ControllerBase
    {
        private readonly AppDbContext _context;

        public AlertsController(AppDbContext context)
        {
            _context = context;
        }

        [HttpGet]
        public async Task<ActionResult<IEnumerable<Alert>>> GetAlerts()
        {
            return await _context.Alerts.ToListAsync();
        }

        [HttpPost]
        public async Task<ActionResult<Alert>> AddAlert(Alert alert)
        {
            _context.Alerts.Add(alert);
            await _context.SaveChangesAsync();
            return Ok(alert);
        }
    }
}
