#pragma checksum "C:\Users\nsa\source\repos\PanopticoSA\PanopticoSA\Views\Domicilios\Details.cshtml" "{ff1816ec-aa5e-4d10-87f7-6f4963833460}" "93aab7908e8944d4efc428d146bb5a5df4501265"
// <auto-generated/>
#pragma warning disable 1591
[assembly: global::Microsoft.AspNetCore.Razor.Hosting.RazorCompiledItemAttribute(typeof(AspNetCore.Views_Domicilios_Details), @"mvc.1.0.view", @"/Views/Domicilios/Details.cshtml")]
[assembly:global::Microsoft.AspNetCore.Mvc.Razor.Compilation.RazorViewAttribute(@"/Views/Domicilios/Details.cshtml", typeof(AspNetCore.Views_Domicilios_Details))]
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
#line 1 "C:\Users\nsa\source\repos\PanopticoSA\PanopticoSA\Views\_ViewImports.cshtml"
using PanopticoSA;

#line default
#line hidden
#line 2 "C:\Users\nsa\source\repos\PanopticoSA\PanopticoSA\Views\_ViewImports.cshtml"
using PanopticoSA.Models;

#line default
#line hidden
    [global::Microsoft.AspNetCore.Razor.Hosting.RazorSourceChecksumAttribute(@"SHA1", @"93aab7908e8944d4efc428d146bb5a5df4501265", @"/Views/Domicilios/Details.cshtml")]
    [global::Microsoft.AspNetCore.Razor.Hosting.RazorSourceChecksumAttribute(@"SHA1", @"56cad1c10e36f60b64a8ea1bcaded70187a48e13", @"/Views/_ViewImports.cshtml")]
    public class Views_Domicilios_Details : global::Microsoft.AspNetCore.Mvc.Razor.RazorPage<PanopticoSA.Models.Domicilio>
    {
        private static readonly global::Microsoft.AspNetCore.Razor.TagHelpers.TagHelperAttribute __tagHelperAttribute_0 = new global::Microsoft.AspNetCore.Razor.TagHelpers.TagHelperAttribute("asp-action", "Edit", global::Microsoft.AspNetCore.Razor.TagHelpers.HtmlAttributeValueStyle.DoubleQuotes);
        private static readonly global::Microsoft.AspNetCore.Razor.TagHelpers.TagHelperAttribute __tagHelperAttribute_1 = new global::Microsoft.AspNetCore.Razor.TagHelpers.TagHelperAttribute("class", new global::Microsoft.AspNetCore.Html.HtmlString(" btn btn-warning"), global::Microsoft.AspNetCore.Razor.TagHelpers.HtmlAttributeValueStyle.DoubleQuotes);
        private static readonly global::Microsoft.AspNetCore.Razor.TagHelpers.TagHelperAttribute __tagHelperAttribute_2 = new global::Microsoft.AspNetCore.Razor.TagHelpers.TagHelperAttribute("asp-action", "Index", global::Microsoft.AspNetCore.Razor.TagHelpers.HtmlAttributeValueStyle.DoubleQuotes);
        private static readonly global::Microsoft.AspNetCore.Razor.TagHelpers.TagHelperAttribute __tagHelperAttribute_3 = new global::Microsoft.AspNetCore.Razor.TagHelpers.TagHelperAttribute("class", new global::Microsoft.AspNetCore.Html.HtmlString("btn btn-dark"), global::Microsoft.AspNetCore.Razor.TagHelpers.HtmlAttributeValueStyle.DoubleQuotes);
        #line hidden
        #pragma warning disable 0169
        private string __tagHelperStringValueBuffer;
        #pragma warning restore 0169
        private global::Microsoft.AspNetCore.Razor.Runtime.TagHelpers.TagHelperExecutionContext __tagHelperExecutionContext;
        private global::Microsoft.AspNetCore.Razor.Runtime.TagHelpers.TagHelperRunner __tagHelperRunner = new global::Microsoft.AspNetCore.Razor.Runtime.TagHelpers.TagHelperRunner();
        private global::Microsoft.AspNetCore.Razor.Runtime.TagHelpers.TagHelperScopeManager __backed__tagHelperScopeManager = null;
        private global::Microsoft.AspNetCore.Razor.Runtime.TagHelpers.TagHelperScopeManager __tagHelperScopeManager
        {
            get
            {
                if (__backed__tagHelperScopeManager == null)
                {
                    __backed__tagHelperScopeManager = new global::Microsoft.AspNetCore.Razor.Runtime.TagHelpers.TagHelperScopeManager(StartTagHelperWritingScope, EndTagHelperWritingScope);
                }
                return __backed__tagHelperScopeManager;
            }
        }
        private global::Microsoft.AspNetCore.Mvc.TagHelpers.AnchorTagHelper __Microsoft_AspNetCore_Mvc_TagHelpers_AnchorTagHelper;
        #pragma warning disable 1998
        public async override global::System.Threading.Tasks.Task ExecuteAsync()
        {
            BeginContext(37, 2, true);
            WriteLiteral("\r\n");
            EndContext();
#line 3 "C:\Users\nsa\source\repos\PanopticoSA\PanopticoSA\Views\Domicilios\Details.cshtml"
  
    ViewData["Title"] = "Details";

#line default
#line hidden
            BeginContext(82, 95, true);
            WriteLiteral("\r\n\r\n<div>\r\n   \r\n    <hr />\r\n    <dl class=\"row\">\r\n        <dt class = \"col-sm-2\">\r\n            ");
            EndContext();
            BeginContext(178, 41, false);
#line 13 "C:\Users\nsa\source\repos\PanopticoSA\PanopticoSA\Views\Domicilios\Details.cshtml"
       Write(Html.DisplayNameFor(model => model.Calle));

#line default
#line hidden
            EndContext();
            BeginContext(219, 63, true);
            WriteLiteral("\r\n        </dt>\r\n        <dd class = \"col-sm-10\">\r\n            ");
            EndContext();
            BeginContext(283, 37, false);
#line 16 "C:\Users\nsa\source\repos\PanopticoSA\PanopticoSA\Views\Domicilios\Details.cshtml"
       Write(Html.DisplayFor(model => model.Calle));

#line default
#line hidden
            EndContext();
            BeginContext(320, 62, true);
            WriteLiteral("\r\n        </dd>\r\n        <dt class = \"col-sm-2\">\r\n            ");
            EndContext();
            BeginContext(383, 42, false);
#line 19 "C:\Users\nsa\source\repos\PanopticoSA\PanopticoSA\Views\Domicilios\Details.cshtml"
       Write(Html.DisplayNameFor(model => model.Numero));

#line default
#line hidden
            EndContext();
            BeginContext(425, 63, true);
            WriteLiteral("\r\n        </dt>\r\n        <dd class = \"col-sm-10\">\r\n            ");
            EndContext();
            BeginContext(489, 38, false);
#line 22 "C:\Users\nsa\source\repos\PanopticoSA\PanopticoSA\Views\Domicilios\Details.cshtml"
       Write(Html.DisplayFor(model => model.Numero));

#line default
#line hidden
            EndContext();
            BeginContext(527, 62, true);
            WriteLiteral("\r\n        </dd>\r\n        <dt class = \"col-sm-2\">\r\n            ");
            EndContext();
            BeginContext(590, 48, false);
#line 25 "C:\Users\nsa\source\repos\PanopticoSA\PanopticoSA\Views\Domicilios\Details.cshtml"
       Write(Html.DisplayNameFor(model => model.Departamento));

#line default
#line hidden
            EndContext();
            BeginContext(638, 63, true);
            WriteLiteral("\r\n        </dt>\r\n        <dd class = \"col-sm-10\">\r\n            ");
            EndContext();
            BeginContext(702, 44, false);
#line 28 "C:\Users\nsa\source\repos\PanopticoSA\PanopticoSA\Views\Domicilios\Details.cshtml"
       Write(Html.DisplayFor(model => model.Departamento));

#line default
#line hidden
            EndContext();
            BeginContext(746, 62, true);
            WriteLiteral("\r\n        </dd>\r\n        <dt class = \"col-sm-2\">\r\n            ");
            EndContext();
            BeginContext(809, 40, false);
#line 31 "C:\Users\nsa\source\repos\PanopticoSA\PanopticoSA\Views\Domicilios\Details.cshtml"
       Write(Html.DisplayNameFor(model => model.Piso));

#line default
#line hidden
            EndContext();
            BeginContext(849, 63, true);
            WriteLiteral("\r\n        </dt>\r\n        <dd class = \"col-sm-10\">\r\n            ");
            EndContext();
            BeginContext(913, 36, false);
#line 34 "C:\Users\nsa\source\repos\PanopticoSA\PanopticoSA\Views\Domicilios\Details.cshtml"
       Write(Html.DisplayFor(model => model.Piso));

#line default
#line hidden
            EndContext();
            BeginContext(949, 62, true);
            WriteLiteral("\r\n        </dd>\r\n        <dt class = \"col-sm-2\">\r\n            ");
            EndContext();
            BeginContext(1012, 45, false);
#line 37 "C:\Users\nsa\source\repos\PanopticoSA\PanopticoSA\Views\Domicilios\Details.cshtml"
       Write(Html.DisplayNameFor(model => model.Provincia));

#line default
#line hidden
            EndContext();
            BeginContext(1057, 63, true);
            WriteLiteral("\r\n        </dt>\r\n        <dd class = \"col-sm-10\">\r\n            ");
            EndContext();
            BeginContext(1121, 41, false);
#line 40 "C:\Users\nsa\source\repos\PanopticoSA\PanopticoSA\Views\Domicilios\Details.cshtml"
       Write(Html.DisplayFor(model => model.Provincia));

#line default
#line hidden
            EndContext();
            BeginContext(1162, 62, true);
            WriteLiteral("\r\n        </dd>\r\n        <dt class = \"col-sm-2\">\r\n            ");
            EndContext();
            BeginContext(1225, 42, false);
#line 43 "C:\Users\nsa\source\repos\PanopticoSA\PanopticoSA\Views\Domicilios\Details.cshtml"
       Write(Html.DisplayNameFor(model => model.Ciudad));

#line default
#line hidden
            EndContext();
            BeginContext(1267, 63, true);
            WriteLiteral("\r\n        </dt>\r\n        <dd class = \"col-sm-10\">\r\n            ");
            EndContext();
            BeginContext(1331, 38, false);
#line 46 "C:\Users\nsa\source\repos\PanopticoSA\PanopticoSA\Views\Domicilios\Details.cshtml"
       Write(Html.DisplayFor(model => model.Ciudad));

#line default
#line hidden
            EndContext();
            BeginContext(1369, 62, true);
            WriteLiteral("\r\n        </dd>\r\n        <dt class = \"col-sm-2\">\r\n            ");
            EndContext();
            BeginContext(1432, 38, false);
#line 49 "C:\Users\nsa\source\repos\PanopticoSA\PanopticoSA\Views\Domicilios\Details.cshtml"
       Write(Html.DisplayNameFor(model => model.Cp));

#line default
#line hidden
            EndContext();
            BeginContext(1470, 63, true);
            WriteLiteral("\r\n        </dt>\r\n        <dd class = \"col-sm-10\">\r\n            ");
            EndContext();
            BeginContext(1534, 34, false);
#line 52 "C:\Users\nsa\source\repos\PanopticoSA\PanopticoSA\Views\Domicilios\Details.cshtml"
       Write(Html.DisplayFor(model => model.Cp));

#line default
#line hidden
            EndContext();
            BeginContext(1568, 62, true);
            WriteLiteral("\r\n        </dd>\r\n        <dt class = \"col-sm-2\">\r\n            ");
            EndContext();
            BeginContext(1631, 42, false);
#line 55 "C:\Users\nsa\source\repos\PanopticoSA\PanopticoSA\Views\Domicilios\Details.cshtml"
       Write(Html.DisplayNameFor(model => model.Barrio));

#line default
#line hidden
            EndContext();
            BeginContext(1673, 63, true);
            WriteLiteral("\r\n        </dt>\r\n        <dd class = \"col-sm-10\">\r\n            ");
            EndContext();
            BeginContext(1737, 38, false);
#line 58 "C:\Users\nsa\source\repos\PanopticoSA\PanopticoSA\Views\Domicilios\Details.cshtml"
       Write(Html.DisplayFor(model => model.Barrio));

#line default
#line hidden
            EndContext();
            BeginContext(1775, 62, true);
            WriteLiteral("\r\n        </dd>\r\n        <dt class = \"col-sm-2\">\r\n            ");
            EndContext();
            BeginContext(1838, 55, false);
#line 61 "C:\Users\nsa\source\repos\PanopticoSA\PanopticoSA\Views\Domicilios\Details.cshtml"
       Write(Html.DisplayNameFor(model => model.IdPersonaNavigation));

#line default
#line hidden
            EndContext();
            BeginContext(1893, 63, true);
            WriteLiteral("\r\n        </dt>\r\n        <dd class = \"col-sm-10\">\r\n            ");
            EndContext();
            BeginContext(1957, 61, false);
#line 64 "C:\Users\nsa\source\repos\PanopticoSA\PanopticoSA\Views\Domicilios\Details.cshtml"
       Write(Html.DisplayFor(model => model.IdPersonaNavigation.IdPersona));

#line default
#line hidden
            EndContext();
            BeginContext(2018, 47, true);
            WriteLiteral("\r\n        </dd>\r\n    </dl>\r\n</div>\r\n<div>\r\n    ");
            EndContext();
            BeginContext(2065, 93, false);
            __tagHelperExecutionContext = __tagHelperScopeManager.Begin("a", global::Microsoft.AspNetCore.Razor.TagHelpers.TagMode.StartTagAndEndTag, "93aab7908e8944d4efc428d146bb5a5df450126512570", async() => {
                BeginContext(2145, 9, true);
                WriteLiteral("Modificar");
                EndContext();
            }
            );
            __Microsoft_AspNetCore_Mvc_TagHelpers_AnchorTagHelper = CreateTagHelper<global::Microsoft.AspNetCore.Mvc.TagHelpers.AnchorTagHelper>();
            __tagHelperExecutionContext.Add(__Microsoft_AspNetCore_Mvc_TagHelpers_AnchorTagHelper);
            __Microsoft_AspNetCore_Mvc_TagHelpers_AnchorTagHelper.Action = (string)__tagHelperAttribute_0.Value;
            __tagHelperExecutionContext.AddTagHelperAttribute(__tagHelperAttribute_0);
            if (__Microsoft_AspNetCore_Mvc_TagHelpers_AnchorTagHelper.RouteValues == null)
            {
                throw new InvalidOperationException(InvalidTagHelperIndexerAssignment("asp-route-id", "Microsoft.AspNetCore.Mvc.TagHelpers.AnchorTagHelper", "RouteValues"));
            }
            BeginWriteTagHelperAttribute();
#line 69 "C:\Users\nsa\source\repos\PanopticoSA\PanopticoSA\Views\Domicilios\Details.cshtml"
                           WriteLiteral(Model.IdDomicilio);

#line default
#line hidden
            __tagHelperStringValueBuffer = EndWriteTagHelperAttribute();
            __Microsoft_AspNetCore_Mvc_TagHelpers_AnchorTagHelper.RouteValues["id"] = __tagHelperStringValueBuffer;
            __tagHelperExecutionContext.AddTagHelperAttribute("asp-route-id", __Microsoft_AspNetCore_Mvc_TagHelpers_AnchorTagHelper.RouteValues["id"], global::Microsoft.AspNetCore.Razor.TagHelpers.HtmlAttributeValueStyle.DoubleQuotes);
            __tagHelperExecutionContext.AddHtmlAttribute(__tagHelperAttribute_1);
            await __tagHelperRunner.RunAsync(__tagHelperExecutionContext);
            if (!__tagHelperExecutionContext.Output.IsContentModified)
            {
                await __tagHelperExecutionContext.SetOutputContentAsync();
            }
            Write(__tagHelperExecutionContext.Output);
            __tagHelperExecutionContext = __tagHelperScopeManager.End();
            EndContext();
            BeginContext(2158, 20, true);
            WriteLiteral("\r\n    <hr />\r\n\r\n    ");
            EndContext();
            BeginContext(2178, 59, false);
            __tagHelperExecutionContext = __tagHelperScopeManager.Begin("a", global::Microsoft.AspNetCore.Razor.TagHelpers.TagMode.StartTagAndEndTag, "93aab7908e8944d4efc428d146bb5a5df450126515008", async() => {
                BeginContext(2221, 12, true);
                WriteLiteral(" << Regresar");
                EndContext();
            }
            );
            __Microsoft_AspNetCore_Mvc_TagHelpers_AnchorTagHelper = CreateTagHelper<global::Microsoft.AspNetCore.Mvc.TagHelpers.AnchorTagHelper>();
            __tagHelperExecutionContext.Add(__Microsoft_AspNetCore_Mvc_TagHelpers_AnchorTagHelper);
            __Microsoft_AspNetCore_Mvc_TagHelpers_AnchorTagHelper.Action = (string)__tagHelperAttribute_2.Value;
            __tagHelperExecutionContext.AddTagHelperAttribute(__tagHelperAttribute_2);
            __tagHelperExecutionContext.AddHtmlAttribute(__tagHelperAttribute_3);
            await __tagHelperRunner.RunAsync(__tagHelperExecutionContext);
            if (!__tagHelperExecutionContext.Output.IsContentModified)
            {
                await __tagHelperExecutionContext.SetOutputContentAsync();
            }
            Write(__tagHelperExecutionContext.Output);
            __tagHelperExecutionContext = __tagHelperScopeManager.End();
            EndContext();
            BeginContext(2237, 12, true);
            WriteLiteral("\r\n\r\n</div>\r\n");
            EndContext();
        }
        #pragma warning restore 1998
        [global::Microsoft.AspNetCore.Mvc.Razor.Internal.RazorInjectAttribute]
        public global::Microsoft.AspNetCore.Mvc.ViewFeatures.IModelExpressionProvider ModelExpressionProvider { get; private set; }
        [global::Microsoft.AspNetCore.Mvc.Razor.Internal.RazorInjectAttribute]
        public global::Microsoft.AspNetCore.Mvc.IUrlHelper Url { get; private set; }
        [global::Microsoft.AspNetCore.Mvc.Razor.Internal.RazorInjectAttribute]
        public global::Microsoft.AspNetCore.Mvc.IViewComponentHelper Component { get; private set; }
        [global::Microsoft.AspNetCore.Mvc.Razor.Internal.RazorInjectAttribute]
        public global::Microsoft.AspNetCore.Mvc.Rendering.IJsonHelper Json { get; private set; }
        [global::Microsoft.AspNetCore.Mvc.Razor.Internal.RazorInjectAttribute]
        public global::Microsoft.AspNetCore.Mvc.Rendering.IHtmlHelper<PanopticoSA.Models.Domicilio> Html { get; private set; }
    }
}
#pragma warning restore 1591
