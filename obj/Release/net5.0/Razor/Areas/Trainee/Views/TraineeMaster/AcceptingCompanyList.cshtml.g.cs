#pragma checksum "C:\Bench\Daiki\ProstyleTechnology\17. Project From Japan\02.git\Project\GloableCommunication\Areas\Trainee\Views\TraineeMaster\AcceptingCompanyList.cshtml" "{ff1816ec-aa5e-4d10-87f7-6f4963833460}" "dfaf56f5abf962094b902812a882acc1c8702081"
// <auto-generated/>
#pragma warning disable 1591
[assembly: global::Microsoft.AspNetCore.Razor.Hosting.RazorCompiledItemAttribute(typeof(AspNetCore.Areas_Trainee_Views_TraineeMaster_AcceptingCompanyList), @"mvc.1.0.view", @"/Areas/Trainee/Views/TraineeMaster/AcceptingCompanyList.cshtml")]
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
    [global::Microsoft.AspNetCore.Razor.Hosting.RazorSourceChecksumAttribute(@"SHA1", @"dfaf56f5abf962094b902812a882acc1c8702081", @"/Areas/Trainee/Views/TraineeMaster/AcceptingCompanyList.cshtml")]
    public class Areas_Trainee_Views_TraineeMaster_AcceptingCompanyList : global::Microsoft.AspNetCore.Mvc.Razor.RazorPage<IEnumerable<GloableCommunication.DbModels.AcceptingCompany>>
    {
        #pragma warning disable 1998
        public async override global::System.Threading.Tasks.Task ExecuteAsync()
        {
            WriteLiteral("\r\n");
#nullable restore
#line 3 "C:\Bench\Daiki\ProstyleTechnology\17. Project From Japan\02.git\Project\GloableCommunication\Areas\Trainee\Views\TraineeMaster\AcceptingCompanyList.cshtml"
   
    ViewData["Title"] = "AcceptingCompanyList";
    Layout = null; 

#line default
#line hidden
#nullable disable
            WriteLiteral(@"
<div>
    <div>
        <button class=""w3-button w3-green""
                onclick=""ReturnBtn()"">
            <i class=""fa fa-arrow-left""></i>
        </button>
    </div>
    <div>
        <a asp-action=""Create"" style=""font-size:15px; padding-left:10px"">戻る</a>

    </div>
</div>

<style>
    tr:hover td {
        background-color: #0095ff;
        cursor: pointer;
    }

    /*table tr.active {
        background-color: #0095ff;
    }*/

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
        max-width: 50% !important;
        align-self: center !important;
    }
</style>


<div class="" w3-margin-top w3-gray"">
    <h5 style=""text-align:center"">
        受入企業一覧
    </h5>
</div>



<table class=""table table-bordered table-hover"" id=""acceptingCompanyTable"">
    <thead>
        <tr>

            <th>
       ");
            WriteLiteral("         受入企業CD\r\n            </th>\r\n            <th>\r\n                受入企業の名前\r\n            </th>\r\n            <th style=\"display:none\">\r\n            </th>\r\n            <th style=\"display:none\">\r\n            </th>\r\n");
            WriteLiteral(@"            <th style=""display:none"">
            </th>
            <th style=""display:none"">
            </th>
            <th style=""display:none"">
            </th>
            <th style=""display:none"">
            </th>
            <th style=""display:none"">
            </th>
            <th style=""display:none"">
            </th>
            <th style=""display:none"">
            </th>
            <th style=""display:none"">
            </th>
        </tr>
    </thead>
    <tbody>
");
#nullable restore
#line 241 "C:\Bench\Daiki\ProstyleTechnology\17. Project From Japan\02.git\Project\GloableCommunication\Areas\Trainee\Views\TraineeMaster\AcceptingCompanyList.cshtml"
         foreach (var item in Model)
        {

#line default
#line hidden
#nullable disable
            WriteLiteral("        <tr>\r\n            <td style=\"display:none;\">\r\n                ");
#nullable restore
#line 245 "C:\Bench\Daiki\ProstyleTechnology\17. Project From Japan\02.git\Project\GloableCommunication\Areas\Trainee\Views\TraineeMaster\AcceptingCompanyList.cshtml"
           Write(Html.DisplayFor(modelItem => item.AcceptingCompanyId));

#line default
#line hidden
#nullable disable
            WriteLiteral("\r\n            </td>\r\n            <td>\r\n                ");
#nullable restore
#line 248 "C:\Bench\Daiki\ProstyleTechnology\17. Project From Japan\02.git\Project\GloableCommunication\Areas\Trainee\Views\TraineeMaster\AcceptingCompanyList.cshtml"
           Write(Html.DisplayFor(modelItem => item.AcceptingCompanyCode));

#line default
#line hidden
#nullable disable
            WriteLiteral("\r\n            </td>\r\n            <td>\r\n                ");
#nullable restore
#line 251 "C:\Bench\Daiki\ProstyleTechnology\17. Project From Japan\02.git\Project\GloableCommunication\Areas\Trainee\Views\TraineeMaster\AcceptingCompanyList.cshtml"
           Write(Html.DisplayFor(modelItem => item.AcceptiingCompanyName));

#line default
#line hidden
#nullable disable
            WriteLiteral("\r\n            </td>\r\n\r\n");
            WriteLiteral("            <td style=\"display:none;\">\r\n                ");
#nullable restore
#line 267 "C:\Bench\Daiki\ProstyleTechnology\17. Project From Japan\02.git\Project\GloableCommunication\Areas\Trainee\Views\TraineeMaster\AcceptingCompanyList.cshtml"
           Write(Html.DisplayFor(modelItem => item.Zip));

#line default
#line hidden
#nullable disable
            WriteLiteral("\r\n            </td>\r\n            <td style=\"display:none;\">\r\n                ");
#nullable restore
#line 270 "C:\Bench\Daiki\ProstyleTechnology\17. Project From Japan\02.git\Project\GloableCommunication\Areas\Trainee\Views\TraineeMaster\AcceptingCompanyList.cshtml"
           Write(Html.DisplayFor(modelItem => item.Address1));

#line default
#line hidden
#nullable disable
            WriteLiteral("\r\n            </td>\r\n            <td style=\"display:none;\">\r\n                ");
#nullable restore
#line 273 "C:\Bench\Daiki\ProstyleTechnology\17. Project From Japan\02.git\Project\GloableCommunication\Areas\Trainee\Views\TraineeMaster\AcceptingCompanyList.cshtml"
           Write(Html.DisplayFor(modelItem => item.Address2));

#line default
#line hidden
#nullable disable
            WriteLiteral("\r\n            </td>\r\n            <td style=\"display:none;\">\r\n                ");
#nullable restore
#line 276 "C:\Bench\Daiki\ProstyleTechnology\17. Project From Japan\02.git\Project\GloableCommunication\Areas\Trainee\Views\TraineeMaster\AcceptingCompanyList.cshtml"
           Write(Html.DisplayFor(modelItem => item.TelephoneNo));

#line default
#line hidden
#nullable disable
            WriteLiteral("\r\n            </td>\r\n            <td style=\"display:none;\">\r\n                ");
#nullable restore
#line 279 "C:\Bench\Daiki\ProstyleTechnology\17. Project From Japan\02.git\Project\GloableCommunication\Areas\Trainee\Views\TraineeMaster\AcceptingCompanyList.cshtml"
           Write(Html.DisplayFor(modelItem => item.Fax));

#line default
#line hidden
#nullable disable
            WriteLiteral("\r\n            </td>\r\n            <td style=\"display:none;\">\r\n                ");
#nullable restore
#line 282 "C:\Bench\Daiki\ProstyleTechnology\17. Project From Japan\02.git\Project\GloableCommunication\Areas\Trainee\Views\TraineeMaster\AcceptingCompanyList.cshtml"
           Write(Html.DisplayFor(modelItem => item.IpNotificationNo));

#line default
#line hidden
#nullable disable
            WriteLiteral("\r\n            </td>\r\n            <td style=\"display:none;\">\r\n                ");
#nullable restore
#line 285 "C:\Bench\Daiki\ProstyleTechnology\17. Project From Japan\02.git\Project\GloableCommunication\Areas\Trainee\Views\TraineeMaster\AcceptingCompanyList.cshtml"
           Write(Html.DisplayFor(modelItem => item.Business));

#line default
#line hidden
#nullable disable
            WriteLiteral("\r\n            </td>\r\n\r\n");
            WriteLiteral("            <td style=\"display:none\">\r\n            </td>\r\n            <td style=\"display:none\">\r\n            </td>\r\n        </tr>\r\n");
#nullable restore
#line 421 "C:\Bench\Daiki\ProstyleTechnology\17. Project From Japan\02.git\Project\GloableCommunication\Areas\Trainee\Views\TraineeMaster\AcceptingCompanyList.cshtml"
        }

#line default
#line hidden
#nullable disable
            WriteLiteral(@"    </tbody>
</table>

<script>
    $(ModalBtn).prop(""disabled"", true);

    $(""#acceptingCompanyTable tr"").click(function () {
        $(this).addClass('selected').siblings().removeClass('selected');
        var nameValue = $(this).find('td:nth-child(3)').html();
        var nameValueTrim = nameValue.trim();
        $(""input[name='AcceptingCompanyName']"").val(nameValueTrim);
        var idValue = $(this).find('td:nth-child(1)').html();
        $(""input[name='AcceptingCompanyId']"").val(idValue);

        var acccodeValue = $(this).find('td:nth-child(2)').html();
        var accValueTrim = acccodeValue.trim();
        $(""input[name='AcceptingCompanyCode']"").val(accValueTrim);


        var zipValue = $(this).find('td:nth-child(4)').html();
        var zipValueTrim = zipValue.trim();
        $(""input[name='ZipAccptingCom']"").val(zipValueTrim);


        var Address1Value = $(this).find('td:nth-child(5)').html();
        var zaddress1ValueTrim = Address1Value.trim();
        $(""input[na");
            WriteLiteral(@"me='Address1AccptCom']"").val(zaddress1ValueTrim);

        var Address2Value = $(this).find('td:nth-child(6)').html();
        var zaddress2ValueTrim = Address2Value.trim();
        $(""input[name='Address2AccptCom']"").val(zaddress2ValueTrim);

        var TelValue = $(this).find('td:nth-child(7)').html();
        var telValueTrim = TelValue.trim();
        $(""input[name='TelephoneNoAccptCom']"").val(telValueTrim);

        var FaxValue = $(this).find('td:nth-child(8)').html();
        var faxValueTrim = FaxValue.trim();
        $(""input[name='FaxAccptCom']"").val(faxValueTrim);

        var FaxValue = $(this).find('td:nth-child(9)').html();
        var faxValueTrim = FaxValue.trim();
        $(""input[name='IpNotificationNo']"").val(faxValueTrim);

        var BusinessValue = $(this).find('td:nth-child(10)').html();
        var businessValueTrim = BusinessValue.trim();
        $(""input[name='Business']"").val(businessValueTrim);

        $(ModalBtn).prop(""disabled"", false);

    });

    ");
            WriteLiteral(@"function ReturnBtn() {
        $(""input[name='AcceptingCompanyId']"").val('');
        $(""input[name='AcceptingCompanyName']"").val('');
        $(""input[name='AcceptingCompanyCode']"").val('');
        $(""input[name='ZipAccptingCom']"").val('');
        $(""input[name='Address1AccptCom']"").val('');
        $(""input[name='Address2AccptCom']"").val('');
        $(""input[name='TelephoneNoAccptCom']"").val('');
        $(""input[name='FaxAccptCom']"").val('');
        $(""input[name='IpNotificationNo']"").val('');
        $(""input[name='Business']"").val('');


        $('#listViewModal').modal('hide');
    }

</script>

<script>
    $(document).ready(function () {
        $('#acceptingCompanyTable').DataTable({
            ""lengthMenu"": [5, 10, 15, 20, 30],
            ""language"": {
                ""search"": ""検索:"",
                ""paginate"": {
                    ""first"": ""一ページ目"",
                    ""last"": ""最後のページ"",
                    ""next"": ""次へ"",
                    ""previous"": ""前へ""
     ");
            WriteLiteral(@"           },
                ""lengthMenu"": "" _MENU_ 件表示"",
                ""info"": ""検索結果 _TOTAL_ 以上 のうち _START_ ~ _END_件"",
                ""infoEmpty"": ""検索結果 0 以上 のうち 0 ~ 0件"",
                ""emptyTable"": ""条件に一致する結果は見つかりませんでした"",
                ""zeroRecords"": ""条件に一致する結果は見つかりませんでした"",
            },
        });
        $('.dataTables_length').addClass('bs-select');
    });
</script>");
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
        public global::Microsoft.AspNetCore.Mvc.Rendering.IHtmlHelper<IEnumerable<GloableCommunication.DbModels.AcceptingCompany>> Html { get; private set; }
    }
}
#pragma warning restore 1591
