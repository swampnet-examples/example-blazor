using Microsoft.AspNetCore.Components;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Threading;
using System.Threading.Tasks;

namespace Swampnet.Examples.BlazorApp.Components
{
    public class HelloBase : ComponentBase
    {
        [Parameter]
        public string Title { get; set; }

        [Parameter]
        public RenderFragment ChildContent { get; set; }



        protected void OnClick()
        {
            Title = DateTime.UtcNow.ToLongTimeString();
        }

    }
}
