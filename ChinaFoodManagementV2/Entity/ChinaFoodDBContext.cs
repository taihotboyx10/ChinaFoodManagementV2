using Microsoft.EntityFrameworkCore;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace ChinaFoodManagementV2.Entity
{
    public class ChinaFoodDBContext:DbContext
    {
        string connectionStr = "Data Source=DESKTOP-BV5B025;Initial Catalog=ChinaFood;Integrated Security=True;";

        public DbSet<Reservation> Reservations { get; set; }
        public DbSet<Account> Accounts { get; set; }
        public DbSet<Category> Categories { get; set; }
        public DbSet<Food> Foods { get; set; }
        public DbSet<BillInfo> BillInfos { get; set; }
        public DbSet<Bill> Bills { get; set; }
        public DbSet<Table> Tables { get; set; }
        protected override void OnConfiguring(DbContextOptionsBuilder optionsBuilder)
        {
            base.OnConfiguring(optionsBuilder);
            optionsBuilder.UseSqlServer(connectionStr);
        }

        protected override void OnModelCreating(ModelBuilder modelBuilder)
        {
            base.OnModelCreating(modelBuilder);

            modelBuilder.Entity<Food>(entity =>
            {
                entity.HasOne(f => f.Category)
                .WithMany()
                .HasForeignKey(f => f.CategoryId)
                .OnDelete(DeleteBehavior.SetNull);
            });

            modelBuilder.Entity<BillInfo>(entity =>
            {
                entity.HasOne(b => b.Food)
                .WithMany()
                .HasForeignKey(b => b.FoodId)
                .OnDelete(DeleteBehavior.Cascade);
            });

            modelBuilder.Entity<BillInfo>(entity =>
            {
                entity.HasOne(b => b.Bill)
                .WithMany()
                .HasForeignKey(b => b.BillId)
                .OnDelete(DeleteBehavior.NoAction);
            });

            modelBuilder.Entity<Bill>(entity =>
            {
                entity.HasOne(b => b.Table)
                .WithMany()
                .HasForeignKey(b => b.TableId)
                .OnDelete(DeleteBehavior.NoAction);
            });
        }
    }
}
