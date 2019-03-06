using GasStationPharmacy.Models;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Net;
using System.Net.Http;
using System.Web.Http;

namespace GasStationPharmacy.Controllers
{
    [RoutePrefix("REST/doctores")]
    public class GestDoctoresController : ApiController
    {

        [Route("")]
        [HttpGet]
        public string Get()
        {
            return CONSTANTS.ListaDoctores.Get();
        }

        /**
         * Realiza la función de crear un médico.
         */
        [Route("{DocInfo}")]
        [HttpPost]
        public void Post(string DocInfo)
        {

        }
        /**
         * Actualiza la información de un médico.
         */
        [Route("{DocInfo}")]
        [HttpPut]
        public void Put(string DocInfo)
        {

        }

        /**
         * Borra un médico, se pueden seguir los pasos indicados en GestClientes.
         */
        [Route("{IDdoc:int}")]
        [HttpDelete]
        public void Delete(int IDdoc)
        {

        }

        /*Los principales datos de los clientes
son: Número Cédula, Número de doctor, Nombre, Apellidos, Lugar de Residencia,
Fecha de nacimiento.*/

        /*// GET api/<controller>
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