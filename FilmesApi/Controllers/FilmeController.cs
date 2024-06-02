using FilmesApi.Models;
using Microsoft.AspNetCore.Mvc;
using System;
using System.Collections.Generic;
using System.Linq;

namespace FilmesApi.Controllers
{
    [ApiController]
    [Route("[controller]")]
    public class FilmeController : ControllerBase
    {
        private static List<Filme> FilmesApi = new List<Filme>();
        private static int Id = 1;

        [HttpPost]
        public IActionResult AdicionarFilmes([FromBody] Filme filme)
        {
            filme.Id = Id++;
            FilmesApi.Add(filme);
            Console.WriteLine(filme.Titulo);
            return CreatedAtAction(nameof(RecuperaFilmePorId),new {Id = filme.Id}, filme);
        }


        [HttpGet]
        public IActionResult RecuperaFilmes()
        {
            return Ok(FilmesApi);
        }
        [HttpGet("{id}")]
        public IActionResult RecuperaFilmePorId(int id)
        {
            Filme filme =  FilmesApi.FirstOrDefault(filme => filme.Id == id);
            if (filme == null)
            {
                return NotFound();
                
            }
            return Ok(filme);
        }
    }
}
