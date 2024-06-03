using Microsoft.EntityFrameworkCore;
using Shopping.Models;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Shopping.Domain.Repository
{
    public class CampaignRepository : Repository<Campaing>
    {
        public CampaignRepository(AppDbContext context) : base(context)
        {

        }

    }
}
