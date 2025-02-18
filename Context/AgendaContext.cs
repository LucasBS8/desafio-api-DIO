using System;
using System.Collections.Generic;
using System.Linq;
using System.Threading.Tasks;
using desafio.Entities;
using Microsoft.EntityFrameworkCore;

namespace desafio.Context
{
    public class AgendaContext(DbContextOptions<AgendaContext> options) : DbContext(options)
    {
        public DbSet<Tarefa> Tarefas { get; set; }
    }
}