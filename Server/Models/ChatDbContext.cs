using Microsoft.EntityFrameworkCore;

namespace Server.Models
{
    public class ChatDbContext : DbContext
    {
        public DbSet<LoginPassword> Logins_Passwords { get; set; }
        public DbSet<User> Users { get; set; } 
        public DbSet<Role> Roles { get; set; } 
        public DbSet<Message> Messages { get; set; } 
        public DbSet<Chat> Chats { get; set; } 
        public DbSet<BannedUser> BannedUsers { get; set; } 

        public ChatDbContext(DbContextOptions<ChatDbContext> options) : base(options)
        {
            Database.EnsureCreated();
        }

        protected override void OnModelCreating(ModelBuilder modelBuilder)
        {
            foreach (var relationship in modelBuilder.Model.GetEntityTypes()
                .SelectMany(e => e.GetForeignKeys()))
            {
                relationship.DeleteBehavior = DeleteBehavior.Restrict;
            }

            var roles = new Role[]
            {
                new Role
                {
                    Id = 1,
                    RoleName = "Admin",
                },
                new Role
                {
                    Id = 2,
                    RoleName = "User",
                },
            };
            modelBuilder.Entity<Role>().HasData(roles);

            var adminLoginPassword = new LoginPassword
            {
                Login = "admin",
                Password = "admin",
            };
            modelBuilder.Entity<LoginPassword>().HasData(adminLoginPassword);

            var admin = new User
            {
                Id = 1,
                LoginUser = adminLoginPassword.Login,
                RegisteredDate = DateTime.Now,
                RoleId = 1,
                ChatId = null,
            };
            modelBuilder.Entity<User>().HasData(admin);
        }
    }
}
