//using Dapper;
using SICCD.Models;
//using Microsoft.Data.SqlClient;

namespace ManejoPresupuesto.Servicios
{
    public interface IRepositorioUsuarios
    {
        Task<Usuario> BuscarUsuarioPorNombre(string nombre);
    }

    public class RepositorioUsuarios: IRepositorioUsuarios
    {
        private readonly string connectionString;
        public RepositorioUsuarios(IConfiguration configuration)
        {
            connectionString = configuration.GetConnectionString("DefaultConnection");
        }

        public async Task<Usuario> BuscarUsuarioPorNombre(string nombre)
        {
            using var connection = new SqlConnection(connectionString);
            var usuario = await connection.QuerySingleOrDefaultAsync<Usuario>(
                "SELECT * FROM Usuarios Where EmailNormalizado = @emailNormalizado");
            return usuario;
        }
    }
}