using Microsoft.AspNetCore.Http;
using Microsoft.AspNetCore.Mvc;
using Microsoft.EntityFrameworkCore;
using SentenceBuilderAPI.Data;
using SentenceBuilderAPI.Models;

namespace SentenceBuilderAPI.Controllers
{
    [Route("api/[controller]")]
    [ApiController]
    public class WordTypeController : ControllerBase
    {
        private readonly DataContext _context;

        public WordTypeController(DataContext context)
        {
            _context = context;
        }

        [HttpGet]
        public async Task<ActionResult<List<WordType>>> GetWordTypes()
        {
            return Ok(await _context.WordTypes.OrderBy(wt => wt.Description).ToListAsync());
        }
    }
}
