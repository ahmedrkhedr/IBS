using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace DAL.Models
{
    public class Season
    {
        public int Id { get; set; }
        public string HijriYear { get; set; }
        public string GeogorianYear { get; set; }
        public bool IsCurrent { get; set; }
        public int CreatedBy { get; set; }

        public int? StatusId { get; set; }
        public SeasonLockup SeasonsLockup;

        public DateTime CreationDate { get; set; }
        public int? ModifiedBy { get; set; }
        public DateTime? ModificationDate { get; set; }
        public bool DF { get; set; }
        public TimeSpan RowConcur { get; set; }

        #region Methods
        public List<Season> GetAllSeasons()
        {
            var db = new PetaPoco.Database("connectionStringName");
            return db.Fetch<Season>(" SELECT Seasons.Id,HijriYear,GeogorianYear,IsCurrent," +
            "StatusId,CreationDate,CreatedBy,ModificationDate,ModifiedBy" +
            " FROM Seasons" +
            " WHERE DF = 0").ToList();
        }      
        #endregion
        


    }
}
