using Core.Models;
using System;
using System.Collections.Generic;
using System.Text;
using System.Threading.Tasks;

namespace Core.Services
{
    public interface IArtistService
    {
        Task<Artist> GetUserById(int id);
        Task<Artist> CreateArtist(Artist artist);
    }


}
