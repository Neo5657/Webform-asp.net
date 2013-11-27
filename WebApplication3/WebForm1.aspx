<%@ Page Language="C#" AutoEventWireup="true" CodeBehind="WebForm1.aspx.cs" Inherits="WebApplication3.WebForm1" %>

<!DOCTYPE html>

<html xmlns="http://www.w3.org/1999/xhtml">
<head runat="server">
    <title></title>
</head>
<body>
    <form id="form1" runat="server">
    <div>
    </div>
    <asp:Panel id="myPanel" Height="200" Width="350" BorderColor="#3333cc" BorderStyle="Outset" runat="server">
        <asp:Label id="label_cartoon" AssociatedControlId="txtbox_cartoon" Text="Cartoon:" runat="server" />
        <asp:TextBox id="txtbox_cartoon" CssClass="textInput" runat="server"/> 
        <asp:Button id="btn_cartoon" OnClick="tryIt" Text="Try it" runat="server" /> <br />
        <asp:Button id="btn_change_title" OnClick="changeTitle" Text="Change Title" runat="server" /> <br />
        <asp:Button id="btn_remove_click_me" OnClick="removeClickMe" Text="Remove Click Me" runat="server" /><br />
        <asp:DropDownList ID="drop_down" runat="server" AppendDataBoundItems="true" DataTextField="Company_Name" DataValueField="id">
            <asp:ListItem Text="---Select---" Value="0" /> 
            <asp:ListItem Text="Konstanz" Value="1" />  
            <asp:ListItem Text="Mainau" Value="2" />
            <asp:ListItem Text="Kreuzlingen" Value="3" />
        </asp:DropDownList>
        <asp:Button id="btn_drop_down" OnClick="writeDropDown" Text="Write Drop Down" runat="server" />
    </asp:Panel>

    <asp:CheckBox id="check" Text="Click to hide panel" OnCheckedChanged="hidePanel" AutoPostBack="true" runat="server"/>

    <asp:Panel id="myPanel2" Height="200" Width="350" BorderColor="#3333cc" BorderStyle="Outset" runat="server">
        <asp:Label id="label_concatenation" runat="server" EnableViewState="false" />
        <asp:Button id="btn_concatenation" OnClick="concatenateStrings" Text="Concatenate Strings" runat="server" /><br />

        <asp:HyperLink Text="I am actually a hyperlink" NavigateUrl="~/About.aspx" target="_blank" runat="server" /><br />
    </asp:Panel>

    </form>
</body>
</html>
