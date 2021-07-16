using Integrate.Interview.Api.Database.Models;
using Integrate.Interview.Api.Models;

namespace Integrate.Interview.Api.Mappers
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