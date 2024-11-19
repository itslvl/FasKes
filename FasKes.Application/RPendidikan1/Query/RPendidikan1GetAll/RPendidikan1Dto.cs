using System;
using System.Collections.Generic;
using System.Linq;
using System.Threading.Tasks;
using FasKes.Application.Common.Mappings;
using FasKes.Domain.Entity.R;

namespace FasKes.Application.RPendidikan1.Query.RPendidikan1GetAll
{
    public class RPendidikan1Dto : IMapFrom<RPendidikan1>
    {
        public int Kode { get; set; }
        public string Uraian { get; set; } = "";
        public int Deleted { get; set; }
    }
}