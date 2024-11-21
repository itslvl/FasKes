using AutoMapper;
using FasKes.Domain.Repository.R;
using MediatR;

namespace FasKes.Application.RPendidikan1App.Command
{
    public class RPendidikan1UpdateCommandHandler : IRequestHandler<RPendidikan1UpdateCommand, int>
    {
        private readonly IRPendidikan1Repo _rPendidikan1Repo;
        private readonly IMapper _mapper;

        public RPendidikan1UpdateCommandHandler(IRPendidikan1Repo rPendidikan1Repo, IMapper mapper)
        {
            _rPendidikan1Repo = rPendidikan1Repo;
            _mapper = mapper;
        }
        public async Task<int> Handle(RPendidikan1UpdateCommand request, CancellationToken cancellationToken)
        {
            int ret = await _rPendidikan1Repo.UpdateAsync(request.Id, request.RPendidikan1);
            return ret;
        }
    }

}