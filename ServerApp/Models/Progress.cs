using System.ComponentModel.DataAnnotations;

namespace ServerApp.Models
{
    public class Progress
    {
          [Key]
        public int progressId{get;set;}
        public string levelId{get;set;}
         public int userId{get;set;}
        public bool isComplete{get;set;}
        public string Level {get;set;}
    }
}