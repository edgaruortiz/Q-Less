﻿using Q_Less.Models;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Net;
using System.Net.Http;
using System.Web.Http;

namespace Q_Less.Controllers.API
{
    public class TransactionsController : ApiController
    {
        private QLinkContext _context;
        public TransactionsController()
        {
            _context = new QLinkContext();
        }

        [HttpPost]
        public IHttpActionResult Save(NewTransaction newTransaction)
        {
            if (ModelState.IsValid)
            {
                var transportCard = _context.TransportCards
                    .SingleOrDefault(c => c.TransportCardUniqueId == newTransaction.TransportCardId);
                var transaction = new Transaction
                {
                    Amount = newTransaction.Amount,
                    EntryPoint = newTransaction.EntryPoint,
                    ExitPoint = newTransaction.ExitPoint,
                    TransportCardId = newTransaction.TransportCardId,
                    DateStamp = DateTime.Now
                };
                _context.Transactions.Add(transaction);
                var currentAmount = transportCard.CardValue;
                transportCard.CardValue = currentAmount - newTransaction.Amount;
                _context.SaveChanges();
            }
            return Ok();
        }

        [HttpGet]
        public IHttpActionResult GetDailyTransactions(int Id)
        {
            if (ModelState.IsValid)
            {
                var transactions = _context.Transactions
                    .Where(t => t.TransportCardId == Id)
                    .ToList()
                    .Where(t => t.DateStamp.ToShortDateString() == DateTime.Now.ToShortDateString());
                return Ok(transactions);
            }
            return Ok();
        }
    }
}
