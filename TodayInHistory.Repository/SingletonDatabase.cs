using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using Microsoft.Practices.EnterpriseLibrary.Common;
using Microsoft.Practices.EnterpriseLibrary.Data;


namespace TodayInHistory.Repository
{
    public static class SingletonDatabase
    {
        private static DatabaseProviderFactory factory;
        private static Database baseDatos;

        public static Database ObtenerDataBase(string nombreCadenaConexion)
        {
            if (baseDatos == null)
            {
                factory = new DatabaseProviderFactory();
                baseDatos = factory.Create(nombreCadenaConexion);
            }

            return baseDatos;
        }

    }
}
