using System;
using System.Collections.Generic;
using System.Linq;
using System.Web;
using System.Web.UI;
using System.Web.UI.WebControls;
using System.Data;
namespace BrollTestApi
{
    public partial class ReturnResults : System.Web.UI.Page
    {
        TestApi.IntegrationAPIClient client = new TestApi.IntegrationAPIClient();
        TestApi.BuildingObj build = new TestApi.BuildingObj();

        int Localekey = 2008;

        protected void Page_Load(object sender, EventArgs e)
        {

        }

        protected void btnReturn_Click(object sender, EventArgs e)
        {
            RunService();
        }

        protected void RunService()
        {
            Guid obj = Guid.NewGuid();
            var temp = Guid.Parse("ebe6f46e-d1fb-4754-8eed-3d64e37def98");
            string AuditUser = "Chumani";
            string BOLUserID = "gchangfoot";
            var info = client.GetLocales(temp, AuditUser, BOLUserID);
            dgrResults.DataSource = info.dtResult;
            dgrResults.DataBind();
            client.Close();
        }


        protected void SaveBuilding()
        {
            Guid obj = Guid.NewGuid();
            var temp = Guid.Parse("ebe6f46e-d1fb-4754-8eed-3d64e37def98");
            string AuditUser = "Chumani";
            string BOLUserID = "gchangfoot";
            //int key = Convert.ToInt32(txtResult.Text);

            TestApi.OwnerObj owner = new TestApi.OwnerObj();

            // Automatic insert 

            owner.OwnersKey = 0;
            owner.Owners_Name = "Broll Property building Owners";
            owner.YearEnd = 4;
            owner.VAT_No = "2090";
            owner.BRegNo = "094903";
            owner.Address = "Broll Group Building";
            owner.Tel = "011-023-9490";
            owner.BillingDate = 31;
            owner.IsManagingAgent = "N";
            owner.IsActive = "Y";
            owner.AccName = "60006300490305903";

            var infosave = client.SaveBuildingOwner(temp, AuditUser, Localekey, owner, BOLUserID);
            //infosave.KeyName = txtResult.Text;
        }

        protected void SaveBuildingShare()
        {
            Guid obj = Guid.NewGuid();
            var temp = Guid.Parse("ebe6f46e-d1fb-4754-8eed-3d64e37def98");
            string AuditUser = "Chumani";
            string BOLUserID = "gchangfoot";
            //int key = 2008;

            TestApi.ShareOwnerObj share = new TestApi.ShareOwnerObj();

            share.OwnersShareKey = 0;

            // Ensure the key is the same, when returning values 
            share.OwnersKey = 10;
            share.Owners_Name = "Broll Property";
            share.YearEnd = 9;
            share.VAT_No = "VAT3994020949333";
            share.BRegNo = "09030940300395";
            share.BillingDate = 20;
            share.ShareUnits = 049930;
            share.Share_Percentage = 03;


            var info = client.SaveBuildingShareOwner(temp, AuditUser, Localekey, share, BOLUserID);
        }

        protected void SaveMeter()
        {
            Guid obj = Guid.NewGuid();
            var temp = Guid.Parse("ebe6f46e-d1fb-4754-8eed-3d64e37def98");
            string AuditUser = "Chumani";
            string BOLUserID = "gchangfoot";

            TestApi.MeterReaderObj meter = new TestApi.MeterReaderObj();

            meter.Reader_Key = 0;
            meter.Company = "Broll meter";
            meter.Email = "broll@co.za";
            meter.FirstName = "name";
            meter.LastName = "last name";
            meter.ContactNo = "09394902";
            meter.Notes = "Plese try and sort out the bill outstanding.";
            meter.Active = true;

            var info = client.SaveMeterReader(temp, AuditUser, Localekey, meter, BOLUserID);

        }


