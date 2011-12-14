using System;
using System.Collections.Generic;
using System.Linq;
using System.Web;
using System.Web.Mvc;
using FootballStatisticsApplication.Models;

namespace FootballStatisticsApplication.Controllers
{
    public class HomeController : Controller
    {
        //
        // GET: /Home/

        public ActionResult Index()
        {
			Club Az = new Club("AZ", 38), 
				 PSV = new Club("PSV", 34),
				 Twente = new Club("Twente", 33),
				 Ajax = new Club("Ajax", 30),
				 Feyenoord = new Club("Feyenoord", 28),
				 Heerenveen = new Club("Heerenveen", 28),
				 Vitesse = new Club("Vitesse", 26),
				 Groningen = new Club("Groningen", 23),
				 Ado = new Club("Ado Den Haag", 21),
				 RJC = new Club("Roda JC", 21);


            Competition eredivisie = new Competition("Eredivisie");
			eredivisie.Clubs.Add( Az );
			eredivisie.Clubs.Add( PSV );
			eredivisie.Clubs.Add( Twente );
			eredivisie.Clubs.Add( Ajax );
			eredivisie.Clubs.Add( Feyenoord );
			eredivisie.Clubs.Add( Heerenveen );
			eredivisie.Clubs.Add( Vitesse );
			eredivisie.Clubs.Add(Groningen);
			eredivisie.Clubs.Add(Ado);
			eredivisie.Clubs.Add( RJC );

			Match match1 = new Match(Feyenoord, Twente);
			match1.HomeGoals = 3;
			match1.GuestGoals = 1;

			Match match2 = new Match(Heerenveen, Az);
			match2.GuestGoals = 1;
			match2.HomeGoals = 5;

			eredivisie.Matches.Add( match1 );
			eredivisie.Matches.Add(match2);

            return View(eredivisie);
        }

    }
}
