<%@ Page Language="C#" AutoEventWireup="true" CodeBehind="WebForm1.aspx.cs" Inherits="WebAppHomework.WebForm1" %>

<!DOCTYPE html>

<html xmlns="http://www.w3.org/1999/xhtml">
<head runat="server">
    <title>Registration form</title>
</head>
<body:background:colour="blue">
    <form id="form1" runat="server">
        <div>
            <asp:Label Text="Username" Font-Italic="true" ID="label1" runat="server"  />
            <asp:TextBox runat="server" ID="textbox1" />
            <br></br>
            <asp:Label Text="Password" Font-Italic="true" ID="label2" runat="server" />
            <asp:TextBox runat="server" ID="textbox2" TextMode="Password" />
            <br></br>
            <asp:Label Text="Repeat Password" Font-Italic="true" ID="label3" runat="server" />
            <asp:TextBox runat="server" ID="textbox3" TextMode="Password" />
            <br></br>
            <asp:Label Text="Age" Font-Italic="true" ID="label4" runat="server" />
            <asp:TextBox runat="server" ID="textbox4" />
            <asp:RegularExpressionValidator ID="RegularExpressionValidator1" ControlToValidate="textbox4" runat="server" ErrorMessage="Only Numbers allowed" ValidationExpression="\d+"></asp:RegularExpressionValidator>
            <br></br>
            <asp:Label Text="E-mail" Font-Italic="true" ID="label5" runat="server" />
            <asp:TextBox runat="server" ID="textbox5" />
            <br></br>
            <asp:Button Text="Register" runat="server" ID="btn" Font-Size="Large" OnClick="btn_Click" />

        </div>
    </form>
</body:background:colour="">
</html>
