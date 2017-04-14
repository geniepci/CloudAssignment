<%@ Page Language="C#" AutoEventWireup="true" CodeBehind="GamePage.aspx.cs" Inherits="TopTrumps.GamePage" %>

<!DOCTYPE html>

<html xmlns="http://www.w3.org/1999/xhtml">
<head runat="server">
    <title></title>
    <style>
        background-color {color: hotpink;}
        .auto-style1 {
            width: 100%;
        }
        .auto-style2 {
            height: 4px;
        }
        .auto-style3 {
            height: 26px;
        }
        .auto-style4 {
            height: 119px;
        }
        .auto-style9 {
            width: 236px;
        }
        .auto-style10 {
            height: 26px;
            width: 236px;
        }
        .auto-style11 {
            height: 4px;
            width: 236px;
        }
        .auto-style12 {
            height: 119px;
            width: 236px;
        }
        .auto-style17 {
            width: 206px;
        }
        .auto-style18 {
            height: 26px;
            width: 206px;
        }
        .auto-style19 {
            height: 4px;
            width: 206px;
        }
        .auto-style20 {
            height: 119px;
            width: 206px;
        }
        .auto-style25 {
            width: 144px;
        }
        .auto-style26 {
            height: 26px;
            width: 144px;
        }
        .auto-style27 {
            height: 4px;
            width: 144px;
        }
        .auto-style28 {
            height: 119px;
            width: 144px;
        }
        .auto-style29 {
            width: 202px;
        }
        .auto-style30 {
            height: 26px;
            width: 202px;
        }
        .auto-style31 {
            height: 4px;
            width: 202px;
        }
        .auto-style32 {
            height: 119px;
            width: 202px;
        }
    </style>
