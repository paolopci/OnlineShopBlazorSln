using System;
using System.Collections.Generic;
using Microsoft.EntityFrameworkCore;

namespace OnlineShopBlazor.Models.Db;

public partial class OnLineShopContext : DbContext
{
    public OnLineShopContext() { }

    public OnLineShopContext(DbContextOptions<OnLineShopContext> options)
        : base(options) { }

    public virtual DbSet<Banner> Banners { get; set; }

    public virtual DbSet<Menu> Menus { get; set; }

    public virtual DbSet<Product> Products { get; set; }

    public virtual DbSet<ProductGallery> ProductGalleries { get; set; }

    protected override void OnConfiguring(DbContextOptionsBuilder optionsBuilder)
#warning To protect potentially sensitive information in your connection string, you should move it out of source code. You can avoid scaffolding the connection string by using the Name= syntax to read it from configuration - see https://go.microsoft.com/fwlink/?linkid=2131148. For more guidance on storing connection strings, see https://go.microsoft.com/fwlink/?LinkId=723263.
        =>
        optionsBuilder.UseSqlServer(
            "Server=localhost,1433;Database=OnlineShop;User Id=sa;Password=Micene@65;TrustServerCertificate=true"
        );

    protected override void OnModelCreating(ModelBuilder modelBuilder)
    {
        modelBuilder.Entity<Banner>(entity =>
        {
            entity.HasKey(e => e.Id).HasName("PK_Banner_ID");
        });

        modelBuilder.Entity<Menu>(entity =>
        {
            entity.HasKey(e => e.Id).HasName("PK_Menus_ID");
        });

        modelBuilder.Entity<Product>(entity =>
        {
            entity.HasKey(e => e.Id).HasName("PK_Products_Id");
        });

        modelBuilder.Entity<ProductGallery>(entity =>
        {
            entity.HasKey(e => e.Id).HasName("PK_ProductGallery_Id");
        });

        OnModelCreatingPartial(modelBuilder);
    }

    partial void OnModelCreatingPartial(ModelBuilder modelBuilder);
}
