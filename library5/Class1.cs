using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;

namespace Library
    {
        public class Registration
        {
            public string Email { get; set; }
            public string Password { get; set; }
            public string Name { get; set; }
            public string ContactNumber { get; set; }

            public Registration(string email, string password, string name, string contactNumber)
            {
                Email = email;
                Password = password;
                Name = name;
                ContactNumber = contactNumber;
            }
        }
    }


