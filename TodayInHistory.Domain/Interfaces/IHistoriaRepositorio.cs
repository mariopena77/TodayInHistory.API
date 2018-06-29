using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace TodayInHistory.Domain.Interfaces
{
    public interface IHistoriaRepositorio
    {
        List<Historia> ObtenerHistorias(int mes, int dia);

        Historia ObtenerHistoria(int id);
    }
}
