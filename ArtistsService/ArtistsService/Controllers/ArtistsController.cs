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
        Artist[] artists = new Artist[]
        {
            new Artist{Id = 1, Category = "Pop", Name = "Kill Me Later", Score = 9},
            new Artist{Id = 2, Category = "Rock", Name="Pablo is a Rockstar", Score = 10},
            new Artist{Id = 3, Category = "Classic", Name="Kraken Simphonic Orchestra", Score = 3.4f},
            new Artist{Id = 4, Category = "Classic", Name="London Orchestra", Score = 7.7f}
        };

        public IEnumerable<Artist> GetAllArtists()
        {
            return artists;
        }

        public Artist GetArtistById(int id)
        {
            var artist = artists.FirstOrDefault(a => a.Id == id);
            if (artist == null)
            {
                throw new HttpResponseException(HttpStatusCode.NotFound);
            }
            return artist;
        }

        public IEnumerable<Artist> GetArtistsByCategory(string category)
        {
            var result = artists.Where(a => string.Equals(a.Category, category, StringComparison.OrdinalIgnoreCase));
            if (result == null || result.Count() == 0)
            {
                throw new HttpResponseException(HttpStatusCode.NotFound);
            }
            return result;
        }
    }
}