
using Shopping.Application;
using Shopping.Domain;
using Shopping.Domain.Repository;
using System.Text;

namespace Shopping.Helpers
{
    public static class InitializeInjection
    {
        public static void Initialize(WebApplicationBuilder builder)
        {
            builder.Services.AddScoped(typeof(AppDbContext));
            builder.Services.AddScoped(typeof(IRepository<>), typeof(Repository<>));
            builder.Services.AddScoped(typeof(CampaignRepository));
            builder.Services.AddScoped(typeof(CampaignApplication));
            builder.Services.AddScoped(typeof(EventRepository));
            builder.Services.AddScoped(typeof(EventApplication));
        }
    }
}
