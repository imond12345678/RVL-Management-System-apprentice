using System;
using System.Data;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Data.SqlClient;
using System.Windows.Forms;
using System.Configuration;
using RVL_Management_System.Forms;
using MetroFramework;

namespace RVL_Management_System.Class
{
    class Cls_cmd
    {
        public static void Login()
        {
            SqlConnection conn = new SqlConnection();
            SqlCommand cmd = new SqlCommand();

            Frm_Login _owner = new Frm_Login();

            conn.ConnectionString = ConfigurationManager.ConnectionStrings["connGlobal"].ToString();

            conn.Open();
            cmd.Connection = conn;
            string LOGIN = "SELECT A.Account, L.UN, L.PW, U.Full_Name FROM tblUser AS U LEFT JOIN tblAccount AS A ON A.AcctID = U.AcctID LEFT JOIN tblLogin AS L ON L.AcctID = U.AcctID WHERE L.UN = @un AND L.PW = @pw AND A.Account = @ut";
            cmd.Parameters.AddWithValue("un", Frm_Login.Username);
            cmd.Parameters.AddWithValue("pw", Frm_Login.Password);
            cmd.Parameters.AddWithValue("ut", Frm_Login.UserType);
            cmd.CommandText = LOGIN;
            cmd.ExecuteNonQuery();
            SqlDataReader reader = cmd.ExecuteReader();

            if (reader.HasRows)
            {
                MetroMessageBox.Show(_owner, "Welcome", "RVL System", MessageBoxButtons.OK, MessageBoxIcon.Information);
                Main fmain = new Main();
                fmain.Show();
            }
            else
            {
                MetroMessageBox.Show(_owner, "Wrong username or password!", "RVL System", MessageBoxButtons.OK, MessageBoxIcon.Warning);

            }
            conn.Close();

            cmd.Parameters.Clear();

        }

        public static void userLogin()
        {
            SqlConnection conn = new SqlConnection();
            SqlCommand cmd = new SqlCommand();

            Frm_UserAdd _owner = new Frm_UserAdd();

            conn.ConnectionString = ConfigurationManager.ConnectionStrings["connGlobal"].ToString();

            conn.Open();

            cmd.Connection = conn;
            string InsertLogin = "INSERT INTO tblLogin(AcctID,UID,UN,PW)VALUES(@acctID,@uid,@un,@pw)";
            cmd.Parameters.AddWithValue("acctID", Frm_UserAdd.acctID);
            cmd.Parameters.AddWithValue("uid", Frm_UserAdd.uID);
            cmd.Parameters.AddWithValue("un", Frm_UserAdd.userName);
            cmd.Parameters.AddWithValue("pw", Frm_UserAdd.Password);
            cmd.CommandText = InsertLogin;
            cmd.ExecuteNonQuery();

            //MetroMessageBox.Show(_owner, "Successfully added these information to the database.", "RVL System", MessageBoxButtons.OK, MessageBoxIcon.Information);

            conn.Close();
            cmd.Parameters.Clear();
        }

        public static void userAdd()
        {
            SqlConnection conn = new SqlConnection();
            SqlCommand cmd = new SqlCommand();

            AddLeadSource _owner = new AddLeadSource();

            conn.ConnectionString = ConfigurationManager.ConnectionStrings["connGlobal"].ToString();
            conn.Open();

            cmd.Connection = conn;
            string INSERT = "INSERT INTO tblUser(AcctID,Full_Name,Email)VALUES(@acctID,@fn,@email)";
            cmd.Parameters.AddWithValue("acctID", Frm_UserAdd.acctID);
            cmd.Parameters.AddWithValue("fn", Frm_UserAdd.fullName);
            cmd.Parameters.AddWithValue("email", Frm_UserAdd.email);
            cmd.CommandText = INSERT;
            cmd.ExecuteNonQuery();

            conn.Close();

            //MetroMessageBox.Show(_owner, "Successfully saved these User Information.", "RVL System", MessageBoxButtons.OK, MessageBoxIcon.Information);

            cmd.Parameters.Clear();
        }

        public static void leadAdd()
        {
            SqlConnection conn = new SqlConnection();
            SqlCommand cmd = new SqlCommand();

            AddLeadSource _owner = new AddLeadSource();

            conn.ConnectionString = ConfigurationManager.ConnectionStrings["connGlobal"].ToString();
            conn.Open();

            cmd.Connection = conn;
            string INSERT = "INSERT INTO tblLeadSource(LeadDescription)VALUES(@leadD)";
            cmd.Parameters.AddWithValue("leadD", Forms.AddLeadSource.leadDes);
            cmd.CommandText = INSERT;
            cmd.ExecuteNonQuery();

            conn.Close();
            MetroMessageBox.Show(_owner, "Successfully saved these Marketing Information.", "RVL System", MessageBoxButtons.OK, MessageBoxIcon.Information);

            cmd.Parameters.Clear();
        }
        

        public static void marketingAdd()
        {
            SqlConnection conn = new SqlConnection();
            SqlCommand cmd = new SqlCommand();

            Frm_LeadGeneration _owner = new Frm_LeadGeneration();

            conn.ConnectionString = ConfigurationManager.ConnectionStrings["connGlobal"].ToString();
            conn.Open();

            cmd.Connection = conn;
            string INSERT = "INSERT INTO tblMarketing(Lead_Received,Last_Name,First_Name,Middle_Name,Phone_Number,Email_Address,Issue_Description,Lead_Source,Other,Lead_FollowUp,Lead_Status,Priority,Memo,Lead_Assigned,Lead_Assesment)VALUES(@leadReceived,@ln,@fn,@mn,@pNum,@eAdd,@issueDes,@leadSource,@other,@leadFollow,@leadStats,@priority,@memo,@leadAssigned,@leadAssesment)";
            cmd.Parameters.AddWithValue("leadReceived", Frm_LeadGeneration.leadReceived);
            cmd.Parameters.AddWithValue("ln", Frm_LeadGeneration.lastName);
            cmd.Parameters.AddWithValue("fn", Frm_LeadGeneration.firstName);
            cmd.Parameters.AddWithValue("mn", Frm_LeadGeneration.middleName);
            cmd.Parameters.AddWithValue("pNum", Frm_LeadGeneration.phoneNumber);
            cmd.Parameters.AddWithValue("eAdd", Frm_LeadGeneration.emailAddress);
            cmd.Parameters.AddWithValue("issueDes", Frm_LeadGeneration.issueDescription);
            cmd.Parameters.AddWithValue("leadSource", Frm_LeadGeneration.leadSource);
            cmd.Parameters.AddWithValue("other", Frm_LeadGeneration.other);
            cmd.Parameters.AddWithValue("leadFollow", Frm_LeadGeneration.leadFollow);
            cmd.Parameters.AddWithValue("leadStats", Frm_LeadGeneration.leadStat);
            cmd.Parameters.AddWithValue("priority", Frm_LeadGeneration.priority);
            cmd.Parameters.AddWithValue("memo", Frm_LeadGeneration.memo);
            cmd.Parameters.AddWithValue("leadAssigned", Frm_LeadGeneration.leadAssigned);
            cmd.Parameters.AddWithValue("leadAssesment", Frm_LeadGeneration.leadAssesment);
            cmd.CommandText = INSERT;
            cmd.ExecuteNonQuery();

            conn.Close();
            MetroMessageBox.Show(_owner, "Successfully saved these Marketing Information.", "RVL System", MessageBoxButtons.OK, MessageBoxIcon.Information);

            cmd.Parameters.Clear();
        }

