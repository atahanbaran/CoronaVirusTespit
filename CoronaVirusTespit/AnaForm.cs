namespace CoronaVirusTespit
{
    public partial class AnaForm : Form
    {
        public AnaForm()
        {
            InitializeComponent();
        }

        private void yardýmToolStripMenuItem_Click(object sender, EventArgs e)
        {
            YardýmForm form = new YardýmForm();
            form.Show();
        }

        private void belirtiTespitToolStripMenuItem_Click_1(object sender, EventArgs e)
        {
            BelirtiTespit form = new BelirtiTespit();
            form.MdiParent = this;
            form.WindowState = FormWindowState.Maximized;
            form.Show();
        }
    }
}