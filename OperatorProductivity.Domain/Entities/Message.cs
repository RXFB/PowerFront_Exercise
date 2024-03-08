namespace OperatorProductivity.Domain.Entities;

public class Message
{
    public int MessageID { get; set; }
    public int ConversationID { get; set; }
    public string MessageContent { get; set; }
    public string MessageFrom { get; set; }
    public int MessageUserID { get; set; }
    public DateTime? MessageDate { get; set; }
}