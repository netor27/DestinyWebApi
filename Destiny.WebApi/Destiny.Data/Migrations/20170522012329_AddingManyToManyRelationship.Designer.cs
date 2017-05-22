using System;
using Microsoft.EntityFrameworkCore;
using Microsoft.EntityFrameworkCore.Infrastructure;
using Microsoft.EntityFrameworkCore.Metadata;
using Microsoft.EntityFrameworkCore.Migrations;
using Destiny.Data;

namespace Destiny.Data.Migrations
{
    [DbContext(typeof(DestinyContext))]
    [Migration("20170522012329_AddingManyToManyRelationship")]
    partial class AddingManyToManyRelationship
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

                    b.HasKey("Id");

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

            modelBuilder.Entity("Destiny.Domain.WeaponPerk", b =>
                {
                    b.Property<int>("WeaponId");

                    b.Property<int>("PerkId");

                    b.HasKey("WeaponId", "PerkId");

                    b.HasIndex("PerkId");

                    b.ToTable("WeaponPerk");
                });

            modelBuilder.Entity("Destiny.Domain.WeaponPerk", b =>
                {
                    b.HasOne("Destiny.Domain.Perk", "Perk")
                        .WithMany("WeaponPerks")
                        .HasForeignKey("PerkId")
                        .OnDelete(DeleteBehavior.Cascade);

                    b.HasOne("Destiny.Domain.Weapon", "Weapon")
                        .WithMany("WeaponPerks")
                        .HasForeignKey("WeaponId")
                        .OnDelete(DeleteBehavior.Cascade);
                });
        }
    }
}
