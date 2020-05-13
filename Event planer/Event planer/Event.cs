using System;

namespace Event_planer
{
    [Serializable]
    public class Event
    {
        public string EventName { get; set; }
        public DateTime EventDate { get; set; }
        public string Priority { get; set; }
        public string Place { get; set; }

        public override string ToString()
        {
            return $"{EventDate}  {Priority} {EventName} {Place}";
        }
        public Event()
        {

        }
    }
}
