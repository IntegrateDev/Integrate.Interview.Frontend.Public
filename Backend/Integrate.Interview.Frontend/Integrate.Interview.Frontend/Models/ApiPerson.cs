using System.ComponentModel.DataAnnotations;

namespace Integrate.Interview.Api.Models
{
    public class ApiPerson
    {
        public int Id { get; set; }
        [Required] public string FirstName { get; set; }
        [Required] public string LastName { get; set; }
        public string StreetAddress { get; set; }
        public string City { get; set; }
        public string State { get; set; }
        public string Zipcode { get; set; }
        public string Title { get; set; }
    }
}