using System;
using Microsoft.EntityFrameworkCore;
using Microsoft.EntityFrameworkCore.Infrastructure;
using Microsoft.EntityFrameworkCore.Metadata;
using Microsoft.EntityFrameworkCore.Migrations;
using Destiny.WebApi.Entities.Context;

namespace Destiny.WebApi.Migrations
{
    [DbContext(typeof(DestinyDbContext))]
    partial class DestinyDbContextModelSnapshot : ModelSnapshot
    {
        protected override void BuildModel(ModelBuilder modelBuilder)
        {
            modelBuilder
                .HasAnnotation("ProductVersion", "1.1.2")
                .HasAnnotation("SqlServer:ValueGenerationStrategy", SqlServerValueGenerationStrategy.IdentityColumn);

            modelBuilder.Entity("Destiny.WebApi.Entities.Perk", b =>
                {
                    b.Property<int>("Id")
                        .ValueGeneratedOnAdd();

                    b.Property<string>("Description")
                        .IsRequired()
                        .HasMaxLength(200);

                    b.Property<bool>("IsActive");

                    b.Property<string>("Name")
                        .IsRequired()
                        .HasMaxLength(50);

                    b.Property<int>("WeaponId");

                    b.HasKey("Id");

                    b.HasIndex("WeaponId");

                    b.ToTable("Perks");
                });

            modelBuilder.Entity("Destiny.WebApi.Entities.Weapon", b =>
                {
                    b.Property<int>("Id")
                        .ValueGeneratedOnAdd();

                    b.Property<string>("Description")
                        .HasMaxLength(200);

                    b.Property<string>("ImageUrl")
                        .IsRequired();

                    b.Property<string>("Name")
                        .IsRequired()
                        .HasMaxLength(75);

                    b.Property<string>("WeaponType")
                        .IsRequired()
                        .HasMaxLength(30);

                    b.HasKey("Id");

                    b.ToTable("Weapons");
                });

            modelBuilder.Entity("Destiny.WebApi.Entities.Perk", b =>
                {
                    b.HasOne("Destiny.WebApi.Entities.Weapon", "Weapon")
                        .WithMany("Perks")
                        .HasForeignKey("WeaponId")
                        .OnDelete(DeleteBehavior.Cascade);
                });
        }
    }
}
