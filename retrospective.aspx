<%@ Page Language="C#" AutoEventWireup="true" Codefile="retrospective.aspx.cs" Inherits="scrum.WebForm5" %>
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
    <body style="background-color:#EEEEEE;" class="shadow-lg">
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
    <br />
        
    <form id="form1" runat="server">
    <asp:ScriptManager runat="server" ID="scriptManager" ></asp:ScriptManager>
        <div class="row">
           
        <h3 class="col-4 allignment">Devloper :</h3>
          <asp:DropDownList ID="Dd1" runat="server" CssClass="form-control col-4 allignment">
                 
        </asp:DropDownList>
                </div>
              <div class="row">
        <h3 class="col-4 allignment">Sprint :</h3>
          <asp:DropDownList ID="Dd2" runat="server" CssClass="form-control col-4 allignment">
                 
        </asp:DropDownList>
        </div>
        
          <div class="row">
         <h3 class="col-4 allignment">Start Date :</h3>

        <asp:TextBox  runat="server" CssClass="col-4 allignment form-control" id="date1" name="date" placeholder="MM/DD/YYY" type="text" AutoCompleteType="Disabled"></asp:TextBox>
        <cc1:CalendarExtender ID="CalendarExtender1"  TargetControlID="date1" runat="server" />
        </div>
            <div class="row">
                               <h3 class="col-4 allignment">deadline : </h3>
        <asp:TextBox runat="server" CssClass="col-4 allignment form-control" id="date2" name="date" placeholder="MM/DD/YYY" type="text" AutoCompleteType="Disabled"></asp:TextBox>
           <cc1:CalendarExtender ID="CalendarExtender2" Format="dd/mm/yyyy"  TargetControlID="date2" runat="server" />    
                </div>
        <div class="row">
        <h3 class="col-4 allignment">Sprint Status</h3>
               
          <asp:DropDownList ID="Dd3" runat="server" CssClass="form-control col-4 allignment">
                 <asp:ListItem Value="Success">Completed</asp:ListItem>
                 <asp:ListItem Value="Cancel">Cancelled</asp:ListItem>
        </asp:DropDownList>
                </div>
             <div class="row"> 
        <h3 class="col-4 allignment">Remarks</h3>
        <asp:TextBox id="Ta1" TextMode="multiline" Columns="5" Rows="5" runat="server" CssClass="col-4 allignment form-control" />                 
        </div>
          <br />         
        <br />
        <div class="row">
        <asp:Button ID="Button1" runat="server"  CssClass="btn-primary padding1" Text="Submit"  />

        </div>
                 <br />         
        <br />
        <br />
        <br />

    </form>
</body>
</html>
