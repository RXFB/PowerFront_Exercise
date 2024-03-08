namespace OperatorProductivity.Domain.Reports;

public class OperatorProductivityResult
{
    public int OperatorID { get; set; }
    public string Name { get; set; }
    public int ProactiveSent { get; set; }
    public int ProactiveAnswered { get; set; }
    public double ProactiveResponseRate { get; set; }
    public int ReactiveReceived { get; set; }
    public int ReactiveAnswered { get; set; }
    public double ReactiveResponseRate { get; set; }
    public string TotalChatLength { get; set; }
    public double AverageChatLength { get; set; }
}
