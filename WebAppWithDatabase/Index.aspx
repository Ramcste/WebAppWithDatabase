<%@ Page Language="C#" AutoEventWireup="true" CodeBehind="Index.aspx.cs" Inherits="WebAppWithDatabase.Index" %>

<!DOCTYPE html>

<html xmlns="http://www.w3.org/1999/xhtml">
<head runat="server">
    <title></title>
</head>
<body>
    <form id="form1" runat="server">
    <div>
    
        <table>
          
                <tr>
                    <td>
                        Name:
                    </td>
                    <td>
                        <input type="text" id="nameInput" runat="server"/>
                    </td>
                </tr>
                
                <tr>
                    <td>
                        Email:
                    </td>
                    <td>
                        <input type="text" id="emailInput" runat="server"/>
                    </td>
                </tr>
                
                <tr>
                    <td>
                        Contact No:
                    </td>
                    <td>
                        <asp:TextBox type="text" id="contactNoTextBox" runat="server"/>
                    </td>
                </tr>

          
        </table>
        
        <asp:Button runat="server" ID="addButton" Text="Save" Width="80" OnClick="addButton_OnClick"/>
        <asp:Label runat="server" ID="Label1"></asp:Label>

    </div>
        <asp:GridView ID="studentGridView" runat="server">
        </asp:GridView>
    </form>
</body>
</html>
