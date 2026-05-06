using Microsoft.AspNetCore.Mvc;
using SellingAlbums.Repositories.Interfaces;

namespace SellingAlbums.Components
{
    public class GenreMenu : ViewComponent
    {
        private readonly IGenreRepository _genreRepository;

        public GenreMenu(IGenreRepository genreRepository)
        {
            _genreRepository = genreRepository;
        }

        public IViewComponentResult Invoke()
        {
            var genres = _genreRepository.Genres.OrderBy(g => g.Name);
            return View(genres);
        }
    }
}
