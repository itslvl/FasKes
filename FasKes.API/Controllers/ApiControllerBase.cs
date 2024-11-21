using System;
using System.Collections.Generic;
using System.Linq;
using System.Threading.Tasks;
using MediatR;
using Microsoft.AspNetCore.Mvc;

namespace FasKes.API.Controllers
{
    [ApiController]
    [Route("api/[controller]")]
    public class ApiControllerBase : ControllerBase
    {
        /// <summary>
        /// The mediator instance used for sending commands and publishing events.
        /// </summary>
        private IMediator _mediator;
        protected ISender Mediator => _mediator ?? HttpContext.RequestServices.GetService(typeof(ISender)) as ISender;
    }
}