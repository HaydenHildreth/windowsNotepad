namespace notepad
{
    public partial class Form1 : Form
    {
        public Form1()
        {
            InitializeComponent();
            this.Text = "notepad";
        }

        private void btnSubmit_Click(object sender, EventArgs e)
        {
            string filename = textboxFilename.Text;
            File.WriteAllText($"{filename}.txt", textboxNotepad.Text);
        }
    }
}