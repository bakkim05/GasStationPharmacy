using Newtonsoft.Json;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Net;
using System.Net.Http;
using System.Web.Http;
using GasStationPharmacy.Models;

namespace GasStationPharmacy.Controllers
{
    [RoutePrefix("Sucursales")]
    public class GestSucursalesController : ApiController
    {
        /**
         * Despliega la información de la sucursal
         * */
        [Route("")]
        [HttpGet]
        public String Get()
        {
            return MainClass.Main();
            //return JsonConvert.SerializeObject(new String[] { "Cartago, Phischel, Cartago, Nickolas", "value2" });
        }

        /**
         * Añade una sucursal
         * */
        [Route("{SucInfo}")]
        [HttpPost]
        public void Post(String SucInfo)
        {
        }

        /**
         * Actualiza una sucursal
         * */
        [Route("{id:int}/{SucInfo}")]
        [HttpPut]
        public void Put(int id, String SucInfo)
        {
        }
        
        /**
         * Elimina una sucursal dado su ID.
         * */
        [Route("{id:int}")]
        [HttpDelete]
        public void Delete(int id)
        {
        }
    }
}