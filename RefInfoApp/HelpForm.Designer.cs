namespace RefInfoApp
{
    partial class HelpForm
    {
        /// <summary>
        /// Required designer variable.
        /// </summary>
        private System.ComponentModel.IContainer components = null;

        /// <summary>
        /// Clean up any resources being used.
        /// </summary>
        /// <param name="disposing">true if managed resources should be disposed; otherwise, false.</param>
        protected override void Dispose(bool disposing)
        {
            if (disposing && (components != null))
            {
                components.Dispose();
            }
            base.Dispose(disposing);
        }

        #region Windows Form Designer generated code

        /// <summary>
        /// Required method for Designer support - do not modify
        /// the contents of this method with the code editor.
        /// </summary>
        private void InitializeComponent()
        {
            this.splitContainer1 = new System.Windows.Forms.SplitContainer();
            this.LabelSearch = new System.Windows.Forms.Label();
            this.RefNameBox = new System.Windows.Forms.ListBox();
            this.RefSearchBox = new System.Windows.Forms.TextBox();
            this.HelpBrowser = new System.Windows.Forms.WebBrowser();
            ((System.ComponentModel.ISupportInitialize)(this.splitContainer1)).BeginInit();
            this.splitContainer1.Panel1.SuspendLayout();
            this.splitContainer1.Panel2.SuspendLayout();
            this.splitContainer1.SuspendLayout();
            this.SuspendLayout();
            // 
            // splitContainer1
            // 
            this.splitContainer1.Dock = System.Windows.Forms.DockStyle.Fill;
            this.splitContainer1.Location = new System.Drawing.Point(0, 0);
            this.splitContainer1.Name = "splitContainer1";
            // 
            // splitContainer1.Panel1
            // 
            this.splitContainer1.Panel1.Controls.Add(this.RefSearchBox);
            this.splitContainer1.Panel1.Controls.Add(this.RefNameBox);
            this.splitContainer1.Panel1.Controls.Add(this.LabelSearch);
            // 
            // splitContainer1.Panel2
            // 
            this.splitContainer1.Panel2.Controls.Add(this.HelpBrowser);
            this.splitContainer1.Size = new System.Drawing.Size(1026, 643);
            this.splitContainer1.SplitterDistance = 342;
            this.splitContainer1.TabIndex = 0;
            // 
            // LabelSearch
            // 
            this.LabelSearch.AutoSize = true;
            this.LabelSearch.Location = new System.Drawing.Point(24, 24);
            this.LabelSearch.Name = "LabelSearch";
            this.LabelSearch.Size = new System.Drawing.Size(42, 13);
            this.LabelSearch.TabIndex = 0;
            this.LabelSearch.Text = "Поиск:";
            // 
            // RefNameBox
            // 
            this.RefNameBox.FormattingEnabled = true;
            this.RefNameBox.Location = new System.Drawing.Point(27, 53);
            this.RefNameBox.Name = "RefNameBox";
            this.RefNameBox.Size = new System.Drawing.Size(278, 563);
            this.RefNameBox.TabIndex = 1;
            this.RefNameBox.SelectedIndexChanged += new System.EventHandler(this.RefNameBox_SelectedIndexChanged);
            // 
            // RefSearchBox
            // 
            this.RefSearchBox.Location = new System.Drawing.Point(72, 21);
            this.RefSearchBox.Name = "RefSearchBox";
            this.RefSearchBox.Size = new System.Drawing.Size(233, 20);
            this.RefSearchBox.TabIndex = 2;
            this.RefSearchBox.TextChanged += new System.EventHandler(this.RefSearchBox_TextChanged);
            // 
            // HelpBrowser
            // 
            this.HelpBrowser.Dock = System.Windows.Forms.DockStyle.Fill;
            this.HelpBrowser.Location = new System.Drawing.Point(0, 0);
            this.HelpBrowser.MinimumSize = new System.Drawing.Size(20, 20);
            this.HelpBrowser.Name = "HelpBrowser";
            this.HelpBrowser.Size = new System.Drawing.Size(680, 643);
            this.HelpBrowser.TabIndex = 0;
            // 
            // HelpForm
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(6F, 13F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.ClientSize = new System.Drawing.Size(1026, 643);
            this.Controls.Add(this.splitContainer1);
            this.Name = "HelpForm";
            this.ShowIcon = false;
            this.Text = "Справка";
            this.splitContainer1.Panel1.ResumeLayout(false);
            this.splitContainer1.Panel1.PerformLayout();
            this.splitContainer1.Panel2.ResumeLayout(false);
            ((System.ComponentModel.ISupportInitialize)(this.splitContainer1)).EndInit();
            this.splitContainer1.ResumeLayout(false);
            this.ResumeLayout(false);

        }

        #endregion

        private System.Windows.Forms.SplitContainer splitContainer1;
        private System.Windows.Forms.TextBox RefSearchBox;
        private System.Windows.Forms.ListBox RefNameBox;
        private System.Windows.Forms.Label LabelSearch;
        private System.Windows.Forms.WebBrowser HelpBrowser;
    }
}