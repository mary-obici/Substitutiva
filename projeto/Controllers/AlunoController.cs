// namespace projeto.Controllers;
using Microsoft.AspNetCore.Mvc;
using projeto.Data;
// using projeto.Data;
using projeto.Models;

namespace projeto.Controllers;
[ApiController]
[Route("api/aluno")]
public class AlunoController : ControllerBase
{
    private readonly AppDataContext _context; public AlunoController(AppDataContext context) => _context = context;


    [HttpGet]
    [Route("listar")]
    public IActionResult Listar()
    {
        try
        {
            List<Aluno> alunos = _context.Alunos.ToList();
            return Ok(alunos);
        }
        catch (Exception e)
        {
            return BadRequest(e.Message);
        }
    }
    [HttpPost]
    [Route("cadastrar")]
    public IActionResult Cadastrar([FromBody] Aluno aluno)
    {
        try
        {
            _context.Add(aluno);
            _context.SaveChanges();
            return Created("", aluno);
        }
        catch (Exception e)
        { return BadRequest(e.Message); }
    }
}