using GasStationPharmacy.Models;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Net;
using System.Net.Http;
using System.Web.Http;

namespace GasStationPharmacy.Controllers
{
    [RoutePrefix("REST/cliente")]
    public class ClientController : ApiController
    {
        // GET dago
        [Route("")]
        [HttpGet]
        public string Get()
        {
            CONSTANTS.ListaClientes.Add(new ClienteModel() {
            Cedula = "asdfasf"});
            return CONSTANTS.ListaClientes.Get();
        }

        // GET api/client/5
        [Route("get2/{id:int}")]
        [HttpGet]
        public string Get(int id)
        {
            return "value";
        }

        // POST api/client
        public void Post([FromBody]string value)
        {
        }

        // PUT api/client/5
        public void Put(int id, [FromBody]string value)
        {
        }

        // DELETE api/client/5
        public void Delete(int id)
        {
        }
    }
}