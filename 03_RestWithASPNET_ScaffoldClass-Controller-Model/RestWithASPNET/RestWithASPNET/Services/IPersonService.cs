using RestWithASPNET.Model;
using System.Collections.Generic;

namespace RestWithASPNET.Services
{
    public interface IPersonService
    {
        Person create(Person person);
        Person FindByID(long id);
        List<Person> FindAll();
        Person Update(Person person);
        Person Delete(long id);
    }
}
