using System;
using System.Collections.Generic;
using System.Text;

namespace Api.Monitoramento.Domain.Models
{
    public class ErrorResponse
    {
        public int Codigo { get; set; }
        public string Mensagem { get; set; }
        public ErrorResponse InnerError { get; set; }
        public string[] Detalhes { get; set; }
    }
}
