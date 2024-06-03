using Microsoft.Extensions.Logging;
using Shopping.Domain.Repository;
using Shopping.Models;

namespace Shopping.Application
{
    public class EventApplication
    {
        // The right thing here is an interface for this repository and make dependcy injection on IEventRepository but this shows well my intention
        CampaignRepository _repository; 
        public EventApplication(CampaignRepository repository)
        {
            _repository = repository;
        }
        public Event Create(Event @event)
        {
           return _repository.Create(@event);
        }

        public void Update(Event @event)
        {
            _repository.Update(@event);
        }

        public void Delete(int eventId)
        {
            _repository.Delete(eventId);
        }

        public Event Get(int eventId)
        {
            return _repository.GetById(eventId);
        }

        public List<Event> GetEvents()
        {
           return _repository.GetAll();
        }
    }
}
