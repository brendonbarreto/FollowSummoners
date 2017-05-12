using System;
using System.Collections.Generic;
using System.Text;

namespace ResponseClasses
{
    public class RunePageDTO
    {
		/// <summary>
		/// Rune page ID.
		/// </summary>
		public long Id { get; set; }

		/// <summary>
		/// Rune page name.
		/// </summary>
		public string Name { get; set; }

		/// <summary>
		/// Indicates if the page is the current page.
		/// </summary>
		public bool Current { get; set; }

		/// <summary>
		/// Collection of rune slots associated with the rune page.
		/// </summary>
		public List<RuneSlotDTO> Slots { get; set; }
	}
}
