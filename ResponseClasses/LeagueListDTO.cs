using System;
using System.Collections.Generic;
using System.Text;

namespace ResponseClasses
{
    public class LeagueListDTO
    {
		public string Tier { get; set; }

		public string Queue { get; set; }

		public string Name { get; set; }

		public List<LeagueItemDTO> Entries { get; set; }
	}
}
