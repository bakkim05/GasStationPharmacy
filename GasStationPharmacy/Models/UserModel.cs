using System;
using System.Collections.Generic;
using System.Linq;
using System.Web;

namespace GasStationPharmacy.Models
{
    public class UserModel
    {
        private int id;
        public int Id { get; set; }
        private string userName;
        public string UserName { get; set; }
        private string Password { get; set; }
        private string FirstName { get; set; }
        private string LastName { get; set; }
        private string Cedula { get; set; }
        private string FechaNacimiento { get; set; }
        private string Phone { get; set; }
        private string Dir { get; set; }
        private string Token { get; set; }
    }
    
    class Program
    {
        static void Main()
        {
            UserModel m1 = new UserModel();
            m1.
        }
    }
}