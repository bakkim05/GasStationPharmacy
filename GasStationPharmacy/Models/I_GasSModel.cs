using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace GasStationPharmacy.Models
{
    public interface I_GasSModel
    {
        string Compare(I_GasSModel toCompare);
    }
}
