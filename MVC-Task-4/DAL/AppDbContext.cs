using Microsoft.EntityFrameworkCore;
using MVC_Task_4.Models;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Threading.Tasks;

namespace MVC_Task_4.DAL
{
    public class AppDbContext:DbContext
    {
        public AppDbContext(DbContextOptions<AppDbContext> options):base(options)
        {


        }
        public DbSet<Card> Cards { get; set; }
        public DbSet<Profession> Professions { get; set; }
        public DbSet<Skill> Skills { get; set; }


    }
}
