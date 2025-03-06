using System;
using System.Collections.Generic;
using Microsoft.EntityFrameworkCore;

namespace OnlineRailwayReservationSystem.Models;

public partial class OnlineRailwayReservationSystemDbContext : DbContext
{
    public OnlineRailwayReservationSystemDbContext()
    {
    }

    public OnlineRailwayReservationSystemDbContext(DbContextOptions<OnlineRailwayReservationSystemDbContext> options)
        : base(options)
    {
    }

    public virtual DbSet<Class> Classes { get; set; }

    public virtual DbSet<Coach> Coaches { get; set; }

    public virtual DbSet<Fare> Fares { get; set; }

    public virtual DbSet<Payment> Payments { get; set; }

    public virtual DbSet<Query> Queries { get; set; }

    public virtual DbSet<QueryList> QueryLists { get; set; }

    public virtual DbSet<Quotum> Quota { get; set; }

    public virtual DbSet<ReservationDetail> ReservationDetails { get; set; }

    public virtual DbSet<Role> Roles { get; set; }

    public virtual DbSet<Route> Routes { get; set; }

    public virtual DbSet<Seat> Seats { get; set; }

    public virtual DbSet<Support> Supports { get; set; }

    public virtual DbSet<Ticket> Tickets { get; set; }

    public virtual DbSet<Train> Trains { get; set; }

    public virtual DbSet<TrainClass> TrainClasses { get; set; }

    public virtual DbSet<TrainQoutum> TrainQouta { get; set; }

    public virtual DbSet<User> Users { get; set; }

    public virtual DbSet<UserRole> UserRoles { get; set; }

    protected override void OnConfiguring(DbContextOptionsBuilder optionsBuilder)
#warning To protect potentially sensitive information in your connection string, you should move it out of source code. You can avoid scaffolding the connection string by using the Name= syntax to read it from configuration - see https://go.microsoft.com/fwlink/?linkid=2131148. For more guidance on storing connection strings, see https://go.microsoft.com/fwlink/?LinkId=723263.
        => optionsBuilder.UseSqlServer("server=(localdb)\\MsSqlLocalDb;Trusted_Connection=True;Database=OnlineRailwayReservationSystemDb ;TrustServerCertificate=yes");

