using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace DAL.Models
{
    public class SeasonLockup
    {
        public int Id { get; set; }
        public string StatusAName { get; set; }
        public string StatusEName { get; set; }


        #region Methods
        public List<SeasonLockup> GetAllSeasonsLockups()
        {
            var db = new PetaPoco.Database("connectionStringName");
            return db.Fetch<SeasonLockup>("SELECT SeasonsLockups.Id,StatusAName," +
            "StatusEName" +
            " FROM SeasonsLockups").ToList();
        }        
        #endregion
    }
}
