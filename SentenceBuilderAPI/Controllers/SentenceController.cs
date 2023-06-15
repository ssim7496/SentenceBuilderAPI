using Microsoft.AspNetCore.Http;
using Microsoft.AspNetCore.Mvc;
using Microsoft.EntityFrameworkCore;
using SentenceBuilderAPI.Data;
using SentenceBuilderAPI.Models;

namespace SentenceBuilderAPI.Controllers
{
    [Route("api/[controller]")]
    [ApiController]
    public class SentenceController : ControllerBase
    {
        private readonly DataContext _context;

        public SentenceController(DataContext context)
        {
            _context = context;
        }

        [HttpGet]
        public async Task<ActionResult<List<Sentence>>> GetSentences()
        {
            return Ok(await _context.Sentences.OrderByDescending(s => s.ID).ToListAsync());
        }

        [HttpPost]
        public async Task<ActionResult<List<Sentence>>> CreateSentence(Sentence sentence)
        {
            _context.Sentences.Add(sentence);
            await _context.SaveChangesAsync();

            return Ok(await _context.Sentences.ToListAsync());
        }
    }
}
