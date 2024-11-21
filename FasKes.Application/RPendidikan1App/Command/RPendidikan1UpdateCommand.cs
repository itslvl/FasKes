using FasKes.Domain.Entity.R;
using MediatR;

namespace FasKes.Application.RPendidikan1App.Command
{
    //secara defenisi ini berarti ada int dalam query dan body RPendidikan
    public class RPendidikan1UpdateCommand : IRequest<int>
    {
        public int Id { get; set; } 
        public RPendidikan1 RPendidikan1 { get; set; }
    }
}