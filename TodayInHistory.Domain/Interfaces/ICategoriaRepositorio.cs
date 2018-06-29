using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace TodayInHistory.Domain.Interfaces
{
    public interface ICategoriaRepositorio
    {
        List<Categoria> ObtenerCategorias();
    }
}
