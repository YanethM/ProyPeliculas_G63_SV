#pragma checksum "C:\ProysCicloIII\semana4_G63\PraticaSemanaIV\Client\Pages\Components\CustomNotFound.razor" "{ff1816ec-aa5e-4d10-87f7-6f4963833460}" "614ed489924c69ed6a79f5993639137ef56b856d"
// <auto-generated/>
#pragma warning disable 1591
namespace PraticaSemanaIV.Client.Pages.Components
{
    #line hidden
    using System;
    using System.Collections.Generic;
    using System.Linq;
    using System.Threading.Tasks;
    using Microsoft.AspNetCore.Components;
#nullable restore
#line 1 "C:\ProysCicloIII\semana4_G63\PraticaSemanaIV\Client\_Imports.razor"
using System.Net.Http;

#line default
#line hidden
#nullable disable
#nullable restore
#line 2 "C:\ProysCicloIII\semana4_G63\PraticaSemanaIV\Client\_Imports.razor"
using System.Net.Http.Json;

#line default
#line hidden
#nullable disable
#nullable restore
#line 3 "C:\ProysCicloIII\semana4_G63\PraticaSemanaIV\Client\_Imports.razor"
using Microsoft.AspNetCore.Components.Forms;

#line default
#line hidden
#nullable disable
#nullable restore
#line 4 "C:\ProysCicloIII\semana4_G63\PraticaSemanaIV\Client\_Imports.razor"
using Microsoft.AspNetCore.Components.Routing;

#line default
#line hidden
#nullable disable
#nullable restore
#line 5 "C:\ProysCicloIII\semana4_G63\PraticaSemanaIV\Client\_Imports.razor"
using Microsoft.AspNetCore.Components.Web;

#line default
#line hidden
#nullable disable
#nullable restore
#line 6 "C:\ProysCicloIII\semana4_G63\PraticaSemanaIV\Client\_Imports.razor"
using Microsoft.AspNetCore.Components.Web.Virtualization;

#line default
#line hidden
#nullable disable
#nullable restore
#line 7 "C:\ProysCicloIII\semana4_G63\PraticaSemanaIV\Client\_Imports.razor"
using Microsoft.AspNetCore.Components.WebAssembly.Http;

#line default
#line hidden
#nullable disable
#nullable restore
#line 8 "C:\ProysCicloIII\semana4_G63\PraticaSemanaIV\Client\_Imports.razor"
using Microsoft.JSInterop;

#line default
#line hidden
#nullable disable
#nullable restore
#line 9 "C:\ProysCicloIII\semana4_G63\PraticaSemanaIV\Client\_Imports.razor"
using PraticaSemanaIV.Client;

#line default
#line hidden
#nullable disable
#nullable restore
#line 10 "C:\ProysCicloIII\semana4_G63\PraticaSemanaIV\Client\_Imports.razor"
using PraticaSemanaIV.Client.Shared;

#line default
#line hidden
#nullable disable
#nullable restore
#line 11 "C:\ProysCicloIII\semana4_G63\PraticaSemanaIV\Client\_Imports.razor"
using PraticaSemanaIV.Shared.Entity;

#line default
#line hidden
#nullable disable
#nullable restore
#line 12 "C:\ProysCicloIII\semana4_G63\PraticaSemanaIV\Client\_Imports.razor"
using PraticaSemanaIV.Client.Services;

#line default
#line hidden
#nullable disable
    public partial class CustomNotFound : Microsoft.AspNetCore.Components.ComponentBase
    {
        #pragma warning disable 1998
        protected override void BuildRenderTree(Microsoft.AspNetCore.Components.Rendering.RenderTreeBuilder __builder)
        {
            __builder.AddMarkupContent(0, "<div class=\"alert alert-warning\" role=\"alert\">\r\n  Lo sentimos, página no encontrada\r\n</div>");
        }
        #pragma warning restore 1998
#nullable restore
#line 4 "C:\ProysCicloIII\semana4_G63\PraticaSemanaIV\Client\Pages\Components\CustomNotFound.razor"
      
    protected override void OnInitialized(){
        Console.WriteLine("404, Ruta no encontrada");
    }

#line default
#line hidden
#nullable disable
    }
}
#pragma warning restore 1591
