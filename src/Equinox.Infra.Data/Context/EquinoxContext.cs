using Equinox.Domain.Models;
using Equinox.Infra.Data.Mappings;
using Microsoft.EntityFrameworkCore;
using Microsoft.Extensions.Configuration;
using System;

namespace Equinox.Infra.Data.Context
{
    public  class EquinoxContext : DbContext 
    {
     
        public EquinoxContext(DbContextOptions<EquinoxContext> options) 
            : base(options)
        {
        }

        public DbSet<Usuario> Usuario { get; set; }
        public DbSet<UsuarioAtivo> UsuarioAtivo { get; set; }
        public DbSet<Ativo> Ativo { get; set; }
        public DbSet<Movimento> Movimento { get; set; }

        protected override void OnConfiguring(DbContextOptionsBuilder optionsBuilder)
        {
            var config = new ConfigurationBuilder()
                .SetBasePath(System.IO.Directory.GetCurrentDirectory())
                .AddJsonFile("appsettings.json")
                .Build();

            //optionsBuilder.UseNpgsql(config.GetConnectionString("DefaultConnection"));

            //optionsBuilder.UseNpgsql(config.GetConnectionString("DefaultConnection"),
            //   options => options.SetPostgresVersion(new Version(9, 6)));  //para versão 9.6 do PostGree

            optionsBuilder.UseSqlServer(config.GetConnectionString("DefaultConnection"));


            optionsBuilder.UseLazyLoadingProxies();
        }


        protected override void OnModelCreating(ModelBuilder modelBuilder)
        {
            base.OnModelCreating(modelBuilder);
            modelBuilder.ApplyConfiguration(new UsuarioMap());
            modelBuilder.ApplyConfiguration(new UsuarioAtivoMap());
            modelBuilder.ApplyConfiguration(new AtivoMap());
            modelBuilder.ApplyConfiguration(new MovimentoMap());

            modelBuilder.Entity<Ativo>().HasData(
                new Ativo( 1, "PETR4", "PETR4", Convert.ToDecimal("28,44"), DateTime.Now, null),
                new Ativo(2, "SANB11", "SANB11", Convert.ToDecimal("40,77"), DateTime.Now, null),
                new Ativo(3, "AZUL4", "AZUL4", Convert.ToDecimal("22,23"), DateTime.Now, null),
                new Ativo(4, "ALPA4", "ALPA4", Convert.ToDecimal("25,25"), DateTime.Now, null),
                new Ativo(5, "BBDC3", "BBDC3", Convert.ToDecimal("17,50"), DateTime.Now, null),
                new Ativo(6, "CMIG3", "CMIG3", Convert.ToDecimal("19,18"), DateTime.Now, null),
                new Ativo(7, "ELET3", "ELET3", Convert.ToDecimal("35,28"), DateTime.Now, null),
                new Ativo(8, "EMBR3", "EMBR3", Convert.ToDecimal("15,28"), DateTime.Now, null),
                new Ativo(9, "EQTL3", "EQTL3", Convert.ToDecimal("26,81"), DateTime.Now, null),
                new Ativo(10, "ENEV3", "ENEV3", Convert.ToDecimal("13,71"), DateTime.Now, null)
            );

        }

    }

}
