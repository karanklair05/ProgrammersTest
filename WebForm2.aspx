<%@ Page Language="C#" AutoEventWireup="true" CodeBehind="WebForm2.aspx.cs" Inherits="WebApplication5.WebForm2" %>

<!DOCTYPE html>

<html xmlns="http://www.w3.org/1999/xhtml">
<head runat="server">
    <title></title>
    <style>
        body{
            background-color:lavenderblush;
            color:red;
            font-family:'Bell MT'
        }
        form{
            border-style:dotted;
        }
        #Button1:hover {
  background-color: #ddd;
  border: none;
  color: black;
  padding: 16px 32px;
  text-align: center;
  font-size: 16px;
  margin: 4px 2px;
  transition: 0.3s;
}
        
    </style>

    </head>
<body>
    <asp:Image ID="Image1" runat="server" ImageUrl="~/bell-canada-logo.png" Height="200" Width="300" />
    <form id="form1" runat="server">
        <asp:RadioButton ID="RadioButton1" runat="server" GroupName="Radio" text="No Filter/Pas de filtre"/>
        <br />
        <asp:RadioButton ID="RadioButton2" runat="server" GroupName="Radio" text="Filter by Project name/Filtrer par nom de projet"/>
        <br />
        <asp:RadioButton ID="RadioButton3" runat="server" GroupName="Radio" text="Filter by Department name/
Filtrer par nom de département"/>
        <br />
        <asp:RadioButton ID="RadioButton4" runat="server" GroupName="Radio" text="Filter by Employee name/Filtrer par nom d'employé"/>

        <br />
        <asp:RadioButton ID="RadioButton5" runat="server" GroupName="Radio" text="Filter by Description(Specific Keywords)/
Filtrer par description (mots clés spécifiques)"/>

        <br />
        <asp:TextBox ID="TextBox1" runat="server"></asp:TextBox>
&nbsp;
        <asp:Button ID="Button1" runat="server" OnClick="Button1_Click" Text="Filter/Filtrer" />
&nbsp;
        &nbsp;<asp:GridView ID="GridView1" runat="server" BackColor="White" BorderColor="#999999" BorderStyle="None" BorderWidth="1px" CellPadding="3" GridLines="Vertical">
            <AlternatingRowStyle BackColor="#DCDCDC" />
            <FooterStyle BackColor="#CCCCCC" ForeColor="Black" />
            <HeaderStyle BackColor="#000084" Font-Bold="True" ForeColor="White" />
            <PagerStyle ForeColor="Black" HorizontalAlign="Center" BackColor="#999999" />
            <RowStyle BackColor="#EEEEEE" ForeColor="Black" />
            <SelectedRowStyle BackColor="#008A8C" Font-Bold="True" ForeColor="White" />
            <SortedAscendingCellStyle BackColor="#F1F1F1" />
            <SortedAscendingHeaderStyle BackColor="#0000A9" />
            <SortedDescendingCellStyle BackColor="#CAC9C9" />
            <SortedDescendingHeaderStyle BackColor="#000065" />
        </asp:GridView>
        <br />
        <br />
        <br />
        <br />
        <asp:ImageButton ID="ImageButton1" runat="server" Height="42px" ImageUrl="~/back_button_-1646213_1920.jpg" PostBackUrl="~/WebForm1.aspx" Width="72px" />
        <div>
        </div>
        
    &nbsp;&nbsp;&nbsp;
        <div style="margin-left: 40px">
            <br />
        </div>
        
    </form>
</body>
</html>
