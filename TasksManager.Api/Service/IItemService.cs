using TasksManager.Api.Data;
using TasksManager.Api.Requests;

namespace TasksManager.Api.Service;

public interface IItemService
{
    IEnumerable<Item> GetAll();
    Item? GetById(int id);
    Item Create(NewItemRequest newItem);
    void DeleteById(int id);
}