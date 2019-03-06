using System;
using System.Collections.Generic;
using System.Linq;
using System.Web;

namespace GasStationPharmacy.Models
{
    public class RecipeModel : GasSModel
    {
        public int Id { get; set; }
        public int Number { get; set; }
        public int Doctor { get; set; }
        public int Meds { get; set; }
    }
}