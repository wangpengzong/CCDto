#pragma checksum "E:\王朋总\Demo\CCDto\src\Web\CCDto.Web\Areas\DB\Views\DBConnection\Edit.cshtml" "{ff1816ec-aa5e-4d10-87f7-6f4963833460}" "1431ab485a2659d01144bcee1e2184373c9dc632"
// <auto-generated/>
#pragma warning disable 1591
[assembly: global::Microsoft.AspNetCore.Razor.Hosting.RazorCompiledItemAttribute(typeof(AspNetCore.Areas_DB_Views_DBConnection_Edit), @"mvc.1.0.view", @"/Areas/DB/Views/DBConnection/Edit.cshtml")]
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
    [global::Microsoft.AspNetCore.Razor.Hosting.RazorSourceChecksumAttribute(@"SHA1", @"1431ab485a2659d01144bcee1e2184373c9dc632", @"/Areas/DB/Views/DBConnection/Edit.cshtml")]
    public class Areas_DB_Views_DBConnection_Edit : global::Microsoft.AspNetCore.Mvc.Razor.RazorPage<int>
    {
        #pragma warning disable 1998
        public async override global::System.Threading.Tasks.Task ExecuteAsync()
        {
#nullable restore
#line 2 "E:\王朋总\Demo\CCDto\src\Web\CCDto.Web\Areas\DB\Views\DBConnection\Edit.cshtml"
  
    Layout = "~/Views/Shared/_Window.cshtml";

#line default
#line hidden
#nullable disable
            WriteLiteral(@"
<div class=""portlet light bordered"" id=""DBDBConnectionEdit"">
    <div class=""portlet-title"">
        <div class=""caption"">
            <i class=""icon-settings font-dark""></i>
            <span class=""caption-subject font-dark sbold uppercase"">Horizontal Form</span>
        </div>
        <div class=""actions"">
            <div class=""btn-group btn-group-devided"" data-toggle=""buttons"">
            </div>
        </div>
    </div>
    <div class=""portlet-body form"">
        <form class=""form-horizontal"" action=""/DB/DBConnection/EditForm"" method=""post"" role=""form"" id=""DBDBConnectionEditForm"">
            <div class=""form-body"">
                <div class=""row"">
                    <div class=""col-md-6 "" v-for=""item in headers"" :key=""item.SortId"" :class=""item.EditType"">
                        <div class=""form-group"">
                            <label class=""col-md-3 control-label"">{{item.ShowName}}</label>
                            <div class=""col-md-9"" v-if=""item.EditType=='hidden'"">
    ");
            WriteLiteral(@"                            <input type=""hidden"" :name=""item.PropertyName"" class=""form-control"" v-model=""data[item.PropertyName]"">
                            </div>
                            <div class=""col-md-9"" v-if=""item.EditType=='text'"">
                                <input type=""text"" :name=""item.PropertyName"" class=""form-control"" v-model=""data[item.PropertyName]"" :placeholder=""'请输入'+item.ShowName"">
                            </div>
                            <div class=""col-md-9"" v-if=""item.EditType=='select'"">
                                <select class=""form-control"" v-model=""data[item.PropertyName]"" :name=""item.PropertyName"">
                                    <option v-for=""op in item.Options"" :key=""op"" :value=""op.Item1"">{{op.Item2}}</option>
                                </select>
                            </div>
                        </div>
                    </div>
                </div>
            </div>
            <div class=""form-actions"">
                <di");
            WriteLiteral(@"v class=""row"">
                    <div class=""col-md-offset-3 col-md-9"">
                        <button type=""submit"" class=""btn green"">提交保存</button>
                        <button class=""btn default"" data-dismiss=""modal"" aria-hidden=""true"">取消</button>
                    </div>
                </div>
            </div>
        </form>
    </div>
</div>

");
            DefineSection("scripts", async() => {
                WriteLiteral(@"
    <script type=""text/javascript"">
       var userVm = new Vue({
           el: '#DBDBConnectionEdit',
           data: {
               headers: [],
               data: {}
           },
           mounted: function () {
               this.initPage();
               this.getShowHeaders();
               this.getData();
           },
           methods: {
               getShowHeaders: function () {
                   var that = this;
                   $.ajax({
                       type: ""GET"",
                       url: ""/DB/DBConnection/GetShowHeaders"",
                       data: { IsCheckEdit: true },
                       dataType: ""json"",
                       success: function (data) {
                           that.headers =  data == null ? [] : data;;
                       }
                   })
               },
               getData: function () {
                   var that = this;
                   $.ajax({
                       type: ""GET"",
         ");
                WriteLiteral("              url: \"/DB/DBConnection/getData/");
#nullable restore
#line 81 "E:\王朋总\Demo\CCDto\src\Web\CCDto.Web\Areas\DB\Views\DBConnection\Edit.cshtml"
                                                  Write(Model);

#line default
#line hidden
#nullable disable
                WriteLiteral(@""",
                       data: {},
                       dataType: ""json"",
                       success: function (data) {
                           that.data = data == null ? {} : data;
                       }
                   })
               },
               initPage:function(){
                   $(""#DBDBConnectionEditForm"").validate();
               
                   $(""#DBDBConnectionEditForm"").ajaxForm({
                       dataType: ""json"",
                       beforeSubmit: function () {
                           var isSuccess = $(""#DBDBConnectionEditForm"").validate().form(); // 返回是否验证成功
                           if (isSuccess) {
                               MyScript.blockUI();
                           } else {
                               $.unblockUI();
                               return false;
                           }
                       },
                       success: function (json) {
                           if (json.IsSuccess) {
 ");
                WriteLiteral(@"                              toastr.clear();
                               toastr[""success""](json.Message, ""系统提示"");
                               parent.$.fancybox.close();
                               parent.currentDBDBConnectionIndexVm.getDataRows();
                           } else {
                               toastr[""error""](json.Message, ""系统提示"");
                               $.unblockUI();
                           }
                       },
                       error: function (XmlHttpRequest, textStatus, errorThrown) {
                           alert(""提交出错！"", ""系统提示"");
                           $.unblockUI();
                           alert(""textStatus:"" + textStatus + "",errorThrown:"" + errorThrown);
                       }
                   });
               
               }
           }
       })
    </script>
");
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
        public global::Microsoft.AspNetCore.Mvc.Rendering.IHtmlHelper<int> Html { get; private set; }
    }
}
#pragma warning restore 1591
