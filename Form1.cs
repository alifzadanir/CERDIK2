namespace GuiTema
{
    public partial class Form1 : Form
    {
        public Form1()
        {
            InitializeComponent();
        }

        private void button1_Click(object sender, EventArgs e)
        {
            string selectedTheme = comboBox1.SelectedItem.ToString();
            ApplyTheme(selectedTheme);
        }

        private void ApplyTheme(string theme)
        {
            switch (theme)
            {
                case "Default":
                    SetDefaultTheme();
                    break;
                case "Gelap":
                    SetDarkTheme();
                    break;
                default:
                    SetDefaultTheme();
                    break;
            }
        }

        private void SetDefaultTheme()
        {
            this.BackColor = SystemColors.Control;
            this.ForeColor = SystemColors.ControlText;
            foreach (Control control in this.Controls)
            {
                if (control is TextBox || control is Button || control is Label)
                {
                    control.BackColor = SystemColors.Window;
                    control.ForeColor = SystemColors.ControlText;
                }
            }
        }

        private void SetDarkTheme()
        {
            this.BackColor = Color.FromArgb(45, 45, 48);
            this.ForeColor = Color.White;
            foreach (Control control in this.Controls)
            {
                if (control is TextBox || control is Button || control is Label)
                {
                    control.BackColor = Color.FromArgb(28, 28, 28);
                    control.ForeColor = Color.White;
                }
            }
        }

        private void comboBox1_SelectedIndexChanged(object sender, EventArgs e)
        {
            label1.Text = comboBox1.Text;
        }

        private void label2_Click(object sender, EventArgs e)
        {

        }
    }
}
