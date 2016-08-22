using System.Web.Http;
using WebActivatorEx;
using Auction.API;
using Swashbuckle.Application;

[assembly: PreApplicationStartMethod(typeof(SwaggerConfig), "Register")]

namespace Auction.API
{
	public class SwaggerConfig
	{
		public static void Register()
		{
			var thisAssembly = typeof(SwaggerConfig).Assembly;

			GlobalConfiguration.Configuration
                .EnableSwagger(c => { c.SingleApiVersion("v1", "Auction.API");
                c.IncludeXmlComments(string.Format(@"{0}\bin\Auction.API.XML",           
                           System.AppDomain.CurrentDomain.BaseDirectory)); })
				.EnableSwaggerUi(c => { });
		}
	}
}
