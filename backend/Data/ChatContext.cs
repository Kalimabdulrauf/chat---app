using Microsoft.EntityFrameworkCore;
using ChatApp.Models;

namespace ChatApp.Data
{
    public class ChatContext : DbContext
    {
        public ChatContext(DbContextOptions<ChatContext> options) : base(options) { }

        public DbSet<User> Users { get; set; }
        public DbSet<Message> Messages { get; set; }
    }
}

