<%@ Page Language="C#" AutoEventWireup="true" CodeBehind="Players.aspx.cs" Inherits="TopTrumps.Players" %>

<!DOCTYPE html>
<html lang="en">

    <head runat="server">
        <title>Messages</title>
        <link href="main.css" rel="stylesheet" type="text/css" />
        <style type="text/css">
            .auto-style1 {
                font-family: "Franklin Gothic Medium", "Arial Narrow", Arial, sans-serif;
            }
            .auto-style2 {
                font-family: Tahoma;
                font-weight: bold;
                font-size: x-large;
                color: white;
            }
            .auto-style3 {
                height: 35px;
            }
            </style>
    </head>

    <body>

        <form id="frmMessages" runat="server">
            
            <div style="width: 600px; position: absolute; left: 50%; margin-left:-300px; ">
                <div>
                    <h1 class="auto-style1">
                        Top Trumps Player Creation</h1>
                </div>

                <div style="width: auto; padding: 5px; background-color: #3366FF; color: white; font-size: x-large; font-family: Tahoma; font-weight: bold;">
                    Add Players</div>
                       
                <div id="divInputMessage"          
                    style="width: auto; padding: 5px; border-style: inset; border-width: medium; margin: 10px 0px 10px 0px; font-family:'Segoe UI', Tahoma, Geneva, Verdana, sans-serif;">
                    <table style="width: auto;">
                        <tr>
                            <td style="vertical-align: top; text-align: right">
                                <label>Player Name :</label>
                            </td>
                            <td>
                                <asp:TextBox 
                                        ID="txtPlayerName" 
                                        runat="server" Width="200px"/>
                            </td>
                        </tr>
                        <tr>
                            <td style="vertical-align: top; text-align: right" class="auto-style3">
                                Age:</td>
                            <td class="auto-style3">
                                <asp:TextBox 
                                        ID="txtAge" 
                                        runat="server" Width="200px"/>
                            </td>
                        </tr>
                        <tr>
                            <td style="vertical-align: top; text-align: right">
                                <label>Row Key :</label>
                            </td>
                            <td style="vertical-align: top; ">
                                <asp:TextBox ID="txtRowKey" runat="server" Width="400px" ReadOnly="True"/>
                            </td>
                        </tr>
                        <tr>
                            <td style="vertical-align: top; text-align: right">
                                <label>Partition Key :</label>
                            </td>
                            <td>
                                <asp:TextBox ID="txtPartitionKey" runat="server" Width="100px" ReadOnly="True"/>
                            </td>
                        </tr>
                                            <tr>
                            <td>
                                <label for="PhotoUpload">Photo:</label>
                            </td>
                            <td>
                                <asp:FileUpload ID="PhotoUpload" runat="server" />
                            </td> 
                        </tr> 
                    </table>

                    <div style="text-align: right">
                        <asp:Button ID="btnInsert3" runat="server" OnClick="btnInsert3_Click" 
                            Text = "Insert" />&nbsp;&nbsp;
                        <asp:Button ID="btnReplace3" runat="server" OnClick="btnReplace3_Click" 
                            Text = "Replace" />&nbsp;&nbsp;&nbsp;
                    </div>  
                </div>

                <div style="width: auto; padding: 5px; background-color: #3366FF; " class="auto-style2">
                    Players</div>

                <asp:DataList 
                    ID="dataListMessages" 
                    runat="server" 
                    DataSourceID="dsMessages" CellPadding="4" 
                    ForeColor="#333333" GridLines="Both" style="margin-right: 0px; width: 600px;">
                    <AlternatingItemStyle BackColor="White" />
                    <FooterStyle BackColor="#507CD1" Font-Bold="True" ForeColor="White" />
                    <HeaderStyle BackColor="#507CD1" Font-Bold="True" ForeColor="White" />
                    <ItemStyle BackColor="#EFF3FB" />
                    <ItemTemplate>
                        <div style="width:100%; display:table; font-family:'Segoe UI', Tahoma, Geneva, Verdana, sans-serif; font-size: smaller; ">
                            <div style="display:table-row; height: 125px;">
                                <div style="display:table-cell;">
                                    <img src="<%# Eval("ImageURI") %>" style="width: 100px; height: 125px;" /> 
                                </div>
                                <div style="display:table-cell; vertical-align:top; padding:10px; ">      
                                    Image URI: <br />
                                    <asp:Label width="400px" runat="server" Text='<%# Eval("ImageURI") %>' />                                          
                                </div>
                            </div> 
                        </div>
                        <br />
                         PlayerName:
                        <asp:Label ID="PlayerNameLabel" runat="server" Text='<%# Eval("PlayerName") %>' />
                        <br />
                         Age: <asp:Label ID="AgeLabel" runat="server" Text='<%# Eval("Age") %>' />
                        <br />
                         ImageURI:
                        <asp:Label ID="ImageURILabel" runat="server" Text='<%# Eval("ImageURI") %>' />
                        <br />
                         PartitionKey:
                        <asp:Label ID="PartitionKeyLabel" runat="server" Text='<%# Eval("PartitionKey") %>' />
                        <br />
                         RowKey:
                        <div style="font-family:'Segoe UI', Tahoma, Geneva, Verdana, sans-serif;">
                                <asp:CheckBox ID="RowKey" runat="server" 
                                    Text='<%# Eval("RowKey") %>' /> (Row Key) &nbsp;|&nbsp;
                        <br />
                         Timestamp:
                        <asp:Label ID="TimestampLabel" runat="server" Text='<%# Eval("Timestamp") %>' />
                        <br />
                         ETag:
                        <asp:Label ID="ETagLabel" runat="server" Text='<%# Eval("ETag") %>' />
                        <br />
                        <br />
                    </ItemTemplate>
                    <SelectedItemStyle BackColor="#D1DDF1" Font-Bold="True" ForeColor="#333333" />
                </asp:DataList>

                <asp:ObjectDataSource 
                   ID="dsMessages"
                   runat="server"
                   SelectMethod="GetPlayers" 
                   TypeName="TopTrumps.Players" 
                   OldValuesParameterFormatString="original_{0}">
                </asp:ObjectDataSource>

                <div style="text-align: right">
                    <asp:Button ID="btnEdit3" runat="server" CausesValidation="False" 
                        onclick="btnEdit3_Click" Text="Edit" />&nbsp;&nbsp;
                    <asp:Button ID="btnDelete3" runat="server" OnClick="btnDelete3_Click" 
                        Text = "Delete" CausesValidation="False" 
                        UseSubmitBehavior="False" />
                </div> 

            </div>

        </form>

    </body>

</html>