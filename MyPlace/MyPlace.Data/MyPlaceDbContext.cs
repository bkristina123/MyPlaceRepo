using Microsoft.EntityFrameworkCore;
using System;
using System.Collections.Generic;
using System.Text;

namespace MyPlace.Data
{
    public class MyPlaceDbContext : DbContext
    {
        public MyPlaceDbContext(DbContextOptions<MyPlaceDbContext> options) : base(options)
        {

        }

        public DbSet<UserImage> UserImages { get; set; }
    }
}
