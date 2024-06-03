using Microsoft.EntityFrameworkCore;
using Shopping.Models;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Shopping.Domain.Repository
{
    public class EventRepository : Repository<Event>
    {
        public EventRepository(AppDbContext context) : base(context)
        {

        }

    }
}
