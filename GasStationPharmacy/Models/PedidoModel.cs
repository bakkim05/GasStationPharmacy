using System;
using System.Collections.Generic;
using System.Linq;
using System.Runtime.Serialization;
using System.Web;

namespace GasStationPharmacy.Models
{
    [DataContract]
    public class PedidoModel : I_GasSModel
    {
        /** Gestión de Pedidos: Las operaciones que debe proveer este módulo son creación,
actualización, eliminación de pedidos, los datos a almacenar de los pedidos son:
sucursal de recojo, cliente, teléfono preferido, listado de medicamentos, hora de
recojo, imagen de la receta.*/
        [DataMember]
        public string Sucursal { get; set; }
        [DataMember]
        public string NombreCliente { get; set; }
        [DataMember]
        public string Telefono { get; set; }
        [DataMember]
        private string[] Medicamentos { get; set; }
        [DataMember]
        private string HoraRecojo { get; set; }
        [DataMember]
        private string Image { get; set; }

        public string Compare(I_GasSModel toCompare)
        {
            throw new NotImplementedException();
        }
    }
}