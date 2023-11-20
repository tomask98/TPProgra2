using CineCordobaBack.Entidades;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace CineCordobaBack.Datos.Interfaz
{
    public interface IFuncionDao
    {
        List<Sucursales> obtenerSucursales();
        List<Horarios> obtenerHorarios();
        List<Peliculas> obtenerPeliculas();
        int ObtenerProximaFuncion();
        List<TipoSalas> obtenerSalas(int idSucursal);
        bool CrearFuncion(Funciones oFuncion);
    }
}
