using System;
using System.Collections.Generic;
using System.Linq;
using System.Net;
using System.Net.Http;
using System.Web.Http;

namespace GasStationPharmacy.Controllers
{
    [RoutePrefix("Medicines")]
    public class GestMedicamentos : ApiController
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
        //nombre,
        //casa farmacéutica, requiere prescripción(Si/No), cantidad disponible
        /**
        * Realiza la función de añadir un medicamento.
        */
        [Route("{MedInfo:string}")]
        [HttpPost]
        public void Post(string MedInfo)
        {

        }
        /**
         * Actualiza la información de un medicamento.
         */
        [Route("{MedInfo:string}")]
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


        /*
        // GET api/<controller>
        public IEnumerable<string> Get()
        {
            return new string[] { "value1", "value2" };
        }

        // GET api/<controller>/5
        public string Get(int id)
        {
            return "value";
        }

        // POST api/<controller>
        public void Post([FromBody]string value)
        {
        }

        // PUT api/<controller>/5
        public void Put(int id, [FromBody]string value)
        {
        }

        // DELETE api/<controller>/5
        public void Delete(int id)
        {
        }*/
    }
}