        protected void SaveOwnerDocument()
        {
            Guid obj = Guid.NewGuid();
            var temp = Guid.Parse("ebe6f46e-d1fb-4754-8eed-3d64e37def98");
            string AuditUser = "Chumani";
            string BOLUserID = "gchangfoot";
            int ownerskey = 510;

            TestApi.DocumentObj document = new TestApi.DocumentObj();

            if (flUpload.PostedFile != null)
            {
                string path = string.Concat(Server.MapPath("~/UploadFile/" + flUpload.FileName));

                flUpload.PostedFile.SaveAs(path);

                txtResult.Text = flUpload.FileName;
            }
            //int doc = 0;

            document.DocID = 0;
            document.DocTypeID = 10;
            document.FileName = flUpload.FileName;
            document.DocName = "Property Name";
            document.ExpiryDate = Convert.ToDateTime("2019-09-09");
            document.Version = "0.009";
            document.Comments = "";
            document.PhysicalLocationID = "";
            document.LocationCode = "Next";
            document.Barcode = "";
            document.Archivecode = "0093";

            var info = client.SaveOwnerDocument(temp, AuditUser, Localekey, ownerskey, document, BOLUserID);
        }

        protected void Savebuilding()
        {

            Guid obj = Guid.NewGuid();
            var temp = Guid.Parse("ebe6f46e-d1fb-4754-8eed-3d64e37def98");
            string AuditUser = "Chumani";
            string BOLUserID = "gchangfoot";

            TestApi.BuildingObj build = new TestApi.BuildingObj();

            build.Building_Key = 0;
            build.Admin_fee_key = 2;
            build.Branch_key = 1;
            build.Portfolio_key = 11;
            build.BuildingType_key = 1;
            build.Building_Code = "9087";
            build.Name = "Sandton City Square";
            build.Owners_key = 10;

            build.Reporting_Region = 1;
            build.TenantInvoiceType = 1;
            build.ManagingAgent_Key = 558;

            build.YrEnd = 7;
            build.IPDSubTypeID = 12;
            build.IPDNodeID = 19;
            var info = client.SaveBuilding(temp, AuditUser, Localekey, build, BOLUserID);


        }

        protected void SaveBuildingCharge()
        {
            Guid obj = Guid.NewGuid();
            var temp = Guid.Parse("ebe6f46e-d1fb-4754-8eed-3d64e37def98");
            string AuditUser = "Chumani";
            string BOLUserID = "gchangfoot";

            TestApi.BuildingChargeTypeObj buildingtype = new TestApi.BuildingChargeTypeObj();
            buildingtype.BuildingChargeType_Key = 0;
            buildingtype.Building_Key = 1145;
            buildingtype.ChargeType = "4FC";
            buildingtype.GlobalAcc_Descr = "Operating cost retail";
            buildingtype.BuildingAcc_Key = 6021700;
            buildingtype.ForexTypeID = 1;
            buildingtype.VATCode = "VAT001";
            buildingtype.Active = 1;

            var info = client.SaveBuildingChargeType(temp, AuditUser, Localekey, buildingtype, BOLUserID);

        }

        protected void SaveBuildingAccount()
        {
            Guid obj = Guid.NewGuid();
            var temp = Guid.Parse("ebe6f46e-d1fb-4754-8eed-3d64e37def98");
            string AuditUser = "Chumani";
            string BOLUserID = "gchangfoot";

            TestApi.BuildingAccountObj buildAcc = new TestApi.BuildingAccountObj();

            buildAcc.BuildingAcc_Key = 0;
            buildAcc.Building_Key = 3623;
            buildAcc.GlobalAcc_Key = 6021700;
            // buildAcc.
            buildAcc.GlobalAcc_Descr = "Operating cost retail";
            buildAcc.Status = "Open";

            // client.SaveBuildingAccount()

            var info = client.SaveBuildingAccount(temp, AuditUser, Localekey, buildAcc, BOLUserID);

            lblError.Text = info.SystemMessage.ToString();

        }


        protected void GetGlobalAccs()
        {
            Guid obj = Guid.NewGuid();
            var temp = Guid.Parse("ebe6f46e-d1fb-4754-8eed-3d64e37def98");
            string AuditUser = "Chumani";
            string BOLUserID = "gchangfoot";
            int buildkey = 2;

            var info = client.GetGlobalAccs_Level1(temp, AuditUser, Localekey, buildkey, BOLUserID);

            dgrResults.DataSource = info.dtResult;
            dgrResults.DataBind();

            //lblMessage.ForeColor = System.Drawing.Color.Red;
            //lblMessage.Text = info.SystemMessage.ToString();
        }

