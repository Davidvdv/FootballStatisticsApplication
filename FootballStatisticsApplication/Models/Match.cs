using System;
using System.Collections.Generic;
using System.Linq;
using System.Web;

namespace FootballStatisticsApplication.Models
{
    public class Match
    {
        private Club home;
		private int homeGoals;

		private Club guest;
		private int guestGoals;

		public int GuestGoals
		{
			get { return guestGoals; }
			set { guestGoals = value; }
		}

		public int HomeGoals
		{
			get { return homeGoals; }
			set { homeGoals = value; }
		}

        public Club Home
        {
            get { return home; }
            set { home = value; }
        }
        
        public Club Guest
        {
            get { return guest; }
            set { guest = value; }
        }

        public Match(Club homeTeam, Club guestTeam)
        {
            home = homeTeam;
            guest = guestTeam;
			guestGoals = 0;
			homeGoals = 0;
        }
    }
}