using System;
using System.Collections.Generic;
using System.Linq;
using System.Net;
using System.Net.Http;
using System.Web.Http;

namespace GasStationPharmacy.Controllers
{
    [RoutePrefix("Roles")]
    public class GestRolesController : ApiController
    {
        /**
         * Consulta los roles, en general, pero no uno específicamente.
         * */
        [Route("")]
        [HttpGet]
        public String Get()
        {
            return "";
        }

        /**
         * Añade un rol, se indica el rol y la descripción.
         * */
        [Route("{role}/{descr}")]
        [HttpPost]
        public void Post(String role, String descr)
        {

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