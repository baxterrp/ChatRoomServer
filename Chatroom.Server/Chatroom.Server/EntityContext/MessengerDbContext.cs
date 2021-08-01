using Chatroom.Server.Models;
using Microsoft.EntityFrameworkCore;

namespace Chatroom.Server.EntityContext
{
    public class MessengerDbContext : DbContext
    {
        public MessengerDbContext(DbContextOptions<MessengerDbContext> options) : base(options)
        {
        }

        DbSet<MessagePackage> Packages { get; set; }
        DbSet<Room> Rooms { get; set; }

        protected override void OnModelCreating(ModelBuilder builder)
        {
            base.OnModelCreating(builder);
        }
    }
}
