using System;
using System.Collections.Generic;
using System.Linq;
using System.Threading.Tasks;
using Microsoft.AspNetCore.Http;
using Microsoft.AspNetCore.Mvc;
using Api.Monitoramento.Application.Interface;
using Api.Monitoramento.Domain.Models;
using Swashbuckle.AspNetCore.Annotations;

namespace Api.Monitoramento.WebApi.Controllers.V1
{
    [ApiController]
    [ApiVersion("1.0")]
    [ApiExplorerSettings(GroupName = "v1")]
    [Route("v{version:apiVersion}/[controller]")]
    public class HardwareController : ControllerBase
    {
        private readonly IHardwareAppService _hardwareAppService;

        public HardwareController(IHardwareAppService hardware)
        {
            _hardwareAppService = hardware;
        }

        [HttpPost]
        [SwaggerOperation(
            Summary = "Carga de Hardware disponibilizado pela SmartAutoMatos",
            Tags = new[] { "Hardware" }
        )]
        [ProducesResponseType(StatusCodes.Status200OK)]
        [ProducesResponseType(StatusCodes.Status500InternalServerError, Type = typeof(ErrorResponse))]
        [ProducesResponseType(StatusCodes.Status400BadRequest, Type = typeof(ErrorResponse))]
        public async Task<IActionResult> IncluirCargaMonitoramentoHardware()
        {
            try
            {
                await _hardwareAppService.AdicionarCargaMonitoramento();
                return Ok();
            }
            catch (Exception ex)
            {
                return BadRequest(ex);
            }
        }
    }
}