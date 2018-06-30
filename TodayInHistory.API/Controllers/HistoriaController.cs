using System;
using System.Collections.Generic;
using System.Linq;
using System.Net;
using System.Net.Http;
using System.Web.Http;
using TodayInHistory.Domain;
using TodayInHistory.Repository;
using WebApi.OutputCache.V2;

namespace TodayInHistory.API.Controllers
{
    [RoutePrefix("api")]
    public class HistoriaController : ApiController
    {
        [HttpGet]
        [Route("historia/{mes}/{dia}")]
        [CacheOutput(ClientTimeSpan = 100, ServerTimeSpan = 100)]
        public IHttpActionResult Get(int mes, int dia)
        {
            try
            {
                Domain.Interfaces.IHistoriaRepositorio repositorio = new HistoriaRepositorio("CONEXION");
                Historia historia = new Historia(repositorio);

                var listaHistorias = historia.ObtenerHistorias(mes, dia);
                if (listaHistorias.Count == 0)
                {
                    return NotFound();
                }
                else
                {
                    return Ok(listaHistorias);
                }                
            }
            catch (Exception)
            {
                return InternalServerError();                
            }
        }
    }
}
