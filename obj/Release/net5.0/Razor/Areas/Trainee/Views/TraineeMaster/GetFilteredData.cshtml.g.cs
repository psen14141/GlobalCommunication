#pragma checksum "C:\Bench\Daiki\ProstyleTechnology\17. Project From Japan\02.git\Project\GloableCommunication\Areas\Trainee\Views\TraineeMaster\GetFilteredData.cshtml" "{ff1816ec-aa5e-4d10-87f7-6f4963833460}" "95529ac951dc5f24603581ec9ff71069c3d7ab36"
// <auto-generated/>
#pragma warning disable 1591
[assembly: global::Microsoft.AspNetCore.Razor.Hosting.RazorCompiledItemAttribute(typeof(AspNetCore.Areas_Trainee_Views_TraineeMaster_GetFilteredData), @"mvc.1.0.view", @"/Areas/Trainee/Views/TraineeMaster/GetFilteredData.cshtml")]
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
    [global::Microsoft.AspNetCore.Razor.Hosting.RazorSourceChecksumAttribute(@"SHA1", @"95529ac951dc5f24603581ec9ff71069c3d7ab36", @"/Areas/Trainee/Views/TraineeMaster/GetFilteredData.cshtml")]
    public class Areas_Trainee_Views_TraineeMaster_GetFilteredData : global::Microsoft.AspNetCore.Mvc.Razor.RazorPage<IEnumerable<GloableCommunication.Areas.Trainee.Models.ViewModel.TraineeMasterViewModel>>
    {
        #pragma warning disable 1998
        public async override global::System.Threading.Tasks.Task ExecuteAsync()
        {
            WriteLiteral("\r\n\r\n");
#nullable restore
#line 4 "C:\Bench\Daiki\ProstyleTechnology\17. Project From Japan\02.git\Project\GloableCommunication\Areas\Trainee\Views\TraineeMaster\GetFilteredData.cshtml"
  
    ViewData["Title"] = "GetFilteredData";
    Layout = null;

#line default
#line hidden
#nullable disable
            WriteLiteral(@"
<style>
    tr:hover td {
        background-color: inherit;
        cursor: auto;
    }

/*    .table-condensed {
        font-size: 4px !important;
    }*/
</style>


<div>
    <div>
        <button class=""w3-button w3-green"" data-dismiss=""modal""><i class=""fa fa-arrow-left""></i></button>
        <button class=""w3-button w3-light-blue""><i class=""fa fa-print"" onclick=""Print()""></i></button>
        <button id=""btnExcel"" class=""w3-button w3-light-gray""><i class=""fa fa-file-excel-o""></i></button>
    </div>
    <div>
        <a style=""font-size:15px; padding-left:10px"">??????</a>
        <a asp-action=""Create"" style=""font-size:15px; padding-right:10px"">??????</a>
        <a asp-action=""Create"" style=""font-size:15px; padding-right:10px"">??????????????????</a>
    </div>
</div>

<script>

</script>

<div class="" w3-margin-top w3-gray"">
    <h5 style=""text-align:center"">
        ????????????
    </h5>
</div>

<table id=""dtDesign"" class=""table table-striped table-bordered table-sm nowrap""  cellspacing=""0"" ");
            WriteLiteral(@"width=""100%"">
    <thead>
        <tr>
            <th style=""font-size:small"">
                ?????????No
            </th>
            <th style=""font-size:small"">
                ??????
            </th>
            <th style=""font-size:small"">
                ???????????????
            </th>
            <th style=""font-size:small"">
                ??????(??????)
            </th>
            <th style=""font-size:small"">
                ??????
            </th>
            <th style=""font-size:small"">
                ?????????
            </th>
            <th style=""font-size:small"">
                ????????????
            </th>
            <th style=""font-size:small"">
                ????????????
            </th>
            <th style=""font-size:small"">
                ????????????
            </th>
            <th style=""font-size:small"">
                ??????
            </th>
            <th style=""font-size:small"">
                ??????
            </th>
            <th style=""font-size:small"">
                ????????????
          ");
            WriteLiteral("  </th>\r\n            <th style=\"font-size:small\">\r\n\r\n            </th>\r\n        </tr>\r\n    </thead>\r\n    <tbody>\r\n");
#nullable restore
#line 89 "C:\Bench\Daiki\ProstyleTechnology\17. Project From Japan\02.git\Project\GloableCommunication\Areas\Trainee\Views\TraineeMaster\GetFilteredData.cshtml"
         foreach (var item in Model)
        {

#line default
#line hidden
#nullable disable
            WriteLiteral("            <tr>\r\n                <td style=\"font-size:x-small\">\r\n                    ");
#nullable restore
#line 93 "C:\Bench\Daiki\ProstyleTechnology\17. Project From Japan\02.git\Project\GloableCommunication\Areas\Trainee\Views\TraineeMaster\GetFilteredData.cshtml"
               Write(Html.DisplayFor(modelItem => item.TraineeNo));

#line default
#line hidden
#nullable disable
            WriteLiteral("\r\n                </td>\r\n                <td style=\"font-size:x-small\">\r\n                    ");
#nullable restore
#line 96 "C:\Bench\Daiki\ProstyleTechnology\17. Project From Japan\02.git\Project\GloableCommunication\Areas\Trainee\Views\TraineeMaster\GetFilteredData.cshtml"
               Write(Html.DisplayFor(modelItem => item.Schlarship));

#line default
#line hidden
#nullable disable
            WriteLiteral("\r\n\r\n                </td>\r\n                <td style=\"font-size:x-small\">\r\n                    ");
#nullable restore
#line 100 "C:\Bench\Daiki\ProstyleTechnology\17. Project From Japan\02.git\Project\GloableCommunication\Areas\Trainee\Views\TraineeMaster\GetFilteredData.cshtml"
               Write(Html.DisplayFor(modelItem => item.TraineeName));

#line default
#line hidden
#nullable disable
            WriteLiteral("\r\n                </td>\r\n                <td style=\"font-size:x-small\">\r\n                    ");
#nullable restore
#line 103 "C:\Bench\Daiki\ProstyleTechnology\17. Project From Japan\02.git\Project\GloableCommunication\Areas\Trainee\Views\TraineeMaster\GetFilteredData.cshtml"
               Write(Html.DisplayFor(modelItem => item.KatakanaName));

#line default
#line hidden
#nullable disable
            WriteLiteral("\r\n                </td>\r\n                <td style=\"font-size:x-small\">\r\n                    ");
#nullable restore
#line 106 "C:\Bench\Daiki\ProstyleTechnology\17. Project From Japan\02.git\Project\GloableCommunication\Areas\Trainee\Views\TraineeMaster\GetFilteredData.cshtml"
               Write(Html.DisplayFor(modelItem => item.SexFlag));

#line default
#line hidden
#nullable disable
            WriteLiteral("\r\n                </td>\r\n                <td style=\"font-size:x-small\">\r\n                    ");
#nullable restore
#line 109 "C:\Bench\Daiki\ProstyleTechnology\17. Project From Japan\02.git\Project\GloableCommunication\Areas\Trainee\Views\TraineeMaster\GetFilteredData.cshtml"
               Write(Html.DisplayFor(modelItem => item.EntranceDateStr));

#line default
#line hidden
#nullable disable
            WriteLiteral("\r\n                </td>\r\n                <td style=\"font-size:x-small\">\r\n                    ");
#nullable restore
#line 112 "C:\Bench\Daiki\ProstyleTechnology\17. Project From Japan\02.git\Project\GloableCommunication\Areas\Trainee\Views\TraineeMaster\GetFilteredData.cshtml"
               Write(Html.DisplayFor(modelItem => item.Immigrationstatus));

#line default
#line hidden
#nullable disable
            WriteLiteral("\r\n                </td>\r\n                <td style=\"font-size:x-small\">\r\n                    ");
#nullable restore
#line 115 "C:\Bench\Daiki\ProstyleTechnology\17. Project From Japan\02.git\Project\GloableCommunication\Areas\Trainee\Views\TraineeMaster\GetFilteredData.cshtml"
               Write(Html.DisplayFor(modelItem => item.PositionStatus));

#line default
#line hidden
#nullable disable
            WriteLiteral("\r\n\r\n                </td>\r\n                <td style=\"font-size:x-small\">\r\n");
#nullable restore
#line 119 "C:\Bench\Daiki\ProstyleTechnology\17. Project From Japan\02.git\Project\GloableCommunication\Areas\Trainee\Views\TraineeMaster\GetFilteredData.cshtml"
                     foreach (var row in item.Acceptings)
                    {
                        

#line default
#line hidden
#nullable disable
#nullable restore
#line 121 "C:\Bench\Daiki\ProstyleTechnology\17. Project From Japan\02.git\Project\GloableCommunication\Areas\Trainee\Views\TraineeMaster\GetFilteredData.cshtml"
                   Write(Html.DisplayFor(modelItem => row.AcceptiingCompanyName));

#line default
#line hidden
#nullable disable
#nullable restore
#line 121 "C:\Bench\Daiki\ProstyleTechnology\17. Project From Japan\02.git\Project\GloableCommunication\Areas\Trainee\Views\TraineeMaster\GetFilteredData.cshtml"
                                                                                

                    }

#line default
#line hidden
#nullable disable
            WriteLiteral("                </td>\r\n                <td style=\"font-size:x-small\">\r\n");
#nullable restore
#line 126 "C:\Bench\Daiki\ProstyleTechnology\17. Project From Japan\02.git\Project\GloableCommunication\Areas\Trainee\Views\TraineeMaster\GetFilteredData.cshtml"
                     foreach (var row in item.OccupationLists)
                    {
                        

#line default
#line hidden
#nullable disable
#nullable restore
#line 128 "C:\Bench\Daiki\ProstyleTechnology\17. Project From Japan\02.git\Project\GloableCommunication\Areas\Trainee\Views\TraineeMaster\GetFilteredData.cshtml"
                   Write(Html.DisplayFor(modelItem => row.OccupationName));

#line default
#line hidden
#nullable disable
#nullable restore
#line 128 "C:\Bench\Daiki\ProstyleTechnology\17. Project From Japan\02.git\Project\GloableCommunication\Areas\Trainee\Views\TraineeMaster\GetFilteredData.cshtml"
                                                                         
                    }

#line default
#line hidden
#nullable disable
            WriteLiteral("                </td>\r\n                <td style=\"font-size:x-small\">\r\n");
#nullable restore
#line 132 "C:\Bench\Daiki\ProstyleTechnology\17. Project From Japan\02.git\Project\GloableCommunication\Areas\Trainee\Views\TraineeMaster\GetFilteredData.cshtml"
                     foreach (var row in item.WorkList)
                    {
                        

#line default
#line hidden
#nullable disable
#nullable restore
#line 134 "C:\Bench\Daiki\ProstyleTechnology\17. Project From Japan\02.git\Project\GloableCommunication\Areas\Trainee\Views\TraineeMaster\GetFilteredData.cshtml"
                   Write(Html.DisplayFor(modelItem => row.WorkName));

#line default
#line hidden
#nullable disable
#nullable restore
#line 134 "C:\Bench\Daiki\ProstyleTechnology\17. Project From Japan\02.git\Project\GloableCommunication\Areas\Trainee\Views\TraineeMaster\GetFilteredData.cshtml"
                                                                   
                    }

#line default
#line hidden
#nullable disable
            WriteLiteral("                </td>\r\n                <td style=\"font-size:x-small\">\r\n");
#nullable restore
#line 138 "C:\Bench\Daiki\ProstyleTechnology\17. Project From Japan\02.git\Project\GloableCommunication\Areas\Trainee\Views\TraineeMaster\GetFilteredData.cshtml"
                     foreach (var row in item.Sendings)
                    {
                        

#line default
#line hidden
#nullable disable
#nullable restore
#line 140 "C:\Bench\Daiki\ProstyleTechnology\17. Project From Japan\02.git\Project\GloableCommunication\Areas\Trainee\Views\TraineeMaster\GetFilteredData.cshtml"
                   Write(Html.DisplayFor(modelItem => row.SendingName));

#line default
#line hidden
#nullable disable
#nullable restore
#line 140 "C:\Bench\Daiki\ProstyleTechnology\17. Project From Japan\02.git\Project\GloableCommunication\Areas\Trainee\Views\TraineeMaster\GetFilteredData.cshtml"
                                                                      
                    }

#line default
#line hidden
#nullable disable
            WriteLiteral("                </td>\r\n                <td style=\"font-size:x-small\">\r\n                    <a class=\"btn btn-primary btn-sm\"");
            BeginWriteAttribute("href", " href=\'", 4637, "\'", 4681, 2);
            WriteAttributeValue("", 4644, "DetailViewTrainee/?Id=", 4644, 22, true);
#nullable restore
#line 144 "C:\Bench\Daiki\ProstyleTechnology\17. Project From Japan\02.git\Project\GloableCommunication\Areas\Trainee\Views\TraineeMaster\GetFilteredData.cshtml"
WriteAttributeValue("", 4666, item.TraineeId, 4666, 15, false);

#line default
#line hidden
#nullable disable
            EndWriteAttribute();
            WriteLiteral(">??????</a>\r\n                    <a class=\"btn btn-primary btn-sm\"");
            BeginWriteAttribute("href", " href=\'", 4744, "\'", 4782, 2);
            WriteAttributeValue("", 4751, "EditTrainee/?Id=", 4751, 16, true);
#nullable restore
#line 145 "C:\Bench\Daiki\ProstyleTechnology\17. Project From Japan\02.git\Project\GloableCommunication\Areas\Trainee\Views\TraineeMaster\GetFilteredData.cshtml"
WriteAttributeValue("", 4767, item.TraineeId, 4767, 15, false);

#line default
#line hidden
#nullable disable
            EndWriteAttribute();
            WriteLiteral(">??????</a>\r\n                </td>\r\n            </tr>\r\n");
#nullable restore
#line 148 "C:\Bench\Daiki\ProstyleTechnology\17. Project From Japan\02.git\Project\GloableCommunication\Areas\Trainee\Views\TraineeMaster\GetFilteredData.cshtml"
        }

#line default
#line hidden
#nullable disable
            WriteLiteral("    </tbody>\r\n</table>\r\n\r\n\r\n\r\n");
            WriteLiteral(@"
<script>
    $(""#btnExcel"").click(function () {
        tableToExcel('dtDesign', 'W3C Example Table');
    });


    var tableToExcel = (function () {
        var uri = 'data:application/vnd.ms-excel;base64,'
            , template = '<html xmlns:o=""urn:schemas-microsoft-com:office:office"" xmlns:x=""urn:schemas-microsoft-com:office:excel"" xmlns=""http://www.w3.org/TR/REC-html40""><head><!--[if gte mso 9]><xml><x:ExcelWorkbook><x:ExcelWorksheets><x:ExcelWorksheet><x:Name>{worksheet}</x:Name><x:WorksheetOptions><x:DisplayGridlines/></x:WorksheetOptions></x:ExcelWorksheet></x:ExcelWorksheets></x:ExcelWorkbook></xml><![endif]--></head><body><table>{table}</table></body></html>'
            , base64 = function (s) { return window.btoa(unescape(encodeURIComponent(s))) }
            , format = function (s, c) { return s.replace(/{(\w+)}/g, function (m, p) { return c[p]; }) }
        return function (table, name) {
            if (!table.nodeType) table = document.getElementById(table)
            var ctx");
            WriteLiteral(" = { worksheet: name || \'Worksheet\', table: table.innerHTML }\r\n            window.location.href = uri + base64(format(template, ctx))\r\n        }\r\n    })()\r\n\r\n</script>\r\n\r\n\r\n");
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
        public global::Microsoft.AspNetCore.Mvc.Rendering.IHtmlHelper<IEnumerable<GloableCommunication.Areas.Trainee.Models.ViewModel.TraineeMasterViewModel>> Html { get; private set; }
    }
}
#pragma warning restore 1591
