﻿// <auto-generated />
using EmailConfigurationWebApi.Model;
using Microsoft.EntityFrameworkCore;
using Microsoft.EntityFrameworkCore.Infrastructure;
using Microsoft.EntityFrameworkCore.Storage.ValueConversion;

#nullable disable

namespace EmailConfigurationWebApi.Migrations
{
    [DbContext(typeof(EmailConfigureContext))]
    partial class EmailConfigureContextModelSnapshot : ModelSnapshot
    {
        protected override void BuildModel(ModelBuilder modelBuilder)
        {
#pragma warning disable 612, 618
            modelBuilder.HasAnnotation("ProductVersion", "6.0.5");

            modelBuilder.Entity("EmailConfigurationWebApi.Model.EmailConfigure", b =>
                {
                    b.Property<int>("EmailId")
                        .ValueGeneratedOnAdd()
                        .HasColumnType("INTEGER");

                    b.Property<string>("EmailName")
                        .IsRequired()
                        .HasColumnType("nvarchar(150)");

                    b.Property<string>("ProviderType")
                        .IsRequired()
                        .HasColumnType("TEXT");

                    b.Property<bool>("StoreAttachment")
                        .HasColumnType("INTEGER");

                    b.Property<string>("WatchedFolder")
                        .IsRequired()
                        .HasColumnType("nvarchar(250)");

                    b.HasKey("EmailId");

                    b.ToTable("EmailConfigures");
                });
#pragma warning restore 612, 618
        }
    }
}
