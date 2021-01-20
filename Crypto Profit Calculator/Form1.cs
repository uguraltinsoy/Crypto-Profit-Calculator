using Newtonsoft.Json.Linq;
using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Linq;
using System.Net;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;

namespace Crypto_Profit_Calculator
{
    public partial class Form1 : Form
    {
        double val_1, val_2, val_3, val_4, val_5, val_6;   
        double val_7, val_8, val_9, val_10, val_11, val_12;

        int bankCount = 0;
        int symbolCount = 0;

        string[] banks = {"Binance","BtcTurk"/*,"Poloniex","Kucoin","Bittrex","Kraken","Bitfinex","Bitstamp" */};

        string[] binanceSymbol = { "BTCTRY", "BNBTRY", "BUSDTRY", "ETHTRY", "XRPTRY", "USDTTRY", "LINKTRY", "SXPTRY", "AVAXTRY", "TRXTRY", "CHZTRY", "XLMTRY","BTCUSDT","ETHUSDT","BNBUSDT","BCCUSDT","NEOUSDT","LTCUSDT","QTUMUSDT","ADAUSDT","XRPUSDT","EOSUSDT","TUSDUSDT","IOTAUSDT","XLMUSDT","ONTUSDT","TRXUSDT","ETCUSDT","ICXUSDT","VENUSDT","NULSUSDT","VETUSDT","PAXUSDT","BCHABCUSDT","BCHSVUSDT","USDCUSDT","LINKUSDT","WAVESUSDT","BTTUSDT","USDSUSDT","ONGUSDT","HOTUSDT","ZILUSDT","ZRXUSDT","FETUSDT","BATUSDT","XMRUSDT","ZECUSDT","IOSTUSDT","CELRUSDT","DASHUSDT","NANOUSDT","OMGUSDT","THETAUSDT","ENJUSDT","MITHUSDT","MATICUSDT","ATOMUSDT","TFUELUSDT","ONEUSDT","FTMUSDT","ALGOUSDT","USDSBUSDT","GTOUSDT","ERDUSDT","DOGEUSDT","DUSKUSDT","ANKRUSDT","WINUSDT","COSUSDT","NPXSUSDT","COCOSUSDT","MTLUSDT","TOMOUSDT","PERLUSDT","DENTUSDT","MFTUSDT","KEYUSDT","STORMUSDT","DOCKUSDT","WANUSDT","FUNUSDT","CVCUSDT","CHZUSDT","BANDUSDT","BUSDUSDT","BEAMUSDT","XTZUSDT","RENUSDT","RVNUSDT","HCUSDT","HBARUSDT","NKNUSDT","STXUSDT","KAVAUSDT","ARPAUSDT","IOTXUSDT","RLCUSDT","MCOUSDT","CTXCUSDT","BCHUSDT","TROYUSDT","VITEUSDT","FTTUSDT","BUSDTRY","USDTTRY","USDTRUB","EURUSDT","OGNUSDT","DREPUSDT","BULLUSDT","BEARUSDT","ETHBULLUSDT","ETHBEARUSDT","TCTUSDT","WRXUSDT","BTSUSDT","LSKUSDT","BNTUSDT","LTOUSDT","EOSBULLUSDT","EOSBEARUSDT","XRPBULLUSDT","XRPBEARUSDT","STRATUSDT","AIONUSDT","MBLUSDT","COTIUSDT","BNBBULLUSDT","BNBBEARUSDT","STPTUSDT","USDTZAR","WTCUSDT","DATAUSDT","XZCUSDT","SOLUSDT","USDTIDRT","CTSIUSDT","HIVEUSDT","CHRUSDT","BTCUPUSDT","BTCDOWNUSDT","GXSUSDT","ARDRUSDT","LENDUSDT","MDTUSDT","STMXUSDT","KNCUSDT","REPUSDT","LRCUSDT","PNTUSDT","USDTUAH","COMPUSDT","USDTBIDR","BKRWUSDT","SCUSDT","ZENUSDT","SNXUSDT","ETHUPUSDT","ETHDOWNUSDT","ADAUPUSDT","ADADOWNUSDT","LINKUPUSDT","LINKDOWNUSDT","VTHOUSDT","DGBUSDT","GBPUSDT","SXPUSDT","MKRUSDT","DAIUSDT","DCRUSDT","STORJUSDT","BNBUPUSDT","BNBDOWNUSDT","XTZUPUSDT","XTZDOWNUSDT","USDTBKRW","MANAUSDT","AUDUSDT","YFIUSDT","BALUSDT","BLZUSDT","IRISUSDT","KMDUSDT","USDTDAI","JSTUSDT","SRMUSDT","ANTUSDT","CRVUSDT","SANDUSDT","OCEANUSDT","NMRUSDT","DOTUSDT","LUNAUSDT","RSRUSDT","PAXGUSDT","WNXMUSDT","TRBUSDT","BZRXUSDT","SUSHIUSDT","YFIIUSDT","KSMUSDT","EGLDUSDT","DIAUSDT","RUNEUSDT","FIOUSDT","UMAUSDT","EOSUPUSDT","EOSDOWNUSDT","TRXUPUSDT","TRXDOWNUSDT","XRPUPUSDT","XRPDOWNUSDT","DOTUPUSDT","DOTDOWNUSDT","USDTNGN","BELUSDT","WINGUSDT","LTCUPUSDT","LTCDOWNUSDT","UNIUSDT","NBSUSDT","OXTUSDT","SUNUSDT","AVAXUSDT","HNTUSDT","FLMUSDT","UNIUPUSDT","UNIDOWNUSDT","ORNUSDT","UTKUSDT","XVSUSDT","ALPHAUSDT","USDTBRL","AAVEUSDT","NEARUSDT","SXPUPUSDT","SXPDOWNUSDT","FILUSDT","FILUPUSDT","FILDOWNUSDT","YFIUPUSDT","YFIDOWNUSDT","INJUSDT","AUDIOUSDT","CTKUSDT","BCHUPUSDT","BCHDOWNUSDT","AKROUSDT","AXSUSDT","HARDUSDT","DNTUSDT","STRAXUSDT","UNFIUSDT","ROSEUSDT","AVAUSDT","XEMUSDT","AAVEUPUSDT","AAVEDOWNUSDT","SKLUSDT","SUSDUSDT","SUSHIUPUSDT","SUSHIDOWNUSDT","XLMUPUSDT","XLMDOWNUSDT","GRTUSDT","JUVUSDT","PSGUSDT","USDTBVND","1INCHUSDT","REEFUSDT","OGUSDT","ATMUSDT","ASRUSDT","CELOUSDT","RIFUSDT","BTCSTUSDT","TRUUSDT" };


