using Microsoft.AspNetCore.Identity.EntityFrameworkCore;
using Microsoft.EntityFrameworkCore;

namespace CleanArchh.MVC.Data
{
    public class AplicationDBContext :IdentityDbContext
    {

        public AplicationDBContext(DbContextOptions<AplicationDBContext>options):base  (options) { }    
     
    }
}
