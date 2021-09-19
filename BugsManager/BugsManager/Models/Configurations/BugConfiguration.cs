﻿// <auto-generated> This file has been auto generated by EF Core Power Tools. </auto-generated>
using BugsManager.Models;
using Microsoft.EntityFrameworkCore.Metadata.Builders;
using Microsoft.EntityFrameworkCore.Metadata;
using Microsoft.EntityFrameworkCore;
using System;

#nullable disable

namespace BugsManager.Models.Configurations
{
    public partial class BugConfiguration : IEntityTypeConfiguration<Bug>
    {
        public void Configure(EntityTypeBuilder<Bug> entity)
        {
            entity.HasOne(d => d.Project)
                .WithMany(p => p.Bug)
                .HasForeignKey(d => d.ProjectId)
                .HasConstraintName("FK_Bug_Project");

            entity.HasOne(d => d.User)
                .WithMany(p => p.Bug)
                .HasForeignKey(d => d.UserId)
                .HasConstraintName("FK_Bug_User");

            OnConfigurePartial(entity);
        }

        partial void OnConfigurePartial(EntityTypeBuilder<Bug> entity);
    }
}
