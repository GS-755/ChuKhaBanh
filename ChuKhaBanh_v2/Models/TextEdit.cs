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
                string shortText = "";
                if(this.Size > 30)
                {
                    for(int i = 0; i < (int)(this.Size / 2); i++)
                    {
                        shortText += this.Text[i];
                    }
                    shortText += "...";

                    return shortText;
                }

                return this.Text;                
            }
        }

        public TextEdit() { this.Text = null; }
        public TextEdit(string text) { this.Text = text; }

        public string[] SplitString()
        {
            string[] strings = this.Text.Split('\n');

            return strings;
        }
        public string ConvertStyle1() 
        {
            string finalString = "";
            string[] strings = SplitString();
            int len = strings.Length;
            for(int k = 0; k < len; k++)
            {
                char[] chars = strings[k].ToCharArray();
                for (int i = 0; i < chars.Length; i++)
                    if (i % 2 != 0)
                    {
                        chars[i] = char.ToUpper(chars[i]);
                    }
                finalString += new string(chars) + "\n";
            }
            
            return finalString;
        }
    }
}
