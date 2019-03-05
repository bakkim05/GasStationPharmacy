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
        public static string WriteFromObject(object toEncode)
        {
            /*
            //Create User object.  
            User user = new User("Bob", 42);
            */
            //Create a stream to serialize the object to.  
            MemoryStream ms = new MemoryStream();

            // Serializer the User object to the stream.  
            DataContractJsonSerializer ser = new DataContractJsonSerializer(typeof(I_GasSModel));
            ser.WriteObject(ms, toEncode);
            byte[] json = ms.ToArray();
            ms.Close();
            return Encoding.UTF8.GetString(json, 0, json.Length);
        }

        // Deserialize a JSON stream to a User object.  
        public static I_GasSModel ReadToObject(string json, int type)
        {
            I_GasSModel deserialized;
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
            deserialized = ser.ReadObject(ms) as I_GasSModel;
            ms.Close();
            return deserialized;
        }
    }
}