using AutoMapper;
using FasKes.Application.RPendidikan1App.Dto;
using FasKes.Domain.Repository.R;
using MediatR;

namespace FasKes.Application.RPendidikan1App.Query
{

    public class RPendidikan1GetByIdQueryHandler : IRequestHandler<RPendidikan1GetByIdQuery, RPendidikan1Dto>
    {
        private readonly IRPendidikan1Repo _rPendidikan1;
        private readonly IMapper _mapper;
        public RPendidikan1GetByIdQueryHandler(IRPendidikan1Repo rPendidikan1, IMapper mapper)
        {
            _mapper = mapper;
            _rPendidikan1 = rPendidikan1;

        }
        public async Task<RPendidikan1Dto> Handle(RPendidikan1GetByIdQuery request, CancellationToken cancellationToken)
        {
            var rPendidikan1 = await _rPendidikan1.GetByIdAsync(request.Kode);
            return _mapper.Map<RPendidikan1Dto>(rPendidikan1);
        }
    }
}