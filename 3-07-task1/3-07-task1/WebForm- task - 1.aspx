﻿<%@ Page Language="C#" AutoEventWireup="true" CodeBehind="task1.aspx.cs" Inherits="task1.task1" %>

<!DOCTYPE html>

<html xmlns="http://www.w3.org/1999/xhtml">
<head runat="server">
    <title></title>
</head>
<body>
    <form id="form1" runat="server">
        <div>
            <asp:Label ID="Label1" runat="server" Text="Name : "></asp:Label> 
            <asp:TextBox ID="TextBox1" runat="server"></asp:TextBox>
            <br />
            <br />
            <asp:Label ID="Label2" runat="server" Text="Email : "></asp:Label>
&nbsp;<asp:TextBox ID="TextBox2" runat="server"></asp:TextBox>
            <br />
            <br />
            <asp:Label ID="Label3" runat="server" Text="ID : "></asp:Label> 
        &nbsp;&nbsp;&nbsp;&nbsp;&nbsp;
            <asp:TextBox ID="TextBox3" runat="server"></asp:TextBox>
            <br />
            <br />
            <asp:Label ID="Label4" runat="server" Text="Gender : "></asp:Label>
&nbsp;
            &nbsp;<asp:RadioButtonList ID="RadioButtonList1" runat="server" OnSelectedIndexChanged="RadioButtonList1_SelectedIndexChanged" Width="122px">
                <asp:ListItem id="nn">Male</asp:ListItem>
                <asp:ListItem>Female</asp:ListItem>
            </asp:RadioButtonList>
            &nbsp;&nbsp;
            <br />
            <asp:Label ID="Label5" runat="server" Text="Courses : "></asp:Label>
&nbsp;<asp:CheckBox ID="CheckBox1" runat="server" Text="C" />
&nbsp;&nbsp;
            <asp:CheckBox ID="CheckBox2" runat="server" Text="C#" />
&nbsp;&nbsp;
            <asp:CheckBox ID="CheckBox3" runat="server" Text="C++" />
            <br />
            <br />
            <asp:Label ID="Label6" runat="server" Text="Description : "></asp:Label>
            <br />
            <br />
            <asp:TextBox ID="TextBox4" runat="server" Height="122px" Width="249px"></asp:TextBox>
            <br />
            <br />
&nbsp;&nbsp;&nbsp;&nbsp;&nbsp;&nbsp;
            <asp:Button ID="Button1" runat="server" OnClick="Button1_Click" Text="Submit" Width="130px" />

            <br />
            <br />
            <asp:Label ID="Label7" runat="server"></asp:Label>
            <br />
            <br />
            <asp:Label ID="Label8" runat="server"></asp:Label>
            <br />
            <br />
            <asp:Label ID="Label9" runat="server"></asp:Label>
            <br />
            <br />
            <asp:Label ID="Label10" runat="server"></asp:Label>
            <br />
            <br />
            <asp:Label ID="Label11" runat="server"></asp:Label>
            &nbsp;<asp:Label ID="Label12" runat="server"></asp:Label>
        &nbsp;<asp:Label ID="Label13" runat="server"></asp:Label>
            <br />
            <br />
            <asp:Label ID="Label14" runat="server"></asp:Label>
            <br />
            <br />
        </div>
    </form>
</body>
</html>