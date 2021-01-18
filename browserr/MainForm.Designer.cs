namespace browserr
{
    partial class MainForm
    {
        /// <summary>
        /// Обязательная переменная конструктора.
        /// </summary>
        private System.ComponentModel.IContainer components = null;

        /// <summary>
        /// Освободить все используемые ресурсы.
        /// </summary>
        /// <param name="disposing">истинно, если управляемый ресурс должен быть удален; иначе ложно.</param>
        protected override void Dispose(bool disposing)
        {
            if (disposing && (components != null))
            {
                components.Dispose();
            }
            base.Dispose(disposing);
        }

        #region Код, автоматически созданный конструктором форм Windows

        /// <summary>
        /// Требуемый метод для поддержки конструктора — не изменяйте 
        /// содержимое этого метода с помощью редактора кода.
        /// </summary>
        private void InitializeComponent()
        {
            this.panel2 = new System.Windows.Forms.Panel();
            this.plusButton = new System.Windows.Forms.Button();
            this.removeButton = new System.Windows.Forms.Button();
            this.SiteTextBox = new System.Windows.Forms.TextBox();
            this.enterBbutton = new System.Windows.Forms.Button();
            this.searchTextBox = new System.Windows.Forms.TextBox();
            this.searchButton = new System.Windows.Forms.Button();
            this.starButton = new System.Windows.Forms.Button();
            this.historyButton = new System.Windows.Forms.Button();
            this.button16 = new System.Windows.Forms.Button();
            this.homeUrlbutton = new System.Windows.Forms.Button();
            this.settingListBox = new System.Windows.Forms.Button();
            this.NextButton = new System.Windows.Forms.Button();
            this.Backbutton = new System.Windows.Forms.Button();
            this.panel1 = new System.Windows.Forms.Panel();
            this.starsPanel = new System.Windows.Forms.Panel();
            this.panel4 = new System.Windows.Forms.Panel();
            this.starsListBox = new System.Windows.Forms.ListBox();
            this.panel3 = new System.Windows.Forms.Panel();
            this.label3 = new System.Windows.Forms.Label();
            this.label2 = new System.Windows.Forms.Label();
            this.label1 = new System.Windows.Forms.Label();
            this.tabControl = new System.Windows.Forms.TabControl();
            this.tabPage1 = new System.Windows.Forms.TabPage();
            this.webBrowser = new System.Windows.Forms.WebBrowser();
            this.panel2.SuspendLayout();
            this.panel1.SuspendLayout();
            this.starsPanel.SuspendLayout();
            this.panel4.SuspendLayout();
            this.panel3.SuspendLayout();
            this.tabControl.SuspendLayout();
            this.tabPage1.SuspendLayout();
            this.SuspendLayout();
            // 
            // panel2
            // 
            this.panel2.Controls.Add(this.plusButton);
            this.panel2.Controls.Add(this.removeButton);
            this.panel2.Controls.Add(this.SiteTextBox);
            this.panel2.Controls.Add(this.enterBbutton);
            this.panel2.Controls.Add(this.searchTextBox);
            this.panel2.Controls.Add(this.searchButton);
            this.panel2.Controls.Add(this.starButton);
            this.panel2.Controls.Add(this.historyButton);
            this.panel2.Controls.Add(this.button16);
            this.panel2.Controls.Add(this.homeUrlbutton);
            this.panel2.Controls.Add(this.settingListBox);
            this.panel2.Controls.Add(this.NextButton);
            this.panel2.Controls.Add(this.Backbutton);
            this.panel2.Dock = System.Windows.Forms.DockStyle.Top;
            this.panel2.Location = new System.Drawing.Point(0, 0);
            this.panel2.Name = "panel2";
            this.panel2.Size = new System.Drawing.Size(882, 33);
            this.panel2.TabIndex = 10;
            // 
            // plusButton
            // 
            this.plusButton.Dock = System.Windows.Forms.DockStyle.Right;
            this.plusButton.Location = new System.Drawing.Point(363, 0);
            this.plusButton.Margin = new System.Windows.Forms.Padding(4);
            this.plusButton.Name = "plusButton";
            this.plusButton.Size = new System.Drawing.Size(42, 33);
            this.plusButton.TabIndex = 32;
            this.plusButton.Text = "➕";
            this.plusButton.UseVisualStyleBackColor = true;
            this.plusButton.Click += new System.EventHandler(this.plusButton_Click);
            // 
            // removeButton
            // 
            this.removeButton.Dock = System.Windows.Forms.DockStyle.Right;
            this.removeButton.Location = new System.Drawing.Point(405, 0);
            this.removeButton.Margin = new System.Windows.Forms.Padding(4);
            this.removeButton.Name = "removeButton";
            this.removeButton.Size = new System.Drawing.Size(42, 33);
            this.removeButton.TabIndex = 31;
            this.removeButton.Text = "➖";
            this.removeButton.UseVisualStyleBackColor = true;
            this.removeButton.Click += new System.EventHandler(this.removeButton_Click);
            // 
            // SiteTextBox
            // 
            this.SiteTextBox.Dock = System.Windows.Forms.DockStyle.Fill;
            this.SiteTextBox.Location = new System.Drawing.Point(90, 0);
            this.SiteTextBox.Multiline = true;
            this.SiteTextBox.Name = "SiteTextBox";
            this.SiteTextBox.Size = new System.Drawing.Size(357, 33);
            this.SiteTextBox.TabIndex = 30;
            // 
            // enterBbutton
            // 
            this.enterBbutton.Dock = System.Windows.Forms.DockStyle.Right;
            this.enterBbutton.Location = new System.Drawing.Point(447, 0);
            this.enterBbutton.Margin = new System.Windows.Forms.Padding(4);
            this.enterBbutton.Name = "enterBbutton";
            this.enterBbutton.Size = new System.Drawing.Size(42, 33);
            this.enterBbutton.TabIndex = 29;
            this.enterBbutton.Text = "⏳";
            this.enterBbutton.UseVisualStyleBackColor = true;
            this.enterBbutton.Click += new System.EventHandler(this.enterBbutton_Click);
            // 
            // searchTextBox
            // 
            this.searchTextBox.Dock = System.Windows.Forms.DockStyle.Right;
            this.searchTextBox.Font = new System.Drawing.Font("Microsoft Sans Serif", 14F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(204)));
            this.searchTextBox.Location = new System.Drawing.Point(489, 0);
            this.searchTextBox.Margin = new System.Windows.Forms.Padding(4);
            this.searchTextBox.Name = "searchTextBox";
            this.searchTextBox.Size = new System.Drawing.Size(123, 34);
            this.searchTextBox.TabIndex = 28;
            // 
            // searchButton
            // 
            this.searchButton.Dock = System.Windows.Forms.DockStyle.Right;
            this.searchButton.Location = new System.Drawing.Point(612, 0);
            this.searchButton.Margin = new System.Windows.Forms.Padding(4);
            this.searchButton.Name = "searchButton";
            this.searchButton.Size = new System.Drawing.Size(45, 33);
            this.searchButton.TabIndex = 27;
            this.searchButton.Text = "🔎";
            this.searchButton.UseVisualStyleBackColor = true;
            this.searchButton.Click += new System.EventHandler(this.searchButton_Click);
            // 
            // starButton
            // 
            this.starButton.Dock = System.Windows.Forms.DockStyle.Right;
            this.starButton.Font = new System.Drawing.Font("Microsoft Sans Serif", 14F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(204)));
            this.starButton.Location = new System.Drawing.Point(657, 0);
            this.starButton.Margin = new System.Windows.Forms.Padding(4);
            this.starButton.Name = "starButton";
            this.starButton.Size = new System.Drawing.Size(45, 33);
            this.starButton.TabIndex = 22;
            this.starButton.Text = "⭐";
            this.starButton.UseVisualStyleBackColor = true;
            this.starButton.Click += new System.EventHandler(this.starButton_Click);
            // 
            // historyButton
            // 
            this.historyButton.Dock = System.Windows.Forms.DockStyle.Right;
            this.historyButton.Font = new System.Drawing.Font("Microsoft Sans Serif", 12F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(204)));
            this.historyButton.Location = new System.Drawing.Point(702, 0);
            this.historyButton.Margin = new System.Windows.Forms.Padding(4);
            this.historyButton.Name = "historyButton";
            this.historyButton.Size = new System.Drawing.Size(45, 33);
            this.historyButton.TabIndex = 20;
            this.historyButton.Text = "🗺";
            this.historyButton.UseVisualStyleBackColor = true;
            this.historyButton.Click += new System.EventHandler(this.historyButton_Click);
            // 
            // button16
            // 
            this.button16.Dock = System.Windows.Forms.DockStyle.Right;
            this.button16.Font = new System.Drawing.Font("Microsoft Sans Serif", 14F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(204)));
            this.button16.Location = new System.Drawing.Point(747, 0);
            this.button16.Margin = new System.Windows.Forms.Padding(4);
            this.button16.Name = "button16";
            this.button16.Size = new System.Drawing.Size(45, 33);
            this.button16.TabIndex = 17;
            this.button16.Text = "📃";
            this.button16.UseVisualStyleBackColor = true;
            this.button16.Click += new System.EventHandler(this.button16_Click);
            // 
            // homeUrlbutton
            // 
            this.homeUrlbutton.Dock = System.Windows.Forms.DockStyle.Right;
            this.homeUrlbutton.Location = new System.Drawing.Point(792, 0);
            this.homeUrlbutton.Margin = new System.Windows.Forms.Padding(4);
            this.homeUrlbutton.Name = "homeUrlbutton";
            this.homeUrlbutton.Size = new System.Drawing.Size(45, 33);
            this.homeUrlbutton.TabIndex = 11;
            this.homeUrlbutton.Text = "🏠";
            this.homeUrlbutton.UseVisualStyleBackColor = true;
            this.homeUrlbutton.Click += new System.EventHandler(this.homeUrlbutton_Click);
            // 
            // settingListBox
            // 
            this.settingListBox.Dock = System.Windows.Forms.DockStyle.Right;
            this.settingListBox.Font = new System.Drawing.Font("Microsoft Sans Serif", 12F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(204)));
            this.settingListBox.Location = new System.Drawing.Point(837, 0);
            this.settingListBox.Margin = new System.Windows.Forms.Padding(4);
            this.settingListBox.Name = "settingListBox";
            this.settingListBox.Size = new System.Drawing.Size(45, 33);
            this.settingListBox.TabIndex = 10;
            this.settingListBox.Text = "⚙";
            this.settingListBox.UseVisualStyleBackColor = true;
            this.settingListBox.Click += new System.EventHandler(this.settingListBox_Click);
            // 
            // NextButton
            // 
            this.NextButton.Dock = System.Windows.Forms.DockStyle.Left;
            this.NextButton.Location = new System.Drawing.Point(45, 0);
            this.NextButton.Margin = new System.Windows.Forms.Padding(4);
            this.NextButton.Name = "NextButton";
            this.NextButton.Size = new System.Drawing.Size(45, 33);
            this.NextButton.TabIndex = 7;
            this.NextButton.Text = "->";
            this.NextButton.UseVisualStyleBackColor = true;
            this.NextButton.Click += new System.EventHandler(this.NextButton_Click);
            // 
            // Backbutton
            // 
            this.Backbutton.Dock = System.Windows.Forms.DockStyle.Left;
            this.Backbutton.Location = new System.Drawing.Point(0, 0);
            this.Backbutton.Margin = new System.Windows.Forms.Padding(4);
            this.Backbutton.Name = "Backbutton";
            this.Backbutton.Size = new System.Drawing.Size(45, 33);
            this.Backbutton.TabIndex = 6;
            this.Backbutton.Text = "<-";
            this.Backbutton.UseVisualStyleBackColor = true;
            this.Backbutton.Click += new System.EventHandler(this.Backbutton_Click);
            // 
            // panel1
            // 
            this.panel1.Controls.Add(this.starsPanel);
            this.panel1.Controls.Add(this.tabControl);
            this.panel1.Controls.Add(this.panel2);
            this.panel1.Dock = System.Windows.Forms.DockStyle.Fill;
            this.panel1.Location = new System.Drawing.Point(0, 0);
            this.panel1.Name = "panel1";
            this.panel1.Size = new System.Drawing.Size(882, 601);
            this.panel1.TabIndex = 0;
            // 
            // starsPanel
            // 
            this.starsPanel.Controls.Add(this.panel4);
            this.starsPanel.Controls.Add(this.panel3);
            this.starsPanel.Dock = System.Windows.Forms.DockStyle.Right;
            this.starsPanel.Location = new System.Drawing.Point(630, 33);
            this.starsPanel.Name = "starsPanel";
            this.starsPanel.Size = new System.Drawing.Size(252, 568);
            this.starsPanel.TabIndex = 13;
            // 
            // panel4
            // 
            this.panel4.Controls.Add(this.starsListBox);
            this.panel4.Dock = System.Windows.Forms.DockStyle.Fill;
            this.panel4.Location = new System.Drawing.Point(0, 94);
            this.panel4.Name = "panel4";
            this.panel4.Size = new System.Drawing.Size(252, 474);
            this.panel4.TabIndex = 4;
            // 
            // starsListBox
            // 
            this.starsListBox.Dock = System.Windows.Forms.DockStyle.Fill;
            this.starsListBox.FormattingEnabled = true;
            this.starsListBox.ItemHeight = 16;
            this.starsListBox.Location = new System.Drawing.Point(0, 0);
            this.starsListBox.Name = "starsListBox";
            this.starsListBox.Size = new System.Drawing.Size(252, 474);
            this.starsListBox.TabIndex = 2;
            this.starsListBox.MouseClick += new System.Windows.Forms.MouseEventHandler(this.starsListBox_MouseClick);
            this.starsListBox.MouseDoubleClick += new System.Windows.Forms.MouseEventHandler(this.starsListBox_MouseDoubleClick);
            // 
            // panel3
            // 
            this.panel3.Controls.Add(this.label3);
            this.panel3.Controls.Add(this.label2);
            this.panel3.Controls.Add(this.label1);
            this.panel3.Dock = System.Windows.Forms.DockStyle.Top;
            this.panel3.Location = new System.Drawing.Point(0, 0);
            this.panel3.Name = "panel3";
            this.panel3.Size = new System.Drawing.Size(252, 94);
            this.panel3.TabIndex = 3;
            // 
            // label3
            // 
            this.label3.Anchor = ((System.Windows.Forms.AnchorStyles)((System.Windows.Forms.AnchorStyles.Bottom | System.Windows.Forms.AnchorStyles.Right)));
            this.label3.AutoSize = true;
            this.label3.Font = new System.Drawing.Font("Microsoft Sans Serif", 12F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(204)));
            this.label3.Location = new System.Drawing.Point(141, 55);
            this.label3.Name = "label3";
            this.label3.Size = new System.Drawing.Size(104, 25);
            this.label3.TabIndex = 3;
            this.label3.Text = "🗑 - 2 click";
            // 
            // label2
            // 
            this.label2.Anchor = ((System.Windows.Forms.AnchorStyles)((System.Windows.Forms.AnchorStyles.Bottom | System.Windows.Forms.AnchorStyles.Right)));
            this.label2.AutoSize = true;
            this.label2.Font = new System.Drawing.Font("Microsoft Sans Serif", 12F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(204)));
            this.label2.Location = new System.Drawing.Point(3, 55);
            this.label2.Name = "label2";
            this.label2.Size = new System.Drawing.Size(104, 25);
            this.label2.TabIndex = 2;
            this.label2.Text = "🎯 - 1 click";
            // 
            // label1
            // 
            this.label1.Anchor = ((System.Windows.Forms.AnchorStyles)((System.Windows.Forms.AnchorStyles.Bottom | System.Windows.Forms.AnchorStyles.Right)));
            this.label1.AutoSize = true;
            this.label1.Font = new System.Drawing.Font("Microsoft Sans Serif", 18F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(204)));
            this.label1.Location = new System.Drawing.Point(57, 4);
            this.label1.Name = "label1";
            this.label1.Size = new System.Drawing.Size(138, 36);
            this.label1.TabIndex = 1;
            this.label1.Text = "Stars site";
            // 
            // tabControl
            // 
            this.tabControl.Controls.Add(this.tabPage1);
            this.tabControl.Dock = System.Windows.Forms.DockStyle.Fill;
            this.tabControl.Location = new System.Drawing.Point(0, 33);
            this.tabControl.Name = "tabControl";
            this.tabControl.SelectedIndex = 0;
            this.tabControl.Size = new System.Drawing.Size(882, 568);
            this.tabControl.TabIndex = 12;
            // 
            // tabPage1
            // 
            this.tabPage1.Controls.Add(this.webBrowser);
            this.tabPage1.Location = new System.Drawing.Point(4, 25);
            this.tabPage1.Name = "tabPage1";
            this.tabPage1.Padding = new System.Windows.Forms.Padding(3);
            this.tabPage1.Size = new System.Drawing.Size(874, 539);
            this.tabPage1.TabIndex = 0;
            this.tabPage1.Text = "tabPage1";
            this.tabPage1.UseVisualStyleBackColor = true;
            // 
            // webBrowser
            // 
            this.webBrowser.Dock = System.Windows.Forms.DockStyle.Fill;
            this.webBrowser.Location = new System.Drawing.Point(3, 3);
            this.webBrowser.MinimumSize = new System.Drawing.Size(20, 20);
            this.webBrowser.Name = "webBrowser";
            this.webBrowser.Size = new System.Drawing.Size(868, 533);
            this.webBrowser.TabIndex = 0;
            this.webBrowser.Navigated += new System.Windows.Forms.WebBrowserNavigatedEventHandler(this.webBrowser1_Navigated);
            // 
            // MainForm
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(8F, 16F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.ClientSize = new System.Drawing.Size(882, 601);
            this.Controls.Add(this.panel1);
            this.Name = "MainForm";
            this.Text = "Form1";
            this.panel2.ResumeLayout(false);
            this.panel2.PerformLayout();
            this.panel1.ResumeLayout(false);
            this.starsPanel.ResumeLayout(false);
            this.panel4.ResumeLayout(false);
            this.panel3.ResumeLayout(false);
            this.panel3.PerformLayout();
            this.tabControl.ResumeLayout(false);
            this.tabPage1.ResumeLayout(false);
            this.ResumeLayout(false);

        }

        #endregion

        private System.Windows.Forms.Panel panel2;
        private System.Windows.Forms.Button starButton;
        private System.Windows.Forms.Button historyButton;
        private System.Windows.Forms.Button button16;
        private System.Windows.Forms.Button homeUrlbutton;
        private System.Windows.Forms.Button NextButton;
        private System.Windows.Forms.Button Backbutton;
        private System.Windows.Forms.Panel panel1;
        private System.Windows.Forms.Button settingListBox;
        private System.Windows.Forms.Panel starsPanel;
        private System.Windows.Forms.TabControl tabControl;
        private System.Windows.Forms.Button enterBbutton;
        private System.Windows.Forms.TextBox searchTextBox;
        private System.Windows.Forms.Button searchButton;
        private System.Windows.Forms.TextBox SiteTextBox;
        private System.Windows.Forms.Label label1;
        private System.Windows.Forms.Button removeButton;
        private System.Windows.Forms.Button plusButton;
        private System.Windows.Forms.ListBox starsListBox;
        private System.Windows.Forms.TabPage tabPage1;
        private System.Windows.Forms.WebBrowser webBrowser;
        private System.Windows.Forms.Panel panel3;
        private System.Windows.Forms.Panel panel4;
        private System.Windows.Forms.Label label3;
        private System.Windows.Forms.Label label2;
    }
}

