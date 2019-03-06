using System;
using System.Collections.Generic;
using System.Linq;
using System.Web;

namespace GasStationPharmacy.Models
{
    public abstract class CONSTANTS
    {
        public const int CLIENTE = 1;
        public const int DOCTOR = 2;
        public const int MEDICAMENTO = 3;
        public const int ROLES = 4;
        public const int SUCURSAL = 5;
        public const int PEDIDO = 6;

        public const int SAME = 0;
        public const int DIFFERENT = 1;

        //public const 

        public static ListModel ListaClientes = new ListModel();
        public static ListModel ListaDoctores = new ListModel();
        public static ListModel ListaMedicamentos = new ListModel();
        public static ListModel ListaPedidos = new ListModel();
        public static ListModel ListaRecipes = new ListModel();
        public static ListModel ListaRoles = new ListModel();
        public static ListModel ListaSucursales = new ListModel();
    }
}