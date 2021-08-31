using Microsoft.EntityFrameworkCore;
using Microsoft.EntityFrameworkCore.Design;

namespace ObliDA.EntityFrameworkCore
{
    public class ContextFactory : IDesignTimeDbContextFactory<Context>
    {
        

        public Context CreateDbContext(string[] args)
        {
            var builder = new DbContextOptionsBuilder<Context>();
            builder.UseSqlServer(@"Server=localhost,1433\\Catalog=tutorial_database;Database=Test;User=SA;Password=obligatorioDA2;");
            return new Context(builder.Options);
        }
    }
}