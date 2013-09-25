namespace UVS
{
    partial class MainForm
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
            System.ComponentModel.ComponentResourceManager resources = new System.ComponentModel.ComponentResourceManager(typeof(MainForm));
            this.bt_Start = new System.Windows.Forms.Button();
            this.lstv_List = new System.Windows.Forms.ListView();
            this.bt_Stop = new System.Windows.Forms.Button();
            this.num_ThreadCount = new System.Windows.Forms.NumericUpDown();
            this.ts_UpperMenu = new System.Windows.Forms.ToolStrip();
            this.ts_UpperMenu_bt_File = new System.Windows.Forms.ToolStripDropDownButton();
            this.ts_UpperMenu_bt_Close = new System.Windows.Forms.ToolStripMenuItem();
            ((System.ComponentModel.ISupportInitialize)(this.num_ThreadCount)).BeginInit();
            this.ts_UpperMenu.SuspendLayout();
            this.SuspendLayout();
            // 
            // bt_Start
            // 
            this.bt_Start.Location = new System.Drawing.Point(12, 54);
            this.bt_Start.Name = "bt_Start";
            this.bt_Start.Size = new System.Drawing.Size(121, 35);
            this.bt_Start.TabIndex = 0;
            this.bt_Start.Text = "Start";
            this.bt_Start.UseVisualStyleBackColor = true;
            this.bt_Start.Click += new System.EventHandler(this.bt_Start_Click);
            // 
            // lstv_List
            // 
            this.lstv_List.Anchor = ((System.Windows.Forms.AnchorStyles)((((System.Windows.Forms.AnchorStyles.Top | System.Windows.Forms.AnchorStyles.Bottom) 
            | System.Windows.Forms.AnchorStyles.Left) 
            | System.Windows.Forms.AnchorStyles.Right)));
            this.lstv_List.Location = new System.Drawing.Point(139, 28);
            this.lstv_List.Name = "lstv_List";
            this.lstv_List.Size = new System.Drawing.Size(418, 323);
            this.lstv_List.TabIndex = 1;
            this.lstv_List.UseCompatibleStateImageBehavior = false;
            // 
            // bt_Stop
            // 
            this.bt_Stop.Location = new System.Drawing.Point(12, 95);
            this.bt_Stop.Name = "bt_Stop";
            this.bt_Stop.Size = new System.Drawing.Size(121, 35);
            this.bt_Stop.TabIndex = 3;
            this.bt_Stop.Text = "Stop";
            this.bt_Stop.UseVisualStyleBackColor = true;
            this.bt_Stop.Click += new System.EventHandler(this.bt_Stop_Click);
            // 
            // num_ThreadCount
            // 
            this.num_ThreadCount.Location = new System.Drawing.Point(12, 28);
            this.num_ThreadCount.Name = "num_ThreadCount";
            this.num_ThreadCount.Size = new System.Drawing.Size(121, 20);
            this.num_ThreadCount.TabIndex = 4;
            // 
            // ts_UpperMenu
            // 
            this.ts_UpperMenu.GripStyle = System.Windows.Forms.ToolStripGripStyle.Hidden;
            this.ts_UpperMenu.Items.AddRange(new System.Windows.Forms.ToolStripItem[] {
            this.ts_UpperMenu_bt_File});
            this.ts_UpperMenu.Location = new System.Drawing.Point(0, 0);
            this.ts_UpperMenu.Name = "ts_UpperMenu";
            this.ts_UpperMenu.RenderMode = System.Windows.Forms.ToolStripRenderMode.System;
            this.ts_UpperMenu.Size = new System.Drawing.Size(569, 25);
            this.ts_UpperMenu.TabIndex = 5;
            this.ts_UpperMenu.Text = "toolStrip1";
            // 
            // ts_UpperMenu_bt_File
            // 
            this.ts_UpperMenu_bt_File.DisplayStyle = System.Windows.Forms.ToolStripItemDisplayStyle.Text;
            this.ts_UpperMenu_bt_File.DropDownItems.AddRange(new System.Windows.Forms.ToolStripItem[] {
            this.ts_UpperMenu_bt_Close});
            this.ts_UpperMenu_bt_File.Image = ((System.Drawing.Image)(resources.GetObject("ts_UpperMenu_bt_File.Image")));
            this.ts_UpperMenu_bt_File.ImageTransparentColor = System.Drawing.Color.Magenta;
            this.ts_UpperMenu_bt_File.Name = "ts_UpperMenu_bt_File";
            this.ts_UpperMenu_bt_File.ShowDropDownArrow = false;
            this.ts_UpperMenu_bt_File.Size = new System.Drawing.Size(27, 22);
            this.ts_UpperMenu_bt_File.Text = "File";
            // 
            // ts_UpperMenu_bt_Close
            // 
            this.ts_UpperMenu_bt_Close.Image = ((System.Drawing.Image)(resources.GetObject("ts_UpperMenu_bt_Close.Image")));
            this.ts_UpperMenu_bt_Close.Name = "ts_UpperMenu_bt_Close";
            this.ts_UpperMenu_bt_Close.Size = new System.Drawing.Size(152, 22);
            this.ts_UpperMenu_bt_Close.Text = "Close";
            this.ts_UpperMenu_bt_Close.Click += new System.EventHandler(this.ts_UpperMenu_bt_Close_Click);
            // 
            // MainForm
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(6F, 13F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.ClientSize = new System.Drawing.Size(569, 363);
            this.Controls.Add(this.ts_UpperMenu);
            this.Controls.Add(this.num_ThreadCount);
            this.Controls.Add(this.bt_Stop);
            this.Controls.Add(this.lstv_List);
            this.Controls.Add(this.bt_Start);
            this.Icon = ((System.Drawing.Icon)(resources.GetObject("$this.Icon")));
            this.MinimumSize = new System.Drawing.Size(470, 390);
            this.Name = "MainForm";
            this.StartPosition = System.Windows.Forms.FormStartPosition.CenterScreen;
            this.Text = "Threads";
            ((System.ComponentModel.ISupportInitialize)(this.num_ThreadCount)).EndInit();
            this.ts_UpperMenu.ResumeLayout(false);
            this.ts_UpperMenu.PerformLayout();
            this.ResumeLayout(false);
            this.PerformLayout();

        }

        private System.Windows.Forms.Button bt_Start;
        private System.Windows.Forms.ListView lstv_List;
        private System.Windows.Forms.Button bt_Stop;
        private System.Windows.Forms.NumericUpDown num_ThreadCount;

        #endregion
        private System.Windows.Forms.ToolStrip ts_UpperMenu;
        private System.Windows.Forms.ToolStripDropDownButton ts_UpperMenu_bt_File;
        private System.Windows.Forms.ToolStripMenuItem ts_UpperMenu_bt_Close;
    }
}