using Microsoft.EntityFrameworkCore;

namespace ChatRoom.Models
{
	public class RealTimeDbContext(DbContextOptions<RealTimeDbContext> options) : DbContext(options)
	{
		public DbSet<User> Users { get; set; }
		public DbSet<Message> Messages { get; set; }


		protected override void OnModelCreating(ModelBuilder modelBuilder)
		{
			base.OnModelCreating(modelBuilder);
		}
	}
}
