using GasStationPharmacy.Models;
using Newtonsoft.Json;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Net;
using System.Net.Http;
using System.Web.Http;

namespace GasStationPharmacy.Controllers
{
    [RoutePrefix("REST/medicines")]
    public class GestMedicamentosController : ApiController
    { 
        /**
         * Lista los medicamentos existentes.
         * */
        [Route("")]
        [HttpGet]
        public string Get()
        {
            return JsonConvert.SerializeObject(CONSTANTS.ListaMedicamentos.lista, Formatting.Indented);
        }
        /**
        * Realiza la función de añadir un medicamento.
        */
        [Route("{MedInfo}")]
        [HttpPost]
        public void Post(string MedInfo)
        {
            string reformatPost = MedInfo.Replace("-", ":");
            CONSTANTS.ListaClientes.Add(JsonConvert.DeserializeObject<MedicamentoModel>(reformatPost));
        }
        /**
         * Actualiza la información de un medicamento.
         */
        [Route("{MedInfo}")]
        [HttpPut]
        public void Put(string MedInfo)
        {

        }

        /**
         * Borra un medicamento, se pueden seguir los pasos indicados en GestClientes.
         */
        [Route("{IdMed:int}")]
        [HttpDelete]
        public void Delete(int IdMed)
        {

        }
    }
}