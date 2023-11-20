using CineCordobaBack.Datos.Implementacion;
using CineCordobaBack.Datos.Interfaz;
using CineCordobaBack.Entidades;
using CineCordobaBack.Fachada.Interfaz;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace CineCordobaBack.Fachada.Implementacion
{
    public class Aplicacion : IAplicacion
    {
        private IFuncionDao funcionDao;
        private IClienteDao clienteDao;
        private IInicioDao inicioDao;
        public Aplicacion()
        {
            funcionDao = new FuncionDao();
            clienteDao = new ClienteDao();
            inicioDao = new InicioDao();
        }

        public bool CrearFuncion(Funciones oFuncion) //no ta
        {
            return funcionDao.CrearFuncion(oFuncion);
        }
        public bool CrearCliente(Clientes oClientes)//ta
        {
            return clienteDao.CrearCliente(oClientes);
        }

        public int ProximaFuncion()  //ta
        {
           return funcionDao.ObtenerProximaFuncion();
        }


        public List<Horarios> traerHorarios()//ta
        {
           return funcionDao.obtenerHorarios();
        }

        public List<Peliculas> traerPeliculas()//ta
        {
           return funcionDao.obtenerPeliculas();
        }

        public List<TipoSalas> traerSalas(int idSucursal)//ta
        {
            return funcionDao.obtenerSalas(idSucursal);
        }

        public List<Sucursales> traerSucursales() //ta
        {
           return funcionDao.obtenerSucursales();
        }
        
        public List<Ciudades> TraerCiudades()//ta
        {
            return clienteDao.obtenerCiudades();
        }

        public List<TipoDoc> TraerDocumentos()//ta
        {
            return clienteDao.obtenerDocumentos();
        }

        public List<Barrios>TraerBarrios(int idProvincia)//ta
        {
            return clienteDao.obtenerBarrio(idProvincia);
        }


        public int ObtenerProximoCliente()//ta
        {
            return clienteDao.ObtenerProximoCliente();
        }

        public int ObtenerUsuario(Usuarios oUsuario)//ta
        {
            return inicioDao.ObtenerUsuario(oUsuario);
        }
    }
}
