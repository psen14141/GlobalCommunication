#pragma checksum "C:\Bench\Daiki\ProstyleTechnology\17. Project From Japan\02.git\Project\GloableCommunication\Areas\Trainee\Views\TraineeMaster\TranningEngineerList.cshtml" "{ff1816ec-aa5e-4d10-87f7-6f4963833460}" "561e2950cb6c9aae176613c4f1138bbb87ef21d0"
// <auto-generated/>
#pragma warning disable 1591
[assembly: global::Microsoft.AspNetCore.Razor.Hosting.RazorCompiledItemAttribute(typeof(AspNetCore.Areas_Trainee_Views_TraineeMaster_TranningEngineerList), @"mvc.1.0.view", @"/Areas/Trainee/Views/TraineeMaster/TranningEngineerList.cshtml")]
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
    [global::Microsoft.AspNetCore.Razor.Hosting.RazorSourceChecksumAttribute(@"SHA1", @"561e2950cb6c9aae176613c4f1138bbb87ef21d0", @"/Areas/Trainee/Views/TraineeMaster/TranningEngineerList.cshtml")]
    public class Areas_Trainee_Views_TraineeMaster_TranningEngineerList : global::Microsoft.AspNetCore.Mvc.Razor.RazorPage<dynamic>
    {
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
        private global::Microsoft.AspNetCore.Mvc.Razor.TagHelpers.HeadTagHelper __Microsoft_AspNetCore_Mvc_Razor_TagHelpers_HeadTagHelper;
        #pragma warning disable 1998
        public async override global::System.Threading.Tasks.Task ExecuteAsync()
        {
            WriteLiteral("\r\n");
#nullable restore
#line 2 "C:\Bench\Daiki\ProstyleTechnology\17. Project From Japan\02.git\Project\GloableCommunication\Areas\Trainee\Views\TraineeMaster\TranningEngineerList.cshtml"
  
    ViewData["Title"] = "TranningEngineerList";
    Layout = "~/Views/Shared/_Layout.cshtml";

#line default
#line hidden
#nullable disable
            WriteLiteral(@"
<link rel=""stylesheet"" href=""https://cdnjs.cloudflare.com/ajax/libs/font-awesome/4.7.0/css/font-awesome.min.css"">
<link rel=""stylesheet"" href=""https://www.w3schools.com/w3css/4/w3.css"">
<link rel=""stylesheet"" href=""https://www.w3schools.com/w3css/4/w3.css"">
<script src=""https://cdn.jsdelivr.net/alasql/0.3/alasql.min.js""></script>
<script src=""https://cdnjs.cloudflare.com/ajax/libs/xlsx/0.7.12/xlsx.core.min.js""></script>

");
            __tagHelperExecutionContext = __tagHelperScopeManager.Begin("head", global::Microsoft.AspNetCore.Razor.TagHelpers.TagMode.StartTagAndEndTag, "561e2950cb6c9aae176613c4f1138bbb87ef21d03585", async() => {
                WriteLiteral(@"
    <style>
        .mybtn {
            background-color: green;
            border: none;
            color: white;
            padding: 12px 16px;
            font-size: 16px;
            cursor: pointer;
            border-radius: 5px;
        }

            /* Darker background on mouse-over */
            .mybtn:hover {
                background-color: forestgreen;
            }
        /* The container */
        .checkBoxcontainer {
            display: block;
            position: relative;
            align-content: center;
            padding-left: 35px;
            margin-bottom: 12px;
            cursor: pointer;
            float: left;
            font-size: 22px;
            -webkit-user-select: none;
            -moz-user-select: none;
            -ms-user-select: none;
            user-select: none;
        }

            /* Hide the browser's default radio button */
            .checkBoxcontainer input {
                position: absolute;
              ");
                WriteLiteral(@"  opacity: 0;
                cursor: pointer;
            }

        /* Create a custom radio button */
        .checkmark {
            position: absolute;
            top: 0;
            left: 0;
            height: 25px;
            width: 25px;
            background-color: #eee;
            border-radius: 50%;
        }

        /* On mouse-over, add a grey background color */
        .checkBoxcontainer:hover input ~ .checkmark {
            background-color: #ccc;
        }

        /* When the radio button is checked, add a blue background */
        .checkBoxcontainer input:checked ~ .checkmark {
            background-color: #2196F3;
        }

        /* Create the indicator (the dot/circle - hidden when not checked) */
        .checkmark:after {
            content: """";
            position: absolute;
            display: none;
        }

        /* Show the indicator (dot/circle) when checked */
        .checkBoxcontainer input:checked ~ .checkmark:after {
      ");
                WriteLiteral(@"      display: block;
        }

        /* Style the indicator (dot/circle) */
        .checkBoxcontainer .checkmark:after {
            top: 9px;
            left: 9px;
            width: 8px;
            height: 8px;
            border-radius: 50%;
            background: white;
        }
    </style>
");
            }
            );
            __Microsoft_AspNetCore_Mvc_Razor_TagHelpers_HeadTagHelper = CreateTagHelper<global::Microsoft.AspNetCore.Mvc.Razor.TagHelpers.HeadTagHelper>();
            __tagHelperExecutionContext.Add(__Microsoft_AspNetCore_Mvc_Razor_TagHelpers_HeadTagHelper);
            await __tagHelperRunner.RunAsync(__tagHelperExecutionContext);
            if (!__tagHelperExecutionContext.Output.IsContentModified)
            {
                await __tagHelperExecutionContext.SetOutputContentAsync();
            }
            Write(__tagHelperExecutionContext.Output);
            __tagHelperExecutionContext = __tagHelperScopeManager.End();
            WriteLiteral("\r\n<h1>技能実習生名簿作成</h1>\r\n<div class=\"card\" style=\"padding:15px\">\r\n    <div");
            BeginWriteAttribute("class", " class=\"", 2989, "\"", 2997, 0);
            EndWriteAttribute();
            WriteLiteral(@">
        <div>
            <button class=""w3-button w3-green"" onclick=""goHome()"" title=""Home""><i class=""fa fa-arrow-left""></i></button>
            <button class=""w3-button w3-blue"" onclick=""download_csv_file()"" id=""downExcel"" title=""Download csv file""><i class=""fa fa-download""></i></button>


            <div id=""downloadLink""></div>

        </div>
        <div>
            <a asp-action=""Create"" style=""font-size:15px; padding-left:10px"">戻る</a>
            <a asp-action=""Create"" style=""font-size:15px; padding-left:10px"">エクセル出力</a>
        </div>
    </div>
    <div class=""row"" style=""padding:20px;"">
        <div class=""col col-md-3""></div>
        <div class=""col col-md-6"" style=""align-content:center;"">
            <form onchange=""selectMenu()"" name=""frmRadio"" id=""radio-buttons""");
            BeginWriteAttribute("action", " action=\"", 3807, "\"", 3816, 0);
            EndWriteAttribute();
            WriteLiteral(">\r\n                <div class=\"checkBoxcontainer\">\r\n                    <label class=\"checkBoxcontainer\">\r\n                        警察提出書類  ");
            WriteLiteral(@"
                        <input type=""radio"" name=""radio1"" id=""radio1"">
                        <span class=""checkmark"" style=""padding:10px;""></span>
                    </label>
                </div>
                <div class=""checkBoxcontainer"">

                    <label class=""checkBoxcontainer"">
                        入管提出書類 ");
            WriteLiteral(@"
                        <input type=""radio"" name=""radio2"" id=""radio2"">
                        <span class=""checkmark"" style=""padding:10px;""></span>
                    </label>
                </div>
                <div class=""checkBoxcontainer"">

                    <label class=""checkBoxcontainer"">
                        自由形式  ");
            WriteLiteral(@"
                        <input type=""radio"" name=""radio3"" id=""radio3"">
                        <span class=""checkmark"" style=""padding:10px;""></span>
                    </label>
                </div>



            </form>
        </div>
        <div class=""col col-md-3""></div>



    </div>
    <div id=""myDiv"">
    </div>

    <div id=""loadDiv1""></div>
    <div id=""loadDiv2""></div>
    <div id=""loadDiv3""></div>
    <div id=""loadDiv4""><button class=""mybtn"" onclick=""addDropDownList();""");
            BeginWriteAttribute("name", " name=\"", 5235, "\"", 5242, 0);
            EndWriteAttribute();
            WriteLiteral(@" title=""Add drop down""><i class=""fa fa-plus""></i></button></div>
</div>

<script type=""text/javascript"">

    function ConvertToCSV(objArray) {

        //alert(""objArray = "" + JSON.stringify(objArray));
        var str = '';
        var line = '';
        var headers = [];
        objArray.forEach(function (item, index) {

            headers = [];
            for (var index in item['Instance']) {

                headers.push(index);
                line += item['Instance'][index].toString() + ',';
            }
            line += '\n';

        });

        str = convertToJapanese(headers) +'\n'+ line;

        //alert(""str = "" + str);
        var element = document.createElement('a');
        element.href = 'data:text/csv;charset=utf-8,' + encodeURI(str);
        element.target = '_blank';
        element.download = 'TraineerData' + getDateTime() + '.csv';
        element.click();



       // return  str;
    }

    function convertToJapanese(entry) {
        var en");
            WriteLiteral(@"try_new = [];
        // alert(""entry.length = "" + entry.length);
        for (var k = 1; k <= entry.length; k++) {

            if (entry[k - 1] == ""TraineeId"") {
                entry_new[k - 1] = ""実習生No"";
            } else if (entry[k - 1] == ""TraineeName"") {
                entry_new[k - 1] = ""氏名(英)"";
            } else if (entry[k - 1] == ""KanjiName"") {
                entry_new[k - 1] = ""氏名(日)"";
            } else if (entry[k - 1] == ""KatakanaName"") {
                entry_new[k - 1] = ""フリガナ"";
            } else if (entry[k - 1] == ""Sex_Flag"") {
                entry_new[k - 1] = ""性別"";
            } else if (entry[k - 1] == ""BirthDate"") {
                entry_new[k - 1] = ""生年月日"";
            } else if (entry[k - 1] == ""Immigrationstatus"") {
                entry_new[k - 1] = ""入国状況"";
            } else if (entry[k - 1] == ""entrance_date"") {
                entry_new[k - 1] = ""入国日"";
            } else if (entry[k - 1] == ""Schlarship"") {
                entry_new[k - 1] = ""期生"";
    ");
            WriteLiteral(@"        } else if (entry[k - 1] == ""OccupationId"") {
                entry_new[k - 1] = ""実習職種"";
            } else if (entry[k - 1] == ""SendingCompanyId"") {
                entry_new[k - 1] = ""送出機関"";
            } else if (entry[k - 1] == ""CountryId"") {
                entry_new[k - 1] = ""国籍"";
            } else if (entry[k - 1] == ""ResidentCardExpireDate"") {
                entry_new[k - 1] = ""在留資格"";
            } else if (entry[k - 1] == ""ResidentCardNo"") {
                entry_new[k - 1] = ""在留カード番号"";
            }

        }
        //alert(""entry_new = "" + JSON.stringify(entry_new));

        return entry_new;
    }

</script>
<script>
    var i;
    function addDropDownList() {
        //alert(""i= ""+i);
        i++;
        if (document.getElementById(""radio3"").checked) {
            //alert(""Radio button 3 clicked"");
            $(""#loadDrop3"").append('<div class=""col col-md-4"" style=""padding:25px;""><select class=""form-control"" name=""option_3' + '_' + i + '"" id=""option_3' + '_");
            WriteLiteral(@"' + i + '""><option value=""2"">実習生No</option><option value=""3"" selected>氏名(英)</option><option value=""4"">氏名(日)</option><option value=""2"">フリガナ</option><option value=""3"">性別</option><option value=""4"">生年月日</option><option value=""2"">入国状況</option><option value=""3"">入国日</option><option value=""4"">在留資格</option><option value=""2"" >期生</option><option value=""3"">実習職種</option><option value=""4"">送出機関</option><option value=""3"">国籍</option><option value=""4"">在留カード番号</option></select></div>');

        } else if (document.getElementById(""radio2"").checked) {
            //alert(""Radio button 2 clicked"");
            $(""#loadDrop2"").append('<div class=""col col-md-4"" style=""padding:25px;""><select class=""form-control"" name=""option_2' + '_' + i + '"" id=""option_2' + '_' + i + '""><option value=""2"">実習生No</option><option value=""3"" selected>氏名(英)</option><option value=""4"">氏名(日)</option><option value=""2"">フリガナ</option><option value=""3"">性別</option><option value=""4"">生年月日</option><option value=""2"">入国状況</option><option value=""3"">入国日</option><opti");
            WriteLiteral(@"on value=""4"">在留資格</option><option value=""2"" >期生</option><option value=""3"">実習職種</option><option value=""4"">送出機関</option><option value=""3"">国籍</option><option value=""4"">在留カード番号</option></select></div>');

        } else if (document.getElementById(""radio1"").checked) {
            //alert(""Radio button 1 clicked"");
            $(""#loadDrop1"").append('<div class=""col col-md-4"" style=""padding:25px;""><select class=""form-control"" name=""option_1' + '_' + i + '"" id=""option_1' + '_' + i + '""><option value=""2"">実習生No</option><option value=""3"" selected>氏名(英)</option><option value=""4"">氏名(日)</option><option value=""2"">フリガナ</option><option value=""3"">性別</option><option value=""4"">生年月日</option><option value=""2"">入国状況</option><option value=""3"">入国日</option><option value=""4"">在留資格</option><option value=""2"" >期生</option><option value=""3"">実習職種</option><option value=""4"">送出機関</option><option value=""3"">国籍</option><option value=""4"">在留カード番号</option></select></div>');

        }

    }


    function download_csv_file() {

        ");
            WriteLiteral(@"//alert(""***Download excel***\n "" + i + "" of options were selected here!"");
        var selectedRadiobutton = 0;
        var acceptCom = """";
        var headersJapanese = [];
        var TblheadersEng = [];
        if (document.getElementById(""radio1"").checked) {
            selectedRadiobutton = 1;
        } else if (document.getElementById(""radio2"").checked) {
            selectedRadiobutton = 2;
            acceptCom = $(""#companies_2"").find("":selected"").val();
        } else if (document.getElementById(""radio3"").checked) {
            selectedRadiobutton = 3;
            acceptCom = $(""#companies_3"").find("":selected"").val();
        }
        //alert(""selectedRadiobutton = "" + selectedRadiobutton);
        for (var k = 1; k <= i; k++) {

            headersJapanese[k - 1] = $(""#"" + ""option_"" + selectedRadiobutton + ""_"" + k).find("":selected"").text();
            //alert(JSON.stringify(headersJapanese[k - 1]));
            if (headersJapanese[k - 1] == ""実習生No"") {
                Tblheade");
            WriteLiteral(@"rsEng[k - 1] = ""TraineeId"";
            } else if (headersJapanese[k - 1] == ""氏名(英)"") {
                TblheadersEng[k - 1] = ""TraineeName"";
            } else if (headersJapanese[k - 1] == ""氏名(日)"") {
                TblheadersEng[k - 1] = ""KanjiName"";
            } else if (headersJapanese[k - 1] == ""フリガナ"") {
                TblheadersEng[k - 1] = ""KatakanaName"";
            } else if (headersJapanese[k - 1] == ""性別"") {
                TblheadersEng[k - 1] = ""Sex_Flag"";
            } else if (headersJapanese[k - 1] == ""生年月日"") {
                TblheadersEng[k - 1] = ""BirthDate"";
            } else if (headersJapanese[k - 1] == ""入国状況"") {
                TblheadersEng[k - 1] = ""Immigrationstatus"";
            } else if (headersJapanese[k - 1] == ""入国日"") {
                TblheadersEng[k - 1] = ""entrance_date"";
            } else if (headersJapanese[k - 1] == ""期生"") {
                TblheadersEng[k - 1] = ""Schlarship"";
            } else if (headersJapanese[k - 1] == ""実習職種"") {
                T");
            WriteLiteral(@"blheadersEng[k - 1] = ""OccupationId"";
            } else if (headersJapanese[k - 1] == ""送出機関"") {
                TblheadersEng[k - 1] = ""SendingCompanyId"";
            } else if (headersJapanese[k - 1] == ""国籍"") {
                TblheadersEng[k - 1] = ""CountryId"";
            } else if (headersJapanese[k - 1] == ""在留資格"") {
                TblheadersEng[k - 1] = ""ResidentCardExpireDate"";
            } else if (headersJapanese[k - 1] == ""在留カード番号"") {
                TblheadersEng[k - 1] = ""ResidentCardNo"";
            }

        }


        var sendDataRequest = {
            tblHeaders: TblheadersEng,
            accepCompany: acceptCom,
            sRadioBtn: selectedRadiobutton
        };
       // alert(JSON.stringify(sendDataRequest));

        $.ajax({
            url: '/Trainee/TraineeMaster/GetTraineerData',
            type: 'post',
            dataType: 'json',
            contentType: 'application/json',
            data: JSON.stringify(sendDataRequest),
            success: ");
            WriteLiteral(@"function (data) {
                //alert(""done"" + JSON.stringify(data));
            },
        }).done(function (my_json) {

            //alert(""awa"" + JSON.stringify( my_json));

            if (my_json == ""Nodata"") {
                alert(""Please Fill in the database"");

            } else if (my_json == ""NoselectedDropDown"") {

                alert(""Please add drop down"");
            } else {
                ConvertToCSV(my_json);
            }




        });


    }
    function getDateTime() {
        var now = new Date();
        var year = now.getFullYear();
        var month = now.getMonth() + 1;
        var day = now.getDate();
        var hour = now.getHours();
        var minute = now.getMinutes();
        var second = now.getSeconds();
        if (month.toString().length == 1) {
            month = '0' + month;
        }
        if (day.toString().length == 1) {
            day = '0' + day;
        }
        if (hour.toString().length == 1) {
          ");
            WriteLiteral(@"  hour = '0' + hour;
        }
        if (minute.toString().length == 1) {
            minute = '0' + minute;
        }
        if (second.toString().length == 1) {
            second = '0' + second;
        }
        var dateTime = year + '-' + month + '-' + day + '_' + hour + '-' + minute;
        return dateTime;
    }


    function selectMenu() {

        var companies = [];

        //alert(""selectMenu......"" );
        $.ajax({
            url: '/Trainee/TraineeMaster/GetAcceptingCompanies',
            type: 'get',
        }).done(function (comp) {




            if (document.getElementById(""radio1"").checked) {

                document.getElementById(""loadDiv1"").innerHTML = '<div class=""row""><div class=""col col-md-4""><div class=""row"" style=""padding: 20px; "" hidden><div class=""col col-md-8"" id=""""></div><div class=""col col-md-2""></div></div></div></div><div class=""row"" style=""padding:10px;""><div class=""row"" style=""padding: 25px; float: left; width: 100%""><label for=""抽出項目"">");
            WriteLiteral(@"抽出項目:</label></div><div class=""row"" style="""" id=""loadDrop1""><div class=""col col-md-4"" style=""padding:25px;""><select class=""form-control"" name=""option_1_1"" id=""option_1_1""><option value=""2"">実習生No</option><option value=""3"">氏名(英)</option><option value=""4"">氏名(日)</option><option value=""2"">フリガナ</option><option value=""3"">性別</option><option value=""4"">生年月日</option><option value=""2"">入国状況</option><option value=""3"">入国日</option><option value=""4"">在留資格</option><option value=""2"">期生</option><option value=""3"">実習職種</option><option value=""4"">送出機関</option><option value=""3"" selected>国籍</option><option value=""4"">在留カード番号</option></select></div><div class=""col col-md-4"" style=""padding:25px;""><select class=""form-control"" name=""option_1_2"" id=""option_1_2""><option value=""2"">実習生No</option><option value=""3"" selected>氏名(英)</option><option value=""4"">氏名(日)</option><option value=""2"">フリガナ</option><option value=""3"">性別</option><option value=""4"">生年月日</option><option value=""2"">入国状況</option><option value=""3"">入国日</option><option value=""4"">在留資格</opti");
            WriteLiteral(@"on><option value=""2"">期生</option><option value=""3"">実習職種</option><option value=""4"">送出機関</option><option value=""3"">国籍</option><option value=""4"">在留カード番号</option></select></div><div class=""col col-md-4"" style=""padding:25px;""><select class=""form-control"" name=""option_1_3"" id=""option_1_3""><option value=""2"">実習生No</option><option value=""3"">氏名(英)</option><option value=""4"">氏名(日)</option><option value=""2"">フリガナ</option><option value=""3"" selected>性別</option><option value=""4"">生年月日</option><option value=""2"">入国状況</option><option value=""3"">入国日</option><option value=""4"">在留資格</option><option value=""2"">期生</option><option value=""3"">実習職種</option><option value=""4"">送出機関</option><option value=""3"">国籍</option><option value=""4"">在留カード番号</option></select></div><div class=""col col-md-4"" style=""padding:25px;""><select class=""form-control"" name=""option_1_4"" id=""option_1_4""><option value=""2"">実習生No</option><option value=""3"">氏名(英)</option><option value=""4"">氏名(日)</option><option value=""2"">フリガナ</option><option value=""3"">性別</option><option value=""4""");
            WriteLiteral(@" selected>生年月日</option><option value=""2"">入国状況</option><option value=""3"">入国日</option><option value=""4"">在留資格</option><option value=""2"">期生</option><option value=""3"">実習職種</option><option value=""4"">送出機関</option><option value=""3"">国籍</option><option value=""4"">在留カード番号</option></select></div><div class=""col col-md-4"" style=""padding:25px;""><select class=""form-control"" name=""option_1_5"" id=""option_1_5""><option value=""2"">実習生No</option><option value=""3"">氏名(英)</option><option value=""4"">氏名(日)</option><option value=""2"">フリガナ</option><option value=""3"">性別</option><option value=""4"">生年月日</option><option value=""2"">入国状況</option><option value=""3"" selected>入国日</option><option value=""4"">在留資格</option><option value=""2"">期生</option><option value=""3"">実習職種</option><option value=""4"">送出機関</option><option value=""3"">国籍</option><option value=""4"">在留カード番号</option></select></div><div class=""col col-md-4"" style=""padding:25px;""><select class=""form-control"" name=""option_1_6"" id=""option_1_6""><option value=""2"">実習生No</option><option value=""3"">氏名(英)</opti");
            WriteLiteral(@"on><option value=""4"">氏名(日)</option><option value=""2"">フリガナ</option><option value=""3"">性別</option><option value=""4"">生年月日</option><option value=""2"">入国状況</option><option value=""3"">入国日</option><option value=""4"">在留資格</option><option value=""2"">期生</option><option value=""3"">実習職種</option><option value=""4"">送出機関</option><option value=""3"">国籍</option><option value=""4"" selected>在留カード番号</option></select></div></div></div>';
                i = 6;
            } else if (document.getElementById(""radio2"").checked) {
                document.getElementById(""loadDiv2"").innerHTML = '<div class=""row""><div class=""col col-md-4""><div class=""row"" style=""padding: 20px; ""><div class=""col col-md-8"" id=""addselect1""></div><div class=""col col-md-2""></div></div></div></div><div class=""row"" style=""padding:10px;""><div class=""row"" style=""padding: 25px; float: left; width: 100%""><label for=""抽出項目"">抽出項目:</label></div><div class=""row"" style="""" id=""loadDrop2""><div class=""col col-md-4"" style=""padding:25px;""><select class=""form-control"" name=""option_");
            WriteLiteral(@"2_1"" id=""option_2_1""><option value=""2"">実習生No</option><option value=""3"">氏名(英)</option><option value=""4"">氏名(日)</option><option value=""2"">フリガナ</option><option value=""3"">性別</option><option value=""4"">生年月日</option><option value=""2"">入国状況</option><option value=""3"">入国日</option><option value=""4"">在留資格</option><option value=""2"" selected>期生</option><option value=""3"">実習職種</option><option value=""4"">送出機関</option><option value=""3"">国籍</option><option value=""4"">在留カード番号</option></select></div><div class=""col col-md-4"" style=""padding:25px;""><select class=""form-control"" name=""option_2_2"" id=""option_2_2""><option value=""2"">実習生No</option><option value=""3"" selected>氏名(英)</option><option value=""4"">氏名(日)</option><option value=""2"">フリガナ</option><option value=""3"">性別</option><option value=""4"">生年月日</option><option value=""2"">入国状況</option><option value=""3"">入国日</option><option value=""4"">在留資格</option><option value=""2"">期生</option><option value=""3"">実習職種</option><option value=""4"">送出機関</option><option value=""3"">国籍</option><option value=""4"">在留カード番号</");
            WriteLiteral(@"option></select></div><div class=""col col-md-4"" style=""padding:25px;""><select class=""form-control"" name=""option_2_3"" id=""option_2_3""><option value=""2"">実習生No</option><option value=""3"">氏名(英)</option><option value=""4"">氏名(日)</option><option value=""2"" selected>フリガナ</option><option value=""3"">性別</option><option value=""4"">生年月日</option><option value=""2"">入国状況</option><option value=""3"">入国日</option><option value=""4"">在留資格</option><option value=""2"">期生</option><option value=""3"">実習職種</option><option value=""4"">送出機関</option><option value=""3"">国籍</option><option value=""4"">在留カード番号</option></select></div><div class=""col col-md-4"" style=""padding:25px;""><select class=""form-control"" name=""option_2_4"" id=""option_2_4""><option value=""2"">実習生No</option><option value=""3"">氏名(英)</option><option value=""4"">氏名(日)</option><option value=""2"">フリガナ</option><option value=""3"">性別</option><option value=""4"">生年月日</option><option value=""2"">入国状況</option><option value=""3"" selected>入国日</option><option value=""4"">在留資格</option><option value=""2"">期生</option><optio");
            WriteLiteral(@"n value=""3"">実習職種</option><option value=""4"">送出機関</option><option value=""3"">国籍</option><option value=""4"">在留カード番号</option></select></div><div class=""col col-md-4"" style=""padding:25px;""><select class=""form-control"" name=""option_2_5"" id=""option_2_5""><option value=""2"">実習生No</option><option value=""3"">氏名(英)</option><option value=""4"">氏名(日)</option><option value=""2"">フリガナ</option><option value=""3"">性別</option><option value=""4"">生年月日</option><option value=""2"">入国状況</option><option value=""3"">入国日</option><option value=""4"" selected>在留資格</option><option value=""2"">期生</option><option value=""3"">実習職種</option><option value=""4"">送出機関</option><option value=""3"">国籍</option><option value=""4"">在留カード番号</option></select></div></div></div>';
                i = 5;
                var select = $('<select class=""form-control"">').prop('id', 'companies_2').prop('name', 'companies_2');

                comp.forEach(function (item, index) {
                    //alert(index + "" "" + item[""acompanyName""]);
                    select.append($('<o");
            WriteLiteral(@"ption></option>').attr('value', item[""aCompanyId""]).text(item[""acompanyName""]));
                });
                var label = $(""<label>"").prop('for', 'companies').text(""受け入れ先企業: "");

                var br = $(""<br>"");
                $('#addselect1').append(label).append(select).append(br);
            } else if (document.getElementById(""radio3"").checked) {
                document.getElementById(""loadDiv3"").innerHTML = '<div class=""row""><div class=""col col-md-4""><div class=""row"" style=""padding:10px; ""><div class=""col col-md-8"" id=""addselect2""></div><div class=""col col-md-2""></div></div></div></div><div class=""row"" style=""padding:0px;"" id=""loadDrop3""></div>';
                i = 0;
                var select = $('<select class=""form-control"">').prop('id', 'companies_3').prop('name', 'companies_3');

                comp.forEach(function (item, index) {
                    //alert(index + "" "" + item[""acompanyName""]);
                    select.append($('<option></option>').attr('value', item[");
            WriteLiteral(@"""aCompanyId""]).text(item[""acompanyName""]));
                });

                var label = $(""<label>"").prop('for', 'companies').text(""受け入れ先企業: "");

                var br = $(""<br>"");
                $('#addselect2').append(label).append(select).append(br);
            }




        });

        //alert(""companies =""+JSON.stringify(companies));



    }

    $(document).ready(function () {

        $(""#radio1"").click(function () {

            $(""#radio2"").prop('checked', false);
            $(""#radio3"").prop('checked', false);

            $(""#loadDiv1:hidden"").show('slow');
            document.getElementById(""loadDiv2"").style.display = 'none';
            document.getElementById(""loadDiv3"").style.display = 'none';

        });
        $(""#radio2"").click(function () {
            $(""#radio1"").prop('checked', false);
            $(""#radio3"").prop('checked', false);

            $(""#loadDiv2:hidden"").show('slow');
            document.getElementById(""loadDiv1"").style.di");
            WriteLiteral(@"splay = 'none';
            document.getElementById(""loadDiv3"").style.display = 'none';

        });
        $(""#radio3"").click(function () {
            $(""#radio1"").prop('checked', false);
            $(""#radio2"").prop('checked', false);

            $(""#loadDiv3:hidden"").show('slow');
            document.getElementById(""loadDiv1"").style.display = 'none';
            document.getElementById(""loadDiv2"").style.display = 'none';
        });




    });



     function goHome() {
            window.location.href = ""/Home"";
    }


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
        public global::Microsoft.AspNetCore.Mvc.Rendering.IHtmlHelper<dynamic> Html { get; private set; }
    }
}
#pragma warning restore 1591
