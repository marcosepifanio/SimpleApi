using TasksManager.Api.Data;
using TasksManager.Api.Requests;
using TasksManager.Api.Responses;

namespace TasksManager.Api.Service;

public interface IItemService
{
    IEnumerable<Item> GetAll();
    Item? GetById(int id);
    ItemResponse Create(NewItemRequest newItem);
    void DeleteById(int id);
}