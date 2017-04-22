<%@ Page Language="C#" AutoEventWireup="true" CodeBehind="HomePage.aspx.cs" Inherits="TopTrumps.HomePage1" %>

<!DOCTYPE html>

<html xmlns="http://www.w3.org/1999/xhtml">
<head runat="server">
    <title></title>
    <style type="text/css">
        .auto-style1 {
            text-align: center;
            font-size: xx-large;
            color: #0000FF;
        }
        .auto-style2 {
            width: 100%;
        }
        .auto-style3 {
            width: 221px;
        }
        .auto-style4 {
            width: 354px;
            text-align: center;
        }
        .auto-style5 {
            text-align: center;
            width: 389px;
        }
    </style>
</head>
<body>
    <form id="form1" runat="server">
    <div class="auto-style1">
    
    </div>
        <table class="auto-style2">
            <tr>
                <td class="auto-style3">&nbsp;</td>
                <td class="auto-style1" colspan="2"><strong>TOP TRUMPS</strong></td>
                <td>&nbsp;</td>
            </tr>
            <tr>
                <td class="auto-style3">&nbsp;</td>
                <td class="auto-style5">&nbsp;</td>
                <td class="auto-style4">&nbsp;</td>
                <td>&nbsp;</td>
            </tr>
            <tr>
                <td class="auto-style3">&nbsp;</td>
                <td class="auto-style5">&nbsp;</td>
                <td class="auto-style4">&nbsp;</td>
                <td>&nbsp;</td>
            </tr>
            <tr>
                <td class="auto-style3">&nbsp;</td>
                <td class="auto-style5">&nbsp;</td>
                <td class="auto-style4">&nbsp;</td>
                <td>&nbsp;</td>
            </tr>
            <tr>
                <td class="auto-style3">&nbsp;</td>
                <td class="auto-style5">
                    <asp:Button ID="Button1" runat="server" OnClick="Button1_Click" Text="PLAY GAME" />
                </td>
                <td class="auto-style4">
                    <asp:Button ID="Button3" runat="server" OnClick="Button3_Click" Text="ADD PLAYERS" />
                </td>
                <td>&nbsp;</td>
            </tr>
            <tr>
                <td class="auto-style3">&nbsp;</td>
                <td class="auto-style5">&nbsp;</td>
                <td class="auto-style4">&nbsp;</td>
                <td>&nbsp;</td>
            </tr>
            <tr>
                <td class="auto-style3">&nbsp;</td>
                <td class="auto-style5">
                    <asp:Button ID="Button2" runat="server" Text="VIEW HIGH SCORES" />
                </td>
                <td class="auto-style4">
                    <asp:Button ID="Button5" runat="server" Text="ADD CARDS/CATEGORIES" />
                </td>
                <td>&nbsp;</td>
            </tr>
            <tr>
                <td class="auto-style3">&nbsp;</td>
                <td class="auto-style5">&nbsp;</td>
                <td class="auto-style4">&nbsp;</td>
                <td>&nbsp;</td>
            </tr>
            <tr>
                <td colspan="4">
                    <asp:Image ID="Image1" runat="server" />
                    <asp:DataList ID="DataList1" runat="server" DataSourceID="ObjectDataSource2" Height="200px" RepeatDirection="Horizontal">
                        <ItemTemplate>
                            <asp:Image ID="Image2" runat="server" Height="100px" ImageUrl='<%# Eval("ImageURI") %>' Width="100px" />
                            <br />
                            &nbsp;<asp:Label ID="NameLabel" runat="server" Text='<%# Eval("Name") %>' />
                            <br />
                            <br />
                            <br />
                        </ItemTemplate>
                    </asp:DataList>
                    <asp:ObjectDataSource ID="ObjectDataSource2" runat="server" SelectMethod="GetCategories" TypeName="TopTrumps.DeveloperPage"></asp:ObjectDataSource>
                </td>
            </tr>
        </table>
    </form>
</body>
</html>
