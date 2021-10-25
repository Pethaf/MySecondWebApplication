using System;
using System.Collections.Generic;
using System.Linq;
using System.Threading.Tasks;

namespace MySecondWebApplication.Managers
{
    public class PersonManager
    {
        private List<Person> _persons; 
        public List<Person> List()
        {
            return _persons; 
        }
        private static PersonManager _instance = null;
        public Person Get(long userId)
        {
            return _persons.Find(user => user.Id == userId);
        }
        public void Create(Person thePerson)
        {
            _persons.Add(thePerson);
        }
        public static PersonManager Instance {
            get { 
                if(_instance == null)
                {
                    return _instance = new PersonManager(); 
                }
                else
                {
                    return _instance;
                }
            }
        }
        
        private PersonManager() { }
    }
}
