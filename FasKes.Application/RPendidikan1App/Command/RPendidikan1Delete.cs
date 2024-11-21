using MediatR;

namespace FasKes.Application.RPendidikan1App.Command
{
    public class RPendidikan1Delete : IRequest<int>
    {
        public int Kode { get; set; }   
    }

}