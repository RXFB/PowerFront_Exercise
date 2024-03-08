namespace OperatorProductivity.Domain.Entities;

public class Conversation
{
    public int ConversationID { get; set; }
    public int VisitorID { get; set; }
    public int OperatorID { get; set; }
    public DateTime? StartDate { get; set; }
    public DateTime? EndDate { get; set; }
    public string Website { get; set; }
    public string PageName { get; set; }
    public string PageURL { get; set; }
}
