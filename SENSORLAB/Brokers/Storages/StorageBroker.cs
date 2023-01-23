using Microsoft.EntityFrameworkCore;
using SENSORLAB.Models;

namespace SENSORLAB.Brokers.Storages
{
    public partial class StorageBroker : DbContext , IStorageBroker
    {
        private readonly IConfiguration configuration;

        public StorageBroker(IConfiguration configuration)
        {
            this.configuration = configuration;
        }
        protected override void OnConfiguring(DbContextOptionsBuilder optionsBuilder)
        {
            if (!optionsBuilder.IsConfigured)
            {
                string connectionString = this.configuration.GetConnectionString("DefaultConnection");
                optionsBuilder.UseSqlServer(connectionString);
            }
        }

        protected override void OnModelCreating(ModelBuilder modelBuilder)
        {
            modelBuilder.Entity<Cliente>(entity =>
            {
                entity.HasKey(e => e.IdCliente)
                    .HasName("PK__CLIENTE__23A3413052B14A03");

                entity.ToTable("CLIENTE");

                entity.Property(e => e.IdCliente)
                    .ValueGeneratedNever()
                    .HasColumnName("ID_CLIENTE");

                entity.Property(e => e.Fecha)
                    .HasColumnType("date")
                    .HasColumnName("FECHA");

                entity.Property(e => e.Nacionalidad)
                    .HasMaxLength(50)
                    .IsUnicode(false)
                    .HasColumnName("NACIONALIDAD");

                entity.Property(e => e.Nombre)
                    .HasMaxLength(50)
                    .IsUnicode(false)
                    .HasColumnName("NOMBRE");

                entity.Property(e => e.Premium).HasColumnName("PREMIUM");
            });

            modelBuilder.Entity<ClienteSensor>(entity =>
            {
                entity.HasKey(e => new { e.IdEvento, e.IdCliente, e.IdSensor })
                    .HasName("PK__CLIENTE___A5E7D68EA805423E");

                entity.ToTable("CLIENTE_SENSOR");

                entity.Property(e => e.IdEvento).HasColumnName("ID_EVENTO");

                entity.Property(e => e.IdCliente).HasColumnName("ID_CLIENTE");

                entity.Property(e => e.IdSensor).HasColumnName("ID_SENSOR");

                entity.Property(e => e.Custom1).HasColumnName("CUSTOM1");

                entity.Property(e => e.Custom2).HasColumnName("CUSTOM2");

                entity.Property(e => e.Custom3).HasColumnName("CUSTOM3");

                entity.Property(e => e.Historico)
                    .HasColumnType("datetime")
                    .HasColumnName("HISTORICO");

                entity.Property(e => e.Hum).HasColumnName("HUM");

                entity.Property(e => e.Temp).HasColumnName("TEMP");

                entity.Property(e => e.Ubi)
                    .HasMaxLength(50)
                    .IsUnicode(false)
                    .HasColumnName("UBI");

                entity.HasOne(d => d.IdClienteNavigation)
                    .WithMany(p => p.ClienteSensors)
                    .HasForeignKey(d => d.IdCliente)
                    .OnDelete(DeleteBehavior.ClientSetNull)
                    .HasConstraintName("FK__CLIENTE_S__ID_CL__4E88ABD4");

                entity.HasOne(d => d.IdSensorNavigation)
                    .WithMany(p => p.ClienteSensors)
                    .HasForeignKey(d => d.IdSensor)
                    .OnDelete(DeleteBehavior.ClientSetNull)
                    .HasConstraintName("FK__CLIENTE_S__ID_SE__4F7CD00D");
            });

            modelBuilder.Entity<Sensor>(entity =>
            {
                entity.HasKey(e => e.IdSensor)
                    .HasName("PK__SENSOR__509DA8C21725A6A9");

                entity.ToTable("SENSOR");

                entity.Property(e => e.IdSensor)
                    .ValueGeneratedNever()
                    .HasColumnName("ID_SENSOR");

                entity.Property(e => e.Fabricante)
                    .HasMaxLength(50)
                    .IsUnicode(false)
                    .HasColumnName("FABRICANTE");
            });

            OnModelCreatingPartial(modelBuilder);
        }

        partial void OnModelCreatingPartial(ModelBuilder modelBuilder);
    }
}
