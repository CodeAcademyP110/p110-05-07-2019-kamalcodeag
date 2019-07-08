using Microsoft.EntityFrameworkCore;
using Practice.Models;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Threading.Tasks;

namespace Practice.Entity
{
    public class TestingMyself : DbContext
    {
        public TestingMyself(DbContextOptions<TestingMyself> options) : base(options)
        {
        }

        public DbSet<OurUser> OurUsers { get; set; }
    }
}
