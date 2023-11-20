using CineCordobaBack.Datos.Interfaz;
using CineCordobaBack.Entidades;
using System;
using System.Collections.Generic;
using System.Data;
using System.Data.SqlClient;
using System.Linq;
using System.Runtime.InteropServices;
using System.Text;
using System.Threading.Tasks;

namespace CineCordobaBack.Datos.Implementacion
{
    public class ClienteDao : IClienteDao
    {
        public int ObtenerProximoCliente()
        {
            return HelperDB.ObtenerInstancia().ConsultarEscalar("SP_PROXIMO_CLIENTES", "@next");
        }

        public bool CrearCliente(Clientes oClientes) //no era con  transaccion boludin
        {
            bool resultado = true;

            SqlConnection conexion = HelperDB.ObtenerInstancia().ObtenerConexion();
           
            try
            {
                conexion.Open();               

                SqlCommand comandoCliente = new SqlCommand("sp_insertarCliente", conexion);
                comandoCliente.CommandType = CommandType.StoredProcedure;
                comandoCliente.Parameters.AddWithValue("@nombre", oClientes.Nombre);
                comandoCliente.Parameters.AddWithValue("@apellido", oClientes.Apellido);
                comandoCliente.Parameters.AddWithValue("@fecha_nac", oClientes.FechaNac);
                comandoCliente.Parameters.AddWithValue("@telefono", oClientes.Telefono);
                comandoCliente.Parameters.AddWithValue("@email", oClientes.Email);

                comandoCliente.Parameters.AddWithValue("@id_barrio", oClientes.Barrio.Id_barrio);
                comandoCliente.Parameters.AddWithValue("@calle", oClientes.Calle);
                comandoCliente.Parameters.AddWithValue("@altura", oClientes.Altura);
                comandoCliente.Parameters.AddWithValue("@id_tipo_doc", oClientes.TipoDocId.TipoDocId);
                comandoCliente.Parameters.AddWithValue("@nro_doc", oClientes.NroDoc);

                SqlParameter param = new SqlParameter("@id_cliente", SqlDbType.Int);
                param.Direction= ParameterDirection.Output;
                comandoCliente.Parameters.Add(param);
                comandoCliente.ExecuteNonQuery();

                int ultimoID = Convert.ToInt32(param.Value);

               
                
            }
            catch (Exception)
            {

                
                resultado = false;
            }
            finally
            {
                if (conexion != null && conexion.State == ConnectionState.Open)
                    conexion.Close();
            }
            return resultado;
        }

        public List<Barrios> obtenerBarrio(int idciudad)
        {
            {
                List<Barrios> lbarrios = new List<Barrios>();
                List<Parametro> lparam = new List<Parametro>();
                Parametro parametro = new Parametro("@id_ciudad", idciudad);
                lparam.Add(parametro);
                DataTable tabla = HelperDB.ObtenerInstancia().ConsultaTabla("sp_barrios", lparam);

                foreach (DataRow fila in tabla.Rows)
                {
                    int id_barrio = int.Parse(fila["id_barrio"].ToString());
                    string barrio = fila["barrio"].ToString();

                    Barrios b = new Barrios(id_barrio, barrio);
                    lbarrios.Add(b);

                }
                return lbarrios;
            }
        }

        public List<Ciudades> obtenerCiudades()
        {
            List<Ciudades> lciudades = new List<Ciudades>();
            DataTable tabla = HelperDB.ObtenerInstancia().Consultar("sp_Ciudad");
            foreach (DataRow fila in tabla.Rows)
            {

                int id_ciudad = int.Parse(fila["id_ciudad"].ToString());
                string nombre_ciudad = fila["ciudad"].ToString();
                Ciudades c = new Ciudades(id_ciudad,nombre_ciudad);
                lciudades.Add(c);
            }
            return lciudades;
        }

        public List<TipoDoc> obtenerDocumentos()
        {
            List<TipoDoc> ldocumentos = new List<TipoDoc>();
            DataTable tabla = HelperDB.ObtenerInstancia().Consultar("Sp_tipo_Doc");
            foreach (DataRow fila in tabla.Rows)
            {                
                int id_tipodoc = int.Parse(fila["id_tipo_doc"].ToString());
                string tipo = fila["tipo_doc"].ToString();
                TipoDoc d = new TipoDoc(id_tipodoc, tipo);
                ldocumentos.Add(d);
            }
            return ldocumentos;
        }


    }
}
