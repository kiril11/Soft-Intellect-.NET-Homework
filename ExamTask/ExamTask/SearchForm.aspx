<%@ Page Language="C#" AutoEventWireup="true" CodeBehind="SearchForm.aspx.cs" Inherits="ExamTask.SearchForm" %>

<!DOCTYPE html>

<html xmlns="http://www.w3.org/1999/xhtml">
<head runat="server">
    <title>Search</title>
</head>
<body>
    <form id="form1" runat="server">
        <div>
            <asp:Label Text="Search for your country" runat="server" ID="label" />
            <br />
            <br />
            <asp:Label Text="Country" runat="server" />
            <asp:TextBox runat="server" ID="textBox" />
            <br />
            <br />
            <asp:Label Text="Capital" runat="server" />
            <asp:TextBox runat="server" ID="textBox1" />
            <br />
            <br />
            <asp:Label Text="Population" runat="server" />
            <asp:TextBox runat="server" ID="textBox2" TextMode="Number" />
            <br />
            <br />
            <asp:Button Text="Search" runat="server" ID="searchBtn" OnClick="searchBtn_Click" />
            <br />
            <br />
            <asp:LinkButton Text="Back" runat="server" PostBackUrl="~/Home.aspx" />
            <br />
            <br />
            <asp:Label Text="" runat="server" ID="labelCountry" />
            <br />
            <br />
            <asp:Label Text="" runat="server" ID="labelCapital" />
            <br />
            <br />
            <asp:Label Text="" runat="server" ID="labelPopulation" />
        </div>
    </form>
</body>
</html>
