using System;
using System.Collections.Generic;
using ServerApp.Models;

namespace ServerApp.DTO
{
    public class UserForDetailsDTO
    {
        public int Id { get; set; }
        public string Name { get; set; }
        public string Email { get; set; }
        public string UserName{get;set;}
        public List<ImagesForDetails> Images {get;set;}

    }

    
}