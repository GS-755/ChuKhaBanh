namespace ChuKhaBanh_v2.Models
{
    public class TextEdit
    {
        public string Text { get; set; }

        public int Size { get => this.Text.Length; }
        public string ShortText
        {
            get
            {
                string shortText = string.Empty;
                if (this.Size >= 40)
                {
                    for (int i = 0; i < (int)(this.Size / 2); i++)
                    {
                        shortText += this.Text[i];
                    }
                    shortText += "...";

                    return shortText;
                }

                return this.Text;
            }
        }

        public TextEdit() { this.Text = string.Empty; }
        public TextEdit(string text) { this.Text = text.ToLower().Trim(); }

        public string[] SplitString()
        {
            string[] strings = this.Text.ToLower().Split('\n');

            return strings;
        }
        public string ConvertToStyle(int mode = 2)
        {
            string finalString = string.Empty;
            string[] strings = SplitString();
            int len = strings.Length;
            for (int k = 0; k < len; k++)
            {
                char[] chars = strings[k].ToCharArray();
                if (mode != 2)
                {
                    for (int i = 0; i < chars.Length; i++)
                        if (i % 2 == 0)
                        {
                            chars[i] = char.ToUpper(chars[i]);
                        }
                }
                else
                {
                    for (int i = 0; i < chars.Length; i++)
                        if (i % 2 != 0)
                        {
                            chars[i] = char.ToUpper(chars[i]);
                        }
                }
                finalString += new string(chars) + "\n";
            }
            this.Text = finalString.Trim();

            return finalString.Trim();
        }
    }
}
