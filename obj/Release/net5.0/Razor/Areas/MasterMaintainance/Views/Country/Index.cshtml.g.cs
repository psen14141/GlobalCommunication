#pragma checksum "C:\Bench\Daiki\ProstyleTechnology\17. Project From Japan\02.git\Project\GloableCommunication\Areas\MasterMaintainance\Views\Country\Index.cshtml" "{ff1816ec-aa5e-4d10-87f7-6f4963833460}" "ce6f817633105e6de8f100e1202912f17a943911"
// <auto-generated/>
#pragma warning disable 1591
[assembly: global::Microsoft.AspNetCore.Razor.Hosting.RazorCompiledItemAttribute(typeof(AspNetCore.Areas_MasterMaintainance_Views_Country_Index), @"mvc.1.0.view", @"/Areas/MasterMaintainance/Views/Country/Index.cshtml")]
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
    [global::Microsoft.AspNetCore.Razor.Hosting.RazorSourceChecksumAttribute(@"SHA1", @"ce6f817633105e6de8f100e1202912f17a943911", @"/Areas/MasterMaintainance/Views/Country/Index.cshtml")]
    public class Areas_MasterMaintainance_Views_Country_Index : global::Microsoft.AspNetCore.Mvc.Razor.RazorPage<IEnumerable<GloableCommunication.DbModels.Country>>
    {
        #pragma warning disable 1998
        public async override global::System.Threading.Tasks.Task ExecuteAsync()
        {
            WriteLiteral("\r\n");
#nullable restore
#line 3 "C:\Bench\Daiki\ProstyleTechnology\17. Project From Japan\02.git\Project\GloableCommunication\Areas\MasterMaintainance\Views\Country\Index.cshtml"
  
    ViewData["Title"] = "Index";
    Layout = "~/Views/Shared/_Layout.cshtml";

#line default
#line hidden
#nullable disable
            WriteLiteral(@"
<script>
    $(document).ready(function () {
        $('#dtDesign').DataTable();
        $('.dataTables_length').addClass('bs-select');
    });
</script>

<h2>国マスト登録</h2>
<br />
<br />
<br />
    <div class=""row"">
        <div class=""col-sm"">
            <button class=""btn btn-primary""><i class=""fa fa-home""></i> 戻る</button>
            <button href=""#"" onclick=""Countrynformation(0)"" class=""btn btn-success""><i class=""fa fa-folder""></i> 登録</button>
            <button class=""btn btn-warning""><i class=""fa fa-trash""></i> クリア</button>
            <button class=""btn btn-danger""><i class=""fa fa-close""></i> 削除</button>
        </div>
        <div class=""col-sm"">

        </div>
    </div>
<br />
<br />
<br />

<table id=""dtDesign"" class=""table table-striped table-bordered table-sm"" cellspacing=""0"" width=""100%"">
    <thead>
        <tr>
");
            WriteLiteral("            <th>\r\n                国　名\r\n            </th>\r\n            <th>\r\n                国　CD\r\n            </th>\r\n");
            WriteLiteral("\r\n            <th></th>\r\n        </tr>\r\n    </thead>\r\n    <tbody>\r\n");
#nullable restore
#line 57 "C:\Bench\Daiki\ProstyleTechnology\17. Project From Japan\02.git\Project\GloableCommunication\Areas\MasterMaintainance\Views\Country\Index.cshtml"
         foreach (var item in Model)
        {

#line default
#line hidden
#nullable disable
            WriteLiteral("            <tr>\r\n");
            WriteLiteral("                <td>\r\n                    ");
#nullable restore
#line 64 "C:\Bench\Daiki\ProstyleTechnology\17. Project From Japan\02.git\Project\GloableCommunication\Areas\MasterMaintainance\Views\Country\Index.cshtml"
               Write(Html.DisplayFor(modelItem => item.CountryName));

#line default
#line hidden
#nullable disable
            WriteLiteral("\r\n                </td>\r\n                <td>\r\n                    ");
#nullable restore
#line 67 "C:\Bench\Daiki\ProstyleTechnology\17. Project From Japan\02.git\Project\GloableCommunication\Areas\MasterMaintainance\Views\Country\Index.cshtml"
               Write(Html.DisplayFor(modelItem => item.CountryCode));

#line default
#line hidden
#nullable disable
            WriteLiteral("\r\n                </td>\r\n");
            WriteLiteral("\r\n            <td>\r\n                <a href=\"#\"");
            BeginWriteAttribute("onclick", " onclick=\"", 2277, "\"", 2321, 3);
            WriteAttributeValue("", 2287, "Countrynformation(", 2287, 18, true);
#nullable restore
#line 77 "C:\Bench\Daiki\ProstyleTechnology\17. Project From Japan\02.git\Project\GloableCommunication\Areas\MasterMaintainance\Views\Country\Index.cshtml"
WriteAttributeValue("", 2305, item.CountryId, 2305, 15, false);

#line default
#line hidden
#nullable disable
            WriteAttributeValue("", 2320, ")", 2320, 1, true);
            EndWriteAttribute();
            WriteLiteral(" class=\"btn btn-primary\">Edit</a>\r\n                <a href=\"#\"");
            BeginWriteAttribute("onclick", " onclick=\"", 2384, "\"", 2428, 3);
            WriteAttributeValue("", 2394, "Countrynformation(", 2394, 18, true);
#nullable restore
#line 78 "C:\Bench\Daiki\ProstyleTechnology\17. Project From Japan\02.git\Project\GloableCommunication\Areas\MasterMaintainance\Views\Country\Index.cshtml"
WriteAttributeValue("", 2412, item.CountryId, 2412, 15, false);

#line default
#line hidden
#nullable disable
            WriteAttributeValue("", 2427, ")", 2427, 1, true);
            EndWriteAttribute();
            WriteLiteral(" class=\"btn btn-primary\">Details</a>\r\n                <a class=\"btn btn-danger\"");
            BeginWriteAttribute("onclick", " onclick=\"", 2508, "\"", 2645, 8);
            WriteAttributeValue("", 2518, "DeleteConfirmation(\'/MaterMaintainance/Country/Delete/?Id=", 2518, 58, true);
#nullable restore
#line 79 "C:\Bench\Daiki\ProstyleTechnology\17. Project From Japan\02.git\Project\GloableCommunication\Areas\MasterMaintainance\Views\Country\Index.cshtml"
WriteAttributeValue("", 2576, item.CountryId, 2576, 15, false);

#line default
#line hidden
#nullable disable
            WriteAttributeValue("", 2591, "\',", 2591, 2, true);
            WriteAttributeValue(" ", 2593, "null,", 2594, 6, true);
            WriteAttributeValue(" ", 2599, "null,", 2600, 6, true);
            WriteAttributeValue(" ", 2605, "true,", 2606, 6, true);
            WriteAttributeValue(" ", 2611, "\'Warning\',", 2612, 11, true);
            WriteAttributeValue(" ", 2622, "\'GlobalCommunication\')", 2623, 23, true);
            EndWriteAttribute();
            WriteLiteral(">Delete</a>\r\n\r\n            </td>\r\n            </tr>\r\n");
#nullable restore
#line 83 "C:\Bench\Daiki\ProstyleTechnology\17. Project From Japan\02.git\Project\GloableCommunication\Areas\MasterMaintainance\Views\Country\Index.cshtml"
        }

#line default
#line hidden
#nullable disable
            WriteLiteral(@"    </tbody>
</table>




<div id=""AddorEditView"" class=""modal"" tabindex=""-1"" role=""dialog"">
    <div class=""modal-dialog"" role=""document"">
        <div class=""modal-content"">
            <div class=""modal-header"">
                <h5 class=""modal-title"">Country section</h5>
                <button type=""button"" class=""close"" data-dismiss=""modal"" aria-label=""Close"">
                    <span aria-hidden=""true"">&times;</span>
                </button>
            </div>
            <div class=""modal-body"" id=""formArea"">

            </div>
            <div class=""modal-footer"">
                <button type=""button"" onclick=""SaveChanges()"" class=""btn btn-primary"">Save changes</button>
                <button type=""button"" class=""btn btn-secondary"" data-dismiss=""modal"">Close</button>
            </div>
        </div>
    </div>
</div>

<script>
    function Countrynformation(id) {

        $('#AddorEditView').modal(); //open the model
        $(""#formArea"").html(""""); // Clear existi");
            WriteLiteral(@"ng are
        //alert(""test message!"");
        $.ajax({
            method: ""GET"",
            url: ""/MasterMaintainance/Country/AddorEditView/"" + id,
        })
            .done(function (msg) {
                $(""#formArea"").html(msg);

            });
    }

    function SaveChanges() {

        let postData = new FormData();
        postData.append('CountryId', $(""#CountryId"").val());
        postData.append('CountryName', $(""#CountryName"").val());
        postData.append('CountryCode', $(""#CountryCode"").val());
        postData.append('UpdateDateTime', $(""#UpdateDateTime"").val());
        postData.append('InsertDateTime', $(""#InsertDateTime"").val());

        $.ajax({
            method: ""POST"",
            url: ""/MasterMaintainance/Country/SaveChanges/"",
            enctype: 'multipart/form-data',
            data: postData,
            contentType: false,
            processData: false,
        })
            .done(function (msg) {
                $('#AddOrEditView').mo");
            WriteLiteral(@"dal('hide')
                alert(""Data has saved"");
                location.reload();
            });
    }
    $(document).ready(function () {
        $('#dtDesign').DataTable();
        $('.dataTables_length').addClass('bs-select');
    });
    function GetConfirmation() {
        var reply = confirm(""Are you sure you want to delete this?"");
        if (reply) {
            return true;
        }
        else {
            return false;
        }
    }
</script>
");
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
        public global::Microsoft.AspNetCore.Mvc.Rendering.IHtmlHelper<IEnumerable<GloableCommunication.DbModels.Country>> Html { get; private set; }
    }
}
#pragma warning restore 1591
