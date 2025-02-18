using System;
using System.Collections.Generic;
using System.Linq;
using System.Threading.Tasks;
using desafio.Context;
using desafio.Entities;
using Microsoft.AspNetCore.Mvc;


namespace desafio.Controllers
{

    [ApiController]
    [Route("[controller]")]
    public class TarefaController : ControllerBase
    {
        private readonly AgendaContext _context;

        public TarefaController(AgendaContext context)
        {
            _context = context;
        }

        [HttpGet("/Tarefa/{id}")]
        public IActionResult GetPorId(int id)
        {
            var tarefa = _context.Find<Tarefa>(id);

            if (tarefa == null)
            {
                return NotFound();
            }
            return Ok(tarefa);
        }

        [HttpPut("/Tarefa/{id}")]
        public IActionResult Put(int id, Tarefa tarefaNova)
        {
            var tarefa = _context.Find<Tarefa>(id);
            if (tarefa == null)
            {
                return NotFound();
            }
            tarefa.Titulo = tarefaNova.Titulo;
            tarefa.Descricao = tarefaNova.Descricao;
            tarefa.Data = tarefaNova.Data;
            tarefa.Status = tarefaNova.Status;
            
            _context.Tarefas.Update(tarefa);
            _context.SaveChanges();

            return Ok(tarefa);
        }

        [HttpDelete("/Tarefa/{id}")]

        public IActionResult delete(int id)
        {
            var tarefa = _context.Find<Tarefa>(id);
            if (tarefa == null)
            {
                return NotFound();
            }
            _context.Tarefas.Remove(tarefa);
            _context.SaveChanges();
            return Ok();
        }

        [HttpGet("/Tarefa/ObterTodos")]

        public IActionResult Get()
        {
            return Ok(_context.Tarefas.ToList());
        }

        [HttpGet("/Tarefa/ObterPorTitulo")]
        public IActionResult Get(string titulo)
        {
            var tarefa = _context.Tarefas.Where(c => c.Titulo.Contains(titulo));

            if (tarefa == null)
            {
                return NotFound();
            }

            return Ok(tarefa);
        }

        [HttpGet("/Tarefa/ObterPorData")]
        public IActionResult Get(DateTime data)
        {
            var tarefa = _context.Tarefas.Where(c => c.Data == data);

            if (tarefa == null)
            {
                return NotFound();
            }

            return Ok(tarefa);
        }

        [HttpGet("/Tarefa/ObterPorStatus")]
        public IActionResult Get(StatusObj status)
        {
            var tarefa = _context.Tarefas.Where(c => c.Status == status);

            if (tarefa == null)
            {
                return NotFound();
            }

            return Ok(tarefa);
        }

        [HttpPost("/Tarefa")]
        public IActionResult Post(Tarefa tarefa)
        {
            _context.Tarefas.Add(tarefa);
            _context.SaveChanges();
            return CreatedAtAction(nameof(GetPorId), new { id = tarefa.Id }, tarefa);
        }

    }
}
