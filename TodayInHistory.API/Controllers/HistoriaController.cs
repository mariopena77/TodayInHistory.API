using System;
using System.Collections.Generic;
using System.Linq;
using System.Net;
using System.Net.Http;
using System.Web.Http;
using TodayInHistory.Domain;
using TodayInHistory.Repository;

namespace TodayInHistory.API.Controllers
{
    public class HistoriaController : ApiController
    {
        public IHttpActionResult Get()
        {
            try
            {
                Domain.Interfaces.IHistoriaRepositorio repositorio = new HistoriaRepositorio("CONEXION");
                Historia historia = new Historia(repositorio);

                return Ok(historia.ObtenerHistorias(6, 29));
            }
            catch (Exception ex)
            {
                return InternalServerError();                
            }
        }
    }
}
