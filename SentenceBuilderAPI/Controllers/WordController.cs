using Microsoft.AspNetCore.Http;
using Microsoft.AspNetCore.Mvc;
using Microsoft.EntityFrameworkCore;
using SentenceBuilderAPI.Data;
using SentenceBuilderAPI.Models;

namespace SentenceBuilderAPI.Controllers
{
    [Route("api/[controller]")]
    [ApiController]
    public class WordController : ControllerBase
    {
        private readonly DataContext _context;

        public WordController(DataContext context)
        {
            _context = context;
        }

        [HttpGet]
        public async Task<ActionResult<List<WordType>>> GetWords()
        {
            return Ok(await _context.Words.OrderBy(w => w.Description).ThenBy(w => w.WordTypeID).ToListAsync());
        }
    }
}
