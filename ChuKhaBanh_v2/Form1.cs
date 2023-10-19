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
            textEdit.Text = rtbInput.Text;
            if (textEdit.Text.Length > 0)
            {
                textEdit.Text = textEdit.ConvertStyle1();
                lbResult.Text = textEdit.Text;
                lbHistory.Items.Add(textEdit.ShortText);
            }
            else
            {
                lbResult.Text = "Nhập chuỗi trước khi ấn nút Chuyển đổi!";
            }
        }

        private void btnReset_Click(object sender, EventArgs e)
        {
            lbResult.Text = "";
            rtbInput.Text = "";
        }

        private void btnClearHistory_Click(object sender, EventArgs e)
        {
            lbHistory.Items.Clear();
        }
        private void lbHistory_SelectedIndexChanged_1(object sender, EventArgs e)
        {
            Clipboard.SetText(textEdit.Text);
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
            lbWindowsVersion.Text += 
                Environment.OSVersion.VersionString + "\n (Compatibility mode)";
        }
    }
}