        public static void companyAdd()
        {
            SqlConnection conn = new SqlConnection();
            SqlCommand cmd = new SqlCommand();

            LandOwner _owner = new LandOwner();

            conn.ConnectionString = ConfigurationManager.ConnectionStrings["connGlobal"].ToString();
            conn.Open();

            cmd.Connection = conn;
            string INSERT = "INSERT INTO tblCompanyLogins(Category_Name,URL_Link,Username,Password,Name_Login_Under,Give_Access_To)VALUES(@catName,@url,@un,@pw,@nameLogin,@giveAccess)";
            cmd.Parameters.AddWithValue("catName", CompanyLoginsAdd.categoryName);
            cmd.Parameters.AddWithValue("url", CompanyLoginsAdd.URLlink);
            cmd.Parameters.AddWithValue("un", CompanyLoginsAdd.userName);
            cmd.Parameters.AddWithValue("pw", CompanyLoginsAdd.passWord);
            cmd.Parameters.AddWithValue("nameLogin", CompanyLoginsAdd.nameLogin);
            cmd.Parameters.AddWithValue("giveAccess", CompanyLoginsAdd.giveAccess);
            cmd.CommandText = INSERT;
            cmd.ExecuteNonQuery();

            conn.Close();
            MetroMessageBox.Show(_owner, "Successfully saved these Company login Information.", "RVL System", MessageBoxButtons.OK, MessageBoxIcon.Information);

            cmd.Parameters.Clear();
        }

        public static void landOwnerAdd()
        {
            SqlConnection conn = new SqlConnection();
            SqlCommand cmd = new SqlCommand();

            LandOwner _owner = new LandOwner();

            conn.ConnectionString = ConfigurationManager.ConnectionStrings["connGlobal"].ToString();
            conn.Open();

            cmd.Connection = conn;
            string INSERT = "INSERT INTO tblLandOwner(Land_Owner)VALUES(@landOwner)";
            cmd.Parameters.AddWithValue("landOwner", LandOwner.landOwner);
            cmd.CommandText = INSERT;
            cmd.ExecuteNonQuery();

            conn.Close();
            MetroMessageBox.Show(_owner, "Successfully saved these land owner Information.", "RVL System", MessageBoxButtons.OK, MessageBoxIcon.Information);

            cmd.Parameters.Clear();
        }

        public static void socialMediaAdd()
        {
            SqlConnection conn = new SqlConnection();
            SqlCommand cmd = new SqlCommand();

            SocialMediaAdd _owner = new SocialMediaAdd();

            conn.ConnectionString = ConfigurationManager.ConnectionStrings["connGlobal"].ToString();
            conn.Open();

            cmd.Connection = conn;
            string INSERT = "INSERT INTO tblSocialMedia(Current_Market_Value,Updated_Price,Title,Social_Media_Notes,Hashtags,Schedule,Pre_Approved,Status,Additional_Notes)VALUES(@currentMarketValue,@updatedPrice,@title,@SocialMediaNotes,@hashtags,@schedule,@preApproved,@status,@additionalNotes)";
            cmd.Parameters.AddWithValue("currentMarketValue", SocialMediaAdd.currentMarketValue);
            cmd.Parameters.AddWithValue("updatedPrice", SocialMediaAdd.updatedPrice);
            cmd.Parameters.AddWithValue("title", SocialMediaAdd.title);
            cmd.Parameters.AddWithValue("SocialMediaNotes", SocialMediaAdd.socialMediaNotes);
            cmd.Parameters.AddWithValue("hashtags", SocialMediaAdd.hashtagsToUse);
            cmd.Parameters.AddWithValue("schedule", SocialMediaAdd.scheduleToBePosted);
            cmd.Parameters.AddWithValue("preApproved", SocialMediaAdd.preApproved);
            cmd.Parameters.AddWithValue("status", SocialMediaAdd.status);
            cmd.Parameters.AddWithValue("additionalNotes", SocialMediaAdd.additionalNotes);
            cmd.CommandText = INSERT;
            cmd.ExecuteNonQuery();

            conn.Close();
            //MetroMessageBox.Show(_owner, "Successfully saved these Social Media Information.", "RVL System", MessageBoxButtons.OK, MessageBoxIcon.Information);

            cmd.Parameters.Clear();
        }

        public static void landStayAdd()
        {
            SqlConnection conn = new SqlConnection();
            SqlCommand cmd = new SqlCommand();

            LandStay _owner = new LandStay();
            
            conn.ConnectionString = ConfigurationManager.ConnectionStrings["connGlobal"].ToString();
            conn.Open();

            cmd.Connection = conn;
            string INSERT = "INSERT INTO tblLandStay(Seller,Phone_Number,Seller_Email,Seller_Notes,Seller_Name,Availability,State,County,APN,Acres,Legal,GPS,Price,Contact_or_Checkout)VALUES(@seller,@phoneNumber,@sellerEmail,@sellerNotes,@sellerName,@availability,@state,@county,@APN,@acres,@legal,@GPS,@price,@contactOrCheckout)";
            cmd.Parameters.AddWithValue("seller", LandStay.seller);
            cmd.Parameters.AddWithValue("phoneNumber", LandStay.phone);
            cmd.Parameters.AddWithValue("sellerEmail", LandStay.sellerEmail);
            cmd.Parameters.AddWithValue("sellerNotes", LandStay.sellerNotes);
            cmd.Parameters.AddWithValue("sellerName", LandStay.sellerName);
            cmd.Parameters.AddWithValue("availability", LandStay.availability);
            cmd.Parameters.AddWithValue("state", LandStay.state);
            cmd.Parameters.AddWithValue("county", LandStay.county);
            cmd.Parameters.AddWithValue("APN", LandStay.APN);
            cmd.Parameters.AddWithValue("acres", LandStay.acres);
            cmd.Parameters.AddWithValue("legal", LandStay.legal);
            cmd.Parameters.AddWithValue("GPS", LandStay.gps);
            cmd.Parameters.AddWithValue("price", LandStay.price);
            cmd.Parameters.AddWithValue("contactOrCheckout", LandStay.contactOrCheckout);
            cmd.CommandText = INSERT;
            cmd.ExecuteNonQuery();

            conn.Close();
            MetroMessageBox.Show(_owner, "Successfully saved these Land Stay Information.", "RVL System", MessageBoxButtons.OK, MessageBoxIcon.Information);

            cmd.Parameters.Clear();
        }

