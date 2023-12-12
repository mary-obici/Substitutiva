﻿// <auto-generated />
using System;
using Microsoft.EntityFrameworkCore;
using Microsoft.EntityFrameworkCore.Infrastructure;
using Microsoft.EntityFrameworkCore.Migrations;
using Microsoft.EntityFrameworkCore.Storage.ValueConversion;
using projeto.Data;

#nullable disable

namespace projeto.Migrations
{
    [DbContext(typeof(AppDataContext))]
    [Migration("20231211231017_migracao")]
    partial class migracao
    {
        protected override void BuildTargetModel(ModelBuilder modelBuilder)
        {
#pragma warning disable 612, 618
            modelBuilder.HasAnnotation("ProductVersion", "6.0.21");

            modelBuilder.Entity("projeto.Models.Aluno", b =>
                {
                    b.Property<int?>("AlunoId")
                        .ValueGeneratedOnAdd()
                        .HasColumnType("INTEGER");

                    b.Property<string>("Nasc")
                        .HasColumnType("TEXT");

                    b.Property<string>("Nome")
                        .HasColumnType("TEXT");

                    b.HasKey("AlunoId");

                    b.ToTable("Alunos");
                });
#pragma warning restore 612, 618
        }
    }
}