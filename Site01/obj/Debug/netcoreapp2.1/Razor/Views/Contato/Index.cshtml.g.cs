#pragma checksum "C:\Cursos\UdemyASP\1_Elias_BasicoMVC\Projeto01\Site01\Views\Contato\Index.cshtml" "{ff1816ec-aa5e-4d10-87f7-6f4963833460}" "826b3d967fce541061ec614cca489c3b19a35153"
// <auto-generated/>
#pragma warning disable 1591
[assembly: global::Microsoft.AspNetCore.Razor.Hosting.RazorCompiledItemAttribute(typeof(AspNetCore.Views_Contato_Index), @"mvc.1.0.view", @"/Views/Contato/Index.cshtml")]
[assembly:global::Microsoft.AspNetCore.Mvc.Razor.Compilation.RazorViewAttribute(@"/Views/Contato/Index.cshtml", typeof(AspNetCore.Views_Contato_Index))]
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
    [global::Microsoft.AspNetCore.Razor.Hosting.RazorSourceChecksumAttribute(@"SHA1", @"826b3d967fce541061ec614cca489c3b19a35153", @"/Views/Contato/Index.cshtml")]
    public class Views_Contato_Index : global::Microsoft.AspNetCore.Mvc.Razor.RazorPage<dynamic>
    {
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
        private global::Microsoft.AspNetCore.Mvc.Razor.TagHelpers.BodyTagHelper __Microsoft_AspNetCore_Mvc_Razor_TagHelpers_BodyTagHelper;
        #pragma warning disable 1998
        public async override global::System.Threading.Tasks.Task ExecuteAsync()
        {
#line 1 "C:\Cursos\UdemyASP\1_Elias_BasicoMVC\Projeto01\Site01\Views\Contato\Index.cshtml"
   
    Layout = null;

#line default
#line hidden
            BeginContext(28, 29, true);
            WriteLiteral("\r\n<!DOCTYPE html>\r\n\r\n<html>\r\n");
            EndContext();
            BeginContext(57, 316, false);
            __tagHelperExecutionContext = __tagHelperScopeManager.Begin("head", global::Microsoft.AspNetCore.Razor.TagHelpers.TagMode.StartTagAndEndTag, "89afed74876843dc8d3e7fb989ca4f62", async() => {
                BeginContext(63, 303, true);
                WriteLiteral(@"
    <meta name=""viewport"" content=""width=device-width"" />
    <title>Index</title>
    <link href=""https://cdn.jsdelivr.net/npm/bootstrap@5.0.2/dist/css/bootstrap.min.css"" rel=""stylesheet"" integrity=""sha384-EVSTQN3/azprG1Anm3QDgpJLIm9Nao0Yz1ztcQTwFspd3yD65VohhpuuCOmLASjC"" crossorigin=""anonymous"">
");
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
            BeginContext(373, 4, true);
            WriteLiteral("\r\n\r\n");
            EndContext();
            BeginContext(377, 1453, false);
            __tagHelperExecutionContext = __tagHelperScopeManager.Begin("body", global::Microsoft.AspNetCore.Razor.TagHelpers.TagMode.StartTagAndEndTag, "15ac14b54b1543e38b0f2f27910b7e93", async() => {
                BeginContext(383, 228, true);
                WriteLiteral("\r\n    <div class=\"container\">\r\n\r\n        <form method=\"post\" action=\"/contato/recebercontato\">\r\n            <div class=\"form-group\">\r\n                <label for=\"nome\">Nome</label>\r\n                <input type=\"text\" name=\"nome\"");
                EndContext();
                BeginWriteAttribute("value", " value=\"", 611, "\"", 640, 1);
#line 20 "C:\Cursos\UdemyASP\1_Elias_BasicoMVC\Projeto01\Site01\Views\Contato\Index.cshtml"
WriteAttributeValue("", 619, ViewBag.Contato.Nome, 619, 21, false);

#line default
#line hidden
                EndWriteAttribute();
                BeginContext(641, 82, true);
                WriteLiteral(" class=\"form-control\" id=\"nome\" placeholder=\"Digite o seu nome\">\r\n                ");
                EndContext();
                BeginContext(724, 30, false);
#line 21 "C:\Cursos\UdemyASP\1_Elias_BasicoMVC\Projeto01\Site01\Views\Contato\Index.cshtml"
           Write(Html.ValidationMessage("nome"));

#line default
#line hidden
                EndContext();
                BeginContext(754, 160, true);
                WriteLiteral("\r\n            </div>\r\n\r\n            <div class=\"form-group\">\r\n                <label for=\"email\">E-mail</label>\r\n                <input type=\"text\" name=\"email\"");
                EndContext();
                BeginWriteAttribute("value", " value=\"", 914, "\"", 944, 1);
#line 26 "C:\Cursos\UdemyASP\1_Elias_BasicoMVC\Projeto01\Site01\Views\Contato\Index.cshtml"
WriteAttributeValue("", 922, ViewBag.Contato.Email, 922, 22, false);

#line default
#line hidden
                EndWriteAttribute();
                BeginContext(945, 85, true);
                WriteLiteral(" class=\"form-control\" id=\"email\" placeholder=\"Digite o seu e-mail\">\r\n                ");
                EndContext();
                BeginContext(1031, 31, false);
#line 27 "C:\Cursos\UdemyASP\1_Elias_BasicoMVC\Projeto01\Site01\Views\Contato\Index.cshtml"
           Write(Html.ValidationMessage("email"));

#line default
#line hidden
                EndContext();
                BeginContext(1062, 165, true);
                WriteLiteral("\r\n            </div>\r\n\r\n            <div class=\"form-group\">\r\n                <label for=\"assunto\">Assunto</label>\r\n                <input type=\"text\" name=\"assunto\"");
                EndContext();
                BeginWriteAttribute("value", " value=\"", 1227, "\"", 1259, 1);
#line 32 "C:\Cursos\UdemyASP\1_Elias_BasicoMVC\Projeto01\Site01\Views\Contato\Index.cshtml"
WriteAttributeValue("", 1235, ViewBag.Contato.Assunto, 1235, 24, false);

#line default
#line hidden
                EndWriteAttribute();
                BeginContext(1260, 84, true);
                WriteLiteral(" class=\"form-control\" id=\"assunto\" placeholder=\"Digite o assunto\">\r\n                ");
                EndContext();
                BeginContext(1345, 33, false);
#line 33 "C:\Cursos\UdemyASP\1_Elias_BasicoMVC\Projeto01\Site01\Views\Contato\Index.cshtml"
           Write(Html.ValidationMessage("assunto"));

#line default
#line hidden
                EndContext();
                BeginContext(1378, 195, true);
                WriteLiteral("\r\n            </div>\r\n\r\n            <div class=\"form-group\">\r\n                <label for=\"mensagem\">Mensagem</label>\r\n                <textarea name=\"mensagem\" class=\"form-control\" id=\"mensagem\">");
                EndContext();
                BeginContext(1574, 24, false);
#line 38 "C:\Cursos\UdemyASP\1_Elias_BasicoMVC\Projeto01\Site01\Views\Contato\Index.cshtml"
                                                                        Write(ViewBag.Contato.Mensagem);

#line default
#line hidden
                EndContext();
                BeginContext(1598, 29, true);
                WriteLiteral("</textarea>\r\n                ");
                EndContext();
                BeginContext(1628, 34, false);
#line 39 "C:\Cursos\UdemyASP\1_Elias_BasicoMVC\Projeto01\Site01\Views\Contato\Index.cshtml"
           Write(Html.ValidationMessage("mensagem"));

#line default
#line hidden
                EndContext();
                BeginContext(1662, 130, true);
                WriteLiteral("\r\n            </div>\r\n\r\n            <button type=\"submit\" class=\"btn btn-primary\">Enviar</button>\r\n\r\n        </form>\r\n\r\n\r\n        ");
                EndContext();
                BeginContext(1793, 16, false);
#line 47 "C:\Cursos\UdemyASP\1_Elias_BasicoMVC\Projeto01\Site01\Views\Contato\Index.cshtml"
   Write(ViewBag.Mensagem);

#line default
#line hidden
                EndContext();
                BeginContext(1809, 14, true);
                WriteLiteral("\r\n    </div>\r\n");
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
            BeginContext(1830, 9, true);
            WriteLiteral("\r\n</html>");
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
