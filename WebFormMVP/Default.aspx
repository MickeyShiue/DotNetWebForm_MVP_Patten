<%@ Page Language="C#" AutoEventWireup="true" CodeBehind="Default.aspx.cs" Inherits="WebFormMVP.Default" %>

<!DOCTYPE html>

<html xmlns="http://www.w3.org/1999/xhtml">
<head runat="server">
<meta http-equiv="Content-Type" content="text/html; charset=utf-8"/>
    <title></title>
</head>
<body>
    <form id="form1" runat="server">
        <div>

              <asp:DropDownList ID="DropDownListDepartments" runat="server">
              </asp:DropDownList>
              <br />
            
            <asp:GridView ID="GridViewEmployee" runat="server"></asp:GridView>

              <asp:Button ID="ButtonSearch" runat="server" Text="查詢" OnClick="ButtonSearch_Click" />
        </div>
      
    </form>
</body>
</html>
