using Q_Less.Models;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Web;
using System.Web.Mvc;
namespace Q_Less.Controllers
{
    public class TransportCardsController : Controller
    {
        private QLinkContext _context;

        public TransportCardsController()
        {
            _context = new QLinkContext();
        }
        public ActionResult Index()
        {
            return View();
        }
        [Route("New")]
        public ActionResult New()
        {
            return View();
        }

        [Route("Load")]
        public ActionResult Load()
        {
            return View();
        }

        [Route("Reload")]
        public ActionResult Reload(TransportCardReloadHistory card)
        {
            var transportCard = _context.TransportCards
                .SingleOrDefault(c => c.TransportCardUniqueId == card.TransportCardUniqueId);

            if (transportCard == null)
                return HttpNotFound();

            double currentVal = transportCard.CardValue;
            transportCard.CardValue = currentVal + card.CardValue;
            card.DateStamp = DateTime.Now;

            _context.TransportCardReloadHistories.Add(card);
            _context.SaveChanges();
            return View();
        }   

        [Route("Save")]
        public ActionResult Save(TransportCard cards)
        {
            if (ModelState.IsValid)
            {
                try
                {
                    _context.TransportCards.Add(cards);
                    _context.SaveChanges();
                }
                catch (Exception ex) { }
            }
            return RedirectToAction("Index", "Home");
        }
    }
}