#pragma checksum "C:\Users\zhoom\OneDrive\Рабочий стол\web2.931801.stepanov.pavel.lab4-master\Backend4\Views\Controls\Radio.cshtml" "{ff1816ec-aa5e-4d10-87f7-6f4963833460}" "0e3580c5b6ed14b4e4c72062f0d72fd31a5ddc12"
// <auto-generated/>
#pragma warning disable 1591
[assembly: global::Microsoft.AspNetCore.Razor.Hosting.RazorCompiledItemAttribute(typeof(AspNetCore.Views_Controls_Radio), @"mvc.1.0.view", @"/Views/Controls/Radio.cshtml")]
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
#line 1 "C:\Users\zhoom\OneDrive\Рабочий стол\web2.931801.stepanov.pavel.lab4-master\Backend4\Views\_ViewImports.cshtml"
using Backend4;

#line default
#line hidden
#nullable disable
#nullable restore
#line 2 "C:\Users\zhoom\OneDrive\Рабочий стол\web2.931801.stepanov.pavel.lab4-master\Backend4\Views\_ViewImports.cshtml"
using Backend4.Models;

#line default
#line hidden
#nullable disable
    [global::Microsoft.AspNetCore.Razor.Hosting.RazorSourceChecksumAttribute(@"SHA1", @"0e3580c5b6ed14b4e4c72062f0d72fd31a5ddc12", @"/Views/Controls/Radio.cshtml")]
    [global::Microsoft.AspNetCore.Razor.Hosting.RazorSourceChecksumAttribute(@"SHA1", @"96619c4a8d13af5dee7982e58002d641c54e06c6", @"/Views/_ViewImports.cshtml")]
    public class Views_Controls_Radio : global::Microsoft.AspNetCore.Mvc.Razor.RazorPage<dynamic>
    {
        private static readonly global::Microsoft.AspNetCore.Razor.TagHelpers.TagHelperAttribute __tagHelperAttribute_0 = new global::Microsoft.AspNetCore.Razor.TagHelpers.TagHelperAttribute("method", "post", global::Microsoft.AspNetCore.Razor.TagHelpers.HtmlAttributeValueStyle.DoubleQuotes);
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
        private global::Microsoft.AspNetCore.Mvc.TagHelpers.FormTagHelper __Microsoft_AspNetCore_Mvc_TagHelpers_FormTagHelper;
        private global::Microsoft.AspNetCore.Mvc.TagHelpers.RenderAtEndOfFormTagHelper __Microsoft_AspNetCore_Mvc_TagHelpers_RenderAtEndOfFormTagHelper;
        #pragma warning disable 1998
        public async override global::System.Threading.Tasks.Task ExecuteAsync()
        {
#nullable restore
#line 1 "C:\Users\zhoom\OneDrive\Рабочий стол\web2.931801.stepanov.pavel.lab4-master\Backend4\Views\Controls\Radio.cshtml"
  
    ViewData["Title"] = "Radio";

#line default
#line hidden
#nullable disable
            WriteLiteral("\n<h1>");
#nullable restore
#line 5 "C:\Users\zhoom\OneDrive\Рабочий стол\web2.931801.stepanov.pavel.lab4-master\Backend4\Views\Controls\Radio.cshtml"
Write(ViewData["Title"]);

#line default
#line hidden
#nullable disable
            WriteLiteral("</h1>\n\n");
            __tagHelperExecutionContext = __tagHelperScopeManager.Begin("form", global::Microsoft.AspNetCore.Razor.TagHelpers.TagMode.StartTagAndEndTag, "0e3580c5b6ed14b4e4c72062f0d72fd31a5ddc124106", async() => {
                WriteLiteral("\n    <div class=\"m-2\"><b>Month</b></div>\n    ");
#nullable restore
#line 9 "C:\Users\zhoom\OneDrive\Рабочий стол\web2.931801.stepanov.pavel.lab4-master\Backend4\Views\Controls\Radio.cshtml"
Write(Html.RadioButton("myRadiobutton", "Январь"));

#line default
#line hidden
#nullable disable
                WriteLiteral("<label>Январь</label><br />\n    ");
#nullable restore
#line 10 "C:\Users\zhoom\OneDrive\Рабочий стол\web2.931801.stepanov.pavel.lab4-master\Backend4\Views\Controls\Radio.cshtml"
Write(Html.RadioButton("myRadiobutton", "Февраль"));

#line default
#line hidden
#nullable disable
                WriteLiteral("<label>Февраль</label><br />\n    ");
#nullable restore
#line 11 "C:\Users\zhoom\OneDrive\Рабочий стол\web2.931801.stepanov.pavel.lab4-master\Backend4\Views\Controls\Radio.cshtml"
Write(Html.RadioButton("myRadiobutton", "Март"));

#line default
#line hidden
#nullable disable
                WriteLiteral("<label>Март</label><br />\n    ");
#nullable restore
#line 12 "C:\Users\zhoom\OneDrive\Рабочий стол\web2.931801.stepanov.pavel.lab4-master\Backend4\Views\Controls\Radio.cshtml"
Write(Html.RadioButton("myRadiobutton", "Апрель"));

#line default
#line hidden
#nullable disable
                WriteLiteral("<label>Апрель</label><br />\n    ");
#nullable restore
#line 13 "C:\Users\zhoom\OneDrive\Рабочий стол\web2.931801.stepanov.pavel.lab4-master\Backend4\Views\Controls\Radio.cshtml"
Write(Html.RadioButton("myRadiobutton", "Май"));

#line default
#line hidden
#nullable disable
                WriteLiteral("<label>Май</label><br />\n    ");
#nullable restore
#line 14 "C:\Users\zhoom\OneDrive\Рабочий стол\web2.931801.stepanov.pavel.lab4-master\Backend4\Views\Controls\Radio.cshtml"
Write(Html.RadioButton("myRadiobutton", "Июнь"));

#line default
#line hidden
#nullable disable
                WriteLiteral("<label>Июнь</label><br />\n    ");
#nullable restore
#line 15 "C:\Users\zhoom\OneDrive\Рабочий стол\web2.931801.stepanov.pavel.lab4-master\Backend4\Views\Controls\Radio.cshtml"
Write(Html.RadioButton("myRadiobutton", "Июль"));

#line default
#line hidden
#nullable disable
                WriteLiteral("<label>Июль</label><br />\n    ");
#nullable restore
#line 16 "C:\Users\zhoom\OneDrive\Рабочий стол\web2.931801.stepanov.pavel.lab4-master\Backend4\Views\Controls\Radio.cshtml"
Write(Html.RadioButton("myRadiobutton", "Август"));

#line default
#line hidden
#nullable disable
                WriteLiteral("<label>Август</label><br />\n    ");
#nullable restore
#line 17 "C:\Users\zhoom\OneDrive\Рабочий стол\web2.931801.stepanov.pavel.lab4-master\Backend4\Views\Controls\Radio.cshtml"
Write(Html.RadioButton("myRadiobutton", "Сентябрь"));

#line default
#line hidden
#nullable disable
                WriteLiteral("<label>Сентябрь</label><br />\n    ");
#nullable restore
#line 18 "C:\Users\zhoom\OneDrive\Рабочий стол\web2.931801.stepanov.pavel.lab4-master\Backend4\Views\Controls\Radio.cshtml"
Write(Html.RadioButton("myRadiobutton", "Октябрь"));

#line default
#line hidden
#nullable disable
                WriteLiteral("<label>Октябрь</label><br />\n    ");
#nullable restore
#line 19 "C:\Users\zhoom\OneDrive\Рабочий стол\web2.931801.stepanov.pavel.lab4-master\Backend4\Views\Controls\Radio.cshtml"
Write(Html.RadioButton("myRadiobutton", "Ноябрь"));

#line default
#line hidden
#nullable disable
                WriteLiteral("<label>Ноябрь</label><br />\n    ");
#nullable restore
#line 20 "C:\Users\zhoom\OneDrive\Рабочий стол\web2.931801.stepanov.pavel.lab4-master\Backend4\Views\Controls\Radio.cshtml"
Write(Html.RadioButton("myRadiobutton", "Декабрь"));

#line default
#line hidden
#nullable disable
                WriteLiteral("<label>Декабрь</label><br />\n    <p>\n        <input type=\"submit\" class=\"btn btn-outline-dark\"  value=\"Submit\" />\n    </p>\n");
            }
            );
            __Microsoft_AspNetCore_Mvc_TagHelpers_FormTagHelper = CreateTagHelper<global::Microsoft.AspNetCore.Mvc.TagHelpers.FormTagHelper>();
            __tagHelperExecutionContext.Add(__Microsoft_AspNetCore_Mvc_TagHelpers_FormTagHelper);
            __Microsoft_AspNetCore_Mvc_TagHelpers_RenderAtEndOfFormTagHelper = CreateTagHelper<global::Microsoft.AspNetCore.Mvc.TagHelpers.RenderAtEndOfFormTagHelper>();
            __tagHelperExecutionContext.Add(__Microsoft_AspNetCore_Mvc_TagHelpers_RenderAtEndOfFormTagHelper);
            __Microsoft_AspNetCore_Mvc_TagHelpers_FormTagHelper.Method = (string)__tagHelperAttribute_0.Value;
            __tagHelperExecutionContext.AddTagHelperAttribute(__tagHelperAttribute_0);
            await __tagHelperRunner.RunAsync(__tagHelperExecutionContext);
            if (!__tagHelperExecutionContext.Output.IsContentModified)
            {
                await __tagHelperExecutionContext.SetOutputContentAsync();
            }
            Write(__tagHelperExecutionContext.Output);
            __tagHelperExecutionContext = __tagHelperScopeManager.End();
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
