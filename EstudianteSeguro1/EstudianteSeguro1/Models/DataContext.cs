
namespace EstudianteSeguro1.Models
{
    using System.Data.Entity;
    public class DataContext:DbContext
    {
        public DataContext():base("DefaultConnection")
        {

        }

        public System.Data.Entity.DbSet<EstudianteSeguro1.Models.Student> Students { get; set; }
    }
}