using System;
using System.Collections.Generic;
using Microsoft.EntityFrameworkCore;

namespace Hotel;

public partial class SqliteContext : DbContext
{
    public SqliteContext()
    {
    }

    public SqliteContext(DbContextOptions<SqliteContext> options)
        : base(options)
    {
    }

    public virtual DbSet<Room> Rooms { get; set; }

    protected override void OnConfiguring(DbContextOptionsBuilder optionsBuilder)
#warning To protect potentially sensitive information in your connection string, you should move it out of source code. You can avoid scaffolding the connection string by using the Name= syntax to read it from configuration - see https://go.microsoft.com/fwlink/?linkid=2131148. For more guidance on storing connection strings, see https://go.microsoft.com/fwlink/?LinkId=723263.
        => optionsBuilder.UseSqlite("Data Source=../../../SQLite.db");

    protected override void OnModelCreating(ModelBuilder modelBuilder)
    {
        modelBuilder.Entity<Room>(entity =>
        {
            entity.ToTable("Room");

            entity.HasIndex(e => e.Id, "IX_Room_id").IsUnique();

            entity.Property(e => e.Id).HasColumnName("id");
            entity.Property(e => e.AarrivalDate).HasColumnName("aarrivalDate");
            entity.Property(e => e.Animal)
                .HasColumnType("INTEGER (0, 1)")
                .HasColumnName("animal");
            entity.Property(e => e.Birthday).HasColumnName("birthday");
            entity.Property(e => e.DaateOfdeparture).HasColumnName("daateOfdeparture");
            entity.Property(e => e.Days).HasColumnName("days");
            entity.Property(e => e.Defrayment).HasColumnName("defrayment");
            entity.Property(e => e.FullName).HasColumnName("fullName");
            entity.Property(e => e.Picture).HasColumnName("picture");
            entity.Property(e => e.Room1)
                .HasColumnType("INTEGER (0, 499)")
                .HasColumnName("room");
            entity.Property(e => e.Statuc).HasColumnName("statuc");
        });

        OnModelCreatingPartial(modelBuilder);
    }

    partial void OnModelCreatingPartial(ModelBuilder modelBuilder);
}
