#pragma checksum "D:\Asp.net\EduHome\EduHome\Views\Teacher\Detail.cshtml" "{ff1816ec-aa5e-4d10-87f7-6f4963833460}" "19f347c2aa72ffb01101c32c5402446753dad513"
// <auto-generated/>
#pragma warning disable 1591
[assembly: global::Microsoft.AspNetCore.Razor.Hosting.RazorCompiledItemAttribute(typeof(AspNetCore.Views_Teacher_Detail), @"mvc.1.0.view", @"/Views/Teacher/Detail.cshtml")]
[assembly:global::Microsoft.AspNetCore.Mvc.Razor.Compilation.RazorViewAttribute(@"/Views/Teacher/Detail.cshtml", typeof(AspNetCore.Views_Teacher_Detail))]
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
#line 1 "D:\Asp.net\EduHome\EduHome\Views\_ViewImports.cshtml"
using EduHome.Models;

#line default
#line hidden
    [global::Microsoft.AspNetCore.Razor.Hosting.RazorSourceChecksumAttribute(@"SHA1", @"19f347c2aa72ffb01101c32c5402446753dad513", @"/Views/Teacher/Detail.cshtml")]
    [global::Microsoft.AspNetCore.Razor.Hosting.RazorSourceChecksumAttribute(@"SHA1", @"4d69e30d1f82adf0a2faf974bd35b9874ef21587", @"/Views/_ViewImports.cshtml")]
    public class Views_Teacher_Detail : global::Microsoft.AspNetCore.Mvc.Razor.RazorPage<dynamic>
    {
        private static readonly global::Microsoft.AspNetCore.Razor.TagHelpers.TagHelperAttribute __tagHelperAttribute_0 = new global::Microsoft.AspNetCore.Razor.TagHelpers.TagHelperAttribute("style", new global::Microsoft.AspNetCore.Html.HtmlString("width:700px!important"), global::Microsoft.AspNetCore.Razor.TagHelpers.HtmlAttributeValueStyle.DoubleQuotes);
        private static readonly global::Microsoft.AspNetCore.Razor.TagHelpers.TagHelperAttribute __tagHelperAttribute_1 = new global::Microsoft.AspNetCore.Razor.TagHelpers.TagHelperAttribute("alt", new global::Microsoft.AspNetCore.Html.HtmlString("teacher"), global::Microsoft.AspNetCore.Razor.TagHelpers.HtmlAttributeValueStyle.DoubleQuotes);
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
            BeginContext(0, 2, true);
            WriteLiteral("\r\n");
            EndContext();
#line 2 "D:\Asp.net\EduHome\EduHome\Views\Teacher\Detail.cshtml"
  
    ViewData["Title"] = "Detail";

#line default
#line hidden
            BeginContext(44, 801, true);
            WriteLiteral(@"<!-- Banner Area Start -->
<div class=""banner-area-wrapper"">
    <div class=""banner-area text-center"">
        <div class=""container"">
            <div class=""row"">
                <div class=""col-xs-12"">
                    <div class=""banner-content-wrapper"">
                        <div class=""banner-content"">
                            <h2>teachers / details</h2>
                        </div>
                    </div>
                </div>
            </div>
        </div>
    </div>
</div>
<!-- Banner Area End -->
<!-- Teacher Start -->
<div class=""teacher-details-area pt-150 pb-60"">
    <div class=""container"">
        <div class=""row"">
            <div class=""col-md-5 col-sm-5 col-xs-12"">
                <div class=""teacher-details-img"">
                    ");
            EndContext();
            BeginContext(845, 82, false);
            __tagHelperExecutionContext = __tagHelperScopeManager.Begin("img", global::Microsoft.AspNetCore.Razor.TagHelpers.TagMode.StartTagOnly, "15bb2dc09e0246ff9c7514a52ba896e3", async() => {
            }
            );
            __Microsoft_AspNetCore_Mvc_Razor_TagHelpers_UrlResolutionTagHelper = CreateTagHelper<global::Microsoft.AspNetCore.Mvc.Razor.TagHelpers.UrlResolutionTagHelper>();
            __tagHelperExecutionContext.Add(__Microsoft_AspNetCore_Mvc_Razor_TagHelpers_UrlResolutionTagHelper);
            __tagHelperExecutionContext.AddHtmlAttribute(__tagHelperAttribute_0);
            BeginAddHtmlAttributeValues(__tagHelperExecutionContext, "src", 2, global::Microsoft.AspNetCore.Razor.TagHelpers.HtmlAttributeValueStyle.DoubleQuotes);
            AddHtmlAttributeValue("", 885, "~/img/teacher/", 885, 14, true);
#line 28 "D:\Asp.net\EduHome\EduHome\Views\Teacher\Detail.cshtml"
AddHtmlAttributeValue("", 899, Model.Image, 899, 12, false);

#line default
#line hidden
            EndAddHtmlAttributeValues(__tagHelperExecutionContext);
            __tagHelperExecutionContext.AddHtmlAttribute(__tagHelperAttribute_1);
            await __tagHelperRunner.RunAsync(__tagHelperExecutionContext);
            if (!__tagHelperExecutionContext.Output.IsContentModified)
            {
                await __tagHelperExecutionContext.SetOutputContentAsync();
            }
            Write(__tagHelperExecutionContext.Output);
            __tagHelperExecutionContext = __tagHelperScopeManager.End();
            EndContext();
            BeginContext(927, 186, true);
            WriteLiteral("\r\n                </div>\r\n            </div>\r\n            <div class=\"col-md-7 col-sm-7 col-xs-12\">\r\n                <div class=\"teacher-details-content ml-50\">\r\n                    <h2>");
            EndContext();
            BeginContext(1114, 14, false);
#line 33 "D:\Asp.net\EduHome\EduHome\Views\Teacher\Detail.cshtml"
                   Write(Model.Fullname);

#line default
#line hidden
            EndContext();
            BeginContext(1128, 31, true);
            WriteLiteral("</h2>\r\n                    <h5>");
            EndContext();
            BeginContext(1160, 16, false);
#line 34 "D:\Asp.net\EduHome\EduHome\Views\Teacher\Detail.cshtml"
                   Write(Model.Profession);

#line default
#line hidden
            EndContext();
            BeginContext(1176, 69, true);
            WriteLiteral("</h5>\r\n                    <h4>about me</h4>\r\n                    <p>");
            EndContext();
            BeginContext(1246, 11, false);
#line 36 "D:\Asp.net\EduHome\EduHome\Views\Teacher\Detail.cshtml"
                  Write(Model.About);

#line default
#line hidden
            EndContext();
            BeginContext(1257, 81, true);
            WriteLiteral("</p>\r\n                    <ul>\r\n                        <li><span>degree: </span>");
            EndContext();
            BeginContext(1339, 12, false);
#line 38 "D:\Asp.net\EduHome\EduHome\Views\Teacher\Detail.cshtml"
                                            Write(Model.Degree);

#line default
#line hidden
            EndContext();
            BeginContext(1351, 60, true);
            WriteLiteral("</li>\r\n                        <li><span>experience: </span>");
            EndContext();
            BeginContext(1412, 16, false);
#line 39 "D:\Asp.net\EduHome\EduHome\Views\Teacher\Detail.cshtml"
                                                Write(Model.Experience);

#line default
#line hidden
            EndContext();
            BeginContext(1428, 57, true);
            WriteLiteral("</li>\r\n                        <li><span>hobbies: </span>");
            EndContext();
            BeginContext(1486, 13, false);
#line 40 "D:\Asp.net\EduHome\EduHome\Views\Teacher\Detail.cshtml"
                                             Write(Model.Hobbies);

#line default
#line hidden
            EndContext();
            BeginContext(1499, 57, true);
            WriteLiteral("</li>\r\n                        <li><span>faculty: </span>");
            EndContext();
            BeginContext(1557, 13, false);
#line 41 "D:\Asp.net\EduHome\EduHome\Views\Teacher\Detail.cshtml"
                                             Write(Model.Faculty);

#line default
#line hidden
            EndContext();
            BeginContext(1570, 309, true);
            WriteLiteral(@"</li>
                    </ul>
                </div>
            </div>
        </div>
        <div class=""row"">
            <div class=""col-md-3 col-sm-4"">
                <div class=""teacher-contact"">
                    <h4>contact information</h4>
                    <p><span>mail me : </span>");
            EndContext();
            BeginContext(1880, 11, false);
#line 50 "D:\Asp.net\EduHome\EduHome\Views\Teacher\Detail.cshtml"
                                         Write(Model.Email);

#line default
#line hidden
            EndContext();
            BeginContext(1891, 56, true);
            WriteLiteral("</p>\r\n                    <p><span>make a call : </span>");
            EndContext();
            BeginContext(1948, 17, false);
#line 51 "D:\Asp.net\EduHome\EduHome\Views\Teacher\Detail.cshtml"
                                             Write(Model.PhoneNumber);

#line default
#line hidden
            EndContext();
            BeginContext(1965, 50, true);
            WriteLiteral("</p>\r\n                    <p><span>skype : </span>");
            EndContext();
            BeginContext(2016, 11, false);
#line 52 "D:\Asp.net\EduHome\EduHome\Views\Teacher\Detail.cshtml"
                                       Write(Model.Skype);

#line default
#line hidden
            EndContext();
            BeginContext(2027, 1330, true);
            WriteLiteral(@"</p>
                    <ul>
                        <li><a href=""https://www.facebook.com/devitems/?ref=bookmarks""><i class=""zmdi zmdi-facebook""></i></a></li>
                        <li><a href=""https://www.pinterest.com/devitemsllc/""><i class=""zmdi zmdi-pinterest""></i></a></li>
                        <li><a href=""#""><i class=""zmdi zmdi-vimeo""></i></a></li>
                        <li><a href=""https://twitter.com/devitemsllc""><i class=""zmdi zmdi-twitter""></i></a></li>
                    </ul>
                </div>
            </div>
            <div class=""col-md-9 col-sm-8"">
                <div class=""skill-area"">
                    <h4>skills</h4>
                </div>
                <div class=""skill-wrapper"">
                    <div class=""row"">
                        <div class=""col-sm-4"">
                            <div class=""skill-bar-item"">
                                <span>language</span>
                                <div class=""progress"">
                     ");
            WriteLiteral(@"               <div data-wow-delay=""1.2s"" data-wow-duration=""1.5s"" style=""width:85%""; visibility: visible; animation-duration: 1.5s; animation-delay: 1.2s; animation-name: fadeInLeft;"" data-progress=""50%"" class=""progress-bar wow fadeInLeft"">
                                        <span class=""text-top"">");
            EndContext();
            BeginContext(3358, 20, false);
#line 72 "D:\Asp.net\EduHome\EduHome\Views\Teacher\Detail.cshtml"
                                                          Write(Model.Skill.Language);

#line default
#line hidden
            EndContext();
            BeginContext(3378, 710, true);
            WriteLiteral(@"%</span>
                                    </div>
                                </div>
                            </div>
                        </div>
                        <div class=""col-sm-4"">
                            <div class=""skill-bar-item"">
                                <span>team leader</span>
                                <div class=""progress"">
                                    <div data-wow-delay=""1.2s"" data-wow-duration=""1.5s"" style=""width: 85%""; visibility: visible; animation-duration: 1.5s; animation-delay: 1.2s; animation-name: fadeInLeft;"" data-progress=""50%"" class=""progress-bar wow fadeInLeft"">
                                        <span class=""text-top"">");
            EndContext();
            BeginContext(4089, 22, false);
#line 82 "D:\Asp.net\EduHome\EduHome\Views\Teacher\Detail.cshtml"
                                                          Write(Model.Skill.TeamLeader);

#line default
#line hidden
            EndContext();
            BeginContext(4111, 710, true);
            WriteLiteral(@" %</span>
                                    </div>
                                </div>
                            </div>
                        </div>
                        <div class=""col-sm-4"">
                            <div class=""skill-bar-item"">
                                <span>development</span>
                                <div class=""progress"">
                                    <div data-wow-delay=""1.2s"" data-wow-duration=""1.5s"" style=""width:85%""; visibility: visible; animation-duration: 1.5s; animation-delay: 1.2s; animation-name: fadeInLeft;"" data-progress=""50%"" class=""progress-bar wow fadeInLeft"">
                                        <span class=""text-top"">");
            EndContext();
            BeginContext(4822, 23, false);
#line 92 "D:\Asp.net\EduHome\EduHome\Views\Teacher\Detail.cshtml"
                                                          Write(Model.Skill.Development);

#line default
#line hidden
            EndContext();
            BeginContext(4845, 704, true);
            WriteLiteral(@"%</span>
                                    </div>
                                </div>
                            </div>
                        </div>
                        <div class=""col-sm-4"">
                            <div class=""skill-bar-item"">
                                <span>design</span>
                                <div class=""progress"">
                                    <div data-wow-delay=""1.2s"" data-wow-duration=""1.5s"" style=""width:85%""; visibility: visible; animation-duration: 1.5s; animation-delay: 1.2s; animation-name: fadeInLeft;"" data-progress=""50%"" class=""progress-bar wow fadeInLeft"">
                                        <span class=""text-top"">");
            EndContext();
            BeginContext(5550, 18, false);
#line 102 "D:\Asp.net\EduHome\EduHome\Views\Teacher\Detail.cshtml"
                                                          Write(Model.Skill.Design);

#line default
#line hidden
            EndContext();
            BeginContext(5568, 708, true);
            WriteLiteral(@"%</span>
                                    </div>
                                </div>
                            </div>
                        </div>
                        <div class=""col-sm-4"">
                            <div class=""skill-bar-item"">
                                <span>innovation</span>
                                <div class=""progress"">
                                    <div data-wow-delay=""1.2s"" data-wow-duration=""1.5s"" style=""width:85%""; visibility: visible; animation-duration: 1.5s; animation-delay: 1.2s; animation-name: fadeInLeft;"" data-progress=""50%"" class=""progress-bar wow fadeInLeft"">
                                        <span class=""text-top"">");
            EndContext();
            BeginContext(6277, 22, false);
#line 112 "D:\Asp.net\EduHome\EduHome\Views\Teacher\Detail.cshtml"
                                                          Write(Model.Skill.Innovation);

#line default
#line hidden
            EndContext();
            BeginContext(6299, 711, true);
            WriteLiteral(@"%</span>
                                    </div>
                                </div>
                            </div>
                        </div>
                        <div class=""col-sm-4"">
                            <div class=""skill-bar-item"">
                                <span>communication</span>
                                <div class=""progress"">
                                    <div data-wow-delay=""1.2s"" data-wow-duration=""1.5s"" style=""width:85%""; visibility: visible; animation-duration: 1.5s; animation-delay: 1.2s; animation-name: fadeInLeft;"" data-progress=""50%"" class=""progress-bar wow fadeInLeft"">
                                        <span class=""text-top"">");
            EndContext();
            BeginContext(7011, 25, false);
#line 122 "D:\Asp.net\EduHome\EduHome\Views\Teacher\Detail.cshtml"
                                                          Write(Model.Skill.Communication);

#line default
#line hidden
            EndContext();
            BeginContext(7036, 290, true);
            WriteLiteral(@"%</span>
                                    </div>
                                </div>
                            </div>
                        </div>
                    </div>
                </div>
            </div>
        </div>
    </div>
</div>
<!-- Teacher End -->");
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
        public global::Microsoft.AspNetCore.Mvc.Rendering.IHtmlHelper<dynamic> Html { get; private set; }
    }
}
#pragma warning restore 1591