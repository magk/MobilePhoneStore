using Microsoft.EntityFrameworkCore;
using MobilePhoneStore.Models;

namespace MobilePhoneStore.Data
{
    public class MvcBasicDbContext : DbContext
    {
        public MvcBasicDbContext(DbContextOptions<MvcBasicDbContext> options): base(options)
        {

        }
        public DbSet<Phone> Phones { get; set; }
    }
}
