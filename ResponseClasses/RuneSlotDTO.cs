using System;
using System.Collections.Generic;
using System.Text;

namespace ResponseClasses
{
	public class RuneSlotDTO
	{
		/// <summary>
		/// Rune slot ID
		/// </summary>
		public int RuneSlotId { get; set; }

		/// <summary>
		/// Rune ID associated with the rune slot. For static information correlating to rune IDs, please refer to the LoL Static Data API.*/
		/// </summary>
		public int RuneId { get; set; }
	}
}
