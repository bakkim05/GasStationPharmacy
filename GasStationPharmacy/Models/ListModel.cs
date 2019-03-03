using System;
using System.Collections.Generic;
using System.Linq;
using System.Web;

namespace GasStationPharmacy.Models
{
    public class ListModel
    {

        // Atributos 
        private List<I_GasSModel> listaClientes;

        //Metodos
        public void AddClient(I_GasSModel pClient)
        {
            listaClientes.Add(pClient);
        }

        public string GetClient(I_GasSModel pToken)
        {
            int i = 0;
            for (; i < listaClientes.Count; i++)
            {
                if (listaClientes[i].Compare(pToken).Equals(1))
                {
                    return XmlObjectSerializer.Serialize<I_GasSModel>(listaClientes[i]);
                }
                 
            }
            return "";
        }

        public string AddClientXML(string pClientString)
        {
            I_GasSModel clientTMP = XmlObjectSerializer.Deserialize<I_GasSModel>(pClientString);
            if (this.GetClient(clientTMP.GetIdentifier()).Equals(""))
            {
                listaClientes.Add(clientTMP);
                return "OK";
            }
            else
            {
                return "ERROR";
            }
        }

        //Constructor
        public ClientModelList()
        {
            listaClientes = new List<I_GasSModel>();
        }

    }
}