</head>
<body>
    <form id="form1" runat="server">
        <table class="auto-style1">
            <tr>
                <td class="auto-style25">&nbsp;</td>
                <td class="auto-style29">&nbsp;</td>
                <td class="auto-style17">TOP TRUMPS</td>
                <td class="auto-style9">&nbsp;</td>
                <td>&nbsp;</td>
            </tr>
            <tr>
                <td class="auto-style25">
                    &nbsp;</td>
                <td class="auto-style29">
                    &nbsp;</td>
                <td class="auto-style17">
                    <asp:Label ID="gameName" runat="server"></asp:Label>
                </td>
                <td class="auto-style9">
                    &nbsp;</td>
                <td>
                    &nbsp;</td>
            </tr>
            <tr>
                <td class="auto-style25">&nbsp;</td>
                <td class="auto-style29">Card Name</td>
                <td class="auto-style17">&nbsp;</td>
                <td class="auto-style9">Card Name</td>
                <td>&nbsp;</td>
            </tr>
            <tr>
                <td class="auto-style25">&nbsp;</td>
                <td class="auto-style29">
                    <asp:Label ID="cardNamePlayerOne" runat="server"></asp:Label>
                </td>
                <td class="auto-style17">&nbsp;</td>
                <td class="auto-style9">
                    <asp:Label ID="cardNamePlayerTwo" runat="server"></asp:Label>
                </td>
                <td>&nbsp;</td>
            </tr>
            <tr>
                <td class="auto-style25">&nbsp;</td>
                <td class="auto-style29">&nbsp;</td>
                <td class="auto-style17">&nbsp;</td>
                <td class="auto-style9">&nbsp;</td>
                <td>&nbsp;</td>
            </tr>
            <tr>
                <td class="auto-style25">
                    <asp:Button ID="Button1" runat="server" OnClick="Button2_Click" Text="PLAYER ONE WINS" />
                </td>
                <td class="auto-style29">
                    <asp:Label ID="attributeOneNamePlayerOne" runat="server"></asp:Label>
                </td>
                <td class="auto-style17">&nbsp;</td>
                <td class="auto-style9">
                    <asp:Label ID="attributeOneNamePlayerTwo" runat="server"></asp:Label>
                </td>
                <td>
                    <asp:Button ID="Button2" runat="server" Text="PLAYER TWO WINS" />
                </td>
            </tr>
            <tr>
                <td class="auto-style25">&nbsp;</td>
                <td class="auto-style29">
                    <asp:Label ID="attributeOneValuePlayerOne" runat="server"></asp:Label>
                </td>
                <td class="auto-style17">&nbsp;</td>
                <td class="auto-style9">
                    <asp:Label ID="attributeOneValuePlayerTwo" runat="server"></asp:Label>
                </td>
                <td>&nbsp;</td>
            </tr>
            <tr>
                <td class="auto-style25">&nbsp;</td>
                <td class="auto-style29">&nbsp;</td>
                <td class="auto-style17">&nbsp;</td>
                <td class="auto-style9">&nbsp;</td>
                <td>&nbsp;</td>
            </tr>
            <tr>
                <td class="auto-style25">
                    &nbsp;</td>
                <td class="auto-style29">
                    <asp:Label ID="attributeTwoNamePlayerOne" runat="server"></asp:Label>
                </td>
                <td class="auto-style17">
                    &nbsp;</td>
                <td class="auto-style9">
                    <asp:Label ID="attributeTwoNamePlayerTwo" runat="server"></asp:Label>
                </td>
                <td>&nbsp;</td>
            </tr>
            <tr>
                <td class="auto-style25">&nbsp;</td>
                <td class="auto-style29">
                    <asp:Label ID="attributeTwoValuePlayerOne" runat="server"></asp:Label>
                </td>
                <td class="auto-style17">&nbsp;</td>
                <td class="auto-style9">
                    <asp:Label ID="attributeTwoValuePlayerTwo" runat="server"></asp:Label>
                </td>
                <td>&nbsp;</td>
            </tr>
            <tr>
                <td class="auto-style25">&nbsp;</td>
                <td class="auto-style29">&nbsp;</td>
                <td class="auto-style17">
                    <asp:Label ID="Label1" runat="server"></asp:Label>
                </td>
                <td class="auto-style9">&nbsp;</td>
                <td>&nbsp;</td>
            </tr>
            <tr>
                <td class="auto-style26">
                    </td>
                <td class="auto-style30">
                    <asp:Label ID="attributeThreeNamePlayerOne" runat="server"></asp:Label>
                </td>
                <td class="auto-style18">&nbsp;</td>
                <td class="auto-style10">
                    <asp:Label ID="attributeThreeNamePlayerTwo" runat="server"></asp:Label>
                </td>
                <td class="auto-style3"></td>
            </tr>
            <tr>
                <td class="auto-style25">&nbsp;</td>
                <td class="auto-style29">
                    <asp:Label ID="attributeThreeValuePlayerOne" runat="server"></asp:Label>
                </td>
                <td class="auto-style17">&nbsp;</td>
                <td class="auto-style9">
                    <asp:Label ID="attributeThreeValuePlayerTwo" runat="server"></asp:Label>
                </td>
                <td>&nbsp;</td>
            </tr>
            <tr>
                <td class="auto-style26"></td>
                <td class="auto-style30"></td>
                <td class="auto-style18"></td>
                <td class="auto-style10"></td>
                <td class="auto-style3"></td>
            </tr>
            <tr>
                <td class="auto-style27">
                    &nbsp;</td>
                <td class="auto-style31">
                    <asp:Label ID="attributeFourNamePlayerOne" runat="server"></asp:Label>
                </td>
                <td class="auto-style19">&nbsp;</td>
                <td class="auto-style11">
                    <asp:Label ID="attributeFourNamePlayerTwo" runat="server"></asp:Label>
                </td>
                <td class="auto-style2"></td>
            </tr>
            <tr>
                <td class="auto-style25">
                    &nbsp;</td>
                <td class="auto-style29">
                    <asp:Label ID="attributeFourValuePlayerOne" runat="server"></asp:Label>
                </td>
                <td class="auto-style17">&nbsp;</td>
                <td class="auto-style9">
                    <asp:Label ID="attributeFourValuePlayerTwo" runat="server"></asp:Label>
                </td>
                <td>&nbsp;</td>
            </tr>
            <tr>
                <td class="auto-style26">
                    </td>
                <td class="auto-style30">
                    </td>
                <td class="auto-style18"></td>
                <td class="auto-style10">
                    </td>
                <td class="auto-style3"></td>
            </tr>
            <tr>
                <td class="auto-style25">
                    &nbsp;</td>
                <td class="auto-style29">
                    <asp:Label ID="attributeFiveNamePlayerOne" runat="server"></asp:Label>
                </td>
                <td class="auto-style17">&nbsp;</td>
                <td class="auto-style9">
                    <asp:Label ID="attributeFiveNamePlayerTwo" runat="server"></asp:Label>
                </td>
                <td>&nbsp;</td>
            </tr>
            <tr>
                <td class="auto-style25">
                    &nbsp;</td>
                <td class="auto-style29">
                    <asp:Label ID="attributeFiveValuePlayerOne" runat="server"></asp:Label>
                </td>
                <td class="auto-style17">&nbsp;</td>
                <td class="auto-style9">
                    <asp:Label ID="attributeFiveValuePlayerTwo" runat="server"></asp:Label>
                </td>
                <td>&nbsp;</td>
            </tr>
            <tr>
                <td class="auto-style25">
                    &nbsp;</td>
                <td class="auto-style29">
                    &nbsp;</td>
                <td class="auto-style17">&nbsp;</td>
                <td class="auto-style9">
                    &nbsp;</td>
                <td>&nbsp;</td>
            </tr>
            <tr>
                <td class="auto-style25">
                    &nbsp;</td>
                <td class="auto-style29">
                    <asp:ListBox ID="ListBox1" runat="server" Width="163px" Height="213px"></asp:ListBox>
                </td>
                <td class="auto-style17">
                    <asp:Button ID="Button3" runat="server" OnClick="Button3_Click" Text="NEXT CARD" />
                </td>
                <td class="auto-style9">
                    <asp:ListBox ID="ListBox2" runat="server" Width="145px" Height="204px"></asp:ListBox>
                </td>
                <td>&nbsp;</td>
            </tr>
            <tr>
                <td class="auto-style28">
                    </td>
                <td class="auto-style32">
                    &nbsp;</td>
                <td class="auto-style20">
                    &nbsp;</td>
                <td class="auto-style12"></td>
                <td class="auto-style4"></td>
            </tr>
            <tr>
                <td class="auto-style25">
                    &nbsp;</td>
                <td class="auto-style29">
                    &nbsp;</td>
                <td class="auto-style17">
                    &nbsp;</td>
                <td class="auto-style9">
                    &nbsp;</td>
                <td>&nbsp;</td>
            </tr>
        </table>
    </form>
    <p>
        &nbsp;</p>
</body>
</html>
