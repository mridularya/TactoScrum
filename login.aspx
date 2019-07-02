<%@ Page Language="C#" AutoEventWireup="true" CodeFile="login.aspx.cs" Inherits="scrum.WebForm8" %>

<!DOCTYPE html>


<html>
<head runat="server">
    <!-- Font Awesome -->
    <link rel="stylesheet" href="https://use.fontawesome.com/releases/v5.8.2/css/all.css">
    <!-- Bootstrap core CSS -->
    <link href="https://cdnjs.cloudflare.com/ajax/libs/twitter-bootstrap/4.3.1/css/bootstrap.min.css" rel="stylesheet">
    <!-- Material Design Bootstrap -->
    <link href="https://cdnjs.cloudflare.com/ajax/libs/mdbootstrap/4.8.2/css/mdb.min.css" rel="stylesheet">
    <title>Login</title>
    <style>
        .allignment {
            margin-top: 400px;
        }

        .imgalignment {
            margin-top: 200px;
        }

        .align {
            margin-left: 10px;
        } 
      
        
                ::-webkit-scrollbar{
      display:none;
  }               

     
    </style>
</head>
<body style="background-image: linear-gradient(to left, #233857, #2d4567, #375278, #426089, #4c6e9b);">
    <form id="form1" runat="server">
        <div class="jumbotron-fluid text-center" style="background-image: linear-gradient(to left, #233857, #2d4567, #375278, #426089, #4c6e9b);; height:90px">
            <div class="row">
                <div>
             <img src="assets/agile_agile-02-512.png" alt="na" height="80px" style="margin-left:500px"/>
                    </div>
                <div>
            <h1 style="color:white;margin-top:20px">TactoScrum</h1>
                    </div>
        </div>
            </div>
        <div class="card container card-body mt-lg-5" style="width: 400px">
            <h5 class="text-center">Sign in</h5>
            <div class="md-form">
                <i class="fas fa-address-card prefix grey-text"></i>
                <asp:TextBox runat="server" AutoCompleteType="Disabled" ID="tb1" CssClass="form-control validate"></asp:TextBox>
                                                      
                <label data-error="wrong" data-success="right" for="defaultForm-email">Your Name</label>
            </div>

            <div class="md-form">
                <i class="fas fa-lock prefix grey-text"></i>
                <asp:TextBox runat="server" AutoCompleteType="Disabled" ID="tb2" CssClass="form-control validate"></asp:TextBox>

                <label data-error="wrong" data-success="right" for="defaultForm-pass">Your password</label>
            </div>
            <div class="col-lg-12">
                <asp:Button runat="server" Class=" col-lg-12" CssClass="btn btn-cyan"  style="border-color: #512DA8; color: #ffffff" ID="btn1" Text="Sign In" OnClick="btn1_Click" />
            </div>



        </div>

    </form>
</body>
<!-- JQuery -->
<script type="text/javascript" src="https://cdnjs.cloudflare.com/ajax/libs/jquery/3.4.1/jquery.min.js"></script>
<!-- Bootstrap tooltips -->
<script type="text/javascript" src="https://cdnjs.cloudflare.com/ajax/libs/popper.js/1.14.4/umd/popper.min.js"></script>
<!-- Bootstrap core JavaScript -->
<script type="text/javascript" src="https://cdnjs.cloudflare.com/ajax/libs/twitter-bootstrap/4.3.1/js/bootstrap.min.js"></script>
<!-- MDB core JavaScript -->
<script type="text/javascript" src="https://cdnjs.cloudflare.com/ajax/libs/mdbootstrap/4.8.2/js/mdb.min.js"></script>
</html>
