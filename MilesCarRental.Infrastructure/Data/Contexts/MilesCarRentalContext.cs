using System;
using System.Collections.Generic;
using Microsoft.EntityFrameworkCore;
using MilesCarRental.Infrastructure.Data.Models;

namespace MilesCarRental.Infrastructure.Data.Contexts;

public partial class MilesCarRentalContext : DbContext
{
    public MilesCarRentalContext()
    {
    }

    public MilesCarRentalContext(DbContextOptions<MilesCarRentalContext> options)
        : base(options)
    {
    }

    public virtual DbSet<Localidade> Localidades { get; set; }

    public virtual DbSet<Reserva> Reservas { get; set; }

    public virtual DbSet<Vehiculo> Vehiculos { get; set; }

    protected override void OnConfiguring(DbContextOptionsBuilder optionsBuilder)
#warning To protect potentially sensitive information in your connection string, you should move it out of source code. You can avoid scaffolding the connection string by using the Name= syntax to read it from configuration - see https://go.microsoft.com/fwlink/?linkid=2131148. For more guidance on storing connection strings, see http://go.microsoft.com/fwlink/?LinkId=723263.
        => optionsBuilder.UseSqlServer("Data Source=DESKTOP-G777FN6\\SQLEXPRESS;Initial Catalog=MilesCarRental;Integrated Security=True;TrustServerCertificate=True;");

    protected override void OnModelCreating(ModelBuilder modelBuilder)
    {
        modelBuilder.Entity<Localidade>(entity =>
        {
            entity.HasKey(e => e.LocalidadId).HasName("PK__Localida__6E289F42E0EE34F5");

            entity.Property(e => e.LocalidadId)
                .ValueGeneratedNever()
                .HasColumnName("LocalidadID");
            entity.Property(e => e.Nombre).HasMaxLength(100);
        });

        modelBuilder.Entity<Reserva>(entity =>
        {
            entity.HasKey(e => e.ReservaId).HasName("PK__Reservas__C399370394FF33EB");

            entity.Property(e => e.ReservaId)
                .ValueGeneratedNever()
                .HasColumnName("ReservaID");
            entity.Property(e => e.Estado).HasMaxLength(50);
            entity.Property(e => e.FechaDevolucion).HasColumnType("datetime");
            entity.Property(e => e.FechaRecogida).HasColumnType("datetime");
            entity.Property(e => e.UsuarioId).HasColumnName("UsuarioID");
            entity.Property(e => e.VehiculoId).HasColumnName("VehiculoID");

            entity.HasOne(d => d.Vehiculo).WithMany(p => p.Reservas)
                .HasForeignKey(d => d.VehiculoId)
                .HasConstraintName("FK__Reservas__Vehicu__4F7CD00D");
        });

        modelBuilder.Entity<Vehiculo>(entity =>
        {
            entity.HasKey(e => e.VehiculoId).HasName("PK__Vehiculo__AA08862026B730B9");

            entity.HasIndex(e => e.LocalidadDevolucion, "idx_LocalidadDevolucion");

            entity.HasIndex(e => e.LocalidadRecogida, "idx_LocalidadRecogida");

            entity.HasIndex(e => e.Tipo, "idx_TipoVehiculo");

            entity.Property(e => e.VehiculoId)
                .ValueGeneratedNever()
                .HasColumnName("VehiculoID");
            entity.Property(e => e.Marca).HasMaxLength(100);
            entity.Property(e => e.Modelo).HasMaxLength(100);
            entity.Property(e => e.Tipo).HasMaxLength(100);
            entity.Property(e => e.Transmision).HasMaxLength(50);

            entity.HasOne(d => d.LocalidadDevolucionNavigation).WithMany(p => p.VehiculoLocalidadDevolucionNavigations)
                .HasForeignKey(d => d.LocalidadDevolucion)
                .OnDelete(DeleteBehavior.ClientSetNull)
                .HasConstraintName("FK__Vehiculos__Local__4CA06362");

            entity.HasOne(d => d.LocalidadRecogidaNavigation).WithMany(p => p.VehiculoLocalidadRecogidaNavigations)
                .HasForeignKey(d => d.LocalidadRecogida)
                .OnDelete(DeleteBehavior.ClientSetNull)
                .HasConstraintName("FK__Vehiculos__Local__4BAC3F29");
        });

        OnModelCreatingPartial(modelBuilder);
    }

    partial void OnModelCreatingPartial(ModelBuilder modelBuilder);
}
