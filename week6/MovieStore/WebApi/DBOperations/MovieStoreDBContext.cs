using Microsoft.EntityFrameworkCore;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Threading.Tasks;
using WebApi.Entities;


namespace WebApi.DBOperations
{
    public class MovieStoreDBContext : DbContext
    {
        public MovieStoreDBContext(DbContextOptions options) : base(options)
        {}

        // optionsBuilder: A builder used to create or modify options for this context.
        // 
        protected override void OnConfiguring(DbContextOptionsBuilder optionsBuilder)
        {
            // optionsBuilder.UseLazyLoadingProxies();
            base.OnConfiguring(optionsBuilder);
        }
        protected override void OnModelCreating(ModelBuilder modelBuilder)
        {
            modelBuilder.Entity<Cast>()
                .HasKey(bc => new { bc.MovieId, bc.ActorId });
            modelBuilder.Entity<Cast>()
                .HasOne(bc => bc.Movie)
                .WithMany(b => b.Cast)
                .HasForeignKey(bc => bc.MovieId);
            modelBuilder.Entity<Cast>()
                .HasOne(bc => bc.Actor)
                .WithMany(c => c.Cast)
                .HasForeignKey(bc => bc.ActorId);
        }
        public DbSet<Movie> Movies { get; set; }
        public DbSet<Actor> Actors { get; set; }
        public DbSet<Director> Directors { get; set; }
        public DbSet<Genre> Genres { get; set; }
        public DbSet<Cast> Cast { get; set; }
    }
}