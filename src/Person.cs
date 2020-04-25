using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace src
{
    class Person
    {
         string fam =" ";
         string name = " ";
         int age = 0;

        public string Fam
        {
            get { return this.fam; }
            set { this.fam = value; }
        }
        public string Name
        {
            get { return this.name; }
            set { this.name = value; }
        }
        public int Age
        {
            get { return this.age; }
            set { this.age = value; }
        }
    }
}
