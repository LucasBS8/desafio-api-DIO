using System;
using System.Collections.Generic;
using System.Linq;
using System.Threading.Tasks;
using desafio.Context;
using desafio.Entities;
using Microsoft.AspNetCore.Mvc;

[ApiController]
[Route("[controller]")]
public class TarefaController : ControllerBase
{
    private readonly ILogger<TarefaController> _logger;

    public TarefaController(ILogger<TarefaController> logger)
    {
        _logger = logger;
    }
}
