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
            this.bt_Start = new System.Windows.Forms.Button();
            this.lstv_List = new System.Windows.Forms.ListView();
            this.bt_Stop = new System.Windows.Forms.Button();
            this.num_ThreadCount = new System.Windows.Forms.NumericUpDown();
            ((System.ComponentModel.ISupportInitialize)(this.num_ThreadCount)).BeginInit();
            this.SuspendLayout();
            // 
            // bt_Start
            // 
            this.bt_Start.Location = new System.Drawing.Point(12, 12);
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
            this.lstv_List.Location = new System.Drawing.Point(12, 55);
            this.lstv_List.Name = "lstv_List";
            this.lstv_List.Size = new System.Drawing.Size(764, 483);
            this.lstv_List.TabIndex = 1;
            this.lstv_List.UseCompatibleStateImageBehavior = false;
            // 
            // bt_Stop
            // 
            this.bt_Stop.Location = new System.Drawing.Point(655, 12);
            this.bt_Stop.Name = "bt_Stop";
            this.bt_Stop.Size = new System.Drawing.Size(121, 35);
            this.bt_Stop.TabIndex = 3;
            this.bt_Stop.Text = "Stop";
            this.bt_Stop.UseVisualStyleBackColor = true;
            this.bt_Stop.Click += new System.EventHandler(this.bt_Stop_Click);
            // 
            // num_ThreadCount
            // 
            this.num_ThreadCount.Location = new System.Drawing.Point(139, 12);
            this.num_ThreadCount.Name = "num_ThreadCount";
            this.num_ThreadCount.Size = new System.Drawing.Size(120, 20);
            this.num_ThreadCount.TabIndex = 4;
            // 
            // MainForm
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(6F, 13F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.ClientSize = new System.Drawing.Size(788, 550);
            this.Controls.Add(this.num_ThreadCount);
            this.Controls.Add(this.bt_Stop);
            this.Controls.Add(this.lstv_List);
            this.Controls.Add(this.bt_Start);
            this.Name = "MainForm";
            this.Text = "Form1";
            ((System.ComponentModel.ISupportInitialize)(this.num_ThreadCount)).EndInit();
            this.ResumeLayout(false);

        }

        private System.Windows.Forms.Button bt_Start;
        private System.Windows.Forms.ListView lstv_List;
        private System.Windows.Forms.Button bt_Stop;
        private System.Windows.Forms.NumericUpDown num_ThreadCount;

        #endregion
    }
}