<%@ Page Language="C#" AutoEventWireup="true" CodeBehind="WebForm1.aspx.cs" Inherits="WebApplication5.WebForm1" %>

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
        <div>
            <asp:Label ID="Label1" runat="server" Text="Project Name/nom du projet"></asp:Label>
            :&nbsp;&nbsp;
            <asp:TextBox ID="TextBox1" runat="server"></asp:TextBox>
            &nbsp;&nbsp;
            <asp:RequiredFieldValidator ID="RequiredFieldValidator1" runat="server" ControlToValidate="TextBox1" ErrorMessage="Project name Required.../Nom du projet Obligatoire ..."></asp:RequiredFieldValidator>
            <br />
            <br />
            <asp:Label ID="Label2" runat="server" Text="Department Name/Nom du département"></asp:Label>
            :
             <asp:DropDownList ID="DropDownList3" runat="server" DataTextField="department" DataValueField="department" AppendDataBoundItems="true" AutoPostBack="True" OnSelectedIndexChanged="DropDownList3_SelectedIndexChanged">  
                    <asp:ListItem Value="-1">-- Select Department--</asp:ListItem>  
                    <asp:ListItem>Division of Telecommunications Extranet Development</asp:ListItem>
                    <asp:ListItem>Extranet Multimedia Connectivity and Security Division</asp:ListItem>
                    <asp:ListItem>Branch of Extranet Implementation</asp:ListItem>
                    <asp:ListItem>Branch of Intranet Computer Maintenance and E-Commerce PC Programming</asp:ListItem>
                    <asp:ListItem>Wireless Extranet Backup Team</asp:ListItem>
                 <asp:ListItem>Database Programming Branch</asp:ListItem>
                 <asp:ListItem>Multimedia Troubleshooting and Maintenance Team</asp:ListItem>
                  <asp:ListItem>Office of Statistical Data Connectivity</asp:ListItem>
                 <asp:ListItem>Division of Application Security</asp:ListItem>
                 <asp:ListItem>PC Maintenance Department</asp:ListItem>
                 <asp:ListItem>Bureau of Business-Oriented PC Backup and Wireless Telecommunications Control</asp:ListItem>
                <asp:ListItem>Software Technology and Networking Department</asp:ListItem>
                 <asp:ListItem>Database Programming Branch</asp:ListItem>
                   <asp:ListItem>Network Maintenance and Multimedia Implementation Committee</asp:ListItem>
                 <asp:ListItem>Hardware Backup Department</asp:ListItem>
                 <asp:ListItem>Mainframe PC Development and Practacal Source Code Acquisition Team</asp:ListItem>

                  </asp:DropDownList>  
            <asp:RequiredFieldValidator ID="RequiredFieldValidator2" runat="server" ControlToValidate="DropDownList3" ErrorMessage="Department name Required..../Nom du département Obligatoire ...."></asp:RequiredFieldValidator>
            <br />
            <br />
            <br />
            <asp:Label ID="Label3" runat="server" Text="Requested By/Demandé par"></asp:Label>
            :&nbsp;&nbsp;&nbsp;&nbsp;
             <asp:DropDownList ID="DropDownList2" runat="server" AppendDataBoundItems="true" DataTextField="employee"   
                    DataValueField="department" AutoPostBack="True">  
         
                </asp:DropDownList>  
            <asp:RequiredFieldValidator ID="RequiredFieldValidator3" runat="server" ControlToValidate="DropDownList2" ErrorMessage="Please Choose the Employe name.../Veuillez choisir le nom de l'employé ..."></asp:RequiredFieldValidator>
            <br />
            <asp:Label ID="Label5" runat="server"></asp:Label>
            <br />
            <asp:Label ID="Label4" runat="server" Text="Description/ La description"></asp:Label>
            :&nbsp;&nbsp;
            <asp:TextBox ID="TextBox2" runat="server" Height="22px" Width="191px"></asp:TextBox>
            <asp:RequiredFieldValidator ID="RequiredFieldValidator4" runat="server" ControlToValidate="TextBox2" ErrorMessage="Problem description Required.../Description du problème Obligatoire ..."></asp:RequiredFieldValidator>
            <br />
            <br />
            <br />
        </div>
        <asp:Button ID="Button1" runat="server" OnClick="Button1_Click"  Text="Submit/Soumettre" />
    </form>
</body>
</html>
