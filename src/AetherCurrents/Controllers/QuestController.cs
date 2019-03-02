using AetherCurrents.Database.Entities;
using Microsoft.AspNetCore.Mvc;

namespace AetherCurrents.Controllers
{
    /// <summary>
    /// Handles requests for Quest related data
    /// </summary>
    [ApiController]
    [Route("aethercurrents/[controller]")]
    public class QuestController : ControllerBase
    {
        private readonly AetherCurrentsContext _context;

        /// <summary>
        /// The constructor. Sets up the dbContext to use.
        /// </summary>
        /// <param name="context">The dbContext.</param>
        public QuestController(AetherCurrentsContext context)
        {
            _context = context;
        }

        /// <summary>
        /// Gets a quest by id.
        /// GET aethercurrents/quest/1
        /// </summary>
        /// <param name="id">The quest id.</param>
        /// <returns>The quest represented by the id, if found.</returns>
        [HttpGet("{id}")]
        public ActionResult<Quest> Get(int id)
        {
            var quest = _context.Quest.Find(id);
            if (quest == null)
            {
                return NotFound();
            }

            return Ok(quest);
        }
    }
}