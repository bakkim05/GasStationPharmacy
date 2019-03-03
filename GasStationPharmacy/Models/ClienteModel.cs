using System;
using System.Collections.Generic;
using System.Linq;
using System.Web;

namespace GasStationPharmacy.Models
{
    public class ClienteModel : I_GasSModel
    {
        public static readonly string modelType = "Cliente";
        public int Id { get; set; }
        public string UserName { get; set; }
        public string Password { get; set; }
        public string FirstName { get; set; }
        public string LastName { get; set; }
        public string Cedula { get; set; }
        public string FechaNacimiento { get; set; }
        public string Phone { get; set; }
        public string Dir { get; set; }
        public string Token { get; set; }

        public string Compare(I_GasSModel toCompare)
        {
            throw new NotImplementedException();
        }
    }
}