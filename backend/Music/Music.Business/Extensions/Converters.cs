using Music.Business.DataTransferObjects;
using System;
using System.Collections.Generic;
using System.Text;
using Music.Models;
using AutoMapper;

namespace Music.Business.Extensions
{
    public static class Converters
    {
        public static List<GenreListResponse> ConvertToListResponse(this List<Genre> genres, IMapper mapper)
        {
            return mapper.Map<List<GenreListResponse>>(genres);
            //var result = new List<GenreListResponse>();
            //genres.ForEach(x => result.Add(new GenreListResponse
            //{
            //    Id = x.Id,
            //    GenreName = x.GenreName
            //}));
        }
        public static Genre ConvertToGenre(this AddNewGenreRequest request, IMapper mapper)
        {
            return mapper.Map<Genre>(request);
        }

        public static GenreListResponse ConvertFromEntity(this Genre genre, IMapper mapper)
        {
            return mapper.Map<GenreListResponse>(genre);
        }
        public static Genre ConvertToEntity(this EditGenreRequest request, IMapper mapper)
        {
            return mapper.Map<Genre>(request);
        }
    }
}
