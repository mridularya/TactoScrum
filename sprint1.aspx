
<%@ Page Language="C#" AutoEventWireup="true" CodeFile="sprint1.aspx.cs" Inherits="scrum.sprint1" %>
<%@ Register Assembly="AjaxControlToolkit" Namespace="AjaxControlToolkit" TagPrefix="cc1" %>

<!DOCTYPE html>

<html>
<head runat="server">
    <title>Sprint Backlog</title>

<!-- Isolated Version of Bootstrap, not needed if your site already uses Bootstrap -->
<link rel="stylesheet" href="https://formden.com/static/cdn/bootstrap-iso.css" />

<!-- Bootstrap Date-Picker Plugin -->
<script type="text/javascript" src="https://cdnjs.cloudflare.com/ajax/libs/bootstrap-datepicker/1.4.1/js/bootstrap-datepicker.min.js"></script>
<link rel="stylesheet" href="https://cdnjs.cloudflare.com/ajax/libs/bootstrap-datepicker/1.4.1/css/bootstrap-datepicker3.css" />
<style>
       .padding{
           margin-left:50px;
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

  .allignment{
     margin-left:20px;
     margin-top:20px;
     margin-bottom:15px;
  }

  ::-webkit-scrollbar{
      display:none;
  }


    </style>
    <%-- <link rel="stylesheet" href="https://cdnjs.cloudflare.com/ajax/libs/materialize/1.0.0/css/materialize.min.css">--%>

    <!-- Compiled and minified JavaScript -->
   <%-- <script src="https://cdnjs.cloudflare.com/ajax/libs/materialize/1.0.0/js/materialize.min.js"></script>
    <title></title>--%>
    <link rel="stylesheet" href="https://stackpath.bootstrapcdn.com/bootstrap/4.3.1/css/bootstrap.min.css" integrity="sha384-ggOyR0iXCbMQv3Xipma34MD+dH/1fQ784/j6cY/iJTQUOhcWr7x9JvoRxT2MZw1T" crossorigin="anonymous">
</head>
<body style="background-color:#EEEEEE">
    <form id="form1" runat="server">
   

        <asp:ScriptManager runat="server" ID="scriptManager" ></asp:ScriptManager>
        <div class="jumbotron-fluid text-center" style="background-image: linear-gradient(to left, #233857, #0a4f6e, #00667d, #007e83, #299481); height:90px">
            <div class="row">
                <div>
             <img src="assets/agile_agile-02-512.png" alt="na" height="80px" style="margin-left:500px"/>
                    </div>
                <div>
            <h1 style="color:white;margin-top:20px">Sprint Entry</h1>
                    </div>
        </div>
            </div>
            <div class="row">
         <h3 class="allignment col-4">Backlog :</h3>
        <asp:DropDownList ID="Dd2" runat="server" CssClass="form-control allignment col-4" OnSelectedIndexChanged="Dd2_SelectedIndexChanged">
                 
        </asp:DropDownList>
                </div>
         <div class="row">
                               <h3 class="allignment col-4">Sprint Name : </h3>
        <asp:TextBox runat="server" CssClass="form-control col-4 allignment" id="Tbx" name="date" placeholder="Sprint Name" type="text" AutoCompleteType="Disabled"></asp:TextBox>  
             </div>
          <div class="row">
         <h3 class="allignment col-4">Start Date :</h3>

        <asp:TextBox  runat="server" CssClass="form-control col-4 allignment" id="date1" name="date" placeholder="DD/MM/YYYY" type="text" AutoCompleteType="Disabled"></asp:TextBox>
        <cc1:CalendarExtender ID="CalendarExtender1" Format="dd/MM/yyyy" TargetControlID="date1" runat="server" />
        </div>
            <div class="row">
                               <h3 class="allignment col-4">deadline : </h3>
        <asp:TextBox runat="server" CssClass="form-control col-4 allignment" id="date2" name="date" placeholder="DD/MM/YYYY" type="text" AutoCompleteType="Disabled"></asp:TextBox>
           <cc1:CalendarExtender ID="CalendarExtender2" Format="dd/MM/yyyy"  TargetControlID="date2" runat="server" />     
        </div>
             <div class="row">
                    <h3 class="allignment col-4">Priority (1-5) :</h3>
                
        <asp:DropDownList ID="Dd4" runat="server" CssClass="form-control  col-4 allignment">
                  <asp:ListItem Value="1">1</asp:ListItem>
                  <asp:ListItem Value="2">2</asp:ListItem>
                  <asp:ListItem Value="3">3</asp:ListItem>
                  <asp:ListItem Value="4">4</asp:ListItem>
                  <asp:ListItem Value="5">5</asp:ListItem>
        </asp:DropDownList>
                    </div>

          <div class="row">
        <h3 class="allignment col-4">Remarks</h3>
        <asp:TextBox id="Ta1" TextMode="multiline" Columns="5" Rows="5" runat="server" CssClass="form-control col-4 allignment" />                 
        </div>
        <br />         
        <br />
        <div class="row">
        <asp:Button ID="Button1" runat="server"  CssClass="padding1 btn-primary" Text="Submit"  OnClick="Button1_Click" />
        </div>
        <br /> 
        <br />
    </form>
       
</body>
</html>