        public static void accountingBusinessAdd()
        {
            SqlConnection conn = new SqlConnection();
            SqlCommand cmd = new SqlCommand();

            PropertyAccountingBusiness _owner = new PropertyAccountingBusiness();

            conn.ConnectionString = ConfigurationManager.ConnectionStrings["connGlobal"].ToString();
            conn.Open();

            cmd.Connection = conn;
            string INSERT = "INSERT INTO tblAccountingBusiness(Type_Of_Account,Type_Of_Payment,Paid_Via,APN_ID,Date_Sold,Date_Aquired,Closed_Sale_Amount,Original_Price,OriginalPrice_Expense,Net_Sale,Balance_Due,Sold_From,Sold_To,Terms_with_LLC,Shared60,Shared40,Check_Number,Invoice_Number,Memo,Date_Payments,Amount_Payments,Total_Amount_Paid,Total_Land_Cost,Payment_Balance_Due,Category_Expense,Notes,Recording_Fee,Card_Processing_Fee,Back_Taxes,Notary,Other_Expense,Total_Expense,Net_Profit)VALUES(@typeAccount,@typePayment,@paidVia,@apnID,@dateSold,@dateAquired,@closedSaleAmount,@originalPrice,@originalPriceExpense,@netSale,@balanceDue,@soldFrom,@soldTo,@termsLLC,@shared60,@shared40,@checkNumber,@invoiceNumber,@memo,@datePayment,@amountPayment,@totalAmountPaid,@totalLandCost,@paymentBalanceDue,@categoryExpense,@notes,@recordingFee,@processingFee,@backTaxes,@notary,@otherExpense,@totalExpense,@netProfit)";
            cmd.Parameters.AddWithValue("typeAccount", PropertyAccountingBusiness.typeAccount);
            cmd.Parameters.AddWithValue("typePayment", PropertyAccountingBusiness.typePayment);
            cmd.Parameters.AddWithValue("paidVia", PropertyAccountingBusiness.paidVia);
            cmd.Parameters.AddWithValue("apnID", PropertyAccountingBusiness.apnID);
            cmd.Parameters.AddWithValue("dateSold", PropertyAccountingBusiness.dateSold);
            cmd.Parameters.AddWithValue("dateAquired", PropertyAccountingBusiness.dateAquired);
            cmd.Parameters.AddWithValue("closedSaleAmount", PropertyAccountingBusiness.closedSale);
            cmd.Parameters.AddWithValue("originalPrice", PropertyAccountingBusiness.originalPrice);
            cmd.Parameters.AddWithValue("originalPriceExpense", PropertyAccountingBusiness.originalPriceExpense);
            cmd.Parameters.AddWithValue("netSale", PropertyAccountingBusiness.netSale);
            cmd.Parameters.AddWithValue("balanceDue", PropertyAccountingBusiness.balanceDue);
            cmd.Parameters.AddWithValue("soldFrom", PropertyAccountingBusiness.soldFrom);
            cmd.Parameters.AddWithValue("soldTo", PropertyAccountingBusiness.soldTo);
            cmd.Parameters.AddWithValue("termsLLC", PropertyAccountingBusiness.termsLLC);
            cmd.Parameters.AddWithValue("shared60", PropertyAccountingBusiness.shared60);
            cmd.Parameters.AddWithValue("shared40", PropertyAccountingBusiness.shared40);
            cmd.Parameters.AddWithValue("checkNumber", PropertyAccountingBusiness.checkNumber);
            cmd.Parameters.AddWithValue("invoiceNumber", PropertyAccountingBusiness.invoiceNumber);
            cmd.Parameters.AddWithValue("memo", PropertyAccountingBusiness.memo);
            cmd.Parameters.AddWithValue("datePayment", PropertyAccountingBusiness.datePayment);
            cmd.Parameters.AddWithValue("amountPayment", PropertyAccountingBusiness.amountPayment);
            cmd.Parameters.AddWithValue("totalAmountPaid", PropertyAccountingBusiness.totalAmountPaid);
            cmd.Parameters.AddWithValue("totalLandCost", PropertyAccountingBusiness.totalLandCost);
            cmd.Parameters.AddWithValue("paymentBalanceDue", PropertyAccountingBusiness.paymentBalanceDue);
            cmd.Parameters.AddWithValue("categoryExpense", PropertyAccountingBusiness.categoryExpense);
            cmd.Parameters.AddWithValue("notes", PropertyAccountingBusiness.notes);
            cmd.Parameters.AddWithValue("recordingFee", PropertyAccountingBusiness.recordingFee);
            cmd.Parameters.AddWithValue("processingFee", PropertyAccountingBusiness.cardProcessingFee);
            cmd.Parameters.AddWithValue("backTaxes", PropertyAccountingBusiness.backTaxes);
            cmd.Parameters.AddWithValue("notary", PropertyAccountingBusiness.notary);
            cmd.Parameters.AddWithValue("otherExpense", PropertyAccountingBusiness.otherExpense);
            cmd.Parameters.AddWithValue("totalExpense", PropertyAccountingBusiness.totalExpense);
            cmd.Parameters.AddWithValue("netProfit", PropertyAccountingBusiness.netProfit);
            cmd.CommandText = INSERT;
            cmd.ExecuteNonQuery();

            conn.Close();
            MetroMessageBox.Show(_owner, "Successfully saved these Land Stay Information.", "RVL System", MessageBoxButtons.OK, MessageBoxIcon.Information);

            cmd.Parameters.Clear();
        }

        public static void accountingPersonalAdd()
        {
            SqlConnection conn = new SqlConnection();
            SqlCommand cmd = new SqlCommand();

            PropertyAccountingPersonal _owner = new PropertyAccountingPersonal();

            conn.ConnectionString = ConfigurationManager.ConnectionStrings["connGlobal"].ToString();
            conn.Open();

            cmd.Connection = conn;
            string INSERT = "INSERT INTO Personal(Account,BilledFrom,BilledTo,Memo,Amount,DateRecorded,Notes,Total)VALUES(@account,@billedFrom,@billedTo,@memo,@amount,@dateRecorded,@notes,@total)";
            cmd.Parameters.AddWithValue("account", PropertyAccountingPersonal.account);
            cmd.Parameters.AddWithValue("billedFrom", PropertyAccountingPersonal.billedFrom);
            cmd.Parameters.AddWithValue("billedTo", PropertyAccountingPersonal.billedTo);
            cmd.Parameters.AddWithValue("memo", PropertyAccountingPersonal.memo);
            cmd.Parameters.AddWithValue("amount", PropertyAccountingPersonal.amount);
            cmd.Parameters.AddWithValue("dateRecorded", PropertyAccountingPersonal.dateRecorded);
            cmd.Parameters.AddWithValue("notes", PropertyAccountingPersonal.notes);
            cmd.Parameters.AddWithValue("total", PropertyAccountingPersonal.total);
            cmd.CommandText = INSERT;
            cmd.ExecuteNonQuery();

            conn.Close();
            MetroMessageBox.Show(_owner, "Saved Successfully.", "RVL System", MessageBoxButtons.OK, MessageBoxIcon.Information);

            cmd.Parameters.Clear();
        }

