<%@ Page Language="C#" AutoEventWireup="true" CodeBehind="WordManager.aspx.cs" Inherits="SampleWebFormsApp.WordManager" %>

<!DOCTYPE html>

<html xmlns="http://www.w3.org/1999/xhtml">
<head runat="server">
    <title></title>
</head>
<body>
    <form id="form1" runat="server">
        <div>
             <asp:ScriptManager runat="server" />
            <h2>Search Word</h2>
            <asp:TextBox ID="txtSearch" runat="server" />
            <asp:Button ID="btnSearch" runat="server" Text="Search" OnClick="btnSearch_Click" />
            <asp:Label ID="lblSearchResult" runat="server" ForeColor="Red" />

            <hr />

            <h2>Add Translation</h2>
            <asp:Label ID="lblWordToTranslate" runat="server" />
            <asp:TextBox ID="txtTranslation" runat="server" />
            <asp:Button ID="btnAddTranslation" runat="server" Text="Add to My Words" OnClick="btnAddTranslation_Click" />

            <hr />

            <h2>My Words</h2>
            <asp:GridView ID="gvWords" runat="server" AutoGenerateColumns="False">
                <Columns>
                    <asp:BoundField DataField="Key" HeaderText="Word" />
                    <asp:BoundField DataField="Value" HeaderText="Translation" />
                </Columns>
            </asp:GridView>
        </div>
    </form>
</body>
</html>
