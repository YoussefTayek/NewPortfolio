#pragma checksum "C:\Users\rahma\Desktop\PersonalProjects\NewPortfolio\Web\Views\Home\Index.cshtml" "{ff1816ec-aa5e-4d10-87f7-6f4963833460}" "5c3a0fd4ed2d48a1a7651c820d3e48fd8b5acf36"
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
#line 1 "C:\Users\rahma\Desktop\PersonalProjects\NewPortfolio\Web\Views\_ViewImports.cshtml"
using Web;

#line default
#line hidden
#nullable disable
#nullable restore
#line 3 "C:\Users\rahma\Desktop\PersonalProjects\NewPortfolio\Web\Views\_ViewImports.cshtml"
using Core.Entities;

#line default
#line hidden
#nullable disable
#nullable restore
#line 5 "C:\Users\rahma\Desktop\PersonalProjects\NewPortfolio\Web\Views\_ViewImports.cshtml"
using Microsoft.AspNetCore.Identity;

#line default
#line hidden
#nullable disable
#nullable restore
#line 1 "C:\Users\rahma\Desktop\PersonalProjects\NewPortfolio\Web\Views\Home\Index.cshtml"
using Web.ViewModels;

#line default
#line hidden
#nullable disable
    [global::Microsoft.AspNetCore.Razor.Hosting.RazorSourceChecksumAttribute(@"SHA1", @"5c3a0fd4ed2d48a1a7651c820d3e48fd8b5acf36", @"/Views/Home/Index.cshtml")]
    [global::Microsoft.AspNetCore.Razor.Hosting.RazorSourceChecksumAttribute(@"SHA1", @"5c4e64e98ff6897c4b4c671f06309e65af1b448a", @"/Views/_ViewImports.cshtml")]
    public class Views_Home_Index : global::Microsoft.AspNetCore.Mvc.Razor.RazorPage<dynamic>
    {
        private static readonly global::Microsoft.AspNetCore.Razor.TagHelpers.TagHelperAttribute __tagHelperAttribute_0 = new global::Microsoft.AspNetCore.Razor.TagHelpers.TagHelperAttribute("class", new global::Microsoft.AspNetCore.Html.HtmlString("masthead-avatar mb-5"), global::Microsoft.AspNetCore.Razor.TagHelpers.HtmlAttributeValueStyle.DoubleQuotes);
        private static readonly global::Microsoft.AspNetCore.Razor.TagHelpers.TagHelperAttribute __tagHelperAttribute_1 = new global::Microsoft.AspNetCore.Razor.TagHelpers.TagHelperAttribute("style", new global::Microsoft.AspNetCore.Html.HtmlString("border-radius: 50%;"), global::Microsoft.AspNetCore.Razor.TagHelpers.HtmlAttributeValueStyle.DoubleQuotes);
        private static readonly global::Microsoft.AspNetCore.Razor.TagHelpers.TagHelperAttribute __tagHelperAttribute_2 = new global::Microsoft.AspNetCore.Razor.TagHelpers.TagHelperAttribute("alt", new global::Microsoft.AspNetCore.Html.HtmlString(""), global::Microsoft.AspNetCore.Razor.TagHelpers.HtmlAttributeValueStyle.DoubleQuotes);
        private static readonly global::Microsoft.AspNetCore.Razor.TagHelpers.TagHelperAttribute __tagHelperAttribute_3 = new global::Microsoft.AspNetCore.Razor.TagHelpers.TagHelperAttribute("class", new global::Microsoft.AspNetCore.Html.HtmlString("img-fluid"), global::Microsoft.AspNetCore.Razor.TagHelpers.HtmlAttributeValueStyle.DoubleQuotes);
        private static readonly global::Microsoft.AspNetCore.Razor.TagHelpers.TagHelperAttribute __tagHelperAttribute_4 = new global::Microsoft.AspNetCore.Razor.TagHelpers.TagHelperAttribute("asp-controller", "Contact", global::Microsoft.AspNetCore.Razor.TagHelpers.HtmlAttributeValueStyle.DoubleQuotes);
        private static readonly global::Microsoft.AspNetCore.Razor.TagHelpers.TagHelperAttribute __tagHelperAttribute_5 = new global::Microsoft.AspNetCore.Razor.TagHelpers.TagHelperAttribute("asp-action", "Index", global::Microsoft.AspNetCore.Razor.TagHelpers.HtmlAttributeValueStyle.DoubleQuotes);
        private static readonly global::Microsoft.AspNetCore.Razor.TagHelpers.TagHelperAttribute __tagHelperAttribute_6 = new global::Microsoft.AspNetCore.Razor.TagHelpers.TagHelperAttribute("enctype", new global::Microsoft.AspNetCore.Html.HtmlString("multipart/form-data"), global::Microsoft.AspNetCore.Razor.TagHelpers.HtmlAttributeValueStyle.DoubleQuotes);
        private static readonly global::Microsoft.AspNetCore.Razor.TagHelpers.TagHelperAttribute __tagHelperAttribute_7 = new global::Microsoft.AspNetCore.Razor.TagHelpers.TagHelperAttribute("novalidate", new global::Microsoft.AspNetCore.Html.HtmlString("novalidate"), global::Microsoft.AspNetCore.Razor.TagHelpers.HtmlAttributeValueStyle.DoubleQuotes);
        private static readonly global::Microsoft.AspNetCore.Razor.TagHelpers.TagHelperAttribute __tagHelperAttribute_8 = new global::Microsoft.AspNetCore.Razor.TagHelpers.TagHelperAttribute("class", new global::Microsoft.AspNetCore.Html.HtmlString("img-fluid rounded mb-5"), global::Microsoft.AspNetCore.Razor.TagHelpers.HtmlAttributeValueStyle.DoubleQuotes);
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
        private global::Microsoft.AspNetCore.Mvc.Razor.TagHelpers.UrlResolutionTagHelper __Microsoft_AspNetCore_Mvc_Razor_TagHelpers_UrlResolutionTagHelper;
        private global::Microsoft.AspNetCore.Mvc.TagHelpers.FormTagHelper __Microsoft_AspNetCore_Mvc_TagHelpers_FormTagHelper;
        private global::Microsoft.AspNetCore.Mvc.TagHelpers.RenderAtEndOfFormTagHelper __Microsoft_AspNetCore_Mvc_TagHelpers_RenderAtEndOfFormTagHelper;
        #pragma warning disable 1998
        public async override global::System.Threading.Tasks.Task ExecuteAsync()
        {
#nullable restore
#line 2 "C:\Users\rahma\Desktop\PersonalProjects\NewPortfolio\Web\Views\Home\Index.cshtml"
  
    ViewData["Title"] = "Portfolio";

#line default
#line hidden
#nullable disable
            WriteLiteral("\r\n        <!-- Masthead-->\r\n        <header class=\"masthead bg-primary text-white text-center\">\r\n            <div class=\"container d-flex align-items-center flex-column\">\r\n                <!-- Masthead Avatar Image-->\r\n                ");
            __tagHelperExecutionContext = __tagHelperScopeManager.Begin("img", global::Microsoft.AspNetCore.Razor.TagHelpers.TagMode.SelfClosing, "5c3a0fd4ed2d48a1a7651c820d3e48fd8b5acf367290", async() => {
            }
            );
            __Microsoft_AspNetCore_Mvc_Razor_TagHelpers_UrlResolutionTagHelper = CreateTagHelper<global::Microsoft.AspNetCore.Mvc.Razor.TagHelpers.UrlResolutionTagHelper>();
            __tagHelperExecutionContext.Add(__Microsoft_AspNetCore_Mvc_Razor_TagHelpers_UrlResolutionTagHelper);
            __tagHelperExecutionContext.AddHtmlAttribute(__tagHelperAttribute_0);
            BeginAddHtmlAttributeValues(__tagHelperExecutionContext, "src", 2, global::Microsoft.AspNetCore.Razor.TagHelpers.HtmlAttributeValueStyle.DoubleQuotes);
            AddHtmlAttributeValue("", 342, "~/assets/img/", 342, 13, true);
#nullable restore
#line 10 "C:\Users\rahma\Desktop\PersonalProjects\NewPortfolio\Web\Views\Home\Index.cshtml"
AddHtmlAttributeValue("", 355, Model.Owner.Avatar, 355, 19, false);

#line default
#line hidden
#nullable disable
            EndAddHtmlAttributeValues(__tagHelperExecutionContext);
            __tagHelperExecutionContext.AddHtmlAttribute(__tagHelperAttribute_1);
            __tagHelperExecutionContext.AddHtmlAttribute(__tagHelperAttribute_2);
            await __tagHelperRunner.RunAsync(__tagHelperExecutionContext);
            if (!__tagHelperExecutionContext.Output.IsContentModified)
            {
                await __tagHelperExecutionContext.SetOutputContentAsync();
            }
            Write(__tagHelperExecutionContext.Output);
            __tagHelperExecutionContext = __tagHelperScopeManager.End();
            WriteLiteral("\r\n                <!-- Masthead Heading-->\r\n                <h1 class=\"masthead-heading text-uppercase mb-0\">");
#nullable restore
#line 12 "C:\Users\rahma\Desktop\PersonalProjects\NewPortfolio\Web\Views\Home\Index.cshtml"
                                                            Write(Model.Owner.FullName);

#line default
#line hidden
#nullable disable
            WriteLiteral(@"</h1>
                <!-- Icon Divider-->
                <div class=""divider-custom divider-light"">
                    <div class=""divider-custom-line""></div>
                    <div class=""divider-custom-icon""><i class=""fas fa-star""></i></div>
                    <div class=""divider-custom-line""></div>
                </div>
                <!-- Masthead Subheading-->
                <p class=""masthead-subheading font-weight-light mb-0"">");
#nullable restore
#line 20 "C:\Users\rahma\Desktop\PersonalProjects\NewPortfolio\Web\Views\Home\Index.cshtml"
                                                                 Write(Model.Owner.Profil);

#line default
#line hidden
#nullable disable
            WriteLiteral(@"</p>
            </div>
        </header>
        <!-- Portfolio Section-->
        <section class=""page-section portfolio"" id=""portfolio"">
            <div class=""container"">
                <!-- Portfolio Section Heading-->
                <h2 class=""page-section-heading text-center text-uppercase text-secondary mb-0"">Portfolio</h2>
                <!-- Icon Divider-->
                <div class=""divider-custom"">
                    <div class=""divider-custom-line""></div>
                    <div class=""divider-custom-icon""><i class=""fas fa-star""></i></div>
                    <div class=""divider-custom-line""></div>
                </div>
                <!-- Portfolio Grid Items-->
                <div class=""row justify-content-center"">
                    <!-- Portfolio Item 1-->
");
#nullable restore
#line 37 "C:\Users\rahma\Desktop\PersonalProjects\NewPortfolio\Web\Views\Home\Index.cshtml"
                      
                        foreach(var p in Model.PortfolioItems)
                        {

#line default
#line hidden
#nullable disable
            WriteLiteral("                            <div class=\"col-md-6 col-lg-4 mb-5\">\r\n                                <div class=\"portfolio-item mx-auto\" data-toggle=\"modal\" data-target=\"#item-");
#nullable restore
#line 41 "C:\Users\rahma\Desktop\PersonalProjects\NewPortfolio\Web\Views\Home\Index.cshtml"
                                                                                                      Write(p.Id);

#line default
#line hidden
#nullable disable
            WriteLiteral(@""">
                                    <div class=""portfolio-item-caption d-flex align-items-center justify-content-center h-100 w-100"">
                                        <div class=""portfolio-item-caption-content text-center text-white""><i class=""fas fa-plus fa-3x""></i></div>
                                    </div>
                                    ");
            __tagHelperExecutionContext = __tagHelperScopeManager.Begin("img", global::Microsoft.AspNetCore.Razor.TagHelpers.TagMode.SelfClosing, "5c3a0fd4ed2d48a1a7651c820d3e48fd8b5acf3612183", async() => {
            }
            );
            __Microsoft_AspNetCore_Mvc_Razor_TagHelpers_UrlResolutionTagHelper = CreateTagHelper<global::Microsoft.AspNetCore.Mvc.Razor.TagHelpers.UrlResolutionTagHelper>();
            __tagHelperExecutionContext.Add(__Microsoft_AspNetCore_Mvc_Razor_TagHelpers_UrlResolutionTagHelper);
            __tagHelperExecutionContext.AddHtmlAttribute(__tagHelperAttribute_3);
            BeginAddHtmlAttributeValues(__tagHelperExecutionContext, "src", 2, global::Microsoft.AspNetCore.Razor.TagHelpers.HtmlAttributeValueStyle.DoubleQuotes);
            AddHtmlAttributeValue("", 2517, "~/assets/img/portfolio/", 2517, 23, true);
#nullable restore
#line 45 "C:\Users\rahma\Desktop\PersonalProjects\NewPortfolio\Web\Views\Home\Index.cshtml"
AddHtmlAttributeValue("", 2540, p.ImageUrl, 2540, 11, false);

#line default
#line hidden
#nullable disable
            EndAddHtmlAttributeValues(__tagHelperExecutionContext);
            __tagHelperExecutionContext.AddHtmlAttribute(__tagHelperAttribute_2);
            await __tagHelperRunner.RunAsync(__tagHelperExecutionContext);
            if (!__tagHelperExecutionContext.Output.IsContentModified)
            {
                await __tagHelperExecutionContext.SetOutputContentAsync();
            }
            Write(__tagHelperExecutionContext.Output);
            __tagHelperExecutionContext = __tagHelperScopeManager.End();
            WriteLiteral("\r\n                                </div>\r\n                            </div>\r\n");
#nullable restore
#line 48 "C:\Users\rahma\Desktop\PersonalProjects\NewPortfolio\Web\Views\Home\Index.cshtml"
                        }
                    

#line default
#line hidden
#nullable disable
            WriteLiteral(@"                </div>
            </div>
        </section>
        <!-- About Section-->
        <section class=""page-section bg-primary text-white mb-0"" id=""about"">
            <div class=""container"">
                <!-- About Section Heading-->
                <h2 class=""page-section-heading text-center text-uppercase text-white"">About</h2>
                <!-- Icon Divider-->
                <div class=""divider-custom divider-light"">
                    <div class=""divider-custom-line""></div>
                    <div class=""divider-custom-icon""><i class=""fas fa-star""></i></div>
                    <div class=""divider-custom-line""></div>
                </div>
                <!-- About Section Content-->
                <div class=""row"">
                    <div class=""col-lg-4 ml-auto""><p class=""lead"">Freelancer is a free bootstrap theme created by Start Bootstrap. The download includes the complete source files including HTML, CSS, and JavaScript as well as optional SASS stylesheets fo");
            WriteLiteral(@"r easy customization.</p></div>
                    <div class=""col-lg-4 mr-auto""><p class=""lead"">You can create your own custom avatar for the masthead, change the icon in the dividers, and add your email address to the contact form to make it fully functional!</p></div>
                </div>
                <!-- About Section Button-->
                <div class=""text-center mt-4"">
                    <a class=""btn btn-xl btn-outline-light"" href=""https://startbootstrap.com/theme/freelancer/"">
                        <i class=""fas fa-download mr-2""></i>
                        Free Download!
                    </a>
                </div>
            </div>
        </section>

        <!-- Contact Section-->
         <section class=""page-section"" id=""contact"">
            <div class=""container"">
                    <!-- Contact Section Heading-->
                    <h2 class=""page-section-heading text-center text-uppercase text-secondary mb-0"">Contact Me</h2>
                    <!-- Icon");
            WriteLiteral(@" Divider-->
                    <div class=""divider-custom"">
                        <div class=""divider-custom-line""></div>
                        <div class=""divider-custom-icon""><i class=""fas fa-star""></i></div>
                        <div class=""divider-custom-line""></div>
                    </div>
                    <!-- Contact Section Form-->
                <div class=""row"">
                    <div class=""col-lg-8 mx-auto"">
                        <!-- To configure the contact form email address, go to mail/contact_me.php and update the email address in the PHP file on line 19.-->
                        ");
            __tagHelperExecutionContext = __tagHelperScopeManager.Begin("form", global::Microsoft.AspNetCore.Razor.TagHelpers.TagMode.StartTagAndEndTag, "5c3a0fd4ed2d48a1a7651c820d3e48fd8b5acf3616973", async() => {
                WriteLiteral(@"
                            <div class=""control-group"">
                                <div class=""form-group floating-label-form-group controls mb-0 pb-2"">
                                    <label >Name</label>
                                    <input class=""form-control"" required name=""name"" type=""text"" placeholder=""Name"" data-validation-required-message=""Please enter your name."" />
                                    <p asp-validation-for=""Name"" class=""help-block text-danger filed-validation-valid""></p>
                                </div>
                            </div>
                            <div class=""control-group"">
                                <div class=""form-group floating-label-form-group controls mb-0 pb-2"">
                                    <label>Email Address</label>
                                    <input class=""form-control"" required name=""email"" type=""email"" placeholder=""Email Address""/>
                                    <p asp-validation-for=""Email"" cl");
                WriteLiteral(@"ass=""help-block text-danger""></p>
                                </div>
                            </div>
                            <div class=""control-group"">
                                <div class=""form-group floating-label-form-group controls mb-0 pb-2"">
                                    <label>Phone Number</label>
                                    <input class=""form-control"" required name=""phone"" type=""tel"" placeholder=""Phone Number"" data-validation-required-message=""Please enter your phone number."" />
                                    <p asp-validation-for=""Phone"" class=""help-block text-danger""></p>
                                </div>
                            </div>
                            <div class=""control-group"">
                                <div class=""form-group floating-label-form-group controls mb-0 pb-2"">
                                    <label>Message</label>
                                    <textarea class=""form-control"" required name=""message"" row");
                WriteLiteral(@"s=""5"" placeholder=""Message"" data-validation-required-message=""Please enter a message.""></textarea>
                                    <p asp-validation-for=""Message"" class=""help-block text-danger""></p>
                                </div>
                            </div>
                            <br />
                            <div id=""success""></div>
                            <div class=""form-group""><button class=""btn btn-primary btn-xl"" id=""sendMessageButton"" type=""submit"">Send</button></div>

                        ");
            }
            );
            __Microsoft_AspNetCore_Mvc_TagHelpers_FormTagHelper = CreateTagHelper<global::Microsoft.AspNetCore.Mvc.TagHelpers.FormTagHelper>();
            __tagHelperExecutionContext.Add(__Microsoft_AspNetCore_Mvc_TagHelpers_FormTagHelper);
            __Microsoft_AspNetCore_Mvc_TagHelpers_RenderAtEndOfFormTagHelper = CreateTagHelper<global::Microsoft.AspNetCore.Mvc.TagHelpers.RenderAtEndOfFormTagHelper>();
            __tagHelperExecutionContext.Add(__Microsoft_AspNetCore_Mvc_TagHelpers_RenderAtEndOfFormTagHelper);
            __Microsoft_AspNetCore_Mvc_TagHelpers_FormTagHelper.Controller = (string)__tagHelperAttribute_4.Value;
            __tagHelperExecutionContext.AddTagHelperAttribute(__tagHelperAttribute_4);
            __Microsoft_AspNetCore_Mvc_TagHelpers_FormTagHelper.Action = (string)__tagHelperAttribute_5.Value;
            __tagHelperExecutionContext.AddTagHelperAttribute(__tagHelperAttribute_5);
            __tagHelperExecutionContext.AddHtmlAttribute(__tagHelperAttribute_6);
            __tagHelperExecutionContext.AddHtmlAttribute(__tagHelperAttribute_7);
            await __tagHelperRunner.RunAsync(__tagHelperExecutionContext);
            if (!__tagHelperExecutionContext.Output.IsContentModified)
            {
                await __tagHelperExecutionContext.SetOutputContentAsync();
            }
            Write(__tagHelperExecutionContext.Output);
            __tagHelperExecutionContext = __tagHelperScopeManager.End();
            WriteLiteral("\r\n                    </div>\r\n                </div>\r\n            </div>\r\n        </section>\r\n        <!-- Portfolio Modals-->\r\n        <!-- Portfolio Modal 1-->\r\n");
#nullable restore
#line 134 "C:\Users\rahma\Desktop\PersonalProjects\NewPortfolio\Web\Views\Home\Index.cshtml"
          
            foreach(var item in Model.PortfolioItems )
            {

#line default
#line hidden
#nullable disable
            WriteLiteral("                 <div class=\"portfolio-modal modal fade\"");
            BeginWriteAttribute("id", " id=\"", 8380, "\"", 8398, 2);
            WriteAttributeValue("", 8385, "item-", 8385, 5, true);
#nullable restore
#line 137 "C:\Users\rahma\Desktop\PersonalProjects\NewPortfolio\Web\Views\Home\Index.cshtml"
WriteAttributeValue("", 8390, item.Id, 8390, 8, false);

#line default
#line hidden
#nullable disable
            EndWriteAttribute();
            WriteLiteral(@" tabindex=""-1"" role=""dialog"" aria-labelledby=""portfolioModal1Label"" aria-hidden=""true"">
                    <div class=""modal-dialog modal-xl"" role=""document"">
                        <div class=""modal-content"">
                            <button class=""close"" type=""button"" data-dismiss=""modal"" aria-label=""Close"">
                                <span aria-hidden=""true""><i class=""fas fa-times""></i></span>
                            </button>
                            <div class=""modal-body text-center"">
                                <div class=""container"">
                                    <div class=""row justify-content-center"">
                                        <div class=""col-lg-8"">
                                            <!-- Portfolio Modal - Title-->
                                            <h2 class=""portfolio-modal-title text-secondary text-uppercase mb-0"">");
#nullable restore
#line 148 "C:\Users\rahma\Desktop\PersonalProjects\NewPortfolio\Web\Views\Home\Index.cshtml"
                                                                                                            Write(item.ProjectName);

#line default
#line hidden
#nullable disable
            WriteLiteral(@"</h2>
                                            <!-- Icon Divider-->
                                            <div class=""divider-custom"">
                                                <div class=""divider-custom-line""></div>
                                                <div class=""divider-custom-icon""><i class=""fas fa-star""></i></div>
                                                <div class=""divider-custom-line""></div>
                                            </div>
                                            <!-- Portfolio Modal - Image-->
                                            ");
            __tagHelperExecutionContext = __tagHelperScopeManager.Begin("img", global::Microsoft.AspNetCore.Razor.TagHelpers.TagMode.SelfClosing, "5c3a0fd4ed2d48a1a7651c820d3e48fd8b5acf3624349", async() => {
            }
            );
            __Microsoft_AspNetCore_Mvc_Razor_TagHelpers_UrlResolutionTagHelper = CreateTagHelper<global::Microsoft.AspNetCore.Mvc.Razor.TagHelpers.UrlResolutionTagHelper>();
            __tagHelperExecutionContext.Add(__Microsoft_AspNetCore_Mvc_Razor_TagHelpers_UrlResolutionTagHelper);
            __tagHelperExecutionContext.AddHtmlAttribute(__tagHelperAttribute_8);
            BeginAddHtmlAttributeValues(__tagHelperExecutionContext, "src", 2, global::Microsoft.AspNetCore.Razor.TagHelpers.HtmlAttributeValueStyle.DoubleQuotes);
            AddHtmlAttributeValue("", 9980, "~/assets/img/portfolio/", 9980, 23, true);
#nullable restore
#line 156 "C:\Users\rahma\Desktop\PersonalProjects\NewPortfolio\Web\Views\Home\Index.cshtml"
AddHtmlAttributeValue("", 10003, item.ImageUrl, 10003, 14, false);

#line default
#line hidden
#nullable disable
            EndAddHtmlAttributeValues(__tagHelperExecutionContext);
            __tagHelperExecutionContext.AddHtmlAttribute(__tagHelperAttribute_2);
            await __tagHelperRunner.RunAsync(__tagHelperExecutionContext);
            if (!__tagHelperExecutionContext.Output.IsContentModified)
            {
                await __tagHelperExecutionContext.SetOutputContentAsync();
            }
            Write(__tagHelperExecutionContext.Output);
            __tagHelperExecutionContext = __tagHelperScopeManager.End();
            WriteLiteral("\r\n                                            <!-- Portfolio Modal - Text-->\r\n                                            <p class=\"mb-5\">");
#nullable restore
#line 158 "C:\Users\rahma\Desktop\PersonalProjects\NewPortfolio\Web\Views\Home\Index.cshtml"
                                                       Write(item.Description);

#line default
#line hidden
#nullable disable
            WriteLiteral(@"</p>
                                            <button class=""btn btn-primary"" data-dismiss=""modal"">
                                                <i class=""fas fa-times fa-fw""></i>
                                                Close Window
                                            </button>
                                        </div>
                                    </div>
                                </div>
                            </div>
                        </div>
                    </div>
                </div>
");
#nullable restore
#line 170 "C:\Users\rahma\Desktop\PersonalProjects\NewPortfolio\Web\Views\Home\Index.cshtml"
            }
        

#line default
#line hidden
#nullable disable
            WriteLiteral("       \r\n");
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
        public global::Microsoft.AspNetCore.Mvc.Rendering.IHtmlHelper<dynamic> Html { get; private set; }
    }
}
#pragma warning restore 1591
