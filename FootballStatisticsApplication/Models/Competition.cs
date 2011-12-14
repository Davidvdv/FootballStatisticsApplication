using System;
using System.Collections.Generic;
using System.Linq;
using System.Web;

namespace FootballStatisticsApplication.Models
{
    public class Competition
    {
        private string competitionName;
        private List<Club> clubs = new List<Club>();
        private List<Match> matches = new List<Match>();

        public List<Match> Matches
        {
            get { return matches; }
            set { matches = value; }
        }

        public string CompetitionName
        {
            get { return competitionName; }
            set { competitionName = value; }
        }
        
        public List<Club> Clubs
        {
            get { return clubs; }
            set { clubs = value; }
        }

        public Competition(string name)
        {
            competitionName = name;
        }
    }
}