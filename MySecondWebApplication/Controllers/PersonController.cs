using Microsoft.AspNetCore.Http;
using Microsoft.AspNetCore.Mvc;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Threading.Tasks;

namespace MySecondWebApplication.Controllers
{
    [Route("api/[controller]")]
    [ApiController]
    public class PersonController : ControllerBase
    {
        [HttpGet("{personId}")]
        public Person GetPerson(long personId)
        {
            return Managers.PersonManager.Instance.Get(personId);
            
        }
        [HttpGet()]
        public List<Person> ListPerson()
        {
            return Managers.PersonManager.Instance.List();
        }
        [HttpPost]
        public bool CreatePerson([FromBody]Person thePerson)
        {
            Managers.PersonManager.Instance.Create(thePerson);
            return true;
        }
    }
}