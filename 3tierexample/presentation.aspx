<%@ Page Language="C#" AutoEventWireup="true" CodeBehind="presentation.aspx.cs" Inherits="_3tierexample.presentation" %>

<!DOCTYPE html>

<html xmlns="http://www.w3.org/1999/xhtml">
<head runat="server">
    <title></title>
    <style type="text/css">
        .auto-style3 {
            text-align: center;
        }
    </style>
</head>
<body>
    <form id="form1" runat="server">
       <table>
           <tr>
               <td class="auto-style3">
                   addressid:<asp:TextBox ID="txtaddressid" runat="server"></asp:TextBox>
               </td>
           </tr>
           <tr>
               <td>
                   firstname:<asp:TextBox ID="txtfirstname" runat="server"></asp:TextBox>
               </td>
           </tr>
           <tr>
               <td> lastname:<asp:TextBox ID="txtlastname" runat="server"></asp:TextBox></td>
               
           </tr>
           <tr>
               <td>email:<asp:TextBox ID="txtemail" runat="server"></asp:TextBox></td>
           </tr>
           <tr>
               <td> phonenumber:<asp:TextBox ID="txtphonenumber" runat="server"></asp:TextBox></td>
           </tr>
           <tr>

               <td>
                   <asp:Button ID="btnsave" runat="server" Text="save" OnClick="btnsave_Click" />

               </td>
               <td>
                   <asp:Button ID="btnupdate" runat="server" Text="Update" OnClick="btnupdate_Click"/>
               </td>
               <td>
                   <asp:Button ID="btndelete" runat="server" Text="Delete" OnClick="btndelete_Click"/>
               </td>
           </tr>
       </table>
        <asp:GridView ID="GridView1" runat="server" BackColor="#DEBA84" BorderColor="#DEBA84" BorderStyle="None" BorderWidth="1px" CellPadding="3" CellSpacing="2">
            <FooterStyle BackColor="#F7DFB5" ForeColor="#8C4510" />
            <HeaderStyle BackColor="#A55129" Font-Bold="True" ForeColor="White" />
            <PagerStyle ForeColor="#8C4510" HorizontalAlign="Center" />
            <RowStyle BackColor="#FFF7E7" ForeColor="#8C4510" />
            <SelectedRowStyle BackColor="#738A9C" Font-Bold="True" ForeColor="White" />
            <SortedAscendingCellStyle BackColor="#FFF1D4" />
            <SortedAscendingHeaderStyle BackColor="#B95C30" />
            <SortedDescendingCellStyle BackColor="#F1E5CE" />
            <SortedDescendingHeaderStyle BackColor="#93451F" />
        </asp:GridView>
    </form>
</body>
</html>
