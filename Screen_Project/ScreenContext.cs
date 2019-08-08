using Microsoft.EntityFrameworkCore;
using Screen_Project.Models;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Threading.Tasks;

namespace Screen_Project
{
    public class ScreenContext : DbContext
    {
        public ScreenContext(DbContextOptions<ScreenContext> options) : base(options)
        {
        }

        protected override void OnModelCreating(ModelBuilder modelBuilder)
        {
                modelBuilder.Entity<TemplateProperties>(builder =>
                {
                    builder.HasOne<Template>(t => t.CurrentTemplate)
                        .WithMany(t => t.TemplatesProperties)
                        .HasForeignKey(t => t.TemplateId);
                });

                modelBuilder.Entity<EventProperties>(builder =>
                {
                    builder.HasOne<Event>(t => t.CurrentEvent)
                        .WithMany(t => t.EventsProperties)
                        .HasForeignKey(t => t.EventId);
                });

                modelBuilder.Entity<Event>(builder =>
                {
                    builder.HasOne<Template>(t => t.CurrentTemplate)
                        .WithMany(t => t.Events)
                        .HasForeignKey(t => t.TemplateId);
                });

                modelBuilder.Entity<EventProperties>(builder =>
                {
                    builder.HasOne<TemplateProperties>(t => t.CurrentTemplateProperty)
                        .WithOne(t => t.CurrentEventProperty).HasForeignKey<EventProperties>(t => t.TemplatePropertyId)
                        .OnDelete(DeleteBehavior.Restrict);
                });


        }

        public DbSet<Event> Events { get; set; }
        public DbSet<EventProperties> EventsProperties { get; set; }
        public DbSet<Template> Templates { get; set; }
        public DbSet<TemplateProperties> TemplatesProperties { get; set; }


    }
}
