using Microsoft.EntityFrameworkCore;

namespace Persistance.Models
{
	public partial class RestaurantContext : DbContext
	{
		public RestaurantContext() { }

		public RestaurantContext(DbContextOptions<RestaurantContext> options)
			: base(options) { }

		public virtual DbSet<Balance> Balances { get; set; } = null!;
		public virtual DbSet<Meal> Meals { get; set; } = null!;
		public virtual DbSet<MealPricing> MealPricings { get; set; } = null!;

		protected override void OnConfiguring(DbContextOptionsBuilder optionsBuilder)
		{
			if (!optionsBuilder.IsConfigured)
			{
				optionsBuilder.UseSqlServer("server=DESKTOP-OO326C9\\SQLEXPRESS;database= Restaurant;Trusted_Connection=True; Encrypt=False;");
			}
		}

		protected override void OnModelCreating(ModelBuilder modelBuilder)
		{
			modelBuilder.Entity<Balance>(entity =>
			{
				entity.ToTable("Balance");

				entity.Property(e => e.Balance1).HasColumnName("Balance");
			});

			modelBuilder.Entity<Meal>(entity =>
			{
				entity.ToTable("Meal");

				entity.Property(e => e.CreatedAt).HasColumnType("date");

				entity.Property(e => e.CreatedBy).HasColumnType("date");

				entity.Property(e => e.Description)
					.HasMaxLength(500)
					.IsUnicode(false);

				entity.Property(e => e.Name)
					.HasMaxLength(100)
					.IsUnicode(false);

				entity.Property(e => e.UpdatedAt).HasColumnType("date");

				entity.Property(e => e.UpdatedBy).HasColumnType("date");

				entity.HasOne(d => d.Price)
					.WithMany(p => p.Meals)
					.HasForeignKey(d => d.PriceId)
					.OnDelete(DeleteBehavior.ClientSetNull)
					.HasConstraintName("FK_Meal_MealPricing");
			});

			modelBuilder.Entity<MealPricing>(entity =>
			{
				entity.ToTable("MealPricing");
			});

			OnModelCreatingPartial(modelBuilder);
		}

		partial void OnModelCreatingPartial(ModelBuilder modelBuilder);
	}
}
