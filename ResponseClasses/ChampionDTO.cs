using System;
using System.Collections.Generic;
using System.Text;

namespace ResponseClasses
{
    public class ChampionDTO
    {
		/// <summary>
		/// Ranked play enabled flag.
		/// </summary>
		public bool RankedPlayEnabled { get; set; }

		/// <summary>
		/// Bot enabled flag (for custom games).
		/// </summary>
		public bool BotEnabled { get; set; }

		/// <summary>
		/// Bot Match Made enabled flag (for Co-op vs. AI games).
		/// </summary>
		public bool BotMmEnabled { get; set; }

		/// <summary>
		/// Indicates if the champion is active.
		/// </summary>
		public bool Active { get; set; }

		/// <summary>
		/// Indicates if the champion is free to play. Free to play champions are rotated periodically.
		/// </summary>
		public bool FreeToPlay { get; set; }

		/// <summary>
		/// Champion ID. For static information correlating to champion IDs, please refer to the LoL Static Data API.
		/// </summary>
		public long Id { get; set; }
	}
}
