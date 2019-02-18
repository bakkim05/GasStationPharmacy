using System;
using System.Collections.Generic;
using System.Linq;
using System.Net;
using System.Net.Http;
using System.Web.Http;

namespace GasStationPharmacy.Controllers
{
    [RoutePrefix("Docs")]
    public class GestDoctoresController : ApiController
    {

        [Route("")]
        [HttpGet]
        public IEnumerable<String> Get()
        {
            return new string[] {
                new string[] {"5-0410-0316","10056", "Dagoberto", "Rojas", "Cartago", new DateTime().ToString(),
                    "2550-2480"}.ToString(),
                new string[] {"5-0410-0316","15532", "Keylor", "Juárez", "Cartago", "07/05/1996",
                    "2550-9299"}.ToString()};
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