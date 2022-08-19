using System.Text;
using TasksManager.Api.Data;

namespace TasksManager.Api.Responses;

public class ItemResponse
{
    public ItemResponse(Item item)
    {
        Id = item.Id;
        Title = item.Title;
        Description = item.Description;
        CreateDate = item.CreateDate?.ToLocalTime();
        NotificationDate = item.NotificationDate?.ToLocalTime();
    }

    public int Id { get; set; }
    public string Title { get; set; }
    public string Description { get; set; }
    public DateTime? CreateDate { get; set; }
    public DateTime? NotificationDate { get; set; }

    public override string ToString()
    {
        return new StringBuilder()
            .AppendFormat("Id: {0},Description {1},Title {2},CreationDate {3},NotificationDate {4}", Id, Description,
                Title, CreateDate, NotificationDate).ToString();
    }
}