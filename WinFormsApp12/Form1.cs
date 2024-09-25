using System.Linq.Expressions;
using System.Windows.Forms.Design;

namespace WinFormsApp12
{
    public partial class Form1 : Form
    {
        string z = "";
        public Form1()
        {
            InitializeComponent();
        }

        private void button1_Click(object sender, EventArgs e)
        {
            List<Commands> commands = new List<Commands>();
            string text = textBox1.Text + "\n";
            while (text != "")
            {
                string line = text[0..text.IndexOf("\n")];
                try
                {
                    commands.Add(
                        new(
                            line[0..line.IndexOf("(")],
                            line[(line.IndexOf("(") + 1)..line.IndexOf(")")]
                            
                            )
                        );
                    


                }
                catch (Exception ex) { }
                text = text[(text.IndexOf("\n") + 1)..^0];
            }
            Form2 form2 = new Form2(commands);
            form2.Show();
            



            //string text = textBox1.Text + "\n";
            //while (text != "")
            //{

            //    string line = text[0..text.IndexOf("\n")].ToString();
            //    MessageBox.Show(line);
            //    text = text[(text.IndexOf("\n") + 1)..^0];
            //}
        }
        public class Commands(string key, string value)
        {
            public string key = key;
            public string value = value;
        }

    }
}
