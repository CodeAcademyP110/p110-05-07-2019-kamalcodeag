#pragma checksum "D:\Programming\Other\ASP.NET\05.07.2019(Partial view,AJAX)\Home\Practice2\Practice2\Practice2\Views\Shared\_LoadMorePartial.cshtml" "{ff1816ec-aa5e-4d10-87f7-6f4963833460}" "c59d24a1289a67da9c6361732e62882ae8873516"
// <auto-generated/>
#pragma warning disable 1591
[assembly: global::Microsoft.AspNetCore.Razor.Hosting.RazorCompiledItemAttribute(typeof(AspNetCore.Views_Shared__LoadMorePartial), @"mvc.1.0.view", @"/Views/Shared/_LoadMorePartial.cshtml")]
[assembly:global::Microsoft.AspNetCore.Mvc.Razor.Compilation.RazorViewAttribute(@"/Views/Shared/_LoadMorePartial.cshtml", typeof(AspNetCore.Views_Shared__LoadMorePartial))]
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
#line 3 "D:\Programming\Other\ASP.NET\05.07.2019(Partial view,AJAX)\Home\Practice2\Practice2\Practice2\Views\_ViewImports.cshtml"
using Practice2.Models;

#line default
#line hidden
    [global::Microsoft.AspNetCore.Razor.Hosting.RazorSourceChecksumAttribute(@"SHA1", @"c59d24a1289a67da9c6361732e62882ae8873516", @"/Views/Shared/_LoadMorePartial.cshtml")]
    [global::Microsoft.AspNetCore.Razor.Hosting.RazorSourceChecksumAttribute(@"SHA1", @"3c02457f1feae416e1c35759d1a658a051307ffb", @"/Views/_ViewImports.cshtml")]
    public class Views_Shared__LoadMorePartial : global::Microsoft.AspNetCore.Mvc.Razor.RazorPage<IEnumerable<House>>
    {
        private static readonly global::Microsoft.AspNetCore.Razor.TagHelpers.TagHelperAttribute __tagHelperAttribute_0 = new global::Microsoft.AspNetCore.Razor.TagHelpers.TagHelperAttribute("alt", new global::Microsoft.AspNetCore.Html.HtmlString("Image placeholder"), global::Microsoft.AspNetCore.Razor.TagHelpers.HtmlAttributeValueStyle.DoubleQuotes);
        private static readonly global::Microsoft.AspNetCore.Razor.TagHelpers.TagHelperAttribute __tagHelperAttribute_1 = new global::Microsoft.AspNetCore.Razor.TagHelpers.TagHelperAttribute("class", new global::Microsoft.AspNetCore.Html.HtmlString("img-fluid rounded"), global::Microsoft.AspNetCore.Razor.TagHelpers.HtmlAttributeValueStyle.DoubleQuotes);
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
        private global::Microsoft.AspNetCore.Mvc.Razor.TagHelpers.UrlResolutionTagHelper __Microsoft_AspNetCore_Mvc_Razor_TagHelpers_UrlResolutionTagHelper;
        #pragma warning disable 1998
        public async override global::System.Threading.Tasks.Task ExecuteAsync()
        {
            BeginContext(28, 2, true);
            WriteLiteral("\r\n");
            EndContext();
#line 3 "D:\Programming\Other\ASP.NET\05.07.2019(Partial view,AJAX)\Home\Practice2\Practice2\Practice2\Views\Shared\_LoadMorePartial.cshtml"
 foreach (var h in Model)
{

#line default
#line hidden
            BeginContext(60, 77, true);
            WriteLiteral("    <div class=\"col-lg-3 col-md-6 visit mb-3\" data-aos=\"fade-up\">\r\n        <a");
            EndContext();
            BeginWriteAttribute("href", " href=\"", 137, "\"", 169, 2);
            WriteAttributeValue("", 144, "/properties/details/", 144, 20, true);
#line 6 "D:\Programming\Other\ASP.NET\05.07.2019(Partial view,AJAX)\Home\Practice2\Practice2\Practice2\Views\Shared\_LoadMorePartial.cshtml"
WriteAttributeValue("", 164, h.Id, 164, 5, false);

#line default
#line hidden
            EndWriteAttribute();
            BeginContext(170, 1, true);
            WriteLiteral(">");
            EndContext();
            BeginContext(171, 105, false);
            __tagHelperExecutionContext = __tagHelperScopeManager.Begin("img", global::Microsoft.AspNetCore.Razor.TagHelpers.TagMode.StartTagOnly, "5db21a4294ce4df98de138495d1b0af3", async() => {
            }
            );
            __Microsoft_AspNetCore_Mvc_Razor_TagHelpers_UrlResolutionTagHelper = CreateTagHelper<global::Microsoft.AspNetCore.Mvc.Razor.TagHelpers.UrlResolutionTagHelper>();
            __tagHelperExecutionContext.Add(__Microsoft_AspNetCore_Mvc_Razor_TagHelpers_UrlResolutionTagHelper);
            BeginAddHtmlAttributeValues(__tagHelperExecutionContext, "src", 2, global::Microsoft.AspNetCore.Razor.TagHelpers.HtmlAttributeValueStyle.DoubleQuotes);
            AddHtmlAttributeValue("", 181, "~/img/", 181, 6, true);
#line 6 "D:\Programming\Other\ASP.NET\05.07.2019(Partial view,AJAX)\Home\Practice2\Practice2\Practice2\Views\Shared\_LoadMorePartial.cshtml"
AddHtmlAttributeValue("", 187, h.HousePhotos.FirstOrDefault().Image, 187, 37, false);

#line default
#line hidden
            EndAddHtmlAttributeValues(__tagHelperExecutionContext);
            __tagHelperExecutionContext.AddHtmlAttribute(__tagHelperAttribute_0);
            __tagHelperExecutionContext.AddHtmlAttribute(__tagHelperAttribute_1);
            await __tagHelperRunner.RunAsync(__tagHelperExecutionContext);
            if (!__tagHelperExecutionContext.Output.IsContentModified)
            {
                await __tagHelperExecutionContext.SetOutputContentAsync();
            }
            Write(__tagHelperExecutionContext.Output);
            __tagHelperExecutionContext = __tagHelperScopeManager.End();
            EndContext();
            BeginContext(276, 51, true);
            WriteLiteral(" </a>\r\n        <h3><a href=\"property-single.html\">$");
            EndContext();
            BeginContext(328, 7, false);
#line 7 "D:\Programming\Other\ASP.NET\05.07.2019(Partial view,AJAX)\Home\Practice2\Practice2\Practice2\Views\Shared\_LoadMorePartial.cshtml"
                                       Write(h.Price);

#line default
#line hidden
            EndContext();
            BeginContext(335, 70, true);
            WriteLiteral("</a></h3>\r\n        <div class=\"reviews-star float-left\">\r\n            ");
            EndContext();
            BeginContext(406, 8, false);
#line 9 "D:\Programming\Other\ASP.NET\05.07.2019(Partial view,AJAX)\Home\Practice2\Practice2\Practice2\Views\Shared\_LoadMorePartial.cshtml"
       Write(h.Adress);

#line default
#line hidden
            EndContext();
            BeginContext(414, 30, true);
            WriteLiteral("\r\n        </div>\r\n    </div>\r\n");
            EndContext();
#line 12 "D:\Programming\Other\ASP.NET\05.07.2019(Partial view,AJAX)\Home\Practice2\Practice2\Practice2\Views\Shared\_LoadMorePartial.cshtml"
}

#line default
#line hidden
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
        public global::Microsoft.AspNetCore.Mvc.Rendering.IHtmlHelper<IEnumerable<House>> Html { get; private set; }
    }
}
#pragma warning restore 1591