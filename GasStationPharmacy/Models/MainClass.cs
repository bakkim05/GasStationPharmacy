using System;
using System.Collections.Generic;
using System.Linq;
using System.Web;
using GasStationPharmacy.Models;

namespace GasStationPharmacy.Models
{
    public class MainClass
    {
        public static string Main()
        {
            ClienteModel c1 = new ClienteModel
            {
                Cedula = "504100316",
                Dir = "Dir 1"
            };

            ClienteModel c3 = new ClienteModel
            {
                Cedula = "asdfsa",
                Dir = "Dir n"
            };

            ListModel lista = new ListModel();
            lista.Add(c1);
            lista.Add(c3);
            return lista.Get();
            //return JSONObjectSerializer.WriteFromObject(lista);
            /*
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
            return outPut;*/
        }
    }
}