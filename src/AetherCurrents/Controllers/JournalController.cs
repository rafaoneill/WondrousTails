using AetherCurrents.Database.Entities;
using Microsoft.AspNetCore.Mvc;
using System.Collections.Generic;
using System.Linq;

namespace AetherCurrents.Controllers
{
    /// <summary>
    /// Handles requests for Journal related data
    /// </summary>
    [ApiController]
    [Route("aethercurrents/[controller]")]
    public class JournalController : ControllerBase
    {
        private readonly AetherCurrentsContext _context;

        /// <summary>
        /// The constructor. Sets up the dbContext to use.
        /// </summary>
        /// <param name="context">The dbContext.</param>
        public JournalController(AetherCurrentsContext context)
        {
            _context = context;
        }

        /// <summary>
        /// Gets all journal sections.
        /// GET aethercurrents/sections
        /// </summary>
        /// <returns>All journal sections, if any.</returns>
        [HttpGet("sections")]
        public ActionResult<IEnumerable<JournalSection>> GetJournalSections()
        {
            var sections = _context.JournalSection;
            if (sections.Count() == 0)
            {
                return NoContent();
            }
            return Ok(sections);
        }

        /// <summary>
        /// Gets a journal section by id.
        /// GET aethercurrents/section/1
        /// </summary>
        /// <param name="id">The journal section id.</param>
        /// <returns>The journal section represented by the id, if found.</returns>
        
        [HttpGet("section/{id}")]
        public ActionResult<JournalSection> GetJournalSection(int id)
        {
            var section = _context.JournalSection.Find(id);
            if(section == null)
            {
                return NotFound();
            }
            return Ok(section);
        }
        
        /// <summary>
        /// Gets journal categories associated to a journal section.
        /// GET aethercurrents/categories/1
        /// </summary>
        /// <param name="id">The journal section id.</param>
        /// <returns>The journal categories associated to a journal section.</returns>
        [HttpGet("categories/{id}")]
        public ActionResult<List<JournalCategory>> GetJournalCategoriesInSection(int id)
        {
            var categories = _context.JournalCategory.Where(w => w.JournalSectionId == id);
            if(categories.Count() == 0)
            {
                return NoContent();
            }
            return Ok(categories.ToList());
        }
    }
}