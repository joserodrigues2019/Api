using Microsoft.AspNetCore.Mvc;
using System.Diagnostics;
using System.Reflection;

namespace API.Information
{
    [Route("[controller]")]
    [ApiController]
    public class InformationController : Controller
    {
		public dynamic Get()

		{
			var version = Assembly.GetExecutingAssembly();
			var result = new
			{
				servico = FileVersionInfo.GetVersionInfo(version.Location).ProductName,
				versao  = FileVersionInfo.GetVersionInfo(version.Location).FileVersion	
			};

			return result;
		}
	}
}
