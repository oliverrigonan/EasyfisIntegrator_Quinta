using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Diagnostics;
using System.Drawing;
using System.Globalization;
using System.IO;
using System.Linq;
using System.Net;
using System.Reflection;
using System.Text;
using System.Threading;
using System.Threading.Tasks;
using System.Web.Script.Serialization;
using System.Windows.Forms;

namespace EasyfisIntegration_Quinta
{
    public partial class MainForm : Form
    {
        public MainForm()
        {
            InitializeComponent();

            btn_start.Enabled = true;
            btn_stop.Enabled = false;
            dtp_currentDate.Enabled = true;

            txt_APIURLSource.Enabled = false;
            txt_hotelCode.Enabled = false;
            txt_currentToken.Enabled = false;
            txt_APIURLHostEasyfis.Enabled = false;
            cbx_IsTimeTrigger.Enabled = false;
            txt_timeTrigger.Enabled = false;

            btn_save.Enabled = false;
            btn_edit.Enabled = true;

            LoadSettings();
        }

        public Boolean isIntegrating = false;

        public void LoadSettings()
        {
            String settingsPath = Path.Combine(Path.GetDirectoryName(Assembly.GetExecutingAssembly().Location), @"Settings.json");

            String json;
            using (StreamReader trmRead = new StreamReader(settingsPath)) { json = trmRead.ReadToEnd(); }

            JavaScriptSerializer javaScriptSerializer = new JavaScriptSerializer();
            Entities.Settings setting = javaScriptSerializer.Deserialize<Entities.Settings>(json);

            txt_currentToken.Text = setting.CurrentToken;
            txt_APIURLSource.Text = setting.APIURLSource;
            txt_hotelCode.Text = setting.HotelCode;
            txt_APIURLHostEasyfis.Text = setting.APIURLHost;
            cbx_IsTimeTrigger.Checked = setting.IsTimeTrigger;
            txt_timeTrigger.Text = setting.TimeTrigger;

            logMessages("Press Start to Integrate... \r\n\n \r\n\n");
        }

        public void logMessages(String message)
        {
            txt_activity.Text += message;

            txt_activity.Focus();
            txt_activity.SelectionStart = txt_activity.Text.Length;
            txt_activity.ScrollToCaret();
        }

        private void btn_start_Click(object sender, EventArgs e)
        {
            if (btn_save.Enabled)
            {
                MessageBox.Show("Settings not save.", "Error", MessageBoxButtons.OK, MessageBoxIcon.Error);
            }
            else
            {
                btn_start.Enabled = false;
                btn_stop.Enabled = true;
                dtp_currentDate.Enabled = false;

                logMessages("Integration has been started! \r\n\n");
                logMessages("Date/Time Stamp: " + DateTime.Now.ToString("yyyy-MM-dd hh:mm:ss tt") + "\r\n\n\r\n\n");

                if (cbx_IsTimeTrigger.Checked)
                {
                    isIntegrating = true;
                }
                else
                {
                    Integrate();
                }
            }
        }

        private void btn_stop_Click(object sender, EventArgs e)
        {
            btn_start.Enabled = true;
            btn_stop.Enabled = false;
            dtp_currentDate.Enabled = true;

            logMessages("\r\n\nIntegration has been stopped! \r\n\n");
            logMessages("Date/Time Stamp: " + DateTime.Now.ToString("yyyy-MM-dd hh:mm:ss tt") + "\r\n\n \r\n\n");

            isIntegrating = false;
        }

        private void btn_save_Click(object sender, EventArgs e)
        {
            DialogResult dialogResult = MessageBox.Show("Save changes?", "Save Settings", MessageBoxButtons.YesNo, MessageBoxIcon.Question);
            if (dialogResult == DialogResult.Yes)
            {
                txt_APIURLSource.Enabled = false;
                txt_hotelCode.Enabled = false;
                txt_currentToken.Enabled = false;
                txt_APIURLHostEasyfis.Enabled = false;
                cbx_IsTimeTrigger.Enabled = false;
                txt_timeTrigger.Enabled = false;

                btn_save.Enabled = false;
                btn_edit.Enabled = true;

                Entities.Settings newSettings = new Entities.Settings()
                {
                    CurrentToken = txt_currentToken.Text,
                    APIURLSource = txt_APIURLSource.Text,
                    HotelCode = txt_hotelCode.Text,
                    APIURLHost = txt_APIURLHostEasyfis.Text,
                    IsTimeTrigger = cbx_IsTimeTrigger.Checked,
                    TimeTrigger = txt_timeTrigger.Text
                };

                String settingsPath = Path.Combine(Path.GetDirectoryName(Assembly.GetExecutingAssembly().Location), @"Settings.json");
                String newJson = new JavaScriptSerializer().Serialize(newSettings);

                File.WriteAllText(settingsPath, newJson);
            }
        }

