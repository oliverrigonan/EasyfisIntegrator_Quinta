using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
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
            txt_timeTrigger.Enabled = false;
            txt_returnPath.Enabled = false;
            txt_returnPath.ReadOnly = false;
            btn_openExplorer.Enabled = false;

            txt_currentToken.Enabled = false;
            txt_APIURLHostEasyfis.Enabled = false;
            cmb_defaultVATOuput.Enabled = false;
            cmb_defaultVATInput.Enabled = false;
            cmb_defaultWTAX.Enabled = false;
            cmb_defaultDiscount.Enabled = false;
            cmb_defaultTerm.Enabled = false;

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
            txt_timeTrigger.Text = setting.TimeTrigger;
            txt_returnPath.Text = setting.ReturnPath;

            txt_APIURLHostEasyfis.Text = setting.APIURLHost;
            cmb_defaultVATOuput.SelectedItem = setting.DefaultVATOutput;
            cmb_defaultVATInput.SelectedItem = setting.DefaultVATInput;
            cmb_defaultWTAX.SelectedItem = setting.DefaultVTAX;
            cmb_defaultDiscount.SelectedItem = setting.DefaultDiscount;
            cmb_defaultTerm.SelectedItem = setting.DefaultTerm;

            CreateComboBoxTaxType();
            CreateComboBoxDiscount();
            CreateComboBoxTerm();

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
                logMessages("Date/Time Stamp: " + DateTime.Now.ToString("yyyy-MM-dd hh:mm:ss tt") + "\r\n\n \r\n\n");

                isIntegrating = true;
            }
        }

        private void btn_stop_Click(object sender, EventArgs e)
        {
            btn_start.Enabled = true;
            btn_stop.Enabled = false;
            dtp_currentDate.Enabled = true;

            logMessages("Integration has been stopped! \r\n\n");
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
                txt_timeTrigger.Enabled = false;
                txt_returnPath.Enabled = false;
                txt_returnPath.ReadOnly = false;
                btn_openExplorer.Enabled = false;

                txt_currentToken.Enabled = false;
                txt_APIURLHostEasyfis.Enabled = false;
                cmb_defaultVATOuput.Enabled = false;
                cmb_defaultVATInput.Enabled = false;
                cmb_defaultWTAX.Enabled = false;
                cmb_defaultDiscount.Enabled = false;
                cmb_defaultTerm.Enabled = false;

                btn_save.Enabled = false;
                btn_edit.Enabled = true;

                Entities.Settings newSettings = new Entities.Settings()
                {
                    CurrentToken = txt_currentToken.Text,
                    APIURLSource = txt_APIURLSource.Text,
                    HotelCode = txt_hotelCode.Text,
                    TimeTrigger = txt_timeTrigger.Text,
                    ReturnPath = txt_returnPath.Text,
                    APIURLHost = txt_APIURLHostEasyfis.Text,
                    DefaultVATOutput = cmb_defaultVATOuput.Text,
                    DefaultVATInput = cmb_defaultVATInput.Text,
                    DefaultVTAX = cmb_defaultWTAX.Text,
                    DefaultDiscount = cmb_defaultDiscount.Text,
                    DefaultTerm = cmb_defaultTerm.Text
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
                txt_timeTrigger.Enabled = true;
                txt_returnPath.Enabled = true;
                txt_returnPath.ReadOnly = true;
                btn_openExplorer.Enabled = true;

                txt_currentToken.Enabled = true;
                txt_APIURLHostEasyfis.Enabled = true;
                cmb_defaultVATOuput.Enabled = true;
                cmb_defaultVATInput.Enabled = true;
                cmb_defaultWTAX.Enabled = true;
                cmb_defaultDiscount.Enabled = true;
                cmb_defaultTerm.Enabled = true;

                btn_save.Enabled = true;
                btn_edit.Enabled = false;
            }
            else
            {
                MessageBox.Show("Please stop the activity first.", "Error", MessageBoxButtons.OK, MessageBoxIcon.Error);
            }
        }

        private void tmr_timeTriggerTick(object sender, EventArgs e)
        {
            txt_time.Text = DateTime.Now.ToString("hh:mm:ss tt", CultureInfo.InvariantCulture);

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

        private void btn_openExplorer_Click(object sender, EventArgs e)
        {
            fbd_returnDataPath.ShowDialog();
            txt_returnPath.Text = fbd_returnDataPath.SelectedPath;
        }

        public void CreateComboBoxTaxType()
        {
            try
            {
                HttpWebRequest httpWebRequest = (HttpWebRequest)WebRequest.Create(txt_APIURLHostEasyfis.Text + "/api/quinta/integration/salesInvoice/dropdown/taxType/list");
                httpWebRequest.ContentType = "application/json";
                httpWebRequest.Method = "GET";

                HttpWebResponse httpResponse = (HttpWebResponse)httpWebRequest.GetResponse();
                using (StreamReader streamReader = new StreamReader(httpResponse.GetResponseStream()))
                {
                    var result = streamReader.ReadToEnd();

                    JavaScriptSerializer javaScriptSerializer = new JavaScriptSerializer();
                    List<Entities.MstTaxType> mstTaxTypes = (List<Entities.MstTaxType>)javaScriptSerializer.Deserialize(result, typeof(List<Entities.MstTaxType>));

                    var isFirstIndexSelected = false;

                    foreach (var taxType in mstTaxTypes)
                    {
                        cmb_defaultVATOuput.Items.Add(taxType.TaxType);
                        cmb_defaultVATInput.Items.Add(taxType.TaxType);
                        cmb_defaultWTAX.Items.Add(taxType.TaxType);

                        if (!isFirstIndexSelected)
                        {
                            cmb_defaultVATOuput.SelectedItem = taxType.TaxType;
                            cmb_defaultVATInput.SelectedItem = taxType.TaxType;
                            cmb_defaultWTAX.SelectedItem = taxType.TaxType;

                            isFirstIndexSelected = true;
                        }
                    }

                    String settingsPath = Path.Combine(Path.GetDirectoryName(Assembly.GetExecutingAssembly().Location), @"settings.json");

                    String settingsJson;
                    using (StreamReader settingsStreamReader = new StreamReader(settingsPath))
                    {
                        settingsJson = settingsStreamReader.ReadToEnd();
                    }

                    JavaScriptSerializer js = new JavaScriptSerializer();
                    Entities.Settings s = js.Deserialize<Entities.Settings>(settingsJson);

                    cmb_defaultVATOuput.SelectedItem = s.DefaultVATOutput;
                    cmb_defaultVATInput.SelectedItem = s.DefaultVATInput;
                    cmb_defaultWTAX.SelectedItem = s.DefaultVTAX;
                }
            }
            catch (Exception e)
            {
                logMessages(e.Message + "\r\n\n");
                logMessages("Date/Time Stamp: " + DateTime.Now.ToString("yyyy-MM-dd hh:mm:ss tt") + "\r\n\n \r\n\n");
            }
        }

        public void CreateComboBoxDiscount()
        {
            try
            {
                HttpWebRequest httpWebRequest = (HttpWebRequest)WebRequest.Create(txt_APIURLHostEasyfis.Text + "/api/quinta/integration/salesInvoice/dropdown/discount/list");
                httpWebRequest.ContentType = "application/json";
                httpWebRequest.Method = "GET";

                HttpWebResponse httpResponse = (HttpWebResponse)httpWebRequest.GetResponse();
                using (StreamReader streamReader = new StreamReader(httpResponse.GetResponseStream()))
                {
                    var result = streamReader.ReadToEnd();

                    JavaScriptSerializer javaScriptSerializer = new JavaScriptSerializer();
                    List<Entities.MstDiscount> mstDiscounts = (List<Entities.MstDiscount>)javaScriptSerializer.Deserialize(result, typeof(List<Entities.MstDiscount>));

                    var isFirstIndexSelected = false;

                    foreach (var discount in mstDiscounts)
                    {
                        cmb_defaultDiscount.Items.Add(discount.Discount);

                        if (!isFirstIndexSelected)
                        {
                            cmb_defaultDiscount.SelectedItem = discount.Discount;

                            isFirstIndexSelected = true;
                        }
                    }

                    String settingsPath = Path.Combine(Path.GetDirectoryName(Assembly.GetExecutingAssembly().Location), @"settings.json");

                    String settingsJson;
                    using (StreamReader settingsStreamReader = new StreamReader(settingsPath))
                    {
                        settingsJson = settingsStreamReader.ReadToEnd();
                    }

                    JavaScriptSerializer js = new JavaScriptSerializer();
                    Entities.Settings s = js.Deserialize<Entities.Settings>(settingsJson);

                    cmb_defaultDiscount.SelectedItem = s.DefaultDiscount;
                }
            }
            catch (Exception e)
            {
                logMessages(e.Message + "\r\n\n");
                logMessages("Date/Time Stamp: " + DateTime.Now.ToString("yyyy-MM-dd hh:mm:ss tt") + "\r\n\n \r\n\n");
            }
        }

        public void CreateComboBoxTerm()
        {
            try
            {
                HttpWebRequest httpWebRequest = (HttpWebRequest)WebRequest.Create(txt_APIURLHostEasyfis.Text + "/api/quinta/integration/salesInvoice/dropdown/term/list");
                httpWebRequest.ContentType = "application/json";
                httpWebRequest.Method = "GET";

                HttpWebResponse httpResponse = (HttpWebResponse)httpWebRequest.GetResponse();
                using (StreamReader streamReader = new StreamReader(httpResponse.GetResponseStream()))
                {
                    var result = streamReader.ReadToEnd();

                    JavaScriptSerializer javaScriptSerializer = new JavaScriptSerializer();
                    List<Entities.MstTerm> mstTerms = (List<Entities.MstTerm>)javaScriptSerializer.Deserialize(result, typeof(List<Entities.MstTerm>));

                    var isFirstIndexSelected = false;

                    foreach (var term in mstTerms)
                    {
                        cmb_defaultTerm.Items.Add(term.Term);

                        if (!isFirstIndexSelected)
                        {
                            cmb_defaultTerm.SelectedItem = term.Term;

                            isFirstIndexSelected = true;
                        }
                    }

                    String settingsPath = Path.Combine(Path.GetDirectoryName(Assembly.GetExecutingAssembly().Location), @"settings.json");

                    String settingsJson;
                    using (StreamReader settingsStreamReader = new StreamReader(settingsPath))
                    {
                        settingsJson = settingsStreamReader.ReadToEnd();
                    }

                    JavaScriptSerializer js = new JavaScriptSerializer();
                    Entities.Settings s = js.Deserialize<Entities.Settings>(settingsJson);

                    cmb_defaultTerm.SelectedItem = s.DefaultTerm;
                }
            }
            catch (Exception e)
            {
                logMessages(e.Message + "\r\n\n");
                logMessages("Date/Time Stamp: " + DateTime.Now.ToString("yyyy-MM-dd hh:mm:ss tt") + "\r\n\n \r\n\n");
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
                    logMessages("Reading data...\r\n\n");

                    var result = streamReader.ReadToEnd();
                    JavaScriptSerializer javaScriptSerializer = new JavaScriptSerializer();
                    Entities.Quinta.RootObject rootObject = (Entities.Quinta.RootObject)javaScriptSerializer.Deserialize(result, typeof(Entities.Quinta.RootObject));

                    List<Entities.Quinta.TRN> newListTRN = new List<Entities.Quinta.TRN>();
                    foreach (var TRN in rootObject.TRN)
                    {
                        List<Entities.Quinta.JEN> newListJEN = new List<Entities.Quinta.JEN>();
                        foreach (var JEN in TRN.JEN)
                        {
                            Entities.Quinta.JEN newJEN = new Entities.Quinta.JEN()
                            {
                                FTN = JEN.FTN,
                                SAR = JEN.SAR,
                                FID = JEN.FID,
                                SUF = JEN.SUF,
                                ACI = JEN.ACI,
                                ACS = JEN.ACS,
                                SAC = JEN.SAC,
                                ADC = JEN.ADC,
                                TDT = JEN.TDT,
                                GLC = JEN.GLC,
                                DBT = JEN.DBT,
                                CRD = JEN.CRD,
                                BNK = JEN.BNK,
                                BNM = JEN.BNM,
                                BOA = JEN.BOA,
                                CTI = JEN.CTI,
                                CNO = JEN.CNO,
                                VNO = JEN.VNO,
                                VDT = JEN.VDT,
                                CHQ = JEN.CHQ
                            };

                            newListJEN.Add(newJEN);
                        }

                        Entities.Quinta.TRN newTRN = new Entities.Quinta.TRN()
                        {
                            FTN = TRN.FTN,
                            PTN = TRN.PTN,
                            FID = TRN.FID,
                            STS = TRN.STS,
                            ADT = TRN.ADT,
                            DDT = TRN.DDT,
                            TDT = TRN.TDT,
                            TCI = TRN.TCI,
                            TCC = TRN.TCC,
                            MEM = TRN.MEM,
                            SAR = TRN.SAR,
                            SAI = TRN.SAI, // Item Code
                            SAM = TRN.SAM, // Item Description
                            ACI = TRN.ACI, // Customer Code
                            ACC = TRN.ACC, // Customer Name
                            RNO = TRN.RNO,
                            ACS = TRN.ACS,
                            CUR = TRN.CUR,
                            DSC = TRN.DSC,
                            DSA = TRN.DSA,
                            BAM = TRN.BAM,
                            GAM = TRN.GAM,
                            NBA = TRN.NBA,
                            NAM = TRN.NAM,
                            BNK = TRN.BNK,
                            BNM = TRN.BNM,
                            BOA = TRN.BOA,
                            CTI = TRN.CTI,
                            CNO = TRN.CNO,
                            VNO = TRN.VNO,
                            VDT = TRN.VDT,
                            CHQ = TRN.CHQ,
                            RMK = TRN.RMK,
                            RMO = TRN.RMO,
                            CNT = TRN.CNT,
                            WHT = TRN.WHT,
                            MRK = TRN.MRK,
                            SRC = TRN.SRC,
                            JEN = newListJEN
                        };

                        newListTRN.Add(newTRN);
                    }

                    Entities.Quinta.CON newCON = new Entities.Quinta.CON()
                    {
                        DPI = rootObject.CON.DPI,
                        DCI = rootObject.CON.DCI,
                    };

                    String defaultTerm = cmb_defaultTerm.Text;
                    String defaultVatOutput = cmb_defaultVATOuput.Text;
                    String defaultVatInput = cmb_defaultVATInput.Text;
                    String defaultWTax = cmb_defaultWTAX.Text;
                    String defaultDiscount = cmb_defaultDiscount.Text;

                    Entities.Quinta.RootObject rootObjectData = new Entities.Quinta.RootObject()
                    {
                        CON = newCON,
                        TRN = newListTRN,
                        DefaultTerm = defaultTerm,
                        DefaultVatOutput = defaultVatOutput,
                        DefaultVatInput = defaultVatInput,
                        DefaultWTax = defaultWTax,
                        DefaultDiscount = defaultDiscount,
                    };

                    String json = new JavaScriptSerializer().Serialize(rootObjectData);
                    SendData(json);
                }
            }
            catch (Exception e)
            {
                logMessages("Reading Error: " + e.Message + "\r\n\n");
                logMessages("Date/Time Stamp: " + DateTime.Now.ToString("yyyy-MM-dd hh:mm:ss tt") + "\r\n\n \r\n\n");
            }
        }

        public void SendData(String json)
        {
            try
            {
                HttpWebRequest httpWebRequest = (HttpWebRequest)WebRequest.Create(txt_APIURLHostEasyfis.Text + "/api/quinta/integration/salesInvoice/add");
                httpWebRequest.ContentType = "application/json";
                httpWebRequest.Method = "POST";

                using (StreamWriter streamWriter = new StreamWriter(httpWebRequest.GetRequestStream()))
                {
                    JavaScriptSerializer javaScriptSerializer = new JavaScriptSerializer();
                    Entities.Quinta.RootObject rootObject = javaScriptSerializer.Deserialize<Entities.Quinta.RootObject>(json);

                    streamWriter.Write(new JavaScriptSerializer().Serialize(rootObject));
                }

                HttpWebResponse httpResponse = (HttpWebResponse)httpWebRequest.GetResponse();
                using (StreamReader streamReader = new StreamReader(httpResponse.GetResponseStream()))
                {
                    var result = streamReader.ReadToEnd();
                    if (result != null)
                    {
                        DateTime dateTimeNow = DateTime.Now;
                        String todayDate = dateTimeNow.ToString("yyyy-MM-dd", CultureInfo.InvariantCulture);

                        String jsonReturnPath = txt_returnPath.Text;
                        String fileName = "Return (" + todayDate + ")";
                        String jsonFileName = jsonReturnPath + "\\" + fileName + ".json";

                        File.WriteAllText(jsonFileName, result);

                        logMessages("Sent Succesful! \r\n\n");
                        logMessages("Date/Time Stamp: " + DateTime.Now.ToString("yyyy-MM-dd hh:mm:ss tt") + "\r\n\n \r\n\n");
                    }
                }
            }
            catch (Exception e)
            {
                logMessages("Sending Error: " + e.Message + "\r\n\n");
                logMessages("Date/Time Stamp: " + DateTime.Now.ToString("yyyy-MM-dd hh:mm:ss tt") + "\r\n\n \r\n\n");
            }
        }
    }
}
