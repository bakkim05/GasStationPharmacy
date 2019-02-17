using System;
using System.Collections.Generic;
using System.Linq;
using System.Net;
using System.Net.Http;
using System.Web.Http;

namespace GasStationPharmacy.Controllers
{
    [RoutePrefix("Clients")]
    public class GestClientes : ApiController
    {

        /**Get principal de la página, solicita la información para desplegar los clientes existentes, 
         * se podría incluir el historial o simplemente ocultarlo y desplegarlo con js.
         */
        [Route("")]
        [HttpGet]
        public IEnumerable<String> Get()
        {
            return new string[] {
                new string[] {"5-0410-0316", "Dagoberto", "Rojas", "Cartago", new DateTime().ToString(),
                    "2550-2480"}.ToString(),
                new string[] {"5-0410-0316", "Keylor", "Juárez", "Cartago", "07/05/1996",
                    "2550-9299"}.ToString()};
        }

        /**Se puede utilizar para obtener o no el historial en caso de que se desee tener el historial por aparte,
         * pero es posible no utilizarlo dependiendo de la implementación.
         * @IDpte id del paciente del que se desea obtener la descripción.
         * @visible indica si se debe o no desplegar el cuadro de texto para el historial.
         */
        //Usa Iframe para despligar la información de esta página.
        /*<iframe src="Clients/id/bool"></iframe>*/
        [Route("{IDpte:int}/{visible:bool}")]
        [HttpGet]
        public string Get(int IDpte, bool visible)
        {
            if (visible)
            {
                return "Lorem ipsum dolor sit amet, consectetur adipiscing elit, sed do eiusmod tempor incididunt ut labore et dolore magna aliqua. Ut enim ad minim veniam, quis nostrud exercitation ullamco laboris nisi ut aliquip ex ea commodo consequat. Duis aute irure dolor in reprehenderit in voluptate velit esse cillum dolore eu fugiat nulla pariatur. Excepteur sint occaecat cupidatat non proident, sunt in culpa qui officia deserunt mollit anim id est laborum.";
            } else
            {
                return "";
            }
        }

        /**
         * Se encarga de eliminar determinado paciente al especificar su ID.
         */
        /*Ejecutar esta solicitud y luego un get para obtener la página actualizada o eleiminarlo con js para
         minimizar el tráfico en la red, aunque no va a ser algo significativo*/
        [Route("{IDpte:int}")]
        [HttpDelete]
        public void Delete(int IDpte)
        {

        }

        /**
         * Se encarga de actualizar la información de un paciente, PteInfo sería un json con los campos que se 
         * deben editar, preferiblemente codificado para que la info no sea visible en el url.
         * 
         * @PteInfo String con los campos e información del paciente que se desea actualizar.
         */
        /*PteInfo sería un json o algo codificado para que la información del paciente no sea visible a simple
         vista.
         
         Se podría utlizar este método y luego get, o se podría utilizar y recrear con js*/
        [Route("{PteInfo:string}")]
        [HttpPut]
        public void Put(string PteInfo)
        {

        }

        /*Número Cédula, Nombre, Apellidos, Lugar de Residencia, Fecha de nacimiento,
teléfono y una breve historial de los padecimientos*/
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