using System;
using System.Collections.Generic;
using System.Linq;
using System.Runtime.Serialization;
using System.Web;

namespace GasStationPharmacy.Models
{
    [CollectionDataContract]
    public class ClienteModel : GasSModel
    {
        [DataMember]
        public static readonly string modelType = "Cliente";

        [DataMember]
        public int Id { get; set; }

        [DataMember]
        public string UserName { get; set; }

        [DataMember]
        public string Password { get; set; }

        [DataMember]
        public string FirstName { get; set; }

        [DataMember]
        public string LastName { get; set; }

        [DataMember]
        public string Cedula { get; set; }

        [DataMember]
        public string FechaNacimiento { get; set; }

        [DataMember]
        public string Phone { get; set; }

        [DataMember]
        public string Dir { get; set; }

        [DataMember]
        public string Token { get; set; }
        
    }
}