<%@ Page Language="C#" AutoEventWireup="true" CodeBehind="Defalut.aspx.cs" Inherits="Lab12.Defalut" %>

<!DOCTYPE html>

<html xmlns="http://www.w3.org/1999/xhtml">
<head runat="server">
    <title></title>
</head>
<body>
    <form id="form1" runat="server">
        <div>
    
                <asp:TextBox ID="txtSearch" runat="server"></asp:TextBox>
                <br />
                <asp:Button ID="btnSearch" runat="server" OnClick="Search_Click" Text="Search" />
                <br />
                <asp:Label ID="lblError" runat="server" Text="Error"></asp:Label>
    
                <asp:GridView runat="server" ID="GridView1" OnSelectedIndexChanged="GridView1_SelectedIndexChanged"></asp:GridView>
                <br />
        </div>
    </form>
</body>
</html>
