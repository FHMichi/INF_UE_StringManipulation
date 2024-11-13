using System.Text;

namespace INF_UE_StringManipulation
{
    public partial class Form1 : Form
    {
        public Form1()
        {
            InitializeComponent();
        }

        private void btStart_Click(object sender, EventArgs e)
        {
            //Reverse Text
            String text = tbInput.Text;           
            StringBuilder reversed = new StringBuilder();
            
            for (int i = text.Length - 1; i >= 0; i--)
            {
                reversed.Append(text.Substring(i, 1));
            }

            lblOutput1.Text = "" + reversed;

            //Part 2 
            char c;
            StringBuilder result = new StringBuilder(); 

            for (int i = 0; i < text.Length; i++)
            {
                c = text[i];

                if (char.IsLetter(c))
                {
                    if (c == 'Z') result.Append('A');
                    else if (c == 'z') result.Append('a');
                    else result.Append((char)(c + 1));
                }
                else
                    result.Append(c);   
            }

            lblOutput2.Text = result.ToString();


        }
    }
}
