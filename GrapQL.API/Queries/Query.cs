using System.Linq;
using System.Security.Claims;
using GrapQL.API.Models;

namespace GrapQL.API.Queries
{
    public class Query
    {
        public Book GetBook(ClaimsPrincipal claimsPrincipal) =>
            new Book
            {
                Title = "API Authentication with AAD, and Auh",
                Author = new Author
                {
                    Name = claimsPrincipal.Claims.FirstOrDefault(c=>  c.Type == "name")?.Value 
                }
            };
    }

}