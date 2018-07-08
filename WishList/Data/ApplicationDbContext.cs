﻿using System;
using System.Collections.Generic;
using System.Linq;
using System.Threading.Tasks;
using Microsoft.EntityFrameworkCore; //need to add this to use DbContext
using WishList.Models;

namespace WishList.Data
{
    public class ApplicationDbContext : DbContext //Dbcontext must use Microsoft.EntityFrameworkCore
    {
        public DbSet<Item> Items { get; set; }

        public ApplicationDbContext(DbContextOptions options) : base(options) 
            //Add a Constructor that accepts a parameter of type DbContextOptions 
            //named options and Invokes the base constructor as well.
        {

        }
    }
}
