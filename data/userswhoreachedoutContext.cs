using myportfolio.Models;
using Microsoft.EntityFrameworkCore;

namespace data
{
    public class userswhoreachedoutContext : DbContext
    {   
        public userswhoreachedoutContext(DbContextOptions<userswhoreachedoutContext> options) : base(options)
        {
        }

        public DbSet<UsersWhoReachedOut> UsersWhoReachedOut { get; set; }
    }
}