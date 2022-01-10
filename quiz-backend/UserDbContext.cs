using Microsoft.AspNetCore.Identity;
using Microsoft.AspNetCore.Identity.EntityFrameworkCore;
using Microsoft.EntityFrameworkCore;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Threading.Tasks;

namespace quiz_backend
{
    public class UserDbContext:IdentityDbContext<IdentityUser>
    {
        //creation of constructor for aceppting bdcontext
        public UserDbContext(DbContextOptions<UserDbContext> options):base(options)
        {

        }
    }
}
