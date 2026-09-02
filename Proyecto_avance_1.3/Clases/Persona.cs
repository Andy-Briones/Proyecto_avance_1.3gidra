using System;
using System.Collections.Generic;
using System.Linq;
using System.Runtime.CompilerServices;
using System.Text;
using System.Threading.Tasks;

namespace Clases
{
    public class Persona
    {
        public string name;
        public int age;
        public override string ToString()
        {
            return ""+name+" "+age;
        }
    }
}
