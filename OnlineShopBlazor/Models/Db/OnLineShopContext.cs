using System;
using System.Collections.Generic;
using Microsoft.EntityFrameworkCore;

namespace OnlineShopBlazor.Models.Db;

public partial class OnLineShopContext : DbContext
{
    public OnLineShopContext()
    {
    }

    public OnLineShopContext(DbContextOptions<OnLineShopContext> options)
        : base(options)
    {
    }

    public virtual DbSet<Menu> Menus { get; set; }

    protected override void OnModelCreating(ModelBuilder modelBuilder)
    {
        modelBuilder.Entity<Menu>(entity =>
        {
            entity.HasKey(e => e.Id).HasName("PK_Menus_ID");
        });

        OnModelCreatingPartial(modelBuilder);
    }

    partial void OnModelCreatingPartial(ModelBuilder modelBuilder);
}
