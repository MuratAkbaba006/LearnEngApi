using System.ComponentModel.DataAnnotations;

namespace ServerApp.Models{

    public class Questions{

            [Key]
            public int QuestionId { get; set; }
            public string Question { get; set; }
            public string ipucu {get;set;}
            public string Answer { get; set; }
            public int AnswerLength { get; set; }
            public string Level { get; set; }
            public string Chapter {get;set;}
            public string level_image {get;set;}
            public string chapter_image{get;set;}
            public int levelId{get;set;}

    }
}