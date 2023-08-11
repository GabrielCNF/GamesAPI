using System;
using System.Collections.Generic;
using GamesAPI.Models;
using Microsoft.EntityFrameworkCore;

namespace AppDbContext;

public partial class DbJogosContext : DbContext
{
    public DbJogosContext()
    {
    }

    public DbJogosContext(DbContextOptions<DbJogosContext> options)
        : base(options)
    {
    }

    public virtual DbSet<Desenvolvedora> Desenvolvedoras { get; set; }

    public virtual DbSet<Distribuidora> Distribuidoras { get; set; }

    public virtual DbSet<Estilo> Estilos { get; set; }

    public virtual DbSet<Jogo> Jogos { get; set; }

    protected override void OnConfiguring(DbContextOptionsBuilder optionsBuilder)
#warning To protect potentially sensitive information in your connection string, you should move it out of source code. You can avoid scaffolding the connection string by using the Name= syntax to read it from configuration - see https://go.microsoft.com/fwlink/?linkid=2131148. For more guidance on storing connection strings, see http://go.microsoft.com/fwlink/?LinkId=723263.
        => optionsBuilder.UseSqlServer("Server=DESKTOP-66T8ILU\\SQLEXPRESS;DataBase=db_jogos;Trusted_Connection=True; Encrypt=False");

    protected override void OnModelCreating(ModelBuilder modelBuilder)
    {
        modelBuilder.Entity<Desenvolvedora>(entity =>
        {
            entity.HasKey(e => e.Id).HasName("PK__desenvol__3213E83F308BA437");

            entity.ToTable("desenvolvedora");

            entity.Property(e => e.Id).HasColumnName("id");
            entity.Property(e => e.Nome)
                .HasMaxLength(20)
                .IsUnicode(false)
                .HasColumnName("nome");
        });

        modelBuilder.Entity<Distribuidora>(entity =>
        {
            entity.HasKey(e => e.Id).HasName("PK__distribu__3213E83F72F81B90");

            entity.ToTable("distribuidora");

            entity.Property(e => e.Id).HasColumnName("id");
            entity.Property(e => e.Nome)
                .HasMaxLength(20)
                .IsUnicode(false)
                .HasColumnName("nome");
        });

        modelBuilder.Entity<Estilo>(entity =>
        {
            entity.HasKey(e => e.Id).HasName("PK__estilo__3213E83F7B2B9648");

            entity.ToTable("estilo");

            entity.Property(e => e.Id).HasColumnName("id");
            entity.Property(e => e.Nome)
                .HasMaxLength(40)
                .IsUnicode(false)
                .HasColumnName("nome");
        });

        modelBuilder.Entity<Jogo>(entity =>
        {
            entity.HasKey(e => e.Id).HasName("PK__jogos__3213E83F9EA224BF");

            entity.ToTable("jogos");

            entity.Property(e => e.Id).HasColumnName("id");
            entity.Property(e => e.DataLancamento)
                .HasColumnType("date")
                .HasColumnName("data_lancamento");
            entity.Property(e => e.DesenvolvedoraId).HasColumnName("desenvolvedora_id");
            entity.Property(e => e.DistribuidoraId).HasColumnName("distribuidora_id");
            entity.Property(e => e.EstiloId).HasColumnName("estilo_id");
            entity.Property(e => e.EstiloSecId).HasColumnName("estilo_sec_id");
            entity.Property(e => e.EstiloTercId).HasColumnName("estilo_terc_id");
            entity.Property(e => e.Nome)
                .HasMaxLength(40)
                .IsUnicode(false)
                .HasColumnName("nome");

            entity.HasOne(d => d.Desenvolvedora).WithMany(p => p.Jogos)
                .HasForeignKey(d => d.DesenvolvedoraId)
                .HasConstraintName("FK__jogos__desenvolv__35BCFE0A");

            entity.HasOne(d => d.Distribuidora).WithMany(p => p.Jogos)
                .HasForeignKey(d => d.DistribuidoraId)
                .HasConstraintName("FK__jogos__distribui__36B12243");

            entity.HasOne(d => d.Estilo).WithMany(p => p.JogoEstilos)
                .HasForeignKey(d => d.EstiloId)
                .OnDelete(DeleteBehavior.ClientSetNull)
                .HasConstraintName("FK__jogos__estilo_id__32E0915F");

            entity.HasOne(d => d.EstiloSec).WithMany(p => p.JogoEstiloSecs)
                .HasForeignKey(d => d.EstiloSecId)
                .HasConstraintName("FK__jogos__estilo_se__33D4B598");

            entity.HasOne(d => d.EstiloTerc).WithMany(p => p.JogoEstiloTercs)
                .HasForeignKey(d => d.EstiloTercId)
                .HasConstraintName("FK__jogos__estilo_te__34C8D9D1");
        });

        OnModelCreatingPartial(modelBuilder);
    }

    partial void OnModelCreatingPartial(ModelBuilder modelBuilder);
}
