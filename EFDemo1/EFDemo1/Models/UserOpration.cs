using Microsoft.EntityFrameworkCore;
using System.Linq;

namespace EFDemo1.Models
{
    public class UserOpration
    {
        private readonly ApplicationDbContext db;

       public UserOpration(ApplicationDbContext db)
        {
            this.db = db;
        }

        // Validate user credentials by email and password
        public User Validate(User user)
        {
            
                    
            return db.Users.FirstOrDefault(u => u.Email == user.Email && u.Password == user.Password);
        }

        
        public int AddUser(User user)
        {
           
            var existingUser = db.Users.FirstOrDefault(u => u.Email == user.Email);
            if (existingUser != null)
            {
                
                return 0;
            }
                      
            db.Users.Add(user);
            return db.SaveChanges(); 
        }
    }
}
