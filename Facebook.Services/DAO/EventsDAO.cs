using Facebook.Services.Models;
using System;
using System.Linq;

namespace Facebook.Services.DAO
{
    public class EventsDAO : IEventsDAO
    {
        private FacebookDBContext context;

        public EventsDAO(FacebookDBContext context)
        {
            if (context == null)
            {
                throw new ArgumentNullException("context");
            }

            this.context = context;
        }

        public void CreateEvent(Events newEvent)
        {
            this.context.Events.Add(newEvent);
            this.context.SaveChanges();
        }

        public int DeleteEventById(int eventId)
        {
            var createdEvent = this.context.Events.Where(f => f.EventId.Equals(eventId)).FirstOrDefault();
            this.context.Events.Remove(createdEvent);

            return this.context.SaveChanges();
        }
    }
}
