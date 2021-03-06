using System.Collections.Generic;
using System.Linq;
using System.Threading.Tasks;
using Microsoft.EntityFrameworkCore;
using ServerApp.Models;
using ServerApp.DTO;

using Microsoft.AspNetCore.Authorization;
using Microsoft.AspNetCore.Mvc;

using ServerApp.Data;

namespace ServerApp.Data
{
    public class SocialRepository : ISocialRepository
    {
        private readonly SocialContext _context;
        
        public SocialRepository(SocialContext context)
        {
            _context = context;
        }
        public async Task<User> GetUser(int id)
        {
            var user = await _context.Users.Include(i=>i.Images)
                                .FirstOrDefaultAsync(i=>i.Id == id);
            return user;
        }

        public async Task<IEnumerable<User>> GetUsers()
        {
            var users = await _context.Users.Include(i=>i.Images).ToListAsync();
            return users;
        }

        
  
    }
}
