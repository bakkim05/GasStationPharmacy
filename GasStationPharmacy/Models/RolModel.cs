﻿using System;
using System.Collections.Generic;
using System.Linq;
using System.Runtime.Serialization;
using System.Web;

namespace GasStationPharmacy.Models
{
    [DataContract]
    public class RolModel : I_GasSModel
    {
        [DataMember]
        public string Nombre { get; set; }
        [DataMember]
        public string Descripcion { get; set; }

        public string Compare(I_GasSModel toCompare)
        {
            throw new NotImplementedException();
        }
    }
}