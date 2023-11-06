using Microsoft.AspNetCore.Mvc;

namespace CatalogoDev.Api.Controllers;

[Route("api/desenvolvedores")]
[ApiController]
public class DesenvolvedoresController : ControllerBase
{
    private List<string> _desenvolvedores;

    public DesenvolvedoresController()
    {
        _desenvolvedores = new ()
        {
            "Lailton", "Rafael", "Luiz", "Fernando", "Maria", "Alessandra", "Carlos"
        };
    }

    [HttpGet]
    public List<string> ListarDevs()
    {
        return _desenvolvedores;
    }

    [HttpGet("{id}")]
    public string PegarDev(int id)
    {
        if (id > _desenvolvedores.LongCount() - 1) return "Id inválido";

        return _desenvolvedores.ElementAt(id);
    }
}
