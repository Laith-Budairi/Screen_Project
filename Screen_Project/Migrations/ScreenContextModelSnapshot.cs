﻿// <auto-generated />
using System;
using Microsoft.EntityFrameworkCore;
using Microsoft.EntityFrameworkCore.Infrastructure;
using Microsoft.EntityFrameworkCore.Metadata;
using Microsoft.EntityFrameworkCore.Storage.ValueConversion;
using Screen_Project;

namespace Screen_Project.Migrations
{
    [DbContext(typeof(ScreenContext))]
    partial class ScreenContextModelSnapshot : ModelSnapshot
    {
        protected override void BuildModel(ModelBuilder modelBuilder)
        {
#pragma warning disable 612, 618
            modelBuilder
                .HasAnnotation("ProductVersion", "2.2.2-servicing-10034")
                .HasAnnotation("Relational:MaxIdentifierLength", 128)
                .HasAnnotation("SqlServer:ValueGenerationStrategy", SqlServerValueGenerationStrategy.IdentityColumn);

            modelBuilder.Entity("Screen_Project.Models.Event", b =>
                {
                    b.Property<int>("Id")
                        .ValueGeneratedOnAdd()
                        .HasAnnotation("SqlServer:ValueGenerationStrategy", SqlServerValueGenerationStrategy.IdentityColumn);

                    b.Property<DateTime>("EndDate");

                    b.Property<int>("Priority");

                    b.Property<string>("Repeat");

                    b.Property<DateTime>("StartDate");

                    b.Property<int>("TemplateId");

                    b.HasKey("Id");

                    b.HasIndex("TemplateId");

                    b.ToTable("Events");
                });

            modelBuilder.Entity("Screen_Project.Models.EventProperties", b =>
                {
                    b.Property<int>("Id")
                        .ValueGeneratedOnAdd()
                        .HasAnnotation("SqlServer:ValueGenerationStrategy", SqlServerValueGenerationStrategy.IdentityColumn);

                    b.Property<int>("EventId");

                    b.Property<string>("PropertyType");

                    b.Property<string>("PropertyValue");

                    b.Property<int>("TemplatePropertyId");

                    b.HasKey("Id");

                    b.HasIndex("EventId");

                    b.HasIndex("TemplatePropertyId")
                        .IsUnique();

                    b.ToTable("EventsProperties");
                });

            modelBuilder.Entity("Screen_Project.Models.Template", b =>
                {
                    b.Property<int>("Id")
                        .ValueGeneratedOnAdd()
                        .HasAnnotation("SqlServer:ValueGenerationStrategy", SqlServerValueGenerationStrategy.IdentityColumn);

                    b.Property<string>("Background");

                    b.Property<string>("Name");

                    b.HasKey("Id");

                    b.ToTable("Templates");
                });

            modelBuilder.Entity("Screen_Project.Models.TemplateProperties", b =>
                {
                    b.Property<int>("Id")
                        .ValueGeneratedOnAdd()
                        .HasAnnotation("SqlServer:ValueGenerationStrategy", SqlServerValueGenerationStrategy.IdentityColumn);

                    b.Property<string>("FontColor");

                    b.Property<string>("FontFamily");

                    b.Property<int>("FontSize");

                    b.Property<int>("Left");

                    b.Property<string>("PropertyName");

                    b.Property<int>("TemplateId");

                    b.Property<int>("Top");

                    b.HasKey("Id");

                    b.HasIndex("TemplateId");

                    b.ToTable("TemplatesProperties");
                });

            modelBuilder.Entity("Screen_Project.Models.Event", b =>
                {
                    b.HasOne("Screen_Project.Models.Template", "CurrentTemplate")
                        .WithMany("Events")
                        .HasForeignKey("TemplateId")
                        .OnDelete(DeleteBehavior.Cascade);
                });

            modelBuilder.Entity("Screen_Project.Models.EventProperties", b =>
                {
                    b.HasOne("Screen_Project.Models.Event", "CurrentEvent")
                        .WithMany("EventsProperties")
                        .HasForeignKey("EventId")
                        .OnDelete(DeleteBehavior.Cascade);

                    b.HasOne("Screen_Project.Models.TemplateProperties", "CurrentTemplateProperty")
                        .WithOne("CurrentEventProperty")
                        .HasForeignKey("Screen_Project.Models.EventProperties", "TemplatePropertyId")
                        .OnDelete(DeleteBehavior.Restrict);
                });

            modelBuilder.Entity("Screen_Project.Models.TemplateProperties", b =>
                {
                    b.HasOne("Screen_Project.Models.Template", "CurrentTemplate")
                        .WithMany("TemplatesProperties")
                        .HasForeignKey("TemplateId")
                        .OnDelete(DeleteBehavior.Cascade);
                });
#pragma warning restore 612, 618
        }
    }
}