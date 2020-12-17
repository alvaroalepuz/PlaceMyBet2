using Microsoft.EntityFrameworkCore;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Web;

namespace PlaceMyBet.Models
{
    public class PlaceMyBetContext : DbContext
    {
        public DbSet<usuario> Usuario { get; set; } //Taula
        public DbSet<mercado> Mercado { get; set; } //Taula
        public DbSet<casaapuestas> Casaapuestas { get; set; } //Taula
        public DbSet<evento> Evento { get; set; } //Taula
        public DbSet<apuesta> Apuesta { get; set; } //Taula

        public PlaceMyBetContext()
        {
        }

        public PlaceMyBetContext(DbContextOptions options)
        : base(options)
        {
            
        }

        //Mètode de configuració
        protected override void OnConfiguring(DbContextOptionsBuilder optionsBuilder)
        {
            if (!optionsBuilder.IsConfigured)
            {
                optionsBuilder.UseMySql("Server=localhost;Database=placemybet2;Uid=root;Pwd=''; SslMode = none");//màquina retos

            }
        }

        //Inserció inicial de dades
        protected override void OnModelCreating(ModelBuilder modelBuilder)
        {
            modelBuilder.Entity<usuario>().HasData(new usuario("alvaroalepuz99@gmail.com", "Alvaro", "Alepuz", 10, 1));
            modelBuilder.Entity<casaapuestas>().HasData(new casaapuestas(1, 300, "Bankia", 239458, "alvaroalepuz99@gmail.com"));
            modelBuilder.Entity<mercado>().HasData(new mercado(1, 1.5, 30, 90, 500, 100));
            modelBuilder.Entity<evento>().HasData(new evento(1, "Barcelona", "Madrid", "06-08-2077", 1));
            modelBuilder.Entity<apuesta>().HasData(new apuesta(1, "under", 400, 1, "alvaroalepuz99@gmail.com"));
        }
    }
}