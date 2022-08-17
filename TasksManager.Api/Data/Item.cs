namespace TasksManager.Api.Data;

public record Item(int Id, string Title, string Description, DateTime CreateDate, DateTime NotificationDate);