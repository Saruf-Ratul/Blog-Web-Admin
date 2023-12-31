﻿using CodePulseAPI.Models.Domain;
using Microsoft.EntityFrameworkCore;

namespace CodePulseAPI.Data
{
    public class ApplicationDbContext : DbContext
    {
        public ApplicationDbContext(DbContextOptions options) : base(options)
        {
        }
        public DbSet<BlogPost> BlogPosts { get; set; }
        public DbSet<Catagory> Catagorys { get; set; }
    }
}
