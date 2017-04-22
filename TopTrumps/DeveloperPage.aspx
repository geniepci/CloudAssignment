<%@ Page Language="C#" AutoEventWireup="true" CodeBehind="DeveloperPage.aspx.cs" Inherits="TopTrumps.DeveloperPage" %>

<!DOCTYPE html>

<html xmlns="http://www.w3.org/1999/xhtml">
<head runat="server">
    <title></title>
    <style type="text/css">
        .auto-style1 {
            width: 100%;
        }
        .auto-style10 {
            height: 69px;
            width: 401px;
            text-align: right;
        }
        .auto-style11 {
            height: 56px;
            width: 401px;
            text-align: right;
        }
        .auto-style16 {
            height: 69px;
            width: 165px;
        }
        .auto-style17 {
            height: 56px;
            width: 165px;
        }
        .auto-style18 {
            height: 48px;
            width: 165px;
        }
        .auto-style20 {
            height: 48px;
            width: 401px;
            text-align: right;
        }
        .auto-style27 {
            height: 32px;
            text-align: center;
            width: 405px;
        }
        .auto-style28 {
            font-size: xx-large;
            color: #0000FF;
            font-family: Arial, Helvetica, sans-serif;
        }
        .auto-style32 {
            height: 46px;
            width: 165px;
        }
        .auto-style33 {
            height: 46px;
            width: 401px;
            text-align: right;
        }
        .auto-style37 {
            height: 35px;
            width: 401px;
            text-align: right;
        }
        .auto-style38 {
            height: 35px;
            width: 165px;
        }
        .auto-style47 {
            height: 69px;
            width: 410px;
            text-align: right;
        }
        .auto-style48 {
            height: 56px;
            width: 410px;
        }
        .auto-style49 {
            height: 48px;
            width: 410px;
        }
        .auto-style51 {
            width: 410px;
            text-align: center;
        }
        .auto-style52 {
            height: 35px;
            width: 410px;
        }
        .auto-style55 {
            height: 69px;
            width: 226px;
        }
        .auto-style56 {
            height: 56px;
            width: 226px;
        }
        .auto-style57 {
            height: 48px;
            width: 226px;
        }
        .auto-style59 {
            height: 46px;
            width: 226px;
        }
        .auto-style60 {
            height: 35px;
            width: 226px;
        }
        .auto-style61 {
            margin-left: 0px;
        }
        .auto-style62 {
            height: 32px;
            width: 165px;
        }
        .auto-style63 {
            height: 32px;
            width: 410px;
        }
        .auto-style64 {
            height: 32px;
            width: 226px;
        }
        .auto-style65 {
            height: 32px;
            width: 401px;
        }
        .auto-style66 {
            height: 48px;
            width: 410px;
            text-align: right;
        }
        .auto-style67 {
            height: 69px;
            width: 405px;
            text-align: right;
        }
        .auto-style68 {
            height: 56px;
            width: 405px;
            text-align: right;
        }
        .auto-style69 {
            height: 48px;
            width: 405px;
            text-align: right;
        }
        .auto-style70 {
            height: 46px;
            width: 405px;
            text-align: right;
        }
        .auto-style71 {
            height: 35px;
            width: 405px;
            text-align: right;
        }
    
.Menu
{
	float: left;
	font-size: 80%;
	margin: 0;
	margin-left: 3px;
	padding: 0;
	text-align: center;
}

a.MenuLink
{
    text-decoration: none;
}

a.MenuLink
{
	background: #ede7f8;
	border-top: 1px solid #FFFFFF;
	border-left: 1px solid #FFFFFF;
	border-right: 1px solid #FFFFFF;
	color: #666666;
	float: left;
	margin: 0px;
	padding: 5px 0px;
	margin-left: 5px;
	text-align: center;
	text-decoration: none;
	width: 120px;
	
	-moz-border-radius-topright: 10px;
	border-top-right-radius: 10px;
	-moz-border-radius-topleft: 10px;
	border-top-left-radius: 10px;
}

a
{
    color: #0066B3;
    background: inherit;
}

a.ActiveLink
{
    background: #ffffff;
	border-top: 1px solid #FFFFFF;
	border-left: 1px solid #FFFFFF;
	border-right: 1px solid #FFFFFF;
	color: #666666;
	float: left;
	margin: 0px;
	padding: 5px 0px;
	margin-left: 5px;
	text-align: center;
	text-decoration: none;
	width: 120px;
	
    -moz-border-radius-topright: 10px;
	border-top-right-radius: 10px;
	-moz-border-radius-topleft: 10px;
	border-top-left-radius: 10px;
}

        .auto-style72 {
            color: #0000FF;
        }

    </style>
