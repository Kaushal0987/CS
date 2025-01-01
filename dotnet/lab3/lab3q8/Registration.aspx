<%@ Page Language="C#" AutoEventWireup="true" CodeBehind="Registration.aspx.cs" Inherits="WebApplication1.Registration" %>

<!DOCTYPE html>
<html xmlns="http://www.w3.org/1999/xhtml">
<head runat="server">
    <title>Registration Form</title>
</head>
<body>
    <form id="form1" runat="server">
        <div style="margin: 20px;">
            <h2>Registration Form</h2>
            
            <!-- Full Name -->
            <label>Full Name:</label><br />
            <asp:TextBox ID="txtName" runat="server" />
            <asp:RequiredFieldValidator ID="rfvName" runat="server" ControlToValidate="txtName"
                ErrorMessage="Name is required." ForeColor="Red" Display="Dynamic" />
            <asp:RegularExpressionValidator ID="revName" runat="server" ControlToValidate="txtName"
                ErrorMessage="Name cannot contain numbers or symbols."
                ValidationExpression="^[a-zA-Z\s]+$" ForeColor="Red" Display="Dynamic" />
            <br /><br />

            <!-- Email -->
            <label>Email:</label><br />
            <asp:TextBox ID="txtEmail" runat="server" TextMode="Email" />
            <asp:RequiredFieldValidator ID="rfvEmail" runat="server" ControlToValidate="txtEmail"
                ErrorMessage="Email is required." ForeColor="Red" Display="Dynamic" />
            <asp:RegularExpressionValidator ID="revEmail" runat="server" ControlToValidate="txtEmail"
                ErrorMessage="Invalid Email Format." 
                ValidationExpression="^[^@\s]+@[^@\s]+\.[^@\s]+$" ForeColor="Red" Display="Dynamic" />
            <br /><br />

            <!-- Password -->
            <label>Password:</label><br />
            <asp:TextBox ID="txtPassword" runat="server" TextMode="Password" />
            <asp:RequiredFieldValidator ID="rfvPassword" runat="server" ControlToValidate="txtPassword"
                ErrorMessage="Password is required." ForeColor="Red" Display="Dynamic" />
            <asp:RegularExpressionValidator ID="revPassword" runat="server" ControlToValidate="txtPassword"
                ErrorMessage="Password must be at least 8 characters long."
                ValidationExpression="^.{8,}$" ForeColor="Red" Display="Dynamic" />
            <br /><br />

            <!-- Submit Button -->
            <asp:Button ID="btnSubmit" runat="server" Text="Submit" OnClick="btnSubmit_Click" />
            <br /><br />

            <!-- Success Message -->
            <asp:Label ID="lblResult" runat="server" ForeColor="Green" Font-Bold="true" />
        </div>
    </form>
</body>
</html>
