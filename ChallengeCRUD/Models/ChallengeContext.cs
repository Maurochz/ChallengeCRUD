using System;
using System.Collections.Generic;
using Microsoft.EntityFrameworkCore;

namespace ChallengeCRUD.Models;

public partial class ChallengeContext : DbContext
{
    public ChallengeContext()
    {
    }

    public ChallengeContext(DbContextOptions<ChallengeContext> options)
        : base(options)
    {
    }

    public virtual DbSet<Empleado> Empleados { get; set; }

    protected override void OnConfiguring(DbContextOptionsBuilder optionsBuilder)
    {
        if (!optionsBuilder.IsConfigured)
        {
            //#warning To protect potentially sensitive information in your connection string, you should move it out of source code. You can avoid scaffolding the connection string by using the Name= syntax to read it from configuration - see https://go.microsoft.com/fwlink/?linkid=2131148. For more guidance on storing connection strings, see http://go.microsoft.com/fwlink/?LinkId=723263.
            //            optionsBuilder.UseSqlServer("server=MAURO-PC\\MSSQLSERVER01; database=Challenge; integrated security=true; TrustServerCertificate=True;");
        }
    }
    protected override void OnModelCreating(ModelBuilder modelBuilder)
    {
        modelBuilder.Entity<Empleado>(entity =>
        {
            entity.ToTable("empleado");

            entity.Property(e => e.Id).HasColumnName("id");
            entity.Property(e => e.Departamento)
                .HasMaxLength(50)
                .IsUnicode(false)
                .HasColumnName("departamento");
            entity.Property(e => e.Edad).HasColumnName("edad");
            entity.Property(e => e.Nombrecompleto)
                .HasMaxLength(50)
                .IsUnicode(false)
                .HasColumnName("nombrecompleto");
            entity.Property(e => e.Salario)
                .HasColumnType("money")
                .HasColumnName("salario");
        });

        OnModelCreatingPartial(modelBuilder);
    }

    partial void OnModelCreatingPartial(ModelBuilder modelBuilder);
}
