using Microsoft.AspNetCore.Mvc;
using projeto.Data;
using projeto.Models;

namespace projeto.Controllers;
[ApiController]
[Route("api/imc")]
public class ImcController : ControllerBase
{
    private readonly AppDataContext _context; public ImcController(AppDataContext context) => _context = context;


    [HttpGet]
    [Route("listar")]
    public IActionResult Listar()
    {
        try
        {
            List<Imc> imcs = _context.Imcs.ToList();
            return Ok(imcs);
        }
        catch (Exception e)
        {
            return BadRequest(e.Message);
        }
    }
    [HttpPost]
    [Route("cadastrar")]
    public IActionResult Cadastrar([FromBody] Imc imc)
    {
        try
        {

            Aluno? aluno = _context.Alunos.Find(imc.AlunoId);
            if (aluno == null)
            {
                return NotFound();
            }
            imc.Aluno = aluno;
            imc.CalculaIMC();
            imc.VerificaImc();
            _context.Add(imc);
            _context.SaveChanges();
            return Created("", imc);
        }
        catch (Exception e)
        { return BadRequest(e.Message); }
    }

    [HttpPut]
    [Route("alterar")]
    public IActionResult Alterar([FromBody] Imc imc)
    {
        try
        {
            Imc imcCriado = _context.Imcs.FirstOrDefault(f => f.ImcId == imc.ImcId);

            if (imcCriado == null)
            {
                return NotFound("Imc não Alterado");
            }

            imcCriado.Altura = imc.Altura;
            imcCriado.Peso = imc.Peso;
           
            _context.SaveChanges();

            return Ok("Imc Alterado");
        }
        catch (Exception e)
        {
            return BadRequest(e.Message);
        }
    }
}