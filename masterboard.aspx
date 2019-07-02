<%@ Page Language="C#" AutoEventWireup="true" CodeFile="masterboard.aspx.cs" Inherits="scrum.masterboard" %>

<%@ Register Assembly="AjaxControlToolkit" Namespace="AjaxControlToolkit" TagPrefix="cc1" %>
<!DOCTYPE html>





<html>
<head runat="server">
    <!-- Font Awesome -->
<link rel="stylesheet" href="https://use.fontawesome.com/releases/v5.8.2/css/all.css">
<!-- Bootstrap core CSS -->
<link href="https://cdnjs.cloudflare.com/ajax/libs/twitter-bootstrap/4.3.1/css/bootstrap.min.css" rel="stylesheet">
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
    <style>

        img{
            display: block;
  margin-left: auto;
  margin-right: auto;
  
        }
        ::-webkit-scrollbar{
            display:none;
        }
    </style>
   <link rel="stylesheet" href="https://stackpath.bootstrapcdn.com/bootstrap/4.3.1/css/bootstrap.min.css" integrity="sha384-ggOyR0iXCbMQv3Xipma34MD+dH/1fQ784/j6cY/iJTQUOhcWr7x9JvoRxT2MZw1T" crossorigin="anonymous">
<script src="//maxcdn.bootstrapcdn.com/bootstrap/4.0.0/js/bootstrap.min.js"></script>
<script src="//cdnjs.cloudflare.com/ajax/libs/jquery/3.2.1/jquery.min.js"></script>
    <title>Master DashBoard</title>
</head>
<body style="background-color:#EEEEEE" class="shadow-lg">
       <div class="jumbotron-fluid text-center" style="background-image: linear-gradient(to left, #233857, #0a4f6e, #00667d, #007e83, #299481); height:90px">
            <div class="row">
                <div>
             <img src="assets/agile_agile-02-512.png" alt="na" height="80px" style="margin-left:500px"/>
                    </div>
                <div>
            <h1 style="color:white;margin-top:20px">Master DashBoard</h1>
                    </div>
        </div>
            </div>
    <br />
        
    <form id="form1" runat="server">
    <div class="container">
	<div class="row">
		<div class="col-sm-3">
		    <!--Card-->
<div class="card">

    <!--Card image-->
    <img class="img-fluid" src="assets/sprint.png" alt="Card image cap" width="120px" height="120px">

    <!--Card content-->
    <div class="card-body">
        <!--Title-->
        <h5 class="card-title">Edit Sprint</h5>
        <!--Text-->
        <p class="card-text"></p>
        <asp:Button ID="Button6" CssClass="btn rounded-0 btn-primary" Width="200px" Height="50px" runat="server" Text="Edit" OnClick="Button6_Click"/>
            </div>
    </div>
</div>
        <div class="col-sm-3">
		    <!--Card-->
<div class="card">

    <!--Card image-->
    <img class="img-fluid" src="assets/bklg.png" alt="Card image cap" width="120px" height="120px">

    <!--Card content-->
    <div class="card-body">
        <!--Title-->
        <h5 class="card-title">Edit Product Backlog</h5>
        <!--Text-->
        <p class="card-text"></p>
        <asp:Button ID="Button5" CssClass=" btn-primary btn rounded-0 waves-effect " Width="200px" Height="50px" runat="server" Text="Edit" OnClick="Button5_Click"/>
    </div>
    </div>
</div>
        <div class="col-sm-3">
		    <!--Card-->
<div class="card">

    <!--Card image-->
    <img class="img-fluid" src="assets/businessman.png" alt="Card image cap" width="120px" height="120px">

    <!--Card content-->
    <div class="card-body">
        <!--Title-->
        <h5 class="card-title">Create Roles</h5>
        <!--Text-->
        <p class="card-text"></p>
        <asp:Button ID="Button4" CssClass="btn rounded-0 btn-primary waves-effect" Width="200px" Height="50px" runat="server" Text="Create" OnClick="Button4_Click"/>
    </div>
    </div>

</div>
          <div class="col-sm-3">
		    <!--Card-->
<div class="card">

    <!--Card image-->
    <img class="img-fluid" src="assets/g.png" alt="Card image cap" width="120px" height="120px">

    <!--Card content-->
    <div class="card-body">
        <!--Title-->
        <h5 class="card-title">specific Instructions</h5>
        <!--Text-->
        <p class="card-text"></p>
        <asp:Button ID="Button3" CssClass="btn rounded-0 btn-primary" Width="200px" Height="50px" runat="server" Text="Create" OnClick="Button3_Click"/>
    </div>
    
    </div>

</div>
       
           
		
        </div>
        <br />
         <div class="row">
        <div class="col-sm-3">
		    <!--Card-->
<div class="card">

    <!--Card image-->
    <img class="img-fluid" src="assets/dg.png" alt="Card image cap" width="120px" height="120px">

    <!--Card content-->
    <div class="card-body">
        <!--Title-->
        <h4 class="card-title">Clear Notes</h4>
        <!--Text-->
        <p class="card-text"></p>
          <asp:Button ID="Button1" CssClass="btn rounded-0 btn-primary" Width="200px" Height="50px" runat="server" Text="Clear" OnClick="Button1_Click"/>
    </div>
    </div>
            </div>
             <div class="col-sm-3">
		    <!--Card-->
