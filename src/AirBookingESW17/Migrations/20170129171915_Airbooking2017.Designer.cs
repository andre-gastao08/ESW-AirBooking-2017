using System;
using Microsoft.EntityFrameworkCore;
using Microsoft.EntityFrameworkCore.Infrastructure;
using Microsoft.EntityFrameworkCore.Metadata;
using Microsoft.EntityFrameworkCore.Migrations;
using AirBookingESW17.Data;

namespace AirBookingESW17.Migrations
{
    [DbContext(typeof(ApplicationDbContext))]
    [Migration("20170129171915_Airbooking2017")]
    partial class Airbooking2017
    {
        protected override void BuildTargetModel(ModelBuilder modelBuilder)
        {
            modelBuilder
                .HasAnnotation("ProductVersion", "1.1.0-rtm-22752")
                .HasAnnotation("SqlServer:ValueGenerationStrategy", SqlServerValueGenerationStrategy.IdentityColumn);

            modelBuilder.Entity("AirBookingESW17.Models.ApplicationUser", b =>
                {
                    b.Property<string>("Id")
                        .ValueGeneratedOnAdd();

                    b.Property<int>("AccessFailedCount");

                    b.Property<string>("ConcurrencyStamp")
                        .IsConcurrencyToken();

                    b.Property<string>("Email")
                        .HasAnnotation("MaxLength", 256);

                    b.Property<bool>("EmailConfirmed");

                    b.Property<bool>("LockoutEnabled");

                    b.Property<DateTimeOffset?>("LockoutEnd");

                    b.Property<string>("NormalizedEmail")
                        .HasAnnotation("MaxLength", 256);

                    b.Property<string>("NormalizedUserName")
                        .HasAnnotation("MaxLength", 256);

                    b.Property<string>("PasswordHash");

                    b.Property<string>("PhoneNumber");

                    b.Property<bool>("PhoneNumberConfirmed");

                    b.Property<string>("SecurityStamp");

                    b.Property<bool>("TwoFactorEnabled");

                    b.Property<string>("UserName")
                        .HasAnnotation("MaxLength", 256);

                    b.HasKey("Id");

                    b.HasIndex("NormalizedEmail")
                        .HasName("EmailIndex");

                    b.HasIndex("NormalizedUserName")
                        .IsUnique()
                        .HasName("UserNameIndex");

                    b.ToTable("Utilizador");
                });

            modelBuilder.Entity("AirBookingESW17.Models.Aviao", b =>
                {
                    b.Property<int>("Id")
                        .ValueGeneratedOnAdd();

                    b.Property<int>("AvCapacidade");

                    b.Property<string>("AvNome")
                        .IsRequired();

                    b.Property<bool>("AvPartilhado");

                    b.Property<string>("AvSerie")
                        .IsRequired();

                    b.Property<int>("FrotaId");

                    b.Property<int>("VooId");

                    b.HasKey("Id");

                    b.HasIndex("FrotaId");

                    b.HasIndex("VooId");

                    b.ToTable("Aviao");
                });

            modelBuilder.Entity("AirBookingESW17.Models.CidadeDestino", b =>
                {
                    b.Property<int>("CidadeDestinoId")
                        .ValueGeneratedOnAdd();

                    b.Property<string>("Nome")
                        .IsRequired()
                        .HasAnnotation("MaxLength", 255);

                    b.Property<int?>("VooId");

                    b.HasKey("CidadeDestinoId");

                    b.HasIndex("VooId");

                    b.ToTable("CidadeDestino");
                });

            modelBuilder.Entity("AirBookingESW17.Models.CidadeOrigem", b =>
                {
                    b.Property<int>("CidadeOrigemId")
                        .ValueGeneratedOnAdd();

                    b.Property<string>("Nome")
                        .IsRequired()
                        .HasAnnotation("MaxLength", 255);

                    b.Property<int?>("VooId");

                    b.HasKey("CidadeOrigemId");

                    b.HasIndex("VooId");

                    b.ToTable("CidadeOrigem");
                });

            modelBuilder.Entity("AirBookingESW17.Models.Configuracao", b =>
                {
                    b.Property<int>("ConfigId")
                        .ValueGeneratedOnAdd();

                    b.Property<string>("AntigaPassword")
                        .HasAnnotation("MaxLength", 255);

                    b.Property<string>("Email")
                        .IsRequired()
                        .HasAnnotation("MaxLength", 255);

                    b.Property<string>("NovaPassword")
                        .IsRequired();

                    b.Property<string>("UserId");

                    b.Property<string>("UsersId");

                    b.HasKey("ConfigId");

                    b.HasIndex("UsersId");

                    b.ToTable("Configuracao");
                });

            modelBuilder.Entity("AirBookingESW17.Models.ContaNotificacao", b =>
                {
                    b.Property<int>("ContaNotId")
                        .ValueGeneratedOnAdd();

                    b.Property<string>("Descricao")
                        .IsRequired()
                        .HasAnnotation("MaxLength", 255);

                    b.Property<int>("NotificacaoId");

                    b.Property<string>("UserId");

                    b.HasKey("ContaNotId");

                    b.HasIndex("NotificacaoId");

                    b.HasIndex("UserId");

                    b.ToTable("ContaNotificacao");
                });

            modelBuilder.Entity("AirBookingESW17.Models.Frota", b =>
                {
                    b.Property<int>("FrotaId")
                        .ValueGeneratedOnAdd();

                    b.Property<string>("Email")
                        .HasAnnotation("MaxLength", 255);

                    b.Property<string>("Morada")
                        .IsRequired()
                        .HasAnnotation("MaxLength", 255);

                    b.Property<int>("NIF");

                    b.Property<string>("Nome")
                        .IsRequired()
                        .HasAnnotation("MaxLength", 255);

                    b.Property<string>("Telefone")
                        .IsRequired();

                    b.HasKey("FrotaId");

                    b.ToTable("Frota");
                });

            modelBuilder.Entity("AirBookingESW17.Models.Newsletter", b =>
                {
                    b.Property<int>("NewsletterId")
                        .ValueGeneratedOnAdd();

                    b.Property<string>("EmaisDestinatario")
                        .IsRequired()
                        .HasAnnotation("MaxLength", 255);

                    b.Property<string>("NomeDestinatario")
                        .IsRequired()
                        .HasAnnotation("MaxLength", 255);

                    b.HasKey("NewsletterId");

                    b.ToTable("Newsletter");
                });

            modelBuilder.Entity("AirBookingESW17.Models.Notificacao", b =>
                {
                    b.Property<int>("NotificacaoId")
                        .ValueGeneratedOnAdd();

                    b.Property<DateTime>("DataNotificacao");

                    b.Property<string>("Descricao")
                        .HasAnnotation("MaxLength", 255);

                    b.Property<int>("NewsletterId");

                    b.HasKey("NotificacaoId");

                    b.HasIndex("NewsletterId");

                    b.ToTable("Notificacao");
                });

            modelBuilder.Entity("AirBookingESW17.Models.Reserva", b =>
                {
                    b.Property<int>("Id")
                        .ValueGeneratedOnAdd();

                    b.Property<DateTime>("Data");

                    b.Property<decimal>("Preco");

                    b.Property<string>("UserId");

                    b.Property<int>("VooId");

                    b.HasKey("Id");

                    b.HasIndex("UserId");

                    b.HasIndex("VooId");

                    b.ToTable("Reserva");
                });

            modelBuilder.Entity("AirBookingESW17.Models.ReservaAviao", b =>
                {
                    b.Property<int>("Id")
                        .ValueGeneratedOnAdd();

                    b.Property<int>("AviaoId");

                    b.Property<DateTime>("DataIda");

                    b.Property<DateTime>("DataRegresso");

                    b.Property<string>("Destino")
                        .IsRequired();

                    b.Property<string>("Origem")
                        .IsRequired();

                    b.Property<int>("ReservaId");

                    b.HasKey("Id");

                    b.HasIndex("AviaoId");

                    b.HasIndex("ReservaId");

                    b.ToTable("ReservaAviao");
                });

            modelBuilder.Entity("AirBookingESW17.Models.Servico", b =>
                {
                    b.Property<int>("Id")
                        .ValueGeneratedOnAdd();

                    b.Property<int>("AviaoId");

                    b.Property<string>("Descricao")
                        .HasAnnotation("MaxLength", 100);

                    b.Property<decimal>("Preco");

                    b.Property<int>("ReservaId");

                    b.HasKey("Id");

                    b.HasIndex("AviaoId");

                    b.HasIndex("ReservaId");

                    b.ToTable("Servico");
                });

            modelBuilder.Entity("AirBookingESW17.Models.Tripulacao", b =>
                {
                    b.Property<int>("Id")
                        .ValueGeneratedOnAdd();

                    b.Property<string>("Descricao")
                        .HasAnnotation("MaxLength", 50);

                    b.Property<int>("NumeroTripulante");

                    b.HasKey("Id");

                    b.ToTable("Tripulacao");
                });

            modelBuilder.Entity("AirBookingESW17.Models.Voo", b =>
                {
                    b.Property<int>("Id")
                        .ValueGeneratedOnAdd();

                    b.Property<int>("CidadeDestinoId");

                    b.Property<int>("CidadeOrigemId")
                        .HasAnnotation("MaxLength", 255);

                    b.Property<DateTime>("DataChegada");

                    b.Property<DateTime>("DataPartida")
                        .HasAnnotation("MaxLength", 255);

                    b.Property<int>("TripulacaoId");

                    b.HasKey("Id");

                    b.HasIndex("TripulacaoId");

                    b.ToTable("Voo");
                });

            modelBuilder.Entity("Microsoft.AspNetCore.Identity.EntityFrameworkCore.IdentityRole", b =>
                {
                    b.Property<string>("Id")
                        .ValueGeneratedOnAdd();

                    b.Property<string>("ConcurrencyStamp")
                        .IsConcurrencyToken();

                    b.Property<string>("Name")
                        .HasAnnotation("MaxLength", 256);

                    b.Property<string>("NormalizedName")
                        .HasAnnotation("MaxLength", 256);

                    b.HasKey("Id");

                    b.HasIndex("NormalizedName")
                        .IsUnique()
                        .HasName("RoleNameIndex");

                    b.ToTable("AspNetRoles");
                });

            modelBuilder.Entity("Microsoft.AspNetCore.Identity.EntityFrameworkCore.IdentityRoleClaim<string>", b =>
                {
                    b.Property<int>("Id")
                        .ValueGeneratedOnAdd();

                    b.Property<string>("ClaimType");

                    b.Property<string>("ClaimValue");

                    b.Property<string>("RoleId")
                        .IsRequired();

                    b.HasKey("Id");

                    b.HasIndex("RoleId");

                    b.ToTable("AspNetRoleClaims");
                });

            modelBuilder.Entity("Microsoft.AspNetCore.Identity.EntityFrameworkCore.IdentityUserClaim<string>", b =>
                {
                    b.Property<int>("Id")
                        .ValueGeneratedOnAdd();

                    b.Property<string>("ClaimType");

                    b.Property<string>("ClaimValue");

                    b.Property<string>("UserId")
                        .IsRequired();

                    b.HasKey("Id");

                    b.HasIndex("UserId");

                    b.ToTable("AspNetUserClaims");
                });

            modelBuilder.Entity("Microsoft.AspNetCore.Identity.EntityFrameworkCore.IdentityUserLogin<string>", b =>
                {
                    b.Property<string>("LoginProvider");

                    b.Property<string>("ProviderKey");

                    b.Property<string>("ProviderDisplayName");

                    b.Property<string>("UserId")
                        .IsRequired();

                    b.HasKey("LoginProvider", "ProviderKey");

                    b.HasIndex("UserId");

                    b.ToTable("AspNetUserLogins");
                });

            modelBuilder.Entity("Microsoft.AspNetCore.Identity.EntityFrameworkCore.IdentityUserRole<string>", b =>
                {
                    b.Property<string>("UserId");

                    b.Property<string>("RoleId");

                    b.HasKey("UserId", "RoleId");

                    b.HasIndex("RoleId");

                    b.ToTable("AspNetUserRoles");
                });

            modelBuilder.Entity("Microsoft.AspNetCore.Identity.EntityFrameworkCore.IdentityUserToken<string>", b =>
                {
                    b.Property<string>("UserId");

                    b.Property<string>("LoginProvider");

                    b.Property<string>("Name");

                    b.Property<string>("Value");

                    b.HasKey("UserId", "LoginProvider", "Name");

                    b.ToTable("AspNetUserTokens");
                });

            modelBuilder.Entity("AirBookingESW17.Models.Aviao", b =>
                {
                    b.HasOne("AirBookingESW17.Models.Frota", "Frotas")
                        .WithMany("Avioes")
                        .HasForeignKey("FrotaId");

                    b.HasOne("AirBookingESW17.Models.Voo", "Voos")
                        .WithMany()
                        .HasForeignKey("VooId");
                });

            modelBuilder.Entity("AirBookingESW17.Models.CidadeDestino", b =>
                {
                    b.HasOne("AirBookingESW17.Models.Voo")
                        .WithMany("Destino")
                        .HasForeignKey("VooId");
                });

            modelBuilder.Entity("AirBookingESW17.Models.CidadeOrigem", b =>
                {
                    b.HasOne("AirBookingESW17.Models.Voo")
                        .WithMany("Origem")
                        .HasForeignKey("VooId");
                });

            modelBuilder.Entity("AirBookingESW17.Models.Configuracao", b =>
                {
                    b.HasOne("AirBookingESW17.Models.ApplicationUser", "Users")
                        .WithMany()
                        .HasForeignKey("UsersId");
                });

            modelBuilder.Entity("AirBookingESW17.Models.ContaNotificacao", b =>
                {
                    b.HasOne("AirBookingESW17.Models.Notificacao", "Notificacoes")
                        .WithMany("ContaNotif")
                        .HasForeignKey("NotificacaoId");

                    b.HasOne("AirBookingESW17.Models.ApplicationUser", "User")
                        .WithMany("ContaNotificacao")
                        .HasForeignKey("UserId");
                });

            modelBuilder.Entity("AirBookingESW17.Models.Notificacao", b =>
                {
                    b.HasOne("AirBookingESW17.Models.Newsletter", "NewsLetters")
                        .WithMany()
                        .HasForeignKey("NewsletterId");
                });

            modelBuilder.Entity("AirBookingESW17.Models.Reserva", b =>
                {
                    b.HasOne("AirBookingESW17.Models.ApplicationUser", "User")
                        .WithMany("Reservas")
                        .HasForeignKey("UserId");

                    b.HasOne("AirBookingESW17.Models.Voo", "Voos")
                        .WithMany("Reservas")
                        .HasForeignKey("VooId");
                });

            modelBuilder.Entity("AirBookingESW17.Models.ReservaAviao", b =>
                {
                    b.HasOne("AirBookingESW17.Models.Aviao", "Avioes")
                        .WithMany("ReservaAviao")
                        .HasForeignKey("AviaoId");

                    b.HasOne("AirBookingESW17.Models.Reserva", "Reservas")
                        .WithMany("ResAvioes")
                        .HasForeignKey("ReservaId");
                });

            modelBuilder.Entity("AirBookingESW17.Models.Servico", b =>
                {
                    b.HasOne("AirBookingESW17.Models.Aviao", "Avioes")
                        .WithMany("Servicos")
                        .HasForeignKey("AviaoId");

                    b.HasOne("AirBookingESW17.Models.Reserva", "Reservas")
                        .WithMany("Servicos")
                        .HasForeignKey("ReservaId");
                });

            modelBuilder.Entity("AirBookingESW17.Models.Voo", b =>
                {
                    b.HasOne("AirBookingESW17.Models.Tripulacao", "Tripulacao")
                        .WithMany("Voos")
                        .HasForeignKey("TripulacaoId");
                });

            modelBuilder.Entity("Microsoft.AspNetCore.Identity.EntityFrameworkCore.IdentityRoleClaim<string>", b =>
                {
                    b.HasOne("Microsoft.AspNetCore.Identity.EntityFrameworkCore.IdentityRole")
                        .WithMany("Claims")
                        .HasForeignKey("RoleId");
                });

            modelBuilder.Entity("Microsoft.AspNetCore.Identity.EntityFrameworkCore.IdentityUserClaim<string>", b =>
                {
                    b.HasOne("AirBookingESW17.Models.ApplicationUser")
                        .WithMany("Claims")
                        .HasForeignKey("UserId");
                });

            modelBuilder.Entity("Microsoft.AspNetCore.Identity.EntityFrameworkCore.IdentityUserLogin<string>", b =>
                {
                    b.HasOne("AirBookingESW17.Models.ApplicationUser")
                        .WithMany("Logins")
                        .HasForeignKey("UserId");
                });

            modelBuilder.Entity("Microsoft.AspNetCore.Identity.EntityFrameworkCore.IdentityUserRole<string>", b =>
                {
                    b.HasOne("Microsoft.AspNetCore.Identity.EntityFrameworkCore.IdentityRole")
                        .WithMany("Users")
                        .HasForeignKey("RoleId");

                    b.HasOne("AirBookingESW17.Models.ApplicationUser")
                        .WithMany("Roles")
                        .HasForeignKey("UserId");
                });
        }
    }
}