        protected void GetGlobalAccs2()
        {
            Guid obj = Guid.NewGuid();
            var temp = Guid.Parse("ebe6f46e-d1fb-4754-8eed-3d64e37def98");
            string AuditUser = "Chumani";
            string BOLUserID = "gchangfoot";
            int buildkey = 2;
            string Level = "income";
            var info = client.GetGlobalAccs_Level2(temp, AuditUser, Localekey, buildkey, Level, BOLUserID);

            dgrResults.DataSource = info.dtResult;
            dgrResults.DataBind();

            //lblMessage.ForeColor = System.Drawing.Color.Red;
            //lblMessage.Text = info.SystemMessage.ToString();
        }

        protected void GetGlobalAcc_Desc()
        {
            Guid obj = Guid.NewGuid();
            var temp = Guid.Parse("ebe6f46e-d1fb-4754-8eed-3d64e37def98");
            string AuditUser = "Chumani";
            string BOLUserID = "gchangfoot";
            int buildkey = 2;
            string Level = "income";
            string level2 = "Recoveries";
            //string levlRent = "rent";
            var info = client.GetGlobalAcc_Descriptions(temp, AuditUser, Localekey, buildkey, Level, level2, BOLUserID);

            dgrResults.DataSource = info.dtResult;
            dgrResults.DataBind();

            //lblMessage.ForeColor = System.Drawing.Color.Red;
            //lblMessage.Text = info.SystemMessage.ToString();
        }

        protected void GetBuildingAcc_GLAcc()
        {
            Guid obj = Guid.NewGuid();
            var temp = Guid.Parse("ebe6f46e-d1fb-4754-8eed-3d64e37def98");
            string AuditUser = "Chumani";
            string BOLUserID = "gchangfoot";
            int buildingkey = 0;
            int globalAcc = 6021700;

            var info = client.GetBuildingAcc_GlAccs(temp, AuditUser, Localekey, buildingkey, globalAcc, BOLUserID);

            dgrResults.DataSource = info.dtResult;
            dgrResults.DataBind();
        }

        protected void GetForex()
        {
            Guid obj = Guid.NewGuid();
            var temp = Guid.Parse("ebe6f46e-d1fb-4754-8eed-3d64e37def98");
            string AuditUser = "Chumani";
            string BOLUserID = "gchangfoot";

            var into = client.GetForexConversionTypes(temp, AuditUser, Localekey, BOLUserID);

            dgrResults.DataSource = into.dtResult;
            dgrResults.DataBind();
        }

        protected void GetVATInt()
        {
            Guid obj = Guid.NewGuid();
            var temp = Guid.Parse("ebe6f46e-d1fb-4754-8eed-3d64e37def98");
            string AuditUser = "Chumani";
            string BOLUserID = "gchangfoot";

            var into = client.GetVATIntTypes(temp, AuditUser, Localekey, BOLUserID);

            dgrResults.DataSource = into.dtResult;
            dgrResults.DataBind();
        }

        protected void GetBuildingChargeTypesAll()
        {
            Guid obj = Guid.NewGuid();
            var temp = Guid.Parse("ebe6f46e-d1fb-4754-8eed-3d64e37def98");
            string AuditUser = "Chumani";
            string BOLUserID = "gchangfoot";
            int key = 643;
            var info = client.GetBuildingChargeTypesAll(temp, AuditUser, Localekey, key, BOLUserID);

            dgrResults.DataSource = info.dtResult;
            dgrResults.DataBind();
        }

        protected void IPDTypes()
        {
            Guid obj = Guid.NewGuid();
            var temp = Guid.Parse("ebe6f46e-d1fb-4754-8eed-3d64e37def98");
            string AuditUser = "Chumani";
            string BOLUserID = "gchangfoot";
            var info = client.GetIPDTypes(temp, AuditUser, BOLUserID);
            dgrResults.DataSource = info.dtResult;
            dgrResults.DataBind();
        }

