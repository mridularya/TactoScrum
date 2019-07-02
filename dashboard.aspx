<%@ Page Language="C#" AutoEventWireup="true" CodeFile="dashboard.aspx.cs" Inherits="scrum.dashboard" %>
<%@ Register Assembly="AjaxControlToolkit" Namespace="AjaxControlToolkit" TagPrefix="cc1" %>
<!DOCTYPE html>
<script runat="server">

   
</script>


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
    <title>DashBoard</title>
</head>
<body style="background-color:#EEEEEE" class="shadow-lg">
       <div class="jumbotron-fluid text-center" style="background-image: linear-gradient(to left, #233857, #0a4f6e, #00667d, #007e83, #299481);height:90px">
            <div class="row">
                <div>
             <img src="assets/agile_agile-02-512.png" alt="na" height="80px" style="margin-left:500px"/>
                    </div>
                <div>
            <h1 style="color:white;margin-top:20px">DashBoard</h1>
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
    <img class="img-fluid" src="assets/cb.png" alt="Card image cap" width="120px" height="120px" >

    <!--Card content-->
    <div class="card-body">
        <!--Title-->
     <h5 class="card-title text-center">Product Backlog</h5>
        <!--Text-->
        <p class="card-text"></p>
        <asp:Button ID="pbbutton" CssClass="btn btn-primary waves-effect6" Width="200px" Height="50px" runat="server" Text="Create" OnClick="pbbutton_Click"/>
            </div>
    </div>
</div>
        <div class="col-sm-3">
		    <!--Card-->
<div class="card">

    <!--Card image-->
    <img class="img-fluid" src="assets/sicon.png" alt="Card image cap" width="120px" height="120px" style="margin-top:13px">

    <!--Card content-->
    <div class="card-body">
        <!--Title-->
        <h5 class="card-title text-center">Sprint</h5>
        <!--Text-->
        <p class="card-text"></p>
        <asp:Button ID="sprintbtn" CssClass=" btn-primary btn waves-effect " Width="200px" Height="50px" runat="server" Text="create" OnClick="sprintbtn_Click"/>
    </div>
    </div>
</div>
        <div class="col-sm-3">
		    <!--Card-->
<div class="card">

    <!--Card image-->
    <img class="img-fluid" src="assets/tk.png" alt="Card image cap" width="120px" height="120px">

    <!--Card content-->
    <div class="card-body">
        <!--Title-->
        <h5 class="card-title text-center">Tasks</h5>
        <!--Text-->
        <p class="card-text"></p>
        <asp:Button ID="taskbtn" CssClass="btn btn-primary waves-effect" Width="200px" Height="50px" runat="server" Text="Create" OnClick="taskbtn_Click"/>
    </div>
    </div>

</div>
       
           
		<div class="col-sm-3"  >

		    <!--Card-->
<div class="card">

    <!--Card image-->
    <img class="img-fluid" src="assets/rs.png" alt="Card image cap" width="100px" height="100px" style="margin-top:20px">
   
    <!--Card content-->
    <div class="card-body">
        <!--Title-->
        <h5 class="card-title text-center">Daily Review</h5>
        <!--Text-->
        <p class="card-text"></p>
        <asp:Button ID="dailyrbtn" CssClass="btn btn-primary" Width="200px" Height="50px" runat="server" Text="GO" OnClick="dailyrbtn_Click"/>
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
    <img class="img-fluid" src="assets/businessman.png" alt="Card image cap" width="100px" height="100px" style="margin-top:19px">

    <!--Card content-->
    <div class="card-body">
        <!--Title-->
        <h5 class="card-title text-center">Users</h5>
        <!--Text-->
        <p class="card-text"></p>
        <asp:Button ID="userbtn" CssClass="btn btn-primary" Width="200px" Height="50px" runat="server" Text="Fill" OnClick="userbtn_Click"/>
    </div>
    
    </div>

</div>
        <div class="col-sm-3">
		    <!--Card-->
<div class="card">

    <!--Card image-->
    <img class="img-fluid" src="assets/retro.png" alt="Card image cap" width="120px" height="120px">

    <!--Card content-->
    <div class="card-body">
        <!--Title-->
        <h5 class="card-title text-center">Retrospective</h5>
        <!--Text-->
        <p class="card-text"></p>
          <asp:Button ID="retrobtn" CssClass="btn btn-primary" Width="200px" Height="50px" runat="server" Text="Fill" OnClick="retrobtn_Click"/>
    </div>
    </div>
            </div>
             <div class="col-sm-3">
		    <!--Card-->
<div class="card">

    <!--Card image-->
    <img class="img-fluid" src="assets/cnote.png" alt="Card image cap" width="100px" height="100px" style="margin-top:20px">

    <!--Card content-->
    <div class="card-body">
        <!--Title-->
        <h5 class="card-title text-center">Notes</h5>
        <!--Text-->
        <p class="card-text"></p>
          <asp:Button ID="notebtn" CssClass="btn btn-primary" Width="200px" Height="50px" runat="server" Text="View" OnClick="notebtn_Click"/>
    </div>
    </div>


</div>
                 <div class="col-sm-3">
		    <!--Card-->
<div class="card">

    <!--Card image-->
    <img class="img-fluid" src="assets/instruct.png" alt="Card image cap" width="120px" height="120px" style="margin-top:40px">

    <!--Card content-->
    <div class="card-body">
        <!--Title-->
        <h5 class="card-title text-center">Instructions</h5>
        <!--Text-->
        <p class="card-text"></p>
          <asp:Button ID="instructbtn" CssClass="btn rounded-0 btn-primary" Width="200px" Height="50px" runat="server" Text="View" OnClick="instructbtn_Click"/>
    </div>
    </div>
            </div>
             
     </div>
        <br />
        <div class="row">


                 <div class="col-sm-3" id="masterdiv" runat="server">
		    <!--Card-->
<div class="card">

    <!--Card image-->
    <img class="img-fluid" src="assets/cpx.png" alt="Card image cap" width="120px" height="120px">

    <!--Card content-->
    <div class="card-body">
        <!--Title-->
        <h5 class="card-title text-center">Master Controls</h5>
        <!--Text-->
        <p class="card-text"></p>
          <asp:Button ID="masterbtn" CssClass="btn btn-danger" Width="200px" Height="50px" runat="server" Text="View" OnClick="masterbtn_Click"/>
    </div>
    </div>
            </div>
            </div>

        <br />
        <br />
        
    </form>
</body>
</html>
