using Microsoft.EntityFrameworkCore;
using Practice2.Models;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Threading.Tasks;

namespace Practice2.MyEF
{
    public class EFdb: DbContext
    {
        public EFdb(DbContextOptions<EFdb> options) : base(options)
        {
        }

        public DbSet<House> Houses { get; set; }
        public DbSet<HousePhoto> HousePhotos { get; set; }

    }
}
