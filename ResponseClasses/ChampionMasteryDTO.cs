using System;

namespace ResponseClasses
{
	public class ChampionMasteryDTO
	{
		/// <summary>
		/// boolean	Is chest granted for this champion or not in current season.
		/// </summary>
		public bool ChestGranted { get; set; }

		/// <summary>
		/// Champion level for specified player and champion combination.
		/// </summary>
		public int ChampionLevel { get; set; }

		/// <summary>
		/// Total number of champion points for this player and champion combination - they are used to determine championLevel.
		/// </summary>
		public int ChampionPoints { get; set; }

		/// <summary>
		/// Champion ID for this entry.
		/// </summary>
		public long ChampionId { get; set; }

		/// <summary>
		/// Player ID for this entry.
		/// </summary>
		public long PlayerId { get; set; }

		/// <summary>
		/// Number of points needed to achieve next level. Zero if player reached maximum champion level for this champion.
		/// </summary>
		public long ChampionPointsUntilNextLevel { get; set; }

		/// <summary>
		/// Number of points earned since current level has been achieved. Zero if player reached maximum champion level for this champion.
		/// </summary>
		public long ChampionPointsSinceLastLevel { get; set; }

		/// <summary>
		/// Last time this champion was played by this player - in Unix milliseconds time format.
		/// </summary>
		public long LastPlayTime { get; set; }
	}
}
