using System;
using Microsoft.EntityFrameworkCore;
using Microsoft.EntityFrameworkCore.Infrastructure;
using Microsoft.EntityFrameworkCore.Metadata;
using Microsoft.EntityFrameworkCore.Migrations;
using Destiny.Data;

namespace Destiny.Data.Migrations
{
    [DbContext(typeof(DestinyContext))]
    [Migration("20170522005949_init")]
    partial class init
    {
        protected override void BuildTargetModel(ModelBuilder modelBuilder)
        {
            modelBuilder
                .HasAnnotation("ProductVersion", "1.1.2")
                .HasAnnotation("SqlServer:ValueGenerationStrategy", SqlServerValueGenerationStrategy.IdentityColumn);

            modelBuilder.Entity("Destiny.Domain.Perk", b =>
                {
                    b.Property<int>("Id")
                        .ValueGeneratedOnAdd();

                    b.Property<string>("Description");

                    b.Property<string>("Name");

                    b.Property<int>("WeaponId");

                    b.HasKey("Id");

                    b.HasIndex("WeaponId");

                    b.ToTable("Perks");
                });

            modelBuilder.Entity("Destiny.Domain.Weapon", b =>
                {
                    b.Property<int>("Id")
                        .ValueGeneratedOnAdd();

                    b.Property<string>("Description");

                    b.Property<string>("ImageUrl");

                    b.Property<string>("Name");

                    b.Property<int>("WeaponTypeId");

                    b.HasKey("Id");

                    b.ToTable("Weapons");
                });

            modelBuilder.Entity("Destiny.Domain.Perk", b =>
                {
                    b.HasOne("Destiny.Domain.Weapon")
                        .WithMany("Perks")
                        .HasForeignKey("WeaponId")
                        .OnDelete(DeleteBehavior.Cascade);
                });
        }
    }
}
