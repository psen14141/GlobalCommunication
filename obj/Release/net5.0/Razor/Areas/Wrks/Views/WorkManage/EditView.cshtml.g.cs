#pragma checksum "C:\Bench\Daiki\ProstyleTechnology\17. Project From Japan\02.git\Project\GloableCommunication\Areas\Wrks\Views\WorkManage\EditView.cshtml" "{ff1816ec-aa5e-4d10-87f7-6f4963833460}" "c6b769b108b2b62bad7ce029dd7eb6bccb4bc31a"
// <auto-generated/>
#pragma warning disable 1591
[assembly: global::Microsoft.AspNetCore.Razor.Hosting.RazorCompiledItemAttribute(typeof(AspNetCore.Areas_Wrks_Views_WorkManage_EditView), @"mvc.1.0.view", @"/Areas/Wrks/Views/WorkManage/EditView.cshtml")]
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
    [global::Microsoft.AspNetCore.Razor.Hosting.RazorSourceChecksumAttribute(@"SHA1", @"c6b769b108b2b62bad7ce029dd7eb6bccb4bc31a", @"/Areas/Wrks/Views/WorkManage/EditView.cshtml")]
    public class Areas_Wrks_Views_WorkManage_EditView : global::Microsoft.AspNetCore.Mvc.Razor.RazorPage<GloableCommunication.Areas.Wrks.Models.ViewModels.WorksViewModel>
    {
        #pragma warning disable 1998
        public async override global::System.Threading.Tasks.Task ExecuteAsync()
        {
            WriteLiteral("\r\n");
            WriteLiteral("\r\n");
            WriteLiteral("\r\n");
            WriteLiteral("<div class=\"row\">\r\n    <div class=\"col-md-12\">\r\n        <form method=\"post\" action=\"/Wrks/WorkManage/SaveNewData\">\r\n            <div asp-validation-summary=\"ModelOnly\" class=\"text-danger\"></div>\r\n            <div class=\"form-group\">\r\n");
            WriteLiteral("                <input name=\"WorkId\"\r\n                       type=\"hidden\" id=\"WorkId\"");
            BeginWriteAttribute("value", " value=\"", 770, "\"", 791, 1);
#nullable restore
#line 22 "C:\Bench\Daiki\ProstyleTechnology\17. Project From Japan\02.git\Project\GloableCommunication\Areas\Wrks\Views\WorkManage\EditView.cshtml"
WriteAttributeValue("", 778, Model.WorkId, 778, 13, false);

#line default
#line hidden
#nullable disable
            EndWriteAttribute();
            WriteLiteral(" />\r\n            </div>\r\n");
            WriteLiteral(@"
            <div class=""form-group "">
                <div class=""row"">
                    <div class=""col-md-4"">
                        <label asp-for=""BiuldingLocationRackId"" class=""control-label"">Occupation</label>

                    </div>
                    <div class=""col-md-8"">
                        <select name=""OccupationId"" placeholder=""Occupation"" id=""OccupationId"" class=""form-control"">
");
#nullable restore
#line 38 "C:\Bench\Daiki\ProstyleTechnology\17. Project From Japan\02.git\Project\GloableCommunication\Areas\Wrks\Views\WorkManage\EditView.cshtml"
                             foreach (var buildingLocationRack in Model.occupations)
                            {
                                if (buildingLocationRack.OccupationId == Model.OccupationId)
                                {

#line default
#line hidden
#nullable disable
            WriteLiteral("                                    <option selected");
            BeginWriteAttribute("value", " value=\"", 1833, "\"", 1875, 1);
#nullable restore
#line 42 "C:\Bench\Daiki\ProstyleTechnology\17. Project From Japan\02.git\Project\GloableCommunication\Areas\Wrks\Views\WorkManage\EditView.cshtml"
WriteAttributeValue("", 1841, buildingLocationRack.OccupationId, 1841, 34, false);

#line default
#line hidden
#nullable disable
            EndWriteAttribute();
            WriteLiteral(">\r\n                                        ");
#nullable restore
#line 43 "C:\Bench\Daiki\ProstyleTechnology\17. Project From Japan\02.git\Project\GloableCommunication\Areas\Wrks\Views\WorkManage\EditView.cshtml"
                                   Write(buildingLocationRack.OccupationName);

#line default
#line hidden
#nullable disable
            WriteLiteral("\r\n                                    </option>\r\n");
#nullable restore
#line 45 "C:\Bench\Daiki\ProstyleTechnology\17. Project From Japan\02.git\Project\GloableCommunication\Areas\Wrks\Views\WorkManage\EditView.cshtml"
                                }
                                else
                                {

#line default
#line hidden
#nullable disable
            WriteLiteral("                                    <option selected");
            BeginWriteAttribute("value", " value=\"", 2164, "\"", 2206, 1);
#nullable restore
#line 48 "C:\Bench\Daiki\ProstyleTechnology\17. Project From Japan\02.git\Project\GloableCommunication\Areas\Wrks\Views\WorkManage\EditView.cshtml"
WriteAttributeValue("", 2172, buildingLocationRack.OccupationId, 2172, 34, false);

#line default
#line hidden
#nullable disable
            EndWriteAttribute();
            WriteLiteral(">\r\n                                        ");
#nullable restore
#line 49 "C:\Bench\Daiki\ProstyleTechnology\17. Project From Japan\02.git\Project\GloableCommunication\Areas\Wrks\Views\WorkManage\EditView.cshtml"
                                   Write(buildingLocationRack.OccupationName);

#line default
#line hidden
#nullable disable
            WriteLiteral("\r\n                                    </option>\r\n");
#nullable restore
#line 51 "C:\Bench\Daiki\ProstyleTechnology\17. Project From Japan\02.git\Project\GloableCommunication\Areas\Wrks\Views\WorkManage\EditView.cshtml"
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
                        <label asp-for=""WorkName"" class=""control-label"">WorkName</label>
                    </div>
                    <div class=""col-md-8"">
                        <input name=""WorkName"" class=""form-control""
                               placeholder=""WorkName"" type=""text"" id=""WorkName""");
            BeginWriteAttribute("value", " value=\"", 2938, "\"", 2961, 1);
#nullable restore
#line 65 "C:\Bench\Daiki\ProstyleTechnology\17. Project From Japan\02.git\Project\GloableCommunication\Areas\Wrks\Views\WorkManage\EditView.cshtml"
WriteAttributeValue("", 2946, Model.WorkName, 2946, 15, false);

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
                        <label asp-for=""VerifcationName"" class=""control-label"">VerifcationName</label>
                    </div>
                    <div class=""col-md-8"">
                        <input name=""VerifcationName"" class=""form-control""
                               placeholder=""VerifcationName"" type=""text"" id=""VerifcationName""");
            BeginWriteAttribute("value", " value=\"", 3529, "\"", 3559, 1);
#nullable restore
#line 82 "C:\Bench\Daiki\ProstyleTechnology\17. Project From Japan\02.git\Project\GloableCommunication\Areas\Wrks\Views\WorkManage\EditView.cshtml"
WriteAttributeValue("", 3537, Model.VerifcationName, 3537, 22, false);

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
            alert(""??????????????????????????????????????????"" + maxLength + ""??????????????????????????????????????????"");
        }
    })
</script>

");
            DefineSection("Scripts", async() => {
                WriteLiteral("\r\n");
#nullable restore
#line 102 "C:\Bench\Daiki\ProstyleTechnology\17. Project From Japan\02.git\Project\GloableCommunication\Areas\Wrks\Views\WorkManage\EditView.cshtml"
      await Html.RenderPartialAsync("_ValidationScriptsPartial");

#line default
#line hidden
#nullable disable
            }
            );
            WriteLiteral("\r\n");
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
