<%@ Page Language="C#" AutoEventWireup="true" CodeBehind="Chocolates.aspx.cs" Inherits="QuestionNO2.Chocolates" %>

<!DOCTYPE html>

<html xmlns="http://www.w3.org/1999/xhtml">
<head runat="server">
    <title></title>
</head>
<body>
     <form id="form1" runat="server"  >
<div>
<h1 style=" color:deepskyblue"><center>CHOCOLATES</center></h1>
<br />
</div>
<h2 style="color:black;"><center>  CHOCOLATES: <asp:DropDownList ID="DropDownList1" runat="server" Height="25px" Width="180px" OnSelectedIndexChanged="DropDownList1_SelectedIndexChanged" AutoPostBack="True">
<asp:ListItem></asp:ListItem>

</asp:DropDownList></center></h2>
<br />

<center><asp:Image ID="Image1" runat="server" Height="225px" Width="275px" /></center>
<br />
<%--<asp:Button ID="Button1" runat="server" Text="Click to Check the Price" />--%>
<h2 style="color:purple;"><center>
<asp:Label ID="Label" runat="server" Text="Price: "></asp:Label></center></h2>
</form>
</body>
</html>
