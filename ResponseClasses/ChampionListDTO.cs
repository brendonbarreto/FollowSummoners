using System;
using System.Collections.Generic;
using System.Text;

namespace ResponseClasses
{
	public class ChampionListDTO
	{
		/// <summary>
		/// The collection of champion information.
		/// </summary>
		public List<ChampionDTO> Champions { get; set; }
	}
}
