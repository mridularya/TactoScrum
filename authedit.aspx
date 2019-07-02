<%@ Page Language="C#" AutoEventWireup="true" CodeFile="authedit.aspx.cs" Inherits="scrum.authedit" %>

<html>
<head runat="server">
    <title>Product Backlog</title>
       <link rel="stylesheet" href="https://stackpath.bootstrapcdn.com/bootstrap/4.3.1/css/bootstrap.min.css" integrity="sha384-ggOyR0iXCbMQv3Xipma34MD+dH/1fQ784/j6cY/iJTQUOhcWr7x9JvoRxT2MZw1T" crossorigin="anonymous">    
     <link href="https://cdnjs.cloudflare.com/ajax/libs/jquery-footable/0.1.0/css/footable.min.css"  <script src="https://cdnjs.cloudflare.com/ajax/libs/materialize/1.0.0/js/materialize.min.js"></script>
<script type="text/javascript" src="http://ajax.googleapis.com/ajax/libs/jquery/1.8.3/jquery.min.js"></script>
<script type="text/javascript" src="https://cdnjs.cloudflare.com/ajax/libs/jquery-footable/0.1.0/js/footable.min.js"></script>
    <style>
        .padding {
            margin-left: 50px;
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

        .allignment {
            margin-left: 20px;
            margin-top: 20px;
            margin-bottom: 15px;
        }

        ::-webkit-scrollbar {
            display: none;
        }
    </style>


</head>
<body style="background-image: linear-gradient(to left, #233857, #0a4f6e, #00667d, #007e83, #299481);" class="shadow-lg">
       <div class="jumbotron-fluid text-center" style="background-image: linear-gradient(to left, #233857, #0a4f6e, #00667d, #007e83, #299481); height:90px">
            <div class="row">
                <div>
             <img src="assets/agile_agile-02-512.png" alt="na" height="80px" style="margin-left:500px"/>
                    </div>
                <div>
            <h1 style="color:white;margin-top:20px">task Master</h1>
                    </div>
        </div>
            </div>
    <br />
    <form id="form1" runat="server">  
       <div class="container-fluid card-body">
        <asp:GridView ID="GridView1" Width="1300px" runat="server" AutoGenerateColumns="False" CellPadding="6" OnRowCancelingEdit="GridView1_RowCancelingEdit"   
  
OnRowEditing="GridView1_RowEditing" OnRowUpdating="GridView1_RowUpdating" OnRowDeleting="GridView1_RowDeleting" CssClass="footable">  
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
            <Columns>  
                <asp:TemplateField>  
                    <ItemTemplate>  
                        <asp:Button ID="btn_Edit" runat="server" Text="Edit" CssClass="btn-primary" CommandName="Edit" />  
                            <asp:Button ID="btn_Delete" runat="server" Text="Unauthorise" CssClass="btn-danger" CommandName="Delete" />  
                    </ItemTemplate>  
                    <EditItemTemplate>  
                        <asp:Button ID="btn_Update" runat="server" Text="Update" CommandName="Update" CssClass="btn-danger"/>  
                        <asp:Button ID="btn_Cancel" runat="server" Text="Cancel" CommandName="Cancel" CssClass="btn-primary"/> 
                      
                    </EditItemTemplate> 
                   
                </asp:TemplateField>  
                <asp:TemplateField HeaderText="id" Visible="false">  
                    <ItemTemplate>  
                        <asp:Label ID="idd" runat="server" Visible="false" Text='<%#Eval("id") %>'></asp:Label>  
                    </ItemTemplate>  
                    </asp:TemplateField>
                 <asp:TemplateField HeaderText="Name">  
                    <ItemTemplate>  
                        <asp:Label ID="Name" runat="server" Text='<%#Eval("Name") %>'></asp:Label>  
                    </ItemTemplate>  
                    <EditItemTemplate>  
                        <asp:TextBox ID="e_Name" runat="server" Text='<%#Eval("Name") %>'></asp:TextBox>
                    </EditItemTemplate>  
                </asp:TemplateField>  
                  <asp:TemplateField HeaderText="Username">  
                    <ItemTemplate>  
                        <asp:Label ID="Uname" runat="server" Text='<%#Eval("username") %>'></asp:Label>  
                        </ItemTemplate>
                             <EditItemTemplate>
                        <asp:TextBox ID="e_Uname" runat="server" Text='<%#Eval("username")%>'></asp:TextBox>
                    </EditItemTemplate>  
                </asp:TemplateField> 
                    <asp:TemplateField HeaderText="Password">  
                    <ItemTemplate>  
                        <asp:Label ID="pwd" runat="server" Text='<%#Eval("password") %>'></asp:Label>  
                        </ItemTemplate>
                             <EditItemTemplate>
                        <asp:TextBox ID="e_pwd" runat="server" Text='<%#Eval("password")%>'></asp:TextBox>
                    </EditItemTemplate>  
                </asp:TemplateField> 
            </Columns>  
        </asp:GridView>  
           </div>
    </form>
</body>
</html>