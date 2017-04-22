<%@ Page Language="C#" AutoEventWireup="true" CodeBehind="WebForm1.aspx.cs" Inherits="TopTrumps.WebForm1" %>

<!DOCTYPE html>

<html xmlns="http://www.w3.org/1999/xhtml">
<head runat="server">
    <title></title>
    <style type="text/css">
        .auto-style1 {
            width: 100%;
        }
        .auto-style2 {
            width: 380px;
        }
        .auto-style3 {
            width: 403px;
        }
    </style>
</head>
<body>
    <form id="form1" runat="server">
    <div>
    
        <div>
&nbsp;&nbsp;
        </div>
        <br />
        <br />
        <br />
    
    </div>
        <br />
        <asp:Label ID="Label1" runat="server" Text="Label"></asp:Label>
        <br />
        <table class="auto-style1">
            <tr>
                <td class="auto-style2">&nbsp;</td>
                <td class="auto-style3">
                    <div style="width: 100%; height: 400px; overflow: scroll">
                        <asp:GridView ID="GridView1" runat="server" AutoGenerateColumns="False" BorderColor="White" BorderStyle="None" DataSourceID="ObjectDataSource1" GridLines="None" Height="100px" HorizontalAlign="Center" OnSelectedIndexChanged="GridView1_SelectedIndexChanged" PageSize="3" Width="200px">
                            <Columns>
                                <asp:CommandField ButtonType="Button" ShowSelectButton="True" />
                                <asp:ImageField DataImageUrlField="ImageURI" HeaderText="Image">
                                    <ControlStyle Height="100px" Width="100px" />
                                </asp:ImageField>
                                <asp:BoundField DataField="PlayerName" HeaderText="PlayerName" SortExpression="PlayerName" />
                                <asp:BoundField DataField="PartitionKey" InsertVisible="False" SortExpression="PartitionKey">
                                <ControlStyle BorderStyle="None" />
                                <ItemStyle BackColor="White" BorderColor="White" BorderStyle="None" ForeColor="White" />
                                </asp:BoundField>
                                <asp:BoundField DataField="RowKey" SortExpression="RowKey">
                                <ControlStyle BackColor="White" BorderColor="White" BorderStyle="None" ForeColor="White" />
                                <ItemStyle BackColor="White" BorderColor="White" ForeColor="White" />
                                </asp:BoundField>
                                <asp:BoundField DataField="Timestamp" HeaderText="Timestamp" SortExpression="Timestamp" Visible="False" />
                            </Columns>
                        </asp:GridView>
                    </div>
                    <asp:ObjectDataSource ID="ObjectDataSource1" runat="server" SelectMethod="GetPlayers" TypeName="TopTrumps.Players"></asp:ObjectDataSource>
                </td>
                <td>&nbsp;</td>
            </tr>
            <tr>
                <td class="auto-style2">&nbsp;</td>
                <td class="auto-style3">&nbsp;</td>
                <td>&nbsp;</td>
            </tr>
        </table>
        <br />
    </form>
</body>
</html>
