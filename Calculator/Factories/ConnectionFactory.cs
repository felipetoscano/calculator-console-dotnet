using System.Data;
using System.Data.SqlClient;

namespace Calculator.Factories
{
    /*
     * Classe que auxilia na criação de objetos que dificilmente serão modificados.
     * A diferença para o builder é justamente essa dinamicidade na criação, onde o Factory busca simplificar ao máximo a criação do objeto.
     */
    public class ConnectionFactory
    {
        public IDbConnection GetConnection()
        {
            var connection = new SqlConnection
            {
                ConnectionString = ""
            };
            //connection.Open();
            return connection;
        }
    }
}
