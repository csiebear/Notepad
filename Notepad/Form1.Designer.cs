namespace Notepad
{
    partial class Form1
    {
        /// <summary>
        /// 設計工具所需的變數。
        /// </summary>
        private System.ComponentModel.IContainer components = null;

        /// <summary>
        /// 清除任何使用中的資源。
        /// </summary>
        /// <param name="disposing">如果應該處置 Managed 資源則為 true，否則為 false。</param>
        protected override void Dispose(bool disposing)
        {
            if (disposing && (components != null))
            {
                components.Dispose();
            }
            base.Dispose(disposing);
        }

        #region Windows Form 設計工具產生的程式碼

        /// <summary>
        /// 此為設計工具支援所需的方法 - 請勿使用程式碼編輯器修改
        /// 這個方法的內容。
        /// </summary>
        private void InitializeComponent()
        {
            System.ComponentModel.ComponentResourceManager resources = new System.ComponentModel.ComponentResourceManager(typeof(Form1));
            this.toolStrip1 = new System.Windows.Forms.ToolStrip();
            this.toolStripDropDownButton1 = new System.Windows.Forms.ToolStripDropDownButton();
            this.ToolStripMenuItem_11 = new System.Windows.Forms.ToolStripMenuItem();
            this.ToolStripMenuItem_12 = new System.Windows.Forms.ToolStripMenuItem();
            this.ToolStripMenuItem_13 = new System.Windows.Forms.ToolStripMenuItem();
            this.ToolStripMenuItem_14 = new System.Windows.Forms.ToolStripMenuItem();
            this.toolStripSeparator1 = new System.Windows.Forms.ToolStripSeparator();
            this.ToolStripMenuItem_15 = new System.Windows.Forms.ToolStripMenuItem();
            this.toolStripMenuItem_16 = new System.Windows.Forms.ToolStripMenuItem();
            this.ToolStripMenuItem_17 = new System.Windows.Forms.ToolStripMenuItem();
            this.toolStripSeparator2 = new System.Windows.Forms.ToolStripSeparator();
            this.ToolStripMenuItem_18 = new System.Windows.Forms.ToolStripMenuItem();
            this.toolStripDropDownButton2 = new System.Windows.Forms.ToolStripDropDownButton();
            this.TSMI_201_Recover = new System.Windows.Forms.ToolStripMenuItem();
            this.toolStripSeparator3 = new System.Windows.Forms.ToolStripSeparator();
            this.TSMI_202_Cut = new System.Windows.Forms.ToolStripMenuItem();
            this.TSMI_203_Copy = new System.Windows.Forms.ToolStripMenuItem();
            this.TSMI_204_Paste = new System.Windows.Forms.ToolStripMenuItem();
            this.TSMI_205_Delete = new System.Windows.Forms.ToolStripMenuItem();
            this.TSMI_206_Clear = new System.Windows.Forms.ToolStripMenuItem();
            this.toolStripSeparator4 = new System.Windows.Forms.ToolStripSeparator();
            this.TSMI_207_Find = new System.Windows.Forms.ToolStripMenuItem();
            this.TSMI_208_FindNextOne = new System.Windows.Forms.ToolStripMenuItem();
            this.TSMI_209_Replace = new System.Windows.Forms.ToolStripMenuItem();
            this.TSMI_210_Move = new System.Windows.Forms.ToolStripMenuItem();
            this.toolStripSeparator5 = new System.Windows.Forms.ToolStripSeparator();
            this.TSMI_211_SelectAll = new System.Windows.Forms.ToolStripMenuItem();
            this.TSMI212_DateTime = new System.Windows.Forms.ToolStripMenuItem();
            this.toolStripDropDownButton3 = new System.Windows.Forms.ToolStripDropDownButton();
            this.toolStripMenuItem11 = new System.Windows.Forms.ToolStripMenuItem();
            this.toolStripMenuItem12 = new System.Windows.Forms.ToolStripMenuItem();
            this.toolStripDropDownButton4 = new System.Windows.Forms.ToolStripDropDownButton();
            this.狀態列SToolStripMenuItem = new System.Windows.Forms.ToolStripMenuItem();
            this.toolStripDropDownButton5 = new System.Windows.Forms.ToolStripDropDownButton();
            this.toolStripMenuItem13 = new System.Windows.Forms.ToolStripMenuItem();
            this.toolStripSeparator6 = new System.Windows.Forms.ToolStripSeparator();
            this.toolStripMenuItem14 = new System.Windows.Forms.ToolStripMenuItem();
            this.richTextBox1 = new System.Windows.Forms.RichTextBox();
            this.printDialog1 = new System.Windows.Forms.PrintDialog();
            this.printDocument1 = new System.Drawing.Printing.PrintDocument();
            this.printPreviewDialog1 = new System.Windows.Forms.PrintPreviewDialog();
            this.openFileDialog1 = new System.Windows.Forms.OpenFileDialog();
            this.saveFileDialog1 = new System.Windows.Forms.SaveFileDialog();
            this.fontDialog1 = new System.Windows.Forms.FontDialog();
            this.fileSystemWatcher1 = new System.IO.FileSystemWatcher();
            this.pageSetupDialog1 = new System.Windows.Forms.PageSetupDialog();
            this.toolStrip1.SuspendLayout();
            ((System.ComponentModel.ISupportInitialize)(this.fileSystemWatcher1)).BeginInit();
            this.SuspendLayout();
            // 
            // toolStrip1
            // 
            this.toolStrip1.Dock = System.Windows.Forms.DockStyle.None;
            this.toolStrip1.Font = new System.Drawing.Font("微軟正黑體", 11.25F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(136)));
            this.toolStrip1.Items.AddRange(new System.Windows.Forms.ToolStripItem[] {
            this.toolStripDropDownButton1,
            this.toolStripDropDownButton2,
            this.toolStripDropDownButton3,
            this.toolStripDropDownButton4,
            this.toolStripDropDownButton5});
            this.toolStrip1.Location = new System.Drawing.Point(0, -1);
            this.toolStrip1.Name = "toolStrip1";
            this.toolStrip1.Size = new System.Drawing.Size(466, 26);
            this.toolStrip1.TabIndex = 0;
            this.toolStrip1.Text = "toolStrip1";
            this.toolStrip1.ItemClicked += new System.Windows.Forms.ToolStripItemClickedEventHandler(this.toolStrip1_ItemClicked);
            // 
            // toolStripDropDownButton1
            // 
            this.toolStripDropDownButton1.DropDownItems.AddRange(new System.Windows.Forms.ToolStripItem[] {
            this.ToolStripMenuItem_11,
            this.ToolStripMenuItem_12,
            this.ToolStripMenuItem_13,
            this.ToolStripMenuItem_14,
            this.toolStripSeparator1,
            this.ToolStripMenuItem_15,
            this.toolStripMenuItem_16,
            this.ToolStripMenuItem_17,
            this.toolStripSeparator2,
            this.ToolStripMenuItem_18});
            this.toolStripDropDownButton1.Image = ((System.Drawing.Image)(resources.GetObject("toolStripDropDownButton1.Image")));
            this.toolStripDropDownButton1.ImageTransparentColor = System.Drawing.Color.Magenta;
            this.toolStripDropDownButton1.Name = "toolStripDropDownButton1";
            this.toolStripDropDownButton1.Size = new System.Drawing.Size(86, 23);
            this.toolStripDropDownButton1.Text = "檔案(F)";
            this.toolStripDropDownButton1.Click += new System.EventHandler(this.toolStripDropDownButton1_Click);
            // 
            // ToolStripMenuItem_11
            // 
            this.ToolStripMenuItem_11.Name = "ToolStripMenuItem_11";
            this.ToolStripMenuItem_11.ShortcutKeys = ((System.Windows.Forms.Keys)((System.Windows.Forms.Keys.Control | System.Windows.Forms.Keys.N)));
            this.ToolStripMenuItem_11.Size = new System.Drawing.Size(235, 24);
            this.ToolStripMenuItem_11.Text = "開啟新檔(N)";
            this.ToolStripMenuItem_11.Click += new System.EventHandler(this.ToolStripMenuItem_11_Click);
            // 
            // ToolStripMenuItem_12
            // 
            this.ToolStripMenuItem_12.Name = "ToolStripMenuItem_12";
            this.ToolStripMenuItem_12.ShortcutKeys = ((System.Windows.Forms.Keys)((System.Windows.Forms.Keys.Control | System.Windows.Forms.Keys.O)));
            this.ToolStripMenuItem_12.Size = new System.Drawing.Size(235, 24);
            this.ToolStripMenuItem_12.Text = "開啟舊檔(O)";
            this.ToolStripMenuItem_12.Click += new System.EventHandler(this.ToolStripMenuItem_12_Click);
            // 
            // ToolStripMenuItem_13
            // 
            this.ToolStripMenuItem_13.Name = "ToolStripMenuItem_13";
            this.ToolStripMenuItem_13.ShortcutKeys = ((System.Windows.Forms.Keys)((System.Windows.Forms.Keys.Control | System.Windows.Forms.Keys.S)));
            this.ToolStripMenuItem_13.Size = new System.Drawing.Size(235, 24);
            this.ToolStripMenuItem_13.Text = "儲存檔案(S)";
            this.ToolStripMenuItem_13.Click += new System.EventHandler(this.ToolStripMenuItem_13_Click);
            // 
            // ToolStripMenuItem_14
            // 
            this.ToolStripMenuItem_14.Name = "ToolStripMenuItem_14";
            this.ToolStripMenuItem_14.ShortcutKeys = ((System.Windows.Forms.Keys)(((System.Windows.Forms.Keys.Control | System.Windows.Forms.Keys.Shift) 
            | System.Windows.Forms.Keys.S)));
            this.ToolStripMenuItem_14.Size = new System.Drawing.Size(235, 24);
            this.ToolStripMenuItem_14.Text = "另存新檔";
            this.ToolStripMenuItem_14.Click += new System.EventHandler(this.ToolStripMenuItem_14_Click);
            // 
            // toolStripSeparator1
            // 
            this.toolStripSeparator1.Name = "toolStripSeparator1";
            this.toolStripSeparator1.Size = new System.Drawing.Size(232, 6);
            // 
            // ToolStripMenuItem_15
            // 
            this.ToolStripMenuItem_15.Name = "ToolStripMenuItem_15";
            this.ToolStripMenuItem_15.Size = new System.Drawing.Size(235, 24);
            this.ToolStripMenuItem_15.Text = "版面設定";
            this.ToolStripMenuItem_15.Click += new System.EventHandler(this.ToolStripMenuItem_15_Click);
            // 
            // toolStripMenuItem_16
            // 
            this.toolStripMenuItem_16.Name = "toolStripMenuItem_16";
            this.toolStripMenuItem_16.Size = new System.Drawing.Size(235, 24);
            this.toolStripMenuItem_16.Text = "預覽列印";
            this.toolStripMenuItem_16.Click += new System.EventHandler(this.toolStripMenuItem_16_Click);
            // 
            // ToolStripMenuItem_17
            // 
            this.ToolStripMenuItem_17.Name = "ToolStripMenuItem_17";
            this.ToolStripMenuItem_17.Size = new System.Drawing.Size(235, 24);
            this.ToolStripMenuItem_17.Text = "列印";
            this.ToolStripMenuItem_17.Click += new System.EventHandler(this.ToolStripMenuItem_17_Click);
            // 
            // toolStripSeparator2
            // 
            this.toolStripSeparator2.Name = "toolStripSeparator2";
            this.toolStripSeparator2.Size = new System.Drawing.Size(232, 6);
            // 
            // ToolStripMenuItem_18
            // 
            this.ToolStripMenuItem_18.Name = "ToolStripMenuItem_18";
            this.ToolStripMenuItem_18.ShortcutKeys = ((System.Windows.Forms.Keys)((System.Windows.Forms.Keys.Alt | System.Windows.Forms.Keys.D4)));
            this.ToolStripMenuItem_18.Size = new System.Drawing.Size(235, 24);
            this.ToolStripMenuItem_18.Text = "結束(X)";
            this.ToolStripMenuItem_18.Click += new System.EventHandler(this.ToolStripMenuItem_18_Click);
            // 
            // toolStripDropDownButton2
            // 
            this.toolStripDropDownButton2.DropDownItems.AddRange(new System.Windows.Forms.ToolStripItem[] {
            this.TSMI_201_Recover,
            this.toolStripSeparator3,
            this.TSMI_202_Cut,
            this.TSMI_203_Copy,
            this.TSMI_204_Paste,
            this.TSMI_205_Delete,
            this.TSMI_206_Clear,
            this.toolStripSeparator4,
            this.TSMI_207_Find,
            this.TSMI_208_FindNextOne,
            this.TSMI_209_Replace,
            this.TSMI_210_Move,
            this.toolStripSeparator5,
            this.TSMI_211_SelectAll,
            this.TSMI212_DateTime});
            this.toolStripDropDownButton2.Image = ((System.Drawing.Image)(resources.GetObject("toolStripDropDownButton2.Image")));
            this.toolStripDropDownButton2.ImageTransparentColor = System.Drawing.Color.Magenta;
            this.toolStripDropDownButton2.Name = "toolStripDropDownButton2";
            this.toolStripDropDownButton2.Size = new System.Drawing.Size(86, 23);
            this.toolStripDropDownButton2.Text = "編輯(E)";
            // 
            // TSMI_201_Recover
            // 
            this.TSMI_201_Recover.Enabled = false;
            this.TSMI_201_Recover.Name = "TSMI_201_Recover";
            this.TSMI_201_Recover.ShortcutKeys = ((System.Windows.Forms.Keys)((System.Windows.Forms.Keys.Control | System.Windows.Forms.Keys.Z)));
            this.TSMI_201_Recover.Size = new System.Drawing.Size(183, 24);
            this.TSMI_201_Recover.Text = "復原(U)";
            this.TSMI_201_Recover.Click += new System.EventHandler(this.ToolStripMenuItem_201_Click);
            // 
            // toolStripSeparator3
            // 
            this.toolStripSeparator3.Name = "toolStripSeparator3";
            this.toolStripSeparator3.Size = new System.Drawing.Size(180, 6);
            // 
            // TSMI_202_Cut
            // 
            this.TSMI_202_Cut.Enabled = false;
            this.TSMI_202_Cut.Name = "TSMI_202_Cut";
            this.TSMI_202_Cut.ShortcutKeys = ((System.Windows.Forms.Keys)((System.Windows.Forms.Keys.Control | System.Windows.Forms.Keys.X)));
            this.TSMI_202_Cut.Size = new System.Drawing.Size(183, 24);
            this.TSMI_202_Cut.Text = "剪下(T)";
            this.TSMI_202_Cut.Click += new System.EventHandler(this.ToolStripMenuItem_202_Click);
            // 
            // TSMI_203_Copy
            // 
            this.TSMI_203_Copy.Enabled = false;
            this.TSMI_203_Copy.Name = "TSMI_203_Copy";
            this.TSMI_203_Copy.ShortcutKeys = ((System.Windows.Forms.Keys)((System.Windows.Forms.Keys.Control | System.Windows.Forms.Keys.C)));
            this.TSMI_203_Copy.Size = new System.Drawing.Size(183, 24);
            this.TSMI_203_Copy.Text = "複製(C)";
            this.TSMI_203_Copy.Click += new System.EventHandler(this.ToolStripMenuItem_203_Click);
            // 
            // TSMI_204_Paste
            // 
            this.TSMI_204_Paste.Name = "TSMI_204_Paste";
            this.TSMI_204_Paste.ShortcutKeys = ((System.Windows.Forms.Keys)((System.Windows.Forms.Keys.Control | System.Windows.Forms.Keys.V)));
            this.TSMI_204_Paste.Size = new System.Drawing.Size(183, 24);
            this.TSMI_204_Paste.Text = "貼上(P)";
            this.TSMI_204_Paste.Click += new System.EventHandler(this.ToolStripMenuItem_204_Click);
            // 
            // TSMI_205_Delete
            // 
            this.TSMI_205_Delete.Name = "TSMI_205_Delete";
            this.TSMI_205_Delete.Size = new System.Drawing.Size(183, 24);
            this.TSMI_205_Delete.Text = "刪除(L)";
            this.TSMI_205_Delete.Click += new System.EventHandler(this.ToolStripMenuItem_205_Click);
            // 
            // TSMI_206_Clear
            // 
            this.TSMI_206_Clear.Enabled = false;
            this.TSMI_206_Clear.Name = "TSMI_206_Clear";
            this.TSMI_206_Clear.Size = new System.Drawing.Size(183, 24);
            this.TSMI_206_Clear.Text = "清除/清空";
            this.TSMI_206_Clear.Click += new System.EventHandler(this.ToolStripMenuItem_206_Click);
            // 
            // toolStripSeparator4
            // 
            this.toolStripSeparator4.Name = "toolStripSeparator4";
            this.toolStripSeparator4.Size = new System.Drawing.Size(180, 6);
            // 
            // TSMI_207_Find
            // 
            this.TSMI_207_Find.Name = "TSMI_207_Find";
            this.TSMI_207_Find.ShortcutKeys = ((System.Windows.Forms.Keys)((System.Windows.Forms.Keys.Control | System.Windows.Forms.Keys.F)));
            this.TSMI_207_Find.Size = new System.Drawing.Size(183, 24);
            this.TSMI_207_Find.Text = "尋找(F)";
            this.TSMI_207_Find.Click += new System.EventHandler(this.TSMI_207_Find_Click_1);
            // 
            // TSMI_208_FindNextOne
            // 
            this.TSMI_208_FindNextOne.Name = "TSMI_208_FindNextOne";
            this.TSMI_208_FindNextOne.Size = new System.Drawing.Size(183, 24);
            this.TSMI_208_FindNextOne.Text = "找下一個(N)";
            // 
            // TSMI_209_Replace
            // 
            this.TSMI_209_Replace.Name = "TSMI_209_Replace";
            this.TSMI_209_Replace.Size = new System.Drawing.Size(183, 24);
            this.TSMI_209_Replace.Text = "取代(R)";
            this.TSMI_209_Replace.Click += new System.EventHandler(this.TSMI_209_Replace_Click);
            // 
            // TSMI_210_Move
            // 
            this.TSMI_210_Move.Name = "TSMI_210_Move";
            this.TSMI_210_Move.Size = new System.Drawing.Size(183, 24);
            this.TSMI_210_Move.Text = "移至(G)";
            // 
            // toolStripSeparator5
            // 
            this.toolStripSeparator5.Name = "toolStripSeparator5";
            this.toolStripSeparator5.Size = new System.Drawing.Size(180, 6);
            // 
            // TSMI_211_SelectAll
            // 
            this.TSMI_211_SelectAll.Name = "TSMI_211_SelectAll";
            this.TSMI_211_SelectAll.Size = new System.Drawing.Size(183, 24);
            this.TSMI_211_SelectAll.Text = "全選(A)";
            this.TSMI_211_SelectAll.Click += new System.EventHandler(this.ToolStripMenuItem_211_Click);
            // 
            // TSMI212_DateTime
            // 
            this.TSMI212_DateTime.Name = "TSMI212_DateTime";
            this.TSMI212_DateTime.Size = new System.Drawing.Size(183, 24);
            this.TSMI212_DateTime.Text = "時間/日期(D)";
            this.TSMI212_DateTime.Click += new System.EventHandler(this.TSMI212_DateTime_Click);
            // 
            // toolStripDropDownButton3
            // 
            this.toolStripDropDownButton3.DisplayStyle = System.Windows.Forms.ToolStripItemDisplayStyle.Text;
            this.toolStripDropDownButton3.DropDownItems.AddRange(new System.Windows.Forms.ToolStripItem[] {
            this.toolStripMenuItem11,
            this.toolStripMenuItem12});
            this.toolStripDropDownButton3.Image = ((System.Drawing.Image)(resources.GetObject("toolStripDropDownButton3.Image")));
            this.toolStripDropDownButton3.ImageTransparentColor = System.Drawing.Color.Magenta;
            this.toolStripDropDownButton3.Name = "toolStripDropDownButton3";
            this.toolStripDropDownButton3.Size = new System.Drawing.Size(74, 23);
            this.toolStripDropDownButton3.Text = "格式(O)";
            this.toolStripDropDownButton3.Click += new System.EventHandler(this.toolStripDropDownButton3_Click);
            // 
            // toolStripMenuItem11
            // 
            this.toolStripMenuItem11.CheckOnClick = true;
            this.toolStripMenuItem11.Name = "toolStripMenuItem11";
            this.toolStripMenuItem11.Size = new System.Drawing.Size(163, 24);
            this.toolStripMenuItem11.Text = "自動換行(W)";
            this.toolStripMenuItem11.Click += new System.EventHandler(this.toolStripMenuItem11_Click);
            // 
            // toolStripMenuItem12
            // 
            this.toolStripMenuItem12.Name = "toolStripMenuItem12";
            this.toolStripMenuItem12.Size = new System.Drawing.Size(163, 24);
            this.toolStripMenuItem12.Text = "字型(F)";
            this.toolStripMenuItem12.Click += new System.EventHandler(this.toolStripMenuItem12_Click);
            // 
            // toolStripDropDownButton4
            // 
            this.toolStripDropDownButton4.DropDownItems.AddRange(new System.Windows.Forms.ToolStripItem[] {
            this.狀態列SToolStripMenuItem});
            this.toolStripDropDownButton4.Image = ((System.Drawing.Image)(resources.GetObject("toolStripDropDownButton4.Image")));
            this.toolStripDropDownButton4.ImageTransparentColor = System.Drawing.Color.Magenta;
            this.toolStripDropDownButton4.Name = "toolStripDropDownButton4";
            this.toolStripDropDownButton4.Size = new System.Drawing.Size(88, 23);
            this.toolStripDropDownButton4.Text = "檢視(V)";
            // 
            // 狀態列SToolStripMenuItem
            // 
            this.狀態列SToolStripMenuItem.Name = "狀態列SToolStripMenuItem";
            this.狀態列SToolStripMenuItem.Size = new System.Drawing.Size(152, 24);
            this.狀態列SToolStripMenuItem.Text = "狀態列(S)";
            // 
            // toolStripDropDownButton5
            // 
            this.toolStripDropDownButton5.DropDownItems.AddRange(new System.Windows.Forms.ToolStripItem[] {
            this.toolStripMenuItem13,
            this.toolStripSeparator6,
            this.toolStripMenuItem14});
            this.toolStripDropDownButton5.Image = ((System.Drawing.Image)(resources.GetObject("toolStripDropDownButton5.Image")));
            this.toolStripDropDownButton5.ImageTransparentColor = System.Drawing.Color.Magenta;
            this.toolStripDropDownButton5.Name = "toolStripDropDownButton5";
            this.toolStripDropDownButton5.Size = new System.Drawing.Size(89, 23);
            this.toolStripDropDownButton5.Text = "說明(H)";
            // 
            // toolStripMenuItem13
            // 
            this.toolStripMenuItem13.Name = "toolStripMenuItem13";
            this.toolStripMenuItem13.Size = new System.Drawing.Size(159, 24);
            this.toolStripMenuItem13.Text = "檢視說明(H)";
            this.toolStripMenuItem13.Click += new System.EventHandler(this.toolStripMenuItem13_Click);
            // 
            // toolStripSeparator6
            // 
            this.toolStripSeparator6.Name = "toolStripSeparator6";
            this.toolStripSeparator6.Size = new System.Drawing.Size(156, 6);
            // 
            // toolStripMenuItem14
            // 
            this.toolStripMenuItem14.Name = "toolStripMenuItem14";
            this.toolStripMenuItem14.Size = new System.Drawing.Size(159, 24);
            this.toolStripMenuItem14.Text = "關於記事本";
            this.toolStripMenuItem14.Click += new System.EventHandler(this.toolStripMenuItem14_Click);
            // 
            // richTextBox1
            // 
            this.richTextBox1.Anchor = ((System.Windows.Forms.AnchorStyles)((((System.Windows.Forms.AnchorStyles.Top | System.Windows.Forms.AnchorStyles.Bottom) 
            | System.Windows.Forms.AnchorStyles.Left) 
            | System.Windows.Forms.AnchorStyles.Right)));
            this.richTextBox1.Location = new System.Drawing.Point(0, 28);
            this.richTextBox1.Multiline = false;
            this.richTextBox1.Name = "richTextBox1";
            this.richTextBox1.Size = new System.Drawing.Size(658, 333);
            this.richTextBox1.TabIndex = 1;
            this.richTextBox1.Text = "";
            this.richTextBox1.TextChanged += new System.EventHandler(this.richTextBox1_TextChanged);
            // 
            // printDialog1
            // 
            this.printDialog1.UseEXDialog = true;
            // 
            // printPreviewDialog1
            // 
            this.printPreviewDialog1.AutoScrollMargin = new System.Drawing.Size(0, 0);
            this.printPreviewDialog1.AutoScrollMinSize = new System.Drawing.Size(0, 0);
            this.printPreviewDialog1.ClientSize = new System.Drawing.Size(400, 300);
            this.printPreviewDialog1.Enabled = true;
            this.printPreviewDialog1.Icon = ((System.Drawing.Icon)(resources.GetObject("printPreviewDialog1.Icon")));
            this.printPreviewDialog1.Name = "printPreviewDialog1";
            this.printPreviewDialog1.Visible = false;
            // 
            // openFileDialog1
            // 
            this.openFileDialog1.FileName = "openFileDialog1";
            // 
            // fileSystemWatcher1
            // 
            this.fileSystemWatcher1.EnableRaisingEvents = true;
            this.fileSystemWatcher1.SynchronizingObject = this;
            // 
            // Form1
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(6F, 12F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.ClientSize = new System.Drawing.Size(659, 362);
            this.Controls.Add(this.richTextBox1);
            this.Controls.Add(this.toolStrip1);
            this.Icon = ((System.Drawing.Icon)(resources.GetObject("$this.Icon")));
            this.Name = "Form1";
            this.toolStrip1.ResumeLayout(false);
            this.toolStrip1.PerformLayout();
            ((System.ComponentModel.ISupportInitialize)(this.fileSystemWatcher1)).EndInit();
            this.ResumeLayout(false);
            this.PerformLayout();

        }

        #endregion

        private System.Windows.Forms.ToolStrip toolStrip1;
        private System.Windows.Forms.ToolStripDropDownButton toolStripDropDownButton1;
        private System.Windows.Forms.ToolStripMenuItem ToolStripMenuItem_11;
        private System.Windows.Forms.ToolStripMenuItem ToolStripMenuItem_12;
        private System.Windows.Forms.ToolStripMenuItem ToolStripMenuItem_13;
        private System.Windows.Forms.ToolStripMenuItem ToolStripMenuItem_14;
        private System.Windows.Forms.ToolStripMenuItem ToolStripMenuItem_15;
        private System.Windows.Forms.ToolStripMenuItem ToolStripMenuItem_17;
        private System.Windows.Forms.ToolStripMenuItem ToolStripMenuItem_18;
        private System.Windows.Forms.ToolStripSeparator toolStripSeparator1;
        private System.Windows.Forms.ToolStripSeparator toolStripSeparator2;
        private System.Windows.Forms.ToolStripDropDownButton toolStripDropDownButton2;
        private System.Windows.Forms.ToolStripMenuItem TSMI_201_Recover;
        private System.Windows.Forms.ToolStripMenuItem TSMI_202_Cut;
        private System.Windows.Forms.ToolStripMenuItem TSMI_203_Copy;
        private System.Windows.Forms.ToolStripMenuItem TSMI_204_Paste;
        private System.Windows.Forms.ToolStripMenuItem TSMI_205_Delete;
        private System.Windows.Forms.ToolStripMenuItem TSMI_207_Find;
        private System.Windows.Forms.ToolStripSeparator toolStripSeparator3;
        private System.Windows.Forms.ToolStripSeparator toolStripSeparator4;
        private System.Windows.Forms.ToolStripMenuItem TSMI_208_FindNextOne;
        private System.Windows.Forms.ToolStripMenuItem TSMI_209_Replace;
        private System.Windows.Forms.ToolStripMenuItem TSMI_210_Move;
        private System.Windows.Forms.ToolStripSeparator toolStripSeparator5;
        private System.Windows.Forms.ToolStripMenuItem TSMI_211_SelectAll;
        private System.Windows.Forms.ToolStripMenuItem TSMI212_DateTime;
        private System.Windows.Forms.ToolStripDropDownButton toolStripDropDownButton3;
        private System.Windows.Forms.ToolStripMenuItem toolStripMenuItem11;
        private System.Windows.Forms.ToolStripMenuItem toolStripMenuItem12;
        private System.Windows.Forms.ToolStripDropDownButton toolStripDropDownButton4;
        private System.Windows.Forms.ToolStripMenuItem 狀態列SToolStripMenuItem;
        private System.Windows.Forms.ToolStripDropDownButton toolStripDropDownButton5;
        private System.Windows.Forms.ToolStripMenuItem toolStripMenuItem13;
        private System.Windows.Forms.ToolStripMenuItem toolStripMenuItem14;
        private System.Windows.Forms.RichTextBox richTextBox1;
        private System.Windows.Forms.PrintDialog printDialog1;
        private System.Drawing.Printing.PrintDocument printDocument1;
        private System.Windows.Forms.PrintPreviewDialog printPreviewDialog1;
        private System.Windows.Forms.ToolStripMenuItem toolStripMenuItem_16;

        private System.Windows.Forms.OpenFileDialog openFileDialog1;
        private System.Windows.Forms.SaveFileDialog saveFileDialog1;
        private System.Windows.Forms.ToolStripMenuItem TSMI_206_Clear;
        private System.Windows.Forms.FontDialog fontDialog1;
        private System.Windows.Forms.ToolStripSeparator toolStripSeparator6;

        //the public variable for stored the file being open
        public static string FileNameinTitle = "";
        //the public variable for string:target and string:replace with 
        public static string target;
        public static string replace;
        private System.IO.FileSystemWatcher fileSystemWatcher1;
        private System.Windows.Forms.PageSetupDialog pageSetupDialog1;
        //the public variable for storing the FilePosition
        public string OpenedFileName;
        private System.Drawing.Printing.PrintDocument document =  new System.Drawing.Printing.PrintDocument();
    }
}

