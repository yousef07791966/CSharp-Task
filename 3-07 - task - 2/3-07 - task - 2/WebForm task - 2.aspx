<%@ Page Language="C#" AutoEventWireup="true" CodeBehind="WebForm task - 2.aspx.cs" Inherits="_3_07___task___2.WebForm_task___2" %>


<!DOCTYPE html>

<html xmlns="http://www.w3.org/1999/xhtml">
<head runat="server">
    <title></title>
</head>
<body>
    <form id="form1" runat="server">
        <div>

            <asp:Label ID="Label1" runat="server" Text="Number 1 : "></asp:Label>
&nbsp;<asp:TextBox ID="TextBox1" runat="server" Height="27px" Width="198px"></asp:TextBox>
            <br />
            <br />
            <asp:Label ID="Label2" runat="server" Text="Number 2 : "></asp:Label>
            <asp:TextBox ID="TextBox2" runat="server" Height="26px" Width="205px"></asp:TextBox>
            <br />
            <br />
            <asp:Button ID="Button1" runat="server" BackColor="Red" OnClick="Button1_Click" Text="-" Width="93px" />
&nbsp;&nbsp;&nbsp;
            <asp:Button ID="Button2" runat="server" BackColor="Lime" OnClick="Button2_Click" Text="+" Width="93px" />
&nbsp;&nbsp;&nbsp;
            <asp:Button ID="Button3" runat="server" BackColor="#0066FF" OnClick="Button3_Click" Text="*" Width="93px" />
            <br />
            <br />
            <asp:Label ID="Label3" runat="server" Text="The Result : "></asp:Label>
            <asp:Label ID="Label4" runat="server"></asp:Label>
            <br />

        </div>
    </form>
</body>
</html>