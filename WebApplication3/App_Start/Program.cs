using System;
using System.Collections.Generic;
using System.Linq;
using System.Web;
using WebApplication3.Controllers;
using WebApplication3.Models;
using SimpleInjector;

namespace WebApplication3.App_Start
{
	public static class Program
	{
		static readonly Container container;

		static Program()
		{
			container = new Container();

			container.Register<CardsController>();

			container.Verify();
		}

		static void Main(string[] args)
		{
			CardsController controller = container.GetInstance<CardsController>();
			Card card = controller.GetCardById(1) as Card;
		}
	}
}