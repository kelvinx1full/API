using System;
using System.Collections.Generic;
using System.Linq;
using System.Threading.Tasks;
using Microsoft.EntityFrameworkCore;
using API.ETEC01.Model;

namespace API.ETEC01.Data
{
    public class APIETEC01Context : DbContext
    {
        public APIETEC01Context (DbContextOptions<APIETEC01Context> options)
            : base(options)
        {
        }

        public DbSet<API.ETEC01.Model.ContaModel> ContaModel { get; set; }
    }
}
