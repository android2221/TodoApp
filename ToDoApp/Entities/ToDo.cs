using System.ComponentModel.DataAnnotations.Schema;

namespace ToDoApp.Entities
{
  public class ToDo
  {
    public int ID {get; set;}
    public string Title {get; set;}
    public string Note {get; set;}
  }
}
