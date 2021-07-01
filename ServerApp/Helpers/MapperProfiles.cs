using System.Linq;
using AutoMapper;
using ServerApp.DTO;
using ServerApp.Models;
namespace ServerApp.Helpers
{
    public class MapperProfiles:Profile{
        public MapperProfiles()
        {
            CreateMap<User,UserForListDTO>().ForMember(dest=>dest.Image,opt=>opt.MapFrom(src=>src.Images.FirstOrDefault(i=>i.IsProfile)))
            .ForMember(dest=>dest.Age,opt=>opt.MapFrom(src=>src.DateOfBirth.CalculateAge()));
             //ForMember(dest=>dest.Image) diyerek DTO içerisindeki Image alanını seçtik,daha sonra
            //opt=>opt.MapFrom(src=>src.Images) dierek kaynaktaki yani User Model içerisinde
            //yer alan resim bilgilerine ulaştık.daha sonra ise isProfile alanı true olan resimi aldık
            CreateMap<User,UserForDetailsDTO>();
            CreateMap<Image,ImagesForDetails>();
        }
            //örneğin CreateMap<User,UserForListDTO> dediğimizde 
        //Userın içerisindeki bilgiler UserForListDTO ile eşleşmiş oalcak    
    }   
}