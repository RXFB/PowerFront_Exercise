namespace OperatorProductivity.Data;

using OperatorProductivity.Domain.Reports;

public interface IChatRepository
{
    IEnumerable<OperatorProductivityResult> GetOperatorProductivityResultReport(OperatorProductivityResultQueryFilter filter);
    IEnumerable<string> GetWebsites();
    IEnumerable<string> GetDevices();
}
