#pragma checksum "C:\Users\Paul\source\repos\ISA2\Week4\Labor\Views\Authentication\Login.cshtml" "{ff1816ec-aa5e-4d10-87f7-6f4963833460}" "d3361836fbe5643f2b4788eddb5eb40ed1a29fd4"
// <auto-generated/>
#pragma warning disable 1591
[assembly: global::Microsoft.AspNetCore.Razor.Hosting.RazorCompiledItemAttribute(typeof(AspNetCore.Views_Authentication_Login), @"mvc.1.0.view", @"/Views/Authentication/Login.cshtml")]
[assembly:global::Microsoft.AspNetCore.Mvc.Razor.Compilation.RazorViewAttribute(@"/Views/Authentication/Login.cshtml", typeof(AspNetCore.Views_Authentication_Login))]
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
#line 1 "C:\Users\Paul\source\repos\ISA2\Week4\Labor\Views\_ViewImports.cshtml"
using Labor;

#line default
#line hidden
#line 1 "C:\Users\Paul\source\repos\ISA2\Week4\Labor\Views\Authentication\Login.cshtml"
using System.ComponentModel;

#line default
#line hidden
    [global::Microsoft.AspNetCore.Razor.Hosting.RazorSourceChecksumAttribute(@"SHA1", @"d3361836fbe5643f2b4788eddb5eb40ed1a29fd4", @"/Views/Authentication/Login.cshtml")]
    [global::Microsoft.AspNetCore.Razor.Hosting.RazorSourceChecksumAttribute(@"SHA1", @"b2d92f1ae7a93732d767a5347b90327a8713b160", @"/Views/_ViewImports.cshtml")]
    public class Views_Authentication_Login : global::Microsoft.AspNetCore.Mvc.Razor.RazorPage<Core.UserDetails>
    {
        #pragma warning disable 1998
        public async override global::System.Threading.Tasks.Task ExecuteAsync()
        {
#line 3 "C:\Users\Paul\source\repos\ISA2\Week4\Labor\Views\Authentication\Login.cshtml"
  
    ViewBag.Title = "Login";

#line default
#line hidden
            BeginContext(92, 27, true);
            WriteLiteral("<h2>Login</h2>\r\n<div>\r\n    ");
            EndContext();
            BeginContext(120, 69, false);
#line 8 "C:\Users\Paul\source\repos\ISA2\Week4\Labor\Views\Authentication\Login.cshtml"
Write(Html.ValidationMessage("CredentialError", new {style = "color: red"}));

#line default
#line hidden
            EndContext();
            BeginContext(189, 2, true);
            WriteLiteral("\r\n");
            EndContext();
#line 9 "C:\Users\Paul\source\repos\ISA2\Week4\Labor\Views\Authentication\Login.cshtml"
     using (Html.BeginForm("DoLogin", "Authentication", FormMethod.Post))
    {
        

#line default
#line hidden
            BeginContext(282, 30, false);
#line 11 "C:\Users\Paul\source\repos\ISA2\Week4\Labor\Views\Authentication\Login.cshtml"
   Write(Html.LabelFor(c => c.UserName));

#line default
#line hidden
            EndContext();
            BeginContext(323, 32, false);
#line 12 "C:\Users\Paul\source\repos\ISA2\Week4\Labor\Views\Authentication\Login.cshtml"
   Write(Html.TextBoxFor(x => x.UserName));

#line default
#line hidden
            EndContext();
            BeginContext(357, 15, true);
            WriteLiteral("        <br/>\r\n");
            EndContext();
            BeginContext(381, 30, false);
#line 14 "C:\Users\Paul\source\repos\ISA2\Week4\Labor\Views\Authentication\Login.cshtml"
   Write(Html.LabelFor(c => c.Password));

#line default
#line hidden
            EndContext();
            BeginContext(422, 33, false);
#line 15 "C:\Users\Paul\source\repos\ISA2\Week4\Labor\Views\Authentication\Login.cshtml"
   Write(Html.PasswordFor(x => x.Password));

#line default
#line hidden
            EndContext();
            BeginContext(457, 77, true);
            WriteLiteral("        <br/>\r\n        <input type=\"submit\" name=\"BtnSumbit value=\"Login\"/>\r\n");
            EndContext();
#line 18 "C:\Users\Paul\source\repos\ISA2\Week4\Labor\Views\Authentication\Login.cshtml"
    }

#line default
#line hidden
            BeginContext(541, 8, true);
            WriteLiteral("</div>\r\n");
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
        public global::Microsoft.AspNetCore.Mvc.Rendering.IHtmlHelper<Core.UserDetails> Html { get; private set; }
    }
}
#pragma warning restore 1591