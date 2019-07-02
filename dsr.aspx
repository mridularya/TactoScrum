<%@ Page Language="C#" AutoEventWireup="true" CodeFile="dsr.aspx.cs" Inherits="scrum.dsr" %>

<!DOCTYPE html>

<html>
<head runat="server">
     <link rel="stylesheet" href="https://stackpath.bootstrapcdn.com/bootstrap/4.3.1/css/bootstrap.min.css" integrity="sha384-ggOyR0iXCbMQv3Xipma34MD+dH/1fQ784/j6cY/iJTQUOhcWr7x9JvoRxT2MZw1T" crossorigin="anonymous">    
     <link href="https://cdnjs.cloudflare.com/ajax/libs/jquery-footable/0.1.0/css/footable.min.css"  <script src="https://cdnjs.cloudflare.com/ajax/libs/materialize/1.0.0/js/materialize.min.js"></script>
<script type="text/javascript" src="http://ajax.googleapis.com/ajax/libs/jquery/1.8.3/jquery.min.js"></script>
<script type="text/javascript" src="https://cdnjs.cloudflare.com/ajax/libs/jquery-footable/0.1.0/js/footable.min.js"></script>
  <!-- Material Design Bootstrap -->
<link href="https://cdnjs.cloudflare.com/ajax/libs/mdbootstrap/4.8.2/css/mdb.min.css" rel="stylesheet">
    <!-- JQuery -->
<script type="text/javascript" src="https://cdnjs.cloudflare.com/ajax/libs/jquery/3.4.1/jquery.min.js"></script>
<!-- Bootstrap tooltips -->
<script type="text/javascript" src="https://cdnjs.cloudflare.com/ajax/libs/popper.js/1.14.4/umd/popper.min.js"></script>
<!-- Bootstrap core JavaScript -->
<script type="text/javascript" src="https://cdnjs.cloudflare.com/ajax/libs/twitter-bootstrap/4.3.1/js/bootstrap.min.js"></script>
<!-- MDB core JavaScript -->
<script type="text/javascript" src="https://cdnjs.cloudflare.com/ajax/libs/mdbootstrap/4.8.2/js/mdb.min.js"></script>
    
      <title>Specific Instructions</title>
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
</head>
<body style="background-color : #EEEEEE">
       <div class="jumbotron-fluid text-center" style="background-image: linear-gradient(to left, #233857, #0a4f6e, #00667d, #007e83, #299481); height:90px">
            <div class="row">
                <div>
             <img src="assets/agile_agile-02-512.png" alt="na" height="80px" style="margin-left:500px"/>
                    </div>
                <div>
            <h1 style="color:white;margin-top:20px">Specific Instructions</h1>
                    </div>
        </div>
            </div>
    <form id="form1" runat="server">
    <div class="row">
        <h3 class="col-4 allignment">Name :</h3>
          <asp:DropDownList ID="Dd1" runat="server" CssClass="form-control col-4 allignment" AutoPostBack="true">
                 
        </asp:DropDownList>
                </div>
        <div class="row">
             <h3 class="col-4 allignment">Reguarding :</h3>
          <asp:DropDownList ID="Dd2" runat="server" CssClass="form-control col-4 allignment" AutoPostBack="true">
                 
        </asp:DropDownList>
            </div>
        <div class="row">
              <h3 class="allignment col-4">Instructions :</h3>
        <asp:TextBox id="Ta1" TextMode="multiline" Columns="5" Rows="5" runat="server" CssClass="form-control col-4 allignment" />                 
             <br />         
        <br />
            </div>
        <div class="row">
        <asp:Button ID="Button1" runat="server"  CssClass="padding1 btn-primary" Text="Submit" OnClick="Button1_Click"/>
            <asp:Button ID="Button2" runat="server"  CssClass=" btn-primary" Text="Back" OnClick="Button2_Click"/>
        </div>
    </form>
</body>
</html>
