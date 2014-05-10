using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace DAL.Models
{
    public class FleetMaster
    {
        public int Id { get; set; }
        public string FleetNumber { get; set; }
        public string PlateNumber { get; set; }
        public int Seats { get; set; }



        #region Methods
        public FleetMaster GetFleetByFleetNumber(string fleetNumber)
        {
            var db = new PetaPoco.Database("connectionStringName");
            return db.SingleOrDefault<FleetMaster>(" SELECT FleetMasters.Id,FleetNumber, PlateNumber, Seats" +            
            " FROM FleetMasters Where FleetNumber = @FleetNumber",fleetNumber);
        }
        #endregion


    }
}
