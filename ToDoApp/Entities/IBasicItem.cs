namespace ToDoApp.Entities
{
    public interface IBasicItem
    {
        int ID { get; set; }
        string Title { get; set; }
        string Note { get; set; }
    }
}