        public static void adminOfficeAdd()
        {
            SqlConnection conn = new SqlConnection();
            SqlCommand cmd = new SqlCommand();

            AdminOfficeAdd _owner = new AdminOfficeAdd();

            conn.ConnectionString = ConfigurationManager.ConnectionStrings["connGlobal"].ToString();
            conn.Open();

            cmd.Connection = conn;
            string INSERT = "INSERT INTO tblAdminContact(Full_name,Email,Phone_number,Address,County,Category)VALUES(@fullName,@email,@phoneNumber,@address,@county,@category)";
            cmd.Parameters.AddWithValue("fullName", AdminOfficeAdd.fullName);
            cmd.Parameters.AddWithValue("email", AdminOfficeAdd.email);
            cmd.Parameters.AddWithValue("phoneNumber", AdminOfficeAdd.phoneNumber);
            cmd.Parameters.AddWithValue("address", AdminOfficeAdd.address);
            cmd.Parameters.AddWithValue("county", AdminOfficeAdd.county);
            cmd.Parameters.AddWithValue("category", AdminOfficeAdd.category);
            cmd.CommandText = INSERT;
            cmd.ExecuteNonQuery();

            conn.Close();
            MetroMessageBox.Show(_owner, "Successfully saved these Admin Contact List Information.", "RVL System", MessageBoxButtons.OK, MessageBoxIcon.Information);

            cmd.Parameters.Clear();
        }

        public static void videoTutorialsAdd()
        {
            SqlConnection conn = new SqlConnection();
            SqlCommand cmd = new SqlCommand();

            VideoTutorialsAdd _owner = new VideoTutorialsAdd();

            conn.ConnectionString = ConfigurationManager.ConnectionStrings["connGlobal"].ToString();
            conn.Open();

            cmd.Connection = conn;
            string INSERT = "INSERT INTO tblVideoTutorial(Process,Link)VALUES(@process,@link)";
            cmd.Parameters.AddWithValue("process", VideoTutorialsAdd.process);
            cmd.Parameters.AddWithValue("link", VideoTutorialsAdd.link);
            cmd.CommandText = INSERT;
            cmd.ExecuteNonQuery();

            conn.Close();
            MetroMessageBox.Show(_owner, "Successfully saved these Youtube Tutorials.", "RVL System", MessageBoxButtons.OK, MessageBoxIcon.Information);

            cmd.Parameters.Clear();
        }

        public static void californiaDeedAdd()
        {
            SqlConnection conn = new SqlConnection();
            SqlCommand cmd = new SqlCommand();

            CaliforniaGrantDeed _owner = new CaliforniaGrantDeed();

            conn.ConnectionString = ConfigurationManager.ConnectionStrings["connGlobal"].ToString();
            conn.Open();

            cmd.Connection = conn;
            string INSERT = "INSERT INTO tblCaliforniaDeed(APN,PreparedBy,ReturnTo,StatementsGrantee,Acknowledged,GrantTo,CountyOf,Dated,Grantor,GrantDeedPrintName,StateOf,AcknowledgementCountyOf,AcknowledgementOn,BeforeMe,PersonallyAppeared,LawsStateOf,NotaryPublic,CommissionExpires,AcknowledgementPrintName,GrantorNameAddressPhone,GranteeNameAddressPhone)VALUES(@apn,@preparedBy,@returnTo,@statementGrantee,@acknowledged,@grantTo,@countyOf,@dated,@grantor,@grantDeedPrintName,@stateOf,@acknowledgementCountyOf,@acknowledgedOn,@beforeMe,@personallyAppeared,@lawsStateOf,@notaryPublic,@commissionExpires,@acknowledgementPrintName,@grantorNameAddressPhone,@granteeNameAddressPhone)";
            cmd.Parameters.AddWithValue("apn", CaliforniaGrantDeed.APN);
            cmd.Parameters.AddWithValue("preparedBy", CaliforniaGrantDeed.preparedBy);
            cmd.Parameters.AddWithValue("returnTo", CaliforniaGrantDeed.returnTo);
            cmd.Parameters.AddWithValue("statementGrantee", CaliforniaGrantDeed.statementsToGrantee);
            cmd.Parameters.AddWithValue("acknowledged", CaliforniaGrantDeed.acknowledged);
            cmd.Parameters.AddWithValue("grantTo", CaliforniaGrantDeed.grantTo);
            cmd.Parameters.AddWithValue("countyOf", CaliforniaGrantDeed.countyOf);
            cmd.Parameters.AddWithValue("dated", CaliforniaGrantDeed.dated);
            cmd.Parameters.AddWithValue("grantor", CaliforniaGrantDeed.grantor);
            cmd.Parameters.AddWithValue("grantDeedPrintName", CaliforniaGrantDeed.grantPrintDeedName);
            cmd.Parameters.AddWithValue("stateOf", CaliforniaGrantDeed.stateOf);
            cmd.Parameters.AddWithValue("acknowledgementCountyOf", CaliforniaGrantDeed.acknowledgementCountyOf);
            cmd.Parameters.AddWithValue("acknowledgedOn", CaliforniaGrantDeed.acknowledgementOn);
            cmd.Parameters.AddWithValue("beforeMe", CaliforniaGrantDeed.beforeMe);
            cmd.Parameters.AddWithValue("personallyAppeared", CaliforniaGrantDeed.personallyAppeared);
            cmd.Parameters.AddWithValue("lawsStateOf", CaliforniaGrantDeed.lawStateOf);
            cmd.Parameters.AddWithValue("notaryPublic", CaliforniaGrantDeed.notaryPublic);
            cmd.Parameters.AddWithValue("commissionExpires", CaliforniaGrantDeed.commissionExpires);
            cmd.Parameters.AddWithValue("acknowledgementPrintName", CaliforniaGrantDeed.acknowledgementPrintName);
            cmd.Parameters.AddWithValue("grantorNameAddressPhone", CaliforniaGrantDeed.grantorNameAddressPhone);
            cmd.Parameters.AddWithValue("granteeNameAddressPhone", CaliforniaGrantDeed.granteeNameAddressPhone);
            cmd.CommandText = INSERT;
            cmd.ExecuteNonQuery();

            conn.Close();
            MetroMessageBox.Show(_owner, "Successfully saved these California Deed information.", "RVL System", MessageBoxButtons.OK, MessageBoxIcon.Information);

            cmd.Parameters.Clear();
        }

