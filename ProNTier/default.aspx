<%@ Page Language="C#" AutoEventWireup="true" CodeBehind="default.aspx.cs" Inherits="ProNTier._default" %>

<!DOCTYPE html>

<html xmlns="http://www.w3.org/1999/xhtml">
<head runat="server">
    <title>List data</title>
</head>
<body>
    <form id="form1" runat="server">
    <div>
        <a href="default.aspx?get=adults">Adult Records</a> | 
        <a href="default.aspx?get=minor">Minor Records</a> |
        <a href="AddRecord.aspx">Add Records</a> 
        <hr />
        <asp:GridView ID="GridView1" runat="server" EnableViewState="false" />
    </div>
    </form>
</body>
</html>