<div class="card">

    <!--Card image-->
    <img class="img-fluid" src="assets/dg.png" alt="Card image cap" width="120px" height="120px">

    <!--Card content-->
    <div class="card-body">
        <!--Title-->
        <h5 class="card-title">Clear Retropecitve</h5>
        <!--Text-->
        <p class="card-text"></p>
          <asp:Button ID="Button7" CssClass="btn rounded-0 btn-primary" Width="200px" Height="50px" runat="server" Text="Clear" OnClick="Button7_Click"/>
    </div>
    </div>


</div>
                 <div class="col-sm-3">
		    <!--Card-->
<div class="card">

    <!--Card image-->
    <img class="img-fluid" src="assets/dg.png" alt="Card image cap" width="120px" height="120px">

    <!--Card content-->
    <div class="card-body">
        <!--Title-->
        <h5 class="card-title">Clear Roles</h5>
        <!--Text-->
        <p class="card-text"></p>
          <asp:Button ID="Button8" CssClass="btn rounded-0 btn-primary" Width="200px" Height="50px" runat="server" Text="Clear" OnClick="Button8_Click"/>
    </div>
    </div>


</div>
                 <div class="col-sm-3">
		    <!--Card-->
<div class="card">

    <!--Card image-->
    <img class="img-fluid" src="assets/dg.png" alt="Card image cap" width="120px" height="120px">

    <!--Card content-->
    <div class="card-body">
        <!--Title-->
        <h5 class="card-title">clear Reviews</h5>
        <!--Text-->
        <p class="card-text"></p>
          <asp:Button ID="Button9" CssClass="btn rounded-0 btn-primary" Width="200px" Height="50px" runat="server" Text="Clear" OnClick="Button9_Click"/>
    </div>
    </div>


</div>
             </div>
        <br />
          <div class="row">
        <div class="col-sm-3">
		    <!--Card-->
<div class="card">

    <!--Card image-->
    <img class="img-fluid" src="assets/dg.png" alt="Card image cap" width="120px" height="120px">

    <!--Card content-->
    <div class="card-body">
        <!--Title-->
        <h4 class="card-title">Clear Tasks</h4>
        <!--Text-->
        <p class="card-text"></p>
          <asp:Button ID="Button10" CssClass="btn rounded-0 btn-primary" Width="200px" Height="50px" runat="server" Text="Create" OnClick="Button10_Click"/>
    </div>
    </div>
            </div>

              <div class="col-sm-3">
		    <!--Card-->
<div class="card">

    <!--Card image-->
    <img class="img-fluid" src="assets/dg.png" alt="Card image cap" width="120px" height="120px">

    <!--Card content-->
    <div class="card-body">
        <!--Title-->
        <h4 class="card-title">Clear Sprints</h4>
        <!--Text-->
        <p class="card-text"></p>
          <asp:Button ID="Button11" CssClass="btn rounded-0 btn-primary" Width="200px" Height="50px" runat="server" Text="Clear" OnClick="Button11_Click"/>
    </div>
    </div>
            </div>
              <div class="col-sm-3">
		    <!--Card-->
<div class="card">

    <!--Card image-->
    <img class="img-fluid" src="assets/dg.png" alt="Card image cap" width="120px" height="120px">

    <!--Card content-->
    <div class="card-body">
        <!--Title-->
        <h4 class="card-title">Clear P.B</h4>
        <!--Text-->
        <p class="card-text"></p>
          <asp:Button ID="Button12" CssClass="btn rounded-0 btn-primary" Width="200px" Height="50px" runat="server" Text="Clear" OnClick="Button12_Click"/>
    </div>
    </div>
            </div>
              <div class="col-sm-3">
		    <!--Card-->
<div class="card">

    <!--Card image-->
    <img class="img-fluid" src="assets/dg.png" alt="Card image cap" width="120px" height="120px">

    <!--Card content-->
    <div class="card-body">
        <!--Title-->
        <h5 class="card-title">Clear specific Instructions </h5>
        <!--Text-->
        <p class="card-text"></p>
          <asp:Button ID="Button2" CssClass="btn rounded-0 btn-primary" Width="200px" Height="50px" runat="server" Text="Clear" OnClick="Button2_Click1"/>
    </div>
    </div>
            </div>
              </div>
        <div class="row">
              <div class="col-sm-3">
		    <!--Card-->
<div class="card">

    <!--Card image-->
    <img class="img-fluid" src="assets/unauth.png" alt="Card image cap" width="120px" height="120px">

    <!--Card content-->
    <div class="card-body">
        <!--Title-->
        <h5 class="card-title">Authorisation Master </h5>
        <!--Text-->
        <p class="card-text"></p>
          <asp:Button ID="Button13" CssClass="btn rounded-0 btn-primary" Width="200px" Height="50px" runat="server" Text="Clear" OnClick="Button13_Click"/>
    </div>
    </div>
            </div>
              <div class="col-sm-3">
		    <!--Card-->
<div class="card">

    <!--Card image-->
    <img class="img-fluid" src="assets/auth.png" alt="Card image cap" width="120px" height="120px">

    <!--Card content-->
    <div class="card-body">
        <!--Title-->
        <h5 class="card-title">Authorisation</h5>
        <!--Text-->
        <p class="card-text"></p>
          <asp:Button ID="Button14" CssClass="btn rounded-0 btn-primary" Width="200px" Height="50px" runat="server" Text="Authorise" OnClick="Button14_Click"/>
    </div>
    </div>
            </div>
            
            



        </div>


        <br />
        <asp:Button Text="Back" runat="server" CssClass="btn btn-primary" OnClick="Unnamed_Click" />

               
        
    </form>
</body>
</html>

