using Microsoft.EntityFrameworkCore;
using Microsoft.EntityFrameworkCore.Design;

namespace ObliDA.EntityFrameworkCore
{
    public class ContextFactory : IDesignTimeDbContextFactory<Context>
    {
        

        public Context CreateDbContext(string[] args)
        {
            var builder = new DbContextOptionsBuilder<Context>();
            builder.UseSqlServer(@"Server=DESKTOP-MNVS5C9\SQLSERVERLOCAL;Database=OtanerObli;Trusted_Connection=True;");
            return new Context(builder.Options);
        }
    }
}