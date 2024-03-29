﻿using eTickets.Models;
using Microsoft.AspNetCore.Identity.EntityFrameworkCore;
using Microsoft.EntityFrameworkCore;

namespace eTickets.Data
{
    public class AppDbContext : IdentityDbContext<ApplicationUser>
    {
        public AppDbContext(DbContextOptions<AppDbContext> options) : base(options)
        {

        }

        protected override void OnModelCreating(ModelBuilder modelBuilder)
        {
            modelBuilder.Entity<Actor_Movie>().HasKey(x => new
            {
                x.MovieId,
                x.ActorId
            });

            modelBuilder.Entity<Actor_Movie>()
                .HasOne(x => x.Movie)
                .WithMany((System.Linq.Expressions.Expression<System.Func<Movie, System.Collections.Generic.IEnumerable<Actor_Movie>>>)(x => (System.Collections.Generic.IEnumerable<Actor_Movie>)x.Actors_Movies))
                .HasForeignKey(x => x.MovieId);

            modelBuilder.Entity<Actor_Movie>()
                .HasOne(x => x.Actor)
                .WithMany(x => x.Actors_Movies)
                .HasForeignKey(x => x.ActorId);

            base.OnModelCreating(modelBuilder);
        }

        public DbSet<Actor> Actors { get; set; }
        public DbSet<Actor_Movie> Actors_Movies { get; set; }
        public DbSet<Cinema> Cinemas { get; set; }
        public DbSet<Movie> Movies { get; set; }
        public DbSet<Producer> Producers { get; set; }
        public DbSet<Order> Orders { get; set; }
        public DbSet<OrderItem> OrderItems { get; set; }
        public DbSet<ShoppingCartItem> ShoppingCartItems { get; set; }
    }
}
