<%@ Page Language="C#" AutoEventWireup="true" CodeBehind="Home.aspx.cs" Inherits="ExamTask.Home" %>

<!DOCTYPE html>

<html xmlns="http://www.w3.org/1999/xhtml">
<head runat="server">
    <title>Home Page</title>
</head>
<body>
    <form id="form1" runat="server">
        <div>
            <asp:Label Text="Welcome" runat="server" ID="label"  />
            <br />
            <br />
            <asp:Label Text="Add Country" runat="server"  />
            <asp:TextBox runat="server" ID="txtB1" />
            <br />
            <br />
            <asp:Label Text="Add Capital" runat="server"  />
            <asp:TextBox runat="server" ID="txtB2" />
            <br />
            <br />
            <asp:Label Text="Add population"  runat="server"  />
            <asp:TextBox runat="server" ID="txtB3" TextMode="Number" />
            <br />
            <br />
            <asp:Button Text="Add" runat="server" id="addBtn" OnClick="addBtn_Click"/>
            <br />
            <br />
        <asp:LinkButton Text="Search" runat="server" PostBackUrl="~/SearchForm.aspx"/>
        </div>
    </form>
</body>
</html>
