#pragma checksum "D:\Programming\Other\ASP.NET\05.07.2019(Partial view,AJAX)\Home\Practice2\Practice2\Practice2\Views\Home\Index.cshtml" "{ff1816ec-aa5e-4d10-87f7-6f4963833460}" "5c4dfca93a2ccd4fe5051001914bf9948387560a"
// <auto-generated/>
#pragma warning disable 1591
[assembly: global::Microsoft.AspNetCore.Razor.Hosting.RazorCompiledItemAttribute(typeof(AspNetCore.Views_Home_Index), @"mvc.1.0.view", @"/Views/Home/Index.cshtml")]
[assembly:global::Microsoft.AspNetCore.Mvc.Razor.Compilation.RazorViewAttribute(@"/Views/Home/Index.cshtml", typeof(AspNetCore.Views_Home_Index))]
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
    [global::Microsoft.AspNetCore.Razor.Hosting.RazorSourceChecksumAttribute(@"SHA1", @"5c4dfca93a2ccd4fe5051001914bf9948387560a", @"/Views/Home/Index.cshtml")]
    [global::Microsoft.AspNetCore.Razor.Hosting.RazorSourceChecksumAttribute(@"SHA1", @"378488019a7de722d602b600c703cba0352af17d", @"/Views/_ViewImports.cshtml")]
    public class Views_Home_Index : global::Microsoft.AspNetCore.Mvc.Razor.RazorPage<IEnumerable<House>>
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
            BeginContext(28, 1178, true);
            WriteLiteral(@"
<section class=""site-hero overlay"" style=""background-image: url(img/hero_1.jpg)"">
    <div class=""container"">
        <div class=""row site-hero-inner align-items-center"">
            <div class=""col-md-7 text-left ml-auto"">
                <h1 class=""heading"" data-aos=""fade-up"">I'm Your Realtor, Get Your Key</h1>
                <p class=""sub-heading mb-5"" data-aos=""fade-up"" data-aos-delay=""100"">Discover our world-class hotel &amp; restaurant resort.</p>
                <p data-aos=""fade-up"" data-aos-delay=""100""><a href=""#"" class=""btn uppercase btn-primary mr-md-2 mr-0 mb-3 d-sm-inline d-block"">Get In Touch</a> <a href=""#"" class=""btn uppercase btn-outline-light d-sm-inline d-block"">Download</a></p>
            </div>
        </div>
        <a href=""#next-section"" class=""smoothscroll scroll-down"">Scroll Down</a>
    </div>
</section>
<!-- END section -->

<section class=""section visit-section"" id=""next-section"">
    <div class=""container"">
        <div class=""row"">
            <div class=""co");
            WriteLiteral("l-md-12\">\r\n                <h2 class=\"heading\" data-aos=\"fade-up\">Popular Properties</h2>\r\n            </div>\r\n        </div>\r\n        <div class=\"row\">\r\n");
            EndContext();
#line 25 "D:\Programming\Other\ASP.NET\05.07.2019(Partial view,AJAX)\Home\Practice2\Practice2\Practice2\Views\Home\Index.cshtml"
             foreach (var h in Model)
            {

#line default
#line hidden
            BeginContext(1260, 101, true);
            WriteLiteral("                <div class=\"col-lg-3 col-md-6 visit mb-3\" data-aos=\"fade-up\">\r\n                    <a");
            EndContext();
            BeginWriteAttribute("href", " href=\"", 1361, "\"", 1393, 2);
            WriteAttributeValue("", 1368, "/properties/details/", 1368, 20, true);
#line 28 "D:\Programming\Other\ASP.NET\05.07.2019(Partial view,AJAX)\Home\Practice2\Practice2\Practice2\Views\Home\Index.cshtml"
WriteAttributeValue("", 1388, h.Id, 1388, 5, false);

#line default
#line hidden
            EndWriteAttribute();
            BeginContext(1394, 1, true);
            WriteLiteral(">");
            EndContext();
            BeginContext(1395, 105, false);
            __tagHelperExecutionContext = __tagHelperScopeManager.Begin("img", global::Microsoft.AspNetCore.Razor.TagHelpers.TagMode.StartTagOnly, "15556d7f6ed440139d4e33a99a0cb842", async() => {
            }
            );
            __Microsoft_AspNetCore_Mvc_Razor_TagHelpers_UrlResolutionTagHelper = CreateTagHelper<global::Microsoft.AspNetCore.Mvc.Razor.TagHelpers.UrlResolutionTagHelper>();
            __tagHelperExecutionContext.Add(__Microsoft_AspNetCore_Mvc_Razor_TagHelpers_UrlResolutionTagHelper);
            BeginAddHtmlAttributeValues(__tagHelperExecutionContext, "src", 2, global::Microsoft.AspNetCore.Razor.TagHelpers.HtmlAttributeValueStyle.DoubleQuotes);
            AddHtmlAttributeValue("", 1405, "~/img/", 1405, 6, true);
#line 28 "D:\Programming\Other\ASP.NET\05.07.2019(Partial view,AJAX)\Home\Practice2\Practice2\Practice2\Views\Home\Index.cshtml"
AddHtmlAttributeValue("", 1411, h.HousePhotos.FirstOrDefault().Image, 1411, 37, false);

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
            BeginContext(1500, 63, true);
            WriteLiteral(" </a>\r\n                    <h3><a href=\"property-single.html\">$");
            EndContext();
            BeginContext(1564, 7, false);
#line 29 "D:\Programming\Other\ASP.NET\05.07.2019(Partial view,AJAX)\Home\Practice2\Practice2\Practice2\Views\Home\Index.cshtml"
                                                   Write(h.Price);

#line default
#line hidden
            EndContext();
            BeginContext(1571, 94, true);
            WriteLiteral("</a></h3>\r\n                    <div class=\"reviews-star float-left\">\r\n                        ");
            EndContext();
            BeginContext(1666, 8, false);
#line 31 "D:\Programming\Other\ASP.NET\05.07.2019(Partial view,AJAX)\Home\Practice2\Practice2\Practice2\Views\Home\Index.cshtml"
                   Write(h.Adress);

#line default
#line hidden
            EndContext();
            BeginContext(1674, 54, true);
            WriteLiteral("\r\n                    </div>\r\n                </div>\r\n");
            EndContext();
#line 34 "D:\Programming\Other\ASP.NET\05.07.2019(Partial view,AJAX)\Home\Practice2\Practice2\Practice2\Views\Home\Index.cshtml"
            }

#line default
#line hidden
            BeginContext(1743, 4, true);
            WriteLiteral("\r\n\r\n");
            EndContext();
            BeginContext(4829, 7003, true);
            WriteLiteral(@"
        </div>
    </div>
</section>
<!-- END section -->

<section class=""section"">
    <div class=""container"">
        <div class=""row mb-5"">
            <div class=""col-12 text-center"">
                <h2>Happy Customers</h2>
            </div>
        </div>
        <div class=""js-carousel-1 owl-carousel"">

            <div class=""testimonial text-center"">
                <div class=""author-image mb-3"">
                    <img src=""img/person_1.jpg"" alt=""Image placeholder"" class=""rounded-circle"">
                </div>
                <blockquote>

                    <p>&ldquo;Et quidem, impedit eum fugiat excepturi iste aliquid suscipit, tempore, delectus rem soluta voluptatem distinctio sed dolores, magni fugit nemo cum expedita. Totam a accusantium sunt aut autem placeat officia.&rdquo;</p>
                </blockquote>
                <p><em>&mdash; Jean Smith</em></p>

            </div>

            <div class=""testimonial text-center"">
                <div class=""aut");
            WriteLiteral(@"hor-image mb-3"">
                    <img src=""img/person_2.jpg"" alt=""Image placeholder"" class=""rounded-circle"">
                </div>
                <blockquote>
                    <p>&ldquo;Lorem ipsum dolor sit amet, consectetur adipisicing elit. In dolor, iusto doloremque quo odio repudiandae sunt eveniet? Enim facilis laborum voluptate id porro, culpa maiores quis, blanditiis laboriosam alias&rdquo;</p>
                </blockquote>
                <p><em>&mdash; John Doe</em></p>
            </div>

            <div class=""testimonial text-center"">
                <div class=""author-image mb-3"">
                    <img src=""img/person_3.jpg"" alt=""Image placeholder"" class=""rounded-circle"">
                </div>
                <blockquote>

                    <p>&ldquo;Nostrum, alias, provident magnam sit blanditiis laboriosam unde quaerat, at ipsam, ratione maiores saepe nisi modi corporis quas! Beatae quam, quod aspernatur debitis nesciunt quasi porro ea iste nobis aliquid perspici");
            WriteLiteral(@"atis nostrum culpa impedit aut, iure blanditiis itaque similique sunt!&rdquo;</p>
                </blockquote>
                <p><em>&mdash; John Doe</em></p>
            </div>

        </div>
    </div>
</section>

<section class=""section"">
    <div class=""container"">
        <div class=""row"">
            <div class=""col-lg-7"">
                <img src=""img/about_1.jpg"" alt=""Image"" class=""img-fluid rounded img-shadow"">
            </div>
            <div class=""col-lg-4 ml-auto"">
                <h3 class=""mb-3"">About Me</h3>
                <p>I'm John Doe a realtor agent, Lorem ipsum dolor sit amet, consectetur adipisicing elit. Saepe omnis beatae libero quisquam ex nostrum repellendus, consectetur suscipit. Velit iusto ducimus sit quos officiis nesciunt libero, officia, aliquam doloremque totam.</p>
                <p>Ratione natus expedita iusto, minus cumque vitae quo culpa reiciendis aspernatur aliquam veritatis magnam non, dicta nemo inventore, nisi quas dolores. Modi laboriosam s");
            WriteLiteral(@"unt aliquid rem, deserunt quis? Porro, hic.</p>
                <p><img src=""img/signature.jpg"" alt=""Image"" class=""img-fluid w-25""></p>

            </div>
        </div>
    </div>
</section>

<section class=""section"">
    <div class=""container"">
        <div class=""row"">
            <div class=""col-md-6 mb-4 mb-lg-0 col-lg-4 text-center"">
                <span class=""ion-android-calendar display-3 text-primary""></span>
                <h3 class=""card-title"">Deal On Time</h3>
                <p>Saepe omnis beatae libero quisquam ex nostrum repellendus, consectetur suscipit. Velit iusto ducimus sit quos officiis nesciunt libero</p>
            </div>
            <div class=""col-md-6 mb-4 mb-lg-0 col-lg-4 text-center"">
                <span class=""ion-android-create display-3 text-primary""></span>
                <h3 class=""card-title"">Good Reviews</h3>
                <p>Saepe omnis beatae libero quisquam ex nostrum repellendus, consectetur suscipit. Velit iusto ducimus sit quos officiis ne");
            WriteLiteral(@"sciunt libero</p>
            </div>
            <div class=""col-md-6 mb-4 mb-lg-0 col-lg-4 text-center"">
                <span class=""ion-android-hangout display-3 text-primary""></span>
                <h3 class=""card-title"">24/7 Support</h3>
                <p>Saepe omnis beatae libero quisquam ex nostrum repellendus, consectetur suscipit. Velit iusto ducimus sit quos officiis nesciunt libero</p>
            </div>
        </div>
    </div>
</section>


<section class=""section bg-light"">
    <div class=""container"">
        <div class=""row justify-content-center text-center mb-5"">
            <div class=""col-md-8"">
                <h2 class=""heading"" data-aos=""fade-up"">Recent Blog Post</h2>
                <p class=""lead"" data-aos=""fade-up"">Lorem ipsum dolor sit amet, consectetur adipisicing elit. In dolor, iusto doloremque quo odio repudiandae sunt eveniet? Enim facilis laborum voluptate id porro, culpa maiores quis, blanditiis laboriosam alias. Sed.</p>
            </div>
        </div>");
            WriteLiteral(@"
        <div class=""row"">
            <div class=""col-lg-4 col-md-6 col-sm-6 col-12 post"" data-aos=""fade-up"" data-aos-delay=""100"">

                <div class=""media media-custom d-block mb-4"">
                    <a href=""blog-single.html"" class=""mb-4 d-block""><img src=""img/img_1.jpg"" alt=""Image placeholder"" class=""img-fluid""></a>
                    <div class=""media-body"">
                        <span class=""meta-post"">February 26, 2018</span>
                        <h2 class=""mt-0 mb-3""><a href=""#"">How to pick right realtor?</a></h2>
                    </div>
                </div>

            </div>
            <div class=""col-lg-4 col-md-6 col-sm-6 col-12 post"" data-aos=""fade-up"" data-aos-delay=""200"">
                <div class=""media media-custom d-block mb-4"">
                    <a href=""blog-single.html"" class=""mb-4 d-block""><img src=""img/img_2.jpg"" alt=""Image placeholder"" class=""img-fluid""></a>
                    <div class=""media-body"">
                        <span class=""me");
            WriteLiteral(@"ta-post"">February 26, 2018</span>
                        <h2 class=""mt-0 mb-3""><a href=""#"">How to pick right realtor?</a></h2>
                    </div>
                </div>
            </div>
            <div class=""col-lg-4 col-md-6 col-sm-6 col-12 post"" data-aos=""fade-up"" data-aos-delay=""300"">
                <div class=""media media-custom d-block mb-4"">
                    <a href=""blog-single.html"" class=""mb-4 d-block""><img src=""img/img_3.jpg"" alt=""Image placeholder"" class=""img-fluid""></a>
                    <div class=""media-body"">
                        <span class=""meta-post"">February 26, 2018</span>
                        <h2 class=""mt-0 mb-3""><a href=""#"">How to pick right realtor?</a></h2>
                    </div>
                </div>
            </div>
        </div>
    </div>
</section>
<!-- END section -->");
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
        public global::Microsoft.AspNetCore.Mvc.Rendering.IHtmlHelper<IEnumerable<House>> Html { get; private set; }
    }
}
#pragma warning restore 1591
