using Music.Business.DataTransferObjects;
using Music.Models;
using System;
using System.Collections.Generic;
using System.Text;

namespace Music.Business
{
    public interface IGenreService
    {
        IList<GenreListResponse> GetAllGenres();
        int AddGenre(AddNewGenreRequest request); //eklenen son varlığın id'si
        GenreListResponse GetGentresById(int id);
        int UpdateGenre(EditGenreRequest request);
        void DeleteGenre(int id);
    }
}