        string[] btcTurkSymbol = { "BTCTRY", "ETHTRY",  "XRPTRY",  "LTCTRY",  "USDTTRY",  "BTCUSDT",  "ETHUSDT",  "XRPUSDT",  "LTCUSDT",  "XLMTRY",  "XLMUSDT",  "NEOTRY",  "NEOUSDT",  "EOSTRY",  "EOSUSDT", "DASHTRY",  "DASHUSDT",  "LINKTRY",  "LINKUSDT", "ATOMTRY",  "ATOMUSDT",  "XTZTRY",  "XTZUSDT", "TRXTRY", "TRXUSDT", "ADATRY", "ADAUSDT",  "DOTTRY", "DOTUSDT",  "USDCTRY",  "USDCUSDT" };

                      

        public Form1()
        {
            InitializeComponent();
        }

        private void Form1_Load(object sender, EventArgs e)
        {
            comboBox1.Items.AddRange(banks);
            comboBox1.SelectedIndex = 0;
            comboBox2.SelectedIndex = 0;
            
            /*foreach(string bb in btcTurkSymbol)
            {
                if (bb.Contains("USDT")) Console.WriteLine("\""+ bb+"\","); 
            }*/
        }

        private void textBox1_TextChanged(object sender, EventArgs e)
        {
            try
            {
                val_1 = Convert.ToDouble(textBox1.Text);
            }
            catch (Exception error)
            {
                Console.WriteLine(error.Message);
            }
            manuelCalculate();
        }

        private void textBox2_TextChanged(object sender, EventArgs e)
        {
            try
            {
                val_2 = Convert.ToDouble(textBox2.Text);
            }
            catch (Exception error)
            {
                Console.WriteLine(error.Message);
            }
            manuelCalculate();
        }