        protected void IPDSubType(string text)
        {
            Guid obj = Guid.NewGuid();
            var temp = Guid.Parse("ebe6f46e-d1fb-4754-8eed-3d64e37def98");
            string AuditUser = "Chumani";
            string BOLUserID = "gchangfoot";
            //  Convert.ToInt32(text);

            var info = client.GetIPDSubTypes(temp, AuditUser, Convert.ToInt32(text), BOLUserID);
            dgrResults.DataSource = info.dtResult;
            dgrResults.DataBind();
        }

        protected void RunbuildingShareOwner()
        {
            Guid obj = Guid.NewGuid();
            var temp = Guid.Parse("ebe6f46e-d1fb-4754-8eed-3d64e37def98");
            string AuditUser = "Chumani";
            string BOLUserID = "gchangfoot";

            // key ,should be the same with saved key, in DB 

            int ownerskey = 10;

            TestApi.GetOperation operation = new TestApi.GetOperation();

            var dt = client.GetBuildingShareOwners(temp, AuditUser, Localekey, ownerskey, BOLUserID);

            dgrResults.DataSource = dt.dtResult;
            dgrResults.DataBind();

        }


        protected void RunBuilding()
        {
            //client.Open();
            Guid obj = Guid.NewGuid();
            var temp = Guid.Parse("ebe6f46e-d1fb-4754-8eed-3d64e37def98");
            string AuditUser = "Chumani";
            string BOLUserID = "gchangfoot";

            var n = build.Owners_key = 0;
            var infoBuild = client.GetBuildingOwners(temp, AuditUser, Localekey, BOLUserID);
            dgrResults.DataSource = infoBuild.dtResult;
            dgrResults.DataBind();
            client.Close();
        }

        protected void RunMunicipal()
        {
            Guid obj = Guid.NewGuid();
            var temp = Guid.Parse("ebe6f46e-d1fb-4754-8eed-3d64e37def98");
            string AuditUser = "Chumani";
            string BOLUserID = "gchangfoot";

            var info = client.GetMunicipalities(temp, AuditUser, Localekey, BOLUserID);

            dgrResults.DataSource = info.dtResult;
            dgrResults.DataBind();
        }

        protected void RunBranches()
        {
            Guid obj = Guid.NewGuid();
            var temp = Guid.Parse("ebe6f46e-d1fb-4754-8eed-3d64e37def98");
            string AuditUser = "Chumani";
            string BOLUserID = "gchangfoot";

            var info = client.GetBranches(temp, AuditUser, Localekey, BOLUserID);

            dgrResults.DataSource = info.dtResult;
            dgrResults.DataBind();
        }

        protected void RunMeterReading()
        {
            Guid obj = Guid.NewGuid();
            var temp = Guid.Parse("ebe6f46e-d1fb-4754-8eed-3d64e37def98");
            string AuditUser = "Chumani";
            string BOLUserID = "gchangfoot";

            var info = client.GetMeterReaders(temp, AuditUser, Localekey, BOLUserID);

            dgrResults.DataSource = info.dtResult;
            dgrResults.DataBind();
        }

        protected void RunBuildingType()
        {
            Guid obj = Guid.NewGuid();
            var temp = Guid.Parse("ebe6f46e-d1fb-4754-8eed-3d64e37def98");
            string AuditUser = "Chumani";
            string BOLUserID = "gchangfoot";
            int key = 0;
            var n = build.Owners_key = 0;
            var info = client.GetBuildingTypes(temp, AuditUser, BOLUserID);
            dgrResults.DataSource = info.dtResult;
            dgrResults.DataBind();
        }

        protected void RunOwnerDocument()
        {
            Guid obj = Guid.NewGuid();
            var temp = Guid.Parse("ebe6f46e-d1fb-4754-8eed-3d64e37def98");
            string AuditUser = "Chumani";
            string BOLUserID = "gchangfoot";

            int ownerskey = 510;

            TestApi.GetOperation operation = new TestApi.GetOperation();


            var info = client.GetOwnerDocuments(temp, AuditUser, Localekey, ownerskey, BOLUserID);
            dgrResults.DataSource = info.dtResult;
            dgrResults.DataBind();

        }

