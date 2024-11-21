using FasKes.Domain.Repository.R;
using MediatR;

namespace FasKes.Application.RPendidikan1App.Command
{
    public class RPendidikan1DeleteHandler : IRequestHandler<RPendidikan1Delete, int>
    {
        private readonly IRPendidikan1Repo _rPendidikan1Repo;
        public RPendidikan1DeleteHandler(IRPendidikan1Repo rPendidikan1Repo)
        {
            _rPendidikan1Repo = rPendidikan1Repo;
        }
        public async Task<int> Handle(RPendidikan1Delete request, CancellationToken cancellationToken)
        {
            var ret = await _rPendidikan1Repo.DeleteAsync(request.Kode);
            return ret;
        }
    }
}