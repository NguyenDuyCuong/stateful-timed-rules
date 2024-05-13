﻿// <auto-generated />
using System;
using Microsoft.EntityFrameworkCore;
using Microsoft.EntityFrameworkCore.Infrastructure;
using Microsoft.EntityFrameworkCore.Migrations;
using Microsoft.EntityFrameworkCore.Storage.ValueConversion;

#nullable disable

namespace using_rules_engine.Migrations
{
    [DbContext(typeof(RulesDemoContext))]
    [Migration("20240510190053_AddFlightLogModel")]
    partial class AddFlightLogModel
    {
        /// <inheritdoc />
        protected override void BuildTargetModel(ModelBuilder modelBuilder)
        {
#pragma warning disable 612, 618
            modelBuilder.HasAnnotation("ProductVersion", "8.0.4");

            modelBuilder.Entity("FlightLog", b =>
                {
                    b.Property<int>("Id")
                        .ValueGeneratedOnAdd()
                        .HasColumnType("INTEGER");

                    b.Property<bool>("Augmented")
                        .HasColumnType("INTEGER");

                    b.Property<bool>("ETOPS")
                        .HasColumnType("INTEGER");

                    b.Property<DateTime>("FlightDate")
                        .HasColumnType("TEXT");

                    b.Property<int>("FlightHours")
                        .HasColumnType("INTEGER");

                    b.Property<string>("FlightNumber")
                        .IsRequired()
                        .HasColumnType("TEXT");

                    b.Property<bool>("Landing")
                        .HasColumnType("INTEGER");

                    b.Property<string>("LandingLocation")
                        .HasColumnType("TEXT");

                    b.Property<string>("Rank")
                        .HasColumnType("TEXT");

                    b.Property<bool>("RightSeat")
                        .HasColumnType("INTEGER");

                    b.Property<string>("Role")
                        .HasColumnType("TEXT");

                    b.Property<bool>("TakeOff")
                        .HasColumnType("INTEGER");

                    b.Property<string>("TakeOffLocation")
                        .HasColumnType("TEXT");

                    b.Property<string>("Training")
                        .HasColumnType("TEXT");

                    b.HasKey("Id");

                    b.ToTable("FlightLogs");
                });

            modelBuilder.Entity("RulesEngine.Models.Rule", b =>
                {
                    b.Property<string>("RuleName")
                        .HasColumnType("TEXT");

                    b.Property<string>("Actions")
                        .HasColumnType("TEXT");

                    b.Property<bool>("Enabled")
                        .HasColumnType("INTEGER");

                    b.Property<string>("ErrorMessage")
                        .HasColumnType("TEXT");

                    b.Property<string>("Expression")
                        .HasColumnType("TEXT");

                    b.Property<string>("Operator")
                        .HasColumnType("TEXT");

                    b.Property<string>("Properties")
                        .HasColumnType("TEXT");

                    b.Property<int>("RuleExpressionType")
                        .HasColumnType("INTEGER");

                    b.Property<string>("RuleNameFK")
                        .HasColumnType("TEXT");

                    b.Property<string>("SuccessEvent")
                        .HasColumnType("TEXT");

                    b.Property<string>("WorkflowName")
                        .HasColumnType("TEXT");

                    b.HasKey("RuleName");

                    b.HasIndex("RuleNameFK");

                    b.HasIndex("WorkflowName");

                    b.ToTable("Rules");
                });

            modelBuilder.Entity("RulesEngine.Models.ScopedParam", b =>
                {
                    b.Property<string>("Name")
                        .HasColumnType("TEXT");

                    b.Property<string>("Expression")
                        .HasColumnType("TEXT");

                    b.Property<string>("RuleName")
                        .HasColumnType("TEXT");

                    b.Property<string>("WorkflowName")
                        .HasColumnType("TEXT");

                    b.HasKey("Name");

                    b.HasIndex("RuleName");

                    b.HasIndex("WorkflowName");

                    b.ToTable("ScopedParam");
                });

            modelBuilder.Entity("RulesEngine.Models.Workflow", b =>
                {
                    b.Property<string>("WorkflowName")
                        .HasColumnType("TEXT");

                    b.Property<int>("RuleExpressionType")
                        .HasColumnType("INTEGER");

                    b.HasKey("WorkflowName");

                    b.ToTable("Workflows");
                });

            modelBuilder.Entity("State", b =>
                {
                    b.Property<int>("Id")
                        .ValueGeneratedOnAdd()
                        .HasColumnType("INTEGER");

                    b.Property<string>("Result")
                        .HasColumnType("TEXT");

                    b.HasKey("Id");

                    b.ToTable("States");
                });

            modelBuilder.Entity("User", b =>
                {
                    b.Property<int>("Id")
                        .ValueGeneratedOnAdd()
                        .HasColumnType("INTEGER");

                    b.Property<string>("Name")
                        .HasColumnType("TEXT");

                    b.HasKey("Id");

                    b.ToTable("Users");

                    b.HasData(
                        new
                        {
                            Id = 1,
                            Name = "Lorem"
                        });
                });

            modelBuilder.Entity("RulesEngine.Models.Rule", b =>
                {
                    b.HasOne("RulesEngine.Models.Rule", null)
                        .WithMany("Rules")
                        .HasForeignKey("RuleNameFK");

                    b.HasOne("RulesEngine.Models.Workflow", null)
                        .WithMany("Rules")
                        .HasForeignKey("WorkflowName");
                });

            modelBuilder.Entity("RulesEngine.Models.ScopedParam", b =>
                {
                    b.HasOne("RulesEngine.Models.Rule", null)
                        .WithMany("LocalParams")
                        .HasForeignKey("RuleName");

                    b.HasOne("RulesEngine.Models.Workflow", null)
                        .WithMany("GlobalParams")
                        .HasForeignKey("WorkflowName");
                });

            modelBuilder.Entity("RulesEngine.Models.Rule", b =>
                {
                    b.Navigation("LocalParams");

                    b.Navigation("Rules");
                });

            modelBuilder.Entity("RulesEngine.Models.Workflow", b =>
                {
                    b.Navigation("GlobalParams");

                    b.Navigation("Rules");
                });
#pragma warning restore 612, 618
        }
    }
}
