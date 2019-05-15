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
using System.Xml.XPath;
using HtmlAgilityPack;

namespace Pobieranie
{
    public partial class Form1 : Form
    {
        public Form1()
        {
            InitializeComponent();
        }

        private void Form1_Load(object sender, EventArgs e)
        {

        }

        //private void ProgressChanged(object sender, DownloadProgressChangedEventArgs e)
        //{
        //    progressBar.Value = e.ProgressPercentage;
        //}
        //private void click_Click(object sender, EventArgs e)
        //{
        //    WebClient webClient = new WebClient();
        //    webClient.DownloadFileCompleted += new AsyncCompletedEventHandler(DownloadCompleted);
        //    webClient.DownloadProgressChanged += new DownloadProgressChangedEventHandler(ProgressChanged);

        //    string sourceFile = $"http://openload.co/stream/Ki5y8-mPcoE~1558022792~95.108.0.0~mdmeUiAb?";
        //    webClient.DownloadFileAsync(new Uri(sourceFile), "test.mp4");
        //}
        //private void DownloadCompleted(object sender, AsyncCompletedEventArgs e)
        //{
        //    MessageBox.Show("The download is completed!");
        //}

        private void button1_Click(object sender, EventArgs e)
        {
            using (var client = new WebClient())
            {
                string page = adres.Text;
                string html = client.DownloadString(page);

                HtmlAgilityPack.HtmlDocument doc = new HtmlAgilityPack.HtmlDocument();
                doc.LoadHtml(html);

                

                HtmlNodeNavigator navigator = (HtmlNodeNavigator)doc.CreateNavigator();
                string xPath = "//*[@id=\"olvideo_html5_api\"]";

                string val = navigator.SelectSingleNode(xPath).Value;
                adres.Text = val;
            }
        }
    }
}
