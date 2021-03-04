namespace ToDoApp.Entities
{
    public interface IBasicTodoItem
    {
        int ID { get; set; }
        string Title { get; set; }
        string Note { get; set; }
    }
}