        public static void emailAdd()
        {
            SqlConnection conn = new SqlConnection();
            SqlCommand cmd = new SqlCommand();

            VideoTutorialsUpdate _owner = new VideoTutorialsUpdate();

            conn.ConnectionString = ConfigurationManager.ConnectionStrings["connGlobal"].ToString();
            conn.Open();

            cmd.Connection = conn;
            string INSERT = "INSERT INTO Email(Email,AppPassword,SenderName)VALUES(@email,@appPassword,@senderName)";
            cmd.Parameters.AddWithValue("email", EmailCredential.email);
            cmd.Parameters.AddWithValue("appPassword", EmailCredential.password);
            cmd.Parameters.AddWithValue("senderName", EmailCredential.senderName);
            cmd.CommandText = INSERT;
            cmd.ExecuteNonQuery();

            conn.Close();
            MetroMessageBox.Show(_owner, "Successfully Added your Gmail credentials in the System.", "RVL System", MessageBoxButtons.OK, MessageBoxIcon.Information);

            cmd.Parameters.Clear();
        }

        public static void deedAdventureAdd()
        {
            SqlConnection conn = new SqlConnection();
            SqlCommand cmd = new SqlCommand();

            LandsOwnedDeedAdventure _owner = new LandsOwnedDeedAdventure();

            conn.ConnectionString = ConfigurationManager.ConnectionStrings["connGlobal"].ToString();
            conn.Open();

            cmd.Connection = conn;
            string INSERT = "INSERT INTO DeedAdventure(APN,County,OriginalPrice,MarketPrice,StatusOfTheLand,TypeOfSale,DownPaymentMade,MonthlyPaymentMade,PaymentPaidSoFar,AmountClosed)VALUES(@apn,@county,@origPrice,@marketPrice,@StatsofTheLand,@typeOfSale,@downPaymentMade,@monthlyPaymentMade,@paymentPaidSoFar,@amountClosed)";
            cmd.Parameters.AddWithValue("apn", LandsOwnedDeedAdventure.apn);
            cmd.Parameters.AddWithValue("county", LandsOwnedDeedAdventure.county);
            cmd.Parameters.AddWithValue("origPrice", LandsOwnedDeedAdventure.originalPrice);
            cmd.Parameters.AddWithValue("marketPrice", LandsOwnedDeedAdventure.marketPrice);
            cmd.Parameters.AddWithValue("StatsofTheLand", LandsOwnedDeedAdventure.statusOfTheLand);
            cmd.Parameters.AddWithValue("typeOfSale", LandsOwnedDeedAdventure.typeOfSale);
            cmd.Parameters.AddWithValue("downPaymentMade", LandsOwnedDeedAdventure.downPaymentMade);
            cmd.Parameters.AddWithValue("monthlyPaymentMade", LandsOwnedDeedAdventure.monthlyPaymentMade);
            cmd.Parameters.AddWithValue("paymentPaidSoFar", LandsOwnedDeedAdventure.paymentPaidSoFar);
            cmd.Parameters.AddWithValue("amountClosed", LandsOwnedDeedAdventure.amountClosed);
            cmd.CommandText = INSERT;
            cmd.ExecuteNonQuery();

            conn.Close();
            MetroMessageBox.Show(_owner, "Successfully Added information for lands owned by Deed Adventure in the System.", "RVL System", MessageBoxButtons.OK, MessageBoxIcon.Information);

            cmd.Parameters.Clear();
        }

        public static void propertyInventoryAdd()
        {
            SqlConnection conn = new SqlConnection();
            SqlCommand cmd = new SqlCommand();

            PropertyInventory _owner = new PropertyInventory();

            conn.ConnectionString = ConfigurationManager.ConnectionStrings["connGlobal"].ToString();
            conn.Open();

            cmd.Connection = conn;
            string INSERT = "INSERT INTO DeedAdventure(Date_Listed,APN_ID,Original_Price,Current_Market_Value,Updated_Price,Image_no,Title,URL_link_for_each_social_media,GPS_Coordinates,GPS_URL_Link,Video_Property_Link,Current_Status,Lands_Sold_Site,Date_Sold,Current_Owner_of_the_Land,Sold_To_Land_Buyer,Buyers_Email,Buyers_PhoneNumber,Terms_and_Conditions,Notes_for_the_Terms,Payment_Remarks,URL_Deeds,URL_Stamp_Deeds,URL_Moonclerk_Form,Status,County,Additional_Notes)VALUES(@dateListed,@apnID,@originalPrice,@currentMarketValue,@updatedPrice,@imageNo,@title,@urlLinkForEachSocialMedia,gpsCoordinates,@gpsUrlLink,@videoProperty,@currentStatus,@landsSoldSite,@dateSold,@currentOwnerOfTheLand,@soldToLandBuyer,@buyersEmail,@buyersPhoneNumber,@termsAndConditions,@notesForTheTerms,@paymentRemarks,@urlDeeds,@urlStampDeeds,@urlMoonclerkForm,@status,@county,@additionalNotes)";
            cmd.Parameters.AddWithValue("dateListed", PropertyInventory.dateListed);
            cmd.Parameters.AddWithValue("apnID", PropertyInventory.apnID);
            cmd.Parameters.AddWithValue("originalPrice", PropertyInventory.originalPrice);
            cmd.Parameters.AddWithValue("currentMarketValue", PropertyInventory.currentMarketValue);
            cmd.Parameters.AddWithValue("updatedPrice", PropertyInventory.updatedPrice);
            cmd.Parameters.AddWithValue("imageNo", PropertyInventory.imageNo);
            cmd.Parameters.AddWithValue("title", PropertyInventory.title);
            cmd.Parameters.AddWithValue("urlLinkForEachSocialMedia", PropertyInventory.urlLinkSocialMedia);
            cmd.Parameters.AddWithValue("gpsCoordinates", PropertyInventory.gpsCoordinates);
            cmd.Parameters.AddWithValue("gpsUrlLink", PropertyInventory.gpsUrlLink);
            cmd.Parameters.AddWithValue("videoProperty", PropertyInventory.videoPropertyLink);
            cmd.Parameters.AddWithValue("currentStatus", PropertyInventory.currentStatus);
            cmd.Parameters.AddWithValue("landsSoldSite", PropertyInventory.landsSoldSite);
            cmd.Parameters.AddWithValue("dateSold", PropertyInventory.dateSold);
            cmd.Parameters.AddWithValue("currentOwnerOfTheLand", PropertyInventory.currentOwner);
            cmd.Parameters.AddWithValue("soldToLandBuyer", PropertyInventory.soldToLandBuyer);
            cmd.Parameters.AddWithValue("buyersEmail", PropertyInventory.buyersEmail);
            cmd.Parameters.AddWithValue("buyersPhoneNumber", PropertyInventory.buyersPhoneNumber);
            cmd.Parameters.AddWithValue("termsAndConditions", PropertyInventory.termsAndConditions);
            cmd.Parameters.AddWithValue("notesForTheTerms", PropertyInventory.notesForTheTerms);
            cmd.Parameters.AddWithValue("paymentRemarks", PropertyInventory.paymentRemarks);
            cmd.Parameters.AddWithValue("urlDeeds", PropertyInventory.urlDeeds);
            cmd.Parameters.AddWithValue("urlStampDeeds", PropertyInventory.urlStampDeeds);
            cmd.Parameters.AddWithValue("urlMoonclerkForm", PropertyInventory.urlMoonClerk);
            cmd.Parameters.AddWithValue("status", PropertyInventory.status);
            cmd.Parameters.AddWithValue("county", PropertyInventory.county);
            cmd.Parameters.AddWithValue("additionalNotes", PropertyInventory.additionalNotes);
            cmd.CommandText = INSERT;
            cmd.ExecuteNonQuery();

            conn.Close();
            MetroMessageBox.Show(_owner, "Successfully Added a property information in the System.", "RVL System", MessageBoxButtons.OK, MessageBoxIcon.Information);

            cmd.Parameters.Clear();
        }

