using Core.Models;
using Core.Respositories;
using System;
using System.Collections.Generic;
using System.Text;

namespace Data.Repositories
{
    public class MusicRepository:Repository<Music>,IMusicRepository
    {
        private MusicAppContext _context => Context as MusicAppContext;
        public MusicRepository(MusicAppContext context):base(context)
        {

        }
    }
}
