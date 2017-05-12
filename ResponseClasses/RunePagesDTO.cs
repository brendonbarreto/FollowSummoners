using System;
using System.Collections.Generic;
using System.Text;

namespace ResponseClasses
{
    public class RunePagesDTO
    {
		/// <summary>
		/// Summoner ID.
		/// </summary>
		public long SummonerId { get; set; }

		/// <summary>
		/// Collection of rune pages associated with the summoner.
		/// </summary>
		public int Pages { get; set; }
	}
}
