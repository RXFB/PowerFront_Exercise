namespace OperatorProductivity.Application.Handlers;

using MediatR;
using OperatorProductivity.Application.DTO;
using OperatorProductivity.Application.Queries;
using OperatorProductivity.Data;
using System.Threading;
using System.Threading.Tasks;

public class GetOperatorProductivityResultQueryHandler : IRequestHandler<GetOperatorProductivityResultQuery, OperatorProductivityResultDTO>
{
    private IChatRepository chatRepository;

    public GetOperatorProductivityResultQueryHandler(IChatRepository chatRepository)
    {
        this.chatRepository = chatRepository;
    }

    public async Task<OperatorProductivityResultDTO> Handle(GetOperatorProductivityResultQuery request, CancellationToken cancellationToken)
    {
        var data = this.chatRepository.GetOperatorProductivityResultReport(request.Filter);


        return new OperatorProductivityResultDTO
        {
            Results = data.ToList(),
            CurrentFilter = request.Filter
        };
    }
}
