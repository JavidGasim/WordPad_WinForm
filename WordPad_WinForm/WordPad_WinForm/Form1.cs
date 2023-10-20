namespace WordPad_WinForm
{
    public partial class Form1 : Form
    {
        public Form1()
        {
            InitializeComponent();
        }

        private void font_button_Click(object sender, EventArgs e)
        {
            if (fontDialog1.ShowDialog() == DialogResult.OK)
            {
                richTextBox1.Font = fontDialog1.Font;
            }
        }

        private void color_btn_Click(object sender, EventArgs e)
        {
            if (colorDialog1.ShowDialog() == DialogResult.OK)
            {
                richTextBox1.ForeColor = colorDialog1.Color;
            }
        }

        private void textBox2_TextChanged(object sender, EventArgs e)
        {

        }

        private void load_btn_Click(object sender, EventArgs e)
        {
            openFileDialog1.Filter = "(*.txt)|*.txt|(*.*)|*.*";

            if (openFileDialog1.ShowDialog() == DialogResult.OK)
            {
                string txt = File.ReadAllText(openFileDialog1.FileName);
                richTextBox1.Text = txt;
            }
        }

        private void save_btn_Click(object sender, EventArgs e)
        {
            saveFileDialog1.Filter = "(*.txt)|*.txt|(*.*)|*.*";
            saveFileDialog1.FileName = textBox1.Text;

            if (saveFileDialog1.ShowDialog() == DialogResult.OK)
            {
                string path = saveFileDialog1.FileName;
                StreamWriter writer = new StreamWriter(path);

                writer.Write(richTextBox1);
                writer.Close();
            }
        }
    }
}