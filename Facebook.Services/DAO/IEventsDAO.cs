using Facebook.Services.Models;

namespace Facebook.Services.DAO
{
    public interface IEventsDAO
    {
        void CreateEvent(Events newEvent);
        int DeleteEventById(int eventId);
    }
}