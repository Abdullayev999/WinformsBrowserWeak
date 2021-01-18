using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.IO;
using System.Linq;
using System.Security.Policy;
using System.Text;
using System.Threading;
using System.Threading.Tasks;
using System.Windows.Forms;
using Newtonsoft.Json;

namespace browserr
{
    public partial class MainForm : Form
    {
        public List<WebBrowser> WebBrowser { get; set; }
        public List<string> HistoryList { get; set; }
       
        public List<string> StarsList { get; set; }
        private int Count { get; set; } 
        List<string> AddSetting { get; set; }
        public string NameNewTab { get; set; } = "New Tab ";

        private const int HomeUrl = 0;

        private const int DefaultSearch = 1;
        public MainForm()
        {
            InitializeComponent();
            AddSetting=new List<string>();
            WebBrowser = new List<WebBrowser>();
            HistoryList = new List<string>();
            StarsList = new List<string>();
            starsPanel.Visible = false;
            tabPage1.Text = NameNewTab;
            WebBrowser.Add(webBrowser);

            try
            {
                HistoryList = JsonConvert.DeserializeObject<List<string>>(File.ReadAllText("HistoryList.json"));
            }
            catch (Exception e){}

            try
            {
                StarsList = JsonConvert.DeserializeObject<List<string>>(File.ReadAllText("Stars.json"));
            }
            catch (Exception e){}

            try
            {
                AddSetting = JsonConvert.DeserializeObject<List<string>>(File.ReadAllText("AddSetting.json"));
            }
            catch (Exception e)
            {
                AddSetting.Add("https://www.google.com/");
                AddSetting.Add("https://www.google.com/search?q=");
            }

            SiteTextBox.Text = AddSetting[HomeUrl];
            webBrowser.Url = new Uri(AddSetting[HomeUrl]);

        }

        protected override void OnClosing(CancelEventArgs e)
        {
            try
            {
                File.WriteAllText("HistoryList.json", JsonConvert.SerializeObject(HistoryList));
            }
            catch (Exception exception) { }

            try
            {
                File.WriteAllText("Stars.json", JsonConvert.SerializeObject(StarsList));
            }
            catch (Exception exception) { }

            try
            {

                File.WriteAllText("AddSetting.json", JsonConvert.SerializeObject(AddSetting));
            }
            catch (Exception exception) { }
            base.OnClosing(e);
        }

        private void button16_Click(object sender, EventArgs e)
        {
            starsPanel.Visible = !starsPanel.Visible;
            if (starsPanel.Visible)
            {
                starsListBox.Show();
            }
        }

        private void webBrowser1_Navigated(object sender, WebBrowserNavigatedEventArgs e)
        {
            HistoryList.Add(e.Url.AbsoluteUri);
            SiteTextBox.Text = HistoryList.Last();
        }

        private void starButton_Click(object sender, EventArgs e)
        {
            int index = tabControl.SelectedIndex;
            StarsList.Add(WebBrowser[index].Url.ToString());
            starsListBox.Items.Add(WebBrowser[index].Url.ToString());
        }

        private void historyButton_Click(object sender, EventArgs e)
        {
            var history = new HistoryForm(HistoryList);
            history.ShowDialog();
        }

        private void searchButton_Click(object sender, EventArgs e)
        {
            

            if (tabControl.TabPages.Count!=0)
            {
                int index = tabControl.SelectedIndex;
                StringBuilder tmp = new StringBuilder();
                tmp.Append(AddSetting[DefaultSearch]);
                tmp.Append(searchTextBox.Text);

                WebBrowser[index].Url = new Uri(tmp.ToString());
                HistoryList.Add(tmp.ToString());
            }
            else
            {
                plusButton_Click(sender, e);
            }

        }

        private void enterBbutton_Click(object sender, EventArgs e)
        {
            if (SiteTextBox.Text != null)
            {
                if (tabControl.TabPages.Count!=0)
                {
                    StringBuilder tmp = new StringBuilder();
                    if (!SiteTextBox.ToString().StartsWith("http://"))
                    {
                        tmp.Append("http://");
                        tmp.Append(SiteTextBox.Text);
                    }

                    int index = tabControl.SelectedIndex;
                    WebBrowser[index].Url = new Uri(tmp.ToString());
                    HistoryList.Add(tmp.ToString());
                }
                else
                {
                    plusButton_Click(sender,e);
                }
            }
        }

        private void removeButton_Click(object sender, EventArgs e)
        {
            if (tabControl.TabPages.Count > 0)
            {
                int index = tabControl.SelectedIndex;
                tabControl.TabPages.RemoveAt(index);
            }
        }

        private void plusButton_Click(object sender, EventArgs e)
        {
            TabPage tmpPage = new TabPage(NameNewTab + Count);
            WebBrowser webTmp = new WebBrowser();
            webTmp.Dock = DockStyle.Fill;
            webTmp.Name = NameNewTab + Count++;
            webTmp.Url = new Uri(AddSetting[HomeUrl]);
            WebBrowser.Add(webTmp);
            tmpPage.Controls.Add(webTmp);
            tabControl.Controls.Add(tmpPage);
        }

        private void starsListBox_MouseClick(object sender, MouseEventArgs e)
        {
            int indexStars = starsListBox.SelectedIndex;
            if (starsListBox.Items.Count>0&&indexStars>=0)
            {
                int index = tabControl.SelectedIndex;
                WebBrowser[index].Url = new Uri(starsListBox.Items[indexStars].ToString());
            }
        }

        private void starsListBox_MouseDoubleClick(object sender, MouseEventArgs e)
        {
            int indexStars = starsListBox.SelectedIndex;
            if (starsListBox.Items.Count > 0 && indexStars >= 0)
            {
                starsListBox.Items.RemoveAt(indexStars);
                StarsList.RemoveAt(indexStars);
            }
        }

        private void Backbutton_Click(object sender, EventArgs e)
        {
            int index = tabControl.SelectedIndex;
            WebBrowser[index].GoBack();
            
        }

        private void NextButton_Click(object sender, EventArgs e)
        {
            int index = tabControl.SelectedIndex; 
            WebBrowser[index].GoForward();
        }

        private void homeUrlbutton_Click(object sender, EventArgs e)
        {
            int index = tabControl.SelectedIndex;
            WebBrowser[index].Url=new Uri(AddSetting[HomeUrl]);
        }

        private void settingListBox_Click(object sender, EventArgs e)
        {
            var settingForm = new SettingForm(AddSetting);
            settingForm.ShowDialog();
        }
    }
}
