namespace WinFormsApp1
{
    public partial class Form1 : Form
    {
        public Form1()
        {
            InitializeComponent();
        }

        private void ChangeColorButtonClick(object sender, EventArgs e)
        {
            ChangeColorButton.BackColor = Color.DeepSkyBlue;
        }

        private void ChangeColorButton_MouseEnter(object sender, EventArgs e)
        {
            ChangeColorButton.BackColor = Color.Gray;
        }

        private void ChangeColorButton_MouseLeave(object sender, EventArgs e)
        {
            ChangeColorButton.BackColor = Color.Transparent;
        }
    }
}