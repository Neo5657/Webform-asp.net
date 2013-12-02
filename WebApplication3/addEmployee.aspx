<%@ Page Language="C#" AutoEventWireup="true" CodeBehind="addEmployee.aspx.cs" Inherits="WebApplication3.addEmployee" %>

<!DOCTYPE html>

<html xmlns="http://www.w3.org/1999/xhtml">
<head runat="server">
    <title></title>
</head>
<body>
    <form id="form1" runat="server">
    <div>
        
        <asp:Label style="text-align:right; margin-right:35px" id="label_name" AssociatedControlId="txtbox_name" Text="Name:" runat="server" />
        <asp:TextBox style="grid-column-align:center" id="txtbox_name" runat="server" /> <br /> 
       
        <asp:Label style="text-align:right; margin-right:35px" id="label_city" AssociatedControlId="txtbox_city" Text="City:" runat="server" />
        <asp:TextBox style="grid-column-align:center" id="txtbox_city" runat="server" /> <br />
        
        <asp:Label style="margin-right:35px" id="label_dpt" AssociatedControlId="txtbox_dpt" Text="Department:" runat="server" />
        <asp:TextBox style="align-content:center" id="txtbox_dpt" runat="server" /> <br />

        <asp:Label style="margin-right:35px" id="label_comp" AssociatedControlId="txtbox_comp" Text="Company:" runat="server" />
        <asp:TextBox style="align-content:center" id="txtbox_comp" runat="server" /> <br />

        <asp:Label style="margin-right:35px" id="label_mgr" Text="Manager:" runat="server" />
        <asp:DropDownList ID="drop_down" runat="server" AppendDataBoundItems="true">
            <asp:ListItem Text="NULL"/> 
        </asp:DropDownList> <br />

        <asp:Button ID="btn_add" Text="Add" onClick="btn_add_Click" runat="server"/>
        <asp:Button ID="btn_cancel" onClick="btn_add_Cancel" Text="Cancel" runat="server"/>
    </div>
    </form>
</body>
</html>
