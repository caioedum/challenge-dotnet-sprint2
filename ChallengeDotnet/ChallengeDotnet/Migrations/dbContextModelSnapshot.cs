﻿// <auto-generated />
using System;
using ChallengeDotnet.Data;
using Microsoft.EntityFrameworkCore;
using Microsoft.EntityFrameworkCore.Infrastructure;
using Microsoft.EntityFrameworkCore.Storage.ValueConversion;
using Oracle.EntityFrameworkCore.Metadata;

#nullable disable

namespace ChallengeDotnet.Migrations
{
    [DbContext(typeof(dbContext))]
    partial class dbContextModelSnapshot : ModelSnapshot
    {
        protected override void BuildModel(ModelBuilder modelBuilder)
        {
#pragma warning disable 612, 618
            modelBuilder
                .HasAnnotation("ProductVersion", "8.0.8")
                .HasAnnotation("Relational:MaxIdentifierLength", 128);

            OracleModelBuilderExtensions.UseIdentityColumns(modelBuilder);

            modelBuilder.Entity("ChallengeDotnet.Models.Atendimento", b =>
                {
                    b.Property<int>("AtendimentoId")
                        .ValueGeneratedOnAdd()
                        .HasColumnType("NUMBER(10)")
                        .HasColumnName("ATENDIMENTO_ID");

                    OraclePropertyBuilderExtensions.UseIdentityColumn(b.Property<int>("AtendimentoId"));

                    b.Property<string>("ClinicaNome")
                        .IsRequired()
                        .HasMaxLength(100)
                        .HasColumnType("NVARCHAR2(100)")
                        .HasColumnName("CLINICA_NOME");

                    b.Property<decimal?>("Custo")
                        .HasColumnType("DECIMAL(18, 2)")
                        .HasColumnName("CUSTO");

                    b.Property<DateTime>("DataAtendimento")
                        .HasColumnType("TIMESTAMP(7)")
                        .HasColumnName("DATA_ATENDIMENTO");

                    b.Property<DateTime>("DataRegistro")
                        .HasColumnType("TIMESTAMP(7)")
                        .HasColumnName("DATA_REGISTRO");

                    b.Property<string>("DentistaNome")
                        .IsRequired()
                        .HasMaxLength(100)
                        .HasColumnType("NVARCHAR2(100)")
                        .HasColumnName("DENTISTA_NOME");

                    b.Property<string>("DescricaoProcedimento")
                        .HasColumnType("NVARCHAR2(2000)")
                        .HasColumnName("DESCRICAO_PROCEDIMENTO");

                    b.Property<int?>("UsuarioId")
                        .IsRequired()
                        .HasMaxLength(10)
                        .HasColumnType("NUMBER(10)")
                        .HasColumnName("USUARIO_ID");

                    b.HasKey("AtendimentoId");

                    b.HasIndex("UsuarioId");

                    b.ToTable("T_ATENDIMENTO_USUARIO_ODONTOPREV");
                });

            modelBuilder.Entity("ChallengeDotnet.Models.Imagem", b =>
                {
                    b.Property<int>("ImagemUsuarioId")
                        .ValueGeneratedOnAdd()
                        .HasColumnType("NUMBER(10)")
                        .HasColumnName("IMAGEM_USUARIO_ID");

                    OraclePropertyBuilderExtensions.UseIdentityColumn(b.Property<int>("ImagemUsuarioId"));

                    b.Property<DateTime?>("DataEnvio")
                        .HasColumnType("TIMESTAMP(7)")
                        .HasColumnName("DATA_ENVIO");

                    b.Property<string>("ImagemUrl")
                        .HasMaxLength(255)
                        .HasColumnType("NVARCHAR2(255)")
                        .HasColumnName("IMAGEM_URL");

                    b.Property<int?>("UsuarioId")
                        .IsRequired()
                        .HasMaxLength(10)
                        .HasColumnType("NUMBER(10)")
                        .HasColumnName("USUARIO_ID");

                    b.HasKey("ImagemUsuarioId");

                    b.HasIndex("UsuarioId");

                    b.ToTable("T_IMAGEM_USUARIO_ODONTOPREV");
                });

            modelBuilder.Entity("ChallengeDotnet.Models.Previsao", b =>
                {
                    b.Property<int>("PrevisaoUsuarioId")
                        .ValueGeneratedOnAdd()
                        .HasColumnType("NUMBER(10)")
                        .HasColumnName("PREVISAO_USUARIO_ID");

                    OraclePropertyBuilderExtensions.UseIdentityColumn(b.Property<int>("PrevisaoUsuarioId"));

                    b.Property<DateTime?>("DataPrevisao")
                        .HasColumnType("TIMESTAMP(7)")
                        .HasColumnName("DATA_PREVISAO");

                    b.Property<int?>("ImagemUsuarioId")
                        .IsRequired()
                        .HasColumnType("NUMBER(10)")
                        .HasColumnName("IMAGEM_USUARIO_ID");

                    b.Property<string>("PrevisaoTexto")
                        .IsRequired()
                        .HasMaxLength(255)
                        .HasColumnType("NVARCHAR2(255)")
                        .HasColumnName("PREVISAO_TEXTO");

                    b.Property<float?>("Probabilidade")
                        .HasColumnType("BINARY_FLOAT")
                        .HasColumnName("PROBABILIDADE");

                    b.Property<string>("Recomendacao")
                        .IsRequired()
                        .HasMaxLength(255)
                        .HasColumnType("NVARCHAR2(255)")
                        .HasColumnName("RECOMENDACAO");

                    b.Property<int?>("UsuarioId")
                        .IsRequired()
                        .HasColumnType("NUMBER(10)")
                        .HasColumnName("USUARIO_ID");

                    b.HasKey("PrevisaoUsuarioId");

                    b.HasIndex("ImagemUsuarioId");

                    b.HasIndex("UsuarioId");

                    b.ToTable("T_PREVISAO_USUARIO_ODONTOPREV");
                });

            modelBuilder.Entity("ChallengeDotnet.Models.Usuario", b =>
                {
                    b.Property<int>("UsuarioId")
                        .ValueGeneratedOnAdd()
                        .HasColumnType("NUMBER(10)")
                        .HasColumnName("USUARIO_ID");

                    OraclePropertyBuilderExtensions.UseIdentityColumn(b.Property<int>("UsuarioId"));

                    b.Property<string>("CPF")
                        .IsRequired()
                        .HasMaxLength(14)
                        .HasColumnType("NVARCHAR2(14)")
                        .HasColumnName("CPF");

                    b.Property<DateTime?>("DataCadastro")
                        .HasColumnType("TIMESTAMP(7)")
                        .HasColumnName("DATA_CADASTRO");

                    b.Property<DateTime>("DataNascimento")
                        .HasColumnType("TIMESTAMP(7)")
                        .HasColumnName("DATA_NASCIMENTO");

                    b.Property<string>("Email")
                        .IsRequired()
                        .HasMaxLength(255)
                        .HasColumnType("NVARCHAR2(255)")
                        .HasColumnName("EMAIL");

                    b.Property<string>("Genero")
                        .IsRequired()
                        .HasMaxLength(1)
                        .HasColumnType("NVARCHAR2(1)")
                        .HasColumnName("GENERO");

                    b.Property<string>("Nome")
                        .IsRequired()
                        .HasMaxLength(100)
                        .HasColumnType("NVARCHAR2(100)")
                        .HasColumnName("NOME");

                    b.Property<string>("Senha")
                        .IsRequired()
                        .HasMaxLength(255)
                        .HasColumnType("NVARCHAR2(255)")
                        .HasColumnName("SENHA");

                    b.Property<string>("Sobrenome")
                        .IsRequired()
                        .HasMaxLength(255)
                        .HasColumnType("NVARCHAR2(255)")
                        .HasColumnName("SOBRENOME");

                    b.HasKey("UsuarioId");

                    b.ToTable("T_USUARIO_ODONTOPREV");
                });

            modelBuilder.Entity("ChallengeDotnet.Models.Atendimento", b =>
                {
                    b.HasOne("ChallengeDotnet.Models.Usuario", "Usuario")
                        .WithMany()
                        .HasForeignKey("UsuarioId")
                        .OnDelete(DeleteBehavior.Cascade)
                        .IsRequired();

                    b.Navigation("Usuario");
                });

            modelBuilder.Entity("ChallengeDotnet.Models.Imagem", b =>
                {
                    b.HasOne("ChallengeDotnet.Models.Usuario", "Usuario")
                        .WithMany()
                        .HasForeignKey("UsuarioId")
                        .OnDelete(DeleteBehavior.Cascade)
                        .IsRequired();

                    b.Navigation("Usuario");
                });

            modelBuilder.Entity("ChallengeDotnet.Models.Previsao", b =>
                {
                    b.HasOne("ChallengeDotnet.Models.Imagem", "ImagemUsuario")
                        .WithMany()
                        .HasForeignKey("ImagemUsuarioId")
                        .OnDelete(DeleteBehavior.Cascade)
                        .IsRequired();

                    b.HasOne("ChallengeDotnet.Models.Usuario", "Usuario")
                        .WithMany()
                        .HasForeignKey("UsuarioId")
                        .OnDelete(DeleteBehavior.Cascade)
                        .IsRequired();

                    b.Navigation("ImagemUsuario");

                    b.Navigation("Usuario");
                });
#pragma warning restore 612, 618
        }
    }
}
