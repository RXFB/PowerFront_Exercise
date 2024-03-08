namespace OperatorProductivity.Application.Queries;

using MediatR;
using OperatorProductivity.Application.DTO;
using OperatorProductivity.Data;

public class GetOperatorProductivityResultQuery : IRequest<OperatorProductivityResultDTO>
{
    public OperatorProductivityResultQueryFilter Filter { get; set; }

    public GetOperatorProductivityResultQuery()
    {
    }

}
