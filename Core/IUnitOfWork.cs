using Core.Respositories;
using System;
using System.Collections.Generic;
using System.Text;
using System.Threading.Tasks;

namespace Core
{
    public interface IUnitOfWork
    {
        IArtistRepository Artist { get; }
        IAlbomRepository Albom { get; }
        IMusicRepository Music { get; set; }
        Task<int> CommitAsync();
    }
}
