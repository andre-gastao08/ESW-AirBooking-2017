using System;
using System.Collections.Generic;
using System.Linq;
using System.Threading.Tasks;
using Microsoft.AspNetCore.Identity.EntityFrameworkCore;
using Microsoft.EntityFrameworkCore;
using AirBookingESW17.Models;
using Microsoft.DotNet.Cli.Utils;
using Microsoft.EntityFrameworkCore.Metadata;

namespace AirBookingESW17.Data
{
    /// <summary>
    /// Classe gerada para o intercâmbio de dados com a base de dados.
    /// </summary>
    public class ApplicationDbContext: IdentityDbContext<ApplicationUser>
    {
        public ApplicationDbContext(DbContextOptions<ApplicationDbContext> options)
            : base(options)
        {


        }


        public DbSet<Aviao> Avioes { get; set; }
        public DbSet<Frota> Frotas { get; set; }
        public DbSet<ReservaAviao> ResAvioes { get; set; }
        public DbSet<Reserva> Reservas { get; set; }
        public DbSet<Servico> Servicos { get; set; }
        public DbSet<Tripulacao> Tripulantes { get; set;}
        public DbSet<Voo> Voos { get; set; }
        public DbSet<ContaNotificacao> ContasNotificacoes { get; set;}
        public DbSet<Notificacao> Notificacoes { get; set;}
        public DbSet<Configuracao> Configuracoes { get; set;}
        public DbSet<Newsletter> Newsletters { get; set;}
        public DbSet<ApplicationUser> users { get; set; }
        public DbSet<CidadeOrigem> CidadesOrigem { get; set; }
        public DbSet<CidadeDestino> CidadesDestino { get; set; }



        protected override void OnModelCreating(ModelBuilder builder)
        {
            base.OnModelCreating(builder);

            foreach (var relationship in builder.Model.GetEntityTypes().SelectMany(e => e.GetForeignKeys()))
            {
                relationship.DeleteBehavior = DeleteBehavior.Restrict;
            }

            builder.Entity<ApplicationUser>().ToTable("Utilizador");
            builder.Entity<Aviao>().ToTable("Aviao");
            builder.Entity<CidadeOrigem>().ToTable("CidadeOrigem");
            builder.Entity<CidadeDestino>().ToTable("CidadeDestino");
            builder.Entity<Frota>().ToTable("Frota");
            builder.Entity<ReservaAviao>().ToTable("ReservaAviao");
            builder.Entity<Reserva>().ToTable("Reserva");
            builder.Entity<Servico>().ToTable("Servico");
            builder.Entity<Tripulacao>().ToTable("Tripulacao");
            builder.Entity<Voo>().ToTable("Voo");
            builder.Entity<ContaNotificacao>().ToTable("ContaNotificacao");
            builder.Entity<Notificacao>().ToTable("Notificacao");
            builder.Entity<Configuracao>().ToTable("Configuracao");
            builder.Entity<Newsletter>().ToTable("Newsletter");


            /* ///especificação do id da reserva.
             builder.Entity<Reserva>()
                 .HasKey(r => r.Id);
             //criar as foreignkeys
             builder.Entity<Reserva>()
                 .HasOne(r => r.User)
                 .WithMany(u => u.Reservas)
                 .HasForeignKey(r => r.UserId);

             //builder.Entity<Reserva>()
                 .HasOne(r => r.Voos)
                 .WithMany(digito => digito.Reservas)
                 .HasForeignKey(r => r.VooId);
             // primary key for table Voo
            */


        }

     } 
}
