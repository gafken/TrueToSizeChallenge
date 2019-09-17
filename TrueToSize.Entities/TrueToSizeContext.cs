using Microsoft.EntityFrameworkCore;
using System;

namespace TrueToSize.Entities
{
    public class TrueToSizeContext : DbContext
    {
        //Tie Postgres to EFCore :)
        protected override void OnConfiguring(DbContextOptionsBuilder optionsBuilder) => optionsBuilder.UseNpgsql("");

        protected override void OnModelCreating(ModelBuilder modelBuilder)
        {
            base.OnModelCreating(modelBuilder);

            //Register Models Here
        }
    }
}
