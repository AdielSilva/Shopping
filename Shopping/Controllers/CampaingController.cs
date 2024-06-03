using Microsoft.AspNetCore.Mvc;
using Shopping.Application;
using Shopping.Models;
using static System.Net.Mime.MediaTypeNames;

namespace Shopping.Controllers
{
    public class CampaingController : Controller
    {
        private CampaignApplication _application;
        public CampaingController(CampaignApplication application)
        {
            _application = application;
        }

        [HttpPost]
        public async Task<ActionResult<Campaing>> PostCampaign(Campaing campaign)
        {
            return CreatedAtAction(nameof(GetCampaing), new { id = campaign.Id }, _application.Create(campaign));
        }

        [HttpGet("{id}")]
        public async Task<Campaing> GetCampaing(int id)
        {
            return _application.Get(id);
        }

        [HttpGet]
        public async Task<ActionResult<IEnumerable<Campaing>>> GetCampaigns()
        {
            return _application.GetCampaigns();
        }

        [HttpPut]
        public async Task<IActionResult> PutCampaign(Campaing campaign)
        {
            _application.Update(campaign);
            return Ok();
        }

        [HttpDelete("{id}")]
        public async Task<ActionResult> Delete(int id)
        {
            _application.Delete(id);
            return Ok();
        }

    }
}
