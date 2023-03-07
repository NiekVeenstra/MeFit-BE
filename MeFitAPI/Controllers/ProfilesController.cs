using MeFitAPI.DataAccess;
using MeFitAPI.Models.Domain;
using Microsoft.AspNetCore.Mvc;
using Microsoft.EntityFrameworkCore;

// For more information on enabling Web API for empty projects, visit https://go.microsoft.com/fwlink/?LinkID=397860

namespace MeFitAPI.Controllers
{
    [Route("api/[controller]")]
    [ApiController]
    public class ProfilesController : ControllerBase
    {
        private readonly MeFitDbContext _context;

        public ProfilesController(MeFitDbContext context)
        {
            _context = context;
        }

        // GET: api/<ProfilesController>
        [HttpGet]
        public async Task<IActionResult> GetProfile(int profile_id)
        {
            // Retrieve profile with the specified ID from the database, or return 404 if not found.
            Profile profile = await _context.Profiles.Include(p => p.Address).FirstOrDefaultAsync(p => p.Id == profile_id);
            if (profile == null)
            {
                return NotFound();
            }

            // Return the profile as JSON.
            return Ok(profile);
        }

        // GET api/<ProfilesController>/5
        [HttpGet("{id}")]
        public string Get(int id)
        {
            return "value";
        }

        // POST api/<ProfilesController>
        [HttpPost]
        public void Post([FromBody] string value)
        {
        }

        // PUT api/<ProfilesController>/5
        [HttpPut("{id}")]
        public void Put(int id, [FromBody] string value)
        {
        }

        // DELETE api/<ProfilesController>/5
        [HttpDelete("{id}")]
        public void Delete(int id)
        {
        }
    }
}
