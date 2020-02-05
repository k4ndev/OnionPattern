using Core.Models;
using Core.Respositories;
using System;
using System.Collections.Generic;
using System.Text;

namespace Data.Repositories
{
    public  class AlbomRepository:Repository<Albom>,IAlbomRepository
    {
        private MusicAppContext _context => Context as MusicAppContext;
        public AlbomRepository(MusicAppContext context ):base(context)
        {

        }
    }
}
