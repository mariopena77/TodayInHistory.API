using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using Microsoft.Practices.EnterpriseLibrary.Data;
using Microsoft.Practices.EnterpriseLibrary.Common;
using TodayInHistory.Domain;
using TodayInHistory.Domain.Interfaces;
using System.Data.Common;
using System.Data;

namespace TodayInHistory.Repository
{
    public class HistoriaRepositorio : IHistoriaRepositorio
    {        
        private Database db;

        public HistoriaRepositorio(string nombreConexion)
        {
            this.db = SingletonDatabase.ObtenerDataBase(nombreConexion);
        }

        public List<Historia> ObtenerHistorias(int mes, int dia)
        {
            List<Historia> lista = new List<Historia>();
            Historia historia;

            using (DbCommand cmd = db.GetStoredProcCommand(Procedimientos.ObtenerHistorias))
            {
                db.AddInParameter(cmd, "@mes", DbType.Int32, mes);
                db.AddInParameter(cmd, "@dia", DbType.Int32, dia);

                using (IDataReader reader = db.ExecuteReader(cmd))
                {
                    while (reader.Read())
                    {
                        historia = new Historia(reader);
                        lista.Add(historia);
                    }
                }

            }

            return lista;
        }

        public Historia ObtenerHistoria(int id)
        {            
            return new Historia();
        }

    }
}
