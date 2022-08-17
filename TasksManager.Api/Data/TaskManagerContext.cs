using Microsoft.EntityFrameworkCore;

namespace TasksManager.Api.Data;

public class TaskManagerContext: DbContext
{
    public TaskManagerContext(DbContextOptions<TaskManagerContext> options): base(options){}

    public DbSet<Item> Items => Set<Item>();
}