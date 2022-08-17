using TasksManager.Api.Data;

namespace TasksManager.Api.Service;

public interface IItemService
{
    IEnumerable<Item> GetAll();
    Item? GetById(int id);
    Item Create(Item newItem);
    void DeleteById(int id);
}