using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Data;
using System.Data.SqlClient;

namespace Gestion_de_Campeonatos
{
    public class Controlador
    {
        #region base de datos
        static string connectionString = @"Server=DESKTOP-AU5BPLN\SQLEXPRESS; Database=ChampionShipMaker; User Id=sa; Password=Univalle";
        public SqlCommand CreateBasicCommand()
        {
            SqlConnection connection = new SqlConnection(connectionString);
            SqlCommand command = new SqlCommand();
            command.Connection = connection;
            return command;
        }
        public SqlCommand CreateBasicCommand(string query)
        {
            SqlConnection connection = new SqlConnection(connectionString);
            SqlCommand command = new SqlCommand(query, connection);
            return command;
        }
        #endregion

        #region Consultas Equipos
        public DataTable Select_Equipos()
        {
            string query = @"select id, nombreEquipo as 'Nombre del equipo:', cantidadEquipos as 'Cantidad de jugadores'
                             from Equipos
                             where status = 1";

            SqlCommand command = CreateBasicCommand(query);

            try
            {
                return ExecuteSelectCommand(command);
            }
            catch (Exception ex)
            {

                throw ex;
            }
        }
        public int Insert_Equipos(Equipo e)
        {
            string query = @"insert into Equipos(nombreEquipo, cantidadEquipos)
                             values(@nombreEquipo, @cantidadEquipos)";
            SqlCommand command = CreateBasicCommand(query);

            command.Parameters.AddWithValue("@nombreEquipo", e.NomEquipos);
            command.Parameters.AddWithValue("@cantidadEquipos", e.CantParticipantes);

            try
            {
                return ExecueteBasicCommand(command);
            }
            catch (Exception ex)
            {

                throw ex;
            }
        }

        public int Update_equipos(Equipo e)
        {
            string query = @"update Equipos set nombreEquipo = @nombreEquipo, cantidadEquipos = @cantidadEquipos
                             where id = @id";
            SqlCommand command = CreateBasicCommand(query);

            command.Parameters.AddWithValue("@id", e.id);
            command.Parameters.AddWithValue("@nombreEquipo", e.NomEquipos);
            command.Parameters.AddWithValue("@cantidadEquipos", e.CantParticipantes);

            try
            {
                return ExecueteBasicCommand(command);
            }
            catch (Exception ex)
            {

                throw ex;
            }
        }

        public int Delete_Equipos (Equipo e)
        {
            string query = @"update Equipos set status = 0
                             where id = @id";
            SqlCommand command = CreateBasicCommand(query);
            command.Parameters.AddWithValue("@id", e.id);

            try
            {
                return ExecueteBasicCommand(command);
            }
            catch (Exception ex)
            {

                throw ex;
            }
        }
        #endregion

        #region Consulas Deportes












        #endregion

        #region Comandos
        public DataTable ExecuteSelectCommand(SqlCommand command)
        {
            try
            {
                command.Connection.Open();
                SqlDataAdapter adapter = new SqlDataAdapter(command);
                DataTable table = new DataTable();
                adapter.Fill(table);
                return table;
            }
            catch (Exception ex)
            {
                throw ex;
            }
            finally
            {
                command.Connection.Close();
            }
        }
        public static int ExecueteBasicCommand(SqlCommand command)
        {
            try
            {
                command.Connection.Open();
                return command.ExecuteNonQuery();
            }
            catch (Exception ex)
            {

                throw ex;
            }
            finally
            {
                command.Connection.Close();
            }
        }
        #endregion
    }
}
