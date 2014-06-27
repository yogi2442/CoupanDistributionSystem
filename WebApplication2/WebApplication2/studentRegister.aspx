<%@ Page Language="C#" AutoEventWireup="true" CodeBehind="studentRegister.aspx.cs" Inherits="WebApplication2.studentRegister" %>

<!DOCTYPE html PUBLIC "-//W3C//DTD XHTML 1.0 Transitional//EN" "http://www.w3.org/TR/xhtml1/DTD/xhtml1-transitional.dtd">

<html xmlns="http://www.w3.org/1999/xhtml">
<head runat="server">
    <title></title>
</head>
<body>
    <form id="form1" runat="server">
    <div>
        <%--
        <asp:Table ID="Table1" runat="server">
            <asp:TableRow>
                <asp:TableCell>
                    <asp:Label ID="label_username" runat="server" Text="Username:"></asp:Label>                
                </asp:TableCell>
                <asp:TableCell>
                    <asp:TextBox ID="textbox_username" runat="server"></asp:TextBox>
                </asp:TableCell>
            </asp:TableRow>
            <asp:TableRow>
                <asp:TableCell>
                    <asp:Label ID="lable_name" runat="server" Text="Name:"></asp:Label>                
                </asp:TableCell>
                <asp:TableCell>
                    <asp:TextBox ID="textbox_name" runat="server"></asp:TextBox>
                </asp:TableCell>
            </asp:TableRow>
            <asp:TableRow>
                <asp:TableCell>
                    <asp:Label ID="label_email" runat="server" Text="E-mail:"></asp:Label>                
                </asp:TableCell>
                <asp:TableCell>
                    <asp:TextBox ID="textbox_email" runat="server"></asp:TextBox>
                </asp:TableCell>
            </asp:TableRow>
            <asp:TableRow>
                <asp:TableCell>
                    <asp:Label ID="label_password" runat="server" Text="Password:"></asp:Label>
                </asp:TableCell>
                <asp:TableCell>
                    <asp:TextBox ID="textbox_password" runat="server" TextMode="Password"></asp:TextBox>
                </asp:TableCell>
            </asp:TableRow>
        </asp:Table>
    --%>
    </div>
    
    
    <div runat="server" BackColor="#F7F6F3" BorderColor="#E6E2D8" 
        BorderPadding="4" BorderStyle="Solid" BorderWidth="1px" Font-Names="Verdana" 
        Font-Size="0.8em" ForeColor="#333333" Height="143px" Width="586px">
        <InstructionTextStyle Font-Italic="True" ForeColor="Black" />
        <LayoutTemplate>
            <table cellpadding="4" cellspacing="0" style="border-collapse:collapse;">
                <tr>
                    <td>
                        <table cellpadding="0" style="height:143px;width:586px;">
                            <tr>
                                <td align="center" colspan="2" 
                                    style="color:White;background-color:#5D7B9D;font-size:0.9em;font-weight:bold;">
                                    Register</td>
                            </tr>
                            <tr>
                                <td align="right">
                                    <asp:Label ID="label_username" runat="server" >Username:</asp:Label>
                                </td>
                                <td>
                                    <asp:TextBox ID="textbox_username" runat="server" Font-Size="0.8em"></asp:TextBox>
                                </td>
                            </tr>
                            <tr>
                                <td align="right">
                                    <asp:Label ID="label_name" runat="server" >Name:</asp:Label>
                                </td>
                                <td>
                                    <asp:TextBox ID="textbox_name" runat="server" Font-Size="0.8em"></asp:TextBox>
                                </td>
                            </tr>
                            <tr>
                                <td align="right">
                                    <asp:Label ID="label_email" runat="server">E-mail:</asp:Label>
                                </td>
                                <td>
                                     <asp:TextBox ID="textbox_email" runat="server" Font-Size="0.8em"></asp:TextBox>                                 
                                </td>
                            </tr>
                            <tr>
                                <td align="right">
                                    <asp:Label ID="label_password" runat="server">Password:</asp:Label>
                                </td>
                                <td>
                                     <asp:TextBox ID="textbox_password" runat="server" Font-Size="0.8em" 
                                         TextMode="Password" Height="19px"></asp:TextBox>                                 
                                </td>
                            </tr>
                            <tr>
                                <td align="right" colspan="2">
                                    <asp:Button ID="RegisterButton" runat="server" BackColor="#FFFBFF" 
                                        BorderColor="#CCCCCC" BorderStyle="Solid" BorderWidth="1px"
                                        Font-Names="Verdana" Font-Size="0.8em" ForeColor="#284775" Text="Register" onclick="register" />
                                </td>
                            </tr>
                        </table>
                    </td>
                </tr>
            </table>
        </LayoutTemplate>
        <LoginButtonStyle BackColor="#FFFBFF" BorderColor="#CCCCCC" BorderStyle="Solid" 
            BorderWidth="1px" Font-Names="Verdana" Font-Size="0.8em" ForeColor="#284775" />
        <TextBoxStyle Font-Size="0.8em" />
        <TitleTextStyle BackColor="#5D7B9D" Font-Bold="True" Font-Size="0.9em" 
            ForeColor="White" />
    </div>


    <br />
    <br />
    <br />


    </form>
</body>
</html>
