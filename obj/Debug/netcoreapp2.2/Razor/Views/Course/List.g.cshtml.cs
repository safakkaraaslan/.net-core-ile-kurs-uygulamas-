#pragma checksum "C:\Users\user\desktop\CourseApp\Views\Course\List.cshtml" "{ff1816ec-aa5e-4d10-87f7-6f4963833460}" "c2119a9ce0f3736ff8b9d8e39dd947f8c4a0df88"
// <auto-generated/>
#pragma warning disable 1591
[assembly: global::Microsoft.AspNetCore.Razor.Hosting.RazorCompiledItemAttribute(typeof(AspNetCore.Views_Course_List), @"mvc.1.0.view", @"/Views/Course/List.cshtml")]
[assembly:global::Microsoft.AspNetCore.Mvc.Razor.Compilation.RazorViewAttribute(@"/Views/Course/List.cshtml", typeof(AspNetCore.Views_Course_List))]
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
#line 1 "C:\Users\user\desktop\CourseApp\Views\_ViewImports.cshtml"
using CourseApp.Models;

#line default
#line hidden
    [global::Microsoft.AspNetCore.Razor.Hosting.RazorSourceChecksumAttribute(@"SHA1", @"c2119a9ce0f3736ff8b9d8e39dd947f8c4a0df88", @"/Views/Course/List.cshtml")]
    [global::Microsoft.AspNetCore.Razor.Hosting.RazorSourceChecksumAttribute(@"SHA1", @"e41b4561d115cf3102867c239a0cc898ed0bb749", @"/Views/_ViewImports.cshtml")]
    public class Views_Course_List : global::Microsoft.AspNetCore.Mvc.Razor.RazorPage<IEnumerable<Student>>
    {
        private static readonly global::Microsoft.AspNetCore.Razor.TagHelpers.TagHelperAttribute __tagHelperAttribute_0 = new global::Microsoft.AspNetCore.Razor.TagHelpers.TagHelperAttribute("rel", new global::Microsoft.AspNetCore.Html.HtmlString("stylesheet"), global::Microsoft.AspNetCore.Razor.TagHelpers.HtmlAttributeValueStyle.DoubleQuotes);
        private static readonly global::Microsoft.AspNetCore.Razor.TagHelpers.TagHelperAttribute __tagHelperAttribute_1 = new global::Microsoft.AspNetCore.Razor.TagHelpers.TagHelperAttribute("href", new global::Microsoft.AspNetCore.Html.HtmlString("~/css/style.css"), global::Microsoft.AspNetCore.Razor.TagHelpers.HtmlAttributeValueStyle.DoubleQuotes);
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
        private global::Microsoft.AspNetCore.Mvc.Razor.TagHelpers.HeadTagHelper __Microsoft_AspNetCore_Mvc_Razor_TagHelpers_HeadTagHelper;
        private global::Microsoft.AspNetCore.Mvc.Razor.TagHelpers.UrlResolutionTagHelper __Microsoft_AspNetCore_Mvc_Razor_TagHelpers_UrlResolutionTagHelper;
        private global::Microsoft.AspNetCore.Mvc.Razor.TagHelpers.BodyTagHelper __Microsoft_AspNetCore_Mvc_Razor_TagHelpers_BodyTagHelper;
        #pragma warning disable 1998
        public async override global::System.Threading.Tasks.Task ExecuteAsync()
        {
            BeginContext(29, 31, true);
            WriteLiteral("\r\n<!DOCTYPE html>\r\n<html>\r\n    ");
            EndContext();
            BeginContext(60, 384, false);
            __tagHelperExecutionContext = __tagHelperScopeManager.Begin("head", global::Microsoft.AspNetCore.Razor.TagHelpers.TagMode.StartTagAndEndTag, "c2119a9ce0f3736ff8b9d8e39dd947f8c4a0df884043", async() => {
                BeginContext(66, 309, true);
                WriteLiteral(@"
        <meta charset=""utf-8"">
        <meta http-equiv=""X-UA-Compatible"" content=""IE=edge"">
        <title>Course</title>
        <meta name=""viewport"" content=""width=device-width,
        initial-scale=1"">
        <link rel=""stylesheet"" href=""/modules/bootstrap/dist/css/bootstrap.min.css"">
        ");
                EndContext();
                BeginContext(375, 46, false);
                __tagHelperExecutionContext = __tagHelperScopeManager.Begin("link", global::Microsoft.AspNetCore.Razor.TagHelpers.TagMode.StartTagOnly, "c2119a9ce0f3736ff8b9d8e39dd947f8c4a0df884745", async() => {
                }
                );
                __Microsoft_AspNetCore_Mvc_Razor_TagHelpers_UrlResolutionTagHelper = CreateTagHelper<global::Microsoft.AspNetCore.Mvc.Razor.TagHelpers.UrlResolutionTagHelper>();
                __tagHelperExecutionContext.Add(__Microsoft_AspNetCore_Mvc_Razor_TagHelpers_UrlResolutionTagHelper);
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
                BeginContext(421, 16, true);
                WriteLiteral("  \r\n      \r\n    ");
                EndContext();
            }
            );
            __Microsoft_AspNetCore_Mvc_Razor_TagHelpers_HeadTagHelper = CreateTagHelper<global::Microsoft.AspNetCore.Mvc.Razor.TagHelpers.HeadTagHelper>();
            __tagHelperExecutionContext.Add(__Microsoft_AspNetCore_Mvc_Razor_TagHelpers_HeadTagHelper);
            await __tagHelperRunner.RunAsync(__tagHelperExecutionContext);
            if (!__tagHelperExecutionContext.Output.IsContentModified)
            {
                await __tagHelperExecutionContext.SetOutputContentAsync();
            }
            Write(__tagHelperExecutionContext.Output);
            __tagHelperExecutionContext = __tagHelperScopeManager.End();
            EndContext();
            BeginContext(444, 6, true);
            WriteLiteral("\r\n    ");
            EndContext();
            BeginContext(450, 1672, false);
            __tagHelperExecutionContext = __tagHelperScopeManager.Begin("body", global::Microsoft.AspNetCore.Razor.TagHelpers.TagMode.StartTagAndEndTag, "c2119a9ce0f3736ff8b9d8e39dd947f8c4a0df886896", async() => {
                BeginContext(456, 697, true);
                WriteLiteral(@"

         <div class=""container m-4"">
            <div class=""card mx-auto"" style=""width:500px;"">
                <div class=""card-header"">
                   Kursa Katılanlar
                </div>
                <table class=""table table-bordered table-striped"">
                        <thead>
                        
                            <tr>
                                <td>Name</td>
                                <td>Email</td> 
                                <td>Phone</td>
                                <td>Confirm</td>      
                            </tr> 
                        
                        </thead>
                        <tbody>
");
                EndContext();
#line 34 "C:\Users\user\desktop\CourseApp\Views\Course\List.cshtml"
                             foreach (var student in Model) //tekrarlıcak alan oldugu ıcın tbody içerisine aldık
                            {

#line default
#line hidden
                BeginContext(1298, 120, true);
                WriteLiteral("                                <tr>\r\n                                    <td>\r\n                                        ");
                EndContext();
                BeginContext(1419, 12, false);
#line 38 "C:\Users\user\desktop\CourseApp\Views\Course\List.cshtml"
                                   Write(student.Name);

#line default
#line hidden
                EndContext();
                BeginContext(1431, 127, true);
                WriteLiteral("\r\n                                    </td>\r\n                                    <td>\r\n                                        ");
                EndContext();
                BeginContext(1559, 13, false);
#line 41 "C:\Users\user\desktop\CourseApp\Views\Course\List.cshtml"
                                   Write(student.Email);

#line default
#line hidden
                EndContext();
                BeginContext(1572, 127, true);
                WriteLiteral("\r\n                                    </td>\r\n                                    <td>\r\n                                        ");
                EndContext();
                BeginContext(1700, 13, false);
#line 44 "C:\Users\user\desktop\CourseApp\Views\Course\List.cshtml"
                                   Write(student.Phone);

#line default
#line hidden
                EndContext();
                BeginContext(1713, 127, true);
                WriteLiteral("\r\n                                    </td>\r\n                                    <td>\r\n                                        ");
                EndContext();
                BeginContext(1841, 15, false);
#line 47 "C:\Users\user\desktop\CourseApp\Views\Course\List.cshtml"
                                   Write(student.Confirm);

#line default
#line hidden
                EndContext();
                BeginContext(1856, 85, true);
                WriteLiteral(" \r\n                                    </td>\r\n                                </tr>\r\n");
                EndContext();
#line 50 "C:\Users\user\desktop\CourseApp\Views\Course\List.cshtml"
                        
                            }

#line default
#line hidden
                BeginContext(1998, 117, true);
                WriteLiteral("                        \r\n                        </tbody>\r\n        </table>\r\n    </div>\r\n</div>\r\n\r\n       \r\n      \r\n");
                EndContext();
            }
            );
            __Microsoft_AspNetCore_Mvc_Razor_TagHelpers_BodyTagHelper = CreateTagHelper<global::Microsoft.AspNetCore.Mvc.Razor.TagHelpers.BodyTagHelper>();
            __tagHelperExecutionContext.Add(__Microsoft_AspNetCore_Mvc_Razor_TagHelpers_BodyTagHelper);
            await __tagHelperRunner.RunAsync(__tagHelperExecutionContext);
            if (!__tagHelperExecutionContext.Output.IsContentModified)
            {
                await __tagHelperExecutionContext.SetOutputContentAsync();
            }
            Write(__tagHelperExecutionContext.Output);
            __tagHelperExecutionContext = __tagHelperScopeManager.End();
            EndContext();
            BeginContext(2122, 10, true);
            WriteLiteral(" \r\n</html>");
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
        public global::Microsoft.AspNetCore.Mvc.Rendering.IHtmlHelper<IEnumerable<Student>> Html { get; private set; }
    }
}
#pragma warning restore 1591