<%@ Page Language="C#" AutoEventWireup="true" CodeBehind="Employees.aspx.cs" Inherits="WebApplication3.Employees" %>

<!DOCTYPE html>

<html xmlns="http://www.w3.org/1999/xhtml">

<%@ Import Namespace="System.Data" %>

<head runat="server">
    <title></title>
    <link rel="stylesheet" type="text/css" href="GridView.css">
</head>
<body>
    <form id="form1" runat="server">
    <div>
        <p>Sunt in employee.</p>
    </div>
        <%--<table border="1" color="black">
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

                <AlternatingItemTemplate>
                    <tr>
                        <tr style="background-color:goldenrod">
                            <td><%#Eval("Name")%></td>
                            <td><%#Eval("Id")%></td>
                            <td><%#Eval("HomeCity")%></td>
                            <td><%#Eval("Department")%></td>
                            <td><%#Eval("Company")%></td>
                        </tr>

                    </tr>
                </AlternatingItemTemplate>

            </asp:Repeater>
                </tbody>
        </table>--%>

        <asp:GridView runat="server" id="myGridView" CellPadding="5" CssClass="GridView" Gridlines="None" AutoGenerateColumns="false" >
	        <HeaderStyle CssClass="GridViewHeader" VerticalAlign="Bottom" />
	        <RowStyle CssClass="GridViewRow" VerticalAlign="Top" />
	        <AlternatingRowStyle CssClass="GridViewAlternatingRow" VerticalAlign="Top" />

            <Columns>
                <asp:BoundField DataField="Id" HeaderText="Id"/>
                <asp:BoundField DataField="Name" HeaderText="Name"/>
                <asp:BoundField DataField="HomeCity" HeaderText="HomeCity"/>
                <asp:BoundField DataField="Department" HeaderText="Department"/>
                <asp:BoundField DataField="Company" HeaderText="Company"/>
                <asp:BoundField DataField="Manager.Name" HeaderText="Manager"/>
                <asp:TemplateField>
                    <ItemTemplate>
                        <asp:Button ID="btn_edit" Text="Edit" runat="server"/>
                    </ItemTemplate>
                </asp:TemplateField>

                <asp:TemplateField>
                    <ItemTemplate>
                        <asp:Button ID="btn_delete" Text="Delete" runat="server"/>
                    </ItemTemplate>
                </asp:TemplateField>

            </Columns>

        </asp:GridView>

        <asp:LinkButton Text="Add New Employee" target="_blank" PostBackUrl="~/addEmployee.aspx" runat="server" /><br />

    </form>
</body>
</html>
