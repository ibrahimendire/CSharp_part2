using System;
namespace HelloASPDotNET.Models
{
    public class Event
    {
        public string Name { get; set; }
        public string Description { get; set; }
        public DateTime Date { get; }
        public int Id { get; }
        static private int nextId = 1;

        public Event(string name ,string desc)
        {
            Name = name;
            Description = desc;
            Date = DateTime.Now;
            Id = nextId;
            nextId++;
        }



        public override string ToString()
        {
            return Name;
        }

        public override bool Equals(object obj)
        {
            return obj is Event @event &&
                   Id == @event.Id;
        }

        public override int GetHashCode()
        {
            return HashCode.Combine(Id);
        }
    }
}

