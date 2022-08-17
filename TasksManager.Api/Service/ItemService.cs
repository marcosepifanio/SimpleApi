using Microsoft.EntityFrameworkCore;
using TasksManager.Api.Data;

namespace TasksManager.Api.Service;

public class ItemService : IItemService
{
    private readonly TaskManagerContext _taskManagerContext;

    public ItemService(TaskManagerContext taskManagerContext)
    {
        _taskManagerContext = taskManagerContext;
    }

    public IEnumerable<Item> GetAll()
    {
        return _taskManagerContext.Items
            .AsNoTracking()
            .ToList();
    }

    public Item? GetById(int id)
    {
        return _taskManagerContext.Items
            .AsNoTracking()
            .SingleOrDefault(x => x.Id == id);
    }

    public Item Create(Item newItem)
    {
        _taskManagerContext.Items.Add(newItem);
        _taskManagerContext.SaveChanges();
        return newItem;
    }

    public void DeleteById(int id)
    {
        var itemToDelete = _taskManagerContext.Items.Find(id);
        if (itemToDelete is not null)
        {
            _taskManagerContext.Items.Remove(itemToDelete);
            _taskManagerContext.SaveChanges();
        }
    }
}