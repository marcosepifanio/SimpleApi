namespace TasksManager.Api.Requests;

public class NewItemRequest
{
    public string Title { get; set; }
    public string Description { get; set; }
    public DateTime NotificationDate { get; set; }
}