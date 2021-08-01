using Microsoft.AspNetCore.Identity.EntityFrameworkCore;
using Microsoft.EntityFrameworkCore;

namespace Chatroom.Server.EntityContext
{
    public class MessengerUserDbContext : IdentityDbContext<MessengerUser>
    {
        public MessengerUserDbContext(DbContextOptions<MessengerUserDbContext> options) : base(options)
        {
        }

        protected override void OnModelCreating(ModelBuilder builder)
        {
            base.OnModelCreating(builder);
        }
    }
}
