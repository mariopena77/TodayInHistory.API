using System;
using System.Collections.Generic;
using System.Data;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace TodayInHistory.Domain
{
    public class Historia
    {
        public int Id { get; set; }
        public string Titulo { get; set; }
        public string Descripcion { get; set; }
        public string Imagen { get; set; }
        public int IdCategoria { get; set; }
        public DateTime Fecha { get; set; }
        public string Resumen { get; set; }
        public bool AC { get; set; }
        public bool Activo { get; set; }

        private Interfaces.IHistoriaRepositorio repositorioHistoria;

        public Historia()
        {
        }

        public Historia(Interfaces.IHistoriaRepositorio repositorio)
        {
            this.repositorioHistoria = repositorio;
        }

        public Historia(IDataReader reader)
        {
            this.Id = (int)reader["id"];
            this.Titulo = (string)reader["titulo"];
            this.Descripcion = (string)reader["historia"];
            this.Imagen = (string)reader["imagen"];
            this.IdCategoria = (int)reader["idCategoria"];
            this.Fecha = (DateTime)reader["fecha"];
            this.Resumen = (string)reader["resumen"];
            this.AC = (bool)reader["AC"];
        }

        public List<Historia> ObtenerHistorias(int mes, int dia)
        {
            return this.repositorioHistoria.ObtenerHistorias(mes, dia);
        }

        public Historia ObtenerHistoria(int id)
        {
            return this.repositorioHistoria.ObtenerHistoria(id);
        }



    }
}