</head>
<body>
    <form id="form1" runat="server">
        <div>
    
         <div class="Menu">
                <a href="#" class="MenuLink">Home</a>
                <a href="GamePage.aspx" class="MenuLink">GamePage</a>
                <a href="http://localhost:50032/guest.aspx" class="MenuLink">Guest</a>
                <a href="http://localhost:50032/course_booking.aspx" class="ActiveLink">Course Booking</a>
                <a href="http://localhost:50032/accommodation.aspx" class="MenuLink">Accommodation</a>
                <a href="http://localhost:50032/staff.aspx" class="MenuLink">Staff</a>
                
            </div>


                    </div>
        <table class="auto-style1" id="bob">
            <tr>
                <td class="auto-style62"></td>
                <td class="auto-style65"></td>
                <td class="auto-style27"><span class="auto-style28"><strong>TOP</strong></span> <span class="auto-style28"><strong>TRUMPS DEVELOPER </strong> </span></td>
                <td class="auto-style63"></td>
                <td class="auto-style64"></td>
            </tr>
            <tr>
                <td class="auto-style16"></td>
                <td class="auto-style10">CHOOSE OPTION</td>
                <td class="auto-style67">
                    <asp:Label ID="Label10" runat="server" Text="CHOOSE CATEGORY"></asp:Label>
                </td>
                <td class="auto-style47">
                    <asp:Label ID="Label12" runat="server" Text="CHOOSE CARD"></asp:Label>
                </td>
                <td class="auto-style55"></td>
            </tr>
            <tr>
                <td class="auto-style17">&nbsp;</td>
                <td class="auto-style11">
                    <asp:ListBox ID="optionList" runat="server" Height="60px" CssClass="auto-style61" Width="400px">
                        <asp:ListItem Value="1">Create Category</asp:ListItem>
                        <asp:ListItem Value="2">Create Card</asp:ListItem>
                        <asp:ListItem Value="3">Update Category</asp:ListItem>
<asp:ListItem Value="4">Update Card</asp:ListItem>
                        <asp:ListItem Value="5">Delete Category</asp:ListItem>
                        <asp:ListItem Value="6">Delete Card</asp:ListItem>
                    </asp:ListBox>
                </td>
                <td class="auto-style68">
                    <asp:ListBox ID="categoryList" runat="server" Height="60px" Width="400px"></asp:ListBox>
                </td>
                <td class="auto-style48">
                    <asp:ListBox ID="cardList" runat="server" Height="60px" Width="400px"></asp:ListBox>
                </td>
                <td class="auto-style56"></td>
            </tr>
            <tr>
                <td class="auto-style18">&nbsp;</td>
                <td class="auto-style20">
                    <asp:Button ID="chooseOption" runat="server" Text="SELECT" OnClick="chooseOption_Click" />
                </td>
                <td class="auto-style69">
                    <asp:Button ID="chooseCategory" runat="server" Text="SELECT" OnClick="chooseCategory_Click" />
                </td>
                <td class="auto-style66">
                    <asp:Button ID="chooseCard" runat="server" Text="SELECT" OnClick="chooseCard_Click" />
                </td>
                <td class="auto-style57"></td>
            </tr>
            
            <tr>
                <td class="auto-style18">&nbsp;</td>
                <td class="auto-style20">
                    &nbsp;</td>
                <td class="auto-style69">
                    <asp:Label ID="Label11" runat="server" ForeColor="Red"></asp:Label>
                </td>
                <td class="auto-style49">&nbsp;</td>
                <td class="auto-style57">&nbsp;</td>
            </tr>
            
            <tr>
                <td class="auto-style32"></td>
                <td class="auto-style33">
                    <asp:Label ID="Label3" runat="server"></asp:Label>
                </td>
                <td class="auto-style70">
