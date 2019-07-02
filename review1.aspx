<%@ Page Language="C#" AutoEventWireup="true" CodeFile="review1.aspx.cs" Inherits="scrum.review1" %>

<%@ Register Assembly="AjaxControlToolkit" Namespace="AjaxControlToolkit" TagPrefix="cc1" %>
<!DOCTYPE html>





<html>
<head runat="server">
    <title>Daily Review</title>

    <!--  jQuery -->
    <script type="text/javascript" src="https://code.jquery.com/jquery-1.11.3.min.js"></script>

    <!-- Isolated Version of Bootstrap, not needed if your site already uses Bootstrap -->
    <link rel="stylesheet" href="https://formden.com/static/cdn/bootstrap-iso.css" />

    <!-- Bootstrap Date-Picker Plugin -->
    <script type="text/javascript" src="https://cdnjs.cloudflare.com/ajax/libs/bootstrap-datepicker/1.4.1/js/bootstrap-datepicker.min.js"></script>
    <link rel="stylesheet" href="https://cdnjs.cloudflare.com/ajax/libs/bootstrap-datepicker/1.4.1/css/bootstrap-datepicker3.css" />
    <style>
        .padding {
            margin-left: 50px;
        }

        .padding1 {
            margin-left: 600px;
        }

        .shadow-textarea textarea.form-control::placeholder {
            font-weight: 300;
        }

        .shadow-textarea textarea.form-control {
            padding-left: 0.8rem;
        }

        .allignment {
            margin-left: 20px;
            margin-top: 20px;
            margin-bottom: 15px;
        }
        ::-webkit-scrollbar{
            display:none;
        }
    </style>
    <link rel="stylesheet" href="https://stackpath.bootstrapcdn.com/bootstrap/4.3.1/css/bootstrap.min.css" integrity="sha384-ggOyR0iXCbMQv3Xipma34MD+dH/1fQ784/j6cY/iJTQUOhcWr7x9JvoRxT2MZw1T" crossorigin="anonymous">
</head>

    <body style="background-color:#EEEEEE" class="shadow-lg">
       <div class="jumbotron-fluid text-center" style="background-image: linear-gradient(to left, #233857, #0a4f6e, #00667d, #007e83, #299481); height:90px">
            <div class="row">
                <div>
             <img src="assets/agile_agile-02-512.png" alt="na" height="80px" style="margin-left:500px"/>
                    </div>
                <div>
            <h1 style="color:white;margin-top:20px">Daily Review</h1>
                    </div>
        </div>
            </div>
    <br />
    <form id="form1" runat="server">
        <div>

            <asp:ScriptManager runat="server" ID="scriptManager"></asp:ScriptManager>
       
                    <div class="row">
                        <h3 class="col-4 allignment">Date :</h3>
                        <asp:TextBox runat="server" CssClass="form-control col-4 allignment" ID="date1" name="date" placeholder="MM/DD/YYY" type="text" AutoCompleteType="Disabled"></asp:TextBox>
                        <cc1:CalendarExtender ID="CalendarExtender1" Format="dd/MM/yyyy" TargetControlID="date1" runat="server" />
                    </div>

                   <%-- <div class="row">
                        <h3 class="col-4 allignment">Devloper :</h3>
                        <asp:DropDownList ID="Dd1" runat="server" CssClass="form-control col-4 allignment">
                        </asp:DropDownList>
                    </div>--%>
                    <div class="row">
                        <h3 class="col-4 allignment">Product :</h3>
                        <asp:DropDownList ID="Dd2" runat="server" CssClass="form-control col-4 allignment" OnSelectedIndexChanged="Dd2_SelectedIndexChanged" AutoPostBack="true" >
                       
                        </asp:DropDownList>
                    </div>
                    <div class="row">
                        <h3 class="col-4 allignment">feature :</h3>
                        <asp:DropDownList ID="Dd3" runat="server" CssClass="col-4 form-control allignment">
                        </asp:DropDownList>
                    </div>
                    <div class="row">
                        <h3 class="col-4 allignment">Brief Description of work done :</h3>
                        <asp:TextBox ID="Ta2" TextMode="multiline" Columns="5" Rows="5" runat="server" CssClass="form-control col-4 allignment" />
                    </div>

                    <div class="row">
                        <h3 class="col-4 allignment">Difficulties Faced :</h3>
                        <asp:TextBox ID="Ta3" TextMode="multiline" Columns="5" Rows="5" runat="server" CssClass="col-4 form-control allignment" />
                    </div>


                    <div class="row">
                        <h3 class="col-4 allignment">Status :</h3>
                        <asp:DropDownList ID="Dd4" runat="server" CssClass="col-4 form-control allignment">
                            <asp:ListItem Value="Done">Done</asp:ListItem>
                            <asp:ListItem Value="Doing">Doing</asp:ListItem>
                            <asp:ListItem Value="To-Do">To-Do</asp:ListItem>
                            <asp:ListItem Value="Pending">Pending</asp:ListItem>
                            <asp:ListItem Value="Pending For Approval">Pending For Approval</asp:ListItem>
                        </asp:DropDownList>
                    </div>


                    <br />
                    <br />
                    <div class="row">
                        <asp:Button ID="Button1" runat="server" CssClass="btn-primary padding1" Text="Submit" OnClick="Button1_Click" />
                    </div>
                    <br />
                    <br />
                </div>
    </form>
         <script>
           
             var date_input = $('input[id="date1"]');
             var date_input1 = $('input[id="date2"]');//our date input has the name "date"
             var container=$('.bootstrap-iso form').length>0 ? $('.bootstrap-iso form').parent() : "body";
             var options={
                 format: 'mm/dd/yyyy',
                 container: container,
                 todayHighlight: true,
                 autoclose: true,
             };
             date_input.datepicker(options);
             date_input1.datepicker(options);
             })</script>
</body>
</html>
