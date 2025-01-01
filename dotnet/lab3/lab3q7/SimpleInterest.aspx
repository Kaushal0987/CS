<%@ Page Language="C#" AutoEventWireup="true" CodeBehind="SimpleInterest.aspx.cs" Inherits="WebApplication1.SimpleInterest" %>

<!DOCTYPE html>
<html xmlns="http://www.w3.org/1999/xhtml">
<head runat="server">
    <title>Simple Interest Calculator</title>
</head>
<body>
    <form id="form1" runat="server">
        <div style="margin: 20px;">
            <h2>Simple Interest Calculator</h2>
            <label>Principal Amount:</label>
            <asp:TextBox ID="txtPrincipal" runat="server" TextMode="Number"></asp:TextBox>
            <br /><br />

            <label>Rate of Interest (%):</label>
            <asp:TextBox ID="txtRate" runat="server" TextMode="Number"></asp:TextBox>
            <br /><br />

            <label>Time (in years):</label>
            <asp:TextBox ID="txtTime" runat="server" TextMode="Number"></asp:TextBox>
            <br /><br />

            <asp:Button ID="btnCalculate" runat="server" Text="Calculate Interest" OnClick="btnCalculate_Click" />
            <br /><br />

            <asp:Label ID="lblResult" runat="server" Text="" Font-Bold="true" ForeColor="Green"></asp:Label>
        </div>
    </form>
</body>
</html>
