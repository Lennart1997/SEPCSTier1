#pragma checksum "C:\Users\abdul\RiderProjects\SEPCSTier1\SEPCSTier1\Pages\NavBar.razor" "{ff1816ec-aa5e-4d10-87f7-6f4963833460}" "0549a28838b9a36257745ec1577f86dae036981f"
// <auto-generated/>
#pragma warning disable 1591
namespace SEPCSTier1.Pages
{
    #line hidden
    using System;
    using System.Collections.Generic;
    using System.Linq;
    using System.Threading.Tasks;
    using Microsoft.AspNetCore.Components;
#nullable restore
#line 1 "C:\Users\abdul\RiderProjects\SEPCSTier1\SEPCSTier1\_Imports.razor"
using System.Net.Http;

#line default
#line hidden
#nullable disable
#nullable restore
#line 2 "C:\Users\abdul\RiderProjects\SEPCSTier1\SEPCSTier1\_Imports.razor"
using Microsoft.AspNetCore.Authorization;

#line default
#line hidden
#nullable disable
#nullable restore
#line 3 "C:\Users\abdul\RiderProjects\SEPCSTier1\SEPCSTier1\_Imports.razor"
using Microsoft.AspNetCore.Components.Authorization;

#line default
#line hidden
#nullable disable
#nullable restore
#line 4 "C:\Users\abdul\RiderProjects\SEPCSTier1\SEPCSTier1\_Imports.razor"
using Microsoft.AspNetCore.Components.Forms;

#line default
#line hidden
#nullable disable
#nullable restore
#line 5 "C:\Users\abdul\RiderProjects\SEPCSTier1\SEPCSTier1\_Imports.razor"
using Microsoft.AspNetCore.Components.Routing;

#line default
#line hidden
#nullable disable
#nullable restore
#line 6 "C:\Users\abdul\RiderProjects\SEPCSTier1\SEPCSTier1\_Imports.razor"
using Microsoft.AspNetCore.Components.Web;

#line default
#line hidden
#nullable disable
#nullable restore
#line 7 "C:\Users\abdul\RiderProjects\SEPCSTier1\SEPCSTier1\_Imports.razor"
using Microsoft.AspNetCore.Components.Web.Virtualization;

#line default
#line hidden
#nullable disable
#nullable restore
#line 8 "C:\Users\abdul\RiderProjects\SEPCSTier1\SEPCSTier1\_Imports.razor"
using Microsoft.JSInterop;

#line default
#line hidden
#nullable disable
#nullable restore
#line 9 "C:\Users\abdul\RiderProjects\SEPCSTier1\SEPCSTier1\_Imports.razor"
using SEPCSTier1;

#line default
#line hidden
#nullable disable
#nullable restore
#line 10 "C:\Users\abdul\RiderProjects\SEPCSTier1\SEPCSTier1\_Imports.razor"
using SEPCSTier1.Shared;

#line default
#line hidden
#nullable disable
#nullable restore
#line 11 "C:\Users\abdul\RiderProjects\SEPCSTier1\SEPCSTier1\_Imports.razor"
using Radzen;

#line default
#line hidden
#nullable disable
#nullable restore
#line 12 "C:\Users\abdul\RiderProjects\SEPCSTier1\SEPCSTier1\_Imports.razor"
using Radzen.Blazor;

#line default
#line hidden
#nullable disable
#nullable restore
#line 13 "C:\Users\abdul\RiderProjects\SEPCSTier1\SEPCSTier1\_Imports.razor"
using Blazored.Toast;

#line default
#line hidden
#nullable disable
#nullable restore
#line 14 "C:\Users\abdul\RiderProjects\SEPCSTier1\SEPCSTier1\_Imports.razor"
using Blazored.Toast.Services;

#line default
#line hidden
#nullable disable
#nullable restore
#line 2 "C:\Users\abdul\RiderProjects\SEPCSTier1\SEPCSTier1\Pages\NavBar.razor"
using SEPCSTier1.Data;

#line default
#line hidden
#nullable disable
#nullable restore
#line 3 "C:\Users\abdul\RiderProjects\SEPCSTier1\SEPCSTier1\Pages\NavBar.razor"
using Microsoft.AspNetCore.Components.Server.ProtectedBrowserStorage;

#line default
#line hidden
#nullable disable
    [Microsoft.AspNetCore.Components.RouteAttribute("/NavBar")]
    public partial class NavBar : Microsoft.AspNetCore.Components.ComponentBase
    {
        #pragma warning disable 1998
        protected override void BuildRenderTree(Microsoft.AspNetCore.Components.Rendering.RenderTreeBuilder __builder)
        {
            __builder.OpenElement(0, "nav");
            __builder.AddAttribute(1, "class", "navbar navbar-expand-lg navbar navbar-dark bg-dark");
            __builder.AddAttribute(2, "b-6j1hao32hh");
            __builder.AddMarkupContent(3, "<a class=\"navbar-brand\" href=\"Shop\" b-6j1hao32hh>CSGO Trading</a>\r\n    ");
            __builder.AddMarkupContent(4, @"<button class=""navbar-toggler"" type=""button"" data-toggle=""collapse"" data-target=""#navbarSupportedContent"" aria-controls=""navbarSupportedContent"" aria-expanded=""false"" aria-label=""Toggle navigation"" b-6j1hao32hh><span class=""navbar-toggler-icon"" b-6j1hao32hh></span></button>

    ");
            __builder.OpenElement(5, "div");
            __builder.AddAttribute(6, "class", "collapse navbar-collapse");
            __builder.AddAttribute(7, "id", "navbarSupportedContent");
            __builder.AddAttribute(8, "b-6j1hao32hh");
            __builder.OpenElement(9, "ul");
            __builder.AddAttribute(10, "class", "navbar-nav mr-auto");
            __builder.AddAttribute(11, "b-6j1hao32hh");
            __builder.AddMarkupContent(12, "<li class=\"nav-item \" b-6j1hao32hh><a class=\"nav-link\" href=\"Shop\" b-6j1hao32hh>Home <span class=\"sr-only\" b-6j1hao32hh>(current)</span></a></li>\r\n            ");
            __builder.AddMarkupContent(13, "<li class=\"nav-item\" b-6j1hao32hh><a class=\"nav-link\" href=\"AddItem\" b-6j1hao32hh>AddItem</a></li>\r\n            ");
            __builder.AddMarkupContent(14, "<li class=\"nav-item\" b-6j1hao32hh><a class=\"nav-link\" href=\"Chat\" b-6j1hao32hh>Chat</a></li>\r\n            ");
            __builder.OpenComponent<Microsoft.AspNetCore.Components.Authorization.AuthorizeView>(15);
            __builder.AddAttribute(16, "NotAuthorized", (Microsoft.AspNetCore.Components.RenderFragment<Microsoft.AspNetCore.Components.Authorization.AuthenticationState>)((context) => (__builder2) => {
                __builder2.AddMarkupContent(17, "<li class=\"nav-item\" b-6j1hao32hh><a class=\"nav-link \" href=\"Login\" b-6j1hao32hh>Login</a></li>");
            }
            ));
            __builder.AddAttribute(18, "Authorized", (Microsoft.AspNetCore.Components.RenderFragment<Microsoft.AspNetCore.Components.Authorization.AuthenticationState>)((context) => (__builder2) => {
                __builder2.AddMarkupContent(19, "<li class=\"nav-item\" b-6j1hao32hh><a class=\"nav-link\" href=\"Admin\" b-6j1hao32hh>Admin</a></li>\r\n                    \r\n                                    ");
                __builder2.AddMarkupContent(20, "<li class=\"nav-item\" b-6j1hao32hh><a class=\"nav-link\" href=\"Wallet\" b-6j1hao32hh>Wallet</a></li>\r\n                    \r\n\r\n                    ");
                __builder2.OpenElement(21, "li");
                __builder2.AddAttribute(22, "class", "nav-item");
                __builder2.AddAttribute(23, "b-6j1hao32hh");
                __builder2.OpenElement(24, "a");
                __builder2.AddAttribute(25, "class", "nav-link ");
                __builder2.AddAttribute(26, "onclick", Microsoft.AspNetCore.Components.EventCallback.Factory.Create<Microsoft.AspNetCore.Components.Web.MouseEventArgs>(this, 
#nullable restore
#line 87 "C:\Users\abdul\RiderProjects\SEPCSTier1\SEPCSTier1\Pages\NavBar.razor"
                                                       PerformLogout

#line default
#line hidden
#nullable disable
                ));
                __builder2.AddAttribute(27, "b-6j1hao32hh");
                __builder2.AddContent(28, " Logout ");
                __builder2.AddContent(29, 
#nullable restore
#line 87 "C:\Users\abdul\RiderProjects\SEPCSTier1\SEPCSTier1\Pages\NavBar.razor"
                                                                               name

#line default
#line hidden
#nullable disable
                );
                __builder2.CloseElement();
                __builder2.CloseElement();
            }
            ));
            __builder.CloseComponent();
            __builder.CloseElement();
            __builder.AddMarkupContent(30, "\r\n        \r\n       \r\n       \r\n        ");
            __builder.OpenElement(31, "div");
            __builder.AddAttribute(32, "onclick", Microsoft.AspNetCore.Components.EventCallback.Factory.Create<Microsoft.AspNetCore.Components.Web.MouseEventArgs>(this, 
#nullable restore
#line 102 "C:\Users\abdul\RiderProjects\SEPCSTier1\SEPCSTier1\Pages\NavBar.razor"
                         () => NavigateToCart()

#line default
#line hidden
#nullable disable
            ));
            __builder.AddAttribute(33, "b-6j1hao32hh");
            __builder.AddMarkupContent(34, "<i class=\"fa\" style=\"color:white;font-size:35px\" b-6j1hao32hh>&#xf07a;</i>\r\n            ");
            __builder.OpenElement(35, "span");
            __builder.AddAttribute(36, "class", "badge badge-warning");
            __builder.AddAttribute(37, "id", "lblCartCount");
            __builder.AddAttribute(38, "b-6j1hao32hh");
            __builder.AddContent(39, 
#nullable restore
#line 105 "C:\Users\abdul\RiderProjects\SEPCSTier1\SEPCSTier1\Pages\NavBar.razor"
                                                                  count

#line default
#line hidden
#nullable disable
            );
            __builder.CloseElement();
            __builder.CloseElement();
            __builder.CloseElement();
            __builder.CloseElement();
        }
        #pragma warning restore 1998
#nullable restore
#line 114 "C:\Users\abdul\RiderProjects\SEPCSTier1\SEPCSTier1\Pages\NavBar.razor"
       

    public string name { get; set; }

    public long id { get; set; }

    public long count { get; set; }

    

    protected async override Task OnInitializedAsync()
    {
        var protectedBrowserStorageResult = await ProtectedSessionStore.GetAsync<string>("username");
        var protectedBrowserStorageResultId = await ProtectedSessionStore.GetAsync<long>("id");
        id = protectedBrowserStorageResultId.Value;
        var cartCountById = await ShoppingCartData.GetCartCountById(id);
        name = protectedBrowserStorageResult.Value;
        count = cartCountById;
    }


    public async Task PerformLogout()
    {
        try
        {
            ((CustomAuthenticationStateProvider) AuthenticationStateProvider).Logout();
            await ProtectedSessionStore.DeleteAsync("id");
            NavigationManager.NavigateTo("/shop", true);
        }
        catch (Exception e)
        {
        }
    }


    public async Task NavigateToCart()
    {
        NavigationManager.NavigateTo("/Cart",true);
        
    }


#line default
#line hidden
#nullable disable
        [global::Microsoft.AspNetCore.Components.InjectAttribute] private IShoppingCartData ShoppingCartData { get; set; }
        [global::Microsoft.AspNetCore.Components.InjectAttribute] private ProtectedSessionStorage ProtectedSessionStore { get; set; }
        [global::Microsoft.AspNetCore.Components.InjectAttribute] private NavigationManager NavigationManager { get; set; }
        [global::Microsoft.AspNetCore.Components.InjectAttribute] private AuthenticationStateProvider AuthenticationStateProvider { get; set; }
    }
}
#pragma warning restore 1591
