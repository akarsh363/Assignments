<%@ Page Language="C#" AutoEventWireup="true" CodeBehind="Register.aspx.cs" Inherits="SampleWebFormsApp.Register" %>

<!DOCTYPE html>
<html xmlns="http://www.w3.org/1999/xhtml">
<head runat="server">
    <title>User Registration</title>
    <link href="https://cdn.jsdelivr.net/npm/bootstrap@5.3.0/dist/css/bootstrap.min.css" rel="stylesheet" />
    <style>
        .error {
            color: red;
            font-size: 0.9em;
        }
        .form-container {
            width: 400px;
            margin: 50px auto;
            padding: 20px;
            border: 1px solid #ccc;
            border-radius: 8px;
            background-color: #f9f9f9;
        }
    </style>
</head>
<body>
    <form id="form1" runat="server">
        <div class="form-container">
            <h2 class="text-center">Register</h2>

            <div class="mb-3">
                <label for="txtName" class="form-label">Name:</label>
                <asp:TextBox ID="txtName" runat="server" CssClass="form-control" />
                <asp:RequiredFieldValidator ID="rfvName" runat="server"
                    ControlToValidate="txtName" ErrorMessage="Name is required"
                    CssClass="error" Display="Dynamic" />
            </div>

            <div class="mb-3">
                <label for="txtEmail" class="form-label">Email:</label>
                <asp:TextBox ID="txtEmail" runat="server" CssClass="form-control" />
                <asp:RequiredFieldValidator ID="rfvEmail" runat="server"
                    ControlToValidate="txtEmail" ErrorMessage="Email is required"
                    CssClass="error" Display="Dynamic" />
                <asp:RegularExpressionValidator ID="revEmail" runat="server"
                    ControlToValidate="txtEmail"
                    ErrorMessage="Invalid email format"
                    CssClass="error"
                    Display="Dynamic"
                    ValidationExpression="^\w+@[a-zA-Z_]+?\.[a-zA-Z]{2,3}$" />
            </div>

            <div class="mb-3">
                <label for="txtPassword" class="form-label">Password:</label>
                <asp:TextBox ID="txtPassword" runat="server" TextMode="Password" CssClass="form-control" />
                <asp:RequiredFieldValidator ID="rfvPassword" runat="server"
                    ControlToValidate="txtPassword" ErrorMessage="Password is required"
                    CssClass="error" Display="Dynamic" />
            </div>

            <div class="mb-3 text-center">
                <asp:Button ID="btnSave" runat="server" Text="Save" CssClass="btn btn-primary" OnClick="btnSave_Click" />
            </div>

            <div class="text-center">
                <asp:Label ID="lblMessage" runat="server" CssClass="error" />
            </div>
        </div>
    </form>
</body>
</html>
