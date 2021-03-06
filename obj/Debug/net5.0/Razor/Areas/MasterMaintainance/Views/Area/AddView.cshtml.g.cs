#pragma checksum "D:\ProstyleTechnology\Project\GloableCommunication\Areas\MasterMaintainance\Views\Area\AddView.cshtml" "{ff1816ec-aa5e-4d10-87f7-6f4963833460}" "6d7fa7e4afc1bc27593692d27a7c94923e702b12"
// <auto-generated/>
#pragma warning disable 1591
[assembly: global::Microsoft.AspNetCore.Razor.Hosting.RazorCompiledItemAttribute(typeof(AspNetCore.Areas_MasterMaintainance_Views_Area_AddView), @"mvc.1.0.view", @"/Areas/MasterMaintainance/Views/Area/AddView.cshtml")]
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
    [global::Microsoft.AspNetCore.Razor.Hosting.RazorSourceChecksumAttribute(@"SHA1", @"6d7fa7e4afc1bc27593692d27a7c94923e702b12", @"/Areas/MasterMaintainance/Views/Area/AddView.cshtml")]
    public class Areas_MasterMaintainance_Views_Area_AddView : global::Microsoft.AspNetCore.Mvc.Razor.RazorPage<GloableCommunication.Areas.MasterMaintainance.Models.ViewModels.AreaViewModel>
    {
        #pragma warning disable 1998
        public async override global::System.Threading.Tasks.Task ExecuteAsync()
        {
            WriteLiteral("\r\n");
#nullable restore
#line 3 "D:\ProstyleTechnology\Project\GloableCommunication\Areas\MasterMaintainance\Views\Area\AddView.cshtml"
  
    ViewData["Title"] = "AddView";
    Layout = null;

#line default
#line hidden
#nullable disable
            WriteLiteral(@"
<div class=""w3-container w3-margin-top w3-gray"">
    <h5 style=""text-align:center""><b>地 域 一 覧</b></h5>
</div>
<hr />

<div class=""row"">
    <div class=""col-12"">
        <form method=""post"" action=""/MasterMaintainance/Area/AddView"">
            <input type=""hidden"" name=""AreaId"" id=""AreaId"" class=""form-control""");
            BeginWriteAttribute("value", " value=\"", 472, "\"", 493, 1);
#nullable restore
#line 16 "D:\ProstyleTechnology\Project\GloableCommunication\Areas\MasterMaintainance\Views\Area\AddView.cshtml"
WriteAttributeValue("", 480, Model.AreaId, 480, 13, false);

#line default
#line hidden
#nullable disable
            EndWriteAttribute();
            WriteLiteral(@" />
            <span asp-validation-for=""AreaId"" class=""text-danger""></span>

            <div class=""form-group "">
                <div class=""row"">
                    <div class=""col-md-4""><label asp-for=""AreaCode"" class=""control-label"">地域 CD</label></div>
                    <div class=""col-md-8 align-self-cente input-group-append"">
                        <input name=""AreaCode"" id=""AreaCode"" class=""form-control""");
            BeginWriteAttribute("value", " value=\"", 922, "\"", 945, 1);
#nullable restore
#line 23 "D:\ProstyleTechnology\Project\GloableCommunication\Areas\MasterMaintainance\Views\Area\AddView.cshtml"
WriteAttributeValue("", 930, Model.AreaCode, 930, 15, false);

#line default
#line hidden
#nullable disable
            EndWriteAttribute();
            WriteLiteral(@" readonly />
                    </div>
                </div>
            </div>

            <div class=""form-group "">
                <div class=""row"">
                    <div class=""col-md-4""><label asp-for=""AreaName"" class=""control-label"">地域 名</label></div>
                    <div class=""col-md-8 align-self-cente input-group-append"">
                        <input name=""AreaName"" id=""AreaName"" class=""form-control""");
            BeginWriteAttribute("value", " value=\"", 1379, "\"", 1402, 1);
#nullable restore
#line 32 "D:\ProstyleTechnology\Project\GloableCommunication\Areas\MasterMaintainance\Views\Area\AddView.cshtml"
WriteAttributeValue("", 1387, Model.AreaName, 1387, 15, false);

#line default
#line hidden
#nullable disable
            EndWriteAttribute();
            WriteLiteral(@" />
                    </div>
                </div>
            </div>

            <div class=""form-group "">
                <div class=""row"">
                    <div class=""col-md-4""><label asp-for=""UpdateDateTime"" class=""control-label"">日時の更新</label></div>
                    <div class=""col-md-8 align-self-center"">
                        <input name=""UpdateDateTime"" id=""UpdateDateTime"" class=""form-control""");
            BeginWriteAttribute("value", " value=\"", 1828, "\"", 1857, 1);
#nullable restore
#line 41 "D:\ProstyleTechnology\Project\GloableCommunication\Areas\MasterMaintainance\Views\Area\AddView.cshtml"
WriteAttributeValue("", 1836, Model.UpdateDateTime, 1836, 21, false);

#line default
#line hidden
#nullable disable
            EndWriteAttribute();
            WriteLiteral(@" disabled />
                    </div>
                </div>
            </div>

            <div class=""form-group "">
                <div class=""row"">
                    <div class=""col-md-4""><label asp-for=""InsertDateTime"" class=""control-label"">日付と時刻を挿入</label></div>
                    <div class=""col-md-8 align-self-center"">
                        <input name=""InsertDateTime"" id=""InsertDateTime"" class=""form-control""");
            BeginWriteAttribute("value", " value=\"", 2295, "\"", 2324, 1);
#nullable restore
#line 50 "D:\ProstyleTechnology\Project\GloableCommunication\Areas\MasterMaintainance\Views\Area\AddView.cshtml"
WriteAttributeValue("", 2303, Model.InsertDateTime, 2303, 21, false);

#line default
#line hidden
#nullable disable
            EndWriteAttribute();
            WriteLiteral(@" disabled />
                    </div>
                </div>
            </div>

            <div class=""form-group "">
                <div class=""row"">
                    <div class=""col-md-4""><label asp-for=""CountryId"" class=""control-label"">国</label></div>
                    <div class=""col-md-8"">
                        <select name=""CountryId"" placeholder=""Choose country"" id=""CountryId"" class=""form-control"">
");
#nullable restore
#line 60 "D:\ProstyleTechnology\Project\GloableCommunication\Areas\MasterMaintainance\Views\Area\AddView.cshtml"
                             foreach (var countries in Model.Countries.Where(w => w.IsDeleteCountry == false))
                            {
                                if (countries.CountryId == Model.CountryId)
                                {

#line default
#line hidden
#nullable disable
            WriteLiteral("                                    <option selected");
            BeginWriteAttribute("value", " value=\"", 3062, "\"", 3090, 1);
#nullable restore
#line 64 "D:\ProstyleTechnology\Project\GloableCommunication\Areas\MasterMaintainance\Views\Area\AddView.cshtml"
WriteAttributeValue("", 3070, countries.CountryId, 3070, 20, false);

#line default
#line hidden
#nullable disable
            EndWriteAttribute();
            WriteLiteral(">");
#nullable restore
#line 64 "D:\ProstyleTechnology\Project\GloableCommunication\Areas\MasterMaintainance\Views\Area\AddView.cshtml"
                                                                             Write(countries.CountryName);

#line default
#line hidden
#nullable disable
            WriteLiteral("</option>\r\n");
#nullable restore
#line 65 "D:\ProstyleTechnology\Project\GloableCommunication\Areas\MasterMaintainance\Views\Area\AddView.cshtml"
                                }
                                else
                                {

#line default
#line hidden
#nullable disable
            WriteLiteral("                                    <option");
            BeginWriteAttribute("value", " value=\"", 3276, "\"", 3304, 1);
#nullable restore
#line 68 "D:\ProstyleTechnology\Project\GloableCommunication\Areas\MasterMaintainance\Views\Area\AddView.cshtml"
WriteAttributeValue("", 3284, countries.CountryId, 3284, 20, false);

#line default
#line hidden
#nullable disable
            EndWriteAttribute();
            WriteLiteral(">");
#nullable restore
#line 68 "D:\ProstyleTechnology\Project\GloableCommunication\Areas\MasterMaintainance\Views\Area\AddView.cshtml"
                                                                    Write(countries.CountryName);

#line default
#line hidden
#nullable disable
            WriteLiteral("</option>\r\n");
#nullable restore
#line 69 "D:\ProstyleTechnology\Project\GloableCommunication\Areas\MasterMaintainance\Views\Area\AddView.cshtml"
                                }
                            }

#line default
#line hidden
#nullable disable
            WriteLiteral("                        </select>\r\n                    </div>\r\n                </div>\r\n            </div>\r\n        </form>\r\n    </div>\r\n</div>\r\n\r\n");
            WriteLiteral(@"<script>
    var today = new Date();
    var date = today.getFullYear() + '/' + (today.getMonth() + 1) + '/' + today.getDate();
    document.getElementById(""UpdateDateTime"").value = date;
</script>

<script>
    var today = new Date();
    var date = today.getFullYear() + '/' + (today.getMonth() + 1) + '/' + today.getDate();
    document.getElementById(""InsertDateTime"").value = date;
</script>


");
            DefineSection("Scripts", async() => {
                WriteLiteral("\r\n");
#nullable restore
#line 94 "D:\ProstyleTechnology\Project\GloableCommunication\Areas\MasterMaintainance\Views\Area\AddView.cshtml"
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
        public global::Microsoft.AspNetCore.Mvc.Rendering.IHtmlHelper<GloableCommunication.Areas.MasterMaintainance.Models.ViewModels.AreaViewModel> Html { get; private set; }
    }
}
#pragma warning restore 1591
