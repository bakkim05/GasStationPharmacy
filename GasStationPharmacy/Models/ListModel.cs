using Newtonsoft.Json;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Runtime.Serialization;
using System.Web;

namespace GasStationPharmacy.Models
{
    public class ListModel 
    {

        // Atributos 
        private List<I_GasSModel> lista;

        //Metodos
        public void Add(I_GasSModel pClient)
        {
            lista.Add(pClient);
        }

        public string GetClient(I_GasSModel pToken)
        {
            for (int i = 0; i < lista.Count; i++)
            {
                if (lista[i].Compare(pToken).Equals(CONSTANTS.SAME))
                {
                    return JSONObjectSerializer.WriteFromObject(lista[i]);
                }
            }
            return "";
        }

        public string Get()
        {
            return JsonConvert.SerializeObject(lista, Formatting.Indented);
            //return JSONObjectSerializer.WriteFromObject(lista);
        }

        public string AddElement(string pClientString)
        {
            I_GasSModel clientTMP = XmlObjectSerializer.Deserialize<I_GasSModel>(pClientString);
            if (this.GetClient(clientTMP).Equals(""))
            {
                lista.Add(clientTMP);
                return "OK";
            }
            else
            {
                return "ERROR";
            }
        }
        //Constructor
        public ListModel()
        {
            lista = new List<I_GasSModel>();
        }

    }
}