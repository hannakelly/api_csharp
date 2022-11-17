using rest_aspnet.Controllers.Model;
using System.Collections.Generic;

namespace rest_aspnet.Services
{
    public interface IPersonService
    {
        Person Create(Person person);

        Person FindByID(long id);

        List<Person> FindAll();

        Person Update(Person person);

        void Delete(long id);
    }
}
