#pragma checksum "C:\Users\Admin\Desktop\CodingDojo\C#Stack\ORM\CRUDelicious\Views\Home\DisplayDish.cshtml" "{ff1816ec-aa5e-4d10-87f7-6f4963833460}" "70a53e26096c5a59e55fde5d7cef9eccf4922dfd"
// <auto-generated/>
#pragma warning disable 1591
[assembly: global::Microsoft.AspNetCore.Razor.Hosting.RazorCompiledItemAttribute(typeof(AspNetCore.Views_Home_DisplayDish), @"mvc.1.0.view", @"/Views/Home/DisplayDish.cshtml")]
[assembly:global::Microsoft.AspNetCore.Mvc.Razor.Compilation.RazorViewAttribute(@"/Views/Home/DisplayDish.cshtml", typeof(AspNetCore.Views_Home_DisplayDish))]
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
#line 1 "C:\Users\Admin\Desktop\CodingDojo\C#Stack\ORM\CRUDelicious\Views\_ViewImports.cshtml"
using CRUDelicious;

#line default
#line hidden
#line 2 "C:\Users\Admin\Desktop\CodingDojo\C#Stack\ORM\CRUDelicious\Views\_ViewImports.cshtml"
using CRUDelicious.Models;

#line default
#line hidden
    [global::Microsoft.AspNetCore.Razor.Hosting.RazorSourceChecksumAttribute(@"SHA1", @"70a53e26096c5a59e55fde5d7cef9eccf4922dfd", @"/Views/Home/DisplayDish.cshtml")]
    [global::Microsoft.AspNetCore.Razor.Hosting.RazorSourceChecksumAttribute(@"SHA1", @"815eae4269ab1eac71e8261ccfa9294c33285639", @"/Views/_ViewImports.cshtml")]
    public class Views_Home_DisplayDish : global::Microsoft.AspNetCore.Mvc.Razor.RazorPage<CRUDelicious.Models.Dish>
    {
        private static readonly global::Microsoft.AspNetCore.Razor.TagHelpers.TagHelperAttribute __tagHelperAttribute_0 = new global::Microsoft.AspNetCore.Razor.TagHelpers.TagHelperAttribute("method", "post", global::Microsoft.AspNetCore.Razor.TagHelpers.HtmlAttributeValueStyle.DoubleQuotes);
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
        private global::Microsoft.AspNetCore.Mvc.TagHelpers.FormTagHelper __Microsoft_AspNetCore_Mvc_TagHelpers_FormTagHelper;
        private global::Microsoft.AspNetCore.Mvc.TagHelpers.RenderAtEndOfFormTagHelper __Microsoft_AspNetCore_Mvc_TagHelpers_RenderAtEndOfFormTagHelper;
        #pragma warning disable 1998
        public async override global::System.Threading.Tasks.Task ExecuteAsync()
        {
            BeginContext(33, 2, true);
            WriteLiteral("\r\n");
            EndContext();
#line 3 "C:\Users\Admin\Desktop\CodingDojo\C#Stack\ORM\CRUDelicious\Views\Home\DisplayDish.cshtml"
  
    ViewData["Title"] = "Dish Page";

#line default
#line hidden
            BeginContext(80, 55, true);
            WriteLiteral("\r\n<div class=\"text-center\">\r\n    <h1 class=\"display-4\">");
            EndContext();
            BeginContext(136, 10, false);
#line 8 "C:\Users\Admin\Desktop\CodingDojo\C#Stack\ORM\CRUDelicious\Views\Home\DisplayDish.cshtml"
                     Write(Model.Name);

#line default
#line hidden
            EndContext();
            BeginContext(146, 15, true);
            WriteLiteral("</h1>\r\n    <h3>");
            EndContext();
            BeginContext(162, 10, false);
#line 9 "C:\Users\Admin\Desktop\CodingDojo\C#Stack\ORM\CRUDelicious\Views\Home\DisplayDish.cshtml"
   Write(Model.Chef);

#line default
#line hidden
            EndContext();
            BeginContext(172, 14, true);
            WriteLiteral("</h3>\r\n    <p>");
            EndContext();
            BeginContext(187, 17, false);
#line 10 "C:\Users\Admin\Desktop\CodingDojo\C#Stack\ORM\CRUDelicious\Views\Home\DisplayDish.cshtml"
  Write(Model.Description);

#line default
#line hidden
            EndContext();
            BeginContext(204, 23, true);
            WriteLiteral("</p>\r\n    <p>Calories: ");
            EndContext();
            BeginContext(228, 14, false);
#line 11 "C:\Users\Admin\Desktop\CodingDojo\C#Stack\ORM\CRUDelicious\Views\Home\DisplayDish.cshtml"
            Write(Model.Calories);

#line default
#line hidden
            EndContext();
            BeginContext(242, 24, true);
            WriteLiteral("</p>\r\n    <p>Tastiness: ");
            EndContext();
            BeginContext(267, 15, false);
#line 12 "C:\Users\Admin\Desktop\CodingDojo\C#Stack\ORM\CRUDelicious\Views\Home\DisplayDish.cshtml"
             Write(Model.Tastiness);

#line default
#line hidden
            EndContext();
            BeginContext(282, 14, true);
            WriteLiteral("</p>\r\n\r\n    <a");
            EndContext();
            BeginWriteAttribute("href", " href= \"", 296, "\"", 328, 3);
            WriteAttributeValue("", 304, "../../", 304, 6, true);
#line 14 "C:\Users\Admin\Desktop\CodingDojo\C#Stack\ORM\CRUDelicious\Views\Home\DisplayDish.cshtml"
WriteAttributeValue("", 310, Model.DishId, 310, 13, false);

#line default
#line hidden
            WriteAttributeValue("", 323, "/Edit", 323, 5, true);
            EndWriteAttribute();
            BeginContext(329, 17, true);
            WriteLiteral(">Edit</a>\r\n\r\n    ");
            EndContext();
            BeginContext(346, 124, false);
            __tagHelperExecutionContext = __tagHelperScopeManager.Begin("form", global::Microsoft.AspNetCore.Razor.TagHelpers.TagMode.StartTagAndEndTag, "70a53e26096c5a59e55fde5d7cef9eccf4922dfd6358", async() => {
                BeginContext(402, 61, true);
                WriteLiteral("\r\n        <input value=\"Delete Dish\" type=\"submit\">    \r\n    ");
                EndContext();
            }
            );
            __Microsoft_AspNetCore_Mvc_TagHelpers_FormTagHelper = CreateTagHelper<global::Microsoft.AspNetCore.Mvc.TagHelpers.FormTagHelper>();
            __tagHelperExecutionContext.Add(__Microsoft_AspNetCore_Mvc_TagHelpers_FormTagHelper);
            __Microsoft_AspNetCore_Mvc_TagHelpers_RenderAtEndOfFormTagHelper = CreateTagHelper<global::Microsoft.AspNetCore.Mvc.TagHelpers.RenderAtEndOfFormTagHelper>();
            __tagHelperExecutionContext.Add(__Microsoft_AspNetCore_Mvc_TagHelpers_RenderAtEndOfFormTagHelper);
            BeginAddHtmlAttributeValues(__tagHelperExecutionContext, "action", 3, global::Microsoft.AspNetCore.Razor.TagHelpers.HtmlAttributeValueStyle.DoubleQuotes);
            AddHtmlAttributeValue("", 360, "../../", 360, 6, true);
#line 16 "C:\Users\Admin\Desktop\CodingDojo\C#Stack\ORM\CRUDelicious\Views\Home\DisplayDish.cshtml"
AddHtmlAttributeValue("", 366, Model.DishId, 366, 13, false);

#line default
#line hidden
            AddHtmlAttributeValue("", 379, "/Delete", 379, 7, true);
            EndAddHtmlAttributeValues(__tagHelperExecutionContext);
            __Microsoft_AspNetCore_Mvc_TagHelpers_FormTagHelper.Method = (string)__tagHelperAttribute_0.Value;
            __tagHelperExecutionContext.AddTagHelperAttribute(__tagHelperAttribute_0);
            await __tagHelperRunner.RunAsync(__tagHelperExecutionContext);
            if (!__tagHelperExecutionContext.Output.IsContentModified)
            {
                await __tagHelperExecutionContext.SetOutputContentAsync();
            }
            Write(__tagHelperExecutionContext.Output);
            __tagHelperExecutionContext = __tagHelperScopeManager.End();
            EndContext();
            BeginContext(470, 8, true);
            WriteLiteral("\r\n</div>");
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
        public global::Microsoft.AspNetCore.Mvc.Rendering.IHtmlHelper<CRUDelicious.Models.Dish> Html { get; private set; }
    }
}
#pragma warning restore 1591
