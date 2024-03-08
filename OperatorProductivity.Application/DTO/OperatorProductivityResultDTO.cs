namespace OperatorProductivity.Application.DTO;

using OperatorProductivity.Data;
using OperatorProductivity.Domain.Reports;

public class OperatorProductivityResultDTO
{
    public List<OperatorProductivityResult> Results { get; set; }
    public OperatorProductivityResultQueryFilter CurrentFilter { get; set; }
}
