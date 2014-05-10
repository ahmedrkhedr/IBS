using System;
using System.Collections.Generic;
using System.Linq;
using System.Web;
using System.Data.Entity;
using DAL.Models;

namespace DAL.Models
{

    public class Context : DbContext
    {
        public Context()
            : base("name=connectionStringName")
        {
            
        }
     
        public DbSet <Season> Seasons{ get; set; }
        public DbSet<SeasonLockup> SeasonStatusLockups { get; set; }
        public DbSet<FleetMaster> FleetMasters { get; set; }
       


    }

    
}