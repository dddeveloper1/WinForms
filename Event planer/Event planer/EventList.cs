using System;
using System.Collections.Generic;

namespace Event_planer
{
    [Serializable]
    public class EventList
    {
        public List<Event> Events { get; set; } = new List<Event>();
        public EventList()
        {
        }
        public void AddEvent(Event e)
        {
            Events.Add(e);
        }
        public void RemoveAt(int index)
        {
            Events.RemoveAt(index);
        }
        public void Clear()
        {
            Events.Clear();
        }

    }
}
