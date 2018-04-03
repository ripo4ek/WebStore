using System;
using System.Collections.Generic;
using System.Collections.Specialized;
using System.Text;
using Microsoft.EntityFrameworkCore;
using WebStore.Domain.Model;

namespace WebStore.DAL.Context
{
    public class WebStoreContext : DbContext
    {
        public WebStoreContext(DbContextOptions options) : base(options)
        { }
        public DbSet<Product> Products { get; set; }
        public DbSet<Section> Sections { get; set; }
        public DbSet<Brand> Brands { get; set; }

    }
}
