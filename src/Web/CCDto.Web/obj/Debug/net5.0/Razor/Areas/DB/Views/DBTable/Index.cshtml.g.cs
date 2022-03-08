#pragma checksum "E:\王朋总\Demo\CCDto\src\Web\CCDto.Web\Areas\DB\Views\DBTable\Index.cshtml" "{ff1816ec-aa5e-4d10-87f7-6f4963833460}" "6c7aae70e3bf1a387e364991857d193b356c6c35"
// <auto-generated/>
#pragma warning disable 1591
[assembly: global::Microsoft.AspNetCore.Razor.Hosting.RazorCompiledItemAttribute(typeof(AspNetCore.Areas_DB_Views_DBTable_Index), @"mvc.1.0.view", @"/Areas/DB/Views/DBTable/Index.cshtml")]
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
    [global::Microsoft.AspNetCore.Razor.Hosting.RazorSourceChecksumAttribute(@"SHA1", @"6c7aae70e3bf1a387e364991857d193b356c6c35", @"/Areas/DB/Views/DBTable/Index.cshtml")]
    public class Areas_DB_Views_DBTable_Index : global::Microsoft.AspNetCore.Mvc.Razor.RazorPage<CCDto.application.Service.Crud.Dto.Response.PagedResultDto<CCDto.application.Service.DBTables.Dto.DBTableDto>>
    {
        #pragma warning disable 1998
        public async override global::System.Threading.Tasks.Task ExecuteAsync()
        {
#nullable restore
#line 2 "E:\王朋总\Demo\CCDto\src\Web\CCDto.Web\Areas\DB\Views\DBTable\Index.cshtml"
  
    ViewBag.Title = "数据库表";
    ViewBag.Small = "列表";

#line default
#line hidden
#nullable disable
            WriteLiteral(@"
<div class=""row"" id=""DBDBTableIndex"">
    <div class=""col-md-12"">
        <!-- BEGIN EXAMPLE TABLE PORTLET-->
        <div class=""portlet light bordered"">
            <div class=""portlet-title"">
                <div class=""caption font-dark"">
                    <i class=""icon-settings font-dark""></i>
                    <span class=""caption-subject bold uppercase"">Row Reordering</span>
                </div>
                <div class=""tools""> </div>
            </div>
            <div class=""portlet-body"">
                <div id=""sample_1_wrapper"" class=""dataTables_wrapper no-footer"">
                    <div class=""row"">
                        <div class=""col-md-12"">
                            <div class=""dt-buttons"">
                                <a class=""dt-button buttons-csv buttons-html5 btn purple btn-outline fancybox fancybox.iframe"" tabindex=""0"" aria-controls=""sample_1"" href=""/DB/DBTable/Edit/"">
                                    <span>新增</span>
                           ");
            WriteLiteral(@"     </a>
                            </div>
                        </div>
                    </div>
                    <div class=""row"">
                        <div class=""col-md-6 col-sm-12"">
                        </div>
                        <div class=""col-md-6 col-sm-12"">
                            <div id=""sample_1_filter"" class=""dataTables_filter"">
                                <!--
                                <label>
                                    EPC	:<input type=""search"" v-on:change=""changeitem()"" class=""form-control input-sm input-small input-inline"" placeholder="""" id=""EPC"" name=""EPC"" aria-controls=""sample_1"">
                                </label>
                                <label>
                                    TID	:<input type=""search"" v-on:change=""changeitem()"" class=""form-control input-sm input-small input-inline"" placeholder="""" id=""TID"" name=""TID"" aria-controls=""sample_1"">
                                </label>
                                ");
            WriteLiteral(@"<button type=""button"" v-on:click=""getDataRows()"" class=""dt-button buttons-csv buttons-html5 btn purple btn-outline"" tabindex=""0"" aria-controls=""sample_1"" >
                                    <span>查询</span>
                                </button>
                                -->
                            </div>
                        </div>
                    </div>
                    <div class=""table-scrollable"">
                        <table class=""table table-striped table-bordered table-hover dataTable no-footer"" id=""sample_1"" role=""grid"" aria-describedby=""sample_1_info"" style=""position: relative;"">
                            <thead>
                                <tr role=""row"">
                                    <th v-for=""item in headers"" :key=""item.SortId"" class=""sorting"" tabindex=""0"" aria-controls=""sample_1"" rowspan=""1"" colspan=""1"" style=""width: 246px;""> {{item.ShowName}} </th>
                                    <th aria-controls=""sample_1"" rowspan=""1"" colspan=""1"" style=""");
            WriteLiteral(@"width: 246px;"">操作</th>
                                </tr>
                            </thead>
                            <tbody>
                                <tr role=""row"" class=""odd"" v-for=""item in tabledata.Items"" :key=""item.Id"">
                                    <td v-for=""head in headers""> {{item[head.PropertyName]}} </td>
                                    <td>
                                        <a class=""fancybox fancybox.iframe""");
            BeginWriteAttribute("title", " title=\"", 3716, "\"", 3724, 0);
            EndWriteAttribute();
            WriteLiteral(@" :href=""'/DB/DBTable/Edit/'+item.Id"">
                                            修改
                                        </a>
                                        <a href=""javascript:;"" v-on:click=""remove(item.Id)"">删除</a>
                                    </td>
                                </tr>
                            </tbody>
                        </table>
                    </div>
                    <div class=""row"" v-html=""tabledata.PagedInput.PageTableFoot.Foot"">
                    </div>
                </div>
            </div>
        </div>
        <!-- END EXAMPLE TABLE PORTLET-->
    </div>
</div>

");
            DefineSection("scripts", async() => {
                WriteLiteral(@"
   <script type=""text/javascript"">
       var currentDBDBTableIndexVm = new Vue({
           el: '#DBDBTableIndex',
           data: {
               headers:[],
               tabledata: {
                   PagedInput: {
                       PageIndex: 1,
                       headers: [],
                       EPC: """",
                       TID: """",
                       PageTableFoot: {
                           Foot: """"
                       }
                   }
               }
           },
           mounted: function () {
               var that = this;

               that.getShowHeaders();
               that.getDataRows();

               $(""body"").on(""click"", ""div.paging_bootstrap_number ul.pagination li a"", function () {
                   that.tabledata.PagedInput.PageIndex = this.attributes.pageindex.value;
                   that.getDataRows();
               })
           },
           methods: {
               remove: function (id) {
               ");
                WriteLiteral(@"    var that = this;
                   $.ajax({
                       type: ""post"",
                       url: ""/DB/DBTable/Delete/""+id,
                       dataType: ""json"",
                       success: function (data) {
                           that.getDataRows();
                       }
                   })
               },
               getShowHeaders: function () {
                   var that = this;
                   $.ajax({
                       type: ""post"",
                       url: ""/DB/DBTable/GetShowHeaders"",
                       data: { IsCheckDisabled : true },
                       dataType: ""json"",
                       success: function (data) {
                           that.headers = data;
                       }
                   })
               },
               changeitem: function () {
                   this.tabledata.PagedInput.PageIndex = 1;
               },
               getDataRows: function () {
                   var that =");
                WriteLiteral(@" this;

                   //that.tabledata.PagedInput.EPC = $(""#EPC"").val();
                   //that.tabledata.PagedInput.TID = $(""#TID"").val();

                   $.ajax({
                       type: ""post"",
                       url: ""/DB/DBTable/GetDatas"",
                       data: that.tabledata.PagedInput ,
                       dataType: ""json"",
                       success: function (data) {
                           that.tabledata = data;
                       }
                   })
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
        public global::Microsoft.AspNetCore.Mvc.Rendering.IHtmlHelper<CCDto.application.Service.Crud.Dto.Response.PagedResultDto<CCDto.application.Service.DBTables.Dto.DBTableDto>> Html { get; private set; }
    }
}
#pragma warning restore 1591
