using AutoMapper;
using Core.Models;
using Core.Services;
using Manage.DTO;
using Microsoft.AspNetCore.Mvc;
using System.Threading.Tasks;

namespace Manage.Controllers
{
    [Route("api/artist")]
    [ApiController]
    public class ArtistController : ControllerBase
    {
        private readonly IMapper _mapper;
        private readonly IArtistService _artistService;

        public ArtistController(IMapper mapper,IArtistService artistService)
        {
            _artistService = artistService;
            _mapper = mapper;
        }

        [HttpGet]
        [Route("{id}")]
        public async Task<IActionResult> GetByArtist(int id)
        {
            var artist = await _artistService.GetUserById(id);
            var artistdto = _mapper.Map<Artist, ArtistDto>(artist);
            return Ok(artistdto);
        }

        
    }
}