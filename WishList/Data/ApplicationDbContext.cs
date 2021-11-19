﻿using Microsoft.EntityFrameworkCore;
using WishList.Models;

namespace WishList.Data
{
    public class ApplicationDbContext : DbContext
    {
        public DbSet<Item> Item { get; set; }
        public ApplicationDbContext(DbContextOptions options) : base(options)
        {

        }
               
    }
}
