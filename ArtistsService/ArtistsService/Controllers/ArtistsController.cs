using ArtistsService.Models;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Net;
using System.Net.Http;
using System.Web.Http;

namespace ArtistsService.Controllers
{
    public class ArtistsController : ApiController
    {
        static readonly IArtistsRepository repository = new ArtistsRepository();

        public IEnumerable<Artist> GetAllArtists()
        {
            return repository.GetAll();
        }

        public Artist GetArtistById(int id)
        {
            var artist = repository.Get(id);
            if (artist == null)
            {
                throw new HttpResponseException(HttpStatusCode.NotFound);
            }
            return artist;
        }

        public IEnumerable<Artist> GetArtistsByCategory(string category)
        {
            var result = repository.GetAll().Where(a => string.Equals(a.Category, category, StringComparison.OrdinalIgnoreCase));
            if (result == null || result.Count() == 0)
            {
                throw new HttpResponseException(HttpStatusCode.NotFound);
            }
            return result;
        }
    }
}