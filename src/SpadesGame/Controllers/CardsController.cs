using System;
using System.Collections.Generic;
using System.Linq;
using System.Threading.Tasks;
using Microsoft.AspNetCore.Mvc;
using SpadesGame.Services;
using SpadesGame.Models;

// For more information on enabling Web API for empty projects, visit http://go.microsoft.com/fwlink/?LinkID=397860

namespace SpadesGame.Controllers
{
    [Route("api/[controller]")]
    public class CardsController : Controller
    {
        private ICardService _service;
        // GET: api/values
        [HttpGet]


        //At the beginning of new game the cards are sent over to the dealer to be delt
        public IEnumerable<Card> Get()
        {
            return _service.GetAllCards();
        }

        //// GET api/values/5
        //[HttpGet("{id}")]
        //public string Get(int id)
        //{
        //    return "value";
        //}

        //// POST api/values
        //[HttpPost]
        //public void Post([FromBody]string value)
        //{
        //}

        //// PUT api/values/5
        //[HttpPut("{id}")]
        //public void Put(int id, [FromBody]string value)
        //{
        //}

        //// DELETE api/values/5
        //[HttpDelete("{id}")]
        //public void Delete(int id)
        //{
        //}

        public CardsController(ICardService service)
        {
            this._service = service;
        }
    }
}
