namespace OperatorProductivity.Data;

public class OperatorProductivityResultQueryFilter
{
    public DateTime? StartDate { get; set; }
    public DateTime? EndDate { get; set; }
    public string Website { get; set; }
    public string Device { get; set; }
}
