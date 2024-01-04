<%@ Page Language="C#" AutoEventWireup="true" CodeBehind="WebForm.aspx.cs" Inherits="Exercise2.WebForm" %>

<!DOCTYPE html>

<html xmlns="http://www.w3.org/1999/xhtml">
<head runat="server">
    <title></title>
</head>
<body>
    <form id="form1" runat="server">
        <div>
            <asp:TextBox ID="TextBoxA" runat="server" Text="A" style="height: 26px" /> 
            <asp:TextBox ID="TextBoxB" runat="server" Text="B" style="height: 26px" /> 
            <asp:Button ID="ButtonCalculateAdd" runat="server" Text="CalculateAdd" OnClick="ButtonCalculateAdd_Click" 
style="height: 26px" /> 
            <asp:Button ID="ButtonCalculateSubtract" runat="server" Text="CalculateSubtract" OnClick="ButtonCalculateSubtract_Click" 
style="height: 26px" /> 
            <asp:Button ID="ButtonCalculateMultiphy" runat="server" Text="CalculateMultiphy" OnClick="ButtonCalculateMultiphy_Click" 
style="height: 26px" />
            <asp:Button ID="ButtonCalculateDivide" runat="server" Text="CalculateDivide" OnClick="ButtonCalculateDivide_Click" 
style="height: 26px" />
            <asp:Label ID="ResultLabel" runat="server" Text="Label"></asp:Label>   
        </div>
    </form>
</body>
</html>
