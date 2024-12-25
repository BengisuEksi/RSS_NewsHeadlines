using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Web;
using System.Windows.Forms;
using System.Xml;

namespace HeadlineNews
{
    public partial class Form1 : Form
    {
        public Form1()
        {
            InitializeComponent();
        }
        void bring_news(string link)
        {
            listBox1.Items.Clear();
            XmlTextReader xmlread = new XmlTextReader(link);
            while (xmlread.Read())
            {
                if(xmlread.Name == "title")
                {
                    listBox1.Items.Add(xmlread.ReadString());
                }
            }
        }
        private void milliyet_bttn_Click(object sender, EventArgs e)
        {
            string link = "http://www.milliyet.com.tr/rss/rssNew/gundemRss.xml";
            bring_news(link);
        }

        private void cumhuriyet_bttn_Click(object sender, EventArgs e)
        {
            string link = "http://www.cumhuriyet.com.tr/rss/son_dakika.xml";
            bring_news(link);
        }

        private void haberturk_bttn_Click(object sender, EventArgs e)
        {
            string link = "https://www.haberturk.com/rss";
            bring_news(link);
        }

        private void milliyet_bttn_MouseEnter(object sender, EventArgs e)
        {
            milliyet_bttn.BackColor = Color.SlateBlue;
        }

        private void milliyet_bttn_MouseLeave(object sender, EventArgs e)
        {
            milliyet_bttn.BackColor = Color.Transparent;
        }

        private void haberturk_bttn_MouseEnter(object sender, EventArgs e)
        {
            haberturk_bttn.BackColor = Color.SlateBlue;
        }

        private void haberturk_bttn_MouseLeave(object sender, EventArgs e)
        {
            haberturk_bttn.BackColor = Color.Transparent;
        }

        private void cumhuriyet_bttn_MouseEnter(object sender, EventArgs e)
        {
            cumhuriyet_bttn.BackColor = Color.SlateBlue;
        }

        private void cumhuriyet_bttn_MouseLeave(object sender, EventArgs e)
        {
            cumhuriyet_bttn.BackColor = Color.Transparent;
        }
    }
}
