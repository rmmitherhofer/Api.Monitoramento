using Microsoft.AspNetCore.Mvc.ModelBinding;
using Api.Monitoramento.Domain.Models;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;

namespace Api.Monitoramento.Application.Util
{
    public class ErrorResponseHelper
    {
        public static ErrorResponse From(Exception e)
        {
            if (e == null)
            {
                return null;
            }
            return new ErrorResponse
            {
                Codigo = e.HResult,
                Mensagem = e.Message,
                InnerError = From(e.InnerException)
            };
        }

        public static ErrorResponse FromModelState(ModelStateDictionary modelState)
        {
            var erros = modelState.Values.SelectMany(m => m.Errors);
            return new ErrorResponse
            {
                Codigo = 100,
                Mensagem = "Houve error(s) no envio da requisição",
                Detalhes = erros.Select(e => e.ErrorMessage).ToArray()
            };
        }
    }
}
