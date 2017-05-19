using Microsoft.EntityFrameworkCore;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Threading.Tasks;

namespace PoslovnaInformatika.Data
{
    public class PoslovnaInformatikaContext : DbContext
    {
        public PoslovnaInformatikaContext(DbContextOptions<PoslovnaInformatikaContext> options) : base(options)
        {

        }
    }
}
