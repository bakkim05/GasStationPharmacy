using System;
using System.Collections.Generic;
using System.Linq;
using System.Runtime.Serialization;
using System.Web;

namespace GasStationPharmacy.Models
{
    [DataContract]
    public class SucursalModel : GasSModel
    {
        [DataMember]
        public string Nombre { get; set; }
        [DataMember]
        public string Descripcion { get; set; }
        [DataMember]
        public string Direccion { get; set; }
        [DataMember]
        public string Administrador { get; set; }
        
    }
}