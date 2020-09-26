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

        protected override void Dispose(bool disposing)
        {
            _context.Dispose();
        }

        [HttpGet]
        public IHttpActionResult GetTransportCard(int Id)
        {
            var transportCard = _context.TransportCards
                .Include(c => c.CardType)
                .Where(c => c.TransportCardUniqueId == Id)
                .ToList()
                .Where(t => DateTime.Now.Year - t.LastUsed.Year  <= 5);
            if (transportCard.Count() == 0)
                return NotFound();
            return Ok(transportCard);
        }
    }
}
