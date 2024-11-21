using System;
using System.Collections.Generic;
using System.Linq;
using System.Threading.Tasks;
using FasKes.Application.RPendidikan1App.Dto;
using MediatR;

namespace FasKes.Application.RPendidikan1App.Query
{
    public class RPendidikan1GetByIdQuery : IRequest<RPendidikan1Dto>
    {
        public int Kode { get; set; }
    }
}