        private void btn_edit_Click(object sender, EventArgs e)
        {
            if (btn_start.Enabled)
            {
                txt_APIURLSource.Enabled = true;
                txt_hotelCode.Enabled = true;
                txt_currentToken.Enabled = true;
                txt_APIURLHostEasyfis.Enabled = true;
                cbx_IsTimeTrigger.Enabled = true;
                txt_timeTrigger.Enabled = true;

                btn_save.Enabled = true;
                btn_edit.Enabled = false;
            }
            else
            {
                MessageBox.Show("Please stop the activity first.", "Error", MessageBoxButtons.OK, MessageBoxIcon.Error);
            }
        }

        public DateTime currentDate = DateTime.Today;
        public DateTime tomorrowDate = DateTime.Today.AddDays(1);

        private void tmr_timeTriggerTick(object sender, EventArgs e)
        {
            txt_time.Text = DateTime.Now.ToString("hh:mm:ss tt", CultureInfo.InvariantCulture);

            if (DateTime.Today == tomorrowDate)
            {
                tomorrowDate = DateTime.Today.AddDays(1);
                dtp_currentDate.Text = DateTime.Today.ToShortDateString();
            }

            if (isIntegrating)
            {
                if (txt_time.Text.Equals(txt_timeTrigger.Text))
                {
                    logMessages("Integrating..." + "\r\n\n");
                    logMessages("Downloading data source..." + "\r\n\n \r\n\n");

                    if (!btn_start.Enabled)
                    {
                        Integrate();
                    }
                }
            }
        }

        private void MainForm_FormClosing(object sender, FormClosingEventArgs e)
        {
            e.Cancel = true;
            Activate();

            DialogResult dialogResult = MessageBox.Show("Are you sure you want to close this application?", "Close Integrator", MessageBoxButtons.YesNo, MessageBoxIcon.Question);
            if (dialogResult == DialogResult.Yes)
            {
                if (btn_start.Enabled)
                {
                    Environment.Exit(0);
                }
                else
                {
                    MessageBox.Show("Please stop the activity first.", "Error", MessageBoxButtons.OK, MessageBoxIcon.Error);
                }
            }
        }

        public void Integrate()
        {
            try
            {
                String currentDate = dtp_currentDate.Value.ToString("yyyy-MM-dd", CultureInfo.InvariantCulture);

                HttpWebRequest httpWebRequest = (HttpWebRequest)WebRequest.Create(txt_APIURLSource.Text + "/api/backoffice/transjournal?hcd=" + txt_hotelCode.Text + "&tkn=" + txt_currentToken.Text + "&pos=false&frm=" + currentDate + "&tdt=" + currentDate);
                httpWebRequest.Method = "GET";
                httpWebRequest.Accept = "application/json";

                HttpWebResponse httpResponse = (HttpWebResponse)httpWebRequest.GetResponse();
                using (StreamReader streamReader = new StreamReader(httpResponse.GetResponseStream()))
                {
                    var result = streamReader.ReadToEnd();

                    JavaScriptSerializer javaScriptSerializer = new JavaScriptSerializer();
                    Entities.Quinta.RootObject rootObject = (Entities.Quinta.RootObject)javaScriptSerializer.Deserialize(result, typeof(Entities.Quinta.RootObject));

                    if (rootObject.TRN.Any())
                    {
                        String previousFID = "";

                        var creditSales = from d in rootObject.TRN
                                          where d.ACS.Equals("CREDIT")
                                          select d;

                        if (creditSales.Any())
                        {
                            logMessages("Sending sales...\r\n\n");

                            foreach (var data in creditSales)
                            {
                                var datas = data;

                                Decimal baseAmount = data.BAM;
                                Decimal discountPercentage = data.DSC;
                                Decimal discountAmount = data.DSA;
                                Decimal grossAmount = data.GAM;
                                Decimal netAmount = data.NAM;

                                Decimal VATAmount = 0;
                                if (grossAmount != netAmount)
                                {
                                    VATAmount = grossAmount - netAmount;
                                }

                                Boolean isSales = false;
                                if (data.ACS.Equals("CREDIT"))
                                {
                                    isSales = true;
                                }

                                Entities.Quinta.TrnSalesInvoice newSalesInvoice = new Entities.Quinta.TrnSalesInvoice()
                                {
                                    SIDate = data.ADT,
                                    DocumentReference = data.FID.ToString(),
                                    ManualSINumber = data.FID.ToString(),
                                    CustomerCode = data.ACI,
                                    Customer = data.ACC,
                                    Remarks = data.STS,
                                    ItemCode = data.SAI,
                                    Item = data.SAM,
                                    DiscountPercentage = discountPercentage,
                                    DiscountAmount = discountAmount,
                                    Amount = grossAmount,
                                    ORDate = data.TDT,
                                    VATAmount = VATAmount,
                                    CheckNumber = data.CHQ,
                                    BankCode = data.BNK.ToString(),
                                    Bank = data.BNM,
                                    Particulars = "FTN: " + data.FTN.ToString() + ", TDT: " + data.TDT + ", MEM: " + data.MEM,
                                    IsSales = isSales
                                };

                                Boolean displayMessage = false;

                                if (previousFID.Equals("") || previousFID.Equals(String.Empty))
                                {
                                    logMessages("Sending FID: " + data.FID.ToString() + " \r\n\n");
                                    displayMessage = true;
                                }
                                else
                                {
                                    if (previousFID.Equals(data.FID.ToString()) == false)
                                    {
                                        logMessages("Sending FID: " + data.FID.ToString() + " \r\n\n");
                                        displayMessage = true;
                                    }
                                }

                                previousFID = data.FID;

                                String json = new JavaScriptSerializer().Serialize(newSalesInvoice);
                                SendData(json, displayMessage);
                            }
                        }

                        var debitCollections = from d in rootObject.TRN
                                               where d.ACS.Equals("DEBIT")
                                               select d;

                        if (debitCollections.Any())
                        {
                            logMessages("Sending collections...\r\n\n");

                            foreach (var data in debitCollections)
                            {
                                var datas = data;

                                Decimal baseAmount = data.BAM;
                                Decimal discountPercentage = data.DSC;
                                Decimal discountAmount = data.DSA;
                                Decimal grossAmount = data.GAM;
                                Decimal netAmount = data.NAM;

                                Decimal VATAmount = 0;
                                if (grossAmount != netAmount)
                                {
                                    VATAmount = grossAmount - netAmount;
                                }

                                Boolean isSales = false;
                                if (data.ACS.Equals("CREDIT"))
                                {
                                    isSales = true;
                                }

                                Entities.Quinta.TrnSalesInvoice newSalesInvoice = new Entities.Quinta.TrnSalesInvoice()
                                {
                                    SIDate = data.TDT,
                                    DocumentReference = data.FID.ToString(),
                                    ManualSINumber = data.FID.ToString(),
                                    CustomerCode = data.ACI,
                                    Customer = data.ACC,
                                    Remarks = data.STS,
                                    ItemCode = data.SAI,
                                    Item = data.SAM,
                                    DiscountPercentage = discountPercentage,
                                    DiscountAmount = discountAmount,
                                    Amount = grossAmount,
                                    ORDate = data.TDT,
                                    VATAmount = VATAmount,
                                    CheckNumber = data.CHQ,
                                    BankCode = data.BNK.ToString(),
                                    Bank = data.BNM,
                                    Particulars = "FTN: " + data.FTN.ToString() + ", TDT: " + data.TDT + ", MEM: " + data.MEM,
                                    IsSales = isSales
                                };

                                Boolean displayMessage = false;

                                if (previousFID.Equals("") || previousFID.Equals(String.Empty))
                                {
                                    logMessages("Sending FID: " + data.FID.ToString() + " \r\n\n");
                                    displayMessage = true;
                                }
                                else
                                {
                                    if (previousFID.Equals(data.FID.ToString()) == false)
                                    {
                                        logMessages("Sending FID: " + data.FID.ToString() + " \r\n\n");
                                        displayMessage = true;
                                    }
                                }

                                previousFID = data.FID;

                                String json = new JavaScriptSerializer().Serialize(newSalesInvoice);
                                SendData(json, displayMessage);
                            }
                        }
                    }
                }
            }
            catch (Exception e)
            {
                logMessages("Reading Error: " + e + "\r\n\n");
                logMessages("Date/Time Stamp: " + DateTime.Now.ToString("yyyy-MM-dd hh:mm:ss tt") + "\r\n\n \r\n\n");
            }
        }

