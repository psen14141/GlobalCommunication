#pragma checksum "C:\Bench\Daiki\ProstyleTechnology\17. Project From Japan\02.git\Project\GloableCommunication\Areas\MasterMaintainance\Views\UserId\AddorEditView.cshtml" "{ff1816ec-aa5e-4d10-87f7-6f4963833460}" "8a124135d0b8e7805492702ac5484e82587e8e66"
// <auto-generated/>
#pragma warning disable 1591
[assembly: global::Microsoft.AspNetCore.Razor.Hosting.RazorCompiledItemAttribute(typeof(AspNetCore.Areas_MasterMaintainance_Views_UserId_AddorEditView), @"mvc.1.0.view", @"/Areas/MasterMaintainance/Views/UserId/AddorEditView.cshtml")]
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
    [global::Microsoft.AspNetCore.Razor.Hosting.RazorSourceChecksumAttribute(@"SHA1", @"8a124135d0b8e7805492702ac5484e82587e8e66", @"/Areas/MasterMaintainance/Views/UserId/AddorEditView.cshtml")]
    public class Areas_MasterMaintainance_Views_UserId_AddorEditView : global::Microsoft.AspNetCore.Mvc.Razor.RazorPage<GloableCommunication.Areas.MasterMaintainance.Models.ViewModels.UserIdViewModel>
    {
        #pragma warning disable 1998
        public async override global::System.Threading.Tasks.Task ExecuteAsync()
        {
#nullable restore
#line 2 "C:\Bench\Daiki\ProstyleTechnology\17. Project From Japan\02.git\Project\GloableCommunication\Areas\MasterMaintainance\Views\UserId\AddorEditView.cshtml"
  
    ViewData["Title"] = "AddorEditView";
    Layout = null;

#line default
#line hidden
#nullable disable
            WriteLiteral("\r\n<h2>\r\n    ユーザーID登録\r\n</h2>\r\n<hr />\r\n<div class=\"row\">\r\n    <div class=\"col-12\">\r\n        <form class=\"form-horizontal\" method=\"post\"");
            BeginWriteAttribute("action", " action=\"", 290, "\"", 299, 0);
            EndWriteAttribute();
            WriteLiteral(">\r\n            <input type=\"hidden\" name=\"UserId\" id=\"UserId\" class=\"form-control\" />\r\n            <span asp-validation-for=\"UserId\" class=\"text-danger\"></span>\r\n\r\n");
            WriteLiteral(@"
            <div class=""form-group "">
                <div class=""row"">
                    <div class=""col-md-4"">
                        <label asp-for=""UserCode"" class=""control-label"">国　CODE</label>
                    </div>
                    <div class=""col-md-8 align-self-cente input-group-append"">
                        <input name=""UserCode"" id=""UserCode"" class=""form-control"" />
                    </div>
                </div>
            </div>

");
            WriteLiteral(@"
            <div class=""form-group "">
                <div class=""row"">
                    <div class=""col-md-4"">
                        <label asp-for=""Password"" class=""control-label"">パスワード</label>
                    </div>
                    <div class=""col-md-8 align-self-cente input-group-append"">
                        <input name=""Password"" id=""Password"" class=""form-control"" />
                    </div>
                </div>
            </div>

            <div class=""form-group "">
                <div class=""row"">
                    <div class=""col-md-4"">
                        <label asp-for=""InsertDateTime"" class=""control-label"">日付と時刻を挿入</label>
                    </div>
                    <div class=""col-md-8 align-self-cente input-group-append"">
                        <input name=""InsertDateTime"" id=""InsertDateTime"" class=""form-control"" />
                        <span class=""input-group-text"">
                            <i class=""la la-calendar-o""></i>
          ");
            WriteLiteral(@"              </span>
                    </div>
                </div>
            </div>

            <div class=""form-group "">
                <div class=""row"">
                    <div class=""col-md-4"">
                        <label asp-for=""UpdateDateTime"" class=""control-label"">日時の更新</label>
                    </div>
                    <div class=""col-md-8 align-self-cente input-group-append"">
                        <input name=""UpdateDateTime"" id=""UpdateDateTime"" class=""form-control"" />
                        <span class=""input-group-text"">
                            <i class=""la la-calendar-o""></i>
                        </span>
                    </div>
                </div>
            </div>

          
        </form>
    </div>
</div>
<script src=""/assets/js/plugin/datepicker/bootstrap-datetimepicker.min.js""></script>
<script>
    $('#InsertDateTime').datetimepicker({
        format: 'YYYY/MM/DD HH:mm',

    });
    $('#UpdateDateTime').datetimepicker({
     ");
            WriteLiteral("   format: \'YYYY/MM/DD HH:mm\',\r\n    });\r\n\r\n</script>\r\n\r\n<div>\r\n    <a asp-action=\"Index\">Back to List</a>\r\n</div>\r\n\r\n");
            DefineSection("Scripts", async() => {
                WriteLiteral("\r\n");
#nullable restore
#line 100 "C:\Bench\Daiki\ProstyleTechnology\17. Project From Japan\02.git\Project\GloableCommunication\Areas\MasterMaintainance\Views\UserId\AddorEditView.cshtml"
      await Html.RenderPartialAsync("_ValidationScriptsPartial");

#line default
#line hidden
#nullable disable
            }
            );
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
        public global::Microsoft.AspNetCore.Mvc.Rendering.IHtmlHelper<GloableCommunication.Areas.MasterMaintainance.Models.ViewModels.UserIdViewModel> Html { get; private set; }
    }
}
#pragma warning restore 1591
