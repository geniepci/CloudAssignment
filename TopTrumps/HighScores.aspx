<%@ Page Language="C#" AutoEventWireup="true" CodeBehind="HighScores.aspx.cs" Inherits="TopTrumps.HighScores" %>

<!DOCTYPE html>

<html xmlns="http://www.w3.org/1999/xhtml">
<head runat="server">
    <title></title>
    <style type="text/css">
        .auto-style1 {
            width: 100%;
        }
        .auto-style2 {
            text-align: center;
        }
        .auto-style7 {
            text-align: center;
            font-size: xx-large;
            color: #0000FF;
        }
        .auto-style8 {
            width: 163px;
            height: 120px;
        }
        .auto-style9 {
            width: 302px;
            height: 120px;
        }
        .auto-style10 {
            width: 171px;
            height: 120px;
        }
        .auto-style11 {
            width: 129px;
            height: 120px;
        }
        .auto-style12 {
            height: 120px;
        }
        .auto-style13 {
            width: 163px;
            height: 128px;
        }
        .auto-style14 {
            width: 302px;
            height: 128px;
        }
        .auto-style15 {
            width: 171px;
            height: 128px;
        }
        .auto-style16 {
            width: 129px;
            height: 128px;
        }
        .auto-style17 {
            height: 128px;
        }
        .auto-style20 {
            width: 302px;
            height: 120px;
            text-align: center;
            font-size: xx-large;
            color: #0000FF;
        }
    </style>
</head>
<body>
    <form id="form1" runat="server">
    <div>
    
        <div class="auto-style7">
            </div>
        <table class="auto-style1">
            <tr>
                <td class="auto-style8">&nbsp;</td>
                <td class="auto-style8">
                    &nbsp;</td>
                <td class="auto-style20">
            <strong>TOP TRUMPS HIGH SCORES</strong></td>
                <td class="auto-style10">
                    &nbsp;</td>
                <td class="auto-style11">
                    &nbsp;</td>
                <td class="auto-style12">
                    &nbsp;</td>
                <td class="auto-style12">&nbsp;</td>
            </tr>
            <tr>
                <td class="auto-style8">&nbsp;</td>
                <td class="auto-style8">
                    &nbsp;</td>
                <td class="auto-style9">
                    <div class="auto-style2">
                        <asp:GridView ID="GridView1" runat="server" AutoGenerateColumns="False" DataSourceID="playerData1" Width="688px">
                            <Columns>
                                <asp:ImageField DataImageUrlField="ImageURI" HeaderText="Picture">
                                    <ControlStyle Height="150px" Width="150px" />
                                </asp:ImageField>
                                <asp:BoundField DataField="PlayerName" HeaderText="PlayerName" SortExpression="PlayerName">
                                <ItemStyle Width="200px" />
                                </asp:BoundField>
                                <asp:BoundField DataField="Wins" HeaderText="Wins" SortExpression="Wins">
                                <ControlStyle Width="200px" />
                                <FooterStyle Width="200px" />
                                <HeaderStyle Width="200px" />
                                <ItemStyle Width="200px" />
                                </asp:BoundField>
                                <asp:BoundField DataField="Losses" HeaderText="Losses       " SortExpression="Losses">
                                <HeaderStyle Width="200px" />
                                </asp:BoundField>
                                <asp:BoundField DataField="Games" HeaderText="Games" SortExpression="Games">
                                <ControlStyle Width="200px" />
                                <ItemStyle Width="200px" />
                                </asp:BoundField>
                            </Columns>
                        </asp:GridView>
                        <asp:ObjectDataSource ID="playerData1" runat="server" SelectMethod="GetPlayerScores" TypeName="TopTrumps.Players"></asp:ObjectDataSource>
                    </div>
                </td>
                <td class="auto-style10">
                    &nbsp;</td>
                <td class="auto-style11">
                    &nbsp;</td>
                <td class="auto-style12">
                    &nbsp;</td>
                <td class="auto-style12">&nbsp;</td>
            </tr>
            <tr>
                <td class="auto-style13">&nbsp;</td>
                <td class="auto-style13">&nbsp;</td>
                <td class="auto-style14">&nbsp;</td>
                <td class="auto-style15">&nbsp;</td>
                <td class="auto-style16">&nbsp;</td>
                <td class="auto-style17">&nbsp;</td>
                <td class="auto-style17">&nbsp;</td>
            </tr>
        </table>
    
    </div>
    </form>
</body>
</html>
