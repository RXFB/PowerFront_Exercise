using MediatR;
using OperatorProductivity.Application.DTO;

namespace OperatorProductivity.Application.Queries;

public class GetFilterValuesQuery : IRequest<FilterValuesDTO>
{
}
