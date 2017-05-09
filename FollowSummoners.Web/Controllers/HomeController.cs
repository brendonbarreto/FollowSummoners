using System;
using System.Collections.Generic;
using System.Linq;
using System.Threading.Tasks;
using Microsoft.AspNetCore.Mvc;
using System.Net.Http;
using ResponseClasses;
using Newtonsoft.Json;
using Newtonsoft.Json.Serialization;

namespace FollowSummoners.Web.Controllers
{
	public class HomeController : Controller
	{
		public async Task<IActionResult> Index()
		{
			var json = await GetJsonAsync();
			ChampionListDTO qr = JsonConvert.DeserializeObject<ChampionListDTO>(json, new JsonSerializerSettings()
			{
				ContractResolver = new CamelCasePropertyNamesContractResolver()
			});

			return View();
		}

		public async Task<string> GetJsonAsync()
		{
			using (var httpClient = new HttpClient())
			{
				var json = await httpClient.GetStringAsync("https://br1.api.riotgames.com/lol/platform/v3/champions?api_key=key");
				return json;
			}
		}

		public IActionResult About()
		{
			ViewData["Message"] = "Your application description page.";

			return View();
		}

		public IActionResult Contact()
		{
			ViewData["Message"] = "Your contact page.";

			return View();
		}

		public IActionResult Error()
		{
			return View();
		}
	}
}
