<%@ Page Language="C#" AutoEventWireup="true" CodeFile="sprint_view.aspx.cs" Inherits="scrum.sprint_view" %>

<!DOCTYPE html>

<html>
<head runat="server">
    <!-- Font Awesome -->
    <link rel="stylesheet" href="https://use.fontawesome.com/releases/v5.8.2/css/all.css">
    <!-- Bootstrap core CSS -->
    <link href="https://cdnjs.cloudflare.com/ajax/libs/twitter-bootstrap/4.3.1/css/bootstrap.min.css" rel="stylesheet">
    <!-- Material Design Bootstrap -->
    <link href="https://cdnjs.cloudflare.com/ajax/libs/mdbootstrap/4.8.2/css/mdb.min.css" rel="stylesheet">
    <title>Splash</title>
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
<body style="background-color:#EEEEEE;">
    <form id="form1" runat="server">
        <div class="jumbotron-fluid text-center" style="background-image: linear-gradient(to left, #233857, #0a4f6e, #00667d, #007e83, #299481); height:90px">
            <div class="row">
                <div>
             <img src="assets/agile_agile-02-512.png" alt="na" height="80px" style="margin-left:500px"/>
                    </div>
                <div>
            <h1 style="color:white;margin-top:20px">Sprint backlog</h1>
                    </div>
        </div>
            </div>
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
                          <asp:Button ID="btn_Delete" runat="server" Text="Delete" CssClass="btn-danger" CommandName="Delete" />  
                    </ItemTemplate>  
                    <EditItemTemplate>  
                        <asp:Button ID="btn_Update" runat="server" Text="Update" CommandName="Update" CssClass="btn-danger"/>  
                        <asp:Button ID="btn_Cancel" runat="server" Text="Cancel" CommandName="Cancel" CssClass="btn-primary"/> 
                      
                    </EditItemTemplate>
                    </asp:TemplateField> 
                
                    
                 <asp:TemplateField HeaderText="id">  
                    <ItemTemplate>  
                        <asp:Label ID="idd" runat="server" Text='<%#Eval("id") %>'></asp:Label>  
                    </ItemTemplate>  
                 </asp:TemplateField>
                       
                <asp:TemplateField HeaderText="Backlog Name">  
                    <ItemTemplate>  
                        <asp:Label ID="bknm" runat="server" Text='<%#Eval("backlog") %>'></asp:Label>  
                    </ItemTemplate>  
                    </asp:TemplateField>
                <asp:TemplateField HeaderText="sprint Name">  
                    <ItemTemplate>  
                        <asp:Label ID="sprint" runat="server" Text='<%#Eval("sprint") %>'></asp:Label>  
                    </ItemTemplate>  
                     <EditItemTemplate>  
                        <asp:TextBox ID="e_sprint" runat="server" Text='<%#Eval("sprint") %>'></asp:TextBox>  
                    </EditItemTemplate>  
                </asp:TemplateField>  
                 <asp:TemplateField HeaderText="start Date">  
                    <ItemTemplate>  
                        <asp:Label ID="cd" runat="server" Text='<%#Eval("creation") %>'></asp:Label>  
                    </ItemTemplate>    
                </asp:TemplateField> 
                  <asp:TemplateField HeaderText="deadline">  
                    <ItemTemplate>  
                        <asp:Label ID="deadline" runat="server" Text='<%#Eval("deadline") %>'></asp:Label>  
                    </ItemTemplate>  
                    <EditItemTemplate>  
                        <asp:TextBox ID="e_deadline" runat="server" Text='<%#Eval("deadline") %>'></asp:TextBox>  
                    </EditItemTemplate>  
                </asp:TemplateField>   
                  <asp:TemplateField HeaderText="priority">  
                    <ItemTemplate>  
                        <asp:Label ID="pr" runat="server" Text='<%#Eval("priority") %>'></asp:Label>  
                    </ItemTemplate>  
                    <EditItemTemplate>  
                        <asp:TextBox ID ="e_pr" runat="server" Text='<%#Eval("priority") %>'></asp:TextBox>
                    </EditItemTemplate>  
                </asp:TemplateField>  
               
                <asp:TemplateField HeaderText="Remarks">  
                    <ItemTemplate>  
                        <asp:Label ID="reamrks" runat="server" Text='<%#Eval("remarks") %>'></asp:Label>  
                    </ItemTemplate>  
                    <EditItemTemplate>  
                        <asp:TextBox ID="e_remarks" runat="server" Text='<%#Eval("remarks") %>'></asp:TextBox>  
                    </EditItemTemplate>  
                </asp:TemplateField>  
                <asp:TemplateField HeaderText="Status">  
                    <ItemTemplate>  
                        <asp:Label ID="status" runat="server" Text='<%#Eval("status") %>'></asp:Label>  
                    </ItemTemplate>  
                    <EditItemTemplate>  
                        <asp:TextBox ID="e_status" runat="server" Text='<%#Eval("status") %>'></asp:TextBox>  
                    </EditItemTemplate>  
                </asp:TemplateField>  
               </Columns>  
        </asp:GridView>  
             
           </div>
        <asp:Button ID="back" Text="Back" CssClass="btn-primary" style="margin-left:10px" OnClick="back_Click" runat="server" />

        </form>
    </body>
    </html>
