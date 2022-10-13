<%@ Page Language="C#" AutoEventWireup="true"  CodeBehind="UserLogin.aspx.cs" Inherits="WebApplication1.UserLogin" %>

<!DOCTYPE html>

<html xmlns="http://www.w3.org/1999/xhtml">
<head runat="server">
    <title></title>
</head>
<body>
    <form id="form1" runat="server">
        <div>
            Enter your UserId&nbsp;&nbsp;&nbsp;&nbsp; :<asp:TextBox ID="namebox" runat="server" ToolTip="Enter the right name"></asp:TextBox>
            <br />
            <br />
            Enter your Password:<asp:TextBox ID="password" runat="server" ToolTip="Enter correct password"></asp:TextBox>
            <br />
            <br />
            <asp:Button ID="Button1" runat="server" OnClick="Button1_Click" Text="Submit" />
            <asp:TextBox ID="TextBox2" runat="server" ReadOnly="True"></asp:TextBox>

       </div>
    </form>
</body>
</html>
