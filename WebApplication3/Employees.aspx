<%@ Page Language="C#" AutoEventWireup="true" CodeBehind="Employees.aspx.cs" Inherits="WebApplication3.Employees" %>

<!DOCTYPE html>

<html xmlns="http://www.w3.org/1999/xhtml">

<%@ Import Namespace="System.Data" %>

<head runat="server">
    <title></title>
</head>
<body>
    <form id="form1" runat="server">
    <div>
        <p>Sunt in employee.</p>
    </div>
        <table>
            <thead>
                <tr>
                    <td>Name</td>
                    <td>Id</td>
                    <td>City</td>
                    <td>Department</td>
                    <td>Company</td>
                </tr>
            </thead>
            <tbody>
            <asp:Repeater id="myRepeater" runat="server">

                <ItemTemplate>
                        <tr>
                            <td><%#Eval("Name")%></td>
                            <td><%#Eval("Id")%></td>
                            <td><%#Eval("HomeCity")%></td>
                            <td><%#Eval("Department")%></td>
                            <td><%#Eval("Company")%></td>
                        </tr>
                </ItemTemplate>
            </asp:Repeater>
                </tbody>
        </table>


    </form>
</body>
</html>
