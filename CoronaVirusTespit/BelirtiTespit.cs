namespace CoronaVirusTespit
{
    public partial class BelirtiTespit : Form
    {
        string[] _sehirler = new string[3]
        {
            "Ankara", "İstanbul", "İzmir"
        };
        string _sonuc;
        public BelirtiTespit()
        {
            InitializeComponent();
        }

        private void BelirtiTespit_Load(object sender, EventArgs e)
        {
            Text = "Belirti Tespit.";
            //1.yontem
            //ddlSehir.Items.Add("Ankara");
            //ddlSehir.Items.Add("İstanbul");
            //ddlSehir.Items.Add("İzmir");
            
            //2.yontem
            //foreach (string sehir in _sehirler)
            //{
            //    ddlSehir.Items.Add(sehir);
            //}
            ddlSehir.Items.AddRange(_sehirler);

            ddlSehir.SelectedIndex = 0;
            dtpTarih.Value = DateTime.Now;
            tbAdi.Focus();

            rbKadın.Checked = true;


        }

        private void button1_Click(object sender, EventArgs e)
        {
            KontrolEt();
        }

        private void KontrolEt()
        {
            _sonuc = "";
            if (rbKadın.Checked)
                _sonuc += "Bayan";
            else 
                _sonuc += "Bay";
            _sonuc += tbAdi.Text + " " + tbSoyadi.Text + "\r\n";
            _sonuc += "Şehriniz " + ddlSehir.Text + "\r\n";
            _sonuc += "Yaşınız " + NudYas.Value + "\r\n";
            _sonuc += "Kontrol Tarihi" + dtpTarih.Value.ToLongDateString() + "\r\n";
            if (cbAtes.Checked || (cbOksuruk.Checked && cbBoğazAgrısı.Checked))
            {
                _sonuc += "Koronavirus olabilirsiniz.";
            }
            else
            {
                _sonuc += "Koronavirus olmayabilirsiniz.";
            }

        }
    }
}