        public static void marketingUpdate()
        {
            SqlConnection conn = new SqlConnection();
            SqlCommand cmd = new SqlCommand();

            MarketingUpdate _owner = new MarketingUpdate();

            conn.ConnectionString = ConfigurationManager.ConnectionStrings["connGlobal"].ToString();
            conn.Open();

            cmd.Connection = conn;
            string INSERT = "INSERT INTO tblMarketing(Lead_Received,Last_Name,First_Name,Middle_Name,Phone_Number,Email_Address,Issue_Description,Lead_Source,Other,Lead_FollowUp,Lead_Status,Priority,Memo,Lead_Assigned,Lead_Assesment)VALUES(@leadReceived,@ln,@fn,@mn,@pNum,@eAdd,@issueDes,@leadSource,@other,@leadFollow,@leadStats,@priority,@memo,@leadAssigned,@leadAssesment)";
            cmd.Parameters.AddWithValue("leadReceived", MarketingUpdate.leadReceived);
            cmd.Parameters.AddWithValue("ln", MarketingUpdate.lastName);
            cmd.Parameters.AddWithValue("fn", MarketingUpdate.firstName);
            cmd.Parameters.AddWithValue("mn", MarketingUpdate.middleName);
            cmd.Parameters.AddWithValue("pNum", MarketingUpdate.phoneNumber);
            cmd.Parameters.AddWithValue("eAdd", MarketingUpdate.emailAddress);
            cmd.Parameters.AddWithValue("issueDes", MarketingUpdate.issueDescription);
            cmd.Parameters.AddWithValue("leadSource", MarketingUpdate.leadSource);
            cmd.Parameters.AddWithValue("other", MarketingUpdate.other);
            cmd.Parameters.AddWithValue("leadFollow", MarketingUpdate.leadFollow);
            cmd.Parameters.AddWithValue("leadStats", MarketingUpdate.leadStat);
            cmd.Parameters.AddWithValue("priority", MarketingUpdate.priority);
            cmd.Parameters.AddWithValue("memo", MarketingUpdate.memo);
            cmd.Parameters.AddWithValue("leadAssigned", MarketingUpdate.leadAssigned);
            cmd.Parameters.AddWithValue("leadAssesment", MarketingUpdate.leadAssesment);
            cmd.CommandText = INSERT;
            cmd.ExecuteNonQuery();

            conn.Close();
            MetroMessageBox.Show(_owner, "Successfully updated these Marketing Information.", "RVL System", MessageBoxButtons.OK, MessageBoxIcon.Information);

            cmd.Parameters.Clear();
        }

        public static void socialMediaUpdate()
        {
            SqlConnection conn = new SqlConnection();
            SqlCommand cmd = new SqlCommand();

            SocialMediaUpdate _owner = new SocialMediaUpdate();

            conn.ConnectionString = ConfigurationManager.ConnectionStrings["connGlobal"].ToString();
            conn.Open();

            cmd.Connection = conn;
            string UPDATE = "UPDATE tblSocialMedia SET Current_Market_Value =@currentMarketValue, Updated_Price = @updatedPrice, Title = @title, Social_Media_Notes = @socialMedia, Hashtags = @hashtags, Schedule = @schedule, Pre_Approved = @preApproved, Status = @status, Additional_Notes =@additionalNotes";
            cmd.Parameters.AddWithValue("currentMarketValue", SocialMediaUpdate.currentMarketValue);
            cmd.Parameters.AddWithValue("updatedPrice", SocialMediaUpdate.updatePrice);
            cmd.Parameters.AddWithValue("title", SocialMediaUpdate.title);
            cmd.Parameters.AddWithValue("socialMedia", SocialMediaUpdate.socialMediaNotes);
            cmd.Parameters.AddWithValue("hashtags", SocialMediaUpdate.hashtags);
            cmd.Parameters.AddWithValue("schedule", SocialMediaUpdate.schedule);
            cmd.Parameters.AddWithValue("preApproved", SocialMediaUpdate.preApproved);
            cmd.Parameters.AddWithValue("status", SocialMediaUpdate.status);
            cmd.Parameters.AddWithValue("additionalNotes", SocialMediaUpdate.additionalNotes);
            cmd.CommandText = UPDATE;
            cmd.ExecuteNonQuery();

            conn.Close();
            //MetroMessageBox.Show(_owner, "Successfully updated these social media Information.", "RVL System", MessageBoxButtons.OK, MessageBoxIcon.Information);

            cmd.Parameters.Clear();
        }

        public static void updateLogin()
        {
            SqlConnection conn = new SqlConnection();
            SqlCommand cmd = new SqlCommand();

            Frm_UserEdit _owner = new Frm_UserEdit();

            conn.ConnectionString = ConfigurationManager.ConnectionStrings["connGlobal"].ToString();


            conn.Open();

            cmd.Connection = conn;
            string InsertLogin = "UPDATE tblLogin SET AcctID=@acctID, UID=@uid, UN =@un, PW=@Pw WHERE LID =@lid";
            cmd.Parameters.AddWithValue("acctID", Frm_UserEdit.acctID);
            cmd.Parameters.AddWithValue("uid", Frm_UserEdit.userID);
            cmd.Parameters.AddWithValue("un", Frm_UserEdit.userName);
            cmd.Parameters.AddWithValue("pw", Frm_UserEdit.passWord);
            cmd.Parameters.AddWithValue("lid", Frm_UserEdit.loginID);
            cmd.CommandText = InsertLogin;
            cmd.ExecuteNonQuery();

            MetroMessageBox.Show(_owner, "Successfully updated the information for this login.", "RVL System", MessageBoxButtons.OK, MessageBoxIcon.Information);

            conn.Close();
            cmd.Parameters.Clear();
        }

