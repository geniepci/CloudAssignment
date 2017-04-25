<%@ Page Language="C#" AutoEventWireup="true" CodeBehind="Login.aspx.cs" Inherits="TopTrumps.HomePage" %>

<!DOCTYPE html>

<html xmlns="http://www.w3.org/1999/xhtml">
<head runat="server">
    <title></title>
    <style type="text/css">
        .auto-style1 {
            width: 100%;
        }
        .auto-style2 {
            height: 26px;
        }
        .auto-style3 {
            height: 26px;
            width: 97px;
        }
        .auto-style4 {
            width: 97px;
        }
        .auto-style5 {
            height: 26px;
            width: 462px;
            text-align: center;
        }
        .auto-style6 {
            width: 462px;
            text-align: center;
        }
        .auto-style7 {
            width: 97px;
            height: 29px;
        }
        .auto-style8 {
            width: 462px;
            text-align: center;
            height: 29px;
        }
        .auto-style9 {
            height: 29px;
        }
        .auto-style10 {
            text-align: center;
        }
        .auto-style11 {
            height: 26px;
            width: 100px;
        }
        .auto-style12 {
            width: 100px;
        }
        .auto-style13 {
            width: 100px;
            height: 29px;
        }
        .auto-style14 {
            height: 26px;
            width: 88px;
        }
        .auto-style15 {
            width: 88px;
        }
        .auto-style16 {
            height: 29px;
            width: 88px;
        }
        .auto-style17 {
            height: 26px;
            text-align: center;
            font-size: xx-large;
            color: #0000FF;
        }
        .auto-style18 {
            height: 26px;
            width: 185px;
        }
        .auto-style19 {
            text-align: center;
            width: 185px;
        }
        .auto-style20 {
            width: 185px;
        }
        .auto-style22 {
            width: 88px;
            text-align: center;
        }
        .auto-style23 {
            height: 29px;
            text-align: center;
            width: 338px;
        }
        .auto-style24 {
            height: 26px;
            width: 338px;
        }
        .auto-style25 {
            text-align: center;
            width: 338px;
        }
        .auto-style26 {
            width: 338px;
        }
        .auto-style27 {
            height: 29px;
            width: 338px;
        }
        .auto-style28 {
            width: 185px;
            height: 29px;
        }
    </style>
