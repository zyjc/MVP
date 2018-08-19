<%@ Page Language="C#" AutoEventWireup="true" CodeBehind="EmployeesManager.aspx.cs" Inherits="MVP.EmployeesManager" %>

<!DOCTYPE html>

<html xmlns="http://www.w3.org/1999/xhtml">
<head runat="server">
<meta http-equiv="Content-Type" content="text/html; charset=utf-8"/>
    <title></title>
</head>
<body>
    <form id="form1" runat="server">
        <div>
            <asp:DropDownList runat="server" ID="ddlDepartment"></asp:DropDownList>
            <asp:Button ID="btnSearch" runat="server" Text="查询" OnClick="btnSearch_Click" />
            <br />
            <asp:DataGrid runat="server" ID="dgEmployee"></asp:DataGrid>
        </div>
    </form>
</body>
</html>
