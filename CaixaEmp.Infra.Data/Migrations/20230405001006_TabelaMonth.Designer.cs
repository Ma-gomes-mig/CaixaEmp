﻿// <auto-generated />
using System;
using CaixaEmp.Infra.Data.Context;
using Microsoft.EntityFrameworkCore;
using Microsoft.EntityFrameworkCore.Infrastructure;
using Microsoft.EntityFrameworkCore.Metadata;
using Microsoft.EntityFrameworkCore.Migrations;
using Microsoft.EntityFrameworkCore.Storage.ValueConversion;

#nullable disable

namespace CaixaEmp.Infra.Data.Migrations
{
    [DbContext(typeof(ApplicationDbContext))]
    [Migration("20230405001006_TabelaMonth")]
    partial class TabelaMonth
    {
        /// <inheritdoc />
        protected override void BuildTargetModel(ModelBuilder modelBuilder)
        {
#pragma warning disable 612, 618
            modelBuilder
                .HasAnnotation("ProductVersion", "7.0.4")
                .HasAnnotation("Relational:MaxIdentifierLength", 128);

            SqlServerModelBuilderExtensions.UseIdentityColumns(modelBuilder);

            modelBuilder.Entity("CaixaEmp.Domain.Entities.Balance", b =>
                {
                    b.Property<int>("Id")
                        .ValueGeneratedOnAdd()
                        .HasColumnType("int");

                    SqlServerPropertyBuilderExtensions.UseIdentityColumn(b.Property<int>("Id"));

                    b.Property<DateTime>("Date")
                        .HasColumnType("datetime2");

                    b.Property<decimal>("Value")
                        .HasPrecision(10, 2)
                        .HasColumnType("decimal(10,2)");

                    b.HasKey("Id");

                    b.ToTable("Balances");
                });

            modelBuilder.Entity("CaixaEmp.Domain.Entities.Emplooyer", b =>
                {
                    b.Property<int>("Id")
                        .ValueGeneratedOnAdd()
                        .HasColumnType("int");

                    SqlServerPropertyBuilderExtensions.UseIdentityColumn(b.Property<int>("Id"));

                    b.Property<string>("Name")
                        .IsRequired()
                        .HasMaxLength(50)
                        .HasColumnType("nvarchar(50)");

                    b.Property<string>("Office")
                        .IsRequired()
                        .HasMaxLength(50)
                        .HasColumnType("nvarchar(50)");

                    b.HasKey("Id");

                    b.ToTable("Emplooyers");
                });

            modelBuilder.Entity("CaixaEmp.Domain.Entities.Expense", b =>
                {
                    b.Property<int>("Id")
                        .ValueGeneratedOnAdd()
                        .HasColumnType("int");

                    SqlServerPropertyBuilderExtensions.UseIdentityColumn(b.Property<int>("Id"));

                    b.Property<string>("Description")
                        .IsRequired()
                        .HasMaxLength(150)
                        .HasColumnType("nvarchar(150)");

                    b.Property<int>("EmplooyerId")
                        .HasColumnType("int");

                    b.Property<int>("ExpenseCategoryId")
                        .HasColumnType("int");

                    b.Property<int>("MonthId")
                        .HasColumnType("int");

                    b.Property<string>("Name")
                        .IsRequired()
                        .HasMaxLength(50)
                        .HasColumnType("nvarchar(50)");

                    b.Property<string>("Priority")
                        .IsRequired()
                        .HasMaxLength(30)
                        .HasColumnType("nvarchar(30)");

                    b.Property<decimal>("Value")
                        .HasPrecision(10, 2)
                        .HasColumnType("decimal(10,2)");

                    b.HasKey("Id");

                    b.HasIndex("EmplooyerId");

                    b.HasIndex("ExpenseCategoryId");

                    b.HasIndex("MonthId");

                    b.ToTable("Expenses");
                });

            modelBuilder.Entity("CaixaEmp.Domain.Entities.ExpenseCategory", b =>
                {
                    b.Property<int>("Id")
                        .ValueGeneratedOnAdd()
                        .HasColumnType("int");

                    SqlServerPropertyBuilderExtensions.UseIdentityColumn(b.Property<int>("Id"));

                    b.Property<string>("Description")
                        .IsRequired()
                        .HasMaxLength(250)
                        .HasColumnType("nvarchar(250)");

                    b.Property<string>("Name")
                        .IsRequired()
                        .HasMaxLength(50)
                        .HasColumnType("nvarchar(50)");

                    b.HasKey("Id");

                    b.ToTable("Categories");
                });

            modelBuilder.Entity("CaixaEmp.Domain.Entities.Inclusion", b =>
                {
                    b.Property<int>("Id")
                        .ValueGeneratedOnAdd()
                        .HasColumnType("int");

                    SqlServerPropertyBuilderExtensions.UseIdentityColumn(b.Property<int>("Id"));

                    b.Property<int>("BalanceId")
                        .HasColumnType("int");

                    b.Property<DateTime>("DateInclusion")
                        .HasColumnType("datetime2");

                    b.Property<string>("Description")
                        .HasMaxLength(150)
                        .HasColumnType("nvarchar(150)");

                    b.Property<int>("EmplooyerId")
                        .HasColumnType("int");

                    b.Property<int>("ExpenseId")
                        .HasColumnType("int");

                    b.Property<string>("Name")
                        .HasColumnType("nvarchar(max)");

                    b.Property<string>("Priority")
                        .HasMaxLength(30)
                        .HasColumnType("nvarchar(30)");

                    b.Property<bool>("Status")
                        .HasMaxLength(30)
                        .HasColumnType("bit");

                    b.Property<decimal>("Value")
                        .HasPrecision(10, 2)
                        .HasColumnType("decimal(10,2)");

                    b.HasKey("Id");

                    b.HasIndex("BalanceId");

                    b.HasIndex("EmplooyerId");

                    b.HasIndex("ExpenseId");

                    b.ToTable("Inclusions");
                });

            modelBuilder.Entity("CaixaEmp.Domain.Entities.Month", b =>
                {
                    b.Property<int>("Id")
                        .ValueGeneratedOnAdd()
                        .HasColumnType("int");

                    SqlServerPropertyBuilderExtensions.UseIdentityColumn(b.Property<int>("Id"));

                    b.Property<string>("Name")
                        .IsRequired()
                        .HasMaxLength(20)
                        .HasColumnType("nvarchar(20)");

                    b.HasKey("Id");

                    b.ToTable("Months");
                });

            modelBuilder.Entity("CaixaEmp.Domain.Entities.Withdrawal", b =>
                {
                    b.Property<int>("Id")
                        .ValueGeneratedOnAdd()
                        .HasColumnType("int");

                    SqlServerPropertyBuilderExtensions.UseIdentityColumn(b.Property<int>("Id"));

                    b.Property<int>("BalanceId")
                        .HasColumnType("int");

                    b.Property<DateTime>("DateWithdrawal")
                        .HasColumnType("datetime2");

                    b.Property<string>("Description")
                        .HasMaxLength(150)
                        .HasColumnType("nvarchar(150)");

                    b.Property<int>("EmplooyerId")
                        .HasColumnType("int");

                    b.Property<int>("ExpenseId")
                        .HasColumnType("int");

                    b.Property<string>("Name")
                        .HasMaxLength(50)
                        .HasColumnType("nvarchar(50)");

                    b.Property<string>("Priority")
                        .HasMaxLength(30)
                        .HasColumnType("nvarchar(30)");

                    b.Property<bool>("Status")
                        .HasMaxLength(30)
                        .HasColumnType("bit");

                    b.Property<decimal>("Value")
                        .HasPrecision(10, 2)
                        .HasColumnType("decimal(10,2)");

                    b.HasKey("Id");

                    b.HasIndex("BalanceId");

                    b.HasIndex("EmplooyerId");

                    b.HasIndex("ExpenseId");

                    b.ToTable("Withdrawals");
                });

            modelBuilder.Entity("CaixaEmp.Domain.Entities.Expense", b =>
                {
                    b.HasOne("CaixaEmp.Domain.Entities.Emplooyer", "Emplooyer")
                        .WithMany("Expenses")
                        .HasForeignKey("EmplooyerId")
                        .OnDelete(DeleteBehavior.Cascade)
                        .IsRequired();

                    b.HasOne("CaixaEmp.Domain.Entities.ExpenseCategory", "ExpenseCategory")
                        .WithMany("Expenses")
                        .HasForeignKey("ExpenseCategoryId")
                        .OnDelete(DeleteBehavior.Cascade)
                        .IsRequired();

                    b.HasOne("CaixaEmp.Domain.Entities.Month", "Month")
                        .WithMany("Expenses")
                        .HasForeignKey("MonthId")
                        .OnDelete(DeleteBehavior.Cascade)
                        .IsRequired();

                    b.Navigation("Emplooyer");

                    b.Navigation("ExpenseCategory");

                    b.Navigation("Month");
                });

            modelBuilder.Entity("CaixaEmp.Domain.Entities.Inclusion", b =>
                {
                    b.HasOne("CaixaEmp.Domain.Entities.Balance", "Balance")
                        .WithMany("Inclusions")
                        .HasForeignKey("BalanceId")
                        .OnDelete(DeleteBehavior.Cascade)
                        .IsRequired();

                    b.HasOne("CaixaEmp.Domain.Entities.Emplooyer", "Emplooyer")
                        .WithMany("Inclusions")
                        .HasForeignKey("EmplooyerId")
                        .OnDelete(DeleteBehavior.Cascade)
                        .IsRequired();

                    b.HasOne("CaixaEmp.Domain.Entities.Expense", "Expense")
                        .WithMany("Inclusions")
                        .HasForeignKey("ExpenseId")
                        .OnDelete(DeleteBehavior.Cascade)
                        .IsRequired();

                    b.Navigation("Balance");

                    b.Navigation("Emplooyer");

                    b.Navigation("Expense");
                });

            modelBuilder.Entity("CaixaEmp.Domain.Entities.Withdrawal", b =>
                {
                    b.HasOne("CaixaEmp.Domain.Entities.Balance", "Balance")
                        .WithMany("Withdrawals")
                        .HasForeignKey("BalanceId")
                        .OnDelete(DeleteBehavior.Cascade)
                        .IsRequired();

                    b.HasOne("CaixaEmp.Domain.Entities.Emplooyer", "Emplooyer")
                        .WithMany("Withdrawals")
                        .HasForeignKey("EmplooyerId")
                        .OnDelete(DeleteBehavior.Cascade)
                        .IsRequired();

                    b.HasOne("CaixaEmp.Domain.Entities.Expense", "Expense")
                        .WithMany("Withdrawals")
                        .HasForeignKey("ExpenseId")
                        .OnDelete(DeleteBehavior.Cascade)
                        .IsRequired();

                    b.Navigation("Balance");

                    b.Navigation("Emplooyer");

                    b.Navigation("Expense");
                });

            modelBuilder.Entity("CaixaEmp.Domain.Entities.Balance", b =>
                {
                    b.Navigation("Inclusions");

                    b.Navigation("Withdrawals");
                });

            modelBuilder.Entity("CaixaEmp.Domain.Entities.Emplooyer", b =>
                {
                    b.Navigation("Expenses");

                    b.Navigation("Inclusions");

                    b.Navigation("Withdrawals");
                });

            modelBuilder.Entity("CaixaEmp.Domain.Entities.Expense", b =>
                {
                    b.Navigation("Inclusions");

                    b.Navigation("Withdrawals");
                });

            modelBuilder.Entity("CaixaEmp.Domain.Entities.ExpenseCategory", b =>
                {
                    b.Navigation("Expenses");
                });

            modelBuilder.Entity("CaixaEmp.Domain.Entities.Month", b =>
                {
                    b.Navigation("Expenses");
                });
#pragma warning restore 612, 618
        }
    }
}
