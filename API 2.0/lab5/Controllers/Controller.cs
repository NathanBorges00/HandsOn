using System.Collections.Generic;
using System.Linq;
using lab5;
using Microsoft.AspNetCore.Mvc;

[Route("api/produtos")]
[ApiController]
public class TesteController : ControllerBase
{

    private readonly Context _prodRepositorio;

    public TesteController(Context rep)
    {
        this._prodRepositorio = rep;
    }

    [HttpPost]
    public ActionResult<Produto> Add([FromBody] Produto produto)
    {
        _prodRepositorio.Add(produto);
        _prodRepositorio.SaveChanges();
        return Created("https://localhost:5001/api/produtos",produto);
    }

    [HttpGet]
    public ActionResult<IEnumerable<Produto>> GetAll()
    {
        List<Produto> lista = _prodRepositorio.Produtos.ToList();
        return Ok(lista);
    }
}