using ChuKhaBanh_v2.Models;
using System;
using System.Windows.Forms;

namespace ChuKhaBanh_v2
{
    public partial class cHuKhAbAnH_v2 : Form
    {
        private TextEdit textEdit = new TextEdit();

        public cHuKhAbAnH_v2()
        {
            InitializeComponent();
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
            this.textEdit.Text = this.rtbInput.Text;
            if (this.textEdit.Text.Length > 0)
            {
                this.textEdit.Text = this.textEdit.ConvertStyle1();
                this.lbResult.Text = this.textEdit.Text;
                this.lbHistory.Items.Add(this.textEdit.ShortText);
            }
            else
            {
                this.lbResult.Text = "Nhập chuỗi trước khi ấn nút Chuyển đổi!";
            }
        }

        private void btnReset_Click(object sender, EventArgs e)
        {
            this.lbResult.Text = "";
            this.rtbInput.Text = "";
        }

        private void btnClearHistory_Click(object sender, EventArgs e)
        {
            this.lbHistory.Items.Clear();
        }
        private void lbHistory_SelectedIndexChanged_1(object sender, EventArgs e)
        {
            Clipboard.SetText(this.textEdit.Text);
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
            this.lbWindowsVersion.Text += 
                Environment.OSVersion.VersionString + "\n (Compatibility mode)";
        }

        private void lbWindowsVersion_Click(object sender, EventArgs e)
        {

        }
    }
}
