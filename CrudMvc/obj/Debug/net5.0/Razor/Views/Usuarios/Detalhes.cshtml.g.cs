#pragma checksum "D:\YouTube\CrudAspNetCore\CrudMvc\CrudMvc\Views\Usuarios\Detalhes.cshtml" "{8829d00f-11b8-4213-878b-770e8597ac16}" "65f0c48566cbcd3b3a7519ff5ae4d3163f1fa214b3d395880b33bb43c67d9e69"
// <auto-generated/>
#pragma warning disable 1591
[assembly: global::Microsoft.AspNetCore.Razor.Hosting.RazorCompiledItemAttribute(typeof(AspNetCore.Views_Usuarios_Detalhes), @"mvc.1.0.view", @"/Views/Usuarios/Detalhes.cshtml")]
namespace AspNetCore
{
    #line hidden
    using global::System;
    using global::System.Collections.Generic;
    using global::System.Linq;
    using global::System.Threading.Tasks;
    using global::Microsoft.AspNetCore.Mvc;
    using global::Microsoft.AspNetCore.Mvc.Rendering;
    using global::Microsoft.AspNetCore.Mvc.ViewFeatures;
#nullable restore
#line 1 "D:\YouTube\CrudAspNetCore\CrudMvc\CrudMvc\Views\_ViewImports.cshtml"
using CrudMvc;

#line default
#line hidden
#nullable disable
#nullable restore
#line 2 "D:\YouTube\CrudAspNetCore\CrudMvc\CrudMvc\Views\_ViewImports.cshtml"
using CrudMvc.Models;

#line default
#line hidden
#nullable disable
    [global::Microsoft.AspNetCore.Razor.Hosting.RazorSourceChecksumAttribute(@"Sha256", @"65f0c48566cbcd3b3a7519ff5ae4d3163f1fa214b3d395880b33bb43c67d9e69", @"/Views/Usuarios/Detalhes.cshtml")]
    [global::Microsoft.AspNetCore.Razor.Hosting.RazorSourceChecksumAttribute(@"Sha256", @"a5e3e86d41ac3289bc877607a73b2efedeae16df931c9acd99ea2ba025b4b8b9", @"/Views/_ViewImports.cshtml")]
    #nullable restore
    public class Views_Usuarios_Detalhes : global::Microsoft.AspNetCore.Mvc.Razor.RazorPage<CrudMvc.Models.Entidades.Usuario>
    #nullable disable
    {
        private static readonly global::Microsoft.AspNetCore.Razor.TagHelpers.TagHelperAttribute __tagHelperAttribute_0 = new global::Microsoft.AspNetCore.Razor.TagHelpers.TagHelperAttribute("asp-action", "Listar", global::Microsoft.AspNetCore.Razor.TagHelpers.HtmlAttributeValueStyle.DoubleQuotes);
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
        private global::Microsoft.AspNetCore.Mvc.TagHelpers.AnchorTagHelper __Microsoft_AspNetCore_Mvc_TagHelpers_AnchorTagHelper;
        #pragma warning disable 1998
        public async override global::System.Threading.Tasks.Task ExecuteAsync()
        {
            WriteLiteral("\r\n");
#nullable restore
#line 3 "D:\YouTube\CrudAspNetCore\CrudMvc\CrudMvc\Views\Usuarios\Detalhes.cshtml"
  
    ViewData["Title"] = "Detalhes";

#line default
#line hidden
#nullable disable
            WriteLiteral("\r\n<h1>Detalhes do Usuário</h1>\r\n\r\n<div>\r\n    <h4>Usuario</h4>\r\n    <hr />\r\n    <dl class=\"row\">\r\n        <dt class=\"col-sm-2\">\r\n            ");
#nullable restore
#line 14 "D:\YouTube\CrudAspNetCore\CrudMvc\CrudMvc\Views\Usuarios\Detalhes.cshtml"
       Write(Html.DisplayNameFor(model => model.NomeUsuario));

#line default
#line hidden
#nullable disable
            WriteLiteral("\r\n        </dt>\r\n        <dd class=\"col-sm-10\">\r\n            ");
#nullable restore
#line 17 "D:\YouTube\CrudAspNetCore\CrudMvc\CrudMvc\Views\Usuarios\Detalhes.cshtml"
       Write(Html.DisplayFor(model => model.NomeUsuario));

#line default
#line hidden
#nullable disable
            WriteLiteral("\r\n        </dd>\r\n        <dt class=\"col-sm-2\">\r\n            ");
#nullable restore
#line 20 "D:\YouTube\CrudAspNetCore\CrudMvc\CrudMvc\Views\Usuarios\Detalhes.cshtml"
       Write(Html.DisplayNameFor(model => model.Idade));

#line default
#line hidden
#nullable disable
            WriteLiteral("\r\n        </dt>\r\n        <dd class=\"col-sm-10\">\r\n            ");
#nullable restore
#line 23 "D:\YouTube\CrudAspNetCore\CrudMvc\CrudMvc\Views\Usuarios\Detalhes.cshtml"
       Write(Html.DisplayFor(model => model.Idade));

#line default
#line hidden
#nullable disable
            WriteLiteral("\r\n        </dd>\r\n        <dt class=\"col-sm-2\">\r\n            ");
#nullable restore
#line 26 "D:\YouTube\CrudAspNetCore\CrudMvc\CrudMvc\Views\Usuarios\Detalhes.cshtml"
       Write(Html.DisplayNameFor(model => model.TipoUsuario));

#line default
#line hidden
#nullable disable
            WriteLiteral("\r\n        </dt>\r\n        <dd class=\"col-sm-10\">\r\n");
#nullable restore
#line 29 "D:\YouTube\CrudAspNetCore\CrudMvc\CrudMvc\Views\Usuarios\Detalhes.cshtml"
             if (Model.TipoUsuario == 1)
            {

#line default
#line hidden
#nullable disable
            WriteLiteral("                <label>Administrador</label>\r\n");
#nullable restore
#line 32 "D:\YouTube\CrudAspNetCore\CrudMvc\CrudMvc\Views\Usuarios\Detalhes.cshtml"
            }
            else if (Model.TipoUsuario == 2)
            {

#line default
#line hidden
#nullable disable
            WriteLiteral("                <label>Técnico</label>\r\n");
#nullable restore
#line 36 "D:\YouTube\CrudAspNetCore\CrudMvc\CrudMvc\Views\Usuarios\Detalhes.cshtml"
            }
            else if (Model.TipoUsuario == 3)
            {

#line default
#line hidden
#nullable disable
            WriteLiteral("                <label>Usuário Normal</label>\r\n");
#nullable restore
#line 40 "D:\YouTube\CrudAspNetCore\CrudMvc\CrudMvc\Views\Usuarios\Detalhes.cshtml"
            }

#line default
#line hidden
#nullable disable
            WriteLiteral("        </dd>\r\n    </dl>\r\n</div>\r\n<div>\r\n    ");
#nullable restore
#line 45 "D:\YouTube\CrudAspNetCore\CrudMvc\CrudMvc\Views\Usuarios\Detalhes.cshtml"
Write(Html.ActionLink("Editar", "Editar", new { id = Model.Id }));

#line default
#line hidden
#nullable disable
            WriteLiteral(" |\r\n    ");
            __tagHelperExecutionContext = __tagHelperScopeManager.Begin("a", global::Microsoft.AspNetCore.Razor.TagHelpers.TagMode.StartTagAndEndTag, "65f0c48566cbcd3b3a7519ff5ae4d3163f1fa214b3d395880b33bb43c67d9e696918", async() => {
                WriteLiteral("Voltar para lista");
            }
            );
            __Microsoft_AspNetCore_Mvc_TagHelpers_AnchorTagHelper = CreateTagHelper<global::Microsoft.AspNetCore.Mvc.TagHelpers.AnchorTagHelper>();
            __tagHelperExecutionContext.Add(__Microsoft_AspNetCore_Mvc_TagHelpers_AnchorTagHelper);
            __Microsoft_AspNetCore_Mvc_TagHelpers_AnchorTagHelper.Action = (string)__tagHelperAttribute_0.Value;
            __tagHelperExecutionContext.AddTagHelperAttribute(__tagHelperAttribute_0);
            await __tagHelperRunner.RunAsync(__tagHelperExecutionContext);
            if (!__tagHelperExecutionContext.Output.IsContentModified)
            {
                await __tagHelperExecutionContext.SetOutputContentAsync();
            }
            Write(__tagHelperExecutionContext.Output);
            __tagHelperExecutionContext = __tagHelperScopeManager.End();
            WriteLiteral("\r\n</div>\r\n");
        }
        #pragma warning restore 1998
        #nullable restore
        [global::Microsoft.AspNetCore.Mvc.Razor.Internal.RazorInjectAttribute]
        public global::Microsoft.AspNetCore.Mvc.ViewFeatures.IModelExpressionProvider ModelExpressionProvider { get; private set; } = default!;
        #nullable disable
        #nullable restore
        [global::Microsoft.AspNetCore.Mvc.Razor.Internal.RazorInjectAttribute]
        public global::Microsoft.AspNetCore.Mvc.IUrlHelper Url { get; private set; } = default!;
        #nullable disable
        #nullable restore
        [global::Microsoft.AspNetCore.Mvc.Razor.Internal.RazorInjectAttribute]
        public global::Microsoft.AspNetCore.Mvc.IViewComponentHelper Component { get; private set; } = default!;
        #nullable disable
        #nullable restore
        [global::Microsoft.AspNetCore.Mvc.Razor.Internal.RazorInjectAttribute]
        public global::Microsoft.AspNetCore.Mvc.Rendering.IJsonHelper Json { get; private set; } = default!;
        #nullable disable
        #nullable restore
        [global::Microsoft.AspNetCore.Mvc.Razor.Internal.RazorInjectAttribute]
        public global::Microsoft.AspNetCore.Mvc.Rendering.IHtmlHelper<CrudMvc.Models.Entidades.Usuario> Html { get; private set; } = default!;
        #nullable disable
    }
}
#pragma warning restore 1591
