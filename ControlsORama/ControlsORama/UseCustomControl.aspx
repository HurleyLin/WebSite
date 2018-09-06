<%@ Page Language="C#" AutoEventWireup="true" CodeBehind="UseCustomControl.aspx.cs" Inherits="ControlsORama.UseCustomControl" %>

<%@ Register assembly="CustomControLib,Version=1.0.0.0, Culture=neutral, PublicKeyToken=null" namespace="CustomControLib" tagprefix="cc1" %>

<!DOCTYPE html PUBLIC "-//W3C//DTD XHTML 1.0 Transitional//EN" "http://www.w3.org/TR/xhtml1/DTD/xhtml1-transitional.dtd">

<html xmlns="http://www.w3.org/1999/xhtml">
<head runat="server">
    <title></title>
</head>
<body>
    <form id="form1" runat="server">
    <div>
    
        <cc1:ServerControl1 ID="ServerControl11" runat="server" 
            Text="When you set the control's property, it shows up in the designer..." />
    
    </div>
    <asp:Label ID="Label1" runat="server" Text="type someting here:"></asp:Label>
    <asp:TextBox ID="TextBox1" runat="server"></asp:TextBox>
    <br />
    <asp:Button ID="Button1" runat="server" onclick="Button1_Click" 
        Text="set control text" />
    </form>
</body>
</html>
