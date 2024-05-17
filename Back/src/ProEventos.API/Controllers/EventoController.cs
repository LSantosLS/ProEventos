using Microsoft.AspNetCore.Mvc;
using ProEventos.API.Models;

namespace ProEventos.API.Controllers
{
    [ApiController]
    [Route("api/[controller]")]
    public class EventoController : ControllerBase
    {
        public IEnumerable<Evento> _evento = new Evento[] {
                new Evento
                {
                    EventoId = 1,
                    Tema = "Angular 11 e .NET 5",
                    Local = "Taquaritinga",
                    Lote = "1� Lote",
                    QtdPessoas = 250,
                    DataEvento = DateTime.Now.AddDays(2).ToString(),
                    ImagemUrl = "foto.png"
                },
                new Evento
                {
                    EventoId = 2,
                    Tema = "Angular e suas novidades",
                    Local = "Jaboticabal",
                    Lote = "2� Lote",
                    QtdPessoas = 310,
                    DataEvento = DateTime.Now.AddDays(4).ToString(),
                    ImagemUrl = "foto1.png"
                }
            };

        public EventoController()
        {
            
        }

        [HttpGet]
        public IEnumerable<Evento> Get()
        {
            return _evento;
        }

        [HttpGet("{id}")]
        public IEnumerable<Evento> GetById(int id)
        {
            return _evento.Where(evento => evento.EventoId == id);
        }

        [HttpPost]
        public string Post()
        {
            return "Exemplo de Post";
        }

        [HttpPut("{id}")]
        public string Put(int id)
        {
            return $"Exemplo de Put - id: {id}";
        }

        [HttpDelete("{id}")]
        public string Delete(int id)
        {
            return $"Exemplo de Delete - id: {id}";
        }
    }
}
