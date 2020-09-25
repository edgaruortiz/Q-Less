﻿using Q_Less.Models;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Net;
using System.Net.Http;
using System.Web.Http;

namespace Q_Less.Controllers.API
{
    public class DestinationsController : ApiController
    {
        private QLinkContext _context;
        public DestinationsController()
        {
            _context = new QLinkContext();
        }

        [HttpGet]
        public IHttpActionResult GetStations(int id)
        {
            var stations = _context.Stations.Where(s => s.line == id)
                .Select(s => new { s.StationName, s.Id }).ToList();
            if (stations == null)
                return NotFound();
            return Ok(stations);
        }



        [HttpPost]
        public IHttpActionResult GetTripCost(NewTrip newTrip)
        {
            var transportCard = _context.PriceMatrices
                .Where(p => p.EntryStationid == newTrip.EntryPointId && p.ExitStationid == newTrip.ExitPointId)
                .ToList();
            if (transportCard == null)
                return NotFound();
            return Ok(transportCard);
        }
    }
}

