using System;
using Microsoft.EntityFrameworkCore;
using Microsoft.EntityFrameworkCore.Metadata;

#nullable disable

namespace TemplateWorker.Models
{
    public partial class MedPrimeCost_MISDEC_DEMOContext : DbContext
    {
        public MedPrimeCost_MISDEC_DEMOContext()
        {
        }

        public MedPrimeCost_MISDEC_DEMOContext(DbContextOptions<MedPrimeCost_MISDEC_DEMOContext> options)
            : base(options)
        {
        }

        public virtual DbSet<EhealthTemplate> EhealthTemplates { get; set; }

        protected override void OnConfiguring(DbContextOptionsBuilder optionsBuilder)
        {
            if (!optionsBuilder.IsConfigured)
            {
#warning To protect potentially sensitive information in your connection string, you should move it out of source code. You can avoid scaffolding the connection string by using the Name= syntax to read it from configuration - see https://go.microsoft.com/fwlink/?linkid=2131148. For more guidance on storing connection strings, see http://go.microsoft.com/fwlink/?LinkId=723263.
                optionsBuilder.UseSqlServer("Server=192.168.88.49,1433;Database=MedPrimeCost_MISDEC_DEMO;User ID=sa;Password=NtrjvtL2020;");
            }
        }

        protected override void OnModelCreating(ModelBuilder modelBuilder)
        {
            modelBuilder.HasAnnotation("Relational:Collation", "Cyrillic_General_CI_AS");

            modelBuilder.Entity<EhealthTemplate>(entity =>
            {
                entity.HasKey(e => e.IdTemplate)
                    .HasName("PK_EHealth_Template.IdTemplate");

                entity.ToTable("EHealth_Template");

                entity.Property(e => e.Comment).HasMaxLength(1000);

                entity.Property(e => e.EditBegin)
                    .HasColumnType("datetime")
                    .HasColumnName("Edit_Begin");

                entity.Property(e => e.EditClientId)
                    .HasMaxLength(100)
                    .IsUnicode(false)
                    .HasColumnName("Edit_ClientID");

                entity.Property(e => e.EditIdUser).HasColumnName("Edit_IdUser");

                entity.Property(e => e.EditLastSave)
                    .HasColumnType("datetime")
                    .HasColumnName("Edit_LastSave");

                entity.Property(e => e.EditTextData).HasColumnName("Edit_TextData");

                entity.Property(e => e.GuidTemplate).HasDefaultValueSql("(newid())");

                entity.Property(e => e.IdDocumentType).HasDefaultValueSql("((1))");

                entity.Property(e => e.LabelTemplate)
                    .IsRequired()
                    .HasMaxLength(100);

                entity.Property(e => e.Properties).HasColumnType("xml");

                entity.Property(e => e.Timestamp)
                    .IsRequired()
                    .IsRowVersion()
                    .IsConcurrencyToken();
            });

            OnModelCreatingPartial(modelBuilder);
        }

        partial void OnModelCreatingPartial(ModelBuilder modelBuilder);
    }
}
