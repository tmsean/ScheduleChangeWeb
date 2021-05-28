﻿// <auto-generated />
using System;
using Microsoft.EntityFrameworkCore;
using Microsoft.EntityFrameworkCore.Infrastructure;
using Microsoft.EntityFrameworkCore.Metadata;
using Microsoft.EntityFrameworkCore.Migrations;
using Microsoft.EntityFrameworkCore.Storage.ValueConversion;
using ScheduleChange.Repository;

namespace ScheduleChange.Migrations
{
    [DbContext(typeof(SCContext))]
    [Migration("20210528043524_AddConfigTables")]
    partial class AddConfigTables
    {
        protected override void BuildTargetModel(ModelBuilder modelBuilder)
        {
#pragma warning disable 612, 618
            modelBuilder
                .HasAnnotation("Relational:MaxIdentifierLength", 128)
                .HasAnnotation("ProductVersion", "5.0.6")
                .HasAnnotation("SqlServer:ValueGenerationStrategy", SqlServerValueGenerationStrategy.IdentityColumn);

            modelBuilder.Entity("ScheduleChange.Data.Config", b =>
                {
                    b.Property<int>("Id")
                        .ValueGeneratedOnAdd()
                        .HasColumnType("int")
                        .HasAnnotation("SqlServer:ValueGenerationStrategy", SqlServerValueGenerationStrategy.IdentityColumn);

                    b.Property<int>("Cap1")
                        .HasColumnType("int");

                    b.Property<int>("Cap2")
                        .HasColumnType("int");

                    b.Property<int>("Cap3")
                        .HasColumnType("int");

                    b.Property<string>("Carrier")
                        .HasColumnType("nvarchar(max)");

                    b.Property<int>("Classes")
                        .HasColumnType("int");

                    b.Property<int>("CreateBy")
                        .HasColumnType("int");

                    b.Property<DateTime>("CreateDate")
                        .HasColumnType("datetime2");

                    b.Property<bool>("DomeIntl")
                        .HasColumnType("bit");

                    b.Property<string>("EQPCode")
                        .HasColumnType("nvarchar(max)");

                    b.Property<DateTime>("FromDate")
                        .HasColumnType("datetime2");

                    b.Property<int>("NumberOfClasses")
                        .HasColumnType("int");

                    b.Property<int>("NumberOfCompartments")
                        .HasColumnType("int");

                    b.Property<string>("Remark")
                        .HasColumnType("nvarchar(max)");

                    b.Property<string>("TableNbr")
                        .HasColumnType("nvarchar(max)");

                    b.Property<DateTime>("Todate")
                        .HasColumnType("datetime2");

                    b.Property<int>("UpdateBy")
                        .HasColumnType("int");

                    b.Property<DateTime>("UpdateDate")
                        .HasColumnType("datetime2");

                    b.HasKey("Id");

                    b.ToTable("Configs");
                });

            modelBuilder.Entity("ScheduleChange.Data.DomesticCities", b =>
                {
                    b.Property<int>("Id")
                        .ValueGeneratedOnAdd()
                        .HasColumnType("int")
                        .HasAnnotation("SqlServer:ValueGenerationStrategy", SqlServerValueGenerationStrategy.IdentityColumn);

                    b.Property<string>("CityCode")
                        .HasColumnType("nvarchar(max)");

                    b.Property<string>("CityName")
                        .HasColumnType("nvarchar(max)");

                    b.Property<int>("CreateBy")
                        .HasColumnType("int");

                    b.Property<DateTime>("CreateDate")
                        .HasColumnType("datetime2");

                    b.Property<int>("UpdateBy")
                        .HasColumnType("int");

                    b.Property<DateTime>("UpdateDate")
                        .HasColumnType("datetime2");

                    b.HasKey("Id");

                    b.ToTable("DomesticCities");
                });

            modelBuilder.Entity("ScheduleChange.Data.MarketingCodeShareFlights", b =>
                {
                    b.Property<int>("Id")
                        .ValueGeneratedOnAdd()
                        .HasColumnType("int")
                        .HasAnnotation("SqlServer:ValueGenerationStrategy", SqlServerValueGenerationStrategy.IdentityColumn);

                    b.Property<int>("CreateBy")
                        .HasColumnType("int");

                    b.Property<DateTime>("CreateDate")
                        .HasColumnType("datetime2");

                    b.Property<int>("DOW")
                        .HasColumnType("int");

                    b.Property<string>("MarketingAirline")
                        .HasColumnType("nvarchar(max)");

                    b.Property<string>("MarketingFlightNumber")
                        .HasColumnType("nvarchar(max)");

                    b.Property<string>("Segment")
                        .HasColumnType("nvarchar(max)");

                    b.Property<int>("UpdateBy")
                        .HasColumnType("int");

                    b.Property<DateTime>("UpdateDate")
                        .HasColumnType("datetime2");

                    b.Property<string>("VN_OPS_FlightNumber")
                        .HasColumnType("nvarchar(max)");

                    b.HasKey("Id");

                    b.ToTable("MarketingCodeShareFlights");
                });

            modelBuilder.Entity("ScheduleChange.Data.Meal", b =>
                {
                    b.Property<int>("Id")
                        .ValueGeneratedOnAdd()
                        .HasColumnType("int")
                        .HasAnnotation("SqlServer:ValueGenerationStrategy", SqlServerValueGenerationStrategy.IdentityColumn);

                    b.Property<string>("Compartment")
                        .HasColumnType("nvarchar(max)");

                    b.Property<int>("CreateBy")
                        .HasColumnType("int");

                    b.Property<DateTime>("CreateDate")
                        .HasColumnType("datetime2");

                    b.Property<DateTime>("FromDate")
                        .HasColumnType("datetime2");

                    b.Property<DateTime>("FromTime")
                        .HasColumnType("datetime2");

                    b.Property<string>("MealCode")
                        .HasColumnType("nvarchar(max)");

                    b.Property<string>("Segment")
                        .HasColumnType("nvarchar(max)");

                    b.Property<DateTime>("ToDate")
                        .HasColumnType("datetime2");

                    b.Property<DateTime>("ToTime")
                        .HasColumnType("datetime2");

                    b.Property<int>("UpdateBy")
                        .HasColumnType("int");

                    b.Property<DateTime>("UpdateDate")
                        .HasColumnType("datetime2");

                    b.HasKey("Id");

                    b.ToTable("Meals");
                });

            modelBuilder.Entity("ScheduleChange.Data.PCC", b =>
                {
                    b.Property<int>("Id")
                        .ValueGeneratedOnAdd()
                        .HasColumnType("int")
                        .HasAnnotation("SqlServer:ValueGenerationStrategy", SqlServerValueGenerationStrategy.IdentityColumn);

                    b.Property<string>("CityCode")
                        .HasColumnType("nvarchar(max)");

                    b.Property<string>("CityName")
                        .HasColumnType("nvarchar(max)");

                    b.Property<int>("CreateBy")
                        .HasColumnType("int");

                    b.Property<DateTime>("CreateDate")
                        .HasColumnType("datetime2");

                    b.Property<string>("PCCCode")
                        .HasColumnType("nvarchar(max)");

                    b.Property<string>("PCCFullName")
                        .HasColumnType("nvarchar(max)");

                    b.Property<string>("PCCName")
                        .HasColumnType("nvarchar(max)");

                    b.Property<int>("QueueNumber")
                        .HasColumnType("int");

                    b.Property<string>("TimeZone")
                        .HasColumnType("nvarchar(max)");

                    b.Property<int>("UpdateBy")
                        .HasColumnType("int");

                    b.Property<DateTime>("UpdateDate")
                        .HasColumnType("datetime2");

                    b.HasKey("Id");

                    b.ToTable("PCCs");
                });

            modelBuilder.Entity("ScheduleChange.Data.SCCRequest", b =>
                {
                    b.Property<int>("Id")
                        .ValueGeneratedOnAdd()
                        .HasColumnType("int")
                        .HasAnnotation("SqlServer:ValueGenerationStrategy", SqlServerValueGenerationStrategy.IdentityColumn);

                    b.Property<string>("Airline")
                        .HasColumnType("nvarchar(max)");

                    b.Property<string>("BoardPoint")
                        .HasColumnType("nvarchar(max)");

                    b.Property<DateTime>("BoardTime")
                        .HasColumnType("datetime2");

                    b.Property<int>("DayChangeIndicator")
                        .HasColumnType("int");

                    b.Property<string>("EquipConfig")
                        .HasColumnType("nvarchar(max)");

                    b.Property<string>("EquipType")
                        .HasColumnType("nvarchar(max)");

                    b.Property<DateTime>("FlightDate")
                        .HasColumnType("datetime2");

                    b.Property<string>("FlightNumber")
                        .HasColumnType("nvarchar(max)");

                    b.Property<int>("Frequency")
                        .HasColumnType("int");

                    b.Property<string>("MessageId")
                        .HasColumnType("nvarchar(max)");

                    b.Property<string>("OffPoint")
                        .HasColumnType("nvarchar(max)");

                    b.Property<DateTime>("OffTime")
                        .HasColumnType("datetime2");

                    b.Property<string>("OtherNote")
                        .HasColumnType("nvarchar(max)");

                    b.Property<string>("Overbooking")
                        .HasColumnType("nvarchar(max)");

                    b.Property<string>("ProtectionPlan")
                        .HasColumnType("nvarchar(max)");

                    b.Property<string>("SCReason")
                        .HasColumnType("nvarchar(max)");

                    b.Property<string>("SCType")
                        .HasColumnType("nvarchar(max)");

                    b.Property<string>("VIPNote")
                        .HasColumnType("nvarchar(max)");

                    b.HasKey("Id");

                    b.ToTable("SCCRequests");
                });

            modelBuilder.Entity("Webgentle.BookStore.Data.Addresses", b =>
                {
                    b.Property<int>("Id")
                        .ValueGeneratedOnAdd()
                        .HasColumnType("int")
                        .HasAnnotation("SqlServer:ValueGenerationStrategy", SqlServerValueGenerationStrategy.IdentityColumn);

                    b.Property<string>("Address")
                        .HasColumnType("nvarchar(max)");

                    b.Property<string>("City")
                        .HasColumnType("nvarchar(max)");

                    b.HasKey("Id");

                    b.ToTable("Addresses");
                });

            modelBuilder.Entity("Webgentle.BookStore.Data.SSCIStation", b =>
                {
                    b.Property<int>("Id")
                        .ValueGeneratedOnAdd()
                        .HasColumnType("int")
                        .HasAnnotation("SqlServer:ValueGenerationStrategy", SqlServerValueGenerationStrategy.IdentityColumn);

                    b.Property<string>("Addresses")
                        .HasColumnType("nvarchar(max)");

                    b.Property<string>("CityCode")
                        .HasColumnType("nvarchar(max)");

                    b.Property<int>("CreateBy")
                        .HasColumnType("int");

                    b.Property<DateTime>("CreateDate")
                        .HasColumnType("datetime2");

                    b.Property<DateTime>("EffectiveDateFrom")
                        .HasColumnType("datetime2");

                    b.Property<DateTime>("EffectiveDateTo")
                        .HasColumnType("datetime2");

                    b.Property<int>("UpdateBy")
                        .HasColumnType("int");

                    b.Property<DateTime>("UpdateDate")
                        .HasColumnType("datetime2");

                    b.HasKey("Id");

                    b.ToTable("SSCIStations");
                });

            modelBuilder.Entity("Webgentle.BookStore.Data.ThreeCompartmentsFlight", b =>
                {
                    b.Property<int>("Id")
                        .ValueGeneratedOnAdd()
                        .HasColumnType("int")
                        .HasAnnotation("SqlServer:ValueGenerationStrategy", SqlServerValueGenerationStrategy.IdentityColumn);

                    b.Property<int>("CreateBy")
                        .HasColumnType("int");

                    b.Property<DateTime>("CreateDate")
                        .HasColumnType("datetime2");

                    b.Property<DateTime>("DepDateFrom")
                        .HasColumnType("datetime2");

                    b.Property<DateTime>("DepDateTo")
                        .HasColumnType("datetime2");

                    b.Property<string>("FlightNumber")
                        .HasColumnType("nvarchar(max)");

                    b.Property<int>("UpdateBy")
                        .HasColumnType("int");

                    b.Property<DateTime>("UpdateDate")
                        .HasColumnType("datetime2");

                    b.HasKey("Id");

                    b.ToTable("ThreeCompartmentsFlights");
                });
#pragma warning restore 612, 618
        }
    }
}
