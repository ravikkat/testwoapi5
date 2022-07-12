using System;
using System.Collections.Generic;
using System.Linq;
using System.Threading.Tasks;
using Microsoft.EntityFrameworkCore;
namespace PetsAPI.Models
{
   
    public class PetDBContext : DbContext
    {
        public PetDBContext(DbContextOptions<PetDBContext> options)
            : base(options)
        {
        }

        public DbSet<Pet> TodoItems { get; set; }
    }
}
