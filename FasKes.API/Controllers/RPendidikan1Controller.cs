using System;
using System.Collections.Generic;
using System.Linq;
using System.Threading.Tasks;
using FasKes.Application.RPendidikan1App.Query;
using Microsoft.AspNetCore.Mvc;

namespace FasKes.API.Controllers
{
    [ApiController]
    [Route("api/[controller]")]
    public class RPendidikan1Controller : ApiControllerBase
    {
        [HttpGet]
        public async Task<IActionResult> GetAllAsync()
        {
            var rows = await Mediator.Send(new RPendidikan1GetAllAsyncQuery());
            return Ok(rows);
        }
    }
}