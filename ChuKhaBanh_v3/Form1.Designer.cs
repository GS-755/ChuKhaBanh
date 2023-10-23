namespace ChuKhaBanh_v3
{
    partial class Form1
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
            System.ComponentModel.ComponentResourceManager resources = new System.ComponentModel.ComponentResourceManager(typeof(Form1));
            this.lbWindowsVersion = new System.Windows.Forms.Label();
            this.lbHelp = new System.Windows.Forms.Label();
            this.lbHint = new System.Windows.Forms.Label();
            this.labelHistory = new System.Windows.Forms.Label();
            this.lbHint2 = new System.Windows.Forms.Label();
            this.lbHistory = new System.Windows.Forms.ListBox();
            this.btnClearHistory = new System.Windows.Forms.Button();
            this.rtbInput = new System.Windows.Forms.TextBox();
            this.lbResult = new System.Windows.Forms.TextBox();
            this.labelAns = new System.Windows.Forms.Label();
            this.label1 = new System.Windows.Forms.Label();
            this.btnReset = new System.Windows.Forms.Button();
            this.btnConvert = new System.Windows.Forms.Button();
            this.btnExit = new System.Windows.Forms.Button();
            this.SuspendLayout();
            // 
            // lbWindowsVersion
            // 
            this.lbWindowsVersion.AutoSize = true;
            this.lbWindowsVersion.Location = new System.Drawing.Point(32, 448);
            this.lbWindowsVersion.Margin = new System.Windows.Forms.Padding(2, 0, 2, 0);
            this.lbWindowsVersion.Name = "lbWindowsVersion";
            this.lbWindowsVersion.Size = new System.Drawing.Size(94, 13);
            this.lbWindowsVersion.TabIndex = 0;
            this.lbWindowsVersion.Text = "Windows version: ";
            this.lbWindowsVersion.Click += new System.EventHandler(this.lbWindowsVersion_Click);
            // 
            // lbHelp
            // 
            this.lbHelp.AutoSize = true;
            this.lbHelp.Location = new System.Drawing.Point(34, 23);
            this.lbHelp.Margin = new System.Windows.Forms.Padding(2, 0, 2, 0);
            this.lbHelp.Name = "lbHelp";
            this.lbHelp.Size = new System.Drawing.Size(118, 13);
            this.lbHelp.TabIndex = 1;
            this.lbHelp.Text = "Nhập text ở ô bên dưới ";
            // 
            // lbHint
            // 
            this.lbHint.AutoSize = true;
            this.lbHint.Location = new System.Drawing.Point(34, 45);
            this.lbHint.Margin = new System.Windows.Forms.Padding(2, 0, 2, 0);
            this.lbHint.Name = "lbHint";
            this.lbHint.Size = new System.Drawing.Size(113, 13);
            this.lbHint.TabIndex = 2;
            this.lbHint.Text = "(Enter để xuống dòng)";
            // 
            // labelHistory
            // 
            this.labelHistory.AutoSize = true;
            this.labelHistory.Location = new System.Drawing.Point(481, 23);
            this.labelHistory.Margin = new System.Windows.Forms.Padding(2, 0, 2, 0);
            this.labelHistory.Name = "labelHistory";
            this.labelHistory.Size = new System.Drawing.Size(97, 13);
            this.labelHistory.TabIndex = 3;
            this.labelHistory.Text = "Lịch sử chuyển đổi";
            // 
            // lbHint2
            // 
            this.lbHint2.AutoSize = true;
            this.lbHint2.Location = new System.Drawing.Point(481, 45);
            this.lbHint2.Margin = new System.Windows.Forms.Padding(2, 0, 2, 0);
            this.lbHint2.Name = "lbHint2";
            this.lbHint2.Size = new System.Drawing.Size(102, 13);
            this.lbHint2.TabIndex = 4;
            this.lbHint2.Text = "(Nhấn vào để copy)";
            // 
            // lbHistory
            // 
            this.lbHistory.FormattingEnabled = true;
            this.lbHistory.Location = new System.Drawing.Point(483, 74);
            this.lbHistory.Margin = new System.Windows.Forms.Padding(2, 2, 2, 2);
            this.lbHistory.Name = "lbHistory";
            this.lbHistory.Size = new System.Drawing.Size(206, 355);
            this.lbHistory.TabIndex = 5;
            this.lbHistory.SelectedIndexChanged += new System.EventHandler(this.lbHistory_SelectedIndexChanged);
            // 
            // btnClearHistory
            // 
            this.btnClearHistory.Location = new System.Drawing.Point(614, 27);
            this.btnClearHistory.Margin = new System.Windows.Forms.Padding(2, 2, 2, 2);
            this.btnClearHistory.Name = "btnClearHistory";
            this.btnClearHistory.Size = new System.Drawing.Size(75, 31);
            this.btnClearHistory.TabIndex = 6;
            this.btnClearHistory.Text = "Xoá lịch sử";
            this.btnClearHistory.UseVisualStyleBackColor = true;
            this.btnClearHistory.Click += new System.EventHandler(this.btnClearHistory_Click);
            // 
            // rtbInput
            // 
            this.rtbInput.Location = new System.Drawing.Point(34, 74);
            this.rtbInput.Margin = new System.Windows.Forms.Padding(2, 2, 2, 2);
            this.rtbInput.Multiline = true;
            this.rtbInput.Name = "rtbInput";
            this.rtbInput.ScrollBars = System.Windows.Forms.ScrollBars.Vertical;
            this.rtbInput.Size = new System.Drawing.Size(402, 157);
            this.rtbInput.TabIndex = 7;
            // 
            // lbResult
            // 
            this.lbResult.Location = new System.Drawing.Point(34, 288);
            this.lbResult.Margin = new System.Windows.Forms.Padding(2, 2, 2, 2);
            this.lbResult.Multiline = true;
            this.lbResult.Name = "lbResult";
            this.lbResult.ScrollBars = System.Windows.Forms.ScrollBars.Vertical;
            this.lbResult.Size = new System.Drawing.Size(402, 136);
            this.lbResult.TabIndex = 8;
            // 
            // labelAns
            // 
            this.labelAns.AutoSize = true;
            this.labelAns.Location = new System.Drawing.Point(32, 240);
            this.labelAns.Margin = new System.Windows.Forms.Padding(2, 0, 2, 0);
            this.labelAns.Name = "labelAns";
            this.labelAns.Size = new System.Drawing.Size(44, 13);
            this.labelAns.TabIndex = 9;
            this.labelAns.Text = "Kết quả";
            // 
            // label1
            // 
            this.label1.AutoSize = true;
            this.label1.Location = new System.Drawing.Point(32, 261);
            this.label1.Margin = new System.Windows.Forms.Padding(2, 0, 2, 0);
            this.label1.Name = "label1";
            this.label1.Size = new System.Drawing.Size(137, 13);
            this.label1.TabIndex = 10;
            this.label1.Text = "(Có thể chỉnh sửa nội dung)";
            // 
            // btnReset
            // 
            this.btnReset.Location = new System.Drawing.Point(265, 241);
            this.btnReset.Margin = new System.Windows.Forms.Padding(2, 2, 2, 2);
            this.btnReset.Name = "btnReset";
            this.btnReset.Size = new System.Drawing.Size(76, 32);
            this.btnReset.TabIndex = 11;
            this.btnReset.Text = "Đặt lại";
            this.btnReset.UseVisualStyleBackColor = true;
            this.btnReset.Click += new System.EventHandler(this.btnReset_Click);
            // 
            // btnConvert
            // 
            this.btnConvert.Location = new System.Drawing.Point(360, 241);
            this.btnConvert.Margin = new System.Windows.Forms.Padding(2, 2, 2, 2);
            this.btnConvert.Name = "btnConvert";
            this.btnConvert.Size = new System.Drawing.Size(76, 32);
            this.btnConvert.TabIndex = 12;
            this.btnConvert.Text = "Chuyển đổi";
            this.btnConvert.UseVisualStyleBackColor = true;
            this.btnConvert.Click += new System.EventHandler(this.btnConvert_Click);
            // 
            // btnExit
            // 
            this.btnExit.Location = new System.Drawing.Point(613, 439);
            this.btnExit.Margin = new System.Windows.Forms.Padding(2, 2, 2, 2);
            this.btnExit.Name = "btnExit";
            this.btnExit.Size = new System.Drawing.Size(76, 32);
            this.btnExit.TabIndex = 13;
            this.btnExit.Text = "Thoát";
            this.btnExit.UseVisualStyleBackColor = true;
            this.btnExit.Click += new System.EventHandler(this.btnExit_Click);
            // 
            // Form1
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(6F, 13F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.ClientSize = new System.Drawing.Size(713, 486);
            this.Controls.Add(this.btnExit);
            this.Controls.Add(this.btnConvert);
            this.Controls.Add(this.btnReset);
            this.Controls.Add(this.label1);
            this.Controls.Add(this.labelAns);
            this.Controls.Add(this.lbResult);
            this.Controls.Add(this.rtbInput);
            this.Controls.Add(this.btnClearHistory);
            this.Controls.Add(this.lbHistory);
            this.Controls.Add(this.lbHint2);
            this.Controls.Add(this.labelHistory);
            this.Controls.Add(this.lbHint);
            this.Controls.Add(this.lbHelp);
            this.Controls.Add(this.lbWindowsVersion);
            this.FormBorderStyle = System.Windows.Forms.FormBorderStyle.FixedSingle;
            this.Icon = ((System.Drawing.Icon)(resources.GetObject("$this.Icon")));
            this.Margin = new System.Windows.Forms.Padding(2, 2, 2, 2);
            this.MaximizeBox = false;
            this.Name = "Form1";
            this.Text = "cHuKhAbAnH_v3";
            this.Load += new System.EventHandler(this.Form1_Load);
            this.ResumeLayout(false);
            this.PerformLayout();

        }

        #endregion

        private System.Windows.Forms.Label lbWindowsVersion;
        private System.Windows.Forms.Label lbHelp;
        private System.Windows.Forms.Label lbHint;
        private System.Windows.Forms.Label labelHistory;
        private System.Windows.Forms.Label lbHint2;
        private System.Windows.Forms.ListBox lbHistory;
        private System.Windows.Forms.Button btnClearHistory;
        private System.Windows.Forms.TextBox rtbInput;
        private System.Windows.Forms.TextBox lbResult;
        private System.Windows.Forms.Label labelAns;
        private System.Windows.Forms.Label label1;
        private System.Windows.Forms.Button btnReset;
        private System.Windows.Forms.Button btnConvert;
        private System.Windows.Forms.Button btnExit;
    }
}

