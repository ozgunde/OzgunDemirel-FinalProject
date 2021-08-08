using AutoMapper;
using Music.Business.DataTransferObjects;
using Music.Business.Extensions;
using Music.DataAccess.Repositories;
using Music.Models;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;

namespace Music.Business
{
    public class GenreService : IGenreService
    {
        private IGenreRepository genreRepository;
        private IMapper mapper;
        public GenreService(IGenreRepository genreRepository, IMapper mapper)
        {
            this.genreRepository = genreRepository;
            this.mapper = mapper;
        }
        public int AddGenre(AddNewGenreRequest request)
        {
            var newGenre = request.ConvertToGenre(mapper);
            genreRepository.Add(newGenre);
            return newGenre.Id;
        }

        public void DeleteGenre(int id)
        {
            genreRepository.Delete(id);
        }

        public IList<GenreListResponse> GetAllGenres()
        {
            var dtolist = genreRepository.GetAll().ToList();
            var result = dtolist.ConvertToListResponse(mapper);
            return result;
        }

        public GenreListResponse GetGentresById(int id)
        {
            Genre genre = genreRepository.GetByID(id);
            return genre.ConvertFromEntity(mapper);
        }

        public int UpdateGenre(EditGenreRequest request)
        {
            var genre = request.ConvertToEntity(mapper);
            int id = genreRepository.Update(genre).Id;
            return id;
        }
    }
}
