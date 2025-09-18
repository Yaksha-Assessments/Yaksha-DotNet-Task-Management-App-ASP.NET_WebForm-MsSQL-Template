using System;
using System.Collections.Generic;
using System.Linq;

public static class EventRepository
{
    private static readonly object _lock = new object();
    private static List<Event> _events;

    public static void Seed()
    {
        lock (_lock)
        {
            if (_events != null) return;
            _events = new List<Event>
            {
                new Event { Id = 1, Title = "Intro to .NET", Date = DateTime.Today.AddDays(3), Fee = 0m, Description = "Beginner friendly intro." },
                new Event { Id = 2, Title = "Web Forms Basics", Date = DateTime.Today.AddDays(7), Fee = 49.99m, Description = "Build classic web apps fast." },
                new Event { Id = 3, Title = "C# Fundamentals", Date = DateTime.Today.AddDays(14), Fee = 29.99m, Description = "Syntax to LINQ in a day." }
            };
        }
    }

    public static IEnumerable<Event> GetAll()
    {
        return _events ?? Enumerable.Empty<Event>();
    }

    public static Event GetById(int id)
    {
        return GetAll().FirstOrDefault(e => e.Id == id);
    }

}
