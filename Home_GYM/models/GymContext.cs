using System;
using System.Collections.Generic;
using Microsoft.EntityFrameworkCore;
using Microsoft.EntityFrameworkCore.Metadata;

namespace Home_GYM.models
{
    public partial class GymContext : DbContext
    {
        public GymContext()
        {
        }

        public GymContext(DbContextOptions<GymContext> options)
            : base(options)
        {
        }

        public virtual DbSet<UserClient> UserClients { get; set; }
        public virtual DbSet<UserGym> UserGyms { get; set; }
        public virtual DbSet<training> training { get; set; }

        protected override void OnConfiguring(DbContextOptionsBuilder optionsBuilder)
        {
            if (!optionsBuilder.IsConfigured)
            {
#warning To protect potentially sensitive information in your connection string, you should move it out of source code. You can avoid scaffolding the connection string by using the Name= syntax to read it from configuration - see https://go.microsoft.com/fwlink/?linkid=2131148. For more guidance on storing connection strings, see http://go.microsoft.com/fwlink/?LinkId=723263.
                optionsBuilder.UseSqlServer("Server=LAPTOP-AD7NUIO9;Database=Gym;Trusted_Connection=True;");
            }
        }

        protected override void OnModelCreating(ModelBuilder modelBuilder)
        {
            modelBuilder.Entity<UserClient>(entity =>
            {
                entity.ToTable("User_Client");

                entity.Property(e => e.Id).HasColumnName("id");

                entity.Property(e => e.DateOfregister)
                    .HasColumnType("date")
                    .HasColumnName("DateOFRegister");

                entity.HasOne(d => d.IduserNavigation)
                    .WithMany(p => p.UserClients)
                    .HasForeignKey(d => d.Iduser)
                    .HasConstraintName("DatpayUser");
            });

            modelBuilder.Entity<UserGym>(entity =>
            {
                entity.ToTable("User_Gym");

                entity.Property(e => e.Id).HasColumnName("id");

                entity.Property(e => e.Email).IsUnicode(false);

                entity.Property(e => e.NameUser).IsUnicode(false);

                entity.Property(e => e.Password)
                    .HasMaxLength(50)
                    .IsUnicode(false)
                    .HasColumnName("password");

                entity.Property(e => e.Phone)
                    .HasMaxLength(11)
                    .IsUnicode(false)
                    .HasColumnName("phone");

                entity.Property(e => e.TypeUser)
                    .HasMaxLength(50)
                    .IsUnicode(false)
                    .HasColumnName("TypeUSer");
            });

            modelBuilder.Entity<training>(entity =>
            {
                entity.Property(e => e.Id).HasColumnName("id");

                entity.Property(e => e.Typetraining)
                    .HasMaxLength(350)
                    .IsUnicode(false);
            });

            OnModelCreatingPartial(modelBuilder);
        }

        partial void OnModelCreatingPartial(ModelBuilder modelBuilder);
    }
}
