<%@ Page Title="" Language="C#" MasterPageFile="~/Site1.Master" AutoEventWireup="true" CodeBehind="WebForm3.aspx.cs" Inherits="mera_project.WebForm3" %>
<asp:Content ID="Content1" ContentPlaceHolderID="head" runat="server">
    <style type="text/css">
        .auto-style2 {
            width: 100%;
        }
    </style>
</asp:Content>
<asp:Content ID="Content2" ContentPlaceHolderID="ContentPlaceHolder1" runat="server">
    <table class="auto-style2">
        <tr>
            <td>
                <asp:HyperLink ID="HyperLink1" runat="server" NavigateUrl="~/WebForm3.aspx">View Customer by Id</asp:HyperLink>
                <table class="auto-style2">
                    <tr>
                        <td>Enter customer id:</td>
                        <td>
                            <asp:TextBox ID="TextBox1" runat="server" OnTextChanged="TextBox1_TextChanged"></asp:TextBox>
                            <asp:Button ID="Button1" runat="server" Text="Search" OnClick="Button1_Click" />
                        </td>
                        <td>&nbsp;</td>
                    </tr>
                </table>
            </td>
            <td>
                <asp:HyperLink ID="HyperLink2" runat="server" NavigateUrl="~/WebForm4.aspx">View Accounts</asp:HyperLink>
            </td>
            <td>
                <asp:HyperLink ID="HyperLink3" runat="server" NavigateUrl="~/Accountdetail.aspx">Add new Account</asp:HyperLink>
            </td>
            <td>
                <asp:HyperLink ID="HyperLink4" runat="server" NavigateUrl="~/WebForm2.aspx">View All customers</asp:HyperLink>
            </td>
        </tr>
    </table>
    <asp:GridView ID="GridView1" runat="server" style="text-align: left" >
    </asp:GridView>
</asp:Content>