</head>
<body>
    <form id="form1" runat="server">
    <div>
    
        <div class="auto-style10">
            <br />
            <br />
        </div>
        <table class="auto-style1">
            <tr>
                <td class="auto-style11">&nbsp;</td>
                <td class="auto-style3">&nbsp;</td>
                <td class="auto-style17" colspan="4">TOP TRUMPS</td>
                <td class="auto-style2">&nbsp;</td>
            </tr>
            <tr>
                <td class="auto-style11"></td>
                <td class="auto-style3"></td>
                <td class="auto-style5"></td>
                <td class="auto-style14"></td>
                <td class="auto-style18">&nbsp;</td>
                <td class="auto-style24"></td>
                <td class="auto-style2"></td>
            </tr>
            <tr>
                <td class="auto-style11">&nbsp;</td>
                <td class="auto-style3">&nbsp;</td>
                <td class="auto-style5">&nbsp;</td>
                <td class="auto-style14">&nbsp;</td>
                <td class="auto-style18">&nbsp;</td>
                <td class="auto-style24">&nbsp;</td>
                <td class="auto-style2">&nbsp;</td>
            </tr>
            <tr>
                <td class="auto-style12">&nbsp;</td>
                <td class="auto-style4">&nbsp;</td>
                <td class="auto-style6">EXISTING USER - SIGN IN</td>
                <td class="auto-style22">OR</td>
                <td class="auto-style19">&nbsp;</td>
                <td class="auto-style25">NEW USER - SIGN UP</td>
                <td>&nbsp;</td>
            </tr>
            <tr>
                <td class="auto-style12">&nbsp;</td>
                <td class="auto-style4">&nbsp;</td>
                <td class="auto-style6">&nbsp;</td>
                <td class="auto-style15">&nbsp;</td>
                <td class="auto-style20">&nbsp;</td>
                <td class="auto-style26">&nbsp;</td>
                <td>&nbsp;</td>
            </tr>
            <tr>
                <td class="auto-style12">&nbsp;</td>
                <td class="auto-style4">Email</td>
                <td class="auto-style6">&nbsp;<asp:TextBox ID="TextBox1" runat="server" TextMode="Email" Width="300px"></asp:TextBox>
                </td>
                <td class="auto-style22">&nbsp;</td>
                <td class="auto-style20">Email</td>
                <td class="auto-style25">
                    <asp:TextBox ID="TextBox3" runat="server" TextMode="Email" Width="300px"></asp:TextBox>
                </td>
                <td>&nbsp;</td>
            </tr>
            <tr>
                <td class="auto-style13">&nbsp;</td>
                <td class="auto-style7">Password </td>
                <td class="auto-style8">
                    <asp:TextBox ID="TextBox2" runat="server" TextMode="Password" Width="300px"></asp:TextBox>
                </td>
                <td class="auto-style16"></td>
                <td class="auto-style28">Password </td>
                <td class="auto-style23">
                    <asp:TextBox ID="TextBox4" runat="server" TextMode="Password" Width="300px"></asp:TextBox>
                </td>
                <td class="auto-style9">&nbsp;</td>
            </tr>
            <tr>
                <td class="auto-style13">&nbsp;</td>
                <td class="auto-style7">&nbsp;</td>
                <td class="auto-style8">&nbsp;</td>
                <td class="auto-style16">&nbsp;</td>
                <td class="auto-style28">Re-enter Password</td>
                <td class="auto-style23">
                    <asp:TextBox ID="TextBox5" runat="server" TextMode="Password" Width="300px"></asp:TextBox>
                </td>
                <td class="auto-style9">&nbsp;</td>
            </tr>
            <tr>
                <td class="auto-style13"></td>
                <td class="auto-style7"></td>
                <td class="auto-style8"></td>
                <td class="auto-style16"></td>
                <td class="auto-style28"></td>
                <td class="auto-style27"></td>
                <td class="auto-style9"></td>
            </tr>
            <tr>
                <td class="auto-style12">&nbsp;</td>
                <td class="auto-style4">&nbsp;</td>
                <td class="auto-style6">
                    <asp:Button ID="Button1" runat="server" Text="Sign In" OnClick="Button1_Click" />
                </td>
                <td class="auto-style15">&nbsp;</td>
                <td class="auto-style19">&nbsp;</td>
                <td class="auto-style25">
                    <asp:Button ID="Button2" runat="server" Text="Sign Up" />
                </td>
                <td>&nbsp;</td>
            </tr>
            <tr>
                <td class="auto-style12">&nbsp;</td>
                <td class="auto-style4">&nbsp;</td>
                <td class="auto-style6">&nbsp;</td>
                <td class="auto-style15">&nbsp;</td>
                <td class="auto-style20">&nbsp;</td>
                <td class="auto-style26">&nbsp;</td>
                <td>&nbsp;</td>
            </tr>
            <tr>
                <td class="auto-style12">&nbsp;</td>
                <td class="auto-style4">&nbsp;</td>
                <td class="auto-style6">&nbsp;</td>
                <td class="auto-style15">&nbsp;</td>
                <td class="auto-style20">&nbsp;</td>
                <td class="auto-style26">&nbsp;</td>
                <td>&nbsp;</td>
            </tr>
            <tr>
                <td class="auto-style11"></td>
                <td class="auto-style3"></td>
                <td class="auto-style5">&nbsp;</td>
                <td class="auto-style14"></td>
                <td class="auto-style18"></td>
                <td class="auto-style24"></td>
                <td class="auto-style2"></td>
            </tr>
            <tr>
                <td class="auto-style12">&nbsp;</td>
                <td class="auto-style4">&nbsp;</td>
                <td class="auto-style6">&nbsp;</td>
                <td class="auto-style15">&nbsp;</td>
                <td class="auto-style20">&nbsp;</td>
                <td class="auto-style26">&nbsp;</td>
                <td>&nbsp;</td>
            </tr>
            <tr>
                <td class="auto-style12">&nbsp;</td>
                <td class="auto-style4">&nbsp;</td>
                <td class="auto-style6">&nbsp;</td>
                <td class="auto-style15">&nbsp;</td>
                <td class="auto-style20">&nbsp;</td>
                <td class="auto-style26">&nbsp;</td>
                <td>&nbsp;</td>
            </tr>
        </table>
    
    </div>
    </form>
</body>
</html>
