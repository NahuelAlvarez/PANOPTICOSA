using System;
using Microsoft.EntityFrameworkCore;
using Microsoft.EntityFrameworkCore.Metadata;

namespace PanopticoSA.Models
{
    public partial class PanopticoSAContext : DbContext
    {
        public PanopticoSAContext()
        {
        }

        public PanopticoSAContext(DbContextOptions<PanopticoSAContext> options)
            : base(options)
        {
        }

        public virtual DbSet<Area> Area { get; set; }
        public virtual DbSet<Cliente> Cliente { get; set; }
        public virtual DbSet<ClienteContrata> ClienteContrata { get; set; }
        public virtual DbSet<ClienteOpina> ClienteOpina { get; set; }
        public virtual DbSet<Cuenta> Cuenta { get; set; }
        public virtual DbSet<Domicilio> Domicilio { get; set; }
        public virtual DbSet<Emergencia> Emergencia { get; set; }
        public virtual DbSet<Empleado> Empleado { get; set; }
        public virtual DbSet<Factura> Factura { get; set; }
        public virtual DbSet<Jefe> Jefe { get; set; }
        public virtual DbSet<Persona> Persona { get; set; }
        public virtual DbSet<Presupuesto> Presupuesto { get; set; }
        public virtual DbSet<Servicio> Servicio { get; set; }
        public virtual DbSet<ServicioTecnico> ServicioTecnico { get; set; }
        public virtual DbSet<Tecnico> Tecnico { get; set; }
        public virtual DbSet<Turno> Turno { get; set; }       

