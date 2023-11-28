using Microsoft.EntityFrameworkCore;

namespace CL3_TristanVelaPieroAlessandro.DataAccess
{
    public class DocenteContext : DbContext
    {
        public DbSet<DocenteEntity> Docente { get; set; }
        public DocenteContext(DbContextOptions<DocenteContext> option) : base(option)
        {

        }

    }
}