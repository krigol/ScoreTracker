using Microsoft.AspNetCore.Mvc;
using ScoreTracker.Entities;

namespace ScoreTracker.Controllers
{
    [Route("api/[controller]")]
    [ApiController]

    public class ScoresController : Controller
    {
        private readonly ScoreTrackerDbContext _context;

        public ScoresController(ScoreTrackerDbContext context)
        {
            _context = context;
        }

        [HttpGet]
        public IActionResult GetScores()
        {
            return Ok(_context.Scores.OrderByDescending(x => x.ScoreAmount).ToList());
        }

        [HttpPost]
        public IActionResult SetScore(Score score)
        {
            _context.Scores.Add(score);
            _context.SaveChanges();

            return Ok();
        }
    }
}
