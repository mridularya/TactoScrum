<%@ Page Language="C#" AutoEventWireup="true" CodeFile="retro.aspx.cs" Inherits="scrum.retro" %>
<%@ Register Assembly="AjaxControlToolkit" Namespace="AjaxControlToolkit" TagPrefix="cc1" %>


<!DOCTYPE html>




<html>
<head runat="server">
   
            
    <script type="text/javascript" src="http://ajax.googleapis.com/ajax/libs/jquery/1.8.3/jquery.min.js"></script>
<script type="text/javascript" src="https://cdnjs.cloudflare.com/ajax/libs/jquery-footable/0.1.0/js/footable.min.js"></script>

    <link rel="stylesheet" href="https://stackpath.bootstrapcdn.com/bootstrap/4.3.1/css/bootstrap.min.css" integrity="sha384-ggOyR0iXCbMQv3Xipma34MD+dH/1fQ784/j6cY/iJTQUOhcWr7x9JvoRxT2MZw1T" crossorigin="anonymous">
    <style>
        .padding1
        {
          margin-left : 500px;  
        }

         .allignment{
     margin-left:20px;
     margin-top:20px;
     margin-bottom:15px;
  }



    </style>

    <title>Retrospective</title>
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
            <h1 style="color:white;margin-top:20px">Retrospective</h1>
                    </div>
        </div>
            </div>
              <div class="row">
        <h3 class="col-4 allignment">Sprint :</h3>
          <asp:DropDownList ID="sprint" runat="server" CssClass="form-control col-4 allignment">
                 
        </asp:DropDownList>
        </div>
        
          <div class="row">
         <h3 class="col-4 allignment">Start Date :</h3>

        <asp:TextBox  runat="server" CssClass="col-4 allignment form-control" id="startdate" name="date" placeholder="DD/MM/YYYY" type="text" AutoCompleteType="Disabled"></asp:TextBox>
        <cc1:CalendarExtender ID="CalendarExtender1" Format="dd/MM/yyyy" TargetControlID="startdate" runat="server" />
        </div>
            <div class="row">
                               <h3 class="col-4 allignment">End Date : </h3>
        <asp:TextBox runat="server" CssClass="col-4 allignment form-control" id="enddate" name="date" placeholder="DD/MM/YYYY" type="text" AutoCompleteType="Disabled"></asp:TextBox>
           <cc1:CalendarExtender ID="CalendarExtender2" Format="dd/MM/yyyy"  TargetControlID="enddate" runat="server" />    
                </div>
        <div class="row">
        <h3 class="col-4 allignment">Sprint Status</h3>
               
          <asp:DropDownList ID="status" runat="server" CssClass="form-control col-4 allignment">
                 <asp:ListItem Value="completed">Completed</asp:ListItem>
                 <asp:ListItem Value="Cancelled">Cancelled</asp:ListItem>
        </asp:DropDownList>
                </div>
             <div class="row"> 
        <h3 class="col-4 allignment">Remarks</h3>
        <asp:TextBox id="Remarks" TextMode="multiline" Columns="5" Rows="5" runat="server" CssClass="col-4 allignment form-control" />                 
        </div>
          <br />         
        <br />
        <div class="row">
        <asp:Button ID="submit" runat="server"  CssClass="btn-primary padding1" Text="Submit" OnClick="Button1_Click"  />

        </div>
                 <br />         
        <br />
        <br />
        <br />

    </form>
</body>
</html>
