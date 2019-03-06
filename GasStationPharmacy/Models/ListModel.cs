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
        public List<GasSModel> lista;

        //Metodos
        public void Add(GasSModel pElement)
        {
            lista.Add(pElement);
        }

        public string GetClient(string pToken)
        {
            for (int i = 0; i < lista.Count; i++)
            {
                if (lista[i].Compare(pToken).Equals(CONSTANTS.SAME))
                {
                    return JsonConvert.SerializeObject(lista[i], Formatting.Indented);
                }
            }
            return "";
        }

        public string Get()
        {
            //return JsonConvert.SerializeObject(lista);
            //JsonConvert
            return JSONObjectSerializer.WriteFromLista(lista);
        }

        public string AddElement(string pClientString, int type)
        {
            GasSModel clientTMP = JSONObjectSerializer.ReadToObject(pClientString, type);
            if (this.GetClient(clientTMP.Hash).Equals(CONSTANTS.DIFFERENT))
            {
                lista.Add(clientTMP);
                return "OK";
            }
            else
            {
                return "ERROR";
            }
        }

        public void DeleteElement(string toDel)
        {
            for (int i = 0; i < lista.Count; i++)
            {
                if (lista[i].Compare(toDel).Equals(CONSTANTS.SAME))
                {
                    lista.RemoveAt(i);
                }
            }

        }
        
        //Constructor
        public ListModel()
        {
            lista = new List<GasSModel>();
        }
    }
}