#pragma checksum "D:\Asp.net\EduHome\EduHome\Views\Course\Detail.cshtml" "{ff1816ec-aa5e-4d10-87f7-6f4963833460}" "485d5d798d09e69ab7da09dea82ae8b2a9a7939a"
// <auto-generated/>
#pragma warning disable 1591
[assembly: global::Microsoft.AspNetCore.Razor.Hosting.RazorCompiledItemAttribute(typeof(AspNetCore.Views_Course_Detail), @"mvc.1.0.view", @"/Views/Course/Detail.cshtml")]
[assembly:global::Microsoft.AspNetCore.Mvc.Razor.Compilation.RazorViewAttribute(@"/Views/Course/Detail.cshtml", typeof(AspNetCore.Views_Course_Detail))]
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
    [global::Microsoft.AspNetCore.Razor.Hosting.RazorSourceChecksumAttribute(@"SHA1", @"485d5d798d09e69ab7da09dea82ae8b2a9a7939a", @"/Views/Course/Detail.cshtml")]
    [global::Microsoft.AspNetCore.Razor.Hosting.RazorSourceChecksumAttribute(@"SHA1", @"4d69e30d1f82adf0a2faf974bd35b9874ef21587", @"/Views/_ViewImports.cshtml")]
    public class Views_Course_Detail : global::Microsoft.AspNetCore.Mvc.Razor.RazorPage<Course>
    {
        private static readonly global::Microsoft.AspNetCore.Razor.TagHelpers.TagHelperAttribute __tagHelperAttribute_0 = new global::Microsoft.AspNetCore.Razor.TagHelpers.TagHelperAttribute("style", new global::Microsoft.AspNetCore.Html.HtmlString("width:700px!important"), global::Microsoft.AspNetCore.Razor.TagHelpers.HtmlAttributeValueStyle.DoubleQuotes);
        private static readonly global::Microsoft.AspNetCore.Razor.TagHelpers.TagHelperAttribute __tagHelperAttribute_1 = new global::Microsoft.AspNetCore.Razor.TagHelpers.TagHelperAttribute("alt", new global::Microsoft.AspNetCore.Html.HtmlString("courses-details"), global::Microsoft.AspNetCore.Razor.TagHelpers.HtmlAttributeValueStyle.DoubleQuotes);
        private static readonly global::Microsoft.AspNetCore.Razor.TagHelpers.TagHelperAttribute __tagHelperAttribute_2 = new global::Microsoft.AspNetCore.Razor.TagHelpers.TagHelperAttribute("id", new global::Microsoft.AspNetCore.Html.HtmlString("contact-form"), global::Microsoft.AspNetCore.Razor.TagHelpers.HtmlAttributeValueStyle.DoubleQuotes);
        private static readonly global::Microsoft.AspNetCore.Razor.TagHelpers.TagHelperAttribute __tagHelperAttribute_3 = new global::Microsoft.AspNetCore.Razor.TagHelpers.TagHelperAttribute("action", new global::Microsoft.AspNetCore.Html.HtmlString("http://demo.devitems.com/eduhome/mail.php"), global::Microsoft.AspNetCore.Razor.TagHelpers.HtmlAttributeValueStyle.DoubleQuotes);
        private static readonly global::Microsoft.AspNetCore.Razor.TagHelpers.TagHelperAttribute __tagHelperAttribute_4 = new global::Microsoft.AspNetCore.Razor.TagHelpers.TagHelperAttribute("method", "post", global::Microsoft.AspNetCore.Razor.TagHelpers.HtmlAttributeValueStyle.DoubleQuotes);
        private static readonly global::Microsoft.AspNetCore.Razor.TagHelpers.TagHelperAttribute __tagHelperAttribute_5 = new global::Microsoft.AspNetCore.Razor.TagHelpers.TagHelperAttribute("id", new global::Microsoft.AspNetCore.Html.HtmlString("search"), global::Microsoft.AspNetCore.Razor.TagHelpers.HtmlAttributeValueStyle.DoubleQuotes);
        private static readonly global::Microsoft.AspNetCore.Razor.TagHelpers.TagHelperAttribute __tagHelperAttribute_6 = new global::Microsoft.AspNetCore.Razor.TagHelpers.TagHelperAttribute("action", new global::Microsoft.AspNetCore.Html.HtmlString("#"), global::Microsoft.AspNetCore.Razor.TagHelpers.HtmlAttributeValueStyle.DoubleQuotes);
        private static readonly global::Microsoft.AspNetCore.Razor.TagHelpers.TagHelperAttribute __tagHelperAttribute_7 = new global::Microsoft.AspNetCore.Razor.TagHelpers.TagHelperAttribute("action", new global::Microsoft.AspNetCore.Html.HtmlString("http://devitems.us11.list-manage.com/subscribe/post?u=6bbb9b6f5827bd842d9640c82&amp;id=05d85f18ef"), global::Microsoft.AspNetCore.Razor.TagHelpers.HtmlAttributeValueStyle.DoubleQuotes);
        private static readonly global::Microsoft.AspNetCore.Razor.TagHelpers.TagHelperAttribute __tagHelperAttribute_8 = new global::Microsoft.AspNetCore.Razor.TagHelpers.TagHelperAttribute("id", new global::Microsoft.AspNetCore.Html.HtmlString("mc-embedded-subscribe-form"), global::Microsoft.AspNetCore.Razor.TagHelpers.HtmlAttributeValueStyle.DoubleQuotes);
        private static readonly global::Microsoft.AspNetCore.Razor.TagHelpers.TagHelperAttribute __tagHelperAttribute_9 = new global::Microsoft.AspNetCore.Razor.TagHelpers.TagHelperAttribute("name", new global::Microsoft.AspNetCore.Html.HtmlString("mc-embedded-subscribe-form"), global::Microsoft.AspNetCore.Razor.TagHelpers.HtmlAttributeValueStyle.DoubleQuotes);
        private static readonly global::Microsoft.AspNetCore.Razor.TagHelpers.TagHelperAttribute __tagHelperAttribute_10 = new global::Microsoft.AspNetCore.Razor.TagHelpers.TagHelperAttribute("class", new global::Microsoft.AspNetCore.Html.HtmlString("validate"), global::Microsoft.AspNetCore.Razor.TagHelpers.HtmlAttributeValueStyle.DoubleQuotes);
        private static readonly global::Microsoft.AspNetCore.Razor.TagHelpers.TagHelperAttribute __tagHelperAttribute_11 = new global::Microsoft.AspNetCore.Razor.TagHelpers.TagHelperAttribute("target", new global::Microsoft.AspNetCore.Html.HtmlString("_blank"), global::Microsoft.AspNetCore.Razor.TagHelpers.HtmlAttributeValueStyle.DoubleQuotes);
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
        private global::Microsoft.AspNetCore.Mvc.TagHelpers.FormTagHelper __Microsoft_AspNetCore_Mvc_TagHelpers_FormTagHelper;
        private global::Microsoft.AspNetCore.Mvc.TagHelpers.RenderAtEndOfFormTagHelper __Microsoft_AspNetCore_Mvc_TagHelpers_RenderAtEndOfFormTagHelper;
        #pragma warning disable 1998
        public async override global::System.Threading.Tasks.Task ExecuteAsync()
        {
#line 2 "D:\Asp.net\EduHome\EduHome\Views\Course\Detail.cshtml"
  
    ViewData["Title"] = "Detail";

#line default
#line hidden
            BeginContext(57, 844, true);
            WriteLiteral(@"
<!-- Banner Area Start -->
<div class=""banner-area-wrapper"">
    <div class=""banner-area text-center"">
        <div class=""container"">
            <div class=""row"">
                <div class=""col-xs-12"">
                    <div class=""banner-content-wrapper"">
                        <div class=""banner-content"">
                            <h2>courses details</h2>
                        </div>
                    </div>
                </div>
            </div>
        </div>
    </div>
</div>
<!-- Banner Area End -->
<!-- Blog Start -->
<div class=""courses-details-area blog-area pt-150 pb-140"">
    <div class=""container"">
        <div class=""row"">
            <div class=""col-md-8"">
                <div class=""courses-details"">
                    <div class=""courses-details-img"">
                        ");
            EndContext();
            BeginContext(901, 89, false);
            __tagHelperExecutionContext = __tagHelperScopeManager.Begin("img", global::Microsoft.AspNetCore.Razor.TagHelpers.TagMode.StartTagOnly, "abcadcd7337f4e8194b414ebd884a47e", async() => {
            }
            );
            __Microsoft_AspNetCore_Mvc_Razor_TagHelpers_UrlResolutionTagHelper = CreateTagHelper<global::Microsoft.AspNetCore.Mvc.Razor.TagHelpers.UrlResolutionTagHelper>();
            __tagHelperExecutionContext.Add(__Microsoft_AspNetCore_Mvc_Razor_TagHelpers_UrlResolutionTagHelper);
            __tagHelperExecutionContext.AddHtmlAttribute(__tagHelperAttribute_0);
            BeginAddHtmlAttributeValues(__tagHelperExecutionContext, "src", 2, global::Microsoft.AspNetCore.Razor.TagHelpers.HtmlAttributeValueStyle.DoubleQuotes);
            AddHtmlAttributeValue("", 941, "~/img/course/", 941, 13, true);
#line 30 "D:\Asp.net\EduHome\EduHome\Views\Course\Detail.cshtml"
AddHtmlAttributeValue("", 954, Model.Image, 954, 12, false);

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
            BeginContext(990, 116, true);
            WriteLiteral("\r\n                    </div>\r\n                    <div class=\"course-details-content\">\r\n                        <h2>");
            EndContext();
            BeginContext(1107, 26, false);
#line 33 "D:\Asp.net\EduHome\EduHome\Views\Course\Detail.cshtml"
                       Write(Model.CourseCategory.Title);

#line default
#line hidden
            EndContext();
            BeginContext(1133, 34, true);
            WriteLiteral("</h2>\r\n                        <p>");
            EndContext();
            BeginContext(1168, 29, false);
#line 34 "D:\Asp.net\EduHome\EduHome\Views\Course\Detail.cshtml"
                      Write(Model.CourseContent.NameAbout);

#line default
#line hidden
            EndContext();
            BeginContext(1197, 217, true);
            WriteLiteral("</p>\r\n                        <div class=\"course-details-left\">\r\n                            <div class=\"single-course-left\">\r\n                                <h3>about course</h3>\r\n                                <p>");
            EndContext();
            BeginContext(1415, 25, false);
#line 38 "D:\Asp.net\EduHome\EduHome\Views\Course\Detail.cshtml"
                              Write(Model.CourseContent.About);

#line default
#line hidden
            EndContext();
            BeginContext(1440, 194, true);
            WriteLiteral("</p>\r\n                            </div>\r\n                            <div class=\"single-course-left\">\r\n                                <h3>how to apply</h3>\r\n                                <p>");
            EndContext();
            BeginContext(1635, 30, false);
#line 42 "D:\Asp.net\EduHome\EduHome\Views\Course\Detail.cshtml"
                              Write(Model.CourseContent.HowToApply);

#line default
#line hidden
            EndContext();
            BeginContext(1665, 210, true);
            WriteLiteral("</p>\r\n                            </div>\r\n                            <div class=\"single-course-left\">\r\n                                <h3>certification</h3>\r\n                                <p class=\"margin\">");
            EndContext();
            BeginContext(1876, 33, false);
#line 46 "D:\Asp.net\EduHome\EduHome\Views\Course\Detail.cshtml"
                                             Write(Model.CourseContent.Certification);

#line default
#line hidden
            EndContext();
            BeginContext(1909, 41, true);
            WriteLiteral("</p>\r\n                                <p>");
            EndContext();
            BeginContext(1951, 33, false);
#line 47 "D:\Asp.net\EduHome\EduHome\Views\Course\Detail.cshtml"
                              Write(Model.CourseContent.Certification);

#line default
#line hidden
            EndContext();
            BeginContext(1984, 271, true);
            WriteLiteral(@"</p>
                            </div>
                        </div>
                        <div class=""course-details-right"">
                            <h3>COURSE FEATURES</h3>
                            <ul>
                                <li>starts <span>");
            EndContext();
            BeginContext(2256, 15, false);
#line 53 "D:\Asp.net\EduHome\EduHome\Views\Course\Detail.cshtml"
                                            Write(Model.StartTime);

#line default
#line hidden
            EndContext();
            BeginContext(2271, 65, true);
            WriteLiteral("</span></li>\r\n                                <li>duration <span>");
            EndContext();
            BeginContext(2337, 14, false);
#line 54 "D:\Asp.net\EduHome\EduHome\Views\Course\Detail.cshtml"
                                              Write(Model.Duration);

#line default
#line hidden
            EndContext();
            BeginContext(2351, 71, true);
            WriteLiteral("</span></li>\r\n                                <li>class duration <span>");
            EndContext();
            BeginContext(2423, 19, false);
#line 55 "D:\Asp.net\EduHome\EduHome\Views\Course\Detail.cshtml"
                                                    Write(Model.ClassDuration);

#line default
#line hidden
            EndContext();
            BeginContext(2442, 68, true);
            WriteLiteral("</span></li>\r\n                                <li>skill level <span>");
            EndContext();
            BeginContext(2511, 16, false);
#line 56 "D:\Asp.net\EduHome\EduHome\Views\Course\Detail.cshtml"
                                                 Write(Model.SkillLevel);

#line default
#line hidden
            EndContext();
            BeginContext(2527, 65, true);
            WriteLiteral("</span></li>\r\n                                <li>language <span>");
            EndContext();
            BeginContext(2593, 14, false);
#line 57 "D:\Asp.net\EduHome\EduHome\Views\Course\Detail.cshtml"
                                              Write(Model.Language);

#line default
#line hidden
            EndContext();
            BeginContext(2607, 65, true);
            WriteLiteral("</span></li>\r\n                                <li>students <span>");
            EndContext();
            BeginContext(2673, 18, false);
#line 58 "D:\Asp.net\EduHome\EduHome\Views\Course\Detail.cshtml"
                                              Write(Model.StudentCount);

#line default
#line hidden
            EndContext();
            BeginContext(2691, 67, true);
            WriteLiteral("</span></li>\r\n                                <li>assesments <span>");
            EndContext();
            BeginContext(2759, 16, false);
#line 59 "D:\Asp.net\EduHome\EduHome\Views\Course\Detail.cshtml"
                                                Write(Model.Assessment);

#line default
#line hidden
            EndContext();
            BeginContext(2775, 106, true);
            WriteLiteral("</span></li>\r\n                            </ul>\r\n                            <h3 class=\"red\">course fee $ ");
            EndContext();
            BeginContext(2882, 9, false);
#line 61 "D:\Asp.net\EduHome\EduHome\Views\Course\Detail.cshtml"
                                                    Write(Model.Fee);

#line default
#line hidden
            EndContext();
            BeginContext(2891, 384, true);
            WriteLiteral(@"</h3>
                        </div>
                    </div>
                    <div class=""reply-area"">
                        <h3>LEAVE A REPLY</h3>
                        <p>I must explain to you how all this a mistaken idea of ncing great explorer of the rut<br> the is lder of human happinescias unde omnis iste natus error sit volptatem </p>
                        ");
            EndContext();
            BeginContext(3275, 1215, false);
            __tagHelperExecutionContext = __tagHelperScopeManager.Begin("form", global::Microsoft.AspNetCore.Razor.TagHelpers.TagMode.StartTagAndEndTag, "b54c3a96682542eebf641635129261d9", async() => {
                BeginContext(3364, 1119, true);
                WriteLiteral(@"
                            <div class=""row"">
                                <div class=""col-md-12"">
                                    <p>Name</p>
                                    <input type=""text"" name=""name"" id=""name"">
                                </div>
                                <div class=""col-md-12"">
                                    <p>Email</p>
                                    <input type=""text"" name=""email"" id=""email"">
                                </div>
                                <div class=""col-md-12"">
                                    <p>Subject</p>
                                    <input type=""text"" name=""subject"" id=""subject"">
                                    <p>Massage</p>
                                    <textarea name=""message"" id=""message"" cols=""15"" rows=""10""></textarea>
                                </div>
                            </div>
                            <a class=""reply-btn"" href=""#"" data-text=""send""><span>send message");
                WriteLiteral("</span></a>\r\n                            <p class=\"form-messege\"></p>\r\n                        ");
                EndContext();
            }
            );
            __Microsoft_AspNetCore_Mvc_TagHelpers_FormTagHelper = CreateTagHelper<global::Microsoft.AspNetCore.Mvc.TagHelpers.FormTagHelper>();
            __tagHelperExecutionContext.Add(__Microsoft_AspNetCore_Mvc_TagHelpers_FormTagHelper);
            __Microsoft_AspNetCore_Mvc_TagHelpers_RenderAtEndOfFormTagHelper = CreateTagHelper<global::Microsoft.AspNetCore.Mvc.TagHelpers.RenderAtEndOfFormTagHelper>();
            __tagHelperExecutionContext.Add(__Microsoft_AspNetCore_Mvc_TagHelpers_RenderAtEndOfFormTagHelper);
            __tagHelperExecutionContext.AddHtmlAttribute(__tagHelperAttribute_2);
            __tagHelperExecutionContext.AddHtmlAttribute(__tagHelperAttribute_3);
            __Microsoft_AspNetCore_Mvc_TagHelpers_FormTagHelper.Method = (string)__tagHelperAttribute_4.Value;
            __tagHelperExecutionContext.AddTagHelperAttribute(__tagHelperAttribute_4);
            await __tagHelperRunner.RunAsync(__tagHelperExecutionContext);
            if (!__tagHelperExecutionContext.Output.IsContentModified)
            {
                await __tagHelperExecutionContext.SetOutputContentAsync();
            }
            Write(__tagHelperExecutionContext.Output);
            __tagHelperExecutionContext = __tagHelperScopeManager.End();
            EndContext();
            BeginContext(4490, 340, true);
            WriteLiteral(@"
                    </div>
                </div>
            </div>
            <div class=""col-md-4"">
                <div class=""blog-sidebar right"">
                    <div class=""single-blog-widget mb-50"">
                        <h3>search</h3>
                        <div class=""blog-search"">
                            ");
            EndContext();
            BeginContext(4830, 339, false);
            __tagHelperExecutionContext = __tagHelperScopeManager.Begin("form", global::Microsoft.AspNetCore.Razor.TagHelpers.TagMode.StartTagAndEndTag, "8f319613985d427bbd72507de4b0e4c5", async() => {
                BeginContext(4859, 303, true);
                WriteLiteral(@"
                                <input type=""search"" placeholder=""Search..."" name=""search"" />
                                <button type=""submit"">
                                    <span><i class=""fa fa-search""></i></span>
                                </button>
                            ");
                EndContext();
            }
            );
            __Microsoft_AspNetCore_Mvc_TagHelpers_FormTagHelper = CreateTagHelper<global::Microsoft.AspNetCore.Mvc.TagHelpers.FormTagHelper>();
            __tagHelperExecutionContext.Add(__Microsoft_AspNetCore_Mvc_TagHelpers_FormTagHelper);
            __Microsoft_AspNetCore_Mvc_TagHelpers_RenderAtEndOfFormTagHelper = CreateTagHelper<global::Microsoft.AspNetCore.Mvc.TagHelpers.RenderAtEndOfFormTagHelper>();
            __tagHelperExecutionContext.Add(__Microsoft_AspNetCore_Mvc_TagHelpers_RenderAtEndOfFormTagHelper);
            __tagHelperExecutionContext.AddHtmlAttribute(__tagHelperAttribute_5);
            __tagHelperExecutionContext.AddHtmlAttribute(__tagHelperAttribute_6);
            await __tagHelperRunner.RunAsync(__tagHelperExecutionContext);
            if (!__tagHelperExecutionContext.Output.IsContentModified)
            {
                await __tagHelperExecutionContext.SetOutputContentAsync();
            }
            Write(__tagHelperExecutionContext.Output);
            __tagHelperExecutionContext = __tagHelperScopeManager.End();
            EndContext();
            BeginContext(5169, 258, true);
            WriteLiteral(@"
                        </div>
                    </div>
                    <div class=""single-blog-widget mb-50"">
                        <h3>categories</h3>
                        <ul>
                            <li><a href=""#"">CSS Engineering (");
            EndContext();
            BeginContext(5428, 26, false);
#line 106 "D:\Asp.net\EduHome\EduHome\Views\Course\Detail.cshtml"
                                                        Write(Model.CourseCategory.Count);

#line default
#line hidden
            EndContext();
            BeginContext(5454, 75, true);
            WriteLiteral(")</a></li>\r\n                            <li><a href=\"#\">Political Science (");
            EndContext();
            BeginContext(5530, 26, false);
#line 107 "D:\Asp.net\EduHome\EduHome\Views\Course\Detail.cshtml"
                                                          Write(Model.CourseCategory.Count);

#line default
#line hidden
            EndContext();
            BeginContext(5556, 71, true);
            WriteLiteral(")</a></li>\r\n                            <li><a href=\"#\">Micro Biology (");
            EndContext();
            BeginContext(5628, 26, false);
#line 108 "D:\Asp.net\EduHome\EduHome\Views\Course\Detail.cshtml"
                                                      Write(Model.CourseCategory.Count);

#line default
#line hidden
            EndContext();
            BeginContext(5654, 74, true);
            WriteLiteral(")</a></li>\r\n                            <li><a href=\"#\">HTML5 &amp; CSS3 (");
            EndContext();
            BeginContext(5729, 26, false);
#line 109 "D:\Asp.net\EduHome\EduHome\Views\Course\Detail.cshtml"
                                                         Write(Model.CourseCategory.Count);

#line default
#line hidden
            EndContext();
            BeginContext(5755, 68, true);
            WriteLiteral(")</a></li>\r\n                            <li><a href=\"#\">Web Design (");
            EndContext();
            BeginContext(5824, 26, false);
#line 110 "D:\Asp.net\EduHome\EduHome\Views\Course\Detail.cshtml"
                                                   Write(Model.CourseCategory.Count);

#line default
#line hidden
            EndContext();
            BeginContext(5850, 61, true);
            WriteLiteral(")</a></li>\r\n                            <li><a href=\"#\">PHP (");
            EndContext();
            BeginContext(5912, 26, false);
#line 111 "D:\Asp.net\EduHome\EduHome\Views\Course\Detail.cshtml"
                                            Write(Model.CourseCategory.Count);

#line default
#line hidden
            EndContext();
            BeginContext(5938, 4277, true);
            WriteLiteral(@")</a></li>
                        </ul>
                    </div>
                    <div class=""single-blog-widget mb-50"">
                        <div class=""single-blog-banner"">
                            <a href=""blog-details.html"" id=""blog""><img src=""img/blog/blog-img.jpg"" alt=""blog""></a>
                            <h2>best<br> eductaion<br> theme</h2>
                        </div>
                    </div>
                    <div class=""single-blog-widget mb-50"">
                        <h3>latest post</h3>
                        <div class=""single-post mb-30"">
                            <div class=""single-post-img"">
                                <a href=""blog-details.html"">
                                    <img src=""img/post/post1.jpg"" alt=""post"">
                                    <div class=""blog-hover"">
                                        <i class=""fa fa-link""></i>
                                    </div>
                                </a>
                 ");
            WriteLiteral(@"           </div>
                            <div class=""single-post-content"">
                                <h4><a href=""blog-details.html"">English Language Course for you</a></h4>
                                <p>By Alex  /  June 20, 2017</p>
                            </div>
                        </div>
                        <div class=""single-post mb-30"">
                            <div class=""single-post-img"">
                                <a href=""blog-details.html"">
                                    <img src=""img/post/post2.jpg"" alt=""post"">
                                    <div class=""blog-hover"">
                                        <i class=""fa fa-link""></i>
                                    </div>
                                </a>
                            </div>
                            <div class=""single-post-content"">
                                <h4><a href=""blog-details.html"">Advance Web Design and Develop</a></h4>
                             ");
            WriteLiteral(@"   <p>By Alex  /  June 20, 2017</p>
                            </div>
                        </div>
                        <div class=""single-post"">
                            <div class=""single-post-img"">
                                <a href=""blog-details.html"">
                                    <img src=""img/post/post3.jpg"" alt=""post"">
                                    <div class=""blog-hover"">
                                        <i class=""fa fa-link""></i>
                                    </div>
                                </a>
                            </div>
                            <div class=""single-post-content"">
                                <h4><a href=""blog-details.html"">English Language Course for you</a></h4>
                                <p>By Alex  /  June 20, 2017</p>
                            </div>
                        </div>
                    </div>
                    <div class=""single-blog-widget"">
                        <h3>tags</h");
            WriteLiteral(@"3>
                        <div class=""single-tag"">
                            <a href=""blog-details.html"" class=""mr-10 mb-10"">course</a>
                            <a href=""blog-details.html"" class=""mr-10 mb-10"">education</a>
                            <a href=""blog-details.html"" class=""mb-10"">teachers</a>
                            <a href=""blog-details.html"" class=""mr-10"">learning</a>
                            <a href=""blog-details.html"" class=""mr-10"">university</a>
                            <a href=""blog-details.html"">events</a>
                        </div>
                    </div>
                </div>
            </div>
        </div>
    </div>
</div>
<!-- Blog End -->
<!-- Subscribe Start -->
<div class=""subscribe-area pt-60 pb-70"">
    <div class=""container"">
        <div class=""row"">
            <div class=""col-md-8 col-md-offset-2"">
                <div class=""subscribe-content section-title text-center"">
                    <h2>subscribe our newsletter</h2>
    ");
            WriteLiteral("                <p>I must explain to you how all this mistaken idea </p>\r\n                </div>\r\n                <div class=\"newsletter-form mc_embed_signup\">\r\n                    ");
            EndContext();
            BeginContext(10215, 976, false);
            __tagHelperExecutionContext = __tagHelperScopeManager.Begin("form", global::Microsoft.AspNetCore.Razor.TagHelpers.TagMode.StartTagAndEndTag, "b7cce858abab46519eb9de4be369e61f", async() => {
                BeginContext(10452, 732, true);
                WriteLiteral(@"
                        <div id=""mc_embed_signup_scroll"" class=""mc-form"">
                            <input type=""email"" value="""" name=""EMAIL"" class=""email"" id=""mce-EMAIL"" placeholder=""Enter your e-mail address"" required>
                            <!-- real people should not fill this in and expect good things - do not remove this or risk form bot signups-->
                            <div class=""mc-news"" aria-hidden=""true""><input type=""text"" name=""b_6bbb9b6f5827bd842d9640c82_05d85f18ef"" tabindex=""-1"" value=""""></div>
                            <button id=""mc-embedded-subscribe"" class=""default-btn"" type=""submit"" name=""subscribe""><span>subscribe</span></button>
                        </div>
                    ");
                EndContext();
            }
            );
            __Microsoft_AspNetCore_Mvc_TagHelpers_FormTagHelper = CreateTagHelper<global::Microsoft.AspNetCore.Mvc.TagHelpers.FormTagHelper>();
            __tagHelperExecutionContext.Add(__Microsoft_AspNetCore_Mvc_TagHelpers_FormTagHelper);
            __Microsoft_AspNetCore_Mvc_TagHelpers_RenderAtEndOfFormTagHelper = CreateTagHelper<global::Microsoft.AspNetCore.Mvc.TagHelpers.RenderAtEndOfFormTagHelper>();
            __tagHelperExecutionContext.Add(__Microsoft_AspNetCore_Mvc_TagHelpers_RenderAtEndOfFormTagHelper);
            __tagHelperExecutionContext.AddHtmlAttribute(__tagHelperAttribute_7);
            __Microsoft_AspNetCore_Mvc_TagHelpers_FormTagHelper.Method = (string)__tagHelperAttribute_4.Value;
            __tagHelperExecutionContext.AddTagHelperAttribute(__tagHelperAttribute_4);
            __tagHelperExecutionContext.AddHtmlAttribute(__tagHelperAttribute_8);
            __tagHelperExecutionContext.AddHtmlAttribute(__tagHelperAttribute_9);
            __tagHelperExecutionContext.AddHtmlAttribute(__tagHelperAttribute_10);
            __tagHelperExecutionContext.AddHtmlAttribute(__tagHelperAttribute_11);
            BeginWriteTagHelperAttribute();
            __tagHelperStringValueBuffer = EndWriteTagHelperAttribute();
            __tagHelperExecutionContext.AddHtmlAttribute("novalidate", Html.Raw(__tagHelperStringValueBuffer), global::Microsoft.AspNetCore.Razor.TagHelpers.HtmlAttributeValueStyle.Minimized);
            await __tagHelperRunner.RunAsync(__tagHelperExecutionContext);
            if (!__tagHelperExecutionContext.Output.IsContentModified)
            {
                await __tagHelperExecutionContext.SetOutputContentAsync();
            }
            Write(__tagHelperExecutionContext.Output);
            __tagHelperExecutionContext = __tagHelperScopeManager.End();
            EndContext();
            BeginContext(11191, 569, true);
            WriteLiteral(@"
                    <!-- mailchimp-alerts Start -->
                    <div class=""mailchimp-alerts"">
                        <div class=""mailchimp-submitting""></div><!-- mailchimp-submitting end -->
                        <div class=""mailchimp-success""></div><!-- mailchimp-success end -->
                        <div class=""mailchimp-error""></div><!-- mailchimp-error end -->
                    </div>
                    <!-- mailchimp-alerts end -->
                </div>
            </div>
        </div>
    </div>
</div>
<!-- Subscribe End -->");
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
        public global::Microsoft.AspNetCore.Mvc.Rendering.IHtmlHelper<Course> Html { get; private set; }
    }
}
#pragma warning restore 1591
