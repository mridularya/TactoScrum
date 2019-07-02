<%@ Page Language="C#" AutoEventWireup="true" CodeFile="viewroles.aspx.cs" Inherits="viewroles" %>
<%@ Register Assembly="AjaxControlToolkit" Namespace="AjaxControlToolkit" TagPrefix="cc1" %>

<!DOCTYPE html>

<html>
<head runat="server">
    <link rel="stylesheet" href="https://stackpath.bootstrapcdn.com/bootstrap/4.3.1/css/bootstrap.min.css" integrity="sha384-ggOyR0iXCbMQv3Xipma34MD+dH/1fQ784/j6cY/iJTQUOhcWr7x9JvoRxT2MZw1T" crossorigin="anonymous"> 
       
     <link href="https://cdnjs.cloudflare.com/ajax/libs/jquery-footable/0.1.0/css/footable.min.css"
    rel="stylesheet" type="text/css" />
   
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
<style>
.mydatagrid

{

    width: 80%;
    border: solid 2px black;

    min-width: 80%;

}

.header

{
    background-color: #000;

    font-family: Arial;

    color: White;

    height: 25px;

    text-align: center;

    font-size: 16px;

}

 

.rows

{

    background-color: #fff;
    font-family: Arial;

    font-size: 14px;

    color: #000;

    min-height: 25px;

    text-align: left;

}

.rows:hover

{

    background-color: #5badff;

    color: #fff;

}

 

.mydatagrid a /** FOR THE PAGING ICONS  **/

{

    background-color: Transparent;

    padding: 5px 5px 5px 5px;

    color: #fff;

    text-decoration: none;

    font-weight: bold;

}

 

.mydatagrid a:hover /** FOR THE PAGING ICONS  HOVER STYLES**/

{

    background-color: #000;

    color: #fff;

}

.mydatagrid span /** FOR THE PAGING ICONS CURRENT PAGE INDICATOR **/

{

    background-color: #fff;

    color: #000;

    padding: 5px 5px 5px 5px;

}

.pager

{

    background-color: #5badff;

    font-family: Arial;

    color: White;

    height: 30px;

    text-align: left;

}

.mydatagrid td

{

    padding: 5px;

}

   .mydatagrid th

{
   padding: 5px;
}
   ::-webkit-scrollbar {
display: none;
}


</style>
    <title>Roles</title>
</head>

<body style="background-image: linear-gradient(to left, #233857, #0a4f6e, #00667d, #007e83, #299481);" class="shadow-lg">
       <div class="jumbotron-fluid text-center" style="background-image: linear-gradient(to left, #233857, #0a4f6e, #00667d, #007e83, #299481); height:90px">
            <div class="row">
                <div>
             <img src="assets/agile_agile-02-512.png" alt="na" height="80px" style="margin-left:500px"/>
                    </div>
                <div>
            <h1 style="color:white;margin-top:20px">Roles</h1>
                    </div>
        </div>
            </div>
    <br />
    <form id="form1" runat="server">
      <div class="container-fluid">
              <div>
            <asp:Button Text="Create New" ID="CreateRole" runat="server" CssClass="btn btn-primary" OnClick="CreateRole_Click" style="float:right" /> 
                <asp:Button Text="Back" ID="back" runat="server" CssClass="btn btn-sm btn-primary" style="float:left" OnClick="back_Click" />
                </div>
       <asp:GridView  ID="gv1" runat="server" BackColor="white"  BorderColor="#DEDFDE"  CellPadding="4" GridLines="Both" ForeColor="black" CssClass="footable">
           <RowStyle HorizontalAlign="Center" />
            <AlternatingRowStyle BackColor="White" HorizontalAlign="Center" />
            <FooterStyle BackColor="#CCCC99" />
            <HeaderStyle BackColor="#000000" Font-Bold="True" ForeColor="white" Width="40px" />
            <PagerStyle BackColor="AliceBlue" ForeColor="Black" HorizontalAlign="Center" /> 
            <RowStyle BackColor="AliceBlue" HorizontalAlign="Center"/>
            <SelectedRowStyle BackColor="#CE5D5A" Font-Bold="True" ForeColor="White" />
            <SortedAscendingCellStyle BackColor="#ff9933" />
            <SortedAscendingHeaderStyle BackColor="#848384" />
            <SortedDescendingCellStyle BackColor="#EAEAD3" />
            <SortedDescendingHeaderStyle BackColor="#575357" />
        </asp:GridView>
            </div>
         <h3>&nbsp;</h3>
    </form>
</body>
</html>