        public static void updateUser()
        {
            SqlConnection conn = new SqlConnection();
            SqlCommand cmd = new SqlCommand();

            Frm_UserEdit _owner = new Frm_UserEdit();

            conn.ConnectionString = ConfigurationManager.ConnectionStrings["connGlobal"].ToString();
            conn.Open();

            cmd.Connection = conn;
            string UPDATE = "UPDATE tblUser SET AcctID = @acctID, Full_Name=@fn WHERE UID = @uid";
            cmd.Parameters.AddWithValue("acctID", Frm_UserEdit.acctID);
            cmd.Parameters.AddWithValue("fn", Frm_UserEdit.fullName);
            cmd.Parameters.AddWithValue("uid", Frm_UserEdit.userID);
            cmd.CommandText = UPDATE;
            cmd.ExecuteNonQuery();

            MetroMessageBox.Show(_owner, "Successfully updated the User Information.", "RVL System", MessageBoxButtons.OK, MessageBoxIcon.Information);

            conn.Close();
            cmd.Parameters.Clear();
        }

        public static void companyUpdate()
        {
            SqlConnection conn = new SqlConnection();
            SqlCommand cmd = new SqlCommand();

            CompanyLoginsUpdate _owner = new CompanyLoginsUpdate();

            conn.ConnectionString = ConfigurationManager.ConnectionStrings["connGlobal"].ToString();
            conn.Open();

            cmd.Connection = conn;
            string UPDATE = "UPDATE tblCompanyLogins SET Category_Name = @cn, URL_Link=@url, Username = @un, Password=@pw, Name_Login_Under = @nLogin, Give_Access_To = @gAccessTo WHERE CID = @cid";
            cmd.Parameters.AddWithValue("cn", CompanyLoginsUpdate.categoryName);
            cmd.Parameters.AddWithValue("url", CompanyLoginsUpdate.URLlink);
            cmd.Parameters.AddWithValue("un", CompanyLoginsUpdate.userName);
            cmd.Parameters.AddWithValue("pw", CompanyLoginsUpdate.passWord);
            cmd.Parameters.AddWithValue("nLogin", CompanyLoginsUpdate.nameLogin);
            cmd.Parameters.AddWithValue("gAccessTo", CompanyLoginsUpdate.giveAccess);
            cmd.Parameters.AddWithValue("cid", CompanyLoginsUpdate.categoryID);
            cmd.CommandText = UPDATE;
            cmd.ExecuteNonQuery();

            conn.Close();
            MetroMessageBox.Show(_owner, "Successfully updated these Company Logins Information.", "RVL System", MessageBoxButtons.OK, MessageBoxIcon.Information);

            cmd.Parameters.Clear();
        }

        public static void landStayUpdate()
        {
            SqlConnection conn = new SqlConnection();
            SqlCommand cmd = new SqlCommand();

            LandStay _owner = new LandStay();

            conn.ConnectionString = ConfigurationManager.ConnectionStrings["connGlobal"].ToString();
            conn.Open();

            cmd.Connection = conn;
            string INSERT = "UPDATE tblLandStay SET Seller = @seller, Phone_Number = @phoneNumber, Seller_Email = @sellerEmail, Seller_Notes = @sellerNotes, Seller_Name = @sellerName, Availability = @availability ,State = @state, County = @county, APN = @APN, Acres = @acres, Legal = @legal, GPS = @GPS, Price = @price,Contact_or_Checkout = @contactOrCheckout WHERE LSID = @lsid";
            cmd.Parameters.AddWithValue("seller", LandStay.sellerUpdate);
            cmd.Parameters.AddWithValue("phoneNumber", LandStay.phoneUpdate);
            cmd.Parameters.AddWithValue("sellerEmail", LandStay.sellerEmailUpdate);
            cmd.Parameters.AddWithValue("sellerNotes", LandStay.sellerNotesUpdate);
            cmd.Parameters.AddWithValue("sellerName", LandStay.sellerNameUpdate);
            cmd.Parameters.AddWithValue("availability", LandStay.availabilityUpdate);
            cmd.Parameters.AddWithValue("state", LandStay.stateUpdate);
            cmd.Parameters.AddWithValue("county", LandStay.countyUpdate);
            cmd.Parameters.AddWithValue("APN", LandStay.APNUpdate);
            cmd.Parameters.AddWithValue("acres", LandStay.acresUpdate);
            cmd.Parameters.AddWithValue("legal", LandStay.legalUpdate);
            cmd.Parameters.AddWithValue("GPS", LandStay.gpsUpdate);
            cmd.Parameters.AddWithValue("price", LandStay.priceUpdate);
            cmd.Parameters.AddWithValue("contactOrCheckout", LandStay.contactOrCheckoutUpdate);
            cmd.Parameters.AddWithValue("lsid", LandStay.lsid);
            cmd.CommandText = INSERT;
            cmd.ExecuteNonQuery();

            conn.Close();
            MetroMessageBox.Show(_owner, "Successfully Updated these Land Stay Information.", "RVL System", MessageBoxButtons.OK, MessageBoxIcon.Information);

            cmd.Parameters.Clear();
        }

        public static void adminOfficeUpdate()
        {
            SqlConnection conn = new SqlConnection();
            SqlCommand cmd = new SqlCommand();

            AdminOfficeUpdate _owner = new AdminOfficeUpdate();

            conn.ConnectionString = ConfigurationManager.ConnectionStrings["connGlobal"].ToString();
            conn.Open();

            cmd.Connection = conn;
            string UPDATE = "UPDATE tblAdminContact SET Full_name = @fn, Email = @email, Phone_number = @phoneNumber, Address = @address, County = @county, Category = @category WHERE ACID = @acid";
            cmd.Parameters.AddWithValue("fn", AdminOfficeUpdate.fullName);
            cmd.Parameters.AddWithValue("email", AdminOfficeUpdate.eMail);
            cmd.Parameters.AddWithValue("phoneNumber", AdminOfficeUpdate.phoneNumber);
            cmd.Parameters.AddWithValue("address", AdminOfficeUpdate.address);
            cmd.Parameters.AddWithValue("county", AdminOfficeUpdate.county);
            cmd.Parameters.AddWithValue("category", AdminOfficeUpdate.category);
            cmd.Parameters.AddWithValue("acid", AdminOfficeUpdate.acid);
            cmd.CommandText = UPDATE;
            cmd.ExecuteNonQuery();

            conn.Close();
            MetroMessageBox.Show(_owner, "Successfully updated these Admin Contact List Information.", "RVL System", MessageBoxButtons.OK, MessageBoxIcon.Information);

            cmd.Parameters.Clear();
        }

