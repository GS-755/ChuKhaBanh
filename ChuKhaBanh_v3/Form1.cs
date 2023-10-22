using ChuKhaBanh_v3.Models;
using OSVersionExtension;
using System;
using System.Windows.Forms;

namespace ChuKhaBanh_v3
{
    public partial class Form1 : Form
    {
        private readonly string WINVER = 
            $"{OSVersion.GetOSVersion().Version.Major}." +
            $"{OSVersion.GetOSVersion().Version.Minor}." +
            $"{OSVersion.GetOSVersion().Version.Build}";
        private TextEdit textEdit = new TextEdit();

        public Form1()
        {
            InitializeComponent();
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

        private void lbHistory_SelectedIndexChanged(object sender, EventArgs e)
        {
            Clipboard.SetText(this.textEdit.Text);
        }

        private void btnClearHistory_Click(object sender, EventArgs e)
        {
            this.lbHistory.Items.Clear();
        }
    }
}
