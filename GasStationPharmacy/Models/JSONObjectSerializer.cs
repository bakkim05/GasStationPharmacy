using System;
using System.Collections.Generic;
using System.IO;
using System.Linq;
using System.Runtime.Serialization.Json;
using System.Text;
using System.Web;


namespace GasStationPharmacy.Models
{
    public class JSONObjectSerializer
    {
        // Create a User object and serialize it to a JSON stream.  

        public static string WriteFromLista(List<GasSModel> lista) {
            string retStr = "[";
            for(int i = 0; i<lista.Count; i++){
                retStr += WriteFromObject(lista.ElementAt(i));
                if (i != lista.Count - 1)
                {
                    retStr += ",";
                }
            }
            retStr += "]";
            return retStr;
        }
        public static string WriteFromObject(GasSModel toEncode)
        {
            /*
            //Create User object.  
            User user = new User("Bob", 42);
            */
            //Create a stream to serialize the object to.  
            MemoryStream ms = new MemoryStream();

            // Serializer the User object to the stream.  
            DataContractJsonSerializer ser = new DataContractJsonSerializer(typeof(GasSModel));
            ser.WriteObject(ms, toEncode);
            byte[] json = ms.ToArray();
            ms.Close();
            return Encoding.Unicode.GetString(json, 0, json.Length);
        }

        // Deserialize a JSON stream to a User object.  
        public static GasSModel ReadToObject(string json, int type)
        {
            GasSModel deserialized;
            switch (type)
            {
                case CONSTANTS.CLIENTE:
                    deserialized = new ClienteModel();
                    break;
                case CONSTANTS.DOCTOR:
                    deserialized = new DoctorModel();
                    break;
                case CONSTANTS.MEDICAMENTO:
                    deserialized = new MedicamentoModel();
                    break;
                case CONSTANTS.ROLES:
                    deserialized = new RolModel();
                    break;
                case CONSTANTS.SUCURSAL:
                    deserialized = new SucursalModel();
                    break;
                case CONSTANTS.PEDIDO:
                    deserialized = new PedidoModel();
                    break;
                default:
                    deserialized = new ClienteModel();
                    break;
            }
            MemoryStream ms = new MemoryStream(Encoding.UTF8.GetBytes(json));

            DataContractJsonSerializer ser = new DataContractJsonSerializer(deserialized.GetType());
            deserialized = ser.ReadObject(ms) as GasSModel;
            ms.Close();
            return deserialized;
        }
    }
}