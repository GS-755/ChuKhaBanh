namespace ChuKhaBanh_v2
{
    partial class cHuKhAbAnH_v2
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
            System.ComponentModel.ComponentResourceManager resources = new System.ComponentModel.ComponentResourceManager(typeof(cHuKhAbAnH_v2));
            this.rtbInput = new System.Windows.Forms.RichTextBox();
            this.lbMessage = new System.Windows.Forms.Label();
            this.lbRemind = new System.Windows.Forms.Label();
            this.lbConvertHistory = new System.Windows.Forms.Label();
            this.btnConvert = new System.Windows.Forms.Button();
            this.btnReset = new System.Windows.Forms.Button();
            this.btnClearHistory = new System.Windows.Forms.Button();
            this.label4 = new System.Windows.Forms.Label();
            this.btnExit = new System.Windows.Forms.Button();
            this.lbResult = new System.Windows.Forms.TextBox();
            this.lbHistory = new System.Windows.Forms.ListBox();
            this.label1 = new System.Windows.Forms.Label();
            this.label2 = new System.Windows.Forms.Label();
            this.lbWindowsVersion = new System.Windows.Forms.Label();
            this.SuspendLayout();
            // 
            // rtbInput
            // 
            this.rtbInput.Location = new System.Drawing.Point(34, 72);
            this.rtbInput.Margin = new System.Windows.Forms.Padding(2);
            this.rtbInput.Name = "rtbInput";
            this.rtbInput.Size = new System.Drawing.Size(402, 157);
            this.rtbInput.TabIndex = 0;
            this.rtbInput.Text = "";
            this.rtbInput.TextChanged += new System.EventHandler(this.rtbInput_TextChanged);
            // 
            // lbMessage
            // 
            this.lbMessage.AutoSize = true;
            this.lbMessage.Location = new System.Drawing.Point(32, 24);
            this.lbMessage.Margin = new System.Windows.Forms.Padding(2, 0, 2, 0);
            this.lbMessage.Name = "lbMessage";
            this.lbMessage.Size = new System.Drawing.Size(115, 13);
            this.lbMessage.TabIndex = 2;
            this.lbMessage.Text = "Nhập text ở ô bên dưới";
            // 
            // lbRemind
            // 
            this.lbRemind.AutoSize = true;
            this.lbRemind.Location = new System.Drawing.Point(32, 45);
            this.lbRemind.Margin = new System.Windows.Forms.Padding(2, 0, 2, 0);
            this.lbRemind.Name = "lbRemind";
            this.lbRemind.Size = new System.Drawing.Size(113, 13);
            this.lbRemind.TabIndex = 3;
            this.lbRemind.Text = "(Enter để xuống dòng)";
            // 
            // lbConvertHistory
            // 
            this.lbConvertHistory.AutoSize = true;
            this.lbConvertHistory.Location = new System.Drawing.Point(465, 24);
            this.lbConvertHistory.Margin = new System.Windows.Forms.Padding(2, 0, 2, 0);
            this.lbConvertHistory.Name = "lbConvertHistory";
            this.lbConvertHistory.Size = new System.Drawing.Size(97, 13);
            this.lbConvertHistory.TabIndex = 4;
            this.lbConvertHistory.Text = "Lịch sử chuyển đổi";
            // 
            // btnConvert
            // 
            this.btnConvert.Location = new System.Drawing.Point(354, 236);
            this.btnConvert.Margin = new System.Windows.Forms.Padding(2);
            this.btnConvert.Name = "btnConvert";
            this.btnConvert.Size = new System.Drawing.Size(82, 31);
            this.btnConvert.TabIndex = 6;
            this.btnConvert.Text = "Chuyển đổi";
            this.btnConvert.UseVisualStyleBackColor = true;
            this.btnConvert.Click += new System.EventHandler(this.btnConvert_Click);
            // 
            // btnReset
            // 
            this.btnReset.Location = new System.Drawing.Point(249, 236);
            this.btnReset.Margin = new System.Windows.Forms.Padding(2);
            this.btnReset.Name = "btnReset";
            this.btnReset.Size = new System.Drawing.Size(82, 31);
            this.btnReset.TabIndex = 7;
            this.btnReset.Text = "Đặt lại";
            this.btnReset.UseVisualStyleBackColor = true;
            this.btnReset.Click += new System.EventHandler(this.btnReset_Click);
            // 
            // btnClearHistory
            // 
            this.btnClearHistory.Location = new System.Drawing.Point(592, 27);
            this.btnClearHistory.Margin = new System.Windows.Forms.Padding(2);
            this.btnClearHistory.Name = "btnClearHistory";
            this.btnClearHistory.Size = new System.Drawing.Size(85, 31);
            this.btnClearHistory.TabIndex = 8;
            this.btnClearHistory.Text = "Xoá lịch sử";
            this.btnClearHistory.UseVisualStyleBackColor = true;
            this.btnClearHistory.Click += new System.EventHandler(this.btnClearHistory_Click);
            // 
            // label4
            // 
            this.label4.AutoSize = true;
            this.label4.Location = new System.Drawing.Point(32, 236);
            this.label4.Margin = new System.Windows.Forms.Padding(2, 0, 2, 0);
            this.label4.Name = "label4";
            this.label4.Size = new System.Drawing.Size(44, 13);
            this.label4.TabIndex = 9;
            this.label4.Text = "Kết quả";
            // 
            // btnExit
            // 
            this.btnExit.Location = new System.Drawing.Point(592, 445);
            this.btnExit.Margin = new System.Windows.Forms.Padding(2);
            this.btnExit.Name = "btnExit";
            this.btnExit.Size = new System.Drawing.Size(85, 31);
            this.btnExit.TabIndex = 10;
            this.btnExit.Text = "Thoát";
            this.btnExit.UseVisualStyleBackColor = true;
            this.btnExit.Click += new System.EventHandler(this.button4_Click);
            // 
            // lbResult
            // 
            this.lbResult.Location = new System.Drawing.Point(34, 275);
            this.lbResult.Margin = new System.Windows.Forms.Padding(2);
            this.lbResult.Multiline = true;
            this.lbResult.Name = "lbResult";
            this.lbResult.Size = new System.Drawing.Size(402, 161);
            this.lbResult.TabIndex = 11;
            this.lbResult.TextChanged += new System.EventHandler(this.lbResult_TextChanged);
            // 
            // lbHistory
            // 
            this.lbHistory.FormattingEnabled = true;
            this.lbHistory.Location = new System.Drawing.Point(468, 72);
            this.lbHistory.Name = "lbHistory";
            this.lbHistory.Size = new System.Drawing.Size(209, 368);
            this.lbHistory.TabIndex = 12;
            this.lbHistory.SelectedIndexChanged += new System.EventHandler(this.lbHistory_SelectedIndexChanged_1);
            // 
            // label1
            // 
            this.label1.AutoSize = true;
            this.label1.Location = new System.Drawing.Point(465, 45);
            this.label1.Name = "label1";
            this.label1.Size = new System.Drawing.Size(102, 13);
            this.label1.TabIndex = 13;
            this.label1.Text = "(Nhấn vào để copy)";
            // 
            // label2
            // 
            this.label2.AutoSize = true;
            this.label2.Location = new System.Drawing.Point(31, 254);
            this.label2.Name = "label2";
            this.label2.Size = new System.Drawing.Size(137, 13);
            this.label2.TabIndex = 14;
            this.label2.Text = "(Có thể chỉnh sửa nội dung)";
            // 
            // lbWindowsVersion
            // 
            this.lbWindowsVersion.AutoSize = true;
            this.lbWindowsVersion.Location = new System.Drawing.Point(32, 445);
            this.lbWindowsVersion.Name = "lbWindowsVersion";
            this.lbWindowsVersion.Size = new System.Drawing.Size(94, 13);
            this.lbWindowsVersion.TabIndex = 15;
            this.lbWindowsVersion.Text = "Windows version: ";
            // 
            // cHuKhAbAnH_v2
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(6F, 13F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.ClientSize = new System.Drawing.Size(713, 486);
            this.Controls.Add(this.lbWindowsVersion);
            this.Controls.Add(this.label2);
            this.Controls.Add(this.label1);
            this.Controls.Add(this.lbHistory);
            this.Controls.Add(this.lbResult);
            this.Controls.Add(this.btnExit);
            this.Controls.Add(this.label4);
            this.Controls.Add(this.btnClearHistory);
            this.Controls.Add(this.btnReset);
            this.Controls.Add(this.btnConvert);
            this.Controls.Add(this.lbConvertHistory);
            this.Controls.Add(this.lbRemind);
            this.Controls.Add(this.lbMessage);
            this.Controls.Add(this.rtbInput);
            this.FormBorderStyle = System.Windows.Forms.FormBorderStyle.FixedSingle;
            this.Icon = ((System.Drawing.Icon)(resources.GetObject("$this.Icon")));
            this.Margin = new System.Windows.Forms.Padding(2);
            this.MaximizeBox = false;
            this.Name = "cHuKhAbAnH_v2";
            this.Text = "cHuKhAbAnH_v2";
            this.Load += new System.EventHandler(this.cHuKhAbAnH_v2_Load);
            this.ResumeLayout(false);
            this.PerformLayout();

        }

        #endregion

        private System.Windows.Forms.RichTextBox rtbInput;
        private System.Windows.Forms.Label lbMessage;
        private System.Windows.Forms.Label lbRemind;
        private System.Windows.Forms.Label lbConvertHistory;
        private System.Windows.Forms.Button btnConvert;
        private System.Windows.Forms.Button btnReset;
        private System.Windows.Forms.Button btnClearHistory;
        private System.Windows.Forms.Label label4;
        private System.Windows.Forms.Button btnExit;
        private System.Windows.Forms.TextBox lbResult;
        private System.Windows.Forms.ListBox lbHistory;
        private System.Windows.Forms.Label label1;
        private System.Windows.Forms.Label label2;
        private System.Windows.Forms.Label lbWindowsVersion;
    }
}

