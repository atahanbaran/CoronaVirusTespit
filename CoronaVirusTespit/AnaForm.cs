namespace CoronaVirusTespit
{
    public partial class AnaForm : Form
    {
        public AnaForm()
        {
            InitializeComponent();
        }

        private void yard�mToolStripMenuItem_Click(object sender, EventArgs e)
        {
            Yard�mForm form = new Yard�mForm();
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