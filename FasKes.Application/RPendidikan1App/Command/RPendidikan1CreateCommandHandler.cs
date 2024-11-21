using AutoMapper;
using FasKes.Application.RPendidikan1App.Dto;
using FasKes.Domain.Entity.R;
using FasKes.Domain.Repository.R;
using MediatR;

namespace FasKes.Application.RPendidikan1App.Command
{
    public class RPendidikan1CreateCommandHandler : IRequestHandler<RPendidikan1CreateCommand, RPendidikan1CreateDto>
    {
        private readonly IRPendidikan1Repo _rPendidikan1;
        private readonly IMapper _mapper;

        public RPendidikan1CreateCommandHandler(IRPendidikan1Repo rPendidikan1, IMapper mapper)
        {
            _rPendidikan1 = rPendidikan1;
            _mapper = mapper;
        }
        public async Task<RPendidikan1CreateDto> Handle(RPendidikan1CreateCommand request, CancellationToken cancellationToken)
        {
            var row = new RPendidikan1
            {
                Uraian = request.RPendidikan1CreateDto.Uraian,
                Deleted = request.RPendidikan1CreateDto.Deleted
            };
            var result = await _rPendidikan1.CreateAsync(row);
            return _mapper.Map<RPendidikan1CreateDto>(result);
        }
    }
}