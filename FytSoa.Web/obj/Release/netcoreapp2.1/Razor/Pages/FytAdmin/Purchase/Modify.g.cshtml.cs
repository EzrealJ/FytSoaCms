#pragma checksum "D:\2018Project\ERP项目\SoaProJect\FytSoa.Web\Pages\FytAdmin\Purchase\Modify.cshtml" "{ff1816ec-aa5e-4d10-87f7-6f4963833460}" "93d248b3980629c6f6bb651d32aa6a1a8d9f1e5c"
// <auto-generated/>
#pragma warning disable 1591
[assembly: global::Microsoft.AspNetCore.Razor.Hosting.RazorCompiledItemAttribute(typeof(FytSoa.Web.Pages.FytAdmin.Purchase.Pages_FytAdmin_Purchase_Modify), @"mvc.1.0.razor-page", @"/Pages/FytAdmin/Purchase/Modify.cshtml")]
[assembly:global::Microsoft.AspNetCore.Mvc.RazorPages.Infrastructure.RazorPageAttribute(@"/Pages/FytAdmin/Purchase/Modify.cshtml", typeof(FytSoa.Web.Pages.FytAdmin.Purchase.Pages_FytAdmin_Purchase_Modify), null)]
namespace FytSoa.Web.Pages.FytAdmin.Purchase
{
    #line hidden
    using System;
    using System.Collections.Generic;
    using System.Linq;
    using System.Threading.Tasks;
    using Microsoft.AspNetCore.Mvc;
    using Microsoft.AspNetCore.Mvc.Rendering;
    using Microsoft.AspNetCore.Mvc.ViewFeatures;
#line 1 "D:\2018Project\ERP项目\SoaProJect\FytSoa.Web\Pages\_ViewImports.cshtml"
using FytSoa.Web;

#line default
#line hidden
    [global::Microsoft.AspNetCore.Razor.Hosting.RazorSourceChecksumAttribute(@"SHA1", @"93d248b3980629c6f6bb651d32aa6a1a8d9f1e5c", @"/Pages/FytAdmin/Purchase/Modify.cshtml")]
    [global::Microsoft.AspNetCore.Razor.Hosting.RazorSourceChecksumAttribute(@"SHA1", @"21c44af9864cf57cf01e8fd1fe389a8e352e148c", @"/Pages/_ViewImports.cshtml")]
    public class Pages_FytAdmin_Purchase_Modify : global::Microsoft.AspNetCore.Mvc.RazorPages.Page
    {
        private static readonly global::Microsoft.AspNetCore.Razor.TagHelpers.TagHelperAttribute __tagHelperAttribute_0 = new global::Microsoft.AspNetCore.Razor.TagHelpers.TagHelperAttribute("value", "", global::Microsoft.AspNetCore.Razor.TagHelpers.HtmlAttributeValueStyle.DoubleQuotes);
        private static readonly global::Microsoft.AspNetCore.Razor.TagHelpers.TagHelperAttribute __tagHelperAttribute_1 = new global::Microsoft.AspNetCore.Razor.TagHelpers.TagHelperAttribute(":value", new global::Microsoft.AspNetCore.Html.HtmlString("it.guid"), global::Microsoft.AspNetCore.Razor.TagHelpers.HtmlAttributeValueStyle.DoubleQuotes);
        private static readonly global::Microsoft.AspNetCore.Razor.TagHelpers.TagHelperAttribute __tagHelperAttribute_2 = new global::Microsoft.AspNetCore.Razor.TagHelpers.TagHelperAttribute("v-for", new global::Microsoft.AspNetCore.Html.HtmlString("it in supplier"), global::Microsoft.AspNetCore.Razor.TagHelpers.HtmlAttributeValueStyle.DoubleQuotes);
        private static readonly global::Microsoft.AspNetCore.Razor.TagHelpers.TagHelperAttribute __tagHelperAttribute_3 = new global::Microsoft.AspNetCore.Razor.TagHelpers.TagHelperAttribute("value", "0", global::Microsoft.AspNetCore.Razor.TagHelpers.HtmlAttributeValueStyle.DoubleQuotes);
        private static readonly global::Microsoft.AspNetCore.Razor.TagHelpers.TagHelperAttribute __tagHelperAttribute_4 = new global::Microsoft.AspNetCore.Razor.TagHelpers.TagHelperAttribute("class", new global::Microsoft.AspNetCore.Html.HtmlString("layui-form form-cus"), global::Microsoft.AspNetCore.Razor.TagHelpers.HtmlAttributeValueStyle.DoubleQuotes);
        private static readonly global::Microsoft.AspNetCore.Razor.TagHelpers.TagHelperAttribute __tagHelperAttribute_5 = new global::Microsoft.AspNetCore.Razor.TagHelpers.TagHelperAttribute("action", new global::Microsoft.AspNetCore.Html.HtmlString(""), global::Microsoft.AspNetCore.Razor.TagHelpers.HtmlAttributeValueStyle.DoubleQuotes);
        private static readonly global::Microsoft.AspNetCore.Razor.TagHelpers.TagHelperAttribute __tagHelperAttribute_6 = new global::Microsoft.AspNetCore.Razor.TagHelpers.TagHelperAttribute("id", new global::Microsoft.AspNetCore.Html.HtmlString("app"), global::Microsoft.AspNetCore.Razor.TagHelpers.HtmlAttributeValueStyle.DoubleQuotes);
        private static readonly global::Microsoft.AspNetCore.Razor.TagHelpers.TagHelperAttribute __tagHelperAttribute_7 = new global::Microsoft.AspNetCore.Razor.TagHelpers.TagHelperAttribute("rel", new global::Microsoft.AspNetCore.Html.HtmlString("stylesheet"), global::Microsoft.AspNetCore.Razor.TagHelpers.HtmlAttributeValueStyle.DoubleQuotes);
        private static readonly global::Microsoft.AspNetCore.Razor.TagHelpers.TagHelperAttribute __tagHelperAttribute_8 = new global::Microsoft.AspNetCore.Razor.TagHelpers.TagHelperAttribute("href", new global::Microsoft.AspNetCore.Html.HtmlString("~/themes/css/city-picker.css"), global::Microsoft.AspNetCore.Razor.TagHelpers.HtmlAttributeValueStyle.DoubleQuotes);
        private static readonly global::Microsoft.AspNetCore.Razor.TagHelpers.TagHelperAttribute __tagHelperAttribute_9 = new global::Microsoft.AspNetCore.Razor.TagHelpers.TagHelperAttribute("type", new global::Microsoft.AspNetCore.Html.HtmlString("text/css"), global::Microsoft.AspNetCore.Razor.TagHelpers.HtmlAttributeValueStyle.DoubleQuotes);
        #line hidden
        #pragma warning disable 0169
        private string __tagHelperStringValueBuffer;
        #pragma warning restore 0169
        private global::Microsoft.AspNetCore.Razor.Runtime.TagHelpers.TagHelperExecutionContext __tagHelperExecutionContext;
        private global::Microsoft.AspNetCore.Razor.Runtime.TagHelpers.TagHelperRunner __tagHelperRunner = new global::Microsoft.AspNetCore.Razor.Runtime.TagHelpers.TagHelperRunner();
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
        private global::Microsoft.AspNetCore.Mvc.TagHelpers.FormTagHelper __Microsoft_AspNetCore_Mvc_TagHelpers_FormTagHelper;
        private global::Microsoft.AspNetCore.Mvc.TagHelpers.RenderAtEndOfFormTagHelper __Microsoft_AspNetCore_Mvc_TagHelpers_RenderAtEndOfFormTagHelper;
        private global::Microsoft.AspNetCore.Mvc.TagHelpers.OptionTagHelper __Microsoft_AspNetCore_Mvc_TagHelpers_OptionTagHelper;
        private global::Microsoft.AspNetCore.Mvc.Razor.TagHelpers.UrlResolutionTagHelper __Microsoft_AspNetCore_Mvc_Razor_TagHelpers_UrlResolutionTagHelper;
        #pragma warning disable 1998
        public async override global::System.Threading.Tasks.Task ExecuteAsync()
        {
#line 3 "D:\2018Project\ERP项目\SoaProJect\FytSoa.Web\Pages\FytAdmin\Purchase\Modify.cshtml"
  
    ViewData["Title"] = "采购单管理";
    Layout = "~/Pages/FytAdmin/_Layout.cshtml";

#line default
#line hidden
            BeginContext(152, 1190, true);
            WriteLiteral(@"<style>
    .fyt-select .layui-form-select dl dd:last-child {
        text-align: center;
        color: #0094ff;
    }
    .list-wall {padding:0px 0px 10px 110px;  }
    .fyt-table thead th{ padding: 5px 0; border-top: none; border-left: none;border-width: 1px; border-style: solid;border-color: #e6e6e6;}
    .fyt-table thead th span{display:inline-block;height: 28px;line-height: 28px; padding: 0 15px; position: relative;font-weight:normal;}
    .fyt-table td{padding:0px;}
    .fyt-table td .layui-input{border-color:#ffffff;}
    .fyt-table td:last-child{text-align:center;}
    .fyt-table td:last-child i,.addAttr i{font-size:24px; cursor:pointer; }
    .addAttr i{vertical-align:middle; position:relative; top:-2px; margin-right:5px; color:#666;}
    .fyt-table .layui-form-select{display:none;}
    .fyt-table select{display:block; border:1px solid #e6e6e6; width:100%; border-radius:4px; height:38px; line-height:38px; padding:0 5px;
                      border:1px solid #fff;
    }
    .fyt-tab");
            WriteLiteral("le select:focus, .fyt-table select:active{border:1px solid #0094ff;}\r\n    .fyt-table samp{color:#ff0000;}\r\n    .addAttr {\r\n        cursor: pointer;\r\n    }\r\n</style>\r\n");
            EndContext();
            BeginContext(1342, 6576, false);
            __tagHelperExecutionContext = __tagHelperScopeManager.Begin("form", global::Microsoft.AspNetCore.Razor.TagHelpers.TagMode.StartTagAndEndTag, "ae8e7f4fbbae48998a56739ca85a1677", async() => {
                BeginContext(1395, 190, true);
                WriteLiteral("\r\n    <div class=\"layui-form-item\">\r\n        <label class=\"layui-form-label\">采购日期</label>\r\n        <div class=\"layui-input-block\">\r\n            <input type=\"text\" id=\"AddDate\" name=\"AddDate\"");
                EndContext();
                BeginWriteAttribute("value", " value=\"", 1585, "\"", 1644, 1);
#line 34 "D:\2018Project\ERP项目\SoaProJect\FytSoa.Web\Pages\FytAdmin\Purchase\Modify.cshtml"
WriteAttributeValue("", 1593, Model.Purchase.AddDate.ToString().Replace("/","-"), 1593, 51, false);

#line default
#line hidden
                EndWriteAttribute();
                BeginContext(1645, 460, true);
                WriteLiteral(@" lay-verify=""title"" autocomplete=""off"" placeholder="""" class=""layui-input"">
        </div>
    </div>
    <div class=""layui-form-item"">
        <div class=""layui-inline"">
            <label class=""layui-form-label"">供应商</label>
            <div class=""layui-input-inline fyt-select"">
                <select id=""Supplier"" name=""SupplierGuid"" v-model=""couponSelected"" lay-filter=""selSupplier"" lay-verify=""required"" lay-verType=""tips"">
                    ");
                EndContext();
                BeginContext(2105, 38, false);
                __tagHelperExecutionContext = __tagHelperScopeManager.Begin("option", global::Microsoft.AspNetCore.Razor.TagHelpers.TagMode.StartTagAndEndTag, "d15ebaf5f2ca461dbe1f37b16099b185", async() => {
                    BeginContext(2122, 12, true);
                    WriteLiteral("--可根据关键字搜索--");
                    EndContext();
                }
                );
                __Microsoft_AspNetCore_Mvc_TagHelpers_OptionTagHelper = CreateTagHelper<global::Microsoft.AspNetCore.Mvc.TagHelpers.OptionTagHelper>();
                __tagHelperExecutionContext.Add(__Microsoft_AspNetCore_Mvc_TagHelpers_OptionTagHelper);
                __Microsoft_AspNetCore_Mvc_TagHelpers_OptionTagHelper.Value = (string)__tagHelperAttribute_0.Value;
                __tagHelperExecutionContext.AddTagHelperAttribute(__tagHelperAttribute_0);
                await __tagHelperRunner.RunAsync(__tagHelperExecutionContext);
                if (!__tagHelperExecutionContext.Output.IsContentModified)
                {
                    await __tagHelperExecutionContext.SetOutputContentAsync();
                }
                Write(__tagHelperExecutionContext.Output);
                __tagHelperExecutionContext = __tagHelperScopeManager.End();
                EndContext();
                BeginContext(2143, 22, true);
                WriteLiteral("\r\n                    ");
                EndContext();
                BeginContext(2165, 68, false);
                __tagHelperExecutionContext = __tagHelperScopeManager.Begin("option", global::Microsoft.AspNetCore.Razor.TagHelpers.TagMode.StartTagAndEndTag, "bbadca8d5d6a425ea8ab546823610440", async() => {
                    BeginContext(2213, 11, true);
                    WriteLiteral("{{it.name}}");
                    EndContext();
                }
                );
                __Microsoft_AspNetCore_Mvc_TagHelpers_OptionTagHelper = CreateTagHelper<global::Microsoft.AspNetCore.Mvc.TagHelpers.OptionTagHelper>();
                __tagHelperExecutionContext.Add(__Microsoft_AspNetCore_Mvc_TagHelpers_OptionTagHelper);
                __tagHelperExecutionContext.AddHtmlAttribute(__tagHelperAttribute_1);
                __tagHelperExecutionContext.AddHtmlAttribute(__tagHelperAttribute_2);
                await __tagHelperRunner.RunAsync(__tagHelperExecutionContext);
                if (!__tagHelperExecutionContext.Output.IsContentModified)
                {
                    await __tagHelperExecutionContext.SetOutputContentAsync();
                }
                Write(__tagHelperExecutionContext.Output);
                __tagHelperExecutionContext = __tagHelperScopeManager.End();
                EndContext();
                BeginContext(2233, 22, true);
                WriteLiteral("\r\n                    ");
                EndContext();
                BeginContext(2255, 32, false);
                __tagHelperExecutionContext = __tagHelperScopeManager.Begin("option", global::Microsoft.AspNetCore.Razor.TagHelpers.TagMode.StartTagAndEndTag, "df98d9a8aa304bcf9cc371e23b1743f4", async() => {
                    BeginContext(2273, 5, true);
                    WriteLiteral("新建供应商");
                    EndContext();
                }
                );
                __Microsoft_AspNetCore_Mvc_TagHelpers_OptionTagHelper = CreateTagHelper<global::Microsoft.AspNetCore.Mvc.TagHelpers.OptionTagHelper>();
                __tagHelperExecutionContext.Add(__Microsoft_AspNetCore_Mvc_TagHelpers_OptionTagHelper);
                __Microsoft_AspNetCore_Mvc_TagHelpers_OptionTagHelper.Value = (string)__tagHelperAttribute_3.Value;
                __tagHelperExecutionContext.AddTagHelperAttribute(__tagHelperAttribute_3);
                await __tagHelperRunner.RunAsync(__tagHelperExecutionContext);
                if (!__tagHelperExecutionContext.Output.IsContentModified)
                {
                    await __tagHelperExecutionContext.SetOutputContentAsync();
                }
                Write(__tagHelperExecutionContext.Output);
                __tagHelperExecutionContext = __tagHelperScopeManager.End();
                EndContext();
                BeginContext(2287, 268, true);
                WriteLiteral(@"
                </select>
            </div>
        </div>
        <div class=""layui-inline"">
            <label class=""layui-form-label"">联系人</label>
            <div class=""layui-input-inline"">
                <input type=""text"" id=""Contacts"" name=""Contacts""");
                EndContext();
                BeginWriteAttribute("value", " value=\"", 2555, "\"", 2587, 1);
#line 51 "D:\2018Project\ERP项目\SoaProJect\FytSoa.Web\Pages\FytAdmin\Purchase\Modify.cshtml"
WriteAttributeValue("", 2563, Model.Purchase.Contacts, 2563, 24, false);

#line default
#line hidden
                EndWriteAttribute();
                BeginContext(2588, 334, true);
                WriteLiteral(@" maxlength=""20"" lay-verify=""required"" lay-verType=""tips"" autocomplete=""off"" class=""layui-input"">
            </div>
        </div>
        <div class=""layui-inline"">
            <label class=""layui-form-label"">联系电话</label>
            <div class=""layui-input-inline"">
                <input type=""text"" id=""Mobile"" name=""Mobile""");
                EndContext();
                BeginWriteAttribute("value", " value=\"", 2922, "\"", 2952, 1);
#line 57 "D:\2018Project\ERP项目\SoaProJect\FytSoa.Web\Pages\FytAdmin\Purchase\Modify.cshtml"
WriteAttributeValue("", 2930, Model.Purchase.Mobile, 2930, 22, false);

#line default
#line hidden
                EndWriteAttribute();
                BeginContext(2953, 400, true);
                WriteLiteral(@" maxlength=""20"" lay-verify=""required"" lay-verType=""tips"" autocomplete=""off"" class=""layui-input"">
            </div>
        </div>
    </div>
    <div class=""layui-form-item"">
        <div class=""layui-inline"">
            <label class=""layui-form-label"">交付地址</label>
            <div class=""layui-input-inline"">
                <input type=""text"" name=""DeliverCity"" data-toggle=""city-picker""");
                EndContext();
                BeginWriteAttribute("value", " value=\"", 3353, "\"", 3388, 1);
#line 65 "D:\2018Project\ERP项目\SoaProJect\FytSoa.Web\Pages\FytAdmin\Purchase\Modify.cshtml"
WriteAttributeValue("", 3361, Model.Purchase.DeliverCity, 3361, 27, false);

#line default
#line hidden
                EndWriteAttribute();
                BeginContext(3389, 306, true);
                WriteLiteral(@" autocomplete=""off"" class=""layui-input city-picker-input"">
            </div>
        </div>
        <div class=""layui-inline"">
            <label class=""layui-form-label"">交付时间</label>
            <div class=""layui-input-inline"">
                <input type=""text"" id=""DeliverDate"" name=""DeliverDate""");
                EndContext();
                BeginWriteAttribute("value", " value=\"", 3695, "\"", 3758, 1);
#line 71 "D:\2018Project\ERP项目\SoaProJect\FytSoa.Web\Pages\FytAdmin\Purchase\Modify.cshtml"
WriteAttributeValue("", 3703, Model.Purchase.DeliverDate.ToString().Replace("/","-"), 3703, 55, false);

#line default
#line hidden
                EndWriteAttribute();
                BeginContext(3759, 1288, true);
                WriteLiteral(@" autocomplete=""off"" class=""layui-input"">
            </div>
        </div>
    </div>
    <div class=""list-wall"">
        <table class=""layui-table fyt-table"">
            <thead>
                <tr>
                    <th width=""60""><span>序号</span></th>
                    <th><span><samp>*</samp>物品编号</span></th>
                    <th><span><samp>*</samp>名称</span></th>
                    <th><span>规格型号</span></th>
                    <th width=""100""><span><samp>*</samp>单位</span></th>
                    <th width=""100""><span><samp>*</samp>采购数量</span></th>
                    <th width=""80""><span><samp>*</samp>单价</span></th>
                    <th><span>备注</span></th>
                    <th width=""60""><span>操作</span></th>
                </tr>
            </thead>
            <tbody>
                <tr v-for=""it,index in tabList"">
                    <td align=""center"">{{index+1}}</td>
                    <td><input type=""text"" v-model=""it.Number"" class=""layui-input"" /></td>
   ");
                WriteLiteral(@"                 <td><input type=""text"" v-model=""it.Name"" class=""layui-input"" /></td>
                    <td><input type=""text"" v-model=""it.Specification"" class=""layui-input"" /></td>
                    <td>
                        <select v-model=""it.Unit"">
");
                EndContext();
#line 98 "D:\2018Project\ERP项目\SoaProJect\FytSoa.Web\Pages\FytAdmin\Purchase\Modify.cshtml"
                              
                                foreach (var item in Model.codeList)
                                {

#line default
#line hidden
                BeginContext(5184, 36, true);
                WriteLiteral("                                    ");
                EndContext();
                BeginContext(5220, 46, false);
                __tagHelperExecutionContext = __tagHelperScopeManager.Begin("option", global::Microsoft.AspNetCore.Razor.TagHelpers.TagMode.StartTagAndEndTag, "870d4a8921484ba8bd9c9c789f44194c", async() => {
                    BeginContext(5248, 9, false);
#line 101 "D:\2018Project\ERP项目\SoaProJect\FytSoa.Web\Pages\FytAdmin\Purchase\Modify.cshtml"
                                                          Write(item.Name);

#line default
#line hidden
                    EndContext();
                }
                );
                __Microsoft_AspNetCore_Mvc_TagHelpers_OptionTagHelper = CreateTagHelper<global::Microsoft.AspNetCore.Mvc.TagHelpers.OptionTagHelper>();
                __tagHelperExecutionContext.Add(__Microsoft_AspNetCore_Mvc_TagHelpers_OptionTagHelper);
                BeginWriteTagHelperAttribute();
#line 101 "D:\2018Project\ERP项目\SoaProJect\FytSoa.Web\Pages\FytAdmin\Purchase\Modify.cshtml"
                                       WriteLiteral(item.Name);

#line default
#line hidden
                __tagHelperStringValueBuffer = EndWriteTagHelperAttribute();
                __Microsoft_AspNetCore_Mvc_TagHelpers_OptionTagHelper.Value = __tagHelperStringValueBuffer;
                __tagHelperExecutionContext.AddTagHelperAttribute("value", __Microsoft_AspNetCore_Mvc_TagHelpers_OptionTagHelper.Value, global::Microsoft.AspNetCore.Razor.TagHelpers.HtmlAttributeValueStyle.DoubleQuotes);
                await __tagHelperRunner.RunAsync(__tagHelperExecutionContext);
                if (!__tagHelperExecutionContext.Output.IsContentModified)
                {
                    await __tagHelperExecutionContext.SetOutputContentAsync();
                }
                Write(__tagHelperExecutionContext.Output);
                __tagHelperExecutionContext = __tagHelperScopeManager.End();
                EndContext();
                BeginContext(5266, 2, true);
                WriteLiteral("\r\n");
                EndContext();
#line 102 "D:\2018Project\ERP项目\SoaProJect\FytSoa.Web\Pages\FytAdmin\Purchase\Modify.cshtml"
                                }
                            

#line default
#line hidden
                BeginContext(5334, 371, true);
                WriteLiteral(@"                        </select>
                    </td>
                    <td><input type=""number"" v-model=""it.Quantity"" class=""layui-input"" /></td>
                    <td><input type=""number"" v-model=""it.Price"" class=""layui-input"" /></td>
                    <td><input type=""text"" v-model=""it.Summary"" class=""layui-input"" /></td>
                    <td><i ");
                EndContext();
                BeginContext(5706, 945, true);
                WriteLiteral(@"@click=""addTableRow()"" class=""layui-icon layui-icon-add-circle-fine""></i></td>
                </tr>
            </tbody>
        </table>
    </div>
    <div class=""layui-form-item"" v-for=""it,index in attrList"">
        <div class=""layui-inline"">
            <label class=""layui-form-label"">自定义</label>
            <div class=""layui-input-inline"">
                <input type=""text"" v-model=""it.Name"" placeholder=""如支付方式"" autocomplete=""off"" class=""layui-input"">
            </div>
        </div>
        <div class=""layui-inline"">
            <div class=""layui-input-inline"">
                <input type=""text"" v-model=""it.Value"" placeholder=""银行转账"" autocomplete=""off"" class=""layui-input"">
            </div>
        </div>
    </div>
    <div class=""layui-form-item"">
        <div class=""layui-inline"">
            <label class=""layui-form-label""></label>
            <div class=""layui-input-inline"">
                <span ");
                EndContext();
                BeginContext(6652, 336, true);
                WriteLiteral(@"@click=""addAttrRow()"" class=""addAttr""><i class=""layui-icon layui-icon-add-circle""></i>添加自定义</span>
            </div>
        </div>
    </div>
    <div class=""layui-form-item"">
        <label class=""layui-form-label"">描述</label>
        <div class=""layui-input-block"">
            <textarea name=""Summary"" class=""layui-textarea"">");
                EndContext();
                BeginContext(6989, 22, false);
#line 138 "D:\2018Project\ERP项目\SoaProJect\FytSoa.Web\Pages\FytAdmin\Purchase\Modify.cshtml"
                                                       Write(Model.Purchase.Summary);

#line default
#line hidden
                EndContext();
                BeginContext(7011, 376, true);
                WriteLiteral(@"</textarea>
        </div>
    </div>
    <div class=""layui-form-item"">
        <div class=""layui-input-block"">
            <button class=""layui-btn"" lay-submit="""" lay-filter=""submit"">立即提交</button>
            <button type=""button"" class=""layui-btn layui-btn-primary btn-open-close"">取消</button>
        </div>
    </div>
    <input type=""hidden"" name=""Guid"" id=""Guid""");
                EndContext();
                BeginWriteAttribute("value", " value=\"", 7387, "\"", 7415, 1);
#line 147 "D:\2018Project\ERP项目\SoaProJect\FytSoa.Web\Pages\FytAdmin\Purchase\Modify.cshtml"
WriteAttributeValue("", 7395, Model.Purchase.Guid, 7395, 20, false);

#line default
#line hidden
                EndWriteAttribute();
                BeginContext(7416, 43, true);
                WriteLiteral(" />\r\n    <input type=\"hidden\" name=\"Status\"");
                EndContext();
                BeginWriteAttribute("value", " value=\"", 7459, "\"", 7489, 1);
#line 148 "D:\2018Project\ERP项目\SoaProJect\FytSoa.Web\Pages\FytAdmin\Purchase\Modify.cshtml"
WriteAttributeValue("", 7467, Model.Purchase.Status, 7467, 22, false);

#line default
#line hidden
                EndWriteAttribute();
                BeginContext(7490, 44, true);
                WriteLiteral(" />\r\n    <input type=\"hidden\" name=\"AddDate\"");
                EndContext();
                BeginWriteAttribute("value", " value=\"", 7534, "\"", 7565, 1);
#line 149 "D:\2018Project\ERP项目\SoaProJect\FytSoa.Web\Pages\FytAdmin\Purchase\Modify.cshtml"
WriteAttributeValue("", 7542, Model.Purchase.AddDate, 7542, 23, false);

#line default
#line hidden
                EndWriteAttribute();
                BeginContext(7566, 46, true);
                WriteLiteral(" />\r\n    <input type=\"hidden\" name=\"AdminGuid\"");
                EndContext();
                BeginWriteAttribute("value", " value=\"", 7612, "\"", 7645, 1);
#line 150 "D:\2018Project\ERP项目\SoaProJect\FytSoa.Web\Pages\FytAdmin\Purchase\Modify.cshtml"
WriteAttributeValue("", 7620, Model.Purchase.AdminGuid, 7620, 25, false);

#line default
#line hidden
                EndWriteAttribute();
                BeginContext(7646, 43, true);
                WriteLiteral(" />\r\n    <input type=\"hidden\" name=\"Number\"");
                EndContext();
                BeginWriteAttribute("value", " value=\"", 7689, "\"", 7719, 1);
#line 151 "D:\2018Project\ERP项目\SoaProJect\FytSoa.Web\Pages\FytAdmin\Purchase\Modify.cshtml"
WriteAttributeValue("", 7697, Model.Purchase.Number, 7697, 22, false);

#line default
#line hidden
                EndWriteAttribute();
                BeginContext(7720, 101, true);
                WriteLiteral(" />\r\n    <input type=\"hidden\" name=\"Attribute\" value=\"\" />\r\n    <input type=\"hidden\" name=\"GoodsList\"");
                EndContext();
                BeginWriteAttribute("value", " value=\"", 7821, "\"", 7854, 1);
#line 153 "D:\2018Project\ERP项目\SoaProJect\FytSoa.Web\Pages\FytAdmin\Purchase\Modify.cshtml"
WriteAttributeValue("", 7829, Model.Purchase.GoodsList, 7829, 25, false);

#line default
#line hidden
                EndWriteAttribute();
                BeginContext(7855, 56, true);
                WriteLiteral(" />\r\n    <input type=\"hidden\" id=\"isSave\" value=\"0\" />\r\n");
                EndContext();
            }
            );
            __Microsoft_AspNetCore_Mvc_TagHelpers_FormTagHelper = CreateTagHelper<global::Microsoft.AspNetCore.Mvc.TagHelpers.FormTagHelper>();
            __tagHelperExecutionContext.Add(__Microsoft_AspNetCore_Mvc_TagHelpers_FormTagHelper);
            __Microsoft_AspNetCore_Mvc_TagHelpers_RenderAtEndOfFormTagHelper = CreateTagHelper<global::Microsoft.AspNetCore.Mvc.TagHelpers.RenderAtEndOfFormTagHelper>();
            __tagHelperExecutionContext.Add(__Microsoft_AspNetCore_Mvc_TagHelpers_RenderAtEndOfFormTagHelper);
            __tagHelperExecutionContext.AddHtmlAttribute(__tagHelperAttribute_4);
            __tagHelperExecutionContext.AddHtmlAttribute(__tagHelperAttribute_5);
            __tagHelperExecutionContext.AddHtmlAttribute(__tagHelperAttribute_6);
            await __tagHelperRunner.RunAsync(__tagHelperExecutionContext);
            if (!__tagHelperExecutionContext.Output.IsContentModified)
            {
                await __tagHelperExecutionContext.SetOutputContentAsync();
            }
            Write(__tagHelperExecutionContext.Output);
            __tagHelperExecutionContext = __tagHelperScopeManager.End();
            EndContext();
            BeginContext(7918, 68, true);
            WriteLiteral("\r\n<script type=\"text/html\" id=\"selectTpl\">\r\n    <select name=\"Unit\">");
            EndContext();
            BeginContext(7986, 18, false);
            __tagHelperExecutionContext = __tagHelperScopeManager.Begin("option", global::Microsoft.AspNetCore.Razor.TagHelpers.TagMode.StartTagAndEndTag, "59842636ac5f4ed38447050946887c01", async() => {
                BeginContext(7994, 1, true);
                WriteLiteral("件");
                EndContext();
            }
            );
            __Microsoft_AspNetCore_Mvc_TagHelpers_OptionTagHelper = CreateTagHelper<global::Microsoft.AspNetCore.Mvc.TagHelpers.OptionTagHelper>();
            __tagHelperExecutionContext.Add(__Microsoft_AspNetCore_Mvc_TagHelpers_OptionTagHelper);
            await __tagHelperRunner.RunAsync(__tagHelperExecutionContext);
            if (!__tagHelperExecutionContext.Output.IsContentModified)
            {
                await __tagHelperExecutionContext.SetOutputContentAsync();
            }
            Write(__tagHelperExecutionContext.Output);
            __tagHelperExecutionContext = __tagHelperScopeManager.End();
            EndContext();
            BeginContext(8004, 18, false);
            __tagHelperExecutionContext = __tagHelperScopeManager.Begin("option", global::Microsoft.AspNetCore.Razor.TagHelpers.TagMode.StartTagAndEndTag, "c03f3027610c45eea38de79b542cf3de", async() => {
                BeginContext(8012, 1, true);
                WriteLiteral("个");
                EndContext();
            }
            );
            __Microsoft_AspNetCore_Mvc_TagHelpers_OptionTagHelper = CreateTagHelper<global::Microsoft.AspNetCore.Mvc.TagHelpers.OptionTagHelper>();
            __tagHelperExecutionContext.Add(__Microsoft_AspNetCore_Mvc_TagHelpers_OptionTagHelper);
            await __tagHelperRunner.RunAsync(__tagHelperExecutionContext);
            if (!__tagHelperExecutionContext.Output.IsContentModified)
            {
                await __tagHelperExecutionContext.SetOutputContentAsync();
            }
            Write(__tagHelperExecutionContext.Output);
            __tagHelperExecutionContext = __tagHelperScopeManager.End();
            EndContext();
            BeginContext(8022, 24, true);
            WriteLiteral("</select>\r\n</script>\r\n\r\n");
            EndContext();
            BeginContext(8046, 75, false);
            __tagHelperExecutionContext = __tagHelperScopeManager.Begin("link", global::Microsoft.AspNetCore.Razor.TagHelpers.TagMode.StartTagOnly, "48009a9a2eb44a82ac1810d2f36906df", async() => {
            }
            );
            __Microsoft_AspNetCore_Mvc_Razor_TagHelpers_UrlResolutionTagHelper = CreateTagHelper<global::Microsoft.AspNetCore.Mvc.Razor.TagHelpers.UrlResolutionTagHelper>();
            __tagHelperExecutionContext.Add(__Microsoft_AspNetCore_Mvc_Razor_TagHelpers_UrlResolutionTagHelper);
            __tagHelperExecutionContext.AddHtmlAttribute(__tagHelperAttribute_7);
            __tagHelperExecutionContext.AddHtmlAttribute(__tagHelperAttribute_8);
            __tagHelperExecutionContext.AddHtmlAttribute(__tagHelperAttribute_9);
            await __tagHelperRunner.RunAsync(__tagHelperExecutionContext);
            if (!__tagHelperExecutionContext.Output.IsContentModified)
            {
                await __tagHelperExecutionContext.SetOutputContentAsync();
            }
            Write(__tagHelperExecutionContext.Output);
            __tagHelperExecutionContext = __tagHelperScopeManager.End();
            EndContext();
            BeginContext(8121, 727, true);
            WriteLiteral(@"
<script>
    var app, data = {
        supplier:[],
        tabList: [
            { 'Number': '', 'Name': '', 'Specification': '', 'Unit': '', 'Quantity': '0', 'Price': '0','Summary':'' },
            { 'Number': '', 'Name': '', 'Specification': '', 'Unit': '', 'Quantity': '0', 'Price': '0', 'Summary': '' },
            { 'Number': '', 'Name': '', 'Specification': '', 'Unit': '', 'Quantity': '0', 'Price': '0', 'Summary': '' }
        ],
        attrList: [
            { 'Name': '', 'Value': '' }
        ],
        couponSelected: '',
    };
    var vm = new Vue({
        el: ""#app"",
        data: data,
        created: function () { 
            var that = this;
            this.couponSelected = '");
            EndContext();
            BeginContext(8849, 27, false);
#line 179 "D:\2018Project\ERP项目\SoaProJect\FytSoa.Web\Pages\FytAdmin\Purchase\Modify.cshtml"
                              Write(Model.Purchase.SupplierGuid);

#line default
#line hidden
            EndContext();
            BeginContext(8876, 31, true);
            WriteLiteral("\';\r\n            var attrStr = \'");
            EndContext();
            BeginContext(8908, 34, false);
#line 180 "D:\2018Project\ERP项目\SoaProJect\FytSoa.Web\Pages\FytAdmin\Purchase\Modify.cshtml"
                      Write(Html.Raw(Model.Purchase.Attribute));

#line default
#line hidden
            EndContext();
            BeginContext(8942, 133, true);
            WriteLiteral("\';\r\n            if (attrStr != \"\") {\r\n                that.attrList = JSON.parse(attrStr);\r\n            }\r\n            var tabStr = \'");
            EndContext();
            BeginContext(9076, 25, false);
#line 184 "D:\2018Project\ERP项目\SoaProJect\FytSoa.Web\Pages\FytAdmin\Purchase\Modify.cshtml"
                     Write(Html.Raw(Model.GoodsJson));

#line default
#line hidden
            EndContext();
            BeginContext(9101, 4738, true);
            WriteLiteral(@"';
            if (tabStr != """") {                
                that.tabList = JSON.parse(tabStr);  
                if (that.tabList.length < 3) {
                    for (var i = 0; i < 3 - that.tabList.length; i++) {
                        that.tabList.push({
                            'Number': '', 'Name': '', 'Specification': '', 'Unit': '', 'Quantity': '0', 'Price': '0', 'Summary': ''
                        });  
                    }
                }
            }
        },
        methods: {
            addTableRow: function () {               
                this.tabList.push({
                    'Number': '', 'Name': '', 'Specification': '', 'Unit': '', 'Quantity': '0', 'Price': '0', 'Summary': ''
                });                              
            },
            addAttrRow: function () {
                this.attrList.push({
                    'Name': '', 'Value': ''
                });
            }
        }
    });
    layui.define(['layer', 'city-pic");
            WriteLiteral(@"ker'], function (exports) {
        ""use strict"";
        exports('citys', null);
    });
    layui.config({
        base: '/themes/js/modules/'
    }).use(['table', 'layer', 'jquery', 'common', 'form', 'laydate'], function () {
        var form = layui.form, $ = layui.$, os = layui.common, laydate = layui.laydate;
        var index = parent.layer.getFrameIndex(window.name);
        laydate.render({
            elem: '#AddDate'
            , theme: '#393D49'
            , type: 'datetime'
        });
        laydate.render({
            elem: '#DeliverDate'
            , theme: '#393D49'
            , type: 'datetime'
        });        
        form.on('select(selSupplier)', function (data) {            
            if (data.value == 0 && data.value) {                
                $(""#Supplier"").val('');
                form.render('select');
                var winH = $(window).height();
                layuiIndex = layer.open({
                    title: '添加供应商'
               ");
            WriteLiteral(@"     , type: 2
                    , area: ['700px', winH+'px']
                    , shade: [0.1, '#333']
                    , resize: false
                    , anim: -1
                    , offset: 'rb'
                    , shadeClose: true
                    , skin: 'layer-anim-07'
                    , content: ""/fytadmin/purchase/suppliermodify""
                    , end: function () {                       
                        if (parseInt($(""#isSave"").val()) == 1) {
                            app.initSupplier();
                        }         
                        $(""#isSave"").val('0');
                    }
                });
            } else {
                if (data.value) { 
                    os.ajax('api/purchase/supplierbyid', { parm: data.value }, function (res) { 
                        if (res.statusCode === 200) {
                            $('#Contacts').val(res.data.contacts);
                            $('#Mobile').val(res.data.mobile)
      ");
            WriteLiteral(@"                  } else {
                            os.error(res.message);
                        }
                    });
                }
            }
        });
        //监听提交
        form.on('submit(submit)', function (data) {
            var urls = ""api/purchase/addpurchase"";
            if ($(""#Guid"").val()) {
                urls = ""api/purchase/editpurchase"";
            }
            data.field.Attribute = JSON.stringify(vm.attrList);
            data.field.GoodsList = JSON.stringify(vm.tabList);
            os.ajax(urls, data.field, function (res) {
                if (res.statusCode == 200) {
                    parent.layer.close(index);
                }
                else {
                    os.error(res.message);
                }
            });
            return false;
        });
        app = {
            selectRender: function () {
                form.render('select'); 
            }
            , initSupplier: function () { 
                os.");
            WriteLiteral(@"ajax('api/purchase/supplierlist', { limit: 1000 }, function (res) { 
                    if (res.statusCode === 200) {
                        vm.supplier = res.data.items;                        
                        vm.$nextTick(function () {
                            form.render('select'); 
                        })
                    } else {
                        os.error(res.message);
                    }
                })
            }
        }
        app.initSupplier();
        $("".btn-open-close"").on('click', function () {
            parent.layer.close(index);
        });
    });
</script>


");
            EndContext();
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
        public global::Microsoft.AspNetCore.Mvc.Rendering.IHtmlHelper<FytSoa.Web.Pages.FytAdmin.Purchase.ModifyModel> Html { get; private set; }
        public global::Microsoft.AspNetCore.Mvc.ViewFeatures.ViewDataDictionary<FytSoa.Web.Pages.FytAdmin.Purchase.ModifyModel> ViewData => (global::Microsoft.AspNetCore.Mvc.ViewFeatures.ViewDataDictionary<FytSoa.Web.Pages.FytAdmin.Purchase.ModifyModel>)PageContext?.ViewData;
        public FytSoa.Web.Pages.FytAdmin.Purchase.ModifyModel Model => ViewData.Model;
    }
}
#pragma warning restore 1591