        public static void videoTutorialsUpdate()
        {
            SqlConnection conn = new SqlConnection();
            SqlCommand cmd = new SqlCommand();

            VideoTutorialsUpdate _owner = new VideoTutorialsUpdate();

            conn.ConnectionString = ConfigurationManager.ConnectionStrings["connGlobal"].ToString();
            conn.Open();

            cmd.Connection = conn;
            string UPDATE = "UPDATE tblVideoTutorial SET Process = @proc, Link = @link  WHERE VID = @vid";
            cmd.Parameters.AddWithValue("proc", VideoTutorialsUpdate.process);
            cmd.Parameters.AddWithValue("link", VideoTutorialsUpdate.link);
            cmd.Parameters.AddWithValue("vid", VideoTutorialsUpdate.vid);
            cmd.CommandText = UPDATE;
            cmd.ExecuteNonQuery();

            conn.Close();
            MetroMessageBox.Show(_owner, "Successfully updated these Youtube Tutorials.", "RVL System", MessageBoxButtons.OK, MessageBoxIcon.Information);

            cmd.Parameters.Clear();
        }

        public static void emailUpdate()
        {
            SqlConnection conn = new SqlConnection();
            SqlCommand cmd = new SqlCommand();

            VideoTutorialsUpdate _owner = new VideoTutorialsUpdate();

            conn.ConnectionString = ConfigurationManager.ConnectionStrings["connGlobal"].ToString();
            conn.Open();

            cmd.Connection = conn;
            string UPDATE = "UPDATE Email SET Email = @email, AppPassword = @appPassword, SenderName = @senderName WHERE Email = @mail";
            cmd.Parameters.AddWithValue("email", EmailCredential.email);
            cmd.Parameters.AddWithValue("appPassword", EmailCredential.password);
            cmd.Parameters.AddWithValue("mail", EmailCredential.email);
            cmd.Parameters.AddWithValue("senderName", EmailCredential.senderName);
            cmd.CommandText = UPDATE;
            cmd.ExecuteNonQuery();

            conn.Close();
            MetroMessageBox.Show(_owner, "Successfully updated your Gmail credentials.", "RVL System", MessageBoxButtons.OK, MessageBoxIcon.Information);

            cmd.Parameters.Clear();
        }

        public static void taskAssign()
        {
            SqlConnection conn = new SqlConnection();
            SqlCommand cmd = new SqlCommand();

            conn.ConnectionString = ConfigurationManager.ConnectionStrings["connGlobal"].ToString();
            conn.Open();

            cmd.Connection = conn;
            string INSERT = "UPDATE tblUser SET TaskAssign=@taskAssign WHERE UID = @uid";
            cmd.Parameters.AddWithValue("TaskAssign", Frm_Tasks.taskAssign);
            cmd.Parameters.AddWithValue("UID", Frm_Tasks.uID);
            cmd.CommandText = INSERT;
            cmd.ExecuteNonQuery();

            MessageBox.Show("Task assign to this person.", "RVL System", MessageBoxButtons.OK, MessageBoxIcon.Information);
            conn.Close();

            cmd.Parameters.Clear();
        }

        public static void companyDelete()
        {
            SqlConnection conn = new SqlConnection();
            SqlCommand cmd = new SqlCommand();

            conn.ConnectionString = ConfigurationManager.ConnectionStrings["connGlobal"].ToString();
            conn.Open();

            cmd.Connection = conn;
            string DELETE = "DELETE tblCompanyLogins WHERE CID = @cid";
            cmd.Parameters.AddWithValue("cid", CompanyLoginsDelete.CID);
            cmd.CommandText = DELETE;
            cmd.ExecuteNonQuery();

            conn.Close();
            //MessageBox.Show("Successfully deleted this Company Logins Information.", "RVL System", MessageBoxButtons.OK, MessageBoxIcon.Information);

            cmd.Parameters.Clear();
        }

        public static void LandStayDelete()
        {
            SqlConnection conn = new SqlConnection();
            SqlCommand cmd = new SqlCommand();

            conn.ConnectionString = ConfigurationManager.ConnectionStrings["connGlobal"].ToString();
            conn.Open();

            cmd.Connection = conn;
            string DELETE = "DELETE tblLandStay WHERE LSID = @lsid";
            cmd.Parameters.AddWithValue("lsid", LandStay.lsidDelete);
            cmd.CommandText = DELETE;
            cmd.ExecuteNonQuery();

            conn.Close();
            MessageBox.Show("Successfully deleted these Company Logins Information.", "RVL System", MessageBoxButtons.OK, MessageBoxIcon.Information);

            cmd.Parameters.Clear();
        }

        public static void adminOfficeDelete()
        {
            SqlConnection conn = new SqlConnection();
            SqlCommand cmd = new SqlCommand();

            Frm_AdminOfficeDelete _owner = new Frm_AdminOfficeDelete();

            conn.ConnectionString = ConfigurationManager.ConnectionStrings["connGlobal"].ToString();
            conn.Open();

            cmd.Connection = conn;
            string DELETE = "DELETE tblAdminContact WHERE ACID = @acid";
            cmd.Parameters.AddWithValue("acid", Frm_AdminOfficeDelete.acid);
            cmd.CommandText = DELETE;
            cmd.ExecuteNonQuery();

            conn.Close();
            MetroMessageBox.Show(_owner, "Successfully deleted these Admin Contact List Information.", "RVL System", MessageBoxButtons.OK, MessageBoxIcon.Information);

            cmd.Parameters.Clear();
        }

        public static void videoTutorialsDelete()
        {
            SqlConnection conn = new SqlConnection();
            SqlCommand cmd = new SqlCommand();

            VideoTutorialsDelete _owner = new VideoTutorialsDelete();

            conn.ConnectionString = ConfigurationManager.ConnectionStrings["connGlobal"].ToString();
            conn.Open();

            cmd.Connection = conn;
            string DELETE = "DELETE tblVideoTutorial WHERE VID = @vid";
            cmd.Parameters.AddWithValue("vid", VideoTutorialsDelete.vid);
            cmd.CommandText = DELETE;
            cmd.ExecuteNonQuery();

            conn.Close();
            MetroMessageBox.Show(_owner, "Successfully deleted these Video Tutorials Information.", "RVL System", MessageBoxButtons.OK, MessageBoxIcon.Information);

            cmd.Parameters.Clear();
        }
    }
}
