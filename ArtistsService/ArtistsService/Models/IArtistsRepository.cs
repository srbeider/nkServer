using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace ArtistsService.Models
{
    interface IArtistsRepository
    {
        IEnumerable<Artist> GetAll();
        Artist Get(int id);
        Artist Add(Artist item);
        void Remove(int id);
        bool Update(Artist item);
    }
}