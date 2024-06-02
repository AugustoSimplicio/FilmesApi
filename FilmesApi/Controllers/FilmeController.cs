using FilmesApi.Models;
using Microsoft.AspNetCore.Mvc;
using System;
using System.Collections.Generic;

namespace FilmesApi.Controllers
{
    [ApiController]
    [Route("[controller]")]
    public class FilmeController
    {
        private static List<Filme> FilmesApi = new List<Filme>();

        [HttpPost]
        public void AdicionarFilmes([FromBody] Filme filme)
        {
            FilmesApi.Add(filme);
            Console.WriteLine(filme.Titulo);
        }
    }
}
