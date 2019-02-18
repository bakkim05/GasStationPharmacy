using System;
using System.Collections.Generic;
using System.Linq;
using System.Net;
using System.Net.Http;
using System.Web.Http;

namespace GasStationPharmacy.Controllers
{
    [RoutePrefix("Loggin")]
    public class LogginCotroller : ApiController
    {
       
        // Post /
        [Route("{user}/{pwd}")]
        [HttpPost]
        public String Post(String user, String pwd)
        {
            return true.ToString();
        }
    }
}