<%@ Page Language="C#" AutoEventWireup="true" CodeBehind="ConStateCity.aspx.cs" Inherits="AssigConStateCity.ConStateCity" %>

<!DOCTYPE html>

<html xmlns="http://www.w3.org/1999/xhtml">
<head runat="server">
    <title></title>
    <style type="text/css">
        .auto-style1 {
            margin-left: 40px;
        }
        .auto-style2 {
            margin-left: 360px;
        }
    </style>
</head>
<body style="margin-bottom: 56px">
    <form id="form1" runat="server">
        <div class="auto-style1">
            Country:&nbsp;&nbsp;&nbsp;&nbsp;&nbsp;&nbsp;&nbsp;&nbsp;
            <asp:DropDownList ID="DDL1_Country" runat="server" AutoPostBack="True" DataTextField="Country_Name" OnSelectedIndexChanged="DDL1_Country_SelectedIndexChanged">
            </asp:DropDownList>
        </div>
        <p class="auto-style1">
            &nbsp;</p>
        <p class="auto-style1">
            State&nbsp;&nbsp;&nbsp;&nbsp;&nbsp;&nbsp;&nbsp;&nbsp;&nbsp;&nbsp;&nbsp; :<asp:DropDownList ID="DDL2_State" runat="server" AutoPostBack="True" DataTextField="State_Name" OnSelectedIndexChanged="DDL2_State_SelectedIndexChanged">
            </asp:DropDownList>
        </p>
        <p class="auto-style1">
            &nbsp;</p>
        <p class="auto-style1">
            City&nbsp;&nbsp;&nbsp;&nbsp;&nbsp;&nbsp;&nbsp;&nbsp;&nbsp;&nbsp;&nbsp; :<asp:DropDownList ID="DDL3_City" runat="server" AutoPostBack="True" DataTextField="City_Name" OnSelectedIndexChanged="DDL3_City_SelectedIndexChanged">
            </asp:DropDownList>
        </p>
        <p class="auto-style2">
            <asp:Button ID="btnOk" runat="server" Text="Ok" />
        </p>
    </form>
</body>
</html>
