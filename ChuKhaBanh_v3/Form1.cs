namespace ChuKhaBanh_v3
{
    using System;
    using System.Collections.Generic;
    using System.Windows.Forms;
    using ChuKhaBanh_v3.Models;
    using OSVersionExtension;

    public partial class cHuKhAbAnH_v3 : Form
    {
        private readonly string WINVER = 
            $"{OSVersion.GetOperatingSystem()} (Build {OSVersion.GetOSVersion().Version.Major}." +
            $"{OSVersion.GetOSVersion().Version.Minor}." +
            $"{OSVersion.GetOSVersion().Version.Build})";
        private TextEdit textEdit;
        private List<TextEdit> convertHistory;
        private int mode;

        public cHuKhAbAnH_v3()
        {
            InitializeComponent();
            this.convertHistory = new List<TextEdit>();
            this.mode = 2;
            this.lbHistory.Items.Clear();
            this.textEdit = new TextEdit();
        }

        private void Form1_Load(object sender, EventArgs e)
        {
            this.lbWindowsVersion.Text += WINVER;
        }
        private void lbWindowsVersion_Click(object sender, EventArgs e)
        {

        }

        private void btnExit_Click(object sender, EventArgs e)
        {
            Environment.Exit(0);
        }

        private void btnConvert_Click(object sender, EventArgs e)
        {
            switch(this.rdMode2.Checked)
            {
                case true:
                    {
                        this.mode = 2;
                    }
                    break;
                default:
                    {
                        this.mode = 1;
                    }
                    break;
            }
            this.textEdit.Text = this.rtbInput.Text;
            if (this.textEdit.Text.Length > 0)
            {
                this.textEdit.Text = this.textEdit.ConvertToStyle(this.mode);
                this.lbResult.Text = this.textEdit.Text;
                this.convertHistory.Add(this.textEdit);
                this.lbHistory.Items.Add(this.textEdit.ShortText);
            }
            else
            {
                MessageBox.Show("Nhập chuỗi trước khi ấn nút \"Chuyển đổi!\"", "Chuỗi không hợp lệ");
            }
        }

        private void btnReset_Click(object sender, EventArgs e)
        {
            this.lbResult.Text = "";
            this.rtbInput.Text = "";
        }

        private void lbHistory_SelectedIndexChanged(object sender, EventArgs e)
        {
            int index = this.lbHistory.SelectedIndex;
            Clipboard.SetText(this.convertHistory[index].Text.Trim());
        }

        private void btnClearHistory_Click(object sender, EventArgs e)
        {
            if(this.lbHistory.Items.Count != 0)
            {
                this.lbHistory.Items.Clear();
            }
            else
            {
                MessageBox.Show("Lịch sử không có nội dung để xoá", "Không có gì để xoá");
            }
        }
    }
}
