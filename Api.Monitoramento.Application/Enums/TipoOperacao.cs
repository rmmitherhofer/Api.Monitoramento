using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Text;

namespace Api.Monitoramento.Application.Enums
{
    public enum TipoOperacao
    {
        [Description("I")]
        Inclusao,
        [Description("U")]
        Alteracao,
        [Description("D")]
        Exclusao
    }
}
