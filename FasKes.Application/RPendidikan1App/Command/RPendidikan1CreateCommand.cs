using System;
using System.Collections.Generic;
using System.Linq;
using System.Threading.Tasks;
using FasKes.Application.RPendidikan1App.Dto;
using MediatR;

namespace FasKes.Application.RPendidikan1App.Command
{
    public class RPendidikan1CreateCommand : IRequest<RPendidikan1CreateDto>
    {
        // public string Uraian { get; set; }
        // public string Deleted   { get; set; }

        public RPendidikan1CreateDto RPendidikan1CreateDto { get; set; }
    }

    
}