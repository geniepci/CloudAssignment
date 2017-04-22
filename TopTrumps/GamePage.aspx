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
        .auto-style9 {
            width: 236px;
            background-color: #FFFFFF;
        }
        .auto-style10 {
            height: 26px;
            width: 236px;
            background-color: #FFFFFF;
        }
        .auto-style17 {
            width: 274px;
            text-align: center;
        }
        .auto-style18 {
            height: 26px;
            width: 274px;
            text-align: center;
        }
        .auto-style19 {
            height: 4px;
            width: 274px;
            text-align: center;
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
        .auto-style33 {
            width: 144px;
            height: 33px;
        }
        .auto-style35 {
            width: 274px;
            height: 33px;
            text-align: center;
        }
        .auto-style36 {
            width: 236px;
            height: 33px;
            background-color: #FFFFFF;
        }
        .auto-style37 {
            height: 33px;
        }
        .auto-style38 {
            width: 295px;
            background-color: #FFFFFF;
            text-align: center;
        }
        .auto-style39 {
            width: 295px;
            height: 33px;
            background-color: #FFFFFF;
            text-align: center;
        }
        .auto-style40 {
            height: 26px;
            width: 295px;
            background-color: #FFFFFF;
            text-align: center;
        }
        .auto-style41 {
            height: 4px;
            width: 295px;
            background-color: #FFFFFF;
            text-align: center;
        }
        .auto-style43 {
            width: 304px;
            background-color: #FFFFFF;
            text-align: center;
        }
        .auto-style44 {
            width: 304px;
            height: 33px;
            background-color: #FFFFFF;
            text-align: center;
        }
        .auto-style45 {
            height: 26px;
            width: 304px;
            background-color: #FFFFFF;
            text-align: center;
        }
        .auto-style46 {
            height: 4px;
            width: 304px;
            background-color: #FFFFFF;
            text-align: center;
        }
        .auto-style48 {
            width: 274px;
            text-align: center;
            font-family: Verdana, Geneva, Tahoma, sans-serif;
            font-weight: bold;
            font-size: xx-large;
            color: #0000FF;
            text-decoration: underline;
        }
        .auto-style49 {
            margin-left: 0px;
        }
        .auto-style50 {
            width: 304px;
            background-color: #FFFFFF;
            text-align: right;
        }
        .auto-style51 {
            width: 295px;
            background-color: #FFFFFF;
            text-align: left;
        }
    </style>
</head>
<body>
    <form id="form1" runat="server">
        <table class="auto-style1">
            <tr>
                <td class="auto-style25">&nbsp;</td>
                <td class="auto-style51">
                    <asp:Image ID="Image3" runat="server" Height="125px" Width="125px" />
                </td>
                <td class="auto-style48" colspan="1">TOP TRUMPS</td>
                <td class="auto-style50" rowspan="1">
                    <asp:Image ID="Image4" runat="server" Height="125px" Width="125px" />
                </td>
                <td>&nbsp;</td>
            </tr>
            <tr>
                <td class="auto-style25">&nbsp;</td>
                <td class="auto-style38">
                    &nbsp;</td>
                <td class="auto-style17">
                    <asp:Label ID="gameName" runat="server" Font-Size="X-Large" ForeColor="#33CC33"></asp:Label>
                </td>
                <td class="auto-style43">
                    &nbsp;</td>
                <td>&nbsp;</td>
            </tr>
            <tr>
                <td class="auto-style25">
                    &nbsp;</td>
                <td class="auto-style38">
                    &nbsp;</td>
                <td class="auto-style17">
                    &nbsp;</td>
                <td class="auto-style43">
                    &nbsp;</td>
                <td>
                    &nbsp;</td>
            </tr>
            <tr>
                <td class="auto-style25">
                    <asp:ListBox ID="ListBox1" runat="server" Width="163px" Height="213px"></asp:ListBox>
                </td>
                <td class="auto-style38">
                    <asp:Image ID="Image1" runat="server" Height="250px" Width="250px" />
                </td>
                <td class="auto-style17">
                    <asp:Label ID="Label1" runat="server" Font-Size="X-Large" ForeColor="Red"></asp:Label>
                    <asp:Label ID="Label2" runat="server" Font-Size="X-Large" ForeColor="Red"></asp:Label>
                    <asp:ListBox ID="ListBox3" runat="server" CssClass="auto-style49" Height="250px" Width="200px"></asp:ListBox>
                    <asp:ListBox ID="ListBox4" runat="server" CssClass="auto-style49" Height="250px" Width="200px"></asp:ListBox>
                    <asp:ListBox ID="ListBox5" runat="server" CssClass="auto-style49" Height="250px" Width="200px"></asp:ListBox>
                </td>
                <td class="auto-style43">
                    <asp:Image ID="Image2" runat="server" Height="250px" Width="250px" />
                </td>
                <td>
                    <asp:ListBox ID="ListBox2" runat="server" Width="145px" Height="204px"></asp:ListBox>
                </td>
            </tr>
            <tr>
                <td class="auto-style25">&nbsp;</td>
                <td class="auto-style38">
                    <asp:Label ID="cardNamePlayerOne" runat="server"></asp:Label>
                </td>
                <td class="auto-style17">&nbsp;</td>
                <td class="auto-style43">
                    <asp:Label ID="cardNamePlayerTwo" runat="server"></asp:Label>
                </td>
                <td>&nbsp;</td>
            </tr>
            <tr>
                <td class="auto-style25">&nbsp;</td>
                <td class="auto-style38">&nbsp;</td>
                <td class="auto-style17">
                    <asp:Button ID="Button1" runat="server" Height="29px" OnClick="Button1_Click" Text="Choose Your Game" />
                    <asp:Button ID="Button2" runat="server" Height="29px" OnClick="Button2_Click" Text="Choose Player One" />
                    <br />
                    <asp:Button ID="Button3" runat="server" Height="29px" OnClick="Button3_Click" Text="Choose Player Two" />
                </td>
                <td class="auto-style43">&nbsp;</td>
                <td>&nbsp;</td>
            </tr>
            <tr>
                <td class="auto-style33">
                    &nbsp;</td>
                <td class="auto-style39">
                    <asp:Button ID="playerOneButtonOne" runat="server" Text="Button" Height="40px" Width="250px" OnClick="playerOneButtonOne_Click" />
                </td>
                <td class="auto-style35">
                    &nbsp;</td>
                <td class="auto-style44">
                    <asp:Button ID="playerTwoButtonOne" runat="server" Height="40px" Text="Button" Width="250px" OnClick="playerTwoButtonOne_Click" />
                </td>
                <td class="auto-style37">
                    &nbsp;</td>
            </tr>
            <tr>
                <td class="auto-style25">
                    &nbsp;</td>
                <td class="auto-style38">
                    &nbsp;</td>
                <td class="auto-style17">&nbsp;</td>
                <td class="auto-style43">
                    &nbsp;</td>
                <td>&nbsp;</td>
            </tr>
            <tr>
                <td class="auto-style25">
                    &nbsp;</td>
                <td class="auto-style38">
                    <asp:Button ID="playerOneButtonTwo" runat="server" Height="40px" Text="Button" Width="250px" OnClick="playerOneButtonTwo_Click" />
                </td>
                <td class="auto-style17">&nbsp;</td>
                <td class="auto-style43">
                    <asp:Button ID="playerTwoButtonTwo" runat="server" Height="40px" Text="Button" Width="250px" OnClick="playerTwoButtonTwo_Click" />
                </td>
                <td>&nbsp;</td>
            </tr>
            <tr>
                <td class="auto-style25">
                    &nbsp;</td>
                <td class="auto-style38">
                    &nbsp;</td>
                <td class="auto-style17">
                    &nbsp;</td>
                <td class="auto-style43">
                    &nbsp;</td>
                <td>
                    &nbsp;</td>
            </tr>
            <tr>
                <td class="auto-style25">&nbsp;</td>
                <td class="auto-style38">
                    <asp:Button ID="playerOneButtonThree" runat="server" Height="40px" Text="Button" Width="250px" OnClick="playerOneButtonThree_Click" />
                </td>
                <td class="auto-style17">&nbsp;</td>
                <td class="auto-style43">
                    <asp:Button ID="playerTwoButtonThree" runat="server" Height="40px" Text="Button" Width="250px" OnClick="playerTwoButtonThree_Click" />
                </td>
                <td class="auto-style36">
                    &nbsp;</td>
            </tr>
            <tr>
                <td class="auto-style25">&nbsp;</td>
                <td class="auto-style38">&nbsp;</td>
                <td class="auto-style17">
                    &nbsp;</td>
                <td class="auto-style43">&nbsp;</td>
                <td class="auto-style9">
                    &nbsp;</td>
            </tr>
            <tr>
                <td class="auto-style26">
                    &nbsp;</td>
                <td class="auto-style40">
                    <asp:Button ID="playerOneButtonFour" runat="server" Height="40px" Text="Button" Width="250px" OnClick="playerOneButtonFour_Click" />
                </td>
                <td class="auto-style18">&nbsp;</td>
                <td class="auto-style45">
                    <asp:Button ID="playerTwoButtonFour" runat="server" Height="40px" Text="Button" Width="250px" OnClick="playerTwoButtonFour_Click" />
                </td>
                <td class="auto-style9">&nbsp;</td>
            </tr>
            <tr>
                <td class="auto-style25">&nbsp;</td>
                <td class="auto-style38">
                    &nbsp;</td>
                <td class="auto-style17">&nbsp;</td>
                <td class="auto-style43">
                    &nbsp;</td>
                <td class="auto-style9">
                    &nbsp;</td>
            </tr>
            <tr>
                <td class="auto-style26"></td>
                <td class="auto-style40">
                    <asp:Button ID="playerOneButtonFive" runat="server" Height="40px" Text="Button" Width="250px" OnClick="playerOneButtonFive_Click" />
                </td>
                <td class="auto-style18">
                    <asp:Button ID="nextCard" runat="server" OnClick="nextCard_Click" Text="NEXT CARD" Height="40px" Width="250px"/>
                    <asp:Button ID="playAgain" runat="server" Height="40px" OnClick="playAgain_Click" Text="PLAY AGAIN" Width="250px" />
                </td>
                <td class="auto-style45">
                    <asp:Button ID="playerTwoButtonFive" runat="server" Height="40px" Text="Button" Width="250px" OnClick="playerTwoButtonFive_Click" />
                </td>
                <td class="auto-style9">
                    &nbsp;</td>
            </tr>
            <tr>
                <td class="auto-style27">
                    &nbsp;</td>
                <td class="auto-style41">
                    &nbsp;</td>
                <td class="auto-style19">&nbsp;</td>
                <td class="auto-style46">
                    &nbsp;</td>
                <td class="auto-style9">&nbsp;</td>
            </tr>
            <tr>
                <td class="auto-style25">
                    &nbsp;</td>
                <td class="auto-style38">
                    &nbsp;</td>
                <td class="auto-style17">&nbsp;</td>
                <td class="auto-style43">
                    &nbsp;</td>
                <td class="auto-style10">
                    &nbsp;</td>
            </tr>
            <tr>
                <td class="auto-style26">
                    </td>
                <td class="auto-style40">
                    </td>
                <td class="auto-style18"></td>
                <td class="auto-style45">
                    </td>
                <td class="auto-style9">
                    &nbsp;</td>
            </tr>
            <tr>
                <td class="auto-style26">
                    </td>
                <td class="auto-style40">
                    </td>
                <td class="auto-style18">
                    </td>
                <td class="auto-style45"></td>
                <td class="auto-style10">
                    </td>
            </tr>
            <tr>
                <td class="auto-style25">
                    &nbsp;</td>
                <td class="auto-style38">
                    &nbsp;</td>
                <td class="auto-style17">
                    &nbsp;</td>
                <td class="auto-style43">
                    &nbsp;</td>
                <td class="auto-style9">
                    &nbsp;</td>
            </tr>
        </table>
    </form>
    <p>
        &nbsp;</p>
</body>
</html>
