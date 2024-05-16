/*
using System;
using csharpingmindApi.Models;
using Microsoft.AspNetCore.Http;
using Microsoft.AspNetCore.Mvc;
using Microsoft.EntityFrameworkCore;

namespace csharpingmindApi.Controllers
{
    [Route("api/[controller]")]
    [ApiController]

    public class NoteController : ControllerBase
    {
        private readonly AuthsContext _context;
        public NoteController(AuthsContext context)
        {
            _context = context;
            _context.Database.EnsureCreated();
        }


        [HttpGet]
        public async Task<ActionResult> GetAllNotes()
        {
            var note = await _context.Notes.ToArrayAsync();
            return Ok(note);
        }


   
        [HttpGet("{id}")]
        public async Task<ActionResult> GetNotes(int id)
        {
            //return _context.Users.SingleOrDefault(u => u.Id == id);
            var note = await _context.Notes.FindAsync(id);
            if (note == null)
            {
                return NotFound();
            }
            return Ok(note);
        }


        /*get user by id
        [HttpGet("{isActive}")]
        public async Task<ActionResult<IEnumerable<User>>> GetAvailableUser()
        {
            var note = await _context.Notes.Where(p => p.Id).ToArrayAsync();
            return note;
        }
    


         get user by id
        [HttpGet("{byuser}")]
        public async Task<ActionResult> GetUNoteByUserId(int ByGroupId)
        {
            var note = await _context.Notes.FindAsync(ByGroupId);
            if (note == null)
            {
                return NotFound();
            }
            return Ok(note);
        }


        [HttpPost]
        public async Task<ActionResult> PostNote(Note note)
        {

            if (!ModelState.IsValid)
            {
                return BadRequest();
            }

            _context.Notes.Add(note);
            await _context.SaveChangesAsync();

            return CreatedAtAction(
                nameof(GetAllNotes),
                new { id = note.Id }, note);
        }


        [HttpPut("{id}")]
        public async Task<ActionResult> PutNotes(int id, Note note)
        {
            if (id != note.Id)
            {
                return BadRequest();
            }

            _context.Entry(note).State = EntityState.Modified;

            try
            {
                await _context.SaveChangesAsync();
            }
            catch (DbUpdateConcurrencyException)
            {
                if (!_context.Notes.Any(p => p.Id == id))
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


        [HttpDelete("{id}")]
        public async Task<ActionResult> DeleteNote(int id)
        {
            var note = await _context.Notes.FindAsync(id);
            if (note == null)
            {
                return NotFound();
            }

            _context.Notes.Remove(note);
            await _context.SaveChangesAsync();

            return Ok(note);
        }


        [HttpPost("Delete")]
        public async Task<ActionResult> DeleteMultipleNotes([FromQuery] int[] ids)
        {
            var notes = new List<Note>();
            foreach (var id in ids)
            {
                var note = await _context.Notes.FindAsync(id);
                if (note == null)
                {
                    return NotFound();
                }
                notes.Add(note);
            }
            _context.Notes.RemoveRange(notes);
            await _context.SaveChangesAsync();
            return Ok(notes);
        }
    }
        
}

*/