#pragma checksum "C:\Users\zhoom\OneDrive\Рабочий стол\web2.931801.stepanov.pavel.lab4-master\Backend4\Views\Mockups\SignUp.cshtml" "{ff1816ec-aa5e-4d10-87f7-6f4963833460}" "f9a6a2aa0be7c8a2aac87f97f50787e50caa5c09"
// <auto-generated/>
#pragma warning disable 1591
[assembly: global::Microsoft.AspNetCore.Razor.Hosting.RazorCompiledItemAttribute(typeof(AspNetCore.Views_Mockups_SignUp), @"mvc.1.0.view", @"/Views/Mockups/SignUp.cshtml")]
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
    [global::Microsoft.AspNetCore.Razor.Hosting.RazorSourceChecksumAttribute(@"SHA1", @"f9a6a2aa0be7c8a2aac87f97f50787e50caa5c09", @"/Views/Mockups/SignUp.cshtml")]
    [global::Microsoft.AspNetCore.Razor.Hosting.RazorSourceChecksumAttribute(@"SHA1", @"96619c4a8d13af5dee7982e58002d641c54e06c6", @"/Views/_ViewImports.cshtml")]
    public class Views_Mockups_SignUp : global::Microsoft.AspNetCore.Mvc.Razor.RazorPage<Auth>
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
#line 2 "C:\Users\zhoom\OneDrive\Рабочий стол\web2.931801.stepanov.pavel.lab4-master\Backend4\Views\Mockups\SignUp.cshtml"
  
    ViewData["Title"] = "SignUp";