        private void numericUpDown1_ValueChanged(object sender, EventArgs e)
        {
            timer1.Interval = (int)numericUpDown1.Value;
        }

        private void numericUpDown1_KeyPress(object sender, KeyPressEventArgs e)
        {
            timer1.Interval = (int)numericUpDown1.Value;
        }

        private void textBox3_TextChanged(object sender, EventArgs e)
        {
            try
            {
                val_3 = Convert.ToDouble(textBox3.Text);
            }
            catch (Exception error)
            {
                Console.WriteLine(error.Message);
            }
            manuelCalculate();
        }

        private void textBox12_TextChanged(object sender, EventArgs e)
        {
            try
            {
                val_7 = Convert.ToDouble(textBox12.Text);
            }
            catch (Exception error)
            {
                Console.WriteLine(error.Message);
            }
            instantCalculate();
        }

        private void textBox10_TextChanged(object sender, EventArgs e)
        {
            try
            {
                val_9 = Convert.ToDouble(textBox10.Text);
            }
            catch (Exception error)
            {
                Console.WriteLine(error.Message);
            }
            instantCalculate();
        }

        private void comboBox1_SelectedIndexChanged(object sender, EventArgs e)
        {
            switch (comboBox1.SelectedIndex)
            {
                case 0:
                    bankCount = 0;
                    comboBox2.Items.Clear();
                    comboBox2.Items.AddRange(binanceSymbol);
                    comboBox2.SelectedIndex = 0;
                    break;
                case 1:
                    bankCount = 1;
                    comboBox2.Items.Clear();
                    comboBox2.Items.AddRange(btcTurkSymbol);
                    comboBox2.SelectedIndex = 0;
                    break;
            }
        }

        private void comboBox2_SelectedIndexChanged(object sender, EventArgs e)
        {
            symbolCount = comboBox2.SelectedIndex;
        }

        private void timer1_Tick(object sender, EventArgs e)
        {
            switch (bankCount)
            {
                case 0:
                    getBinance();
                    break;
                case 1:
                    getBtcTurk();
                    break;
            }            
        }

        private void getBinance()
        {
            try
            {
                using (var webClient = new WebClient())
                {
                    string url = "https://www.binance.com/api/v3/ticker/price?symbol=" + binanceSymbol[symbolCount];
                    string rawJson = webClient.DownloadString(url);
                    JObject json = JObject.Parse(rawJson);
                    val_8 = Convert.ToDouble(json["price"]);
                    textBox11.Text = val_8.ToString();
                }
            }
            catch (Exception error)
            {
                Console.WriteLine(error.Message);
            }
            instantCalculate();
        }

        private void getBtcTurk()
        {
            try
            {
                using (var webClient = new WebClient())
                {
                    string url = "https://api.btcturk.com/api/v2/ticker?pairSymbol=" + btcTurkSymbol[symbolCount];
                    string rawJson = webClient.DownloadString(url);
                    JObject json = JObject.Parse(rawJson);
                    val_8 = Convert.ToDouble(json["data"][0]["last"]);
                    textBox11.Text = val_8.ToString();
                }
            }
            catch (Exception e)
            {
                Console.WriteLine("WebClient" + e);
            }
            instantCalculate();
        }

        // Para birimini ayarlat
        private void manuelCalculate()
        {
            try
            {
                val_4 = ((val_2 - val_1) / val_1) * 100;
                val_5 = val_3 + ((val_3 * val_4) / 100);
                val_6 = val_5 - val_3;

                textBox4.Text = "%" + Math.Round(val_4, 2).ToString();
                textBox5.Text = Math.Round(val_5, 2).ToString();
                textBox6.Text = Math.Round(val_6, 2).ToString();
            }
            catch (Exception)
            {

                throw;
            }
        }

        private void instantCalculate()
        {
            try
            {
                val_10 = ((val_8 - val_7) / val_7) * 100;
                val_11 = val_9 + ((val_9 * val_10) / 100);
                val_12 = val_11 - val_9;

                textBox9.Text = "%" + Math.Round(val_10, 2).ToString();
                textBox8.Text = Math.Round(val_11, 2).ToString();
                textBox7.Text = Math.Round(val_12, 2).ToString();
            }
            catch (Exception)
            {

                throw;
            }
        }
    }
}
