using CineCordobaBack.Datos.Implementacion;
using CineCordobaBack.Datos.Interfaz;
using CineCordobaBack.Entidades;
using CineCordobaBack.Servicios.Interfaz;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace CineCordobaBack.Servicios.Implementacion
{
    public class Servicio : IServicio
    {
        private IFuncionDao funcionDao;

        public Servicio()
        {
            funcionDao = new FuncionDao();

        }
        public int ProximaFuncion()
        {
            return funcionDao.ObtenerProximaFuncion();
        }

        public List<Horarios> traerHorarios()
        {
            return funcionDao.obtenerHorarios();
        }

        public List<Peliculas> traerPeliculas()
        {
            return funcionDao.obtenerPeliculas();
        }

        public List<TipoSalas> traerSalas(int idSucursal)
        {
            return funcionDao.obtenerSalas(idSucursal);
        }

        public List<Sucursales> traerSucursales()
        {
            return funcionDao.obtenerSucursales();
        }
    }
}
