using HotChocolate.AspNetCore.Authorization;

namespace GrapQL.API.Models
{
    public class Book
    {
        public string Title { get; set; }

        [Authorize]
        public Author Author { get; set; }
    }

    public class Author
    {
        public string Name { get; set; }
    }

}