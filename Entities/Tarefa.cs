using System;
using System.Collections.Generic;
using System.Linq;
using System.Threading.Tasks;

namespace desafio.Entities
{
    public class Tarefa
    {
        public int Id { get; set; }
        public string Titulo { get; set; }
        public string Descricao { get; set; }
        public DateTime Data { get; set; }
        public StatusObj Status { get; set; }
    }

    public enum StatusObj
    {
        Pendente,
        EmProgresso,
        Concluida
    }
}