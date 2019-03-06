using System;
using System.Collections;
using System.Collections.Generic;
using System.Linq;
using System.Runtime.Serialization;
using System.Text;
using System.Threading.Tasks;

namespace GasStationPharmacy.Models
{
    [DataContract]
    public class GasSModel { 
        public string Hash { get; set; }

        public int Compare(string toCompare)
        {
            if (Hash.Equals(toCompare))
            {
                return CONSTANTS.SAME;
            }
            return CONSTANTS.DIFFERENT;
        }
    }
}
