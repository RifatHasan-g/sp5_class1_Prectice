using Microsoft.EntityFrameworkCore;
using WebApplication2me.Models;

namespace WebApplication2me.DBcontexts
{
    public class employeeDBcontexts : DbContext
    {
        public employeeDBcontexts(DbContextOptions<employeeDBcontexts>options)
            : base(options) 
        {
        
        }

        public DbSet<employee>employees { get; set; }

    }
}
