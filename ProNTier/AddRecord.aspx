<%@ Page Language="C#" AutoEventWireup="true" CodeBehind="AddRecord.aspx.cs" Inherits="TollPlusNTier.AddRecord" %>

<!DOCTYPE html>

<html xmlns="http://www.w3.org/1999/xhtml">
<head runat="server">
    <title>Add records</title>
</head>
<body>
    <form id="form1" runat="server">
    <div>
    <a href="default.aspx?get=adults">Adult Records</a> | 
        <a href="default.aspx?get=minor">Minor Records</a> |
        <a href="AddRecord.aspx">Add Records</a> 
        <hr />

        <p>
            <asp:Label ID="lblMessage" runat="server" EnableViewState="false" />
        </p>

        First name:
        <asp:TextBox runat="server" ID="txtFirstName" />
        <p>
            Last name:
        <asp:TextBox runat="server" ID="txtLastName" />
        </p>

        <p>
            Age:
        <asp:TextBox runat="server" ID="txtAge" />
        </p>

        <p>
            Active : 
        <asp:RadioButtonList runat="server" ID="radioActive" RepeatDirection="Horizontal" RepeatLayout="Flow">
            <asp:ListItem Text="Yes" Value="true" />
            <asp:ListItem Text="No" Value="false" />
        </asp:RadioButtonList>
        </p>
        <p>
            <asp:Button ID="btnSubmit" runat="server" Text="Submit" OnClick="btnSubmit_Click" />
        </p>

    </div>
    </form>
</body>
</html>
