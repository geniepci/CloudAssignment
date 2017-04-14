<%@ Page Language="C#" AutoEventWireup="true" CodeBehind="GamePage.aspx.cs" Inherits="TopTrumps.GamePage" %>

<!DOCTYPE html>

<html xmlns="http://www.w3.org/1999/xhtml">
<head runat="server">
    <title></title>
    <style>
        background-color {color: hotpink;}
        .auto-style1 {
            width: 100%;
            background-color: #FFFFFF;
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
            background-color: #FFFFFF;
        }
        .auto-style10 {
            height: 26px;
            width: 236px;
            background-color: #FFFFFF;
        }
        .auto-style11 {
            height: 4px;
            width: 236px;
            background-color: #FFFFFF;
        }
        .auto-style12 {
            height: 119px;
            width: 236px;
            background-color: #FFFFFF;
        }
        .auto-style17 {
            width: 463px;
        }
        .auto-style18 {
            height: 26px;
            width: 463px;
        }
        .auto-style19 {
            height: 4px;
            width: 463px;
        }
        .auto-style20 {
            height: 119px;
            width: 463px;
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
            background-color: #FFFFFF;
        }
        .auto-style30 {
            height: 26px;
            width: 202px;
            background-color: #FFFFFF;
        }
        .auto-style31 {
            height: 4px;
            width: 202px;
            background-color: #FFFFFF;
        }
        .auto-style32 {
            height: 119px;
            width: 202px;
            background-color: #FFFFFF;
        }
        .auto-style33 {
            width: 144px;
            height: 33px;
        }
        .auto-style34 {
            width: 202px;
            height: 33px;
            background-color: #FFFFFF;
        }
        .auto-style35 {
            width: 463px;
            height: 33px;
        }
        .auto-style36 {
            width: 236px;
            height: 33px;
            background-color: #FFFFFF;
        }
        .auto-style37 {
            height: 33px;
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
                <td class="auto-style25">&nbsp;</td>
                <td class="auto-style29">
                    <asp:Button ID="Button1" runat="server" OnClick="Button2_Click" Text="PLAYER ONE WINS" />
                </td>
                <td class="auto-style17">
                    <asp:Label ID="gameName" runat="server"></asp:Label>
                </td>
                <td class="auto-style9">
                    <asp:Button ID="Button2" runat="server" Text="PLAYER TWO WINS" />
                </td>
                <td>&nbsp;</td>
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
                <td>
                    &nbsp;</td>
            </tr>
            <tr>
                <td class="auto-style25">
                    &nbsp;</td>
                <td class="auto-style29">
                    <asp:Image ID="Image1" runat="server" Height="250px" Width="250px" />
                </td>
                <td class="auto-style17">
                    <asp:Label ID="Label1" runat="server"></asp:Label>
                </td>
                <td class="auto-style9">
                    <asp:Image ID="Image2" runat="server" Height="250px" Width="250px" />
                </td>
                <td>
                    &nbsp;</td>
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
                <td class="auto-style33">
                </td>
                <td class="auto-style34">
                    <asp:Button ID="playerOneButtonOne" runat="server" Text="Button" Height="40px" Width="250px" />
                </td>
                <td class="auto-style35"></td>
                <td class="auto-style36">
                    <asp:Button ID="playerTwoButtonOne" runat="server" Height="40px" Text="Button" Width="250px" />
                </td>
                <td class="auto-style37">
                    &nbsp;</td>
            </tr>
            <tr>
                <td class="auto-style25">&nbsp;</td>
                <td class="auto-style29">
                    &nbsp;</td>
                <td class="auto-style17">&nbsp;</td>
                <td class="auto-style9">
                    &nbsp;</td>
                <td>&nbsp;</td>
            </tr>
            <tr>
                <td class="auto-style25">&nbsp;</td>
                <td class="auto-style29">
                    <asp:Button ID="playerOneButtonTwo" runat="server" Height="40px" Text="Button" Width="250px" />
                </td>
                <td class="auto-style17">&nbsp;</td>
                <td class="auto-style9">
                    <asp:Button ID="playerTwoButtonTwo" runat="server" Height="40px" Text="Button" Width="250px" />
                </td>
                <td>&nbsp;</td>
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
                <td>
                    &nbsp;</td>
            </tr>
            <tr>
                <td class="auto-style25">&nbsp;</td>
                <td class="auto-style29">
                    <asp:Button ID="playerOneButtonThree" runat="server" Height="40px" Text="Button" Width="250px" />
                </td>
                <td class="auto-style17">&nbsp;</td>
                <td class="auto-style9">
                    <asp:Button ID="playerTwoButtonThree" runat="server" Height="40px" Text="Button" Width="250px" />
                </td>
                <td class="auto-style36">
                    <asp:Label ID="attributeOneNamePlayerTwo" runat="server"></asp:Label>
                </td>
            </tr>
            <tr>
                <td class="auto-style25">&nbsp;</td>
                <td class="auto-style29">&nbsp;</td>
                <td class="auto-style17">
                    &nbsp;</td>
                <td class="auto-style9">&nbsp;</td>
                <td class="auto-style9">
                    <asp:Label ID="attributeOneValuePlayerTwo" runat="server"></asp:Label>
                </td>
            </tr>
            <tr>
                <td class="auto-style26">
                    &nbsp;</td>
                <td class="auto-style30">
                    <asp:Button ID="playerOneButtonFour" runat="server" Height="40px" Text="Button" Width="250px" />
                </td>
                <td class="auto-style18">&nbsp;</td>
                <td class="auto-style10">
                    <asp:Button ID="playerTwoButtonFour" runat="server" Height="40px" Text="Button" Width="250px" />
                </td>
                <td class="auto-style9">&nbsp;</td>
            </tr>
            <tr>
                <td class="auto-style25">&nbsp;</td>
                <td class="auto-style29">
                    &nbsp;</td>
                <td class="auto-style17">&nbsp;</td>
                <td class="auto-style9">
                    &nbsp;</td>
                <td class="auto-style9">
                    <asp:Label ID="attributeTwoNamePlayerTwo" runat="server"></asp:Label>
                </td>
            </tr>
            <tr>
                <td class="auto-style26"></td>
                <td class="auto-style30">
                    <asp:Button ID="playerOneButtonFive" runat="server" Height="40px" Text="Button" Width="250px" />
                </td>
                <td class="auto-style18"></td>
                <td class="auto-style10">
                    <asp:Button ID="playerTwoButtonFive" runat="server" Height="40px" Text="Button" Width="250px" />
                </td>
                <td class="auto-style9">
                    <asp:Label ID="attributeTwoValuePlayerTwo" runat="server"></asp:Label>
                </td>
            </tr>
            <tr>
                <td class="auto-style27">
                    &nbsp;</td>
                <td class="auto-style31">
                    &nbsp;</td>
                <td class="auto-style19">&nbsp;</td>
                <td class="auto-style11">
                    &nbsp;</td>
                <td class="auto-style9">&nbsp;</td>
            </tr>
            <tr>
                <td class="auto-style25">
                    &nbsp;</td>
                <td class="auto-style29">
                    &nbsp;</td>
                <td class="auto-style17">&nbsp;</td>
                <td class="auto-style9">
                    &nbsp;</td>
                <td class="auto-style10">
                    <asp:Label ID="attributeThreeNamePlayerTwo" runat="server"></asp:Label>
                </td>
            </tr>
            <tr>
                <td class="auto-style26">
                    </td>
                <td class="auto-style30">
                    </td>
                <td class="auto-style18"></td>
                <td class="auto-style10">
                    </td>
                <td class="auto-style9">
                    <asp:Label ID="attributeThreeValuePlayerTwo" runat="server"></asp:Label>
                </td>
            </tr>
            <tr>
                <td class="auto-style25">
                    &nbsp;</td>
                <td class="auto-style29">
                    &nbsp;</td>
                <td class="auto-style17">&nbsp;</td>
                <td class="auto-style9">
                    &nbsp;</td>
                <td class="auto-style10"></td>
            </tr>
            <tr>
                <td class="auto-style25">
                    &nbsp;</td>
                <td class="auto-style29">
                    &nbsp;</td>
                <td class="auto-style17">&nbsp;</td>
                <td class="auto-style9">
                    &nbsp;</td>
                <td class="auto-style11">
                    <asp:Label ID="attributeFourNamePlayerTwo" runat="server"></asp:Label>
                </td>
            </tr>
            <tr>
                <td class="auto-style25">
                    &nbsp;</td>
                <td class="auto-style29">
                    &nbsp;</td>
                <td class="auto-style17">&nbsp;</td>
                <td class="auto-style9">
                    &nbsp;</td>
                <td class="auto-style9">
                    <asp:Label ID="attributeFourValuePlayerTwo" runat="server"></asp:Label>
                </td>
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
                <td class="auto-style10">
                    </td>
            </tr>
            <tr>
                <td class="auto-style28">
                    </td>
                <td class="auto-style32">
                    &nbsp;</td>
                <td class="auto-style20">
                    &nbsp;</td>
                <td class="auto-style12"></td>
                <td class="auto-style9">
                    <asp:Label ID="attributeFiveNamePlayerTwo" runat="server"></asp:Label>
                </td>
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
                <td class="auto-style9">
                    <asp:Label ID="attributeFiveValuePlayerTwo" runat="server"></asp:Label>
                </td>
            </tr>
        </table>
    </form>
    <p>
        &nbsp;</p>
</body>
</html>
