using System.Threading.Tasks;
using Core;
using Core.Models;
using Core.Services;

namespace Services.Data
{
    public class ArtistService : IArtistService
    {
        private readonly IUnitOfWork _unitOfWork;
        public ArtistService(IUnitOfWork unitOfWork)
        {
            _unitOfWork = unitOfWork;
        }
        public async Task<Artist> GetUserById(int id)
        {
            return await _unitOfWork.Artist.SingleOrDefaultAsync(a => a.Id == id);
        }
    }
}
