#pragma checksum "C:\Users\karou\source\repos\Gestion Produits MVC\Gestion Produits MVC\Views\Produit\Index.cshtml" "{ff1816ec-aa5e-4d10-87f7-6f4963833460}" "1b459036db854759af103d37c318947bef9965bf"
// <auto-generated/>
#pragma warning disable 1591
[assembly: global::Microsoft.AspNetCore.Razor.Hosting.RazorCompiledItemAttribute(typeof(AspNetCore.Views_Produit_Index), @"mvc.1.0.view", @"/Views/Produit/Index.cshtml")]
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
#line 1 "C:\Users\karou\source\repos\Gestion Produits MVC\Gestion Produits MVC\Views\_ViewImports.cshtml"
using Gestion_Produits_MVC;

#line default
#line hidden
#nullable disable
#nullable restore
#line 2 "C:\Users\karou\source\repos\Gestion Produits MVC\Gestion Produits MVC\Views\_ViewImports.cshtml"
using Gestion_Produits_MVC.Models;

#line default
#line hidden
#nullable disable
    [global::Microsoft.AspNetCore.Razor.Hosting.RazorSourceChecksumAttribute(@"SHA1", @"1b459036db854759af103d37c318947bef9965bf", @"/Views/Produit/Index.cshtml")]
    [global::Microsoft.AspNetCore.Razor.Hosting.RazorSourceChecksumAttribute(@"SHA1", @"b4c061307282eba7537a8c0e0259a231f132d632", @"/Views/_ViewImports.cshtml")]
    public class Views_Produit_Index : global::Microsoft.AspNetCore.Mvc.Razor.RazorPage<IEnumerable<Gestion_Produits_MVC.Models.Produit>>
    {
        private static readonly global::Microsoft.AspNetCore.Razor.TagHelpers.TagHelperAttribute __tagHelperAttribute_0 = new global::Microsoft.AspNetCore.Razor.TagHelpers.TagHelperAttribute("body", "Panel body", global::Microsoft.AspNetCore.Razor.TagHelpers.HtmlAttributeValueStyle.DoubleQuotes);
        private static readonly global::Microsoft.AspNetCore.Razor.TagHelpers.TagHelperAttribute __tagHelperAttribute_1 = new global::Microsoft.AspNetCore.Razor.TagHelpers.TagHelperAttribute("header", "panel header", global::Microsoft.AspNetCore.Razor.TagHelpers.HtmlAttributeValueStyle.DoubleQuotes);
        private static readonly global::Microsoft.AspNetCore.Razor.TagHelpers.TagHelperAttribute __tagHelperAttribute_2 = new global::Microsoft.AspNetCore.Razor.TagHelpers.TagHelperAttribute("footer", "panel footer", global::Microsoft.AspNetCore.Razor.TagHelpers.HtmlAttributeValueStyle.DoubleQuotes);
        private static readonly global::Microsoft.AspNetCore.Razor.TagHelpers.TagHelperAttribute __tagHelperAttribute_3 = new global::Microsoft.AspNetCore.Razor.TagHelpers.TagHelperAttribute("asp-action", "Create", global::Microsoft.AspNetCore.Razor.TagHelpers.HtmlAttributeValueStyle.DoubleQuotes);
        #line hidden
        #pragma warning disable 0649
        private global::Microsoft.AspNetCore.Razor.Runtime.TagHelpers.TagHelperExecutionContext __tagHelperExecutionContext;
        #pragma warning restore 0649
        private global::Microsoft.AspNetCore.Razor.Runtime.TagHelpers.TagHelperRunner __tagHelperRunner = new global::Microsoft.AspNetCore.Razor.Runtime.TagHelpers.TagHelperRunner();
        #pragma warning disable 0169
        private string __tagHelperStringValueBuffer;
        #pragma warning restore 0169
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
        private global::Gestion_Produits_MVC.TagHelpers.PanelTagHelper __Gestion_Produits_MVC_TagHelpers_PanelTagHelper;
        private global::Microsoft.AspNetCore.Mvc.TagHelpers.AnchorTagHelper __Microsoft_AspNetCore_Mvc_TagHelpers_AnchorTagHelper;
        #pragma warning disable 1998
        public async override global::System.Threading.Tasks.Task ExecuteAsync()
        {
            WriteLiteral("\r\n");
#nullable restore
#line 3 "C:\Users\karou\source\repos\Gestion Produits MVC\Gestion Produits MVC\Views\Produit\Index.cshtml"
  
    ViewData["Title"] = "Index";

#line default
#line hidden
#nullable disable
            WriteLiteral(@"
<link rel=""stylesheet"" href=""https://maxcdn.bootstrapcdn.com/bootstrap/3.4.1/css/bootstrap.min.css"">
<script src=""https://ajax.googleapis.com/ajax/libs/jquery/3.5.1/jquery.min.js""></script>
<script src=""https://maxcdn.bootstrapcdn.com/bootstrap/3.4.1/js/bootstrap.min.js""></script>

<div class=""panel panel-default"">
    <div class=""panel-heading"">Panel Heading</div>
    <div class=""panel-body"">Panel Body</div>
    <div class=""panel-footer"">Panel Footer</div>
</div>

<!-- objectif: simplifier l'écriture du panel en utilisant la méthode d'écriture suivante:
    <div panel-type=""Success""
    body=""Panel Body""
    header=""Panel Header""
    footer=""Panel Footer"">
    </div>
    aussi le choix du type de panel sera à partir d'un Enum
    
    -->
");
            __tagHelperExecutionContext = __tagHelperScopeManager.Begin("div", global::Microsoft.AspNetCore.Razor.TagHelpers.TagMode.StartTagAndEndTag, "1b459036db854759af103d37c318947bef9965bf5555", async() => {
            }
            );
            __Gestion_Produits_MVC_TagHelpers_PanelTagHelper = CreateTagHelper<global::Gestion_Produits_MVC.TagHelpers.PanelTagHelper>();
            __tagHelperExecutionContext.Add(__Gestion_Produits_MVC_TagHelpers_PanelTagHelper);
#nullable restore
#line 26 "C:\Users\karou\source\repos\Gestion Produits MVC\Gestion Produits MVC\Views\Produit\Index.cshtml"
__Gestion_Produits_MVC_TagHelpers_PanelTagHelper.PanelType = global::Gestion_Produits_MVC.TagHelpers.PanelTagHelper.PanelTypesEnum.Danger;

#line default
#line hidden
#nullable disable
            __tagHelperExecutionContext.AddTagHelperAttribute("panel-type", __Gestion_Produits_MVC_TagHelpers_PanelTagHelper.PanelType, global::Microsoft.AspNetCore.Razor.TagHelpers.HtmlAttributeValueStyle.DoubleQuotes);
            __Gestion_Produits_MVC_TagHelpers_PanelTagHelper.Body = (string)__tagHelperAttribute_0.Value;
            __tagHelperExecutionContext.AddTagHelperAttribute(__tagHelperAttribute_0);
            __Gestion_Produits_MVC_TagHelpers_PanelTagHelper.Header = (string)__tagHelperAttribute_1.Value;
            __tagHelperExecutionContext.AddTagHelperAttribute(__tagHelperAttribute_1);
            __Gestion_Produits_MVC_TagHelpers_PanelTagHelper.Footer = (string)__tagHelperAttribute_2.Value;
            __tagHelperExecutionContext.AddTagHelperAttribute(__tagHelperAttribute_2);
            await __tagHelperRunner.RunAsync(__tagHelperExecutionContext);
            if (!__tagHelperExecutionContext.Output.IsContentModified)
            {
                await __tagHelperExecutionContext.SetOutputContentAsync();
            }
            Write(__tagHelperExecutionContext.Output);
            __tagHelperExecutionContext = __tagHelperScopeManager.End();
            WriteLiteral("\r\n\r\n<p>\r\n    ");
            __tagHelperExecutionContext = __tagHelperScopeManager.Begin("a", global::Microsoft.AspNetCore.Razor.TagHelpers.TagMode.StartTagAndEndTag, "1b459036db854759af103d37c318947bef9965bf7598", async() => {
                WriteLiteral("Create New");
            }
            );
            __Microsoft_AspNetCore_Mvc_TagHelpers_AnchorTagHelper = CreateTagHelper<global::Microsoft.AspNetCore.Mvc.TagHelpers.AnchorTagHelper>();
            __tagHelperExecutionContext.Add(__Microsoft_AspNetCore_Mvc_TagHelpers_AnchorTagHelper);
            __Microsoft_AspNetCore_Mvc_TagHelpers_AnchorTagHelper.Action = (string)__tagHelperAttribute_3.Value;
            __tagHelperExecutionContext.AddTagHelperAttribute(__tagHelperAttribute_3);
            await __tagHelperRunner.RunAsync(__tagHelperExecutionContext);
            if (!__tagHelperExecutionContext.Output.IsContentModified)
            {
                await __tagHelperExecutionContext.SetOutputContentAsync();
            }
            Write(__tagHelperExecutionContext.Output);
            __tagHelperExecutionContext = __tagHelperScopeManager.End();
            WriteLiteral("\r\n</p>\r\n<table class=\"table\">\r\n    <thead>\r\n        <tr>\r\n            <th>\r\n                ");
#nullable restore
#line 38 "C:\Users\karou\source\repos\Gestion Produits MVC\Gestion Produits MVC\Views\Produit\Index.cshtml"
           Write(Html.DisplayNameFor(model => model.id));

#line default
#line hidden
#nullable disable
            WriteLiteral("\r\n            </th>\r\n            <th>\r\n                ");
#nullable restore
#line 41 "C:\Users\karou\source\repos\Gestion Produits MVC\Gestion Produits MVC\Views\Produit\Index.cshtml"
           Write(Html.DisplayNameFor(model => model.reference));

#line default
#line hidden
#nullable disable
            WriteLiteral("\r\n            </th>\r\n            <th>\r\n                ");
#nullable restore
#line 44 "C:\Users\karou\source\repos\Gestion Produits MVC\Gestion Produits MVC\Views\Produit\Index.cshtml"
           Write(Html.DisplayNameFor(model => model.designation));

#line default
#line hidden
#nullable disable
            WriteLiteral("\r\n            </th>\r\n            <th>\r\n                ");
#nullable restore
#line 47 "C:\Users\karou\source\repos\Gestion Produits MVC\Gestion Produits MVC\Views\Produit\Index.cshtml"
           Write(Html.DisplayNameFor(model => model.description));

#line default
#line hidden
#nullable disable
            WriteLiteral("\r\n            </th>\r\n            <th>\r\n                ");
#nullable restore
#line 50 "C:\Users\karou\source\repos\Gestion Produits MVC\Gestion Produits MVC\Views\Produit\Index.cshtml"
           Write(Html.DisplayNameFor(model => model.disponible));

#line default
#line hidden
#nullable disable
            WriteLiteral("\r\n            </th>\r\n            <th></th>\r\n        </tr>\r\n    </thead>\r\n    <tbody>\r\n");
#nullable restore
#line 56 "C:\Users\karou\source\repos\Gestion Produits MVC\Gestion Produits MVC\Views\Produit\Index.cshtml"
         foreach (var item in Model)
        {

#line default
#line hidden
#nullable disable
            WriteLiteral("            <tr>\r\n                <td>\r\n                    ");
#nullable restore
#line 60 "C:\Users\karou\source\repos\Gestion Produits MVC\Gestion Produits MVC\Views\Produit\Index.cshtml"
               Write(Html.DisplayFor(modelItem => item.id));

#line default
#line hidden
#nullable disable
            WriteLiteral("\r\n                </td>\r\n                <td>\r\n                    ");
#nullable restore
#line 63 "C:\Users\karou\source\repos\Gestion Produits MVC\Gestion Produits MVC\Views\Produit\Index.cshtml"
               Write(Html.DisplayFor(modelItem => item.reference));

#line default
#line hidden
#nullable disable
            WriteLiteral("\r\n                </td>\r\n                <td>\r\n                    ");
#nullable restore
#line 66 "C:\Users\karou\source\repos\Gestion Produits MVC\Gestion Produits MVC\Views\Produit\Index.cshtml"
               Write(Html.DisplayFor(modelItem => item.designation));

#line default
#line hidden
#nullable disable
            WriteLiteral("\r\n                </td>\r\n                <td>\r\n                    ");
#nullable restore
#line 69 "C:\Users\karou\source\repos\Gestion Produits MVC\Gestion Produits MVC\Views\Produit\Index.cshtml"
               Write(Html.DisplayFor(modelItem => item.description));

#line default
#line hidden
#nullable disable
            WriteLiteral("\r\n                </td>\r\n                <td>\r\n                    ");
#nullable restore
#line 72 "C:\Users\karou\source\repos\Gestion Produits MVC\Gestion Produits MVC\Views\Produit\Index.cshtml"
               Write(Html.DisplayFor(modelItem => item.disponible));

#line default
#line hidden
#nullable disable
            WriteLiteral("\r\n                </td>\r\n                <td>\r\n                    ");
#nullable restore
#line 75 "C:\Users\karou\source\repos\Gestion Produits MVC\Gestion Produits MVC\Views\Produit\Index.cshtml"
               Write(Html.ActionLink("Edit", "Edit", new { id = item.id }));

#line default
#line hidden
#nullable disable
            WriteLiteral(" |\r\n                    ");
#nullable restore
#line 76 "C:\Users\karou\source\repos\Gestion Produits MVC\Gestion Produits MVC\Views\Produit\Index.cshtml"
               Write(Html.ActionLink("Details", "Details", new { id = item.id }));

#line default
#line hidden
#nullable disable
            WriteLiteral(" |\r\n                    ");
#nullable restore
#line 77 "C:\Users\karou\source\repos\Gestion Produits MVC\Gestion Produits MVC\Views\Produit\Index.cshtml"
               Write(Html.ActionLink("Delete", "Delete", new { id = item.id }));

#line default
#line hidden
#nullable disable
            WriteLiteral("\r\n                </td>\r\n            </tr>\r\n");
#nullable restore
#line 80 "C:\Users\karou\source\repos\Gestion Produits MVC\Gestion Produits MVC\Views\Produit\Index.cshtml"
        }

#line default
#line hidden
#nullable disable
            WriteLiteral("    </tbody>\r\n</table>\r\n");
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
        public global::Microsoft.AspNetCore.Mvc.Rendering.IHtmlHelper<IEnumerable<Gestion_Produits_MVC.Models.Produit>> Html { get; private set; }
    }
}
#pragma warning restore 1591
