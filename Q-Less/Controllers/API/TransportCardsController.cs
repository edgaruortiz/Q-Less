using Q_Less.Models;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Web.Http;
using System.Web;
using System.Data.Entity;

namespace Q_Less.Controllers.API
{
    public class TransportCardsController : ApiController
    {
        private QLinkContext _context;
        public TransportCardsController()
        {
            _context = new QLinkContext();
        }

        [HttpGet]
        public IHttpActionResult GetTransportCard(int Id)
        {
            var transportCard = _context.TransportCards
                .Include(c => c.CardType)
                .SingleOrDefault(c => c.TransportCardUniqueId == Id);
            if (transportCard == null)
                return NotFound();
            return Ok(transportCard);
        }
    }
}
