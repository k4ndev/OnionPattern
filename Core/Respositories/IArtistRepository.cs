using Core.Models;
using System;
using System.Collections.Generic;
using System.Text;
using System.Threading.Tasks;

namespace Core.Respositories
{
    public interface IArtistRepository :IRepository<Artist>
    {
        Task<Artist> FindArtist(int id);
    }
}
