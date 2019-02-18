using System;
using System.Collections.Generic;
using System.Linq;
using System.Net;
using System.Net.Http;
using System.Web.Http;

namespace GasStationPharmacy.Controllers
{
    [RoutePrefix("medicines")]
    public class GestMedicamentosController : ApiController
    { 
        /**
         * Lista los medicamentos existentes.
         * */
        [Route("")]
        [HttpGet]
        public IEnumerable<String> Get()
        {
            return new string[] {
                new string[] {"Paracetamol","Phischel", "No", "64"}.ToString(),
                new string[] {"Hidróxido de magnesio", "BombaTica", "Sí", "10" }.ToString()
            };
        }
        /**
        * Realiza la función de añadir un medicamento.
        */
        [Route("{MedInfo}")]
        [HttpPost]
        public void Post(string MedInfo)
        {

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