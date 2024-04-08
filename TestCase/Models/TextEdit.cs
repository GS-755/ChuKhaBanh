namespace TestCase.Models
{
    public class TextEdit
    {
        public string Text { get; set; }
        public string ShortText 
        {
            get
            {
                string shortText = "";
                if(this.Size > 30)
                {
                    for(int i = 0; i < this.Size; i++)
                    {
                        shortText += this.Text[i];
                    }
                    shortText += "...";

                    return shortText;
                }

                return this.Text;                
            }
        }
        public int Size { get => this.Text.Length; }

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
            for(int k = 0; k < strings.Length; k++)
            {
                char[] chars = strings[k].ToCharArray();
                for (int i = 0; i < chars.Length; i++)
                {
                    if (i % 2 != 0)
                    {
                        chars[i] = char.ToUpper(chars[i]);
                    }
                }
                finalString += new string(chars) + "\n";
            }
            
            return finalString;
        }
    }
}