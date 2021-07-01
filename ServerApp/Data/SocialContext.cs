using Microsoft.AspNetCore.Identity.EntityFrameworkCore;
using Microsoft.EntityFrameworkCore;
using ServerApp.Models;

namespace ServerApp.Data
{
    public class SocialContext:IdentityDbContext<User,Role,int>
//burada normalde sadece dbcontext vardı ancak biz identity kullanmak için böyle ayzdık
//ekstra paket yüklenmesini gerektirir.Microsoft.AspNetCore.Identity.EntityFrameworkCore paketini yükle

    {
        public SocialContext(DbContextOptions<SocialContext> options):base(options)
        {
            
        }

        public DbSet<Questions> question{get;set;}
        public DbSet<Image> Images{get;set;}

        public DbSet<Progress> Progresses {get;set;}
    }
}