        protected void RunRegion()
        {
            Guid obj = Guid.NewGuid();
            var temp = Guid.Parse("ebe6f46e-d1fb-4754-8eed-3d64e37def98");
            string AuditUser = "Chumani";
            string BOLUserID = "gchangfoot";

            var info = client.GetReportingRegions(temp, AuditUser, Localekey, BOLUserID);
            dgrResults.DataSource = info.dtResult;
            dgrResults.DataBind();
        }

        protected void RunTenantInvoice()
        {
            Guid obj = Guid.NewGuid();
            var temp = Guid.Parse("ebe6f46e-d1fb-4754-8eed-3d64e37def98");
            string AuditUser = "Chumani";
            string BOLUserID = "gchangfoot";

            var info = client.GetTenantInvoiceTypes(temp, AuditUser, Localekey, BOLUserID);
            dgrResults.DataSource = info.dtResult;
            dgrResults.DataBind();
        }

        protected void RunGetNodes()
        {
            Guid obj = Guid.NewGuid();
            var temp = Guid.Parse("ebe6f46e-d1fb-4754-8eed-3d64e37def98");
            string AuditUser = "Chumani";
            string BOLUserID = "gchangfoot";

            int type = 3;

            var info = client.GetIPDNodes(temp, AuditUser, type, BOLUserID);
            dgrResults.DataSource = info.dtResult;
            dgrResults.DataBind();
        }

        protected void RunIDPTypes()
        {
            Guid obj = Guid.NewGuid();
            var temp = Guid.Parse("ebe6f46e-d1fb-4754-8eed-3d64e37def98");
            string AuditUser = "Chumani";
            string BOLUserID = "gchangfoot";

            var info = client.GetIPDTypes(temp, AuditUser, BOLUserID);
            dgrResults.DataSource = info.dtResult;
            dgrResults.DataBind();
        }

        protected void RunPortfolio()
        {
            Guid obj = Guid.NewGuid();
            var temp = Guid.Parse("ebe6f46e-d1fb-4754-8eed-3d64e37def98");
            string AuditUser = "Chumani";
            string BOLUserID = "gchangfoot";

            var info = client.GetPortfolios(temp, AuditUser, Localekey, BOLUserID);
            dgrResults.DataSource = info.dtResult;
            dgrResults.DataBind();
        }

        protected void RunBuildings()
        {
            Guid obj = Guid.NewGuid();
            var temp = Guid.Parse("ebe6f46e-d1fb-4754-8eed-3d64e37def98");
            string AuditUser = "Chumani";
            string BOLUserID = "gchangfoot";
            int portfolioKey = 11;

            var info = client.GetBuildings(temp, AuditUser, Localekey, portfolioKey, BOLUserID);

            dgrResults.DataSource = info.dtResult;
            dgrResults.DataBind();

        }

        protected void GetBuildingType()
        {
            Guid obj = Guid.NewGuid();
            var temp = Guid.Parse("ebe6f46e-d1fb-4754-8eed-3d64e37def98");
            string AuditUser = "Chumani";
            string BOLUserID = "gchangfoot";

            var info = client.GetBuildingTypes(temp, AuditUser, BOLUserID);
            dgrResults.DataSource = info.dtResult;
            dgrResults.DataBind();
        }

        protected void SaveIPDNode()
        {
            Guid obj = Guid.NewGuid();
            var temp = Guid.Parse("ebe6f46e-d1fb-4754-8eed-3d64e37def98");
            string AuditUser = "Chumani";
            string BOLUserID = "gchangfoot";

            TestApi.IPDNodeObj node = new TestApi.IPDNodeObj();
            node.NodeID = 0;
            node.Name = "Node type";
            node.TypeID = 10;

            var info = client.SaveIPDNode(temp, AuditUser, node, BOLUserID);
        }

        protected void SaveBuildingSpace()
        {
            Guid obj = Guid.NewGuid();

            var temp = Guid.Parse("ebe6f46e-d1fb-4754-8eed-3d64e37def98");
            string AuditUser = "Chumani";
            string BOLUserID = "gchangfoot";

            bool action = true;

            TestApi.BuildingSpaceObj space = new TestApi.BuildingSpaceObj();
            space.BuildingSpace_Key = 0;
            space.Building_Key = 362;
            space.Description = "Space for the building";
            space.SpaceOrder = 200;
            

            var inf0 = client.SaveBuildingSpace(temp, AuditUser, Localekey, action, space, BOLUserID);

        }

