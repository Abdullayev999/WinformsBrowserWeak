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
    public partial class HistoryForm : Form
    {
        public List<string> HistoryList { get; set; }
        public HistoryForm(List<string> histroyList)
        {
            
            InitializeComponent();
            HistoryList =histroyList;
            historyListBox.Items.AddRange(histroyList.ToArray());

        }

        private void removeButton_Click(object sender, EventArgs e)
        {
            int index = historyListBox.SelectedIndex;

            if (historyListBox.Items[index]!=null)
            {
                historyListBox.Items.RemoveAt(index);
                HistoryList.RemoveAt(index);
            }
        }

        private void closeButton_Click(object sender, EventArgs e)
        {
            Close();
        }

        private void removeAllButton_Click(object sender, EventArgs e)
        {
            HistoryList.Clear();
            historyListBox.Items.Clear();
        }
    }
}
