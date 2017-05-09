using System;
using System.Collections.Generic;
using System.Text;

namespace ResponseClasses
{
    public class LeagueItemDTO
    {
		public string Rank { get; set; }

		public bool HotStreak { get; set; }

		public MiniSeriesDTO MiniSeries { get; set; }

		public int Wins { get; set; }

		public bool Veteran { get; set; }

		public int Losses { get; set; }

		public string PlayerOrTeamId { get; set; }

		public string PlayerOrTeamName { get; set; }

		public bool Inactive { get; set; }

		public bool FreshBlood { get; set; }

		public int LeaguePoints { get; set; }
	}
}
