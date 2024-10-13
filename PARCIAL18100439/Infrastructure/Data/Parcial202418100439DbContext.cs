using System;
using System.Collections.Generic;
using Microsoft.EntityFrameworkCore;

namespace PARCIAL18100439.Infrastructure.Data;

public partial class Parcial202418100439DbContext : DbContext
{
    public Parcial202418100439DbContext()
    {
    }

    public Parcial202418100439DbContext(DbContextOptions<Parcial202418100439DbContext> options)
        : base(options)
    {
    }

    public virtual DbSet<Mechanic> Mechanic { get; set; }

    protected override void OnConfiguring(DbContextOptionsBuilder optionsBuilder)
#warning To protect potentially sensitive information in your connection string, you should move it out of source code. You can avoid scaffolding the connection string by using the Name= syntax to read it from configuration - see https://go.microsoft.com/fwlink/?linkid=2131148. For more guidance on storing connection strings, see https://go.microsoft.com/fwlink/?LinkId=723263.
        => optionsBuilder.UseSqlServer("Server=RUBEN\\SQLEXPRESS;Database=Parcial202418100439DB;Integrated Security=true;TrustServerCertificate=True");

    protected override void OnModelCreating(ModelBuilder modelBuilder)
    {
        modelBuilder.Entity<Mechanic>(entity =>
        {
            entity.HasKey(e => e.Id).HasName("PK__Mechanic__3213E83F5A92B930");

            entity.Property(e => e.Id)
                .ValueGeneratedNever()
                .HasColumnName("id");
            entity.Property(e => e.Email)
                .HasMaxLength(1)
                .IsUnicode(false);
            entity.Property(e => e.Firstname)
                .HasMaxLength(1)
                .IsUnicode(false);
            entity.Property(e => e.Lastname)
                .HasMaxLength(1)
                .IsUnicode(false);
        });

        OnModelCreatingPartial(modelBuilder);
    }

    partial void OnModelCreatingPartial(ModelBuilder modelBuilder);
}
