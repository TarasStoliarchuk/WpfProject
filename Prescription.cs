using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace WpfProject
{
    public class Prescription
    {
        public int Id { get; set; }
        public string? NamePrescription { get; set; }
        public string? Ingridients { get; set; }
        public string? TextPrescription { get; set; }

        public int UserId { get; set; }
        public User? User { get; set; }
    }
}
