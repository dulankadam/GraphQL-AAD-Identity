using System.Linq;
using System.Security.Claims;
using GrapQL.API.Models;
using GreenDonut;
using HotChocolate.AspNetCore.Authorization;
using Microsoft.AspNetCore.Mvc;

namespace GrapQL.API.Queries
{
    public class Query
    {
        [Authorize]
        public Book GetBook(ClaimsPrincipal claimsPrincipal) =>
            new Book
            {
                Title = "API Authentication with AAD, and Auth",
                Author = new Author
                {
                    Name = claimsPrincipal.Claims.FirstOrDefault(c => c.Type == "name")?.Value
                }
            };
    }

}