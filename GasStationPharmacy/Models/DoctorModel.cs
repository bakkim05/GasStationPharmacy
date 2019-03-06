using System;
using System.Collections.Generic;
using System.Linq;
using System.Runtime.Serialization;
using System.Web;

namespace GasStationPharmacy.Models
{
    [DataContract]
    public class DoctorModel : GasSModel
    {
        [DataMember]
        public string Cedula { get; set; }
        [DataMember]
        public int NumeroDoctor { get; set; }
        [DataMember]
        public string Nombre { get; set; }
        [DataMember]
        public string Apellido { get; set; }
        [DataMember]
        public string Residencia { get; set; }
        [DataMember]
        public string FechaNacimiento { get; set; }
        
    }
}