<%@ Page Language="C#" AutoEventWireup="true" CodeBehind="ReturnResults.aspx.cs" Inherits="BrollTestApi.ReturnResults" %>

<!DOCTYPE html>

<html xmlns="http://www.w3.org/1999/xhtml">
<head runat="server">
    <link href="https://stackpath.bootstrapcdn.com/bootstrap/4.1.3/css/bootstrap.min.css" rel="stylesheet" />
    <title></title>
</head>
<body>
    <form id="form1" runat="server">
        <div style="margin-left: 20px; font-size: 50px;">
            <header>Testing API.</header>
        </div>
        <br />
        <div style="margin-left: 250px;">
            <table>
                <tr>
                    <td>Type in Unquie Key :
                    </td>
                    <td></td>
                </tr>
                <tr>
                    <td>File Name
                       <asp:TextBox ID="txtResult" runat="server"></asp:TextBox>
                    </td>
                    <td>
                        <asp:FileUpload ID="flUpload" runat="server" />
                    </td>
                </tr>
            </table>
            <br />
            <b>
                <asp:Button ID="btnSave" runat="server" Text="Save." OnClick="btnSave_Click" />
            </b>
        </div>
        <br />
        <div style="margin-top: 10px; margin-left: 30px;">
            <asp:DropDownList ID="dllSelect" AutoPostBack="true" Width="200px" OnSelectedIndexChanged="dllSelect_SelectedIndexChanged" runat="server">
                <asp:ListItem>Currency</asp:ListItem>
                <asp:ListItem>Agent</asp:ListItem>
                <asp:ListItem>DocumentList</asp:ListItem>
                <asp:ListItem>Branches</asp:ListItem>
                <asp:ListItem>Municipalities</asp:ListItem>
                <asp:ListItem>Meter</asp:ListItem>
                <asp:ListItem>Regions</asp:ListItem>
                <asp:ListItem>InvoiceTypes</asp:ListItem>
                <asp:ListItem>IPDNodes</asp:ListItem>
                <asp:ListItem>IDPTypes</asp:ListItem>
                <asp:ListItem>Portfolio</asp:ListItem>
                <asp:ListItem>Building Types</asp:ListItem>
                <asp:ListItem>All Buildings</asp:ListItem>
                <asp:ListItem>Global Acc Level1</asp:ListItem>
                <asp:ListItem>Global Acc Level2</asp:ListItem>
                <asp:ListItem>Global Acc Desc</asp:ListItem>
                <asp:ListItem>Gl Acc Building</asp:ListItem>
                <asp:ListItem>FoxConversion</asp:ListItem>
                <asp:ListItem>VAT</asp:ListItem>
                <asp:ListItem>BuildingCharges</asp:ListItem>
                <asp:ListItem>BuildingSpace</asp:ListItem>
                <asp:ListItem>GetBuildingSpace</asp:ListItem>
                <asp:ListItem>GetPremisesTypes</asp:ListItem>
                <asp:ListItem>GetPremises</asp:ListItem>
                <asp:ListItem>EntranceType</asp:ListItem>
                <asp:ListItem>GetEntrance</asp:ListItem>
            </asp:DropDownList>
        </div>
        <br />
        <br />
        <div style="margin-top: 10px; margin-left: 30px;">
            <div>
                <asp:Button ID="btnReturn" runat="server" Text="Get Locale.." Width="200px" OnClick="btnReturn_Click" />
            </div>
            <br />
            <div>
                <asp:Button ID="btnSaveBuildingSpace" runat="server" Text="Save Building Space" Width="200px" OnClick="btnSaveBuildingSpace_Click" />
            </div>
            <br />
            <div>
                <asp:Button ID="btnBuilding" runat="server" Text="Get Building" Width="200px" OnClick="btnBuilding_Click" />
            </div>
            <%--<br />--%>
            <%--<div>
                <asp:Button ID="btnGetBuildingType" runat="server" Text="Building Type" Width="200px" OnClick="btnGetBuildingType_Click" />
            </div>--%>
            <br />
            <div>
                <asp:Button ID="btnGetBuildingShare" runat="server" Text="Save Building Account" Width="200px" OnClick="btnGetBuildingShare_Click" />
            </div>
            <br />

            <%--<div>
                <asp:Button ID="btnGetOwnerDocument" runat="server" Text="Owner Document" Width="200px" OnClick="btnGetOwnerDocument_Click" />
            </div>--%>
            <%--<br />
            <div>
                <asp:Button ID="btnGetBranches" runat="server" Text="Get Branches" Width="200px" OnClick="btnGetBranches_Click" />
            </div>--%>
            <br />
            <div>
                <asp:Button ID="btnGetMunicipal" runat="server" Text="Save Building ChargeType" Width="200px" OnClick="btnGetMunicipal_Click" />
            </div>
            <br />
            <div>
                <asp:Button ID="btnGetMeter" runat="server" Text="Save Building" Width="200px" OnClick="btnGetMeter_Click" />
            </div>
            <br />
            <div>
                <asp:Button ID="btnGetType" runat="server" Text="Save Owner Document" Width="200px" OnClick="btnGetType_Click" />
            </div>
            <br />
            <div>
                <asp:Button ID="btnGetIDPsub" runat="server" Text="Get IDP sub" Width="200px" OnClick="btnGetIDPsub_Click" />
                <br />
                <br />
                <b>
                    <asp:TextBox ID="txtIDPSub" runat="server"></asp:TextBox><asp:Label ID="lblError" runat="server" Text=""></asp:Label>
                </b>
            </div>

            <br />
            <br />
        </div>
        <div style="margin-top: -400px; margin-left: 300px;">
            <br />
            <asp:GridView ID="dgrResults" runat="server" CssClass="table table-responsive table-striped"></asp:GridView>
            <br />
            <asp:Label ID="lblMessage" runat="server" Text=""></asp:Label>
            <br />
        </div>

    </form>
</body>
</html>
