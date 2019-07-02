<%@ Page Language="C#" AutoEventWireup="true" CodeFile="pb.aspx.cs" Inherits="scrum.pb" %>

<!DOCTYPE html>
<html>
<head runat="server">
    <!-- Bootstrap core CSS -->
    <link href="https://cdnjs.cloudflare.com/ajax/libs/twitter-bootstrap/4.3.1/css/bootstrap.min.css" rel="stylesheet
     <script src="https://cdnjs.cloudflare.com/ajax/libs/materialize/1.0.0/js/materialize.min.js"></script>
<script type="text/javascript" src="http://ajax.googleapis.com/ajax/libs/jquery/1.8.3/jquery.min.js"></script>
<script type="text/javascript" src="https://cdnjs.cloudflare.com/ajax/libs/jquery-footable/0.1.0/js/footable.min.js"></script>
    <link href="https://cdnjs.cloudflare.com/ajax/libs/mdbootstrap/4.8.2/css/mdb.min.css" rel="stylesheet">
    <!-- JQuery -->
<script type="text/javascript" src="https://cdnjs.cloudflare.com/ajax/libs/jquery/3.4.1/jquery.min.js"></script>
<!-- Bootstrap tooltips -->
<script type="text/javascript" src="https://cdnjs.cloudflare.com/ajax/libs/popper.js/1.14.4/umd/popper.min.js"></script>
<!-- Bootstrap core JavaScript -->
<script type="text/javascript" src="https://cdnjs.cloudflare.com/ajax/libs/twitter-bootstrap/4.3.1/js/bootstrap.min.js"></script>
<!-- MDB core JavaScript -->
<script type="text/javascript" src="https://cdnjs.cloudflare.com/ajax/libs/mdbootstrap/4.8.2/js/mdb.min.js"></script>
    <title>Product Backlog</title>
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

     
    </style>
</head>
<body style="background-color:#EEEEEE">
    <form id="form1" runat="server">
        <div class="jumbotron-fluid text-center" style="background-image: linear-gradient(to left, #233857, #0a4f6e, #00667d, #007e83, #299481); height:90px">
            <div class="row">
                <div>
             <img src="assets/agile_agile-02-512.png" alt="na" height="80px" style="margin-left:500px"/>
                    </div>
                <div>
            <h1 style="color:white;margin-top:20px">Product Backlog</h1>
                    </div>
        </div>
            </div>
        <br />

        <div class="container-fluid">

            <div>
            <asp:Button Text="Create New" runat="server" ID="pbCreateButton" CssClass="btn btn-primary" style="float:right" OnClick="pbCreateButton_Click" />
                 <asp:Button Text="Back" runat="server" ID="Back" CssClass="btn btn-primary btn-sm" style="float:left" OnClick="Back_Click" />
       </div>
                <asp:GridView  ID="gv1" runat="server" BackColor="white"  BorderColor="#000000"  CellPadding="4" GridLines="Both" BorderWidth="1px" ForeColor="black" CssClass="footable" Width="100%" Height="100%">
           <RowStyle HorizontalAlign="Center" />
            <AlternatingRowStyle BackColor="White" HorizontalAlign="Center" />
            <FooterStyle BackColor="#CCCC99" />

            <HeaderStyle BackColor="#000000" Font-Bold="True" HorizontalAlign="Center" ForeColor="white" Width="40px" />
            <PagerStyle BackColor="AliceBlue" ForeColor="Black" HorizontalAlign="Center" /> 
            <RowStyle BackColor="AliceBlue" HorizontalAlign="Center"/>
            <SelectedRowStyle BackColor="#CE5D5A" Font-Bold="True" ForeColor="White" />
            <SortedAscendingCellStyle BackColor="#ff9933" />
            <SortedAscendingHeaderStyle BackColor="#848384" />
            <SortedDescendingCellStyle BackColor="#EAEAD3" />
            <SortedDescendingHeaderStyle BackColor="#575357" />
        
        </asp:GridView>
            </div>
        </form>
    </body>
    </html>