        protected override void OnModelCreating(ModelBuilder modelBuilder)
        {
            modelBuilder.HasAnnotation("ProductVersion", "2.2.6-servicing-10079");

            modelBuilder.Entity<Area>(entity =>
            {
                entity.HasKey(e => e.IdArea);

                entity.Property(e => e.Tipo)
                    .HasMaxLength(50)
                    .IsUnicode(false);

                entity.HasOne(d => d.IdJefeNavigation)
                    .WithMany(p => p.Area)
                    .HasForeignKey(d => d.IdJefe)
                    .OnDelete(DeleteBehavior.ClientSetNull)
                    .HasConstraintName("FK_Area_Jefe");
            });

            modelBuilder.Entity<Cliente>(entity =>
            {
                entity.HasKey(e => e.IdCliente);

                entity.HasOne(d => d.IdPersonaNavigation)
                    .WithMany(p => p.Cliente)
                    .HasForeignKey(d => d.IdPersona)
                    .OnDelete(DeleteBehavior.ClientSetNull)
                    .HasConstraintName("FK_Cliente_Persona");
            });

            modelBuilder.Entity<ClienteContrata>(entity =>
            {
                entity.HasKey(e => new { e.IdCliente, e.IdServicio });

                entity.ToTable("Cliente_Contrata");

                entity.HasOne(d => d.IdClienteNavigation)
                    .WithMany(p => p.ClienteContrata)
                    .HasForeignKey(d => d.IdCliente)
                    .OnDelete(DeleteBehavior.ClientSetNull)
                    .HasConstraintName("FK_Cliente_Contrata_Cliente");

                entity.HasOne(d => d.IdServicioNavigation)
                    .WithMany(p => p.ClienteContrata)
                    .HasForeignKey(d => d.IdServicio)
                    .OnDelete(DeleteBehavior.ClientSetNull)
                    .HasConstraintName("FK_Cliente_Contrata_Servicio");
            });

            modelBuilder.Entity<ClienteOpina>(entity =>
            {
                entity.HasKey(e => new { e.IdCliente, e.IdServicio });

                entity.ToTable("Cliente_Opina");

                entity.HasOne(d => d.IdClienteNavigation)
                    .WithMany(p => p.ClienteOpina)
                    .HasForeignKey(d => d.IdCliente)
                    .OnDelete(DeleteBehavior.ClientSetNull)
                    .HasConstraintName("FK_Cliente_Opina_Cliente");

                entity.HasOne(d => d.IdServicioNavigation)
                    .WithMany(p => p.ClienteOpina)
                    .HasForeignKey(d => d.IdServicio)
                    .OnDelete(DeleteBehavior.ClientSetNull)
                    .HasConstraintName("FK_Cliente_Opina_Servicio");
            });

            modelBuilder.Entity<Cuenta>(entity =>
            {
                entity.HasKey(e => new { e.IdCuenta, e.IdCliente })
                    .HasName("PK_Cuenta_1");

                entity.Property(e => e.IdCuenta).ValueGeneratedOnAdd();

                entity.Property(e => e.Estado)
                    .HasMaxLength(50)
                    .IsUnicode(false);

                entity.Property(e => e.FechaPago).HasColumnName("Fecha_Pago");

                entity.Property(e => e.FechaVencimiento).HasColumnName("Fecha_Vencimiento");

                entity.Property(e => e.Monto).HasColumnType("money");

                entity.HasOne(d => d.IdClienteNavigation)
                    .WithMany(p => p.Cuenta)
                    .HasForeignKey(d => d.IdCliente)
                    .OnDelete(DeleteBehavior.ClientSetNull)
                    .HasConstraintName("FK_Cuenta_Cliente");
            });

            modelBuilder.Entity<Domicilio>(entity =>
            {
                entity.HasKey(e => e.IdDomicilio);

                entity.Property(e => e.Barrio)
                    .HasMaxLength(100)
                    .IsUnicode(false);

                entity.Property(e => e.Calle)
                    .IsRequired()
                    .HasMaxLength(50)
                    .IsUnicode(false);

                entity.Property(e => e.Ciudad)
                    .IsRequired()
                    .HasMaxLength(50)
                    .IsUnicode(false);

                entity.Property(e => e.Cp).HasColumnName("CP");

                entity.Property(e => e.Departamento)
                    .HasMaxLength(50)
                    .IsUnicode(false);

                entity.Property(e => e.Provincia)
                    .IsRequired()
                    .HasMaxLength(50)
                    .IsUnicode(false);

                entity.HasOne(d => d.IdPersonaNavigation)
                    .WithMany(p => p.Domicilio)
                    .HasForeignKey(d => d.IdPersona)
                    .HasConstraintName("FK_Domicilio_Persona");
            });

            modelBuilder.Entity<Emergencia>(entity =>
            {
                entity.HasKey(e => e.IdEmergencia);

                entity.HasOne(d => d.IdClienteNavigation)
                    .WithMany(p => p.Emergencia)
                    .HasForeignKey(d => d.IdCliente)
                    .OnDelete(DeleteBehavior.ClientSetNull)
                    .HasConstraintName("FK_Emergencia_Cliente");
            });

            modelBuilder.Entity<Empleado>(entity =>
            {
                entity.HasKey(e => e.IdEmpleado);

                entity.Property(e => e.Sueldo).HasColumnType("money");

                entity.HasOne(d => d.IdPersonaNavigation)
                    .WithMany(p => p.Empleado)
                    .HasForeignKey(d => d.IdPersona)
                    .OnDelete(DeleteBehavior.ClientSetNull)
                    .HasConstraintName("FK_Empleado_Persona");
            });

            modelBuilder.Entity<Factura>(entity =>
            {
                entity.HasKey(e => e.IdFactura);

                entity.Property(e => e.Fecha).HasColumnType("date");

                entity.HasOne(d => d.IdClienteNavigation)
                    .WithMany(p => p.Factura)
                    .HasForeignKey(d => d.IdCliente)
                    .OnDelete(DeleteBehavior.ClientSetNull)
                    .HasConstraintName("FK_Factura_Cliente");

                entity.HasOne(d => d.IdC)
                    .WithMany(p => p.Factura)
                    .HasForeignKey(d => new { d.IdCuenta, d.IdCliente })
                    .OnDelete(DeleteBehavior.ClientSetNull)
                    .HasConstraintName("FK_Factura_Cuenta");
            });

            modelBuilder.Entity<Jefe>(entity =>
            {
                entity.HasKey(e => e.IdJefe);

                entity.Property(e => e.Tipo)
                    .IsRequired()
                    .HasMaxLength(20)
                    .IsUnicode(false);
            });

            modelBuilder.Entity<Persona>(entity =>
            {
                entity.HasKey(e => e.IdPersona);

                entity.Property(e => e.Apellido)
                    .HasMaxLength(50)
                    .IsUnicode(false);

                entity.Property(e => e.Email)
                    .HasMaxLength(50)
                    .IsUnicode(false);

                entity.Property(e => e.FechaNacimiento).HasColumnName("Fecha_Nacimiento");

                entity.Property(e => e.Nombre)
                    .HasMaxLength(50)
                    .IsUnicode(false);

                entity.Property(e => e.Telefono)
                    .HasMaxLength(20)
                    .IsUnicode(false);
            });

            modelBuilder.Entity<Presupuesto>(entity =>
            {
                entity.HasKey(e => e.IdPresupuesto);

                entity.HasOne(d => d.IdJefeNavigation)
                    .WithMany(p => p.Presupuesto)
                    .HasForeignKey(d => d.IdJefe)
                    .OnDelete(DeleteBehavior.ClientSetNull)
                    .HasConstraintName("FK_Presupuesto_Jefe");

                entity.HasOne(d => d.IdServicioNavigation)
                    .WithMany(p => p.Presupuesto)
                    .HasForeignKey(d => d.IdServicio)
                    .OnDelete(DeleteBehavior.ClientSetNull)
                    .HasConstraintName("FK_Presupuesto_Servicio");
            });

            modelBuilder.Entity<Servicio>(entity =>
            {
                entity.HasKey(e => e.IdServicio);

                entity.Property(e => e.Descripcion)
                    .HasMaxLength(150)
                    .IsUnicode(false);

                entity.Property(e => e.Observaciones)
                    .HasMaxLength(150)
                    .IsUnicode(false);

                entity.Property(e => e.Tipo)
                    .HasMaxLength(50)
                    .IsUnicode(false);
            });

            modelBuilder.Entity<ServicioTecnico>(entity =>
            {
                entity.HasKey(e => new { e.IdTurno, e.IdTecnico });

                entity.ToTable("Servicio_Tecnico");

                entity.HasOne(d => d.IdTecnicoNavigation)
                    .WithMany(p => p.ServicioTecnico)
                    .HasForeignKey(d => d.IdTecnico)
                    .OnDelete(DeleteBehavior.ClientSetNull)
                    .HasConstraintName("FK_Servicio_Tecnico_Tecnico");

                entity.HasOne(d => d.IdTurnoNavigation)
                    .WithMany(p => p.ServicioTecnico)
                    .HasForeignKey(d => d.IdTurno)
                    .OnDelete(DeleteBehavior.ClientSetNull)
                    .HasConstraintName("FK_Servicio_Tecnico_Servicio");
            });

            modelBuilder.Entity<Tecnico>(entity =>
            {
                entity.HasKey(e => e.IdTecnico);

                entity.HasOne(d => d.IdEmpleadoNavigation)
                    .WithMany(p => p.Tecnico)
                    .HasForeignKey(d => d.IdEmpleado)
                    .OnDelete(DeleteBehavior.ClientSetNull)
                    .HasConstraintName("FK_Tecnico_Empleado");
            });

            modelBuilder.Entity<Turno>(entity =>
            {
                entity.HasKey(e => e.IdTurno);

                entity.Property(e => e.Estado)
                    .HasMaxLength(50)
                    .IsUnicode(false);

                entity.Property(e => e.Fecha).HasColumnType("date");

                entity.HasOne(d => d.IdClienteNavigation)
                    .WithMany(p => p.Turno)
                    .HasForeignKey(d => d.IdCliente)
                    .OnDelete(DeleteBehavior.ClientSetNull)
                    .HasConstraintName("FK_Turno_Cliente");

                entity.HasOne(d => d.IdServicioNavigation)
                    .WithMany(p => p.Turno)
                    .HasForeignKey(d => d.IdServicio)
                    .OnDelete(DeleteBehavior.ClientSetNull)
                    .HasConstraintName("FK_Turno_Servicio");
            });
        }
    }
}
