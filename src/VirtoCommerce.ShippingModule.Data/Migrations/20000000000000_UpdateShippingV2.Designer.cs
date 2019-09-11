// <auto-generated />
using Microsoft.EntityFrameworkCore;
using Microsoft.EntityFrameworkCore.Infrastructure;
using Microsoft.EntityFrameworkCore.Metadata;
using Microsoft.EntityFrameworkCore.Migrations;
using VirtoCommerce.ShippingModule.Data.Repositories;

namespace VirtoCommerce.ShippingModule.Data.Migrations
{
    [DbContext(typeof(ShippingDbContext))]
    [Migration("20000000000000_UpdateShippingV2")]
    partial class UpdateShippingV2
    {
        protected override void BuildTargetModel(ModelBuilder modelBuilder)
        {
#pragma warning disable 612, 618
            modelBuilder
                .HasAnnotation("ProductVersion", "2.2.3-servicing-35854")
                .HasAnnotation("Relational:MaxIdentifierLength", 128)
                .HasAnnotation("SqlServer:ValueGenerationStrategy", SqlServerValueGenerationStrategy.IdentityColumn);

            modelBuilder.Entity("VirtoCommerce.ShippingModule.Data.Model.StoreShippingMethodEntity", b =>
                {
                    b.Property<string>("Id")
                        .ValueGeneratedOnAdd()
                        .HasMaxLength(128);

                    b.Property<string>("Code")
                        .IsRequired()
                        .HasMaxLength(128);

                    b.Property<bool>("IsActive");

                    b.Property<string>("LogoUrl")
                        .HasMaxLength(2048);

                    b.Property<int>("Priority");

                    b.Property<string>("StoreId")
                        .HasMaxLength(128);

                    b.Property<string>("TaxType")
                        .HasMaxLength(64);

                    b.Property<string>("TypeName")
                        .HasMaxLength(128);

                    b.HasKey("Id");

                    b.HasIndex("TypeName", "StoreId")
                        .IsUnique()
                        .HasName("IX_StoreShippingMethodEntity_TypeName_StoreId")
                        .HasFilter("[TypeName] IS NOT NULL AND [StoreId] IS NOT NULL");

                    b.ToTable("StoreShippingMethod");
                });
#pragma warning restore 612, 618
        }
    }
}
