using ToDoApp.Entities;

namespace ToDoApp.Mappers
{
    public static class ToDoMapper<T> where T : IBasicItem
    {
        public static T MapChanges(T inboundObject, T objectToChange){
            objectToChange.Note = inboundObject.Note;
            objectToChange.Title = inboundObject.Title;

            return objectToChange;
        }
    }
}