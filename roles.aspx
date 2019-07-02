<%@ Page Language="C#" AutoEventWireup="true" CodeFile="roles.aspx.cs" Inherits="roles" %>

<!DOCTYPE html>

<html>
<head runat="server">
    <style>
       .padding{
           margin-left:20px;
       }
        .padding1 {
            margin-left: 500px;
        }
       ::-webkit-scrollbar {
display: none;
}
    </style>
    <!-- Compiled and minified CSS -->
    <link rel="stylesheet" href="https://cdnjs.cloudflare.com/ajax/libs/materialize/1.0.0/css/materialize.min.css">

    <!-- Compiled and minified JavaScript -->
    <script src="https://cdnjs.cloudflare.com/ajax/libs/materialize/1.0.0/js/materialize.min.js"></script>
            
    <script src="https://code.jquery.com/jquery-3.3.1.slim.min.js" integrity="sha384-q8i/X+965DzO0rT7abK41JStQIAqVgRVzpbzo5smXKp4YfRvH+8abtTE1Pi6jizo" crossorigin="anonymous"></script>
<script src="https://cdnjs.cloudflare.com/ajax/libs/popper.js/1.14.7/umd/popper.min.js" integrity="sha384-UO2eT0CpHqdSJQ6hJty5KVphtPhzWj9WO1clHTMGa3JDZwrnQq4sF86dIHNDz0W1" crossorigin="anonymous"></script>
<script src="https://stackpath.bootstrapcdn.com/bootstrap/4.3.1/js/bootstrap.min.js" integrity="sha384-JjSmVgyd0p3pXB1rRibZUAYoIIy6OrQ6VrjIEaFf/nJGzIxFDsf4x0xIM+B07jRM" crossorigin="anonymous"></script>
<link rel="stylesheet" href="https://stackpath.bootstrapcdn.com/bootstrap/4.3.1/css/bootstrap.min.css" integrity="sha384-ggOyR0iXCbMQv3Xipma34MD+dH/1fQ784/j6cY/iJTQUOhcWr7x9JvoRxT2MZw1T" crossorigin="anonymous">    
    <title>Create Roles</title>
</head>
<body  style="background-color:#EEEEEE">
            <div class ="jumbotron text-center rounded-0 "  style="background-image: linear-gradient(to left, #233857, #0a4f6e, #00667d, #007e83, #299481);height:90px">
    <h1>Create Role</h1>
        </div>
   
    <form id="form1" runat="server" method="post" class="col s12">
   
         <div class="row">
             <div class="col-3">
         <h3>Full Name :</h3>
                 </div>
             <div class="col-9">
        <asp:TextBox ID="tb1" runat="server" CssClass="validate" AutoCompleteType="Disabled" style="width:100%;align-content:center;"></asp:TextBox>
         </div>
             </div>
        <br />
        <div class="row">
        <div class="col-3">
              <h3>E-mail Address :</h3>
            </div>
        <div class="col-9">
            <asp:TextBox ID="tb2" runat="server" CssClass="validate" AutoCompleteType="Disabled" style="width:100%;align-content:center;"></asp:TextBox>
        </div>
            </div>
            <asp:RegularExpressionValidator ID="regexEmailValid" runat="server" ValidationExpression="\w+([-+.]\w+)*@\w+([-.]\w+)*\.\w+([-.]\w+)*" ControlToValidate="tb2" ErrorMessage="Not a valid Email"></asp:RegularExpressionValidator>
        <div class="row">
            <div class="col-3">
        <h3>Mobile Number : </h3>
                </div>
            <div class="col-9">
        <asp:TextBox ID="tb3" runat="server" CssClass="validate" AutoCompleteType="Disabled" style="width:100%;align-content:center;"></asp:TextBox>
         </div>
            </div>
            <asp:RegularExpressionValidator ID="RegularExpressionValidator1" runat="server" ValidationExpression="^(?:(?:\+|0{0,2})91(\s*[\-]\s*)?|[0]?)?[789]\d{9}$" ControlToValidate="tb3" ErrorMessage="Not a mobile number"></asp:RegularExpressionValidator>
       <div class="row">
           <div class="col-3">
         <h3>Select Role :</h3>
               </div>
               <div class="col-9">
        <asp:DropDownList ID="dd2" runat="server" CssClass="col-sm-4 form-control padding">
                  <asp:ListItem Value="Product Master">Product Master</asp:ListItem>
                  <asp:ListItem Value="Scrum Master">Scrum Master</asp:ListItem>
                  <asp:ListItem Value="Developer">Developer</asp:ListItem>
        </asp:DropDownList>
        </div>
           </div>
        <br />
        <asp:Button ID="Button1" runat="server"  CssClass="btn-primary" Text="Submit" OnClick="Button1_Click" />
            <br />
        <br />

            <asp:Button ID="Button2" runat="server"  CssClass="btn-primary" Text="Back" OnClick="Button2_Click" />
        <br />
        <br />
    </form>
</body>
</html>
