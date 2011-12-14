using System;
using System.Collections.Generic;
using System.Linq;
using System.Web;

namespace FootballStatisticsApplication.Models
{
    public class Club
    {
        private string clubName;
        private int matchPoints;

        public int MatchPoints
        {
            get { return matchPoints; }
            set { matchPoints = value; }
        }

        public string ClubName
        {
            get { return clubName; }
            set { clubName = value; }
        }

        public Club(string name, int points = 0)
        {
            clubName = name;
            matchPoints = points;
        }
    }
}