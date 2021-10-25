using System;
using System.Collections.Generic;
using System.Linq;
using System.Threading.Tasks;

namespace MySecondWebApplication
{
    public class Person
    {
        private static int _idCounter = 0;
        public int Age { get; set; }
        public string Name { get; set; }
        public int Id { get; private set; }
        public Person()
        {
            this.Id = _idCounter++;
        }
    }
}