        protected void RunBuildingSpace()
        {
            Guid obj = Guid.NewGuid();

            var temp = Guid.Parse("ebe6f46e-d1fb-4754-8eed-3d64e37def98");
            string AuditUser = "Chumani";
            string BOLUserID = "gchangfoot";

            //int building_key = 1145;
            int building_key = 410;

            var info = client.GetBuildingSpaces(temp, AuditUser, Localekey, building_key, BOLUserID);

            dgrResults.DataSource = info.dtResult;
            dgrResults.DataBind();
        }

        protected void SaveBuildingSpaceDetail()
        {
            Guid obj = Guid.NewGuid();

            var temp = Guid.Parse("ebe6f46e-d1fb-4754-8eed-3d64e37def98");
            string AuditUser = "Chumani";
            string BOLUserID = "gchangfoot";

            bool Action = true;

            TestApi.BuildingSpaceDetailObj buildingspace = new TestApi.BuildingSpaceDetailObj();
            
            buildingspace.BuildingSpace_Key = 1000;
            buildingspace.StartDate = Convert.ToDateTime("2019-09-09");
            buildingspace.Common_Area = 9403;
            buildingspace.Usable_Area = 829904;

            

            var info = client.SaveBuildingSpaceDetail(temp, AuditUser, Localekey, Action, buildingspace, BOLUserID);

        }

        protected void RunBuildingSpaceDetails()
        {
            Guid obj = Guid.NewGuid();

            var temp = Guid.Parse("ebe6f46e-d1fb-4754-8eed-3d64e37def98");
            string AuditUser = "Chumani";
            string BOLUserID = "gchangfoot";

            int buildingspace = 456;

            var info = client.GetBuildingSpaceDetails(temp, AuditUser, Localekey, buildingspace, BOLUserID);

            dgrResults.DataSource = info.dtResult;
            dgrResults.DataBind();
        }

        protected void GetPremisesTypes()
        {
            Guid obj = Guid.NewGuid();

            var temp = Guid.Parse("ebe6f46e-d1fb-4754-8eed-3d64e37def98");
            string AuditUser = "Chumani";
            string BOLUserID = "gchangfoot";

            var info = client.GetPremisesTypes(temp, AuditUser, Localekey, BOLUserID);

            dgrResults.DataSource = info.dtResult;
            dgrResults.DataBind();
        }

        protected void SavePremises()
        {
            Guid obj = Guid.NewGuid();

            var temp = Guid.Parse("ebe6f46e-d1fb-4754-8eed-3d64e37def98");
            string AuditUser = "Chumani";
            string BOLUserID = "gchangfoot";

            bool Action = true;

            TestApi.PremisesObj objpre = new TestApi.PremisesObj();

            // 0 for adding, 1 for updating and 2 for deleting 
            objpre.Premises_Key = 0;
            objpre.BuildingSpace_Key = 456;
            objpre.Building_Key = 410;
            objpre.Premises_Code = "BR09919";
            objpre.Description = "Premises in Broll Group";

            objpre.Start_Date = Convert.ToDateTime("2019-09-30");
            objpre.End_Date = Convert.ToDateTime("2020-11-30");

            objpre.PremisesType_Key = 29;

           
            //float number not accessing 
            objpre.UsableArea = 100.00F;

            objpre.Mothball = 10;

            objpre.MothballDate = Convert.ToDateTime("2019-10-01");

            var info = client.SavePremises(temp, AuditUser, Localekey, Action, objpre, BOLUserID);

        }

        protected void GetPremises()
        {
            Guid obj = Guid.NewGuid();

            var temp = Guid.Parse("ebe6f46e-d1fb-4754-8eed-3d64e37def98");
            string AuditUser = "Chumani";
            string BOLUserID = "gchangfoot";

            int building = 410;
            int buildingspace = 456;

            var info = client.GetPremises(temp, AuditUser, Localekey, building, buildingspace, BOLUserID);

            dgrResults.DataSource = info.dtResult;
            dgrResults.DataBind();

        }

