using System.Collections.Generic;
using System.Linq;
using System.Threading.Tasks;
using Microsoft.AspNetCore.Mvc;
using Microsoft.EntityFrameworkCore;
using ServerApp.Data;
using ServerApp.Models;
using Microsoft.AspNetCore.Authorization;

namespace ServerApp.Controllers{
    
     [Authorize]
     [ApiController]
     [Route("api/[controller]")]   
    public class QuestionsController:ControllerBase
    {
        private readonly SocialContext _context;
        public QuestionsController(SocialContext context){
            _context=context;                
        }
        [HttpGet]
        public async Task<IActionResult> GetQuestions(){
            var questions=await _context.question.ToListAsync();
            return Ok(questions);
        }

        [HttpGet("{id}")]
        public async Task<IActionResult> GetQuestion(int id){
            var q=await _context.question.FirstOrDefaultAsync(i=>i.QuestionId==id);
            if(q==null)
            {
                return NotFound();
            }
            return Ok(q);
        }

        [HttpPost]
        public async Task<IActionResult> CreateQuestions(Questions entity){
            _context.question.Add(entity);
            await _context.SaveChangesAsync();
            return CreatedAtAction(nameof(GetQuestion),new{id=entity.QuestionId},entity);
        }
        [HttpPut("{id}")]
        public async Task<IActionResult> UpdateQuestions(int id,Questions entity)
        {
            if(id!=entity.QuestionId)
            {
                return BadRequest();
            }
            var questions=await _context.question.FindAsync(id);
            if(questions==null){
                return NotFound();
            }
            questions.Question=entity.Question;
            questions.Answer=entity.Answer;
            questions.AnswerLength=entity.AnswerLength;
            questions.Level=entity.Level;
            questions.ipucu=entity.ipucu;
            questions.Chapter=entity.Chapter;
            questions.chapter_image=entity.chapter_image;
            questions.level_image=entity.level_image;
            questions.levelId=entity.levelId;
            try{
                await _context.SaveChangesAsync();
            }catch{
                return NotFound();
            }
            return NoContent();
        }

        [HttpDelete("{id}")]
        public async Task<IActionResult> DeleteQuestion(int id){
            var questions=await _context.question.FindAsync(id);
            if(questions==null){
                return NotFound();
            }
            _context.question.Remove(questions);
            await _context.SaveChangesAsync();
            return NoContent();
        }
    }
}