using Integrate.Interview.Frontend.Database.Models;
using Integrate.Interview.Frontend.Models;

namespace Integrate.Interview.Frontend.Mappers
{
    public class ApiPersonToPersonMapper : IToDbMapper<ApiPerson, Person>
    {
        public Person Map(ApiPerson apiPerson)
        {
            return new Person
            {
                Id = apiPerson.Id,
                City = apiPerson.City,
                State = apiPerson.State,
                Title = apiPerson.Title,
                Zipcode = apiPerson.Zipcode,
                FirstName = apiPerson.FirstName,
                LastName = apiPerson.LastName,
                StreetAddress = apiPerson.StreetAddress
            };
        }
    }
}