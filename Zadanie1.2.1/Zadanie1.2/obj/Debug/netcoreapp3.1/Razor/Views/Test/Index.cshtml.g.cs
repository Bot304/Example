#pragma checksum "C:\C#\Zadanie1.2.1\Zadanie1.2\Views\Test\Index.cshtml" "{ff1816ec-aa5e-4d10-87f7-6f4963833460}" "992247230efbb34d6e30b7c2d4976c86eb95fd7b"
// <auto-generated/>
#pragma warning disable 1591
[assembly: global::Microsoft.AspNetCore.Razor.Hosting.RazorCompiledItemAttribute(typeof(AspNetCore.Views_Test_Index), @"mvc.1.0.view", @"/Views/Test/Index.cshtml")]
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
#nullable restore
#line 1 "C:\C#\Zadanie1.2.1\Zadanie1.2\Views\_ViewImports.cshtml"
using Zadanie1._2;

#line default
#line hidden
#nullable disable
#nullable restore
#line 2 "C:\C#\Zadanie1.2.1\Zadanie1.2\Views\_ViewImports.cshtml"
using Zadanie1._2.Models;

#line default
#line hidden
#nullable disable
    [global::Microsoft.AspNetCore.Razor.Hosting.RazorSourceChecksumAttribute(@"SHA1", @"992247230efbb34d6e30b7c2d4976c86eb95fd7b", @"/Views/Test/Index.cshtml")]
    [global::Microsoft.AspNetCore.Razor.Hosting.RazorSourceChecksumAttribute(@"SHA1", @"f69d43cd48644dd7832c792a6b4fcc0774c66a3c", @"/Views/_ViewImports.cshtml")]
    #nullable restore
    public class Views_Test_Index : global::Microsoft.AspNetCore.Mvc.Razor.RazorPage<dynamic>
    #nullable disable
    {
        #pragma warning disable 1998
        public async override global::System.Threading.Tasks.Task ExecuteAsync()
        {
#nullable restore
#line 1 "C:\C#\Zadanie1.2.1\Zadanie1.2\Views\Test\Index.cshtml"
  
    ViewData["Title"] = "Тест";

#line default
#line hidden
#nullable disable
            WriteLiteral(@"

<div id=""user"" class=""container"" style=""max-width:100%"">
    <div class=""row"">
        <div class=""col-1 pt-2"">

            <input id=""Name"" placeholder=""имя"" class=""form-control text-center"" />

        </div>

        <div class=""col-1 pl-0 pr-3 pb-3 pt-2"">

            <input id=""Surname"" placeholder=""фамилия"" class=""form-control text-center"" />

        </div>

        <div class=""col-1 pl-0 pr-3 pb-3 pt-2"">

            <input id=""Patronymic"" placeholder=""отчество"" class=""form-control text-center"" />

        </div>

        <div class=""col-2 pl-0 pr-3 pb-3 pt-2"">

            <input id=""DateBirth"" placeholder=""дата рождения"" class=""form-control text-center"" />

        </div>

        <div class=""col-2 pl-0 pr-3 pb-3 pt-2"">

            <input id=""Number"" placeholder=""телефон"" class=""form-control text-center"" />

        </div>

        <div class=""col-2 pl-0 pr-3 pb-3 pt-2"">

            <input id=""Email"" placeholder=""почта"" class=""form-control text-center"" />

");
            WriteLiteral("        </div>\r\n\r\n        <div class=\"col-2 pl-0 pr-3 pb-3 pt-2\">\r\n\r\n            ");
#nullable restore
#line 46 "C:\C#\Zadanie1.2.1\Zadanie1.2\Views\Test\Index.cshtml"
       Write(Html.DropDownList("OrganizationId", null, "организация", htmlAttributes: new { @class = "form-control" }));

#line default
#line hidden
#nullable disable
            WriteLiteral("\r\n\r\n");
            WriteLiteral(@"
        </div>

        <div class=""pl-0 pr-3 pb-3 pt-2"">

            <button id=""ButtonAddUser"" style=""margin-right: 5px; height: 38px;"" class=""btn-sm btn-primary"">+сотрудник</button>

        </div>
    </div>



    <div class=""row"">
        <div class=""col"">
            <div class=""table-responsive"">
");
            WriteLiteral(@"

                <table id=""table"" class=""table table-hover table-bordered table-sm text-center "">
                    <thead class=""thead-dark"">
                        <tr>
                            <th class=""align-middle"">
                                Имя
                            </th>
                            <th class=""align-middle"">
                                Фамилия
                            </th>
                            <th class=""align-middle"">
                                Отчество
                            </th>
                            <th class=""align-middle"">
                                Дата рождения
                            </th>
                            <th class=""align-middle"">
                                Телефон
                            </th>
                            <th class=""align-middle"">
                                Эмеил
                            </th>
                            <th class=""align-middle"">
 ");
            WriteLiteral(@"                               Организация
                            </th>
                        </tr>
                    </thead>
                    <tbody id=""TBody"">
                        <tr class=""UserListItem"" id=""UserListItem"">
                            <td class=""align-middle text-left"">
                                <button class=""RemoveUser"" value=""$NameId"">X</button><input value=""$Name"" class=""Name"" style=""max-width:80%"" />
                            </td>
                            <td class=""align-middle text-left"">
                                <input value=""$Surname"" class=""Surname"" />
                            </td>
                            <td class=""align-middle text-left"">
                                <input value=""$Patronymic"" class=""Patronymic"" />
                            </td>
                            <td class=""align-middle text-left"">
                                <input value=""$DateBirth"" class=""DateBirth"" />
                           ");
            WriteLiteral(@" </td>
                            <td class=""align-middle text-left"">
                                <input value=""$Number"" class=""Number"" />
                            </td>
                            <td class=""align-middle text-left"">
                                <input value=""$Email"" class=""Email"" />
                            </td>
                            <td class=""align-middle"">
");
            WriteLiteral("                                ");
#nullable restore
#line 122 "C:\C#\Zadanie1.2.1\Zadanie1.2\Views\Test\Index.cshtml"
                           Write(Html.DropDownList("Id", ViewBag.Books as SelectList));

#line default
#line hidden
#nullable disable
            WriteLiteral(@"

                            </td>
                        </tr>
                    </tbody>
                </table>

            </div>
        </div>
    </div>
</div>


<script src=""https://ajax.googleapis.com/ajax/libs/jquery/3.4.1/jquery.min.js""></script>

<script>

    function did(id) { return document.getElementById(id); }

    var userListItem;

    userListItem = did('UserListItem').outerHTML;

    did('UserListItem').outerHTML = '';

    $(document).ready(async function () {

        GetUser();

        // получение пользователей

        function GetUser() {

            did('TBody').innerHTML = '';

            $.ajax({
                url: ""/Test/GetUser"",
                type: ""POST"",
                success: function (json) {

                    $.each(json, function () {

                        addRow(this.name, this.surname, this.patronymic, this.dateBirth, this.number, this.email, this.org, this.id);

                    });

              ");
            WriteLiteral(@"  }
            });

        }

        // через эту функцию можно добавить сотрудника
        function addRow(NameRow, SurnameRow, PatronymicRow, DateBirthRow, NumberRow, EmailRow, OrganizationRow, NameIdRow) {

            $('#table > tbody:last-child').append(userListItem
                .replace('$NameId', NameIdRow)
                .replace('$Name', NameRow)
                .replace('$Surname', SurnameRow)
                .replace('$Patronymic', PatronymicRow)
                .replace('$DateBirth', DateBirthRow)
                .replace('$Number', NumberRow)
                .replace('$Email', EmailRow)
                /*.replace('$Organization', OrganizationRow)*/
            );

        }
        // добавить пользователя
        $('#ButtonAddUser').click(function () {

            var name = $('#Name').val()
            var surname = $('#Surname').val()
            var patronymic = $('#Patronymic').val()
            var datebirth = $('#DateBirth').val()
            var number ");
            WriteLiteral(@"= $('#Number').val()
            var email = $('#Email').val()
            var orgId = $('#OrganizationId').val()

            $.ajax({
                url: ""/Test/AddUser"",
                data: { 'name': name, 'surname': surname, 'patronymic': patronymic, 'datebirth': datebirth, 'number': number, 'email': email, 'orgId': orgId },
                type: ""POST"",
                success: function (json) {

                    $.each(json, function () {

                        var nameId = this.id;
                        var name = this.name;
                        var surname = this.surname;
                        var patronymic = this.patronymic;
                        var datebirth = this.datebirth;
                        var number = this.number;
                        var email = this.email;
                        var org = this.organizationName;

                        addRow(name, surname, patronymic, datebirth, number, email, org, nameId);

                        //$('tab");
            WriteLiteral(@"le#table tbody').append(

                        //    '<tr class=""UserListItem"" id=""UserListItem"">' +
                        //    '<td class=""align-middle text-left"">' +
                        //    '<button class=""RemoveUser"" value=""' + nameId + '"">X</button> <input value=""' + name + '"" class=""Name""/>' +
                        //    '</td>' +

                        //    '<td class=""align-middle text-left"">' +
                        //    '<input value=""' + surname + '"" class=""Surname""/>' +
                        //    '</td>' +
                        //    '<td class=""align-middle text-left"">' +
                        //    '<input value=""' + patronymic + '"" class=""Patronymic""/>' +
                        //    '</td>' +
                        //    '<td class=""align-middle text-left"">' +
                        //    '<input value=""' + datebirth + '"" class=""DateBirth""/>' +
                        //    '</td>' +
                        //    '<td class=""align-middle text-left"">");
            WriteLiteral(@"' +
                        //    '<input value=""' + number + '"" class=""Number""/>' +
                        //    '</td>' +
                        //    '<td class=""align-middle text-left"">' +
                        //    '<input value=""' + email + '"" class=""Email""/>' +
                        //    '</td>' +

                        //    '<td class=""align-middle"">' +
");
            WriteLiteral(@"                        //    '<select class = ""form-control"" id=""Organization"" name=""Organization""><option value="""">' + org + '</option>' +
                        //    '<option value=""1"">""СанетехЭл""</option>' +
                        //    '<option value=""2"">""Рога""</option>' +
                        //    '</select>' +
                        //    '</td>' +
                        //    '</tr>'

                        //)

                    });

                }
            });

        });

        // удалить пользователя
        $(document).on(""click"", ""table#table button.RemoveUser"", async function () {

            var nameid = $(this).val();


            $.ajax({
                url: ""/Test/RemoveUser"",
                data: { 'nameid': nameid },
                type: ""POST"",
                success: function () {

                    $('table#table tbody tr').each(function () {

                        if ($(this).find('button.RemoveUser').val() == nameid) {

 ");
            WriteLiteral(@"                           $(this).remove();

                        }

                    });

                }
            });

        });

        $(document).on(""change"", ""table#table tbody tr"", async function () {

            var thisTr = $(this).closest(""tr"");

            var name = thisTr.find('input.Name').val();
            var surname = thisTr.find('input.Surname').val();
            var patronymic = thisTr.find('input.Patronymic').val();
            var datebirth = thisTr.find('input.DateBirth').val();
            var number = thisTr.find('input.Number').val();
            var email = thisTr.find('input.Email').val();

            var nameid = thisTr.find('button.RemoveUser').val();

            

            //$('#Organization').each(function GetValue() {

            //    if ($(this).find('button.RemoveUser').val() == nameid) {
            //        var getValue = this.value;
                   
            //        alert(getValue);
            //    }
   ");
            WriteLiteral(@"         //    return 0;
            //});
            //var n = document.getElementById(""Organization"").options.selectedIndex;  document.getElementById(""Organization"").options[n].value;
            var orgId = thisTr.find('select.form-control').val();
            



            $.ajax({
                url: ""/Test/UpdateUser"",
                data: { 'nameid': nameid, 'name': name, 'surname': surname, 'patronymic': patronymic, 'datebirth': datebirth, 'number': number, 'email': email, 'orgId': orgId },
                type: ""POST"",
                success: function () {

                    $('table#table tbody tr').each(function () {

                        if ($(this).find('button.RemoveUser').val() == nameid) {

                            $(this).find('input.Name').val(name);
                            $(this).find('input.Surname').val(surname);
                            $(this).find('input.Patronymic').val(patronymic);
                            $(this).find('input.DateBirth').");
            WriteLiteral(@"val(datebirth);
                            $(this).find('input.Number').val(number);
                            $(this).find('input.Email').val(email);

                            $(this).find('select.form-control').val(orgId);
                            //$('#Organization').val(orgId);


                        }

                    });

                }
            });

        });

    });


</script>
");
        }
        #pragma warning restore 1998
        #nullable restore
        [global::Microsoft.AspNetCore.Mvc.Razor.Internal.RazorInjectAttribute]
        public global::Microsoft.AspNetCore.Mvc.ViewFeatures.IModelExpressionProvider ModelExpressionProvider { get; private set; } = default!;
        #nullable disable
        #nullable restore
        [global::Microsoft.AspNetCore.Mvc.Razor.Internal.RazorInjectAttribute]
        public global::Microsoft.AspNetCore.Mvc.IUrlHelper Url { get; private set; } = default!;
        #nullable disable
        #nullable restore
        [global::Microsoft.AspNetCore.Mvc.Razor.Internal.RazorInjectAttribute]
        public global::Microsoft.AspNetCore.Mvc.IViewComponentHelper Component { get; private set; } = default!;
        #nullable disable
        #nullable restore
        [global::Microsoft.AspNetCore.Mvc.Razor.Internal.RazorInjectAttribute]
        public global::Microsoft.AspNetCore.Mvc.Rendering.IJsonHelper Json { get; private set; } = default!;
        #nullable disable
        #nullable restore
        [global::Microsoft.AspNetCore.Mvc.Razor.Internal.RazorInjectAttribute]
        public global::Microsoft.AspNetCore.Mvc.Rendering.IHtmlHelper<dynamic> Html { get; private set; } = default!;
        #nullable disable
    }
}
#pragma warning restore 1591