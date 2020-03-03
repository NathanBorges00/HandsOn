using Microsoft.AspNetCore.Mvc;
using System;
using System.Collections;
using System.Collections.Generic;
using System.Threading.Tasks;

namespace lab1.Controllers
{
    [Route("api/produtos")]
    [ApiController]
    public class TesteController : ControllerBase
    {

        private readonly IRepositorio _prodRepositorio;


        public TesteController(IRepositorio rep)
        {
            this._prodRepositorio = rep;
        }


        [HttpGet]
        public ActionResult<IEnumerable<Produto>> GetAll()
        {
            IList<Produto> lista = _prodRepositorio.GetAll();
            return Ok(lista);
        }

        [HttpGet("{id}")]
        public ActionResult<Produto> Get(Guid id)
        {
            Produto produto = _prodRepositorio.Get(id);
            if (produto == null) return NotFound();
            return Ok(produto);
        }

        [HttpPost]
        public ActionResult<Produto> Add([FromBody] Produto produto)
        {
            _prodRepositorio.Add(produto);
            return Created($"https://localhost:5001/api/produtos/{produto.Id}", produto);
        }

        [HttpPut("{id}")]
        public ActionResult<Produto> Update(Guid id, Produto produto)
        {
            produto.Id = id;

            _prodRepositorio.Update(produto);
            return Ok();
        }

        [HttpDelete("{id}")]
        public ActionResult Delete(Guid id)
        {
            _prodRepositorio.Remove(id);
            return Ok();
        }
    }
}