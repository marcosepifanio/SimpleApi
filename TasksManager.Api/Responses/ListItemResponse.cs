using TasksManager.Api.Data;

namespace TasksManager.Api.Responses;

public class ListItemResponse
{
    public ListItemResponse(IEnumerable<Item>? items)
    {
        Items = new List<ItemResponse>();

        if (items != null)
            foreach (var item in items)
            {
                Items.Add(new ItemResponse(item));
            }
    }
    public List<ItemResponse> Items { get; set; }
}