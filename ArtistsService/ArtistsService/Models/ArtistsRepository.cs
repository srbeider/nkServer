using System;
using System.Collections.Generic;
using System.Linq;
using System.Web;

namespace ArtistsService.Models
{
    public class ArtistsRepository : IArtistsRepository
    {
        private List<Artist> artists = new List<Artist>();
        private int _nextId = 1;

        public ArtistsRepository()
        {
            Add(new Artist{Id = 1, Category = "Pop", Name = "Kill Me Later", Score = 9});
            Add(new Artist{Id = 2, Category = "Rock", Name="Pablo is a Rockstar", Score = 10});
            Add(new Artist{Id = 3, Category = "Classic", Name="Kraken Simphonic Orchestra", Score = 3.4f});
            Add(new Artist{Id = 4, Category = "Classic", Name="London Orchestra", Score = 7.7f});
        }

        public IEnumerable<Artist> GetAll()
        {
            return artists;
        }

        public Artist Get(int id)
        {
            return artists.Find(p => p.Id == id);
        }

        public Artist Add(Artist item)
        {
            if (item == null)
            {
                throw new ArgumentNullException("item");
            }
            item.Id = _nextId++;
            artists.Add(item);
            return item;
        }

        public void Remove(int id)
        {
            artists.RemoveAll(p => p.Id == id);
        }

        public bool Update(Artist item)
        {
            if (item == null)
            {
                throw new ArgumentNullException("item");
            }
            int index = artists.FindIndex(p => p.Id == item.Id);
            if (index == -1)
            {
                return false;
            }
            artists.RemoveAt(index);
            artists.Add(item);
            return true;
        }
    }
}