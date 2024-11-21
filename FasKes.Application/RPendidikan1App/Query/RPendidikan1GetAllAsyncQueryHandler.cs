using AutoMapper;
using FasKes.Application.RPendidikan1App.Dto;
using FasKes.Domain.Repository.R;
using MediatR;

namespace FasKes.Application.RPendidikan1App.Query
{
    public class RPendidikan1GetAllAsyncQueryHandler : IRequestHandler<RPendidikan1GetAllAsyncQuery, List<RPendidikan1Dto>>
    {
        private readonly IRPendidikan1Repo _rPendidikan1;
        public IMapper _mapper { get; }
        public RPendidikan1GetAllAsyncQueryHandler(IRPendidikan1Repo rPendidikan1, IMapper mapper)
        {
            _mapper = mapper;
            _rPendidikan1 = rPendidikan1;
        }
        public async Task<List<RPendidikan1Dto>> Handle(RPendidikan1GetAllAsyncQuery request, CancellationToken cancellationToken)
        {
            var r = await _rPendidikan1.GetAllAsync();
            // var rList = r.Select(x => new RPendidikan1Dto
            // {
            //     Kode = x.Kode,
            //     Uraian = x.Uraian,
            //     Deleted = x.Deleted
            // }).ToList();
            var rList = _mapper.Map<List<RPendidikan1Dto>>(r);
            return rList;

        }
    }
}