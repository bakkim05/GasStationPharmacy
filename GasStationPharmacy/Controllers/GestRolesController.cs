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
    [RoutePrefix("REST/roles")]
    public class GestRolesController : ApiController
    {
        /**
         * Consulta los roles, en general, pero no uno específicamente.
         * */
        [Route("")]
        [HttpGet]
        public string Get()
        {
            return JsonConvert.SerializeObject(CONSTANTS.ListaRoles.lista, Formatting.Indented);
        }

        /**
         * Añade un rol, se indica el rol y la descripción.
         * */
        [Route("{role}")]
        [HttpPost]
        public void Post(String role)
        {
            string reformatPost = role.Replace("-", ":");
            CONSTANTS.ListaClientes.Add(JsonConvert.DeserializeObject<RolModel>(reformatPost));
        }

        /**
         * Actualiza un determinado rol
         * */
        [Route("{id}/{role}/{descr}")]
        [HttpPut]
        public void Put(String id, String role, String descr)
        {

        }

        /**
         * Se elimina un rol especificado por id.
         * */
        [Route("{id}")]
        [HttpDelete]
        public void Delete(String id)
        {

        }
    }
}