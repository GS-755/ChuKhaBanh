using System;
using ChuKhaBanh_v2.Models;
using System.Windows.Forms;
using System.Collections.Generic;

namespace ChuKhaBanh_v2
{
    public partial class cHuKhAbAnH_v2 : Form
    {
        private readonly string VERSION = Environment.OSVersion.VersionString + " (Compatibility mode)";
        private TextEdit textEdit;
        private List<TextEdit> convertHistory;
        private int mode;

        public cHuKhAbAnH_v2()
        {
            InitializeComponent();
            this.mode = 2;
            this.textEdit = new TextEdit();
            this.convertHistory = new List<TextEdit>();
        }

        private void button4_Click(object sender, EventArgs e)
        {
            Environment.Exit(0);
        }

        private void rtbInput_TextChanged(object sender, EventArgs e)
        {

        }

        private void btnConvert_Click(object sender, EventArgs e)
        {
            switch (this.rdMode2.Checked)
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
                this.convertHistory.Add(textEdit);
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

        private void btnClearHistory_Click(object sender, EventArgs e)
        {
            if (this.lbHistory.Items.Count != 0)
            {
                this.lbHistory.Items.Clear();
            }
            else
            {
                MessageBox.Show("Lịch sử không có nội dung để xoá", "Không có gì để xoá");
            }
        }
        private void lbHistory_SelectedIndexChanged_1(object sender, EventArgs e)
        {
            int index = this.lbHistory.SelectedIndex;
            string copiedText = this.convertHistory[index].Text.Trim();
            Clipboard.SetText(copiedText);
        }
        private void lbResult_SelectedIndexChanged(object sender, EventArgs e)
        {

        }

        private void lbHistory_SelectedIndexChanged(object sender, EventArgs e)
        {

        }

        private void lbResult_TextChanged(object sender, EventArgs e)
        {

        }

        private void lbHistory_TextChanged(object sender, EventArgs e)
        {

        }

        private void cHuKhAbAnH_v2_Load(object sender, EventArgs e)
        {
            this.lbWindowsVersion.Text = this.VERSION;
        }

        private void lbWindowsVersion_Click(object sender, EventArgs e)
        {

        }
    }
}
