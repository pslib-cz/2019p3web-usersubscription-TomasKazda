﻿// <auto-generated />
using Microsoft.EntityFrameworkCore;
using Microsoft.EntityFrameworkCore.Infrastructure;
using Microsoft.EntityFrameworkCore.Storage.ValueConversion;
using UserSubscription.Models;

namespace UserSubscription.Migrations
{
    [DbContext(typeof(SubscriptionContext))]
    partial class SubscriptionContextModelSnapshot : ModelSnapshot
    {
        protected override void BuildModel(ModelBuilder modelBuilder)
        {
#pragma warning disable 612, 618
            modelBuilder
                .HasAnnotation("ProductVersion", "2.2.6-servicing-10079");

            modelBuilder.Entity("UserSubscription.Models.Subscription", b =>
                {
                    b.Property<int>("Id")
                        .ValueGeneratedOnAdd();

                    b.Property<bool>("Agreed");

                    b.Property<string>("ConfirmationCode");

                    b.Property<bool>("Confirmed");

                    b.Property<string>("CountryCode")
                        .IsRequired();

                    b.Property<string>("Email")
                        .IsRequired();

                    b.Property<string>("FirstName")
                        .IsRequired();

                    b.Property<int>("Gender");

                    b.Property<string>("LastName")
                        .IsRequired();

                    b.HasKey("Id");

                    b.ToTable("Subscriptions");

                    b.HasData(
                        new
                        {
                            Id = 1,
                            Agreed = true,
                            ConfirmationCode = "FGC12556",
                            Confirmed = true,
                            CountryCode = "CZ",
                            Email = "john@doe.com",
                            FirstName = "John",
                            Gender = 0,
                            LastName = "Doe"
                        });
                });
#pragma warning restore 612, 618
        }
    }
}
