#pragma checksum "D:\ProstyleTechnology\Project\GloableCommunication\Areas\Documents\Views\Document\AddorEditView.cshtml" "{ff1816ec-aa5e-4d10-87f7-6f4963833460}" "0e964b871cd80d0c4b38b0adbab42afe4bb7452d"
// <auto-generated/>
#pragma warning disable 1591
[assembly: global::Microsoft.AspNetCore.Razor.Hosting.RazorCompiledItemAttribute(typeof(AspNetCore.Areas_Documents_Views_Document_AddorEditView), @"mvc.1.0.view", @"/Areas/Documents/Views/Document/AddorEditView.cshtml")]
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
    [global::Microsoft.AspNetCore.Razor.Hosting.RazorSourceChecksumAttribute(@"SHA1", @"0e964b871cd80d0c4b38b0adbab42afe4bb7452d", @"/Areas/Documents/Views/Document/AddorEditView.cshtml")]
    public class Areas_Documents_Views_Document_AddorEditView : global::Microsoft.AspNetCore.Mvc.Razor.RazorPage<GloableCommunication.Areas.Documents.Models.ViewModels.DocumentViewModel>
    {
        #pragma warning disable 1998
        public async override global::System.Threading.Tasks.Task ExecuteAsync()
        {
            WriteLiteral("\r\n");
#nullable restore
#line 4 "D:\ProstyleTechnology\Project\GloableCommunication\Areas\Documents\Views\Document\AddorEditView.cshtml"
  
    ViewData["Title"] = "AddorEditView";

#line default
#line hidden
#nullable disable
            WriteLiteral("\r\n<div class=\"row\">\r\n    <div class=\"col-md-12\">\r\n        <form method=\"post\" action=\"/Documents/Document/SaveData\">\r\n            <input type=\"hidden\" name=\"DocumentId\" class=\"form-control\" id=\"DocumentId\"");
            BeginWriteAttribute("value", " value=\"", 371, "\"", 396, 1);
#nullable restore
#line 11 "D:\ProstyleTechnology\Project\GloableCommunication\Areas\Documents\Views\Document\AddorEditView.cshtml"
WriteAttributeValue("", 379, Model.DocumentId, 379, 17, false);

#line default
#line hidden
#nullable disable
            EndWriteAttribute();
            WriteLiteral(" />\r\n            <input type=\"hidden\" class=\"form-check-input\" name=\"DocumentIsDelete\" id=\"DocumentIsDelete\" value=\"false\" /> ");
            WriteLiteral("\r\n            <div asp-validation-summary=\"ModelOnly\" class=\"text-danger\"></div>\r\n");
#nullable restore
#line 14 "D:\ProstyleTechnology\Project\GloableCommunication\Areas\Documents\Views\Document\AddorEditView.cshtml"
             if (Model.Flag == 0)
            {

#line default
#line hidden
#nullable disable
            WriteLiteral("                <div class=\"form-group\">\r\n                    <label asp-for=\"DocumentTypeId\" class=\"control-label\">Type</label>\r\n                    <select class=\"form-control\" id=\"DocumentCategoryId\" name=\"DocumentCategoryId\">\r\n");
#nullable restore
#line 20 "D:\ProstyleTechnology\Project\GloableCommunication\Areas\Documents\Views\Document\AddorEditView.cshtml"
                         foreach (var type in Model.DocumentTypes)
                        {
                            if (type.DocumentTypeId == Model.DocumentTypeId)
                            {

#line default
#line hidden
#nullable disable
            WriteLiteral("                                <option selected");
            BeginWriteAttribute("value", " value=\"", 1278, "\"", 1306, 1);
#nullable restore
#line 24 "D:\ProstyleTechnology\Project\GloableCommunication\Areas\Documents\Views\Document\AddorEditView.cshtml"
WriteAttributeValue("", 1286, type.DocumentTypeId, 1286, 20, false);

#line default
#line hidden
#nullable disable
            EndWriteAttribute();
            WriteLiteral(">");
#nullable restore
#line 24 "D:\ProstyleTechnology\Project\GloableCommunication\Areas\Documents\Views\Document\AddorEditView.cshtml"
                                                                         Write(type.DocumentTypeName);

#line default
#line hidden
#nullable disable
            WriteLiteral("</option>\r\n");
#nullable restore
#line 25 "D:\ProstyleTechnology\Project\GloableCommunication\Areas\Documents\Views\Document\AddorEditView.cshtml"
                            }
                            else
                            {

#line default
#line hidden
#nullable disable
            WriteLiteral("                                <option");
            BeginWriteAttribute("value", " value=\"", 1476, "\"", 1504, 1);
#nullable restore
#line 28 "D:\ProstyleTechnology\Project\GloableCommunication\Areas\Documents\Views\Document\AddorEditView.cshtml"
WriteAttributeValue("", 1484, type.DocumentTypeId, 1484, 20, false);

#line default
#line hidden
#nullable disable
            EndWriteAttribute();
            WriteLiteral(">");
#nullable restore
#line 28 "D:\ProstyleTechnology\Project\GloableCommunication\Areas\Documents\Views\Document\AddorEditView.cshtml"
                                                                Write(type.DocumentTypeName);

#line default
#line hidden
#nullable disable
            WriteLiteral("</option>\r\n");
#nullable restore
#line 29 "D:\ProstyleTechnology\Project\GloableCommunication\Areas\Documents\Views\Document\AddorEditView.cshtml"
                            }
                        }

#line default
#line hidden
#nullable disable
            WriteLiteral("                    </select>\r\n                </div>\r\n");
#nullable restore
#line 33 "D:\ProstyleTechnology\Project\GloableCommunication\Areas\Documents\Views\Document\AddorEditView.cshtml"
            }
            else
            {

#line default
#line hidden
#nullable disable
            WriteLiteral("                <input type=\"hidden\" name=\"DocumentCategoryId\" class=\"form-control\" id=\"DocumentCategoryId\"");
            BeginWriteAttribute("value", " value=\"", 1807, "\"", 1826, 1);
#nullable restore
#line 36 "D:\ProstyleTechnology\Project\GloableCommunication\Areas\Documents\Views\Document\AddorEditView.cshtml"
WriteAttributeValue("", 1815, Model.Flag, 1815, 11, false);

#line default
#line hidden
#nullable disable
            EndWriteAttribute();
            WriteLiteral(" />\r\n");
#nullable restore
#line 37 "D:\ProstyleTechnology\Project\GloableCommunication\Areas\Documents\Views\Document\AddorEditView.cshtml"
            }

#line default
#line hidden
#nullable disable
            WriteLiteral(@"            <input type=""hidden"" name=""urlPath"" class=""form-control"" id=""urlPath"" value=""/Documents/Document/SaveData"" />
            <div class=""form-group"">
                <label asp-for=""DocumentName"" class=""control-label"">Name</label>
                <input placeholder=""Name"" name=""DocumentName"" class=""form-control"" id=""DocumentName"" maxlength=""100""");
            BeginWriteAttribute("value", " value=\"", 2206, "\"", 2233, 1);
#nullable restore
#line 41 "D:\ProstyleTechnology\Project\GloableCommunication\Areas\Documents\Views\Document\AddorEditView.cshtml"
WriteAttributeValue("", 2214, Model.DocumentName, 2214, 19, false);

#line default
#line hidden
#nullable disable
            EndWriteAttribute();
            WriteLiteral(@" />
                <span asp-validation-for=""DocumentName"" class=""text-danger""></span>
            </div>
            <div class=""form-group"">
                <label asp-for=""DocumentDescription"" class=""control-label"">Description</label>
                <textarea placeholder=""Description"" name=""DocumentDescription"" class=""form-control"" id=""DocumentDescription"" maxlength=""250"">");
#nullable restore
#line 46 "D:\ProstyleTechnology\Project\GloableCommunication\Areas\Documents\Views\Document\AddorEditView.cshtml"
                                                                                                                                        Write(Model.DocumentDescription);

#line default
#line hidden
#nullable disable
            WriteLiteral(@"</textarea>
                <span asp-validation-for=""DocumentDescription"" class=""text-danger""></span>
            </div>
            <div class=""form-group"">
                <label asp-for=""DocumentFilePath"" class=""control-label""></label>
                <input type=""file"" name=""UploadedFile"" class=""form-control"" id=""UploadedFile"" maxlength=""100""");
            BeginWriteAttribute("value", " value=\"", 2999, "\"", 3030, 1);
#nullable restore
#line 51 "D:\ProstyleTechnology\Project\GloableCommunication\Areas\Documents\Views\Document\AddorEditView.cshtml"
WriteAttributeValue("", 3007, Model.DocumentFilePath, 3007, 23, false);

#line default
#line hidden
#nullable disable
            EndWriteAttribute();
            WriteLiteral(" />\r\n                <span asp-validation-for=\"DocumentFilePath\" class=\"text-danger\"></span>\r\n            </div>\r\n        </form>\r\n    </div>\r\n</div>\r\n\r\n<div class=\"progress-bar\"></div>\r\n\r\n");
            DefineSection("Scripts", async() => {
                WriteLiteral("\r\n");
#nullable restore
#line 61 "D:\ProstyleTechnology\Project\GloableCommunication\Areas\Documents\Views\Document\AddorEditView.cshtml"
      await Html.RenderPartialAsync("_ValidationScriptsPartial");

#line default
#line hidden
#nullable disable
            }
            );
            WriteLiteral(@"

<script>
    //File uploading Script

    function uploadingZipFile() {
        //alert(""urlPath = "" + $(""#urlPath"").val());
        // Get document
        var files = $(""#UploadedFile"").get(0).files;
        // Create an FormData object
        let data = new FormData();
        //add ID if it is needed
        data.append(""DocumentId"", $(""#DocumentId"").val());
        data.append(""DocumentTypeId"", $(""#DocumentCategoryId"").val());
        if (!IsFilled(""DocumentName"", ""Document Name"", ""Please fill the document name"")) {
            return;
        }
        data.append(""DocumentName"", $(""#DocumentName"").val());
        data.append(""DocumentDescription"", $(""#DocumentDescription"").val());
        data.append(""DocumentIsDelete"", $(""#DocumentIsDelete"").val());
        data.append(""InstituteId"", $(""#InstituteId"").val());

        if (files.length > 0) {
            data.append(""UploadedDoc"", files[0]);
        }
        else {

            if ($(""#DocumentId"").val() == 0) {
        ");
            WriteLiteral(@"        if (!IsFilled(""UploadedDoc"", ""Upload File"", ""Please Choose a file to upload"")) {
                    return;
                }
            }

        }

        data.append(""name"", ""name"");

        $.ajax({
            type: ""POST"",
            enctype: 'multipart/form-data',
            url: $(""#urlPath"").val(),
            data: data,
            processData: false,
            contentType: false,
            cache: false,
            timeout: 600000,
            xhr: function () {
                var xhr = new window.XMLHttpRequest();
                xhr.upload.addEventListener(""progress"", function (evt) {
                    if (evt.lengthComputable) {
                        var progress = Math.round((evt.loaded / evt.total) * 100);
                        $("".progress-bar"").css(""width"", progress + ""%"").attr(""aria-valuenow"", progress);
                        $("".progress-bar"").html(progress + ""%"");
                    }
                }, false);
                retur");
            WriteLiteral(@"n xhr;
            },
            success: function (data) {

                alert(""uploading done"");
                $('#AddOrEditDocument').modal('hide');
                location.reload();

            },
            error: function (e) {
                alert(""File uploading done!"");
                $('#AddOrEditDocument').modal('hide');
                location.reload();

            }
        });
    }
</script>

<script>
    $(""input"").on(""keyup"", function () {
        var maxLength = $(this).attr(""maxlength"");
        if (maxLength == $(this).val().length) {
            alert(""Characters length exceeds the Limit, please input less than "" + maxLength + "" characters"");
        }
    })

    $(""textarea"").on(""keyup"", function () {
        var maxLength = $(this).attr(""maxlength"");
        if (maxLength == $(this).val().length) {
            alert(""Characters length exceeds the Limit, please input less than "" + maxLength + "" characters"");
        }
    })
</script>
<scri");
            WriteLiteral(@"pt>
    var uploadField = document.getElementById(""UploadedFile"");

    uploadField.onchange = function () {
        if (this.files[0].size > 10485760) {
            alert(""File is too big! The size should be less than 10MB."");
            this.value = """";
        };
    };
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
        public global::Microsoft.AspNetCore.Mvc.Rendering.IHtmlHelper<GloableCommunication.Areas.Documents.Models.ViewModels.DocumentViewModel> Html { get; private set; }
    }
}
#pragma warning restore 1591
