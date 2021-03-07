using API.ETEC01.Model;
using Microsoft.AspNetCore.Mvc;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Threading.Tasks;

// For more information on enabling Web API for empty projects, visit https://go.microsoft.com/fwlink/?LinkID=397860

namespace API.ETEC01.Controllers
{
    

    [Route("api/[controller]")]
    [ApiController]
    public class ContaController : ControllerBase
    {
        public ICollection<ContaModel> contas;

        public ContaController()
        {
            contas = new List<ContaModel>();
            contas.Add(new ContaModel() { Id = 1, NomeDoCredor = "Felipe Silva", Email = "felipesilva@gmail.com", DataDoVencimento = DateTime.Now.AddDays(20), ValoraPagar = 1500});
            contas.Add(new ContaModel() { Id = 2, NomeDoCredor = "João Francisco", Email = "joãofrancisco@gmail.com", DataDoVencimento = DateTime.Now.AddDays(30), ValoraPagar = 2000});
            contas.Add(new ContaModel() { Id = 3, NomeDoCredor = "Leandro Otavio", Email = "leandrootavio@gmail.com", DataDoVencimento = DateTime.Now.AddDays(40), ValoraPagar = 3000});
            contas.Add(new ContaModel() { Id = 4, NomeDoCredor = "Gustavo Neto", Email = "gustavoneto@gmail.com", DataDoVencimento = DateTime.Now.AddDays(30), ValoraPagar = 1500 });
            contas.Add(new ContaModel() { Id = 5, NomeDoCredor = "Silvano Trindade", Email = "silvanotrindade@gmail.com", DataDoVencimento = DateTime.Now.AddDays(20), ValoraPagar = 1500});
        }

        // GET: api/<ContaController>
        [HttpGet]
        public async Task<ActionResult<ContaModel>> Get()
        {
            return Ok(contas.OrderBy(a => a.Id).ToList());
        }

        // GET api/<ContaController>/5
        [HttpGet("{id}")]
        public ActionResult<ContaModel> Get(int id)
        {
            return Ok(contas.Where(a => a.Id == id).FirstOrDefault() );
        }

        // POST api/<ContaController>
        [HttpPost]
        public void Post([FromBody] string value)
        {
        }

        // PUT api/<ContaController>/5
        [HttpPut("{id}")]
        public void Put(int id, [FromBody] string value)
        {
        }

        // DELETE api/<ContaController>/5
        [HttpDelete("{id}")]
        public void Delete(int id)
        {
        }
    }
}
