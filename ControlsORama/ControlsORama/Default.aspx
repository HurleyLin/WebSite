<%@ Page Language="C#" AutoEventWireup="true" CodeBehind="Default.aspx.cs" Inherits="ControlsORama.Default" %>

<!DOCTYPE html PUBLIC "-//W3C//DTD XHTML 1.0 Transitional//EN" "http://www.w3.org/TR/xhtml1/DTD/xhtml1-transitional.dtd">

<html xmlns="http://www.w3.org/1999/xhtml">
<head runat="server">
    <title></title>
    <style type="text/css">
        .新建样式1
        {
        }
        .新建样式2
        {
            position: fixed;
            z-index: inherit;
            bottom: inherit;
            left: 1px;
            right: 1px;
            top: 45px;
            width: 55px;
            height: 5px;
        }
    </style>
</head>
<body>
    <form id="form1" runat="server">
    <div style="font-size: 20pt; font-weight: 500; font-family: 'Calisto MT'">
    
        Page in Visual Studio<br />
        <asp:Label ID="Label2" runat="server" Text="type in me :"></asp:Label>
        <asp:TextBox ID="TextBox1" runat="server">HELLO WORLD</asp:TextBox>
        <br />
        <asp:DropDownList ID="DropDownList1" runat="server">
            <asp:ListItem>111</asp:ListItem>
            <asp:ListItem>222</asp:ListItem>
            <asp:ListItem>333</asp:ListItem>
            <asp:ListItem>444</asp:ListItem>
        </asp:DropDownList>
        <br />
        <asp:Button ID="Button1" runat="server" onclick="Button1_Click" 
            Text="click me" />
    
    </div>
    </form>
</body>
</html>
