<%@ Page Language="C#" AutoEventWireup="true" CodeFile="product backlog.aspx.cs" Inherits="scrum.WebForm2" %>

<%@ Register Assembly="AjaxControlToolkit" Namespace="AjaxControlToolkit" TagPrefix="cc1" %>

<!DOCTYPE html>

<html>
<head runat="server">
  
   
    <link type="text/css" href="css/ui-lightness/jquery-ui-1.8.19.custom.css" rel="stylesheet" />
<script type="text/javascript" src="js/jquery-1.7.2.min.js"></script>
<script type="text/javascript" src="js/jquery-ui-1.8.19.custom.min.js"></script>
            
   
  
       <!--  jQuery -->
<script type="text/javascript" src="https://code.jquery.com/jquery-1.11.3.min.js"></script>

<!-- Isolated Version of Bootstrap, not needed if your site already uses Bootstrap -->
<link rel="stylesheet" href="https://formden.com/static/cdn/bootstrap-iso.css" />

<!-- Bootstrap Date-Picker Plugin -->
<script type="text/javascript" src="https://cdnjs.cloudflare.com/ajax/libs/bootstrap-datepicker/1.4.1/js/bootstrap-datepicker.min.js"></script>
<link rel="stylesheet" href="https://cdnjs.cloudflare.com/ajax/libs/bootstrap-datepicker/1.4.1/css/bootstrap-datepicker3.css"/>
    
  
    <style>
        .padding{
            margin-left : 20px;
        }
         .allignment{
     margin-left:20px;
     margin-top:20px;
     margin-bottom:15px;
  }
            ::-webkit-scrollbar {
display: none;
}
      

    </style>

    <title>Product Backlog</title>
    <link href="https://cdnjs.cloudflare.com/ajax/libs/jquery-footable/0.1.0/css/footable.min.css"
    rel="stylesheet" type="text/css" />
<script type="text/javascript" src="http://ajax.googleapis.com/ajax/libs/jquery/1.8.3/jquery.min.js"></script>
<script type="text/javascript" src="https://cdnjs.cloudflare.com/ajax/libs/jquery-footable/0.1.0/js/footable.min.js"></script>

    <link rel="stylesheet" href="https://stackpath.bootstrapcdn.com/bootstrap/4.3.1/css/bootstrap.min.css" integrity="sha384-ggOyR0iXCbMQv3Xipma34MD+dH/1fQ784/j6cY/iJTQUOhcWr7x9JvoRxT2MZw1T" crossorigin="anonymous">
</head>
<body runat="server" style="background-color:#EEEEEE">
            <form id="form1" runat="server" method="post">
                 <asp:ScriptManager runat="server" ID="scriptManager" ></asp:ScriptManager>
        <div class="jumbotron-fluid text-center" style="background-image: linear-gradient(to left, #233857, #0a4f6e, #00667d, #007e83, #299481); height:90px">
            <div class="row">
                <div>
             <img src="assets/agile_agile-02-512.png" alt="na" height="80px" style="margin-left:500px"/>
                    </div>
                <div>
            <h1 style="color:white;margin-top:20px">Product Entry</h1>
                    </div>
        </div>
            </div>
                            <div class="row">
                                <h3 class="col-4 allignment">Select Product Master</h3>
                                
                                <asp:DropDownList ID="Dd1" runat="server" CssClass="col-4 form-control allignment"></asp:DropDownList>
                            </div>
                         
                            <div class="row">
                                <h3 class="col-4 allignment">Backlog Name :</h3>
                                <asp:TextBox ID="tb1" runat="server" CssClass="form-control col-4 allignment" AutoCompleteType="Disabled"></asp:TextBox>
                            </div>
                            <div class="row">
                                
                             <h3 class="col-4 allignment">Start Date :</h3>
                                
                                  
        <asp:TextBox  runat="server" CssClass="form-control col-4 allignment" id="date1" name="date" placeholder="DD/MM/YYYY" type="text" AutoCompleteType="Disabled"></asp:TextBox>
                            <ajaxToolkit:CalendarExtender ID="CalendarExtender1" TargetControlID="date1" Format="dd/MM/yyyy"  runat="server" />
                                        </div>
         <div class="row">
                 <h3 class="col-4 allignment">deadline : </h3>
        <asp:TextBox runat="server" CssClass="form-control col-4 allignment"  id="date2" name="date" placeholder="DD/MM/YYYY" type="text" AutoCompleteType="Disabled"></asp:TextBox>
                          <ajaxToolkit:CalendarExtender ID="CalendarExtender2" TargetControlID="date2" Format="dd/MM/yyyy"  runat="server" />
                 </div>    
                 <div class="row">
                                <h3 class="col-4 allignment">Priority (1-5) :</h3>
                     
                                <asp:DropDownList ID="Dd2" runat="server" CssClass="col-4 form-control allignment">
                                    <asp:ListItem Value="1">1</asp:ListItem>
                                    <asp:ListItem Value="2">2</asp:ListItem>
                                    <asp:ListItem Value="3">3</asp:ListItem>
                                    <asp:ListItem Value="4">4</asp:ListItem>
                                    <asp:ListItem Value="5">5</asp:ListItem>
                                </asp:DropDownList>
                            </div>
                  <div class="container-fluid">     
                 <asp:gridview ID="Gridview1" runat="server" ShowFooter="true"
                             AutoGenerateColumns="false" CssClass="footable tmarg">
        <Columns>
        <asp:BoundField DataField="RowNumber" HeaderText="Feature number" />
        <asp:TemplateField HeaderText="feature Name">
            <ItemTemplate>
                <asp:TextBox ID="TextBox1" AutoCompleteType="Disabled" runat="server" CssClass="form-control col-12" ></asp:TextBox>
            </ItemTemplate>
        </asp:TemplateField>
        <asp:TemplateField HeaderText="feature Description">
            <ItemTemplate>
                <asp:TextBox ID="TextBox2" AutoCompleteType="Disabled"  runat="server" CssClass="form-control col-12"></asp:TextBox>
            </ItemTemplate>
        </asp:TemplateField>
        <asp:TemplateField HeaderText="Acceptence Criteria">
            <ItemTemplate>
                 <asp:TextBox ID="TextBox3" AutoCompleteType="Disabled"  runat="server" CssClass="form-control col-12"></asp:TextBox>
            </ItemTemplate>
            <FooterStyle HorizontalAlign="Right" />
            <FooterTemplate>
                 <asp:Button ID="ButtonAdd" runat="server" Text="Add another feature Or Save" CssClass="btn-secondary" OnClick ="ButtonAdd_Click" />
            </FooterTemplate>
        </asp:TemplateField>
        </Columns>
</asp:gridview>
                      </div>
                       
               

                            
                        
                    <br />
                <div class="row">
                        
                            <asp:Button ID="Button1" runat="server" CssClass="btn-primary col-6"  Text="Submit" OnClick="Button1_Click" />
                       
                
                            <asp:Button ID="Button2" runat="server" CssClass="btn-danger col-6"  Text="Back" OnClick="Button2_Click" />
                    </div>    
                    <br />
                    <br />
                    <br />
</div>
</form>
     


</body>
</html>
