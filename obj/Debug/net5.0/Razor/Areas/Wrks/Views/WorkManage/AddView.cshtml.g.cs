#pragma checksum "D:\ProstyleTechnology\Project\GloableCommunication\Areas\Wrks\Views\WorkManage\AddView.cshtml" "{ff1816ec-aa5e-4d10-87f7-6f4963833460}" "58a88044cf67cfa976f3f98a62f1217ab386eb84"
// <auto-generated/>
#pragma warning disable 1591
[assembly: global::Microsoft.AspNetCore.Razor.Hosting.RazorCompiledItemAttribute(typeof(AspNetCore.Areas_Wrks_Views_WorkManage_AddView), @"mvc.1.0.view", @"/Areas/Wrks/Views/WorkManage/AddView.cshtml")]
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
    [global::Microsoft.AspNetCore.Razor.Hosting.RazorSourceChecksumAttribute(@"SHA1", @"58a88044cf67cfa976f3f98a62f1217ab386eb84", @"/Areas/Wrks/Views/WorkManage/AddView.cshtml")]
    public class Areas_Wrks_Views_WorkManage_AddView : global::Microsoft.AspNetCore.Mvc.Razor.RazorPage<GloableCommunication.Areas.Wrks.Models.ViewModels.WorksViewModel>
    {
        #pragma warning disable 1998
        public async override global::System.Threading.Tasks.Task ExecuteAsync()
        {
            WriteLiteral("\r\n");
            WriteLiteral("\r\n");
#nullable restore
#line 4 "D:\ProstyleTechnology\Project\GloableCommunication\Areas\Wrks\Views\WorkManage\AddView.cshtml"
  
//ViewData["Title"] = "AddView";
//Layout = "~/Views/Shared/_Layout.cshtml";

#line default
#line hidden
#nullable disable
            WriteLiteral("\r\n");
            WriteLiteral("\r\n");
            WriteLiteral(@"


<style>

    label {
        color: #1b1c20 !important;
        font-size: 13px !important;
    }
</style>
<div class=""row"">
    <div class=""col-md-12"">
        <form method=""post"" action=""/Wrks/WorkManage/SaveNewData"">
            <div asp-validation-summary=""ModelOnly"" class=""text-danger""></div>
            <div class=""form-group"">
");
            WriteLiteral("                <input name=\"WorkId\"\r\n                       type=\"hidden\" id=\"WorkId\"");
            BeginWriteAttribute("value", " value=\"", 872, "\"", 893, 1);
#nullable restore
#line 32 "D:\ProstyleTechnology\Project\GloableCommunication\Areas\Wrks\Views\WorkManage\AddView.cshtml"
WriteAttributeValue("", 880, Model.WorkId, 880, 13, false);

#line default
#line hidden
#nullable disable
            EndWriteAttribute();
            WriteLiteral(" />\r\n            </div>\r\n");
            WriteLiteral(@"
            <div class=""form-group "">
                <div class=""row"">
                    <div class=""col-md-4"">
                        <label asp-for=""BiuldingLocationRackId"" class=""control-label"">職種</label>

                    </div>
                    <div class=""col-md-8"">
                        <select name=""OccupationId"" placeholder=""Occupation"" id=""OccupationId"" class=""form-control"">
");
#nullable restore
#line 48 "D:\ProstyleTechnology\Project\GloableCommunication\Areas\Wrks\Views\WorkManage\AddView.cshtml"
                             foreach (var buildingLocationRack in Model.occupations)
                            {
                                if (buildingLocationRack.OccupationId == Model.OccupationId)
                                {

#line default
#line hidden
#nullable disable
            WriteLiteral("                                    <option selected");
            BeginWriteAttribute("value", " value=\"", 1895, "\"", 1937, 1);
#nullable restore
#line 52 "D:\ProstyleTechnology\Project\GloableCommunication\Areas\Wrks\Views\WorkManage\AddView.cshtml"
WriteAttributeValue("", 1903, buildingLocationRack.OccupationId, 1903, 34, false);

#line default
#line hidden
#nullable disable
            EndWriteAttribute();
            WriteLiteral(">\r\n                                        ");
#nullable restore
#line 53 "D:\ProstyleTechnology\Project\GloableCommunication\Areas\Wrks\Views\WorkManage\AddView.cshtml"
                                   Write(buildingLocationRack.OccupationName);

#line default
#line hidden
#nullable disable
            WriteLiteral("\r\n                                    </option>\r\n");
#nullable restore
#line 55 "D:\ProstyleTechnology\Project\GloableCommunication\Areas\Wrks\Views\WorkManage\AddView.cshtml"
                                }
                                else
                                {

#line default
#line hidden
#nullable disable
            WriteLiteral("                                    <option selected");
            BeginWriteAttribute("value", " value=\"", 2226, "\"", 2268, 1);
#nullable restore
#line 58 "D:\ProstyleTechnology\Project\GloableCommunication\Areas\Wrks\Views\WorkManage\AddView.cshtml"
WriteAttributeValue("", 2234, buildingLocationRack.OccupationId, 2234, 34, false);

#line default
#line hidden
#nullable disable
            EndWriteAttribute();
            WriteLiteral(">\r\n                                        ");
#nullable restore
#line 59 "D:\ProstyleTechnology\Project\GloableCommunication\Areas\Wrks\Views\WorkManage\AddView.cshtml"
                                   Write(buildingLocationRack.OccupationName);

#line default
#line hidden
#nullable disable
            WriteLiteral("\r\n                                    </option>\r\n");
#nullable restore
#line 61 "D:\ProstyleTechnology\Project\GloableCommunication\Areas\Wrks\Views\WorkManage\AddView.cshtml"
                                }
                            }

#line default
#line hidden
#nullable disable
            WriteLiteral(@"                        </select>
                    </div>
                </div>
            </div>

            <div class=""form-group "">
                <div class=""row"">
                    <div class=""col-md-4"">
                        <label asp-for=""WorkName"" class=""control-label"">作業名</label>
                    </div>
                    <div class=""col-md-8"">
                        <input name=""WorkName"" class=""form-control""
                               placeholder=""WorkName"" type=""text"" id=""WorkName""");
            BeginWriteAttribute("value", " value=\"", 2995, "\"", 3018, 1);
#nullable restore
#line 75 "D:\ProstyleTechnology\Project\GloableCommunication\Areas\Wrks\Views\WorkManage\AddView.cshtml"
WriteAttributeValue("", 3003, Model.WorkName, 3003, 15, false);

#line default
#line hidden
#nullable disable
            EndWriteAttribute();
            WriteLiteral(@" maxlength=""50"" />
                    </div>
                </div>
            </div>






            <div class=""form-group "">
                <div class=""row"">
                    <div class=""col-md-4"">
                        <label asp-for=""VerifcationName"" class=""control-label"">検定名</label>
                    </div>
                    <div class=""col-md-8"">
                        <input name=""VerifcationName"" class=""form-control""
                               placeholder=""VerifcationName"" type=""text"" id=""VerifcationName""");
            BeginWriteAttribute("value", " value=\"", 3574, "\"", 3604, 1);
#nullable restore
#line 92 "D:\ProstyleTechnology\Project\GloableCommunication\Areas\Wrks\Views\WorkManage\AddView.cshtml"
WriteAttributeValue("", 3582, Model.VerifcationName, 3582, 22, false);

#line default
#line hidden
#nullable disable
            EndWriteAttribute();
            WriteLiteral(@" maxlength=""100"" />
                    </div>
                </div>
            </div>

       
        </form>
    </div>
</div>

<script>
    $(""input"").on(""keyup"", function () {
        var maxLength = $(this).attr(""maxlength"");
        if (maxLength == $(this).val().length) {
            alert(""文字数が制限を超えています。"" + maxLength + ""文字未満で入力してください。"");
        }
    })
</script>


");
            DefineSection("Scripts", async() => {
                WriteLiteral("\r\n");
#nullable restore
#line 113 "D:\ProstyleTechnology\Project\GloableCommunication\Areas\Wrks\Views\WorkManage\AddView.cshtml"
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
        public global::Microsoft.AspNetCore.Mvc.Rendering.IHtmlHelper<GloableCommunication.Areas.Wrks.Models.ViewModels.WorksViewModel> Html { get; private set; }
    }
}
#pragma warning restore 1591