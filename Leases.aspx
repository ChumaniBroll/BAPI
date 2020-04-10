<%@ Page Language="C#" AutoEventWireup="true" CodeBehind="Leases.aspx.cs" Inherits="BrollTestApi.Leases" %>

<!DOCTYPE html>

<html xmlns="http://www.w3.org/1999/xhtml">
<head runat="server">
    <link href="https://stackpath.bootstrapcdn.com/bootstrap/4.1.3/css/bootstrap.min.css" rel="stylesheet" />
    <title></title>
</head>
<body>
    <form id="form1" runat="server">
        <div style="margin-left: 20px; font-size: 30px;">
            <header>Testing API Leases.</header>
        </div>
        <br />
        <div style="margin-left: 50px;">
            <div>
                <h5>Save Lease Header
                </h5>
                <table>
                    <tr>
                        <td>Lease Key</td>
                        <td>
                            <asp:TextBox ID="txtLeaseKey" runat="server"></asp:TextBox></td>
                    </tr>
                    <tr>
                        <td>Building Key</td>
                        <td>
                            <asp:TextBox ID="txtBuildingKey" runat="server"></asp:TextBox></td>
                    </tr>
                    <tr>
                        <td>CaptureFormNum</td>
                        <td>
                            <asp:TextBox ID="txtCaptureFormNum" runat="server"></asp:TextBox></td>
                    </tr>
                    <tr>
                        <td>Tenant</td>
                        <td>
                            <asp:TextBox ID="txtTenant" runat="server"></asp:TextBox></td>
                    </tr>
                    <tr>
                        <td>TradingAs</td>
                        <td>
                            <asp:TextBox ID="txtTradingAs" runat="server"></asp:TextBox></td>
                    </tr>
                    <tr>
                        <td>Grade</td>
                        <td>
                            <asp:TextBox ID="txtGrade" runat="server"></asp:TextBox></td>
                    </tr>
                    <tr>
                        <td>TenantType</td>
                        <td>
                            <asp:TextBox ID="txtTenantType" runat="server"></asp:TextBox></td>
                    </tr>
                    <tr>
                        <td>TenantYrEnd</td>
                        <td>
                            <asp:TextBox ID="txtTenantYrEnd" runat="server"></asp:TextBox></td>
                    </tr>
                    <tr>
                        <td>LeaseSigned</td>
                        <td>
                            <asp:TextBox ID="txtLeaseSigned" runat="server"></asp:TextBox></td>
                    </tr>
                    <tr>
                        <td>MonthlyIND</td>
                        <td>
                            <asp:TextBox ID="txtMonthlyIND" runat="server"></asp:TextBox></td>
                    </tr>
                    <tr>
                        <td>LeaseType_Key</td>
                        <td>
                            <asp:TextBox ID="txtLeaseTypeKey" runat="server"></asp:TextBox></td>
                    </tr>
                    <tr>
                        <td>VendorID</td>
                        <td>
                            <asp:TextBox ID="txtVendorId" runat="server"></asp:TextBox></td>
                    </tr>
                    <tr>
                        <td>CommissionCharged</td>
                        <td>
                            <asp:TextBox ID="txtCommissionCharged" runat="server"></asp:TextBox></td>
                    </tr>
                    <tr>
                        <td>CommissionPayee</td>
                        <td>
                            <asp:TextBox ID="txtCommissionPayee" runat="server"></asp:TextBox></td>
                    </tr>
                    <tr>
                        <td>TerminationReason</td>
                        <td>
                            <asp:TextBox ID="txtTerminationReason" runat="server"></asp:TextBox></td>
                    </tr>
                    <tr>
                        <td>
                            <asp:Button ID="ButtonSaveLeaseHeader" OnClick="ButtonSaveLeaseHeader_Click" runat="server" Text="Save" /></td>
                        <td>
                            <asp:Label ID="lblError" runat="server" Text=""></asp:Label>
                        </td>
                    </tr>
                </table>
            </div>
        </div>
        <div style="padding: 0px 0px 0px 500px; margin-top: -500px">
            <asp:GridView ID="dgrsResults" CssClass="table table-responsive table-striped" runat="server">
            </asp:GridView>
        </div>
    </form>
</body>
</html>
