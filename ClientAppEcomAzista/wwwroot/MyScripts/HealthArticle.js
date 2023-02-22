
$(document).ready(function () {    
    GetAll();
    function GetAll() {
        $("table tbody").html("");
        $.ajax({
            url: "http://localhost:35487/api/HealthArticlesApi",
            type: "get",
            contentType: "application/json",
            success: function (result, status, xhr) {
                console.log(JSON.stringify(result));
                
                $.each(result, function (index, value) {
                    $("tbody").append($("<tr>"));
                    appendElement = $("tbody tr").last();
                    appendElement.append($("<td>").html(value["Id"]));
                    appendElement.append($("<td>").html(value["Title"]));
                    appendElement.append($("<td>").html(value["Description"]));
                    appendElement.append($("<td>").html("<img src="+value["Image"]+" height='100' width='100'>"));
                    //appendElement.append($("<td>").html("<a href=\"UpdateReservation.html?id=" + value["id"] + "\"><img src=\"icon/edit.png\" /></a>"));
                    //appendElement.append($("<td>").html("<img class=\"delete\" src=\"icon/close.png\" />"));
                });
            },
            error: function (xhr, status, error) {
                console.log(xhr)
            }
        });
    };

    //Add Data Function
    function Add() {
        var res = validate();
        if (res == false) {
            return false;
        }
        var model = {
            ID: "0",// $('#ID').val(),      
            BrandName: $('#txtBrandName').val(),
            MoleculeId: $('#ddlMolecules').val(),
            BrandCompanyId: $('#ddlCompaniess').val(),
            Active: $('#ActiveStatus').val()
        };
        var action = $("#Add").val();
        $.ajax({
            url: action,
            data: JSON.stringify(model),
            type: "POST",
            contentType: "application/json;charset=utf-8",
            dataType: "json",
            success: function (result) {
                if (result.redirectTo) {
                    alert('session expired');
                    window.location.href = $('#LogOut').val();
                }
                //  loadData();
                if (result == "Already Taken") {
                    alert(result);
                }
                else {
                    alert(result);
                    $('#myModal').modal('hide');
                    $('#div1').show(location.reload());
                }
            },
            error: function (errormessage) {
                alert(errormessage.responseText);
            }
        });
    }
    function getbyID(Id) {
        var id = { id: Id };
        // alert('in getbyid'+Id);
        var action = $("#GetById").val();
        //$(this).find('#inputActiveStatus').show();
        $.ajax({
            url: action,
            type: "POST",
            data: JSON.stringify(id),
            contentType: "application/json;charset=UTF-8",
            dataType: "json",
            success: function (result) {
                if (result.redirectTo) {
                    alert('session expired');
                    window.location.href = $('#LogOut').val();
                }
                $('#ID').val(result.BrandId);
                $('#txtBrandName').val(result.BrandName);
                $('#ddlMolecules').val(result.MoleculeId);
                $('#ddlCompaniess').val(result.BrandCompanyId);

                $('#ActiveStatus').val(result.Active);
                //$('#State').val(result.State);
                //$('#Country').val(result.Country);

                $('#btnUpdate').show();
                $('#btnAdd').hide();
                $('#myModal').modal('show');

                var numbers = ['Y', 'N'];
                var option = '';
                for (var i = 0; i < numbers.length; i++) {
                    option += '<option value="' + numbers[i] + '">' + numbers[i] + '</option>';
                }
                var activests = result.ActiveStatus;
                var v = ('#ddlActiveStatus' + Id).replace(/\s/g, '');
                $(v).empty();
                $(v).append(option);
                $(v).show();
                $(v).val(activests);

                var btnAdd = ('#btnAdd').replace(/\s/g, '');
                $(btnAdd).hide();
                var btnupdate = ('#btnUpdate').replace(/\s/g, '');
                $(btnupdate).show();
                var btncancel = ('#btnCancel').replace(/\s/g, '');
                $(btncancel).show();
                //var btnActDec = ('#btnDel' + Id).replace(/\s/g, '');
                //$(btnActDec).hide();
                // alert(actionID + 'test' + typeinputid);
            },
            error: function (errormessage) {
                alert('error' + id);

            }
        });
        // return false;
    }
    function Update() {
        //  var b = ('#inputType' + Id).replace(/\s/g, '');
        //var c = ('#ddlActiveStatus' + Id).replace(/\s/g, '');    
        var model = {
            BrandId: $('#ID').val(),
            BrandName: $('#txtBrandName').val(),
            MoleculeId: $('#ddlMolecules').val(),
            BrandCompanyId: $('#ddlCompaniess').val(),
            Active: $('#ActiveStatus').val()
        }

        var res = validatee(model);
        if (res == false) {
            return false;
            $("#Update").prop('disabled', true);
        }
        else {
            $("#Update").prop('disabled', false);
            $('#myModal').modal('hide')
        }
        var action = $("#Update").val();
        var Id = $('#ID').val();
        $.ajax({
            url: action,
            data: JSON.stringify(model),
            type: "POST",
            contentType: "application/json;charset=utf-8",
            dataType: "json",
            success: function (result) {
                if (result.redirectTo) {
                    alert('session expired');
                    window.location.href = $('#LogOut').val();
                }
                // alert(JSON.stringify(result));
                if (result.Status == "Already Exists") { alert(result.Status); }
                else {

                    //var v = ('#ddlActiveStatus' + Id).replace(/\s/g, '');
                    //$(v).hide();    

                    var BrandName = ('#divBrandName' + Id).replace(/\s/g, '');
                    $(BrandName).html(result.brandsVm.BrandName);

                    var MoleculeName = ('#divMoleculeName' + Id).replace(/\s/g, '');
                    $(MoleculeName).html(result.brandsVm.MoleculeName);

                    var BrandCompanyName = ('#divBrandCompanyName' + Id).replace(/\s/g, '');
                    $(BrandCompanyName).html(result.brandsVm.BrandCompanyName);

                    var Active = ('#divActiveStatus' + Id).replace(/\s/g, '');
                    $(Active).html(result.brandsVm.Active);


                    var btnedit = ('#btnEdit1' + Id).replace(/\s/g, '');
                    $(btnedit).show();
                    //var btnupdate = ('#btnUpdate1' + Id).replace(/\s/g, '');
                    //$(btnupdate).hide();
                    //var btncancel = ('#btnCancel1' + Id).replace(/\s/g, '');
                    //$(btncancel).hide();
                    var btnActDec = ('#btnDel' + Id).replace(/\s/g, '');
                    $(btnActDec).show();
                    var btndel = "";
                    btndel = ('#btnDel' + Id).replace(/\s/g, '');
                    //alert(btndel);
                    if (result.brandsVm.Active == 'Y') {
                        $(btndel).html("Deactivate");
                    }
                    else if (result.brandsVm.Active == 'N') {
                        $(btndel).html("Activate");
                    } else { }
                    // alert(result.Status);
                }

            },
            error: function (errormessage) {
                alert(errormessage.responseText);
            }
        })
    }
    function validatee(model) {
        var isValid = true;
        var inputType = (('#inputType') + model.ID).replace(/\s/g, '');
        //alert(model.ID+' in validation');
        if (model.BrandName.trim() == "") {
            $("#txtBrandName").css('border-color', 'Red');
            //  alert('please enter something');
            isValid = false;
        }
        else {
            $("#txtBrandName").css('border-color', 'lightgrey');
        }
        if (model.MoleculeId == "") {
            $("#ddlMolecules").css('border-color', 'Red');
            //  alert('please enter something');
            isValid = false;
        }
        else {
            $("#ddlMolecules").css('border-color', 'lightgrey');
        }
        if (model.BrandCompanyId == "") {
            $("#ddlCompaniess").css('border-color', 'Red');
            //  alert('please enter something');
            isValid = false;
        }
        else {
            $("#ddlCompaniess").css('border-color', 'lightgrey');
        }


        if (model.Active == "") {
            $("#ActiveStatus").css('border-color', 'Red');
            //  alert('please enter something');
            isValid = false;
        }
        else {
            $("#ActiveStatus").css('border-color', 'lightgrey');
        }
        // console.log(model.ID + ' its id');
        //alert(model.Type + ' its inputtype');
        //  console.log(model.Type);
        //   console.log(model.ActiveStatus + ' its active status');
        return isValid;
    }
    function ActiveDeactive(Id) {

        var ans = confirm("Are you sure you want to Active/Deactive this Record?");
        if (ans) {
            var id = { id: Id };
            var action = $("#Active").val();

            $.ajax({
                url: action,
                type: "POST",
                //async: true,
                data: JSON.stringify(id),
                contentType: "application/json;charset=utf-8",
                dataType: "json",
                success: function (result) {
                    if (result.redirectTo) {
                        alert('session expired');
                        window.location.href = $('#LogOut').val();
                    }
                    var s = ""; var btndel = "";
                    btndel = '#btnDel' + Id;
                    if (result == 'Activated') {
                        $(btndel).html("Deactivate");
                        s = "Y";
                    }
                    else if (result == 'DeActivated') {
                        $(btndel).html("Activate");
                        s = "N";
                    } else { }
                    var actionID = '#divActiveStatus' + Id;
                    //alert(actionID);
                    $(actionID).html(s);
                },
                error: function (xhr, ajaxOptions, thrownError) {
                    if (xhr.status == 401) {
                        alert("unauthorized");
                    }
                    alert("in error");

                }
            });
        }
    }
    //Function for clearing the textboxes
    function clearTextBox(Id) {
        //alert('in clear');
        //var v = ('#ddlActiveStatus' + Id).replace(/\s/g, '');
        //$(v).hide();
        //var actionID = ('#divActiveStatus' + Id).replace(/\s/g, '');
        //$(actionID).show();
        //var typeid = ('#divType' + Id).replace(/\s/g, '');
        //$(typeid).show();
        //var typeinputid = ('#inputType' + Id).replace(/\s/g, '');
        //$(typeinputid).hide();
        //var btnedit = ('#btnEdit').replace(/\s/g, '');
        //$(btnedit).show();
        var btnAdd = ('#btnAdd').replace(/\s/g, '');
        $(btnAdd).show();
        var btnupdate = ('#btnUpdate').replace(/\s/g, '');
        $(btnupdate).hide();
        //var btncancel = ('#btnCancel').replace(/\s/g, '');
        //$(btncancel).hide();
        //var btnActDec = ('#btnDel' + Id).replace(/\s/g, '');
        //$(btnActDec).show();
        $('#ID').val("");
        $('#txtBrandName').val("");
        $('#ddlMolecules').val("");
        $('#ddlCompaniess').val("");
        $('#ActiveStatus').val("");

        //$('#btnUpdate').hide();
        //$('#btnAdd').show();
        //$('#Type').css('border-color', 'lightgrey');
        //$('#ActiveStatus').css('border-color', 'lightgrey');

    }

    //Valdidation using jquery
    function validate() {
        var isValid = true;
        if ($('#txtBrandName').val().trim() == "") {
            $('#txtBrandName').css('border-color', 'Red');
            isValid = false;
        }
        else {
            $('#txtBrandName').css('border-color', 'lightgrey');
        }
        if ($('#ddlMolecules').val().trim() == "") {
            $('#ddlMolecules').css('border-color', 'Red');
            isValid = false;
        }
        else {
            $('#ddlMolecules').css('border-color', 'lightgrey');
        }
        if ($('#ddlCompaniess').val().trim() == "") {
            $('#ddlCompaniess').css('border-color', 'Red');
            isValid = false;
        }
        else {
            $('#ddlCompaniess').css('border-color', 'lightgrey');
        }
        if ($('#ActiveStatus').val().trim() == "") {
            $('#ActiveStatus').css('border-color', 'Red');
            isValid = false;
        }
        else {
            $('#ActiveStatus').css('border-color', 'lightgrey');
        }
        return isValid;
    }
});