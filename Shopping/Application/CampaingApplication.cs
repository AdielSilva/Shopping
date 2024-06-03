using Microsoft.Extensions.Logging;
using Shopping.Domain.Repository;
using Shopping.Models;

namespace Shopping.Application
{
    public class CampaignApplication
    {
        // The right thing here is an interface for this repository and make dependcy injection on IEventRepository but this shows well my intention
        CampaignRepository _repository; 
        public CampaignApplication(CampaignRepository repository)
        {
            _repository = repository;
        }
        public Campaing Create(Campaing campaign)
        {
           return _repository.Create(campaign);
        }

        public void Update(Campaing campaign)
        {
            _repository.Update(campaign);
        }

        public void Delete(int campaignId)
        {
            _repository.Delete(campaignId);
        }

        public Campaing Get(int campaignId)
        {
            return _repository.GetById(campaignId);
        }

        public List<Campaing> GetCampaigns()
        {
           return _repository.GetAll();
        }
    }
}