    protected override void OnModelCreating(ModelBuilder modelBuilder)
    {
        modelBuilder.Entity<Class>(entity =>
        {
            entity.HasKey(e => e.ClassId).HasName("PK__Class__CB1927C0A4EFD172");

            entity.ToTable("Class");

            entity.Property(e => e.ClassId)
                .HasMaxLength(10)
                .IsUnicode(false);
            entity.Property(e => e.ClassName)
                .HasMaxLength(20)
                .IsUnicode(false);
            entity.Property(e => e.ClassType)
                .HasMaxLength(20)
                .IsUnicode(false);
        });

        modelBuilder.Entity<Coach>(entity =>
        {
            entity.HasKey(e => e.CoachId).HasName("PK__Coach__F411D941A8C7483E");

            entity.ToTable("Coach");

            entity.Property(e => e.CoachId)
                .HasMaxLength(10)
                .IsUnicode(false);
            entity.Property(e => e.ClassId)
                .HasMaxLength(10)
                .IsUnicode(false);
            entity.Property(e => e.CoachNumber)
                .HasMaxLength(10)
                .IsUnicode(false);

            entity.HasOne(d => d.Class).WithMany(p => p.Coaches)
                .HasForeignKey(d => d.ClassId)
                .HasConstraintName("FK__Coach__ClassId__3C69FB99");
        });

        modelBuilder.Entity<Fare>(entity =>
        {
            entity.HasKey(e => e.FareId).HasName("PK__Fare__1261FA16727C7955");

            entity.ToTable("Fare");

            entity.Property(e => e.FareId)
                .HasMaxLength(10)
                .IsUnicode(false);
            entity.Property(e => e.CancelCharge12hrs).HasColumnName("CancelCharge_12hrs");
            entity.Property(e => e.CancelCharge48hrs).HasColumnName("CancelCharge_48hrs");
            entity.Property(e => e.CancelCharge4hrs).HasColumnName("CancelCharge_4hrs");
            entity.Property(e => e.ClassId)
                .HasMaxLength(10)
                .IsUnicode(false);

            entity.HasOne(d => d.Class).WithMany(p => p.Fares)
                .HasForeignKey(d => d.ClassId)
                .HasConstraintName("FK__Fare__ClassId__47DBAE45");
        });

        modelBuilder.Entity<Payment>(entity =>
        {
            entity.HasKey(e => e.PaymentId).HasName("PK__Payment__9B556A3851D9EFE1");

            entity.ToTable("Payment");

            entity.Property(e => e.PaymentId)
                .HasMaxLength(10)
                .IsUnicode(false);
            entity.Property(e => e.PaymentMode)
                .HasMaxLength(20)
                .IsUnicode(false);
            entity.Property(e => e.Status)
                .HasMaxLength(10)
                .IsUnicode(false);
            entity.Property(e => e.TicketId)
                .HasMaxLength(10)
                .IsUnicode(false);
            entity.Property(e => e.UserId)
                .HasMaxLength(10)
                .IsUnicode(false);

            entity.HasOne(d => d.Ticket).WithMany(p => p.Payments)
                .HasForeignKey(d => d.TicketId)
                .OnDelete(DeleteBehavior.ClientSetNull)
                .HasConstraintName("FK__Payment__TicketI__4BAC3F29");

            entity.HasOne(d => d.User).WithMany(p => p.Payments)
                .HasForeignKey(d => d.UserId)
                .OnDelete(DeleteBehavior.ClientSetNull)
                .HasConstraintName("FK__Payment__UserId__4AB81AF0");
        });

        modelBuilder.Entity<Query>(entity =>
        {
            entity.HasKey(e => e.QueryId).HasName("PK__Query__5967F7DBAAE7019F");

            entity.ToTable("Query");

            entity.Property(e => e.QueryId)
                .HasMaxLength(10)
                .IsUnicode(false);
            entity.Property(e => e.Keywords)
                .HasMaxLength(100)
                .IsUnicode(false);
        });

        modelBuilder.Entity<QueryList>(entity =>
        {
            entity.HasKey(e => e.QueryListId).HasName("PK__QueryLis__ACD72B5FB4AAB836");

            entity.ToTable("QueryList");

            entity.Property(e => e.QueryListId)
                .HasMaxLength(10)
                .IsUnicode(false);
            entity.Property(e => e.QueryDescription)
                .HasMaxLength(100)
                .IsUnicode(false);
            entity.Property(e => e.QueryId)
                .HasMaxLength(10)
                .IsUnicode(false);

            entity.HasOne(d => d.Query).WithMany(p => p.QueryLists)
                .HasForeignKey(d => d.QueryId)
                .HasConstraintName("FK__QueryList__Query__5812160E");
        });

        modelBuilder.Entity<Quotum>(entity =>
        {
            entity.HasKey(e => e.QuotaId).HasName("PK__Quota__AE96C9C27466D3BF");

            entity.Property(e => e.QuotaId)
                .HasMaxLength(10)
                .IsUnicode(false);
            entity.Property(e => e.QuotaType)
                .HasMaxLength(10)
                .IsUnicode(false);
        });

        modelBuilder.Entity<ReservationDetail>(entity =>
        {
            entity.HasKey(e => e.ReservationId).HasName("PK__Reservat__B7EE5F24589DD8A8");

            entity.Property(e => e.ReservationId)
                .HasMaxLength(10)
                .IsUnicode(false);
            entity.Property(e => e.Address).HasColumnType("text");
            entity.Property(e => e.Gender)
                .HasMaxLength(10)
                .IsUnicode(false);
            entity.Property(e => e.Name)
                .HasMaxLength(30)
                .IsUnicode(false);
            entity.Property(e => e.PaymentId)
                .HasMaxLength(10)
                .IsUnicode(false);
            entity.Property(e => e.TicketId)
                .HasMaxLength(10)
                .IsUnicode(false);
            entity.Property(e => e.UserId)
                .HasMaxLength(10)
                .IsUnicode(false);

            entity.HasOne(d => d.Payment).WithMany(p => p.ReservationDetails)
                .HasForeignKey(d => d.PaymentId)
                .OnDelete(DeleteBehavior.ClientSetNull)
                .HasConstraintName("FK__Reservati__Payme__534D60F1");

            entity.HasOne(d => d.Ticket).WithMany(p => p.ReservationDetails)
                .HasForeignKey(d => d.TicketId)
                .OnDelete(DeleteBehavior.ClientSetNull)
                .HasConstraintName("FK__Reservati__Ticke__5070F446");

            entity.HasOne(d => d.User).WithMany(p => p.ReservationDetails)
                .HasForeignKey(d => d.UserId)
                .OnDelete(DeleteBehavior.ClientSetNull)
                .HasConstraintName("FK__Reservati__UserI__5165187F");
        });

        modelBuilder.Entity<Role>(entity =>
        {
            entity.HasKey(e => e.RoleId).HasName("PK__Roles__8AFACE1A58E749F9");

            entity.Property(e => e.RoleId)
                .HasMaxLength(10)
                .IsUnicode(false);
            entity.Property(e => e.RoleName)
                .HasMaxLength(20)
                .IsUnicode(false);
        });

        modelBuilder.Entity<Route>(entity =>
        {
            entity.HasKey(e => e.RouteId).HasName("PK__Route__80979AAD6B2E275F");

            entity.ToTable("Route");

            entity.Property(e => e.RouteId)
                .HasMaxLength(10)
                .IsUnicode(false)
                .HasColumnName("RouteID");
            entity.Property(e => e.Destination)
                .HasMaxLength(20)
                .IsUnicode(false);
            entity.Property(e => e.Duration)
                .HasMaxLength(20)
                .IsUnicode(false);
            entity.Property(e => e.Source)
                .HasMaxLength(20)
                .IsUnicode(false);
        });

        modelBuilder.Entity<Seat>(entity =>
        {
            entity.HasKey(e => e.SeatId).HasName("PK__Seat__311713F3F068FE4C");

            entity.ToTable("Seat");

            entity.Property(e => e.SeatId)
                .HasMaxLength(10)
                .IsUnicode(false);
            entity.Property(e => e.AvailabilityStatus).HasDefaultValue(true);
            entity.Property(e => e.CoachId)
                .HasMaxLength(10)
                .IsUnicode(false);

            entity.HasOne(d => d.Coach).WithMany(p => p.Seats)
                .HasForeignKey(d => d.CoachId)
                .HasConstraintName("FK__Seat__CoachId__403A8C7D");
        });

        modelBuilder.Entity<Support>(entity =>
        {
            entity.HasKey(e => e.SupportId).HasName("PK__Support__D82DBC8CC0E81699");

            entity.ToTable("Support");

            entity.Property(e => e.SupportId)
                .HasMaxLength(10)
                .IsUnicode(false);
            entity.Property(e => e.QueryListId)
                .HasMaxLength(10)
                .IsUnicode(false);
            entity.Property(e => e.QueryText)
                .HasMaxLength(100)
                .IsUnicode(false);
            entity.Property(e => e.Status)
                .HasMaxLength(20)
                .IsUnicode(false);
            entity.Property(e => e.UserId)
                .HasMaxLength(10)
                .IsUnicode(false);

            entity.HasOne(d => d.QueryList).WithMany(p => p.Supports)
                .HasForeignKey(d => d.QueryListId)
                .HasConstraintName("FK__Support__QueryLi__5BE2A6F2");

            entity.HasOne(d => d.User).WithMany(p => p.Supports)
                .HasForeignKey(d => d.UserId)
                .HasConstraintName("FK__Support__UserId__5AEE82B9");
        });

        modelBuilder.Entity<Ticket>(entity =>
        {
            entity.HasKey(e => e.TicketId).HasName("PK__Ticket__712CC60722E2AC57");

            entity.ToTable("Ticket");

            entity.Property(e => e.TicketId)
                .HasMaxLength(10)
                .IsUnicode(false);
            entity.Property(e => e.ClassName)
                .HasMaxLength(30)
                .IsUnicode(false);
            entity.Property(e => e.Coach)
                .HasMaxLength(5)
                .IsUnicode(false);
            entity.Property(e => e.DestinationStation)
                .HasMaxLength(20)
                .IsUnicode(false);
            entity.Property(e => e.JourneyEndDate).HasColumnType("datetime");
            entity.Property(e => e.JourneyStartDate).HasColumnType("datetime");
            entity.Property(e => e.Pnr)
                .HasMaxLength(10)
                .IsUnicode(false)
                .HasColumnName("PNR");
            entity.Property(e => e.SeatNumber)
                .HasMaxLength(5)
                .IsUnicode(false);
            entity.Property(e => e.SourceStation)
                .HasMaxLength(20)
                .IsUnicode(false);
            entity.Property(e => e.TicketStatus)
                .HasMaxLength(10)
                .IsUnicode(false);
            entity.Property(e => e.TrainId)
                .HasMaxLength(10)
                .IsUnicode(false);
            entity.Property(e => e.UserId)
                .HasMaxLength(10)
                .IsUnicode(false);

            entity.HasOne(d => d.Train).WithMany(p => p.Tickets)
                .HasForeignKey(d => d.TrainId)
                .HasConstraintName("FK__Ticket__TrainId__440B1D61");

            entity.HasOne(d => d.User).WithMany(p => p.Tickets)
                .HasForeignKey(d => d.UserId)
                .HasConstraintName("FK__Ticket__UserId__4316F928");
        });

        modelBuilder.Entity<Train>(entity =>
        {
            entity.HasKey(e => e.TrainId).HasName("PK__Train__8ED2723A6AE5AD76");

            entity.ToTable("Train");

            entity.Property(e => e.TrainId)
                .HasMaxLength(10)
                .IsUnicode(false);
            entity.Property(e => e.Route)
                .HasMaxLength(30)
                .IsUnicode(false);
            entity.Property(e => e.RunningDay)
                .HasMaxLength(10)
                .IsUnicode(false);
            entity.Property(e => e.TrainName)
                .HasMaxLength(30)
                .IsUnicode(false);
            entity.Property(e => e.TrainNumber)
                .HasMaxLength(10)
                .IsUnicode(false);
        });

        modelBuilder.Entity<TrainClass>(entity =>
        {
            entity
                .HasNoKey()
                .ToTable("TrainClass");

            entity.Property(e => e.ClassId)
                .HasMaxLength(10)
                .IsUnicode(false);
            entity.Property(e => e.TrainId)
                .HasMaxLength(10)
                .IsUnicode(false);

            entity.HasOne(d => d.Class).WithMany()
                .HasForeignKey(d => d.ClassId)
                .OnDelete(DeleteBehavior.ClientSetNull)
                .HasConstraintName("FK__TrainClas__Class__38996AB5");

            entity.HasOne(d => d.Train).WithMany()
                .HasForeignKey(d => d.TrainId)
                .OnDelete(DeleteBehavior.ClientSetNull)
                .HasConstraintName("FK__TrainClas__Train__398D8EEE");
        });

        modelBuilder.Entity<TrainQoutum>(entity =>
        {
            entity.HasNoKey();

            entity.Property(e => e.QuotaId)
                .HasMaxLength(10)
                .IsUnicode(false);
            entity.Property(e => e.TrainId)
                .HasMaxLength(10)
                .IsUnicode(false);

            entity.HasOne(d => d.Quota).WithMany()
                .HasForeignKey(d => d.QuotaId)
                .OnDelete(DeleteBehavior.ClientSetNull)
                .HasConstraintName("FK__TrainQout__Quota__31EC6D26");

            entity.HasOne(d => d.Train).WithMany()
                .HasForeignKey(d => d.TrainId)
                .OnDelete(DeleteBehavior.ClientSetNull)
                .HasConstraintName("FK__TrainQout__Train__32E0915F");
        });

        modelBuilder.Entity<User>(entity =>
        {
            entity.HasKey(e => e.UserId).HasName("PK__Users__1788CC4C73D1764D");

            entity.Property(e => e.UserId)
                .HasMaxLength(10)
                .IsUnicode(false);
            entity.Property(e => e.Email)
                .HasMaxLength(50)
                .IsUnicode(false);
            entity.Property(e => e.Name)
                .HasMaxLength(20)
                .IsUnicode(false);
            entity.Property(e => e.Password)
                .HasMaxLength(20)
                .IsUnicode(false);
            entity.Property(e => e.Phone)
                .HasMaxLength(10)
                .IsUnicode(false);
        });

        modelBuilder.Entity<UserRole>(entity =>
        {
            entity.HasKey(e => e.UserId).HasName("PK__UserRole__1788CC4C930A01EE");

            entity.Property(e => e.UserId)
                .HasMaxLength(10)
                .IsUnicode(false);
            entity.Property(e => e.RoleId)
                .HasMaxLength(10)
                .IsUnicode(false);

            entity.HasOne(d => d.Role).WithMany(p => p.UserRoles)
                .HasForeignKey(d => d.RoleId)
                .HasConstraintName("FK__UserRoles__RoleI__29572725");

            entity.HasOne(d => d.User).WithOne(p => p.UserRole)
                .HasForeignKey<UserRole>(d => d.UserId)
                .OnDelete(DeleteBehavior.ClientSetNull)
                .HasConstraintName("FK__UserRoles__UserI__286302EC");
        });

        OnModelCreatingPartial(modelBuilder);
    }

    partial void OnModelCreatingPartial(ModelBuilder modelBuilder);
}
