using System.Data.Common;
using Microsoft.EntityFrameworkCore;

namespace Syntaq.Falcon.EntityFrameworkCore
{
    public static class FalconDbContextConfigurer
    {
        public static void Configure(DbContextOptionsBuilder<FalconDbContext> builder, string connectionString)
        {
            builder.UseNpgsql(connectionString);
        }

        public static void Configure(DbContextOptionsBuilder<FalconDbContext> builder, DbConnection connection)
        {
            builder.UseNpgsql(connection);
        }
    }
}