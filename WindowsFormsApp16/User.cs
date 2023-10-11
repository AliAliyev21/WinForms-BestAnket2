using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace WindowsFormsApp16
{
    public class User
    {
        public string Name { get; set; } = default;
        public string Surname {  get; set; }= default;
        public string Email { get; set; } = default;
        public string Phone { get; set; } = default;
        public DateTime BirthDate {  get; set; }= DateTime.Now;
        public string JsonFileName { get; set; } = default;

    }
}





