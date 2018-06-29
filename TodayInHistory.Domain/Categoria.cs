using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace TodayInHistory.Domain
{
    public class Categoria
    {
        public int Id { get; set; }
        public string Nombre { get; set; }

        private Interfaces.ICategoriaRepositorio repositorioCategoria;

        public Categoria()
        {
        }

        public Categoria(Interfaces.ICategoriaRepositorio repositorio)
        {
            this.repositorioCategoria = repositorio;
        }

        public List<Categoria> ObtenerCategorias()
        {
            return this.repositorioCategoria.ObtenerCategorias();
        }
    }
}
