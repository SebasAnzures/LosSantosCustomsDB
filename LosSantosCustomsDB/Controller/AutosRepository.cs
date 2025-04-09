using LosSantosCustomsDB.Context;
using LosSantosCustomsDB.Model;
using Microsoft.Data.SqlClient;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace LosSantosCustomsDB.Controller
{

    class AutosRepository : iAutosRepository
    {
        private Conexion conexion = new Conexion();
        public AutosRepository() { }
        public List<Autos> Leer()
        {
            List<Autos> autos = new List<Autos>();
            try
            {
                using (SqlConnection conn = conexion.GetConnection())
                {
                    string query = "Leer";
                    SqlCommand cmd = new SqlCommand(query, conn);

                    conn.Open();
                    SqlDataReader reader = cmd.ExecuteReader();
                    while (reader.Read())
                    {
                        autos.Add(new Autos()
                        {
                            idauto = Convert.ToInt32(reader["idauto"]),
                            marca = reader["marca"].ToString(),
                            modelo = reader["modelo"].ToString(),
                            ano = Convert.ToInt32(reader["ano"]),
                            disponible = Convert.ToInt32(reader["disponible"])
                            
                        });
                    }
                }
                return autos;
            }
            catch (Exception ex)
            {
                throw new Exception("Error al leer los autos: " + ex.Message);
            }

        }
        public bool Insertar(Autos auto)
        {
            try
            {
                using (SqlConnection conn = conexion.GetConnection())
                {
                    string query = "Insertar";
                    SqlCommand cmd = new SqlCommand(query, conn);
                    cmd.CommandType = System.Data.CommandType.StoredProcedure;
                    cmd.Parameters.AddWithValue("@marca", auto.marca);
                    cmd.Parameters.AddWithValue("@modelo", auto.modelo);
                    cmd.Parameters.AddWithValue("@ano", auto.ano);
                    cmd.Parameters.AddWithValue("@disponible", auto.disponible);
                    conn.Open();
                    int rowsAffected = cmd.ExecuteNonQuery();
                    return true;
                }
            }
            catch (Exception ex)
            {
                throw new Exception("Error al insertar el auto: " + ex.Message);
            }
        }
        public bool Actualizar(Autos auto)
        {
            try
            {
                using (SqlConnection conn = conexion.GetConnection())
                {
                    string query = "Actualizar";
                    SqlCommand cmd = new SqlCommand(query, conn);
                    cmd.CommandType = System.Data.CommandType.StoredProcedure;
                    cmd.Parameters.AddWithValue("@idauto", auto.idauto);
                    cmd.Parameters.AddWithValue("@marca", auto.marca);
                    cmd.Parameters.AddWithValue("@modelo", auto.modelo);
                    cmd.Parameters.AddWithValue("@ano", auto.ano);
                    cmd.Parameters.AddWithValue("@disponible", auto.disponible);
                    conn.Open();
                    int rowsAffected = cmd.ExecuteNonQuery();
                    return true;
                }
            }
            catch (Exception ex)
            {
                throw new Exception("Error al actualizar el auto: " + ex.Message);
            }
        }
        public bool Eliminar(int idauto)
        {
            try
            {
                using (SqlConnection conn = conexion.GetConnection())
                {
                    string query = "Eliminar";
                    SqlCommand cmd = new SqlCommand(query, conn);
                    cmd.CommandType = System.Data.CommandType.StoredProcedure;
                    cmd.Parameters.AddWithValue("@idauto", idauto);
                    conn.Open();
                    int rowsAffected = cmd.ExecuteNonQuery();
                    return true;
                }
            }
            catch (Exception ex)
            {
                throw new Exception("Error al eliminar el auto: " + ex.Message);
            }
        }
    }

}
