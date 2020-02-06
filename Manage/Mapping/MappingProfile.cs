using AutoMapper;
using Core.Models;
using Manage.DTO;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Threading.Tasks;

namespace Manage.Mapping
{
    public class MappingProfile :Profile
    {

        private string PhotoUrl = "localhost";
        public MappingProfile()
        {
            CreateMap<Artist, ArtistDto>()
                .ForMember(d => d.Poster,opt=>opt.MapFrom(src=>PhotoUrl+src.Poster))
                .ForMember(d=>d.AddedAt,opt=>opt.MapFrom(src=>DateTime.Now));

        }
    }
}
