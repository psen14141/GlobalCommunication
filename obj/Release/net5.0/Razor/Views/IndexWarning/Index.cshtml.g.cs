#pragma checksum "C:\Bench\Daiki\ProstyleTechnology\17. Project From Japan\02.git\Project\GloableCommunication\Views\IndexWarning\Index.cshtml" "{ff1816ec-aa5e-4d10-87f7-6f4963833460}" "5037c707318791a3b25440865f4568fd8775e81c"
// <auto-generated/>
#pragma warning disable 1591
[assembly: global::Microsoft.AspNetCore.Razor.Hosting.RazorCompiledItemAttribute(typeof(AspNetCore.Views_IndexWarning_Index), @"mvc.1.0.view", @"/Views/IndexWarning/Index.cshtml")]
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
#line 1 "C:\Bench\Daiki\ProstyleTechnology\17. Project From Japan\02.git\Project\GloableCommunication\Views\_ViewImports.cshtml"
using GloableCommunication;

#line default
#line hidden
#nullable disable
#nullable restore
#line 2 "C:\Bench\Daiki\ProstyleTechnology\17. Project From Japan\02.git\Project\GloableCommunication\Views\_ViewImports.cshtml"
using GloableCommunication.Models;

#line default
#line hidden
#nullable disable
    [global::Microsoft.AspNetCore.Razor.Hosting.RazorSourceChecksumAttribute(@"SHA1", @"5037c707318791a3b25440865f4568fd8775e81c", @"/Views/IndexWarning/Index.cshtml")]
    [global::Microsoft.AspNetCore.Razor.Hosting.RazorSourceChecksumAttribute(@"SHA1", @"b5f62707b2b221ab1219262a8c4e2ea9b680bb53", @"/Views/_ViewImports.cshtml")]
    public class Views_IndexWarning_Index : global::Microsoft.AspNetCore.Mvc.Razor.RazorPage<IEnumerable<GloableCommunication.Models.ViewModel.WarningViewModel>>
    {
        private static readonly global::Microsoft.AspNetCore.Razor.TagHelpers.TagHelperAttribute __tagHelperAttribute_0 = new global::Microsoft.AspNetCore.Razor.TagHelpers.TagHelperAttribute("asp-action", "Create", global::Microsoft.AspNetCore.Razor.TagHelpers.HtmlAttributeValueStyle.DoubleQuotes);
        private static readonly global::Microsoft.AspNetCore.Razor.TagHelpers.TagHelperAttribute __tagHelperAttribute_1 = new global::Microsoft.AspNetCore.Razor.TagHelpers.TagHelperAttribute("style", new global::Microsoft.AspNetCore.Html.HtmlString("font-size:15px; padding-left:10px"), global::Microsoft.AspNetCore.Razor.TagHelpers.HtmlAttributeValueStyle.DoubleQuotes);
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
            WriteLiteral("\r\n\r\n\r\n");
            WriteLiteral("\r\n\r\n");
#nullable restore
#line 11 "C:\Bench\Daiki\ProstyleTechnology\17. Project From Japan\02.git\Project\GloableCommunication\Views\IndexWarning\Index.cshtml"
  
    ViewData["Title"] = "IndexWarning";
    Layout = "~/Views/Shared/_Layout.cshtml";

#line default
#line hidden
#nullable disable
            WriteLiteral("\r\n<div class=\"w3-padding w3-white\">\r\n    <div>\r\n        <button class=\"w3-button w3-green\"  onclick=\"location.href = \'/Home/Index\'\";   ><i class=\"fa fa-arrow-left\"></i></button>\r\n");
            WriteLiteral("    </div>\r\n    <div>\r\n        ");
            __tagHelperExecutionContext = __tagHelperScopeManager.Begin("a", global::Microsoft.AspNetCore.Razor.TagHelpers.TagMode.StartTagAndEndTag, "5037c707318791a3b25440865f4568fd8775e81c4646", async() => {
                WriteLiteral("戻る");
            }
            );
            __Microsoft_AspNetCore_Mvc_TagHelpers_AnchorTagHelper = CreateTagHelper<global::Microsoft.AspNetCore.Mvc.TagHelpers.AnchorTagHelper>();
            __tagHelperExecutionContext.Add(__Microsoft_AspNetCore_Mvc_TagHelpers_AnchorTagHelper);
            __Microsoft_AspNetCore_Mvc_TagHelpers_AnchorTagHelper.Action = (string)__tagHelperAttribute_0.Value;
            __tagHelperExecutionContext.AddTagHelperAttribute(__tagHelperAttribute_0);
            __tagHelperExecutionContext.AddHtmlAttribute(__tagHelperAttribute_1);
            await __tagHelperRunner.RunAsync(__tagHelperExecutionContext);
            if (!__tagHelperExecutionContext.Output.IsContentModified)
            {
                await __tagHelperExecutionContext.SetOutputContentAsync();
            }
            Write(__tagHelperExecutionContext.Output);
            __tagHelperExecutionContext = __tagHelperScopeManager.End();
            WriteLiteral("\r\n");
            WriteLiteral("    </div>\r\n</div>\r\n\r\n<h1>提出期限注意</h1>\r\n\r\n<p>\r\n");
            WriteLiteral("</p>\r\n<table class=\"table\">\r\n    <thead>\r\n        <tr>\r\n\r\n            <th>\r\n");
            WriteLiteral("                研修生名\r\n            </th>\r\n            <th>\r\n                会社名\r\n            </th>\r\n            <th>\r\n                期生\r\n            </th>\r\n\r\n            <th>\r\n\r\n");
            WriteLiteral(@"               書類提出、
            </th>
            <th>
                残り日数

            </th>
            <th>
                状況
            </th>
            <th>
                提出済み
            </th>

            <th></th>
        </tr>
    </thead>
    <tbody>
");
#nullable restore
#line 72 "C:\Bench\Daiki\ProstyleTechnology\17. Project From Japan\02.git\Project\GloableCommunication\Views\IndexWarning\Index.cshtml"
         foreach (var item in Model)
        {

#line default
#line hidden
#nullable disable
            WriteLiteral("            <tr");
            BeginWriteAttribute("style", " style=\'", 2135, "\'", 2239, 3);
            WriteAttributeValue("", 2143, "background-color:", 2143, 17, true);
#nullable restore
#line 74 "C:\Bench\Daiki\ProstyleTechnology\17. Project From Japan\02.git\Project\GloableCommunication\Views\IndexWarning\Index.cshtml"
WriteAttributeValue(" ", 2160, item.RemainingDays<30 ? "red" : item.RemainingDays<90 ? "yellow" : "white", 2161, 77, false);

#line default
#line hidden
#nullable disable
            WriteAttributeValue("", 2238, ";", 2238, 1, true);
            EndWriteAttribute();
            WriteLiteral(">\r\n\r\n                <td>\r\n                    ");
#nullable restore
#line 77 "C:\Bench\Daiki\ProstyleTechnology\17. Project From Japan\02.git\Project\GloableCommunication\Views\IndexWarning\Index.cshtml"
               Write(Html.DisplayFor(modelItem => item.TraineeName));

#line default
#line hidden
#nullable disable
            WriteLiteral("\r\n");
            WriteLiteral("                </td>\r\n                <td>\r\n");
            WriteLiteral("                    ");
#nullable restore
#line 83 "C:\Bench\Daiki\ProstyleTechnology\17. Project From Japan\02.git\Project\GloableCommunication\Views\IndexWarning\Index.cshtml"
               Write(Html.DisplayFor(modelItem => item.SendingName));

#line default
#line hidden
#nullable disable
            WriteLiteral("\r\n\r\n");
            WriteLiteral("                </td>\r\n                <td>\r\n");
            WriteLiteral("                    ");
#nullable restore
#line 94 "C:\Bench\Daiki\ProstyleTechnology\17. Project From Japan\02.git\Project\GloableCommunication\Views\IndexWarning\Index.cshtml"
               Write(Html.DisplayFor(modelItem => item.Schlarship));

#line default
#line hidden
#nullable disable
            WriteLiteral("\r\n");
            WriteLiteral("                </td>\r\n\r\n                <td>\r\n");
            WriteLiteral("                    ");
#nullable restore
#line 100 "C:\Bench\Daiki\ProstyleTechnology\17. Project From Japan\02.git\Project\GloableCommunication\Views\IndexWarning\Index.cshtml"
               Write(Html.DisplayFor(modelItem => item.PassportLimit));

#line default
#line hidden
#nullable disable
            WriteLiteral("\r\n");
            WriteLiteral("                </td>\r\n                <td>\r\n\r\n                    ");
#nullable restore
#line 110 "C:\Bench\Daiki\ProstyleTechnology\17. Project From Japan\02.git\Project\GloableCommunication\Views\IndexWarning\Index.cshtml"
               Write(Html.DisplayFor(modelItem => item.RemainingDays));

#line default
#line hidden
#nullable disable
            WriteLiteral("\r\n\r\n                    残り日数\r\n                </td>\r\n                <td>\r\n                    提出期限切れ\r\n                </td>\r\n                <td>\r\n                   <a");
            BeginWriteAttribute("href", " href=\"", 3888, "\"", 3947, 2);
            WriteAttributeValue("", 3895, "/IndexWarning/EditTraineeHistory/?id=", 3895, 37, true);
#nullable restore
#line 118 "C:\Bench\Daiki\ProstyleTechnology\17. Project From Japan\02.git\Project\GloableCommunication\Views\IndexWarning\Index.cshtml"
WriteAttributeValue("", 3932, item.TraineeId, 3932, 15, false);

#line default
#line hidden
#nullable disable
            EndWriteAttribute();
            WriteLiteral(" class=\"btn btn-primary\">提出 </a>\r\n                   \r\n                   \r\n                </td>\r\n\r\n");
            WriteLiteral("            </tr>\r\n");
#nullable restore
#line 130 "C:\Bench\Daiki\ProstyleTechnology\17. Project From Japan\02.git\Project\GloableCommunication\Views\IndexWarning\Index.cshtml"
        }

#line default
#line hidden
#nullable disable
            WriteLiteral("    </tbody>\r\n</table>\r\n\r\n\r\n<script>\r\n    function goBack() {\r\n        window.history.back();\r\n    }\r\n</script>");
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
        public global::Microsoft.AspNetCore.Mvc.Rendering.IHtmlHelper<IEnumerable<GloableCommunication.Models.ViewModel.WarningViewModel>> Html { get; private set; }
    }
}
#pragma warning restore 1591