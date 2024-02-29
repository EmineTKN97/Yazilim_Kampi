namespace ThreadingDemo
{
    public partial class Form1 : Form
    {
        public Form1()
        {
            InitializeComponent();
        }

        private void BtnProcess1_Click(object sender, EventArgs e)
        {
            MessageBox.Show("iþlem 1 çalýþtý");
        }

        private void btnProcecess2_Click(object sender, EventArgs e)
        {
            MessageBox.Show("iþlem 2 çalýþtý");
        }
    }
}
