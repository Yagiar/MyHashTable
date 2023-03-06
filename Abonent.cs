using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Hash_Table_Abonent
{
    internal class Abonent
    {
        string dateOfBirthday;
        string name;
        string phone;
        public string Birthday
        {
            get { return dateOfBirthday; }
        }
        public string Name
        {
            get { return name; }
        }
        public string Phone
        {
            get { return phone; }
        }

        public Abonent(string name, string phone, string dateOfBirthday)
        {
            this.dateOfBirthday = dateOfBirthday;
            this.name = name;
            this.phone = phone;
        }
    }
}