        protected void SaveEntrance()
        {
            Guid obj = Guid.NewGuid();

            var temp = Guid.Parse("ebe6f46e-d1fb-4754-8eed-3d64e37def98");
            string AuditUser = "Chumani";
            string BOLUserID = "gchangfoot";

            bool Action = true;

            TestApi.EntranceObj objentrance = new TestApi.EntranceObj();

            objentrance.Entrance_Key = 0;
            objentrance.Building_Key = 1145;
            objentrance.BuildingSpace_Key = 877;
            objentrance.EntranceType_Key = 2;
            objentrance.EntranceCode = "P039403";
            objentrance.EntranceDescription = "Parking space at Broll building";
            objentrance.StartDate = Convert.ToDateTime("2019-09-30"); 
            objentrance.EndDate = Convert.ToDateTime("2020-12-30"); ;

            var info = client.SaveEntrance(temp, AuditUser, Localekey, Action, objentrance, BOLUserID);


        }

        protected void GetEntranceType()
        {
            Guid obj = Guid.NewGuid();

            var temp = Guid.Parse("ebe6f46e-d1fb-4754-8eed-3d64e37def98");
            string AuditUser = "Chumani";
            string BOLUserID = "gchangfoot";

            var info = client.GetEntranceTypes(temp, AuditUser, Localekey, BOLUserID);

            dgrResults.DataSource = info.dtResult;
            dgrResults.DataBind();

        }


        protected void GetEntrance()
        {
            Guid obj = Guid.NewGuid();

            var temp = Guid.Parse("ebe6f46e-d1fb-4754-8eed-3d64e37def98");
            string AuditUser = "Chumani";
            string BOLUserID = "gchangfoot";


            int building = 1145;
            int buildingspace = 877;

            var info = client.GetEntrances(temp, AuditUser, Localekey, building, buildingspace, BOLUserID);

            dgrResults.DataSource = info.dtResult;
            dgrResults.DataBind();
        }

       


        protected void btnBuilding_Click(object sender, EventArgs e)
        {
            RunBuilding();
        }

        protected void btnGetBuildingType_Click(object sender, EventArgs e)
        {

        }

        protected void btnSave_Click(object sender, EventArgs e)
        {
            // SaveBuildingSpace();
            //SaveEntrance();
             SavePremises();
           // SaveBuildingSpaceDetail();
            /// SaveBuildingSpaceDetail();
            //SaveBuildingCharge();
            //  SaveBuildingAccount();
            ///Savebuilding();
            //SaveIPDNode();
            //SaveMeter();
            //SaveOwnerDocument();
            ///SaveBuildingShare();
            //SaveBuilding();
        }

        protected void btnGetBuildingShare_Click(object sender, EventArgs e)
        {
            SaveBuildingAccount();
            //RunbuildingShareOwner();
        }

        protected void btnGetOwnerDocument_Click(object sender, EventArgs e)
        {

        }

        protected void btnGetType_Click(object sender, EventArgs e)
        {
            //IPDTypes();
            SaveOwnerDocument();
        }

        protected void btnGetIDPsub_Click(object sender, EventArgs e)
        {
            switch (txtIDPSub.Text)
            {
                case "1":
                    IPDSubType(txtIDPSub.Text);
                    lblError.Text = "Retail";
                    break;
                case "2":
                    IPDSubType(txtIDPSub.Text);
                    lblError.Text = "Office";
                    break;
                case "3":
                    IPDSubType(txtIDPSub.Text);
                    lblError.Text = "Industrial";
                    break;
                case "4":
                    IPDSubType(txtIDPSub.Text);
                    lblError.Text = "Other";
                    break;
                case "5":
                    IPDSubType(txtIDPSub.Text);
                    lblError.Text = "Test IPD Type Changed";
                    break;
                default:
                    break;
            }
        }

        protected void btnGetMunicipal_Click(object sender, EventArgs e)
        {
            SaveBuildingCharge();
        }

        protected void btnGetBranches_Click(object sender, EventArgs e)
        {

        }

        protected void btnGetMeter_Click(object sender, EventArgs e)
        {
            SaveBuilding();

        }

