using System;
using System.Collections.Generic;
using System.Linq;
using System.Threading.Tasks;
using Microsoft.EntityFrameworkCore;
using TodoApp.Models;
using Microsoft.AspNetCore.Identity;
using Microsoft.AspNetCore.Identity.EntityFrameworkCore;


namespace TodoApp.Data {
    public class ApiDbContext : IdentityDbContext {
        public virtual DbSet<ItemData> Items {get; set;}
        public virtual DbSet<RefreshToken> RefreshToken {get; set;}
        public ApiDbContext(DbContextOptions<ApiDbContext> options) : base(options) 
        {

        }
    }
}