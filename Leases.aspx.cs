using System;
using System.Collections.Generic;
using System.Linq;
using System.Web;
using System.Web.UI;
using System.Web.UI.WebControls;
using System.Data;

namespace BrollTestApi
{
    public partial class Leases : System.Web.UI.Page
    {

        TestApi.IntegrationAPIClient client = new TestApi.IntegrationAPIClient();
        TestApi.BuildingObj build = new TestApi.BuildingObj();

        int Localekey = 2008;

        protected void Page_Load(object sender, EventArgs e)
        {
            //GetLeaseType();
            GetBuilding();
        }

        protected void GetBuilding()
        {
            Guid obj = Guid.NewGuid();

            var temp = Guid.Parse("ebe6f46e-d1fb-4754-8eed-3d64e37def98");
            string AuditUser = "Chumani";
            string BOLUserID = "gchangfoot";

            int Building_Key = 410;

            var info = client.GetBuilding(temp,AuditUser,Localekey,Building_Key,BOLUserID);

            dgrsResults.DataSource = info.dtResult;
            dgrsResults.DataBind();
        }
        protected void GetLeaseType()
        {
            Guid obj = Guid.NewGuid();

            var temp = Guid.Parse("ebe6f46e-d1fb-4754-8eed-3d64e37def98");
            string AuditUser = "Chumani";
            string BOLUserID = "gchangfoot";

            int Building_Key = 410;

            var info = client.GetLeaseTypes(temp, AuditUser, Localekey, Building_Key, BOLUserID);

            dgrsResults.DataSource = info.dtResult;
            dgrsResults.DataBind();
        }

        protected void GetLeases()
        {
            Guid obj = Guid.NewGuid();

            var temp = Guid.Parse("ebe6f46e-d1fb-4754-8eed-3d64e37def98");
            string AuditUser = "Chumani";
            string BOLUserID = "gchangfoot";


        }


        protected void SaveLeaseHeader()
        {
            Guid obj = Guid.NewGuid();

            var temp = Guid.Parse("ebe6f46e-d1fb-4754-8eed-3d64e37def98");
            string AuditUser = "Chumani";
            string BOLUserID = "gchangfoot";

            TestApi.LeaseHeaderObj objheader = new TestApi.LeaseHeaderObj();

            objheader.Lease_key = Convert.ToInt32(txtLeaseKey.Text);
            //Key 
            objheader.Building_Key = Convert.ToInt32(txtBuildingKey.Text);
            objheader.CaptureFormNum = txtCaptureFormNum.Text;
            objheader.Tenant = txtTenant.Text;
            objheader.TradingAs = txtTradingAs.Text;
            objheader.StartDate = Convert.ToDateTime("2019-09-30");
            objheader.EndDate = Convert.ToDateTime("2019-09-30");
            objheader.Grade = txtGrade.Text;
            //key
            objheader.TenantType = txtTenantType.Text;
            objheader.RecoveryPerc = 100.00F;
            objheader.TenantYrEnd = Convert.ToInt32(txtTenantYrEnd.Text);
            objheader.NoticeDate = Convert.ToDateTime("2019-09-30");
            objheader.LeaseSigned = Convert.ToInt32(txtLeaseSigned.Text);
            objheader.RenewalDate = Convert.ToDateTime("2019-09-30");
            objheader.MonthlyIND = Convert.ToInt32(txtMonthlyIND.Text);
            //key
            objheader.LeaseType_Key = Convert.ToInt32(txtLeaseTypeKey.Text);
            //key
            objheader.VendorID = Convert.ToInt32(txtVendorId.Text);
            objheader.CommissionCharged = Convert.ToDecimal(txtCommissionCharged.Text);
            objheader.CommissionPayee = txtCommissionPayee.Text;
            objheader.TerminationReason = txtTerminationReason.Text;

            var info = client.SaveLeaseHeader(temp, AuditUser, Localekey, objheader, BOLUserID);

            lblError.Text = info.SystemMessage;
        }

        protected void ButtonSaveLeaseHeader_Click(object sender, EventArgs e)
        {
            SaveLeaseHeader();
        }
    }
}