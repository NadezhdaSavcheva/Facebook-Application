using Facebook.Services.DAO;

namespace Facebook.Business.Controllers
{
    class EventsController
    {
        private EventsDAO eventsDAO = null;

        public EventsController(EventsDAO eventsDAO)
        {
            this.eventsDAO = eventsDAO;
        }
    }
}
