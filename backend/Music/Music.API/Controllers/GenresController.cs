using Microsoft.AspNetCore.Http;
using Microsoft.AspNetCore.Mvc;
using Music.API.Filters;
using Music.Business;
using Music.Business.DataTransferObjects;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Threading.Tasks;

namespace Music.API.Controllers
{
    [Route("api/[controller]")]
    [ApiController]
    public class GenresController : ControllerBase
    {
        private IGenreService service;

        public GenresController(IGenreService genreService) //dependency injection
        {
            service = genreService;
        }

        [HttpGet]
        public IActionResult GetResult() //Adı önemli değil
        {
            var result = service.GetAllGenres();
            return Ok(result);
        }

        [HttpGet("(id)")]
        public IActionResult GetById(int id)
        {
            var genreListResponse = service.GetGentresById(id);
            if (genreListResponse != null)
            {
                return Ok(genreListResponse);
            }
            return NotFound();
        }

        [HttpPost]
        public IActionResult AddGenre(AddNewGenreRequest request)
        {
            if (ModelState.IsValid)
            {
                int genreId = service.AddGenre(request);
                return CreatedAtAction(nameof(GetById), routeValues: new { id = genreId }, value: null);
            }
            return BadRequest(ModelState);
        }

        [HttpPut("{id}")]
        [GenreExists]
        public IActionResult UpdateGenre(int id, EditGenreRequest request)
        {
            if (ModelState.IsValid)
            {
                int newItemId = service.UpdateGenre(request);
                return Ok();
            }
            return BadRequest(ModelState);
        }
        [HttpDelete("{id}")]
        [GenreExists]
        public IActionResult Delete(int id)
        {
            service.DeleteGenre(id);
            return Ok();
        }
    }
}
