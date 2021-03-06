#pragma checksum "D:\ProstyleTechnology\Project\GloableCommunication\Areas\AcceptingCompany\Views\AcceptingCompany\TraineePerfectureListView.cshtml" "{ff1816ec-aa5e-4d10-87f7-6f4963833460}" "2549ff105f258cecdc03ef7a5bee28420caa77fb"
// <auto-generated/>
#pragma warning disable 1591
[assembly: global::Microsoft.AspNetCore.Razor.Hosting.RazorCompiledItemAttribute(typeof(AspNetCore.Areas_AcceptingCompany_Views_AcceptingCompany_TraineePerfectureListView), @"mvc.1.0.view", @"/Areas/AcceptingCompany/Views/AcceptingCompany/TraineePerfectureListView.cshtml")]
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
    [global::Microsoft.AspNetCore.Razor.Hosting.RazorSourceChecksumAttribute(@"SHA1", @"2549ff105f258cecdc03ef7a5bee28420caa77fb", @"/Areas/AcceptingCompany/Views/AcceptingCompany/TraineePerfectureListView.cshtml")]
    public class Areas_AcceptingCompany_Views_AcceptingCompany_TraineePerfectureListView : global::Microsoft.AspNetCore.Mvc.Razor.RazorPage<IEnumerable<GloableCommunication.DbModels.Perfecture>>
    {
        #pragma warning disable 1998
        public async override global::System.Threading.Tasks.Task ExecuteAsync()
        {
            WriteLiteral("\r\n");
#nullable restore
#line 3 "D:\ProstyleTechnology\Project\GloableCommunication\Areas\AcceptingCompany\Views\AcceptingCompany\TraineePerfectureListView.cshtml"
  
    ViewData["Title"] = "TraineePerfectureListView";
    Layout = null;

#line default
#line hidden
#nullable disable
            WriteLiteral(@"
<link rel=""stylesheet"" href=""//code.jquery.com/ui/1.11.4/themes/start/jquery-ui.css"">


<div>
    <div>
        <button class=""w3-button w3-green"" data-dismiss=""modal"" onclick=""ReturnBtn()""><i class=""fa fa-arrow-left""></i></button>
    </div>
    <div>
        <a asp-action=""Create"" style=""font-size:15px; padding-left:10px"">??????</a>
    </div>
</div>

<style>
    tr:hover td {
        background-color: #0095ff;
        cursor: pointer;
    }

    td .selectRow {
        border: 1px #DDD solid;
        padding: 5px;
        cursor: pointer;
    }

    .selected {
        background-color: #0095ff;
        color: #FFF;
    }

    .modal-nw {
        max-width: 50%;
        align-self: center;
    }
</style>

<div class="" w3-margin-top w3-gray"">
    <h5 style=""text-align:center"">?????????????????????</h5>
</div>

<table id=""perfectureTable"" class=""table table-bordered table-hover"">
    <thead>
        <tr>
            <th style=""display:none""></th>
            <th>
                ???");
            WriteLiteral(" CD\r\n            </th>\r\n            <th>\r\n                ????????????\r\n            </th>\r\n        </tr>\r\n    </thead>\r\n    <tbody>\r\n");
#nullable restore
#line 60 "D:\ProstyleTechnology\Project\GloableCommunication\Areas\AcceptingCompany\Views\AcceptingCompany\TraineePerfectureListView.cshtml"
         foreach (var item in Model)
        {

#line default
#line hidden
#nullable disable
            WriteLiteral("            <tr class=\"row-click\">\r\n                <td style=\"display:none\">\r\n                    ");
#nullable restore
#line 64 "D:\ProstyleTechnology\Project\GloableCommunication\Areas\AcceptingCompany\Views\AcceptingCompany\TraineePerfectureListView.cshtml"
               Write(Html.DisplayFor(modelItem => item.PerfectureId));

#line default
#line hidden
#nullable disable
            WriteLiteral("\r\n                </td>\r\n                <td class=\"selectRow\">\r\n                    ");
#nullable restore
#line 67 "D:\ProstyleTechnology\Project\GloableCommunication\Areas\AcceptingCompany\Views\AcceptingCompany\TraineePerfectureListView.cshtml"
               Write(Html.DisplayFor(modelItem => item.PerfectureCode));

#line default
#line hidden
#nullable disable
            WriteLiteral("\r\n                </td>\r\n                <td class=\"selectRow\">\r\n                    ");
#nullable restore
#line 70 "D:\ProstyleTechnology\Project\GloableCommunication\Areas\AcceptingCompany\Views\AcceptingCompany\TraineePerfectureListView.cshtml"
               Write(Html.DisplayFor(modelItem => item.PerfectureName));

#line default
#line hidden
#nullable disable
            WriteLiteral("\r\n                </td>\r\n            </tr>\r\n");
#nullable restore
#line 73 "D:\ProstyleTechnology\Project\GloableCommunication\Areas\AcceptingCompany\Views\AcceptingCompany\TraineePerfectureListView.cshtml"
        }

#line default
#line hidden
#nullable disable
            WriteLiteral(@"    </tbody>
</table>

<script>

    $(ModalBtn).prop(""disabled"", true);
    $(""#perfectureTable tr"").click(function () {
        $(this).addClass('selected').siblings().removeClass('selected');
        var nameValue = $(this).find('td:nth-child(3)').html();
        nameValue1 = nameValue.trim()
        $(""input[name='PerfectureCode']"").val(nameValue1);
        var idValue = $(this).find('td:nth-child(1)').html();
        $(""input[name='PerfectureId']"").val(idValue);
        $(ModalBtn).prop(""disabled"", false);
    });

    function ReturnBtn() {
        $(""input[name='PerfectureId']"").val('');
        $(""input[name='PerfectureCode']"").val('');
        $('#listViewModal').modal('hide');
    }

    $(document).ready(function () {
        $('#perfectureTable').DataTable({
            ""lengthMenu"": [5, 10, 15, 20, 30],
            ""language"": {
                ""search"": ""??????:"",
                ""paginate"": {
                    ""first"": ""???????????????"",
                    ""last"": ""??????????????????"",
 ");
            WriteLiteral(@"                   ""next"": ""??????"",
                    ""previous"": ""??????""
                },
                ""lengthMenu"": "" MENU ?????????"",
                ""info"": ""???????????? TOTAL ?????? ????????? START ~ _END_???"",
                ""infoEmpty"": ""???????????? 0 ?????? ????????? 0 ~ 0???"",
                ""emptyTable"": ""????????????????????????????????????????????????????????????"",
                ""zeroRecords"": ""????????????????????????????????????????????????????????????"",
            },
        });
        $('.dataTables_length').addClass('bs-select');
    });

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
        public global::Microsoft.AspNetCore.Mvc.Rendering.IHtmlHelper<IEnumerable<GloableCommunication.DbModels.Perfecture>> Html { get; private set; }
    }
}
#pragma warning restore 1591
