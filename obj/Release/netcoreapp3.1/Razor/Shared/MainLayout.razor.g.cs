#pragma checksum "D:\Programming\Tamin-Telerik\Shared\MainLayout.razor" "{ff1816ec-aa5e-4d10-87f7-6f4963833460}" "c64ac33d4560caa64c248cb9517770b60d7bbf75"
// <auto-generated/>
#pragma warning disable 1591
namespace Tamin.Shared
{
    #line hidden
    using System;
    using System.Collections.Generic;
    using System.Linq;
    using System.Threading.Tasks;
    using Microsoft.AspNetCore.Components;
#nullable restore
#line 1 "D:\Programming\Tamin-Telerik\_Imports.razor"
using System.Net.Http;

#line default
#line hidden
#nullable disable
#nullable restore
#line 2 "D:\Programming\Tamin-Telerik\_Imports.razor"
using Microsoft.AspNetCore.Authorization;

#line default
#line hidden
#nullable disable
#nullable restore
#line 3 "D:\Programming\Tamin-Telerik\_Imports.razor"
using Microsoft.AspNetCore.Components.Authorization;

#line default
#line hidden
#nullable disable
#nullable restore
#line 4 "D:\Programming\Tamin-Telerik\_Imports.razor"
using Microsoft.AspNetCore.Components.Forms;

#line default
#line hidden
#nullable disable
#nullable restore
#line 5 "D:\Programming\Tamin-Telerik\_Imports.razor"
using Microsoft.AspNetCore.Components.Routing;

#line default
#line hidden
#nullable disable
#nullable restore
#line 6 "D:\Programming\Tamin-Telerik\_Imports.razor"
using Microsoft.AspNetCore.Components.Web;

#line default
#line hidden
#nullable disable
#nullable restore
#line 7 "D:\Programming\Tamin-Telerik\_Imports.razor"
using Microsoft.AspNetCore.Identity;

#line default
#line hidden
#nullable disable
#nullable restore
#line 8 "D:\Programming\Tamin-Telerik\_Imports.razor"
using Microsoft.JSInterop;

#line default
#line hidden
#nullable disable
#nullable restore
#line 9 "D:\Programming\Tamin-Telerik\_Imports.razor"
using Tamin;

#line default
#line hidden
#nullable disable
#nullable restore
#line 10 "D:\Programming\Tamin-Telerik\_Imports.razor"
using Tamin.Shared;

#line default
#line hidden
#nullable disable
#nullable restore
#line 11 "D:\Programming\Tamin-Telerik\_Imports.razor"
using System.IO;

#line default
#line hidden
#nullable disable
#nullable restore
#line 12 "D:\Programming\Tamin-Telerik\_Imports.razor"
using Tamin.Data;

#line default
#line hidden
#nullable disable
#nullable restore
#line 13 "D:\Programming\Tamin-Telerik\_Imports.razor"
using Services;

#line default
#line hidden
#nullable disable
#nullable restore
#line 14 "D:\Programming\Tamin-Telerik\_Imports.razor"
using Entities;

#line default
#line hidden
#nullable disable
#nullable restore
#line 15 "D:\Programming\Tamin-Telerik\_Imports.razor"
using System.Linq.Dynamic;

#line default
#line hidden
#nullable disable
#nullable restore
#line 16 "D:\Programming\Tamin-Telerik\_Imports.razor"
using Telerik.Blazor;

#line default
#line hidden
#nullable disable
#nullable restore
#line 17 "D:\Programming\Tamin-Telerik\_Imports.razor"
using Telerik.Blazor.Components;

#line default
#line hidden
#nullable disable
#nullable restore
#line 18 "D:\Programming\Tamin-Telerik\_Imports.razor"
using Telerik.Documents;

#line default
#line hidden
#nullable disable
    public partial class MainLayout : LayoutComponentBase
    {
        #pragma warning disable 1998
        protected override void BuildRenderTree(global::Microsoft.AspNetCore.Components.Rendering.RenderTreeBuilder __builder)
        {
            __builder.OpenComponent<global::Telerik.Blazor.Components.TelerikRootComponent>(0);
            __builder.AddAttribute(1, "ChildContent", (global::Microsoft.AspNetCore.Components.RenderFragment)((__builder2) => {
                __builder2.AddMarkupContent(2, "\r\n    \r\n    ");
                __builder2.OpenElement(3, "div");
                __builder2.AddAttribute(4, "class", "main");
                __builder2.AddAttribute(5, "lang", "fa");
                __builder2.AddAttribute(6, "style", "width:100%");
                __builder2.AddMarkupContent(7, "\r\n\r\n        ");
#nullable restore
#line 8 "D:\Programming\Tamin-Telerik\Shared\MainLayout.razor"
__builder2.AddContent(8, Body);

#line default
#line hidden
#nullable disable
                __builder2.AddMarkupContent(9, "\r\n\r\n    ");
                __builder2.CloseElement();
                __builder2.AddMarkupContent(10, "\r\n\r\n");
            }
            ));
            __builder.CloseComponent();
        }
        #pragma warning restore 1998
    }
}
#pragma warning restore 1591