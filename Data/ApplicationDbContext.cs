﻿using Microsoft.AspNetCore.Identity.EntityFrameworkCore;
using Microsoft.EntityFrameworkCore;


namespace CommunityApp.Data;

public class ApplicationDbContext : IdentityDbContext
{
    public ApplicationDbContext(DbContextOptions<ApplicationDbContext> options)
        : base(options)
    {
    }

    public DbSet<Province>? Provinces { get; set; }
    public DbSet<City>? Cities { get; set; }

    protected override void OnModelCreating(ModelBuilder builder)
    {
        base.OnModelCreating(builder);
        builder.Entity<City>().Property(m => m.CityId).IsRequired();

        /*builder.Entity<Province>().Property(p => p.TeamName).HasMaxLength(30);*/

        builder.Entity<City>().ToTable("City");
        builder.Entity<Province>().ToTable("Province");

        builder.Seed();
    }

}
