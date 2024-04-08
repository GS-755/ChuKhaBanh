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
            this.rdMode1 = new System.Windows.Forms.RadioButton();
            this.rdMode2 = new System.Windows.Forms.RadioButton();
            this.label3 = new System.Windows.Forms.Label();
            this.SuspendLayout();
            // 
            // rtbInput
            // 
            this.rtbInput.Location = new System.Drawing.Point(45, 89);
            this.rtbInput.Margin = new System.Windows.Forms.Padding(3, 2, 3, 2);
            this.rtbInput.Name = "rtbInput";
            this.rtbInput.Size = new System.Drawing.Size(535, 192);
            this.rtbInput.TabIndex = 0;
            this.rtbInput.Text = "";
            this.rtbInput.TextChanged += new System.EventHandler(this.rtbInput_TextChanged);
            // 
            // lbMessage
            // 
            this.lbMessage.AutoSize = true;
            this.lbMessage.Location = new System.Drawing.Point(43, 30);
            this.lbMessage.Name = "lbMessage";
            this.lbMessage.Size = new System.Drawing.Size(140, 16);
            this.lbMessage.TabIndex = 2;
            this.lbMessage.Text = "Nhập text ở ô bên dưới";
            // 
            // lbRemind
            // 
            this.lbRemind.AutoSize = true;
            this.lbRemind.Location = new System.Drawing.Point(43, 55);
            this.lbRemind.Name = "lbRemind";
            this.lbRemind.Size = new System.Drawing.Size(138, 16);
            this.lbRemind.TabIndex = 3;
            this.lbRemind.Text = "(Enter để xuống dòng)";
            // 
            // lbConvertHistory
            // 
            this.lbConvertHistory.AutoSize = true;
            this.lbConvertHistory.Location = new System.Drawing.Point(620, 30);
            this.lbConvertHistory.Name = "lbConvertHistory";
            this.lbConvertHistory.Size = new System.Drawing.Size(116, 16);
            this.lbConvertHistory.TabIndex = 4;
            this.lbConvertHistory.Text = "Lịch sử chuyển đổi";
            // 
            // btnConvert
            // 
            this.btnConvert.Location = new System.Drawing.Point(470, 285);
            this.btnConvert.Margin = new System.Windows.Forms.Padding(3, 2, 3, 2);
            this.btnConvert.Name = "btnConvert";
            this.btnConvert.Size = new System.Drawing.Size(109, 35);
            this.btnConvert.TabIndex = 6;
            this.btnConvert.Text = "Chuyển đổi";
            this.btnConvert.UseVisualStyleBackColor = true;
            this.btnConvert.Click += new System.EventHandler(this.btnConvert_Click);
            // 
            // btnReset
            // 
            this.btnReset.Location = new System.Drawing.Point(470, 323);
            this.btnReset.Margin = new System.Windows.Forms.Padding(3, 2, 3, 2);
            this.btnReset.Name = "btnReset";
            this.btnReset.Size = new System.Drawing.Size(109, 35);
            this.btnReset.TabIndex = 7;
            this.btnReset.Text = "Đặt lại";
            this.btnReset.UseVisualStyleBackColor = true;
            this.btnReset.Click += new System.EventHandler(this.btnReset_Click);
            // 
            // btnClearHistory
            // 
            this.btnClearHistory.Location = new System.Drawing.Point(789, 33);
            this.btnClearHistory.Margin = new System.Windows.Forms.Padding(3, 2, 3, 2);
            this.btnClearHistory.Name = "btnClearHistory";
            this.btnClearHistory.Size = new System.Drawing.Size(113, 38);
            this.btnClearHistory.TabIndex = 8;
            this.btnClearHistory.Text = "Xoá lịch sử";
            this.btnClearHistory.UseVisualStyleBackColor = true;
            this.btnClearHistory.Click += new System.EventHandler(this.btnClearHistory_Click);
            // 
            // label4
            // 
            this.label4.AutoSize = true;
            this.label4.Location = new System.Drawing.Point(43, 312);
            this.label4.Name = "label4";
            this.label4.Size = new System.Drawing.Size(52, 16);
            this.label4.TabIndex = 9;
            this.label4.Text = "Kết quả";
            // 
            // btnExit
            // 
            this.btnExit.Location = new System.Drawing.Point(789, 548);
            this.btnExit.Margin = new System.Windows.Forms.Padding(3, 2, 3, 2);
            this.btnExit.Name = "btnExit";
            this.btnExit.Size = new System.Drawing.Size(113, 38);
            this.btnExit.TabIndex = 10;
            this.btnExit.Text = "Thoát";
            this.btnExit.UseVisualStyleBackColor = true;
            this.btnExit.Click += new System.EventHandler(this.button4_Click);
            // 
            // lbResult
            // 
            this.lbResult.Location = new System.Drawing.Point(44, 362);
            this.lbResult.Margin = new System.Windows.Forms.Padding(3, 2, 3, 2);
            this.lbResult.Multiline = true;
            this.lbResult.Name = "lbResult";
            this.lbResult.Size = new System.Drawing.Size(535, 197);
            this.lbResult.TabIndex = 11;
            this.lbResult.TextChanged += new System.EventHandler(this.lbResult_TextChanged);
            // 
            // lbHistory
            // 
            this.lbHistory.FormattingEnabled = true;
            this.lbHistory.ItemHeight = 16;
            this.lbHistory.Location = new System.Drawing.Point(624, 89);
            this.lbHistory.Margin = new System.Windows.Forms.Padding(4);
            this.lbHistory.Name = "lbHistory";
            this.lbHistory.Size = new System.Drawing.Size(277, 452);
            this.lbHistory.TabIndex = 12;
            this.lbHistory.SelectedIndexChanged += new System.EventHandler(this.lbHistory_SelectedIndexChanged_1);
            // 
            // label1
            // 
            this.label1.AutoSize = true;
            this.label1.Location = new System.Drawing.Point(620, 55);
            this.label1.Margin = new System.Windows.Forms.Padding(4, 0, 4, 0);
            this.label1.Name = "label1";
            this.label1.Size = new System.Drawing.Size(125, 16);
            this.label1.TabIndex = 13;
            this.label1.Text = "(Nhấn vào để copy)";
            // 
            // label2
            // 
            this.label2.AutoSize = true;
            this.label2.Location = new System.Drawing.Point(41, 335);
            this.label2.Margin = new System.Windows.Forms.Padding(4, 0, 4, 0);
            this.label2.Name = "label2";
            this.label2.Size = new System.Drawing.Size(166, 16);
            this.label2.TabIndex = 14;
            this.label2.Text = "(Có thể chỉnh sửa nội dung)";
            // 
            // lbWindowsVersion
            // 
            this.lbWindowsVersion.AutoSize = true;
            this.lbWindowsVersion.Location = new System.Drawing.Point(43, 570);
            this.lbWindowsVersion.Margin = new System.Windows.Forms.Padding(4, 0, 4, 0);
            this.lbWindowsVersion.Name = "lbWindowsVersion";
            this.lbWindowsVersion.Size = new System.Drawing.Size(115, 16);
            this.lbWindowsVersion.TabIndex = 15;
            this.lbWindowsVersion.Text = "Windows version: ";
            this.lbWindowsVersion.Click += new System.EventHandler(this.lbWindowsVersion_Click);
            // 
            // rdMode1
            // 
            this.rdMode1.AutoSize = true;
            this.rdMode1.Location = new System.Drawing.Point(327, 307);
            this.rdMode1.Name = "rdMode1";
            this.rdMode1.Size = new System.Drawing.Size(113, 20);
            this.rdMode1.TabIndex = 16;
            this.rdMode1.Text = "ChUkHaBaNh";
            this.rdMode1.UseVisualStyleBackColor = true;
            // 
            // rdMode2
            // 
            this.rdMode2.AutoSize = true;
            this.rdMode2.Checked = true;
            this.rdMode2.Location = new System.Drawing.Point(327, 286);
            this.rdMode2.Name = "rdMode2";
            this.rdMode2.Size = new System.Drawing.Size(110, 20);
            this.rdMode2.TabIndex = 17;
            this.rdMode2.TabStop = true;
            this.rdMode2.Text = "cHuKhAbAnH";
            this.rdMode2.UseVisualStyleBackColor = true;
            // 
            // label3
            // 
            this.label3.AutoSize = true;
            this.label3.Location = new System.Drawing.Point(186, 288);
            this.label3.Name = "label3";
            this.label3.Size = new System.Drawing.Size(124, 16);
            this.label3.TabIndex = 18;
            this.label3.Text = "Chế độ chuyển đổi: ";
            // 
            // cHuKhAbAnH_v2
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(8F, 16F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.ClientSize = new System.Drawing.Size(951, 598);
            this.Controls.Add(this.label3);
            this.Controls.Add(this.rdMode2);
            this.Controls.Add(this.rdMode1);
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
            this.Margin = new System.Windows.Forms.Padding(3, 2, 3, 2);
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
        private System.Windows.Forms.RadioButton rdMode1;
        private System.Windows.Forms.RadioButton rdMode2;
        private System.Windows.Forms.Label label3;
    }
}

