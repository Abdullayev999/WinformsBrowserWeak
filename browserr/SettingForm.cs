using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;

namespace browserr
{
    public partial class SettingForm : Form
    {
        private const int DefaultSearch = 1;
        private int HomeUrl = 0;

        public List<string> List { get; set; }
        public SettingForm( List<string> tmp)
        {
            InitializeComponent();
            List = tmp;
        }

        private void saveButton_Click(object sender, EventArgs e)
        {
            StringBuilder tmp = new StringBuilder();
            if (searchComboBox.SelectedItem!=null)
            {
                List[DefaultSearch] = searchComboBox.SelectedItem.ToString();
            }

            tmp = new StringBuilder();
            if (homeUrlTextBox.Text!=null)
            {
                if (!homeUrlTextBox.ToString().StartsWith("http://"))
                {
                    tmp.Append("http://");
                    tmp.Append(homeUrlTextBox.Text);
                }
                List[HomeUrl] = tmp.ToString();
            }
            Close();
        }
    }
}
