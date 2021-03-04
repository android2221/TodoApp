namespace ToDoApp.Entities
{
  public class ToDo : IBasicTodoItem
  {
    public int ID {get; set;}
    public string Title {get; set;}
    public string Note {get; set;}
  }
}
