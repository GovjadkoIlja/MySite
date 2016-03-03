using System;
using System.Collections.Generic;
using System.Linq;
using System.Web;

namespace MvcApplication4.Models
{
    public class Filmmass
    {
        public static List<Film> makemass()
        {
            List<Film> mass = new List<Film>();
            mass.Add(new Film()
            {
                Name = "Великий Гэтсби",
                Genre = "Драма",
                Actors="Леонардо Ди Каприо, Тоби Магвуайр",
                Ssilka = "http://www.kinopoisk.ru/film/463724/"
            });
            mass.Add(new Film()
            {
                Name = "Троя",
                Genre = "Боевик",
                Actors = "Брэд Питт",
                Ssilka = "http://www.kinopoisk.ru/film/3442/"
            });
            return mass;
        }

    }
}