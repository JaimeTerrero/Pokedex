#pragma checksum "C:\Users\Jaime Terrero\Documents\GitHub\Pokedex\Pokedex\Views\Home\Index.cshtml" "{ff1816ec-aa5e-4d10-87f7-6f4963833460}" "e90f4ddd81c397d6faf073760ce4bcfbf634b966"
// <auto-generated/>
#pragma warning disable 1591
[assembly: global::Microsoft.AspNetCore.Razor.Hosting.RazorCompiledItemAttribute(typeof(AspNetCore.Views_Home_Index), @"mvc.1.0.view", @"/Views/Home/Index.cshtml")]
namespace AspNetCore
{
    #line hidden
    using System;
    using System.Collections.Generic;
    using System.Linq;
    using System.Threading.Tasks;
    using Microsoft.AspNetCore.Mvc;
    using Microsoft.AspNetCore.Mvc.Rendering;
    using Microsoft.AspNetCore.Mvc.ViewFeatures;
#nullable restore
#line 1 "C:\Users\Jaime Terrero\Documents\GitHub\Pokedex\Pokedex\Views\_ViewImports.cshtml"
using Pokedex;

#line default
#line hidden
#nullable disable
#nullable restore
#line 2 "C:\Users\Jaime Terrero\Documents\GitHub\Pokedex\Pokedex\Views\_ViewImports.cshtml"
using Pokedex.Models;

#line default
#line hidden
#nullable disable
    [global::Microsoft.AspNetCore.Razor.Hosting.RazorSourceChecksumAttribute(@"SHA1", @"e90f4ddd81c397d6faf073760ce4bcfbf634b966", @"/Views/Home/Index.cshtml")]
    [global::Microsoft.AspNetCore.Razor.Hosting.RazorSourceChecksumAttribute(@"SHA1", @"a5da491ecae30895087782c13bde70b295c8ac28", @"/Views/_ViewImports.cshtml")]
    #nullable restore
    public class Views_Home_Index : global::Microsoft.AspNetCore.Mvc.Razor.RazorPage<List<Application.ViewModels.PokemonViewModel>>
    #nullable disable
    {
        #pragma warning disable 1998
        public async override global::System.Threading.Tasks.Task ExecuteAsync()
        {
#nullable restore
#line 2 "C:\Users\Jaime Terrero\Documents\GitHub\Pokedex\Pokedex\Views\Home\Index.cshtml"
  
    ViewData["Title"] = "Home";

#line default
#line hidden
#nullable disable
            WriteLiteral("\r\n<div class=\"container-fluid\">\r\n    <div class=\"row\">\r\n\r\n");
#nullable restore
#line 9 "C:\Users\Jaime Terrero\Documents\GitHub\Pokedex\Pokedex\Views\Home\Index.cshtml"
         if(Model == null || Model.Count == 0){

#line default
#line hidden
#nullable disable
            WriteLiteral("            <h2>No hay Pokémones aún</h2>\r\n");
#nullable restore
#line 11 "C:\Users\Jaime Terrero\Documents\GitHub\Pokedex\Pokedex\Views\Home\Index.cshtml"
        }
        else
        {
            

#line default
#line hidden
#nullable disable
#nullable restore
#line 14 "C:\Users\Jaime Terrero\Documents\GitHub\Pokedex\Pokedex\Views\Home\Index.cshtml"
             foreach (Application.ViewModels.PokemonViewModel item in Model)
            {

#line default
#line hidden
#nullable disable
            WriteLiteral("                <div class=\"col-4\">\r\n                  <div class=\"card shadow-sm\">\r\n\r\n                    <img class=\"bd-placeholder-img card-img-top\"");
            BeginWriteAttribute("src", " src=\"", 524, "\"", 544, 1);
#nullable restore
#line 19 "C:\Users\Jaime Terrero\Documents\GitHub\Pokedex\Pokedex\Views\Home\Index.cshtml"
WriteAttributeValue("", 530, item.ImageUrl, 530, 14, false);

#line default
#line hidden
#nullable disable
            EndWriteAttribute();
            WriteLiteral(" />\r\n\r\n                    <div class=\"card-body\">\r\n                        <h4>");
#nullable restore
#line 22 "C:\Users\Jaime Terrero\Documents\GitHub\Pokedex\Pokedex\Views\Home\Index.cshtml"
                       Write(item.Name);

#line default
#line hidden
#nullable disable
            WriteLiteral("</h4>\r\n                        <div>\r\n                            <small class=\"fw-bold fs-6\">Región: ");
#nullable restore
#line 24 "C:\Users\Jaime Terrero\Documents\GitHub\Pokedex\Pokedex\Views\Home\Index.cshtml"
                                                           Write(item.RegionName);

#line default
#line hidden
#nullable disable
            WriteLiteral("</small>\r\n                        </div>\r\n                      <div>\r\n                        <small class=\"fw-bold fs-6 d-block\">Tipo Primario: ");
#nullable restore
#line 27 "C:\Users\Jaime Terrero\Documents\GitHub\Pokedex\Pokedex\Views\Home\Index.cshtml"
                                                                      Write(item.TipoPrimario);

#line default
#line hidden
#nullable disable
            WriteLiteral("</small>\r\n                        <small class=\"fw-bold fs-6\">Tipo Secundario: ");
#nullable restore
#line 28 "C:\Users\Jaime Terrero\Documents\GitHub\Pokedex\Pokedex\Views\Home\Index.cshtml"
                                                                Write(item.TipoSecundario);

#line default
#line hidden
#nullable disable
            WriteLiteral("</small>\r\n                      </div>\r\n                    </div>\r\n                  </div>\r\n                </div>\r\n");
#nullable restore
#line 33 "C:\Users\Jaime Terrero\Documents\GitHub\Pokedex\Pokedex\Views\Home\Index.cshtml"
            }

#line default
#line hidden
#nullable disable
#nullable restore
#line 33 "C:\Users\Jaime Terrero\Documents\GitHub\Pokedex\Pokedex\Views\Home\Index.cshtml"
             
        }

#line default
#line hidden
#nullable disable
            WriteLiteral("                        \r\n     </div>\r\n</div>");
        }
        #pragma warning restore 1998
        #nullable restore
        [global::Microsoft.AspNetCore.Mvc.Razor.Internal.RazorInjectAttribute]
        public global::Microsoft.AspNetCore.Mvc.ViewFeatures.IModelExpressionProvider ModelExpressionProvider { get; private set; } = default!;
        #nullable disable
        #nullable restore
        [global::Microsoft.AspNetCore.Mvc.Razor.Internal.RazorInjectAttribute]
        public global::Microsoft.AspNetCore.Mvc.IUrlHelper Url { get; private set; } = default!;
        #nullable disable
        #nullable restore
        [global::Microsoft.AspNetCore.Mvc.Razor.Internal.RazorInjectAttribute]
        public global::Microsoft.AspNetCore.Mvc.IViewComponentHelper Component { get; private set; } = default!;
        #nullable disable
        #nullable restore
        [global::Microsoft.AspNetCore.Mvc.Razor.Internal.RazorInjectAttribute]
        public global::Microsoft.AspNetCore.Mvc.Rendering.IJsonHelper Json { get; private set; } = default!;
        #nullable disable
        #nullable restore
        [global::Microsoft.AspNetCore.Mvc.Razor.Internal.RazorInjectAttribute]
        public global::Microsoft.AspNetCore.Mvc.Rendering.IHtmlHelper<List<Application.ViewModels.PokemonViewModel>> Html { get; private set; } = default!;
        #nullable disable
    }
}
#pragma warning restore 1591