&nbsp;<asp:TextBox ID="nameTxtBox" runat="server" Width="400px"></asp:TextBox>
                </td>
                <td class="auto-style51" rowspan="5">
                    <asp:Image ID="blobImage" runat="server" Height="150px" Width="150px" />
                    </td>
                <td class="auto-style59"></td>
            </tr>
            
            <tr>
                <td class="auto-style38"></td>
                <td class="auto-style37">
                    <asp:Label ID="Label4" runat="server"></asp:Label>
                    </td>
                <td class="auto-style71">
                    <asp:TextBox ID="attributeOneTxtBox" runat="server" Width="400px"></asp:TextBox>
                </td>
                <td class="auto-style60"></td>
            </tr>
            
            <tr>
                <td class="auto-style38">&nbsp;</td>
                <td class="auto-style37">
                    <asp:Label ID="Label5" runat="server"></asp:Label>
                    </td>
                <td class="auto-style71">
                    <asp:TextBox ID="attributeTwoTxtBox" runat="server" Width="400px"></asp:TextBox>
                </td>
                <td class="auto-style60">&nbsp;</td>
            </tr>
            
            <tr>
                <td class="auto-style38">&nbsp;</td>
                <td class="auto-style37">
                    <asp:Label ID="Label6" runat="server"></asp:Label>
                    </td>
                <td class="auto-style71">
                    <asp:TextBox ID="attributeThreeTxtBox" runat="server" Width="400px"></asp:TextBox>
                </td>
                <td class="auto-style60">&nbsp;</td>
            </tr>
            
            <tr>
                <td class="auto-style38">&nbsp;</td>
                <td class="auto-style37">
                    <asp:Label ID="Label7" runat="server"></asp:Label>
                    </td>
                <td class="auto-style71">
                    <asp:TextBox ID="attributeFourTxtBox" runat="server" Width="400px"></asp:TextBox>
                </td>
                <td class="auto-style60">&nbsp;</td>
            </tr>
            
            <tr>
                <td class="auto-style38">&nbsp;</td>
                <td class="auto-style37">
                    <asp:Label ID="Label8" runat="server"></asp:Label>
                    </td>
                <td class="auto-style71">
                    <asp:TextBox ID="attributeFiveTxtBox" runat="server" Width="400px"></asp:TextBox>
                </td>
                <td class="auto-style52">&nbsp;</td>
                <td class="auto-style60">&nbsp;</td>
            </tr>
            
            <tr>
                <td class="auto-style38">&nbsp;</td>
                <td class="auto-style37">
                    <asp:Label ID="Label9" runat="server"></asp:Label>
                    </td>
                <td class="auto-style71">
                    <asp:FileUpload ID="blobUpload" runat="server" />
                </td>
                <td class="auto-style52">&nbsp;</td>
                <td class="auto-style60">&nbsp;</td>
            </tr>
            
            <tr>
                <td class="auto-style38">&nbsp;</td>
                <td class="auto-style37">
                    &nbsp;</td>
                <td class="auto-style71">
                    <asp:Label ID="Label13" runat="server" CssClass="auto-style72"></asp:Label>
                </td>
                <td class="auto-style52">&nbsp;</td>
                <td class="auto-style60">&nbsp;</td>
            </tr>
            
            <tr>
                <td class="auto-style38">&nbsp;</td>
                <td class="auto-style37">
                    &nbsp;</td>
                <td class="auto-style71">
                    <asp:Button ID="deleteCategory" runat="server" OnClick="deleteCategory_Click" Text="DELETE CATEGORY" />
                    <asp:Button ID="deleteCard" runat="server" OnClick="deleteCard_Click" Text="DELETE CARD" />
                    <asp:Button ID="updateCategory" runat="server" OnClick="updateCategory_Click" Text="UPDATE CATEGORY" />
                    <asp:Button ID="updateCard" runat="server" OnClick="updateCard_Click" Text="UPDATE CARD" />
                    <asp:Button ID="createCard" runat="server" OnClick="createCard_Click" Text="CREATE CARD" />
                    <asp:Button ID="createCategory" runat="server" OnClick="createCategory_Click" Text="CREATE CATEGORY" />
                </td>
                <td class="auto-style52">&nbsp;</td>
                <td class="auto-style60">&nbsp;</td>
            </tr>
            
            <tr>
                <td class="auto-style38">&nbsp;</td>
                <td class="auto-style37">
                    &nbsp;</td>
                <td class="auto-style71">
                    &nbsp;</td>
                <td class="auto-style52">&nbsp;</td>
                <td class="auto-style60">&nbsp;</td>
            </tr>
        </table>
    <div>
    
        <asp:DataList ID="DataList1" runat="server" DataSourceID="ObjectDataSource1">
        </asp:DataList>
        <asp:ObjectDataSource ID="ObjectDataSource1" runat="server"></asp:ObjectDataSource>
    
    </div>
    </form>
</body>
</html>
