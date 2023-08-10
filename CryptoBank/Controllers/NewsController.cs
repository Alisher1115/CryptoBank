using CryptoBank.Models;
using Microsoft.AspNetCore.Mvc;

namespace CryptoBank.Controllers
{
    [ApiController]
    [Route("[controller]")]
    public class NewsController : ControllerBase
    {
        private static readonly List<NewsModel> News = new List<NewsModel>()
        {
            new NewsModel
            {
                Title = "First Title",
                Date = DateTime.Now,
                Author = "First Author",
                Text = "First News"
            },
            new NewsModel
            {
                Title = "Second Title",
                Date = DateTime.Now,
                Author = "Second Author",
                Text = "Second News"
            },
            new NewsModel
            {
                Title = "Third Title",
                Date = DateTime.Now,
                Author = "Third Author",
                Text = "Third News"
            }
        };

        public NewsController()
        {
        }

        [HttpGet(Name = "GetNews")]
        public IEnumerable<NewsModel> Get()
        {
            return News;
        }
    }
}
