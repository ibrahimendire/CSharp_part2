using System;
using System.Collections.Generic;
using HelloASPDotNET.Models;

namespace HelloASPDotNET.Data
{
    public class EventData
    {
        //Store events
        static private Dictionary<int, Event> Events = new Dictionary<int, Event>();

        // GetAll   retreive the events
        public static IEnumerable<Event> GetAll()
        {
            return Events.Values;
        }

        // Add
        public static void Add(Event newEvent)
        {
            Events.Add(newEvent.Id, newEvent);
        }

        // Remove an event
        public static void Remove(int id)
        {
            Events.Remove(id);
        }

        // GetById   retreive a single event
        public static Event GetById(int id)
        {
            return Events[id];
        }
    }
}
