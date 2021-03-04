using ToDoApp.Entities;

namespace ToDoApp.Mappers
{
    public static class ToDoMapper
    {
        public static ToDo MapChanges(ToDo inboundObject, ToDo objectToChange){
            objectToChange.Note = inboundObject.Note;
            objectToChange.Title = inboundObject.Title;

            return objectToChange;
        }
    }
}