#line default
#line hidden
#nullable disable
            WriteLiteral("<div class=\"text-left\">\n    <h1 style=\"font-size:35px; color:#333333\">Sign Up</h1>\n</div>\n");
            __tagHelperExecutionContext = __tagHelperScopeManager.Begin("form", global::Microsoft.AspNetCore.Razor.TagHelpers.TagMode.StartTagAndEndTag, "f9a6a2aa0be7c8a2aac87f97f50787e50caa5c093936", async() => {
                WriteLiteral("\n    <b>First name </b><br>\n    <div style=\"margin-top:10px\">");
#nullable restore
#line 11 "C:\Users\zhoom\OneDrive\Рабочий стол\web2.931801.stepanov.pavel.lab4-master\Backend4\Views\Mockups\SignUp.cshtml"
                            Write(Html.EditorFor(p => p.FirstName));

#line default
#line hidden
#nullable disable
                WriteLiteral(" ");
#nullable restore
#line 11 "C:\Users\zhoom\OneDrive\Рабочий стол\web2.931801.stepanov.pavel.lab4-master\Backend4\Views\Mockups\SignUp.cshtml"
                                                              Write(Html.ValidationMessageFor(p => p.FirstName));

#line default
#line hidden
#nullable disable
                WriteLiteral("</div><br>\n    <b style=\"margin-top:10px\">Last name </b><br>\n    <div style=\"margin-top:10px\"> ");
#nullable restore
#line 13 "C:\Users\zhoom\OneDrive\Рабочий стол\web2.931801.stepanov.pavel.lab4-master\Backend4\Views\Mockups\SignUp.cshtml"
                             Write(Html.EditorFor(p => p.LastName));

#line default
#line hidden
#nullable disable
                WriteLiteral(" ");
#nullable restore
#line 13 "C:\Users\zhoom\OneDrive\Рабочий стол\web2.931801.stepanov.pavel.lab4-master\Backend4\Views\Mockups\SignUp.cshtml"
                                                              Write(Html.ValidationMessageFor(p => p.LastName));

#line default
#line hidden
#nullable disable
                WriteLiteral("</div><br>\n    <b style=\"margin-top:10px\">Birthday</b><br>\n    <div style=\"margin-top:10px\">\n        ");
#nullable restore
#line 16 "C:\Users\zhoom\OneDrive\Рабочий стол\web2.931801.stepanov.pavel.lab4-master\Backend4\Views\Mockups\SignUp.cshtml"
   Write(Html.DropDownListFor((p => p.Day), new SelectList(new string[] { "1", "2", "3", "4",
"5", "6", "7", "8", "9", "10", "11", "12","13", "14", "15", "16",
"17", "18", "19", "20", "21", "22", "23", "24", "25", "26", "27", "28", "29", "30", "31"}), new { style = "padding:3px" }));

#line default
#line hidden
#nullable disable
                WriteLiteral("\n        ");
#nullable restore
#line 19 "C:\Users\zhoom\OneDrive\Рабочий стол\web2.931801.stepanov.pavel.lab4-master\Backend4\Views\Mockups\SignUp.cshtml"
   Write(Html.DropDownListFor((p => p.Month), new SelectList(new string[] { "January", "February", "March", "April",
                    "May", "June", "July", "August", "Septemer", "October", "November", "December"}), new { style = "padding:3px" }));

#line default
#line hidden
#nullable disable
                WriteLiteral("\n        ");
#nullable restore
#line 21 "C:\Users\zhoom\OneDrive\Рабочий стол\web2.931801.stepanov.pavel.lab4-master\Backend4\Views\Mockups\SignUp.cshtml"
   Write(Html.DropDownListFor((p => p.Year), new SelectList(new string[] { "1900", "1901", "1902", "1903",
                    "1904","1905", "1906", "1907", "1908", "1909", "1910", "1911", "1912","1913", "1914", "1915", "1916",
                    "1917", "1918", "1919", "1920", "1921", "1922", "1923", "1924", "1925", "1926", "1927", "1928", "1929", "1930", "1931","1932", "1933", "1934", "1935",
                     "1936", "1937", "1938", "1939", "1940", "1941", "1942","1943", "1944", "1945", "1946",
                    "1947", "1948", "1949", "1950", "1951", "1952", "1953", "1954", "1955", "1956", "1957", "1958", "1959", "1960", "1961", "1962", "1963",
                    "1964","1965", "1966", "1967", "1968", "1969", "1970", "1971", "1972","1973", "1974", "1975", "1976",
                    "1977", "1978", "1979", "1980", "1981", "1982", "1983", "1984", "1985", "1986", "1987", "1988", "1989", "1990", "1991","1992", "1993", "1994", "1995",
                     "1996", "1997", "1998", "1999", "2000", "2001", "2002","2003", "2004", "2005", "2006",
                    "2007", "2008", "2009", "2010", "2011", "2012", "2013", "2014", "2015", "2016", "2017", "2018", "2019", "2020", "2021"}), new { style = "padding:3px" }));

#line default
#line hidden
#nullable disable
                WriteLiteral("\n    </div><br>\n    <b style=\"margin-top:10px\">Gender</b> ");
#nullable restore
#line 31 "C:\Users\zhoom\OneDrive\Рабочий стол\web2.931801.stepanov.pavel.lab4-master\Backend4\Views\Mockups\SignUp.cshtml"
                                     Write(Html.ValidationMessageFor(p => p.Gender));

#line default
#line hidden
#nullable disable
                WriteLiteral("<br>\n    ");
#nullable restore
#line 32 "C:\Users\zhoom\OneDrive\Рабочий стол\web2.931801.stepanov.pavel.lab4-master\Backend4\Views\Mockups\SignUp.cshtml"
Write(Html.RadioButtonFor((p => p.Gender), "Male"));

#line default
#line hidden
#nullable disable
                WriteLiteral("Male<br>\n    ");
#nullable restore
#line 33 "C:\Users\zhoom\OneDrive\Рабочий стол\web2.931801.stepanov.pavel.lab4-master\Backend4\Views\Mockups\SignUp.cshtml"
Write(Html.RadioButtonFor((p => p.Gender), "Female"));

#line default
#line hidden
#nullable disable
                WriteLiteral("Female<br>\n    <input type=\"submit\" value=\"Sign Up\" class=\"btn btn-primary mt-3 pr-3 pl-3\">\n");
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
        public global::Microsoft.AspNetCore.Mvc.Rendering.IHtmlHelper<Auth> Html { get; private set; }
    }
}
#pragma warning restore 1591
