using Microsoft.AspNetCore.Identity;
using System;
using System.Collections.Generic;
namespace ServerApp.Models
{
    public class User: IdentityUser<int>
    {


        //identity frameworkü parola eşleştirme vb. metodları bulundurduğu için bize kolaylık sağlar
        public string Name { get; set; }
        public string Gender { get; set; }
        public DateTime DateOfBirth { get; set;}
        public DateTime Created { get; set; }
        public DateTime LastActive { get; set; }

        public string City { get; set; }
        public string Country{get;set;}
        public string Introduction { get; set; }
        public string Hobbies { get; set; }

        public List<Image> Images {get;set;}

        


    }
}