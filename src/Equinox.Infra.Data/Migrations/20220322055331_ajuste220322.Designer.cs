﻿// <auto-generated />
using System;
using Equinox.Infra.Data.Context;
using Microsoft.EntityFrameworkCore;
using Microsoft.EntityFrameworkCore.Infrastructure;
using Microsoft.EntityFrameworkCore.Metadata;
using Microsoft.EntityFrameworkCore.Migrations;
using Microsoft.EntityFrameworkCore.Storage.ValueConversion;

namespace Equinox.Infra.Data.Migrations
{
    [DbContext(typeof(EquinoxContext))]
    [Migration("20220322055331_ajuste220322")]
    partial class ajuste220322
    {
        protected override void BuildTargetModel(ModelBuilder modelBuilder)
        {
#pragma warning disable 612, 618
            modelBuilder
                .HasAnnotation("ProductVersion", "3.1.4")
                .HasAnnotation("Relational:MaxIdentifierLength", 128)
                .HasAnnotation("SqlServer:ValueGenerationStrategy", SqlServerValueGenerationStrategy.IdentityColumn);

            modelBuilder.Entity("Equinox.Domain.Models.Ativo", b =>
                {
                    b.Property<int>("Id")
                        .ValueGeneratedOnAdd()
                        .HasColumnName("Id")
                        .HasColumnType("int")
                        .HasAnnotation("SqlServer:ValueGenerationStrategy", SqlServerValueGenerationStrategy.IdentityColumn);

                    b.Property<DateTime?>("DataCadastro")
                        .HasColumnType("datetime2");

                    b.Property<string>("Descricao")
                        .IsRequired()
                        .HasColumnType("varchar(150)")
                        .HasMaxLength(150);

                    b.Property<string>("Sigla")
                        .IsRequired()
                        .HasColumnType("varchar(50)")
                        .HasMaxLength(50);

                    b.Property<decimal>("Valor")
                        .HasColumnType("decimal(18,5)");

                    b.HasKey("Id");

                    b.ToTable("Ativo");

                    b.HasData(
                        new
                        {
                            Id = 1,
                            DataCadastro = new DateTime(2022, 3, 22, 2, 53, 30, 565, DateTimeKind.Local).AddTicks(7278),
                            Descricao = "PETR4",
                            Sigla = "PETR4",
                            Valor = 28.44m
                        },
                        new
                        {
                            Id = 2,
                            DataCadastro = new DateTime(2022, 3, 22, 2, 53, 30, 568, DateTimeKind.Local).AddTicks(44),
                            Descricao = "SANB11",
                            Sigla = "SANB11",
                            Valor = 40.77m
                        },
                        new
                        {
                            Id = 3,
                            DataCadastro = new DateTime(2022, 3, 22, 2, 53, 30, 568, DateTimeKind.Local).AddTicks(92),
                            Descricao = "AZUL4",
                            Sigla = "AZUL4",
                            Valor = 22.23m
                        },
                        new
                        {
                            Id = 4,
                            DataCadastro = new DateTime(2022, 3, 22, 2, 53, 30, 568, DateTimeKind.Local).AddTicks(98),
                            Descricao = "ALPA4",
                            Sigla = "ALPA4",
                            Valor = 25.25m
                        },
                        new
                        {
                            Id = 5,
                            DataCadastro = new DateTime(2022, 3, 22, 2, 53, 30, 568, DateTimeKind.Local).AddTicks(103),
                            Descricao = "BBDC3",
                            Sigla = "BBDC3",
                            Valor = 17.50m
                        },
                        new
                        {
                            Id = 6,
                            DataCadastro = new DateTime(2022, 3, 22, 2, 53, 30, 568, DateTimeKind.Local).AddTicks(106),
                            Descricao = "CMIG3",
                            Sigla = "CMIG3",
                            Valor = 19.18m
                        },
                        new
                        {
                            Id = 7,
                            DataCadastro = new DateTime(2022, 3, 22, 2, 53, 30, 568, DateTimeKind.Local).AddTicks(110),
                            Descricao = "ELET3",
                            Sigla = "ELET3",
                            Valor = 35.28m
                        },
                        new
                        {
                            Id = 8,
                            DataCadastro = new DateTime(2022, 3, 22, 2, 53, 30, 568, DateTimeKind.Local).AddTicks(114),
                            Descricao = "EMBR3",
                            Sigla = "EMBR3",
                            Valor = 15.28m
                        },
                        new
                        {
                            Id = 9,
                            DataCadastro = new DateTime(2022, 3, 22, 2, 53, 30, 568, DateTimeKind.Local).AddTicks(118),
                            Descricao = "EQTL3",
                            Sigla = "EQTL3",
                            Valor = 26.81m
                        },
                        new
                        {
                            Id = 10,
                            DataCadastro = new DateTime(2022, 3, 22, 2, 53, 30, 568, DateTimeKind.Local).AddTicks(121),
                            Descricao = "ENEV3",
                            Sigla = "ENEV3",
                            Valor = 13.71m
                        });
                });

            modelBuilder.Entity("Equinox.Domain.Models.Movimento", b =>
                {
                    b.Property<int>("Id")
                        .ValueGeneratedOnAdd()
                        .HasColumnName("Id")
                        .HasColumnType("int")
                        .HasAnnotation("SqlServer:ValueGenerationStrategy", SqlServerValueGenerationStrategy.IdentityColumn);

                    b.Property<string>("AgenciaDestino")
                        .HasColumnType("varchar(10)")
                        .HasMaxLength(10);

                    b.Property<string>("AgenciaOrigem")
                        .HasColumnType("varchar(10)")
                        .HasMaxLength(10);

                    b.Property<string>("BancoDestino")
                        .HasColumnType("varchar(10)")
                        .HasMaxLength(10);

                    b.Property<string>("BancoOrigem")
                        .HasColumnType("varchar(10)")
                        .HasMaxLength(10);

                    b.Property<string>("ContaDestino")
                        .HasColumnType("varchar(10)")
                        .HasMaxLength(10);

                    b.Property<string>("CpfOrigem")
                        .HasColumnType("varchar(15)")
                        .HasMaxLength(15);

                    b.Property<DateTime?>("DataCadastro")
                        .HasColumnType("datetime");

                    b.Property<string>("Evento")
                        .HasColumnType("varchar(25)")
                        .HasMaxLength(25);

                    b.Property<int>("UsuarioId")
                        .HasColumnName("UsuarioId")
                        .HasColumnType("int");

                    b.Property<decimal>("Valor")
                        .HasColumnType("decimal(18,5)");

                    b.HasKey("Id");

                    b.HasIndex("UsuarioId");

                    b.ToTable("Movimento");
                });

            modelBuilder.Entity("Equinox.Domain.Models.Usuario", b =>
                {
                    b.Property<int>("Id")
                        .ValueGeneratedOnAdd()
                        .HasColumnName("Id")
                        .HasColumnType("int")
                        .HasAnnotation("SqlServer:ValueGenerationStrategy", SqlServerValueGenerationStrategy.IdentityColumn);

                    b.Property<string>("CodConta")
                        .HasColumnType("varchar(6)");

                    b.Property<string>("Cpf")
                        .IsRequired()
                        .HasColumnType("varchar(20)")
                        .HasMaxLength(20);

                    b.Property<DateTime?>("DataCadastro")
                        .HasColumnType("datetime");

                    b.Property<string>("Email")
                        .HasColumnType("varchar(150)")
                        .HasMaxLength(150);

                    b.Property<string>("Nome")
                        .IsRequired()
                        .HasColumnType("varchar(150)")
                        .HasMaxLength(150);

                    b.Property<decimal>("Saldo")
                        .HasColumnType("decimal(18,5)");

                    b.Property<string>("Senha")
                        .IsRequired()
                        .HasColumnType("varchar(25)")
                        .HasMaxLength(25);

                    b.HasKey("Id");

                    b.ToTable("Usuario");

                    b.HasData(
                        new
                        {
                            Id = 2,
                            CodConta = "000002",
                            Cpf = "12345678901",
                            DataCadastro = new DateTime(2022, 3, 22, 2, 53, 30, 569, DateTimeKind.Local).AddTicks(1105),
                            Email = "email@gmail.com",
                            Nome = "Teste2",
                            Saldo = 100m,
                            Senha = "1234"
                        },
                        new
                        {
                            Id = 3,
                            CodConta = "000003",
                            Cpf = "12345678901",
                            DataCadastro = new DateTime(2022, 3, 22, 2, 53, 30, 569, DateTimeKind.Local).AddTicks(5027),
                            Email = "email@gmail.com",
                            Nome = "Teste2",
                            Saldo = 100m,
                            Senha = "1234"
                        },
                        new
                        {
                            Id = 4,
                            CodConta = "000004",
                            Cpf = "12345678901",
                            DataCadastro = new DateTime(2022, 3, 22, 2, 53, 30, 569, DateTimeKind.Local).AddTicks(5045),
                            Email = "email@gmail.com",
                            Nome = "Teste2",
                            Saldo = 100m,
                            Senha = "1234"
                        },
                        new
                        {
                            Id = 5,
                            CodConta = "000005",
                            Cpf = "12345678901",
                            DataCadastro = new DateTime(2022, 3, 22, 2, 53, 30, 569, DateTimeKind.Local).AddTicks(5048),
                            Email = "email@gmail.com",
                            Nome = "Teste2",
                            Saldo = 100m,
                            Senha = "1234"
                        },
                        new
                        {
                            Id = 6,
                            CodConta = "000006",
                            Cpf = "12345678901",
                            DataCadastro = new DateTime(2022, 3, 22, 2, 53, 30, 569, DateTimeKind.Local).AddTicks(5052),
                            Email = "email@gmail.com",
                            Nome = "Teste2",
                            Saldo = 100m,
                            Senha = "1234"
                        },
                        new
                        {
                            Id = 7,
                            CodConta = "000007",
                            Cpf = "12345678901",
                            DataCadastro = new DateTime(2022, 3, 22, 2, 53, 30, 569, DateTimeKind.Local).AddTicks(5057),
                            Email = "email@gmail.com",
                            Nome = "Teste2",
                            Saldo = 100m,
                            Senha = "1234"
                        },
                        new
                        {
                            Id = 8,
                            CodConta = "000008",
                            Cpf = "12345678901",
                            DataCadastro = new DateTime(2022, 3, 22, 2, 53, 30, 569, DateTimeKind.Local).AddTicks(5060),
                            Email = "email@gmail.com",
                            Nome = "Teste2",
                            Saldo = 100m,
                            Senha = "1234"
                        },
                        new
                        {
                            Id = 9,
                            CodConta = "000009",
                            Cpf = "12345678901",
                            DataCadastro = new DateTime(2022, 3, 22, 2, 53, 30, 569, DateTimeKind.Local).AddTicks(5062),
                            Email = "email@gmail.com",
                            Nome = "Teste2",
                            Saldo = 100m,
                            Senha = "1234"
                        });
                });

            modelBuilder.Entity("Equinox.Domain.Models.UsuarioAtivo", b =>
                {
                    b.Property<int>("Id")
                        .ValueGeneratedOnAdd()
                        .HasColumnName("Id")
                        .HasColumnType("int")
                        .HasAnnotation("SqlServer:ValueGenerationStrategy", SqlServerValueGenerationStrategy.IdentityColumn);

                    b.Property<int>("AtivoId")
                        .HasColumnName("AtivoId")
                        .HasColumnType("int");

                    b.Property<DateTime?>("DataCadastro")
                        .HasColumnType("datetime");

                    b.Property<int>("Quantidade")
                        .HasColumnType("int");

                    b.Property<int>("UsuarioId")
                        .HasColumnName("UsuarioId")
                        .HasColumnType("int");

                    b.HasKey("Id");

                    b.HasIndex("AtivoId");

                    b.HasIndex("UsuarioId");

                    b.ToTable("UsuarioAtivo");

                    b.HasData(
                        new
                        {
                            Id = 3,
                            AtivoId = 1,
                            DataCadastro = new DateTime(2022, 3, 22, 2, 53, 30, 569, DateTimeKind.Local).AddTicks(5293),
                            Quantidade = 3,
                            UsuarioId = 2
                        },
                        new
                        {
                            Id = 4,
                            AtivoId = 3,
                            DataCadastro = new DateTime(2022, 3, 22, 2, 53, 30, 569, DateTimeKind.Local).AddTicks(8267),
                            Quantidade = 2,
                            UsuarioId = 2
                        },
                        new
                        {
                            Id = 5,
                            AtivoId = 1,
                            DataCadastro = new DateTime(2022, 3, 22, 2, 53, 30, 569, DateTimeKind.Local).AddTicks(8283),
                            Quantidade = 3,
                            UsuarioId = 3
                        },
                        new
                        {
                            Id = 6,
                            AtivoId = 3,
                            DataCadastro = new DateTime(2022, 3, 22, 2, 53, 30, 569, DateTimeKind.Local).AddTicks(8286),
                            Quantidade = 2,
                            UsuarioId = 3
                        },
                        new
                        {
                            Id = 7,
                            AtivoId = 5,
                            DataCadastro = new DateTime(2022, 3, 22, 2, 53, 30, 569, DateTimeKind.Local).AddTicks(8289),
                            Quantidade = 3,
                            UsuarioId = 3
                        },
                        new
                        {
                            Id = 8,
                            AtivoId = 6,
                            DataCadastro = new DateTime(2022, 3, 22, 2, 53, 30, 569, DateTimeKind.Local).AddTicks(8291),
                            Quantidade = 2,
                            UsuarioId = 3
                        },
                        new
                        {
                            Id = 9,
                            AtivoId = 7,
                            DataCadastro = new DateTime(2022, 3, 22, 2, 53, 30, 569, DateTimeKind.Local).AddTicks(8293),
                            Quantidade = 3,
                            UsuarioId = 5
                        },
                        new
                        {
                            Id = 10,
                            AtivoId = 8,
                            DataCadastro = new DateTime(2022, 3, 22, 2, 53, 30, 569, DateTimeKind.Local).AddTicks(8296),
                            Quantidade = 2,
                            UsuarioId = 5
                        });
                });

            modelBuilder.Entity("Equinox.Domain.Models.Movimento", b =>
                {
                    b.HasOne("Equinox.Domain.Models.Usuario", "Usuario")
                        .WithMany("Movimento")
                        .HasForeignKey("UsuarioId")
                        .OnDelete(DeleteBehavior.Cascade)
                        .IsRequired();
                });

            modelBuilder.Entity("Equinox.Domain.Models.UsuarioAtivo", b =>
                {
                    b.HasOne("Equinox.Domain.Models.Ativo", "Ativo")
                        .WithMany("UsuarioAtivo")
                        .HasForeignKey("AtivoId")
                        .OnDelete(DeleteBehavior.Cascade)
                        .IsRequired();

                    b.HasOne("Equinox.Domain.Models.Usuario", "Usuario")
                        .WithMany("UsuarioAtivo")
                        .HasForeignKey("UsuarioId")
                        .OnDelete(DeleteBehavior.Cascade)
                        .IsRequired();
                });
#pragma warning restore 612, 618
        }
    }
}