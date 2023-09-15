using Microsoft.EntityFrameworkCore;
using CoreAPI_SP.Models.DB;
#nullable disable
namespace CoreAPI_SP.Models.DB
{
    public partial class DB_Demo_APIContext : DbContext
    {
        public DB_Demo_APIContext()
        {
        }

        public DB_Demo_APIContext(DbContextOptions<DB_Demo_APIContext> options)
            : base(options)
        {
        }

        public DbSet<CoreAPI_SP.Models.DB.output>? output { get; set; }

    }
}
