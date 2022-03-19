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

        public DbSet<Cliente> Cliente { get; set; }
        public DbSet<ClienteContato> ClienteContato { get; set; }
        public DbSet<ClienteAnimal> ClienteAnimal { get; set; }
        public DbSet<TipoAnimal> TipoAnimal { get; set; }
        public DbSet<TipoContato> TipoContato { get; set; }
        public DbSet<Veterinario> Veterinario { get; set; }
        public DbSet<VeterinarioGrade> VeterinarioGrade { get; set; }
        public DbSet<Agendamento> Agendamento { get; set; }
        public DbSet<Atendimento> Atendimento { get; set; }

        protected override void OnConfiguring(DbContextOptionsBuilder optionsBuilder)
        {
            var config = new ConfigurationBuilder()
                .SetBasePath(System.IO.Directory.GetCurrentDirectory())
                .AddJsonFile("appsettings.json")
                .Build();

            optionsBuilder.UseNpgsql(config.GetConnectionString("DefaultConnection"));

            //optionsBuilder.UseNpgsql(config.GetConnectionString("DefaultConnection"),
            //   options => options.SetPostgresVersion(new Version(9, 6)));  //para versão 9.6 do PostGree

            optionsBuilder.UseLazyLoadingProxies();
        }


        protected override void OnModelCreating(ModelBuilder modelBuilder)
        {
            base.OnModelCreating(modelBuilder);
            modelBuilder.ApplyConfiguration(new ClienteMap());
            modelBuilder.ApplyConfiguration(new ClienteContatoMap());
            modelBuilder.ApplyConfiguration(new ClienteAnimalMap());
            modelBuilder.ApplyConfiguration(new TipoAnimalMap());
            modelBuilder.ApplyConfiguration(new TipoContatoMap());
            modelBuilder.ApplyConfiguration(new VeterinarioMap());
            modelBuilder.ApplyConfiguration(new VeterinarioGradeMap());
            modelBuilder.ApplyConfiguration(new AgendamentoMap());
            modelBuilder.ApplyConfiguration(new AtendimentoMap());
        }

    }

}
