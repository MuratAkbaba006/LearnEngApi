using System;

namespace ServerApp.DTO
{
    public class ImagesForDetails
    {
         public int id { get; set; }   
        public string Name { get; set; }
        public string Description { get; set; }
        public DateTime DateAdd { get; set; }
        public bool IsProfile { get; set; }

    }
}