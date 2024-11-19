using AutoMapper;
using FasKes.Domain.Repository.R;
using MediatR;

namespace FasKes.Application.RPendidikan1.Query.RPendidikan1GetAll
{
    public class RPendidikan1QueryHandler : IRequestHandler<RPendidikan1Query, List<RPendidikan1Dto>>
    {
        private readonly IRPendidikan1 _rPendidikan1;
        public IMapper _mapper { get; }
        public RPendidikan1QueryHandler(IRPendidikan1 rPendidikan1, IMapper mapper)
        {
            _mapper = mapper;
            _rPendidikan1 = rPendidikan1;
        }
        public async Task<List<RPendidikan1Dto>> Handle(RPendidikan1Query request, CancellationToken cancellationToken)
        {
            var r = await _rPendidikan1.GetAllRPendidikan1Async();
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