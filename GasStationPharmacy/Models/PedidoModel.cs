using System;
using System.Collections.Generic;
using System.Linq;
using System.Web;

namespace GasStationPharmacy.Models
{
    public class PedidoModel
    {
       /** Gestión de Pedidos: Las operaciones que debe proveer este módulo son creación,
actualización, eliminación de pedidos, los datos a almacenar de los pedidos son:
sucursal de recojo, cliente, teléfono preferido, listado de medicamentos, hora de
recojo, imagen de la receta.*/        
        public string Sucursal { get; set; }
        public string NombreCliente { get; set; }
        public string Telefono { get; set; }
        private string[] Medicamentos { get; set; }
        private string HoraRecojo { get; set; }
        private string Image { get; set; }
    }
}