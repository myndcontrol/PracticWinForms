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
            Random r = new Random();
            int N = r.Next(1, 5);
            switch (N)
            {
                case 1:
                    ChangeColorButton.BackColor = Color.Pink;
                    break;
                case 2:
                    ChangeColorButton.BackColor = Color.DeepSkyBlue;
                    break;
                case 3:
                    ChangeColorButton.BackColor = Color.GreenYellow;
                    break;
                case 4:
                    ChangeColorButton.BackColor = Color.Green;
                    break;
                case 5: ChangeColorButton.BackColor = Color.Lavender;
                    break;
            }
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
