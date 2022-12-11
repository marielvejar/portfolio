using Portafolio.Models;

namespace Portafolio.Servicios
{
    public interface IRepositorioProyectos
    {
        List<Proyecto> ObtenerProyectos();
    }
    public class RepositorioProyectos: IRepositorioProyectos
    {
        public List<Proyecto> ObtenerProyectos()
        {
            return new List<Proyecto>() { 
                new Proyecto
            {
                Titulo = "Bennu Spa",
                Descripcion = " Mantención y Desarrollo en Java",
                Link = "https://www.bennu.cl",
                ImagenURL = "/imagenes/bennu.png"

            },
            };
        }
    }
}
