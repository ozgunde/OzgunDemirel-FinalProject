using System;
using System.Collections.Generic;
using System.Text;
using AutoMapper;
using Music.Business.DataTransferObjects;
using Music.Models;

namespace Music.Business.Mapper
{
    public class MappingProfile : Profile
    {
        public MappingProfile()
        {
            CreateMap<Genre, GenreListResponse>().ReverseMap();
            CreateMap<Genre, AddNewGenreRequest>().ReverseMap();
            CreateMap<Genre, EditGenreRequest>().ReverseMap();
        }
    }
}
