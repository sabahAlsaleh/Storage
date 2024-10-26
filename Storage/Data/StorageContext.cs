using System;
using System.Collections.Generic;
using System.Linq;
using System.Threading.Tasks;
using Microsoft.EntityFrameworkCore;
using Storage.Models;

namespace Storage.Data
{
    public class StorageContext : DbContext
    {
        public StorageContext (DbContextOptions<StorageContext> options)
            : base(options)
        {
        }
        //  vi använder oss av det för att hämta data från databasen
        public DbSet<Storage.Models.Product> Product { get; set; } = default!;
    }
}