        protected void dllSelect_SelectedIndexChanged(object sender, EventArgs e)
        {
            if (IsPostBack)
            {
                if (dllSelect.SelectedValue.ToString() == "Currency")
                {
                    Guid obj = Guid.NewGuid();
                    var temp = Guid.Parse("ebe6f46e-d1fb-4754-8eed-3d64e37def98");
                    string AuditUser = "Chumani";
                    string BOLUserID = "gchangfoot";

                    var info = client.GetForexCurrencies(temp, AuditUser, Localekey, BOLUserID);
                    dgrResults.DataSource = info.dtResult;
                    dgrResults.DataBind();
                }
                else if (dllSelect.SelectedValue.ToString() == "DocumentList")
                {
                    RunOwnerDocument();
                }
                else if (dllSelect.SelectedValue.ToString() == "Agent")
                {
                    Guid obj = Guid.NewGuid();
                    var temp = Guid.Parse("ebe6f46e-d1fb-4754-8eed-3d64e37def98");
                    string AuditUser = "Chumani";
                    string BOLUserID = "gchangfoot";

                    var info = client.GetManagingAgents(temp, AuditUser, Localekey, BOLUserID);
                    dgrResults.DataSource = info.dtResult;
                    dgrResults.DataBind();
                }
                else if (dllSelect.SelectedValue.ToString() == "Branches")
                {
                    RunBranches();
                }
                else if (dllSelect.SelectedValue.ToString() == "Municipalities")
                {
                    RunMunicipal();
                }
                else if (dllSelect.SelectedValue.ToString() == "Meter")
                {
                    RunMeterReading();
                }
                else if (dllSelect.SelectedValue.ToString() == "Regions")
                {
                    RunRegion();
                }
                else if (dllSelect.SelectedValue.ToString() == "InvoiceTypes")
                {
                    RunTenantInvoice();
                }
                else if (dllSelect.SelectedValue.ToString() == "IPDNodes")
                {
                    RunGetNodes();
                }
                else if (dllSelect.SelectedValue.ToString() == "IDPTypes")
                {
                    RunIDPTypes();
                }
                else if (dllSelect.SelectedValue.ToString() == "Portfolio")
                {
                    RunPortfolio();
                }
                else if (dllSelect.SelectedValue.ToString() == "Building Types")
                {
                    RunBuildingType();

                }
                else if (dllSelect.SelectedValue.ToString() == "All Buildings")
                {
                    RunBuildings();
                }
                else if (dllSelect.SelectedValue.ToString() == "Global Acc Level1")
                {
                    GetGlobalAccs();
                }
                else if (dllSelect.SelectedValue.ToString() == "Global Acc Level2")
                {
                    GetGlobalAccs2();
                }
                else if (dllSelect.SelectedValue.ToString() == "Global Acc Desc")
                {
                    GetGlobalAcc_Desc();
                }
                else if (dllSelect.SelectedValue.ToString() == "Gl Acc Building")
                {
                    GetBuildingAcc_GLAcc();
                }
                else if (dllSelect.SelectedValue.ToString() == "FoxConversion")
                {
                    GetForex();
                }
                else if (dllSelect.SelectedValue.ToString() == "VAT")
                {
                    GetVATInt();
                }
                else if (dllSelect.SelectedValue.ToString() == "BuildingCharges")
                {
                    GetBuildingChargeTypesAll();
                }
                else if (dllSelect.SelectedValue.ToString() == "BuildingSpace")
                {
                    RunBuildingSpace();
                }
                else if (dllSelect.SelectedValue.ToString() == "GetBuildingSpace")
                {
                    RunBuildingSpaceDetails();
                }
                else if (dllSelect.SelectedValue.ToString() == "GetPremisesTypes")
                {
                    GetPremisesTypes();
                }
                else if (dllSelect.SelectedValue.ToString() == "GetPremises")
                {
                    GetPremises();
                }
                else if (dllSelect.SelectedValue.ToString() == "GetEntrance")
                {
                    GetEntrance();
                }
                else if(dllSelect.SelectedValue.ToString() == "EntranceType")
                {
                    GetEntranceType();
                }
            }
        }

        protected void btnSaveBuildingSpace_Click(object sender, EventArgs e)
        {
            SaveBuildingSpace();
        }
    }
}