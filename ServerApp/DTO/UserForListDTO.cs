using System;
using System.Collections.Generic;
using ServerApp.Models;

namespace ServerApp.DTO
{
    public class UserForListDTO
    {

        public int Id { get; set; }
        public string Name { get; set; }
        public string Email { get; set; }

        public string UserName{get;set;}
        public int Age { get; set; }
        
     

        public ImagesForDetails Image {get;set;}


    }
    
}