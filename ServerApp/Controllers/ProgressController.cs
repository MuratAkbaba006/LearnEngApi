using System;
using System.Threading.Tasks;
using Microsoft.AspNetCore.Mvc;
using Microsoft.EntityFrameworkCore;
using ServerApp.Data;
using ServerApp.Models;

namespace ServerApp.Controllers
{   
    [ApiController]
    [Route("api/[controller]")]
    public class ProgressController:ControllerBase
    {
        private readonly SocialContext _context;

        public ProgressController(SocialContext context){
            _context=context;
        }

        [HttpGet]
        public async Task<IActionResult> GetProgresses(){
            var progresses=await _context.Progresses.ToListAsync();
            return Ok(progresses);
        }

        [HttpGet("{id}")]
        public async Task<IActionResult> GetProgress(int id){
            
            var p=await _context.Progresses.FirstOrDefaultAsync(i=>i.progressId==id);
            if(p==null){
                return NotFound();
            }
            return Ok(p);
        }

        [HttpPost]
        public async Task<IActionResult> CreateProgress(Progress entity){
            _context.Progresses.Add(entity);
            await _context.SaveChangesAsync();
            return CreatedAtAction(nameof(GetProgress),new{id=entity.progressId},entity);
        }
    }
}