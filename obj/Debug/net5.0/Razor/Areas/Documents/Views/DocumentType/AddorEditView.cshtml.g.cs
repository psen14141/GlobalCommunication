#pragma checksum "D:\ProstyleTechnology\Project\GloableCommunication\Areas\Documents\Views\DocumentType\AddorEditView.cshtml" "{ff1816ec-aa5e-4d10-87f7-6f4963833460}" "aa534ebe502ab5d78063851dc2f8ee2239840961"
// <auto-generated/>
#pragma warning disable 1591
[assembly: global::Microsoft.AspNetCore.Razor.Hosting.RazorCompiledItemAttribute(typeof(AspNetCore.Areas_Documents_Views_DocumentType_AddorEditView), @"mvc.1.0.view", @"/Areas/Documents/Views/DocumentType/AddorEditView.cshtml")]
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
    [global::Microsoft.AspNetCore.Razor.Hosting.RazorSourceChecksumAttribute(@"SHA1", @"aa534ebe502ab5d78063851dc2f8ee2239840961", @"/Areas/Documents/Views/DocumentType/AddorEditView.cshtml")]
    public class Areas_Documents_Views_DocumentType_AddorEditView : global::Microsoft.AspNetCore.Mvc.Razor.RazorPage<GloableCommunication.DbModels.DocumentType>
    {
        #pragma warning disable 1998
        public async override global::System.Threading.Tasks.Task ExecuteAsync()
        {
            WriteLiteral("\r\n");
#nullable restore
#line 3 "D:\ProstyleTechnology\Project\GloableCommunication\Areas\Documents\Views\DocumentType\AddorEditView.cshtml"
  
    ViewData["Title"] = "AddorEditView";
    //Layout = "~/Views/Shared/_Layout.cshtml";

#line default
#line hidden
#nullable disable
            WriteLiteral("\r\n<div class=\"row\">\r\n    <div class=\"col-md-12\">\r\n        <form method=\"post\" action=\"/Documents/DocumentType/SaveData\">\r\n            <input type=\"hidden\" name=\"DocumentTypeId\" class=\"form-control\" id=\"DocumentTypeId\"");
            BeginWriteAttribute("value", " value=\"", 368, "\"", 397, 1);
#nullable restore
#line 11 "D:\ProstyleTechnology\Project\GloableCommunication\Areas\Documents\Views\DocumentType\AddorEditView.cshtml"
WriteAttributeValue("", 376, Model.DocumentTypeId, 376, 21, false);

#line default
#line hidden
#nullable disable
            EndWriteAttribute();
            WriteLiteral(" />\r\n            <input type=\"hidden\" class=\"form-check-input\" name=\"DocumentTypeIsDelete\" id=\"DocumentTypeIsDelete\" value=\"false\" /> ");
            WriteLiteral(@"
            <div asp-validation-summary=""ModelOnly"" class=""text-danger""></div>
            <div class=""form-group"">
                <label asp-for=""DocumentTypeName"" class=""control-label"">Name</label>
                <input placeholder=""Name"" name=""DocumentTypeName"" class=""form-control"" id=""DocumentTypeName"" maxlength=""100""");
            BeginWriteAttribute("value", " value=\"", 923, "\"", 954, 1);
#nullable restore
#line 16 "D:\ProstyleTechnology\Project\GloableCommunication\Areas\Documents\Views\DocumentType\AddorEditView.cshtml"
WriteAttributeValue("", 931, Model.DocumentTypeName, 931, 23, false);

#line default
#line hidden
#nullable disable
            EndWriteAttribute();
            WriteLiteral(" />\r\n                <span asp-validation-for=\"DocumentTypeName\" class=\"text-danger\"></span>\r\n            </div>\r\n");
            WriteLiteral(@"            <div class=""form-group"">
                <label asp-for=""DocumentTypeDescription"" class=""control-label"">Description</label>
                <textarea placeholder=""Description"" name=""DocumentTypeDescription"" class=""form-control"" id=""DocumentTypeDescription"" maxlength=""250"">");
#nullable restore
#line 26 "D:\ProstyleTechnology\Project\GloableCommunication\Areas\Documents\Views\DocumentType\AddorEditView.cshtml"
                                                                                                                                                Write(Model.DocumentTypeDescription);

#line default
#line hidden
#nullable disable
            WriteLiteral("</textarea>\r\n                <span asp-validation-for=\"DocumentTypeDescription\" class=\"text-danger\"></span>\r\n            </div>\r\n        </form>\r\n    </div>\r\n</div>\r\n\r\n\r\n");
            DefineSection("Scripts", async() => {
                WriteLiteral("\r\n");
#nullable restore
#line 35 "D:\ProstyleTechnology\Project\GloableCommunication\Areas\Documents\Views\DocumentType\AddorEditView.cshtml"
      await Html.RenderPartialAsync("_ValidationScriptsPartial");

#line default
#line hidden
#nullable disable
            }
            );
            WriteLiteral(@"
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
        public global::Microsoft.AspNetCore.Mvc.Rendering.IHtmlHelper<GloableCommunication.DbModels.DocumentType> Html { get; private set; }
    }
}
#pragma warning restore 1591
