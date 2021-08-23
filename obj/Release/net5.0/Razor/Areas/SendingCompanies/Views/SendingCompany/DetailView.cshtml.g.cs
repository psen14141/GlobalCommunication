#pragma checksum "C:\Bench\Daiki\ProstyleTechnology\17. Project From Japan\02.git\Project\GloableCommunication\Areas\SendingCompanies\Views\SendingCompany\DetailView.cshtml" "{ff1816ec-aa5e-4d10-87f7-6f4963833460}" "9b6879bbbb227e28b377b21bca87e66d9663ec4b"
// <auto-generated/>
#pragma warning disable 1591
[assembly: global::Microsoft.AspNetCore.Razor.Hosting.RazorCompiledItemAttribute(typeof(AspNetCore.Areas_SendingCompanies_Views_SendingCompany_DetailView), @"mvc.1.0.view", @"/Areas/SendingCompanies/Views/SendingCompany/DetailView.cshtml")]
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
    [global::Microsoft.AspNetCore.Razor.Hosting.RazorSourceChecksumAttribute(@"SHA1", @"9b6879bbbb227e28b377b21bca87e66d9663ec4b", @"/Areas/SendingCompanies/Views/SendingCompany/DetailView.cshtml")]
    public class Areas_SendingCompanies_Views_SendingCompany_DetailView : global::Microsoft.AspNetCore.Mvc.Razor.RazorPage<GloableCommunication.Areas.SendingCompanies.Model.ViewModels.SendingCompanyViewModel>
    {
        #pragma warning disable 1998
        public async override global::System.Threading.Tasks.Task ExecuteAsync()
        {
            WriteLiteral("\r\n");
#nullable restore
#line 4 "C:\Bench\Daiki\ProstyleTechnology\17. Project From Japan\02.git\Project\GloableCommunication\Areas\SendingCompanies\Views\SendingCompany\DetailView.cshtml"
  
    ViewData["Title"] = "DetailView";
    Layout = "~/Views/Shared/_Layout.cshtml";

#line default
#line hidden
#nullable disable
            WriteLiteral(@"
<meta name=""viewport"" content=""width=device-width, initial-scale=1"">
<link rel=""stylesheet"" href=""https://www.w3schools.com/w3css/4/w3.css"">
<link rel=""stylesheet"" href=""https://www.w3schools.com/w3css/4/w3.css"">
<link rel=""stylesheet"" href=""https://cdnjs.cloudflare.com/ajax/libs/font-awesome/4.7.0/css/font-awesome.min.css"">

<div class=""w3-padding w3-white"">
    <div>
        <button class=""w3-button w3-green"" onclick=""location.href = '/SendingCompanies/SendingCompany/'""><i class=""fa fa-arrow-left""></i></button>
        <button class=""w3-button w3-light-green"" onclick=""updateDiv()""><i class=""fa fa-refresh""></i></button>
        <button class=""w3-button w3-light-blue"" onclick=""PrintDiv()""><i class=""fa fa-print""></i></button>
    </div>
    <div>
        <a asp-action=""Create"" style=""font-size:15px; padding-left:10px"">戻る</a>
        <a asp-action=""Create"" style=""font-size:15px; padding-left:10px"">編集</a>
        <a asp-action=""Create"" style=""font-size:15px; padding-right:10px"">印刷</a>
        <p");
            WriteLiteral(" style=\"text-align:right\">更新日: 2018/08/10</p>\r\n    </div>\r\n</div>\r\n\r\n<div class=\"w3-container w3-margin-top w3-gray\">\r\n    <h5 style=\"text-align:center\">送出機関情報</h5>\r\n</div>\r\n\r\n\r\n");
            DefineSection("Scripts", async() => {
                WriteLiteral("\r\n");
#nullable restore
#line 34 "C:\Bench\Daiki\ProstyleTechnology\17. Project From Japan\02.git\Project\GloableCommunication\Areas\SendingCompanies\Views\SendingCompany\DetailView.cshtml"
      await Html.RenderPartialAsync("_ValidationScriptsPartial");

#line default
#line hidden
#nullable disable
            }
            );
            WriteLiteral("\r\n\r\n<div id=\"divcontent\">\r\n    <dl class=\"row\">\r\n        <dt class=\"col-sm-2\">\r\n            送出機関CD\r\n        </dt>\r\n        <dd class=\"col-sm-10\">\r\n            ");
#nullable restore
#line 44 "C:\Bench\Daiki\ProstyleTechnology\17. Project From Japan\02.git\Project\GloableCommunication\Areas\SendingCompanies\Views\SendingCompany\DetailView.cshtml"
       Write(Model.SendingCompanyDetail.SendingComapny);

#line default
#line hidden
#nullable disable
            WriteLiteral("\r\n        </dd>\r\n        <dt class=\"col-sm-2\">\r\n            送出機関名\r\n        </dt>\r\n        <dd class=\"col-sm-10\">\r\n            <span style=\"color:brown;\">");
#nullable restore
#line 50 "C:\Bench\Daiki\ProstyleTechnology\17. Project From Japan\02.git\Project\GloableCommunication\Areas\SendingCompanies\Views\SendingCompany\DetailView.cshtml"
                                  Write(Model.SendingCompanyDetail.SendingName);

#line default
#line hidden
#nullable disable
            WriteLiteral("</span>\r\n        </dd>\r\n        <dt class=\"col-sm-2\">\r\n            正式名称\r\n        </dt>\r\n        <dd class=\"col-sm-10\">\r\n            <span style=\"color:brown;\">");
#nullable restore
#line 56 "C:\Bench\Daiki\ProstyleTechnology\17. Project From Japan\02.git\Project\GloableCommunication\Areas\SendingCompanies\Views\SendingCompany\DetailView.cshtml"
                                  Write(Model.SendingCompanyDetail.Fullname);

#line default
#line hidden
#nullable disable
            WriteLiteral("</span>\r\n        </dd>\r\n        <dt class=\"col-sm-2\">\r\n            国区分\r\n        </dt>\r\n        <dd class=\"col-sm-10\">\r\n");
#nullable restore
#line 62 "C:\Bench\Daiki\ProstyleTechnology\17. Project From Japan\02.git\Project\GloableCommunication\Areas\SendingCompanies\Views\SendingCompany\DetailView.cshtml"
             foreach (var row in Model.sendingCountry)
            {

                

#line default
#line hidden
#nullable disable
#nullable restore
#line 65 "C:\Bench\Daiki\ProstyleTechnology\17. Project From Japan\02.git\Project\GloableCommunication\Areas\SendingCompanies\Views\SendingCompany\DetailView.cshtml"
           Write(row.CountryName);

#line default
#line hidden
#nullable disable
#nullable restore
#line 65 "C:\Bench\Daiki\ProstyleTechnology\17. Project From Japan\02.git\Project\GloableCommunication\Areas\SendingCompanies\Views\SendingCompany\DetailView.cshtml"
                                

            }

#line default
#line hidden
#nullable disable
            WriteLiteral("\r\n        </dd>\r\n        <dt class=\"col-sm-2\">\r\n            地域区分\r\n        </dt>\r\n        <dd class=\"col-sm-10\">\r\n");
#nullable restore
#line 74 "C:\Bench\Daiki\ProstyleTechnology\17. Project From Japan\02.git\Project\GloableCommunication\Areas\SendingCompanies\Views\SendingCompany\DetailView.cshtml"
             foreach (var row in Model.sendingArea)
            {

                

#line default
#line hidden
#nullable disable
#nullable restore
#line 77 "C:\Bench\Daiki\ProstyleTechnology\17. Project From Japan\02.git\Project\GloableCommunication\Areas\SendingCompanies\Views\SendingCompany\DetailView.cshtml"
           Write(row.AreaName);

#line default
#line hidden
#nullable disable
#nullable restore
#line 77 "C:\Bench\Daiki\ProstyleTechnology\17. Project From Japan\02.git\Project\GloableCommunication\Areas\SendingCompanies\Views\SendingCompany\DetailView.cshtml"
                             

            }

#line default
#line hidden
#nullable disable
            WriteLiteral("        </dd>\r\n        <dt class=\"col-sm-2\">\r\n            所在地\r\n        </dt>\r\n        <dd class=\"col-sm-10\">\r\n            <span style=\"color:red;\"><b>〒 </b></span>");
#nullable restore
#line 85 "C:\Bench\Daiki\ProstyleTechnology\17. Project From Japan\02.git\Project\GloableCommunication\Areas\SendingCompanies\Views\SendingCompany\DetailView.cshtml"
                                                Write(Model.SendingCompanyDetail.Zip);

#line default
#line hidden
#nullable disable
            WriteLiteral("\r\n        </dd>\r\n        <dt class=\"col-sm-2\">\r\n\r\n        </dt>\r\n        <dd class=\"col-sm-10\">\r\n            <span style=\"color:brown;\">");
#nullable restore
#line 91 "C:\Bench\Daiki\ProstyleTechnology\17. Project From Japan\02.git\Project\GloableCommunication\Areas\SendingCompanies\Views\SendingCompany\DetailView.cshtml"
                                  Write(Model.SendingCompanyDetail.Address1);

#line default
#line hidden
#nullable disable
            WriteLiteral("</span>\r\n        </dd>\r\n        <dt class=\"col-sm-2\">\r\n\r\n        </dt>\r\n        <dd class=\"col-sm-10\">\r\n            <span style=\"color:brown;\">");
#nullable restore
#line 97 "C:\Bench\Daiki\ProstyleTechnology\17. Project From Japan\02.git\Project\GloableCommunication\Areas\SendingCompanies\Views\SendingCompany\DetailView.cshtml"
                                  Write(Model.SendingCompanyDetail.Address2);

#line default
#line hidden
#nullable disable
            WriteLiteral("</span>\r\n        </dd>\r\n        <dt class=\"col-sm-2\">\r\n            連絡先\r\n        </dt>\r\n        <dd class=\"col-sm-2\">\r\n            <b>TELL</b>\r\n        </dd>\r\n        <dd class=\"col-sm-2\">\r\n            ");
#nullable restore
#line 106 "C:\Bench\Daiki\ProstyleTechnology\17. Project From Japan\02.git\Project\GloableCommunication\Areas\SendingCompanies\Views\SendingCompany\DetailView.cshtml"
       Write(Model.SendingCompanyDetail.Telephone);

#line default
#line hidden
#nullable disable
            WriteLiteral("\r\n        </dd>\r\n        <dd class=\"col-sm-2\">\r\n\r\n        </dd>\r\n        <dd class=\"col-sm-2\">\r\n            <b>FAX</b>\r\n        </dd>\r\n        <dd class=\"col-sm-2\">\r\n            ");
#nullable restore
#line 115 "C:\Bench\Daiki\ProstyleTechnology\17. Project From Japan\02.git\Project\GloableCommunication\Areas\SendingCompanies\Views\SendingCompany\DetailView.cshtml"
       Write(Model.SendingCompanyDetail.Fax);

#line default
#line hidden
#nullable disable
            WriteLiteral("\r\n        </dd>\r\n        <dt class=\"col-sm-2\">\r\n            代表者\r\n        </dt>\r\n        <dd class=\"col-sm-10\">\r\n            <span style=\"color:brown;\">");
#nullable restore
#line 121 "C:\Bench\Daiki\ProstyleTechnology\17. Project From Japan\02.git\Project\GloableCommunication\Areas\SendingCompanies\Views\SendingCompany\DetailView.cshtml"
                                  Write(Model.SendingCompanyDetail.CheifExecutiveOfficer);

#line default
#line hidden
#nullable disable
            WriteLiteral("</span>\r\n        </dd>\r\n        <dt class=\"col-sm-2\">\r\n            担当者\r\n        </dt>\r\n        <dd class=\"col-sm-10\">\r\n            <span style=\"color:brown;\">");
#nullable restore
#line 127 "C:\Bench\Daiki\ProstyleTechnology\17. Project From Japan\02.git\Project\GloableCommunication\Areas\SendingCompanies\Views\SendingCompany\DetailView.cshtml"
                                  Write(Model.SendingCompanyDetail.Charge);

#line default
#line hidden
#nullable disable
            WriteLiteral("</span>\r\n        </dd>\r\n        <dt class=\"col-sm-2\">\r\n            担当者TEL\r\n        </dt>\r\n        <dd class=\"col-sm-10\">\r\n            ");
#nullable restore
#line 133 "C:\Bench\Daiki\ProstyleTechnology\17. Project From Japan\02.git\Project\GloableCommunication\Areas\SendingCompanies\Views\SendingCompany\DetailView.cshtml"
       Write(Model.SendingCompanyDetail.ChargeTelephone);

#line default
#line hidden
#nullable disable
            WriteLiteral("\r\n        </dd>\r\n        <dt class=\"col-sm-2\">\r\n            MEMO\r\n        </dt>\r\n        <dd class=\"col-sm-10\">\r\n            ");
#nullable restore
#line 139 "C:\Bench\Daiki\ProstyleTechnology\17. Project From Japan\02.git\Project\GloableCommunication\Areas\SendingCompanies\Views\SendingCompany\DetailView.cshtml"
       Write(Model.SendingCompanyDetail.Memo1);

#line default
#line hidden
#nullable disable
            WriteLiteral("\r\n        </dd>\r\n        <dt class=\"col-sm-2\">\r\n");
            WriteLiteral("        </dt>\r\n        <dd class=\"col-sm-10\">\r\n");
            WriteLiteral("        </dd>\r\n        <dt class=\"col-sm-2\">\r\n");
            WriteLiteral("        </dt>\r\n        <dd class=\"col-sm-10\">\r\n");
            WriteLiteral("        </dd>\r\n    </dl>\r\n</div>\r\n\r\n");
            WriteLiteral(@"<script>
    function goBack() {
        window.history.back();
    }
</script>

<script type=""text/javascript"">
    function PrintDiv() {
        var divContents = document.getElementById(""divcontent"").innerHTML;
        var printWindow = window.open('', '', 'height=200,width=400');
        printWindow.document.write('<html><head><title>Print DIV Content</title>');
        printWindow.document.write('</head><body >');
        printWindow.document.write(divContents);
        printWindow.document.write('</body></html>');
        printWindow.document.close();
        printWindow.print();
    }
</script>

<script>
    function updateDiv() {
        document.getElementById(""divcontent"").innerHTML.reload;
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
        public global::Microsoft.AspNetCore.Mvc.Rendering.IHtmlHelper<GloableCommunication.Areas.SendingCompanies.Model.ViewModels.SendingCompanyViewModel> Html { get; private set; }
    }
}
#pragma warning restore 1591