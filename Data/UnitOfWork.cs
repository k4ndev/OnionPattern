using Core;
using Core.Respositories;
using Data.Repositories;
using System;
using System.Collections.Generic;
using System.Text;
using System.Threading.Tasks;

namespace Data
{
    public class UnitOfWork : IUnitOfWork
    {

        private readonly MusicAppContext _context;
        private IMusicRepository _musicRepository;
        private IAlbomRepository _albomRepository;
        private IArtistRepository _artistRepository;
         
        public IArtistRepository Artist => _artistRepository?? new ArtistRepository(_context);

        public IAlbomRepository Albom => _albomRepository?? new AlbomRepository(_context);

        public IMusicRepository Music { get => throw new NotImplementedException(); set => throw new NotImplementedException(); }

        public UnitOfWork(MusicAppContext context)
        {
            this._context = context;
        }
        public Task<int> CommitAsync()
        {
            throw new NotImplementedException();
        }
    }
}
