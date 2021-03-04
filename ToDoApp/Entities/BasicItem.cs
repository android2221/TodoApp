namespace ToDoApp.Entities
{
    public class BasicItem : IBasicItem
    {
        public int ID {get; set;}
        public string Title {get; set;}
        public string Note {get; set;}

    }
}