<%@ Page Language="C#" AutoEventWireup="true" CodeFile="auth.aspx.cs" Inherits="scrum.WebForm6" %>

<!DOCTYPE html>

<html>
<head runat="server">
    <title>Authorisation</title>

       <!--  jQuery -->
<script type="text/javascript" src="https://code.jquery.com/jquery-1.11.3.min.js"></script>

<!-- Isolated Version of Bootstrap, not needed if your site already uses Bootstrap -->
<link rel="stylesheet" href="https://formden.com/static/cdn/bootstrap-iso.css" />

<!-- Bootstrap Date-Picker Plugin -->
<script type="text/javascript" src="https://cdnjs.cloudflare.com/ajax/libs/bootstrap-datepicker/1.4.1/js/bootstrap-datepicker.min.js"></script>
<link rel="stylesheet" href="https://cdnjs.cloudflare.com/ajax/libs/bootstrap-datepicker/1.4.1/css/bootstrap-datepicker3.css"/>
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


    </style>
    
    <link rel="stylesheet" href="https://stackpath.bootstrapcdn.com/bootstrap/4.3.1/css/bootstrap.min.css" integrity="sha384-ggOyR0iXCbMQv3Xipma34MD+dH/1fQ784/j6cY/iJTQUOhcWr7x9JvoRxT2MZw1T" crossorigin="anonymous">    
</head>
<body style="background-color: #EEEEEE">
    <form id="form1" runat="server">
        <div class="jumbotron-fluid text-center" style="background-image: linear-gradient(to left, #233857, #0a4f6e, #00667d, #007e83, #299481);; height:90px">
            <div class="row">
                <div>
             <img src="assets/agile_agile-02-512.png" alt="na" height="80px" style="margin-left:500px"/>
                    </div>
                <div>
            <h1 style="color:white;margin-top:20px">Authorisation</h1>
                    </div>
        </div>
            </div>
            <div class="row">
        <h3 class="allignment col-4">Role :</h3>
          <asp:DropDownList ID="dd2" runat="server" CssClass="form-control col-4 allignment">
              <asp:ListItem Value="Developer">Developer</asp:ListItem>
              <asp:ListItem Value="Product Master">Product Master</asp:ListItem>
               <asp:ListItem Value="Scrum Master">Scrum Master</asp:ListItem>
                 
        </asp:DropDownList>
                </div>
         <div class="row">
                                <h3 class="col-4 allignment">Name</h3>
                                
                                <asp:DropDownList ID="Dd1" runat="server" CssClass="col-4 form-control allignment" AutoPostBack="true" OnSelectedIndexChanged="Dd1_SelectedIndexChanged">

                                </asp:DropDownList>
                            </div>
            <div class="row">
               
         <h3 class="allignment col-4">Username :</h3>
       <asp:TextBox runat="server" CssClass="col-4 form-control allignment" id="tb1"  type="text" AutoCompleteType="Disabled"></asp:TextBox>   
                    </div>
           
            <div class="row">
                               <h3 class="allignment col-4">Password : </h3>
        <asp:TextBox runat="server" CssClass="col-4 form-control allignment" id="tb2"  type="text" AutoCompleteType="Disabled"></asp:TextBox>   
        </div>
            
          <br />
          <br />
        <div class="row">
        <asp:Button ID="Button1" runat="server"  CssClass="btn-primary padding1" Text="Submit" OnClick="Button1_Click"   />
        </div>
        <br />
        <br />
    </div>
    </form>
       
</body>
</html>
