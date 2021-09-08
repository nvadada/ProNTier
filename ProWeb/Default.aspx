<%@ Page Language="C#" AutoEventWireup="true" CodeFile="Default.aspx.cs" Inherits="_Default" %>

<!DOCTYPE html>

<html xmlns="http://www.w3.org/1999/xhtml">
<head runat="server">
    <title>Search Personal details</title>
    <style>
        body {
            font-family: 'Lucida Sans', 'Lucida Sans Regular', 'Lucida Grande', 'Lucida Sans Unicode', Geneva, Verdana, sans-serif;
        }

        table {
            border: 1px solid #ff6a00;
            border-collapse: collapse;
        }

        td, th {
            border: 1px solid #ff6a00;
            padding: 5px;
        }

        tr:nth-child(even) {
            background-color: #e6f7bb;
        }
    </style>

    <script>
        function CallMePlease(message) {
            alert(message);
        }
    </script>

</head>
<body>
    <form id="form1" runat="server">
        <p>
            <asp:Label ID="lblMessage1" runat="server" EnableViewState="false" />
        </p>

        Search records whose first name starts with :
        <asp:TextBox ID="txtFirstName" runat="server" />
        <asp:Button ID="btnSearch" runat="server" Text="Search" OnClick="btnSearch_Click" />
        <hr />
        <div>
            <asp:GridView ID="GridView1" runat="server" EnableViewState="false" />

        </div>
    </form>
</body>
</html>
