using System;
using System.Collections.Generic;
using System.Linq;
using System.Threading.Tasks;
using Microsoft.AspNetCore.Http;
using Microsoft.AspNetCore.Mvc;
using Microsoft.EntityFrameworkCore;
using IntelligentCommunityServicePlatform.Data;

namespace IntelligentCommunityServicePlatform.Controllers
{
    [Produces("application/json")]
    [Route("api/FormDatas")]
    public class FormDatasController : Controller
    {
        private readonly ApplicationDbContext _context;

        public FormDatasController(ApplicationDbContext context)
        {
            _context = context;
        }

        // GET: api/FormDatas
        [HttpGet]
        public IEnumerable<FormData> GetFormDatas()
        {
            return _context.FormDatas.OrderByDescending(x => x.CreatedAt);
        }

        // GET: api/FormDatas/5
        [HttpGet("{id}")]
        public async Task<IActionResult> GetFormData([FromRoute] int id)
        {
            if (!ModelState.IsValid)
            {
                return BadRequest(ModelState);
            }

            var formData = await _context.FormDatas.SingleOrDefaultAsync(m => m.Id == id);

            if (formData == null)
            {
                return NotFound();
            }

            return Ok(formData);
        }

        // PUT: api/FormDatas/5
        [HttpPut("{id}")]
        public async Task<IActionResult> PutFormData([FromRoute] int id, [FromBody] FormData formData)
        {
            if (!ModelState.IsValid)
            {
                return BadRequest(ModelState);
            }

            if (id != formData.Id)
            {
                return BadRequest();
            }

            _context.Entry(formData).State = EntityState.Modified;

            try
            {
                await _context.SaveChangesAsync();
            }
            catch (DbUpdateConcurrencyException)
            {
                if (!FormDataExists(id))
                {
                    return NotFound();
                }
                else
                {
                    throw;
                }
            }

            return NoContent();
        }

        // POST: api/FormDatas
        [HttpPost]
        public async Task<IActionResult> PostFormData([FromBody] FormData formData)
        {
            if (!ModelState.IsValid)
            {
                return BadRequest(ModelState);
            }
            formData.CreatedAt = DateTime.Now;
            _context.FormDatas.Add(formData);
            await _context.SaveChangesAsync();

            return CreatedAtAction("GetFormData", new { id = formData.Id }, formData);
        }

        // DELETE: api/FormDatas/5
        [HttpDelete("{id}")]
        public async Task<IActionResult> DeleteFormData([FromRoute] int id)
        {
            if (!ModelState.IsValid)
            {
                return BadRequest(ModelState);
            }

            var formData = await _context.FormDatas.SingleOrDefaultAsync(m => m.Id == id);
            if (formData == null)
            {
                return NotFound();
            }

            _context.FormDatas.Remove(formData);
            await _context.SaveChangesAsync();

            return Ok(formData);
        }

        private bool FormDataExists(int id)
        {
            return _context.FormDatas.Any(e => e.Id == id);
        }
    }
}