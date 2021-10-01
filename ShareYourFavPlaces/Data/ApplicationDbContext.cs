using Microsoft.AspNetCore.Identity.EntityFrameworkCore;
using Microsoft.EntityFrameworkCore;
using ShareYourFavPlaces.Models;
using System;
using System.Collections.Generic;
using System.Text;

namespace ShareYourFavPlaces.Data
{
    public class ApplicationDbContext : IdentityDbContext
    {
        //add global reference for all models
        public DbSet<Models.Type> Types { get; set; }
        public DbSet<Post> Posts { get; set; }

        public ApplicationDbContext(DbContextOptions<ApplicationDbContext> options)
            : base(options)
        {
        }
    }
}
