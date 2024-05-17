using System;
using System.Collections.Generic;
using Microsoft.EntityFrameworkCore;

namespace MyCards.Models;

public partial class MycardsContext : DbContext
{
    public MycardsContext()
    {
    }

    public MycardsContext(DbContextOptions<MycardsContext> options)
        : base(options)
    {
    }

    public virtual DbSet<Card> Cards { get; set; }

    public virtual DbSet<Category> Categories { get; set; }

    public virtual DbSet<User> Users { get; set; }

    protected override void OnConfiguring(DbContextOptionsBuilder optionsBuilder)
#warning To protect potentially sensitive information in your connection string, you should move it out of source code. You can avoid scaffolding the connection string by using the Name= syntax to read it from configuration - see https://go.microsoft.com/fwlink/?linkid=2131148. For more guidance on storing connection strings, see http://go.microsoft.com/fwlink/?LinkId=723263.
        => optionsBuilder.UseMySql("server=localhost;port=3306;database=mycards;uid=root", Microsoft.EntityFrameworkCore.ServerVersion.Parse("10.4.28-mariadb"));

    protected override void OnModelCreating(ModelBuilder modelBuilder)
    {
        modelBuilder
            .UseCollation("utf8mb4_general_ci")
            .HasCharSet("utf8mb4");

        modelBuilder.Entity<Card>(entity =>
        {
            entity.HasKey(e => e.Id).HasName("PRIMARY");

            entity.ToTable("card");

            entity.HasIndex(e => e.CategoryId, "FK_Category");

            entity.Property(e => e.Id).HasColumnType("int(11)");
            entity.Property(e => e.Back).HasMaxLength(2000);
            entity.Property(e => e.BackNotice)
                .HasMaxLength(2000)
                .HasColumnName("Back_Notice");
            entity.Property(e => e.CategoryId)
                .HasColumnType("int(11)")
                .HasColumnName("Category_Id");
            entity.Property(e => e.Color).HasColumnType("int(11)");
            entity.Property(e => e.Completed)
                .HasDefaultValueSql("'N'")
                .HasColumnType("enum('Y','N')");
            entity.Property(e => e.Front).HasMaxLength(2000);
            entity.Property(e => e.FrontNotice)
                .HasMaxLength(2000)
                .HasColumnName("Front_Notice");

            entity.HasOne(d => d.Category).WithMany(p => p.Cards)
                .HasForeignKey(d => d.CategoryId)
                .HasConstraintName("FK_Category");
        });

        modelBuilder.Entity<Category>(entity =>
        {
            entity.HasKey(e => e.Id).HasName("PRIMARY");

            entity.ToTable("category");

            entity.HasIndex(e => e.UserId, "FK_User_Category");

            entity.Property(e => e.Id).HasColumnType("int(11)");
            entity.Property(e => e.Name).HasMaxLength(200);
            entity.Property(e => e.UserId)
                .HasColumnType("int(11)")
                .HasColumnName("User_Id");

            entity.HasOne(d => d.User).WithMany(p => p.Categories)
                .HasForeignKey(d => d.UserId)
                .HasConstraintName("FK_User_Category");
        });

        modelBuilder.Entity<User>(entity =>
        {
            entity.HasKey(e => e.Id).HasName("PRIMARY");

            entity.ToTable("user");

            entity.Property(e => e.Id).HasColumnType("int(11)");
            entity.Property(e => e.Email).HasMaxLength(100);
            entity.Property(e => e.Lastname).HasMaxLength(100);
            entity.Property(e => e.Password).HasMaxLength(150);
            entity.Property(e => e.Surname).HasMaxLength(100);
            entity.Property(e => e.Username).HasMaxLength(100);
        });

        OnModelCreatingPartial(modelBuilder);
    }

    partial void OnModelCreatingPartial(ModelBuilder modelBuilder);
}
