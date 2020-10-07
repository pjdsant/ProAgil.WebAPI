using System;
using System.Collections.Generic;
using System.Linq;
using System.Threading.Tasks;
using Microsoft.AspNetCore.Mvc;
using Microsoft.Extensions.Logging;
using ProAgil.WebAPI.Model;

namespace ProAgil.WebAPI.Controllers
{
    [ApiController]
    [Route("[controller]")]
    public class WeatherForecastController : ControllerBase
    {
        private static readonly string[] Summaries = new[]
        {
            "Freezing", "Bracing", "Chilly", "Cool", "Mild", "Warm", "Balmy", "Hot", "Sweltering", "Scorching"
        };

        private readonly ILogger<WeatherForecastController> _logger;

        public WeatherForecastController(ILogger<WeatherForecastController> logger)
        {
            _logger = logger;
        }

        [HttpGet]
        public ActionResult<IEnumerable<Model.Evento>> Get()
        {
            return new Evento[]{
                new Evento(){
                    EventoId = 1,
                    Tema = "Angular e .Net Core",
                    Local = "São Paulo",
                    Lote = "1o. Lote",
                    QtdPessoas = 250,
                    DataEvento = DateTime.Now.AddDays(2).ToString("dd/MM/yyyy")
                },
                  new Evento(){
                    EventoId = 2,
                    Tema = "Angular e Suas Dependencias",
                    Local = "São Paulo",
                    Lote = "1o. Lote",
                    QtdPessoas = 130,
                    DataEvento = DateTime.Now.AddDays(2).ToString("dd/MM/yyyy")
                }
            };
            // var rng = new Random();
            // return Enumerable.Range(1, 5).Select(index => new WeatherForecast
            // {
            //     Date = DateTime.Now.AddDays(index),
            //     TemperatureC = rng.Next(-20, 55),
            //     Summary = Summaries[rng.Next(Summaries.Length)]
            // })
            // .ToArray();


        }

        [HttpGet("{id}")]
        public ActionResult<Model.Evento> Get(int id)
        {
            return new Evento[]{
                new Evento(){
                    EventoId = 1,
                    Tema = "Angular e .Net Core",
                    Local = "São Paulo",
                    Lote = "1o. Lote",
                    QtdPessoas = 250,
                    DataEvento = DateTime.Now.AddDays(2).ToString("dd/MM/yyyy")
                },
                  new Evento(){
                    EventoId = 2,
                    Tema = "Angular e Suas Dependencias",
                    Local = "São Paulo",
                    Lote = "1o. Lote",
                    QtdPessoas = 130,
                    DataEvento = DateTime.Now.AddDays(2).ToString("dd/MM/yyyy")
                }
            }.FirstOrDefault(x => x.EventoId == id);
        }
    }
}
