using System;
using System.Collections.Generic;
using System.Linq;
using System.Web;

namespace GasStationPharmacy.Models
{
    public class MainClass
    {
        static public string Main()
        {
            ClienteModel client1 = new ClienteModel();
            client1.Token = "t1";
            client1.FirstName = "Nombre 1";
            string outPut = "";
            ClientModelList list = new ClientModelList();
            outPut = outPut + list.GetClient("t1") + "\n";
            list.AddClient(client1);
            //System.Diagnostics.Debug.WriteLine(list.GetClient("t1"));
            outPut = outPut + list.GetClient("t1") + "\n";
            //System.Diagnostics.Debug.WriteLine(list.AddClientXML(list.GetClient("t1")));
            outPut = outPut + list.AddClientXML(list.GetClient("t1")) + "\n";
            return outPut;
        }
    }
}