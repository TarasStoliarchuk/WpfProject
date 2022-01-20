using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace WpfProject
{
    public class User
    {
        public int id { get; set; }
        public string dblogin { get; set; }
        public string dbpassword { get; set; }
        public List<Prescription> Recipes { get; set; }
    }
}
