using System;
using System.Collections.Generic;
using Microsoft.EntityFrameworkCore;

namespace Ndb_2310900011.Models;

public partial class NguyenDinhBau12310900011Context : DbContext
{
    public NguyenDinhBau12310900011Context()
    {
    }

    public NguyenDinhBau12310900011Context(DbContextOptions<NguyenDinhBau12310900011Context> options)
        : base(options)
    {
    }

    public virtual DbSet<NdbEmployee> NdbEmployees { get; set; }

    protected override void OnConfiguring(DbContextOptionsBuilder optionsBuilder)
#warning To protect potentially sensitive information in your connection string, you should move it out of source code. You can avoid scaffolding the connection string by using the Name= syntax to read it from configuration - see https://go.microsoft.com/fwlink/?linkid=2131148. For more guidance on storing connection strings, see https://go.microsoft.com/fwlink/?LinkId=723263.
        => optionsBuilder.UseSqlServer("Server=HIHIHI\\MAY1;Database=NguyenDinhBau1_2310900011;Trusted_Connection=True;MultipleActiveResultSets=True;TrustServerCertificate=True");

    protected override void OnModelCreating(ModelBuilder modelBuilder)
    {
        modelBuilder.Entity<NdbEmployee>(entity =>
        {
            entity.HasKey(e => e.NdbEmpId).HasName("PK__ndbEmplo__364B54A4B18C18B7");

            entity.ToTable("ndbEmployee");

            entity.Property(e => e.NdbEmpId).HasColumnName("ndbEmpId");
            entity.Property(e => e.NdbEmpLevel).HasColumnName("ndbEmpLevel");
            entity.Property(e => e.NdbEmpName)
                .HasMaxLength(100)
                .HasColumnName("ndbEmpName");
            entity.Property(e => e.NdbEmpStartDate).HasColumnName("ndbEmpStartDate");
            entity.Property(e => e.NdbEmpStartus).HasColumnName("ndbEmpStartus");
        });

        OnModelCreatingPartial(modelBuilder);
    }

    partial void OnModelCreatingPartial(ModelBuilder modelBuilder);
}
