using Microsoft.AspNetCore.Components;
using Swampnet.Examples.BlazorApp.Data;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Threading.Tasks;

namespace Swampnet.Examples.BlazorApp.Pages
{
    public class TestComponent : ComponentBase
    {
        [Inject] WeatherForecastService ForecastService { get; set; }

        public string Message { get; set; } = "some message";

        protected void DangerClick()
        {
        }
    }
}