        public void SendData(String json, Boolean displayMessage)
        {
            try
            {
                HttpWebRequest httpWebRequest = (HttpWebRequest)WebRequest.Create(txt_APIURLHostEasyfis.Text + "/api/quinta/integration/salesInvoice/collection/send");
                httpWebRequest.ContentType = "application/json";
                httpWebRequest.Method = "POST";

                using (StreamWriter streamWriter = new StreamWriter(httpWebRequest.GetRequestStream()))
                {
                    Entities.Quinta.TrnSalesInvoice jsonData = new JavaScriptSerializer().Deserialize<Entities.Quinta.TrnSalesInvoice>(json);
                    streamWriter.Write(new JavaScriptSerializer().Serialize(jsonData));
                }

                HttpWebResponse httpResponse = (HttpWebResponse)httpWebRequest.GetResponse();
                using (StreamReader streamReader = new StreamReader(httpResponse.GetResponseStream()))
                {
                    if (displayMessage)
                    {
                        String resp = streamReader.ReadToEnd().Replace("\"", "");
                        if (resp.Equals(""))
                        {
                            logMessages("Send Successful! \r\n\n");
                            logMessages("Date/Time Stamp: " + DateTime.Now.ToString("yyyy-MM-dd hh:mm:ss tt") + "\r\n\n \r\n\n");
                        }
                        else
                        {
                            logMessages("Send Failed! " + resp + "\r\n\n");
                            logMessages("Date/Time Stamp: " + DateTime.Now.ToString("yyyy-MM-dd hh:mm:ss tt") + "\r\n\n \r\n\n");
                        }
                    }
                }
            }
            catch (WebException we)
            {
                var resp = new StreamReader(we.Response.GetResponseStream()).ReadToEnd();

                logMessages(resp + "\r\n\n");
                logMessages("Date/Time Stamp: " + DateTime.Now.ToString("yyyy-MM-dd hh:mm:ss tt") + "\r\n\n \r\n\n");
            }
        }
    }
}
