using System.Drawing.Text;

namespace vecchi_cassaforte
{
    public partial class Form1 : Form
    {
        private Cassaforte cassaforte;
        public Form1()
        {
            cassaforte = new Cassaforte(01, "Il boss delle casseforti", "best", "A123B6A123B6", 0);

            InitializeComponent();
        }


        private void buttonApri_Click(object sender, EventArgs e)
        {
            cassaforte.Apri(Convert.ToInt32(textBoxCodUtente.Text));
            AggiornaForm();
        }

        private void buttonChiudi_Click(object sender, EventArgs e)
        {
            cassaforte.Chiudi();
            AggiornaForm();
        }

        private void buttonSblocca_Click(object sender, EventArgs e)
        {
            cassaforte.Sblocca(textBoxCodSblocco.Text);
            AggiornaForm();
        }

        private void AggiornaForm()
        {
            if (cassaforte.IsOpen)
            {
                labelStato.Text = "Aperto";
            }
            else 
            {
                labelStato.Text = "Chiuso";
            }
            labelTentativi.Text = cassaforte.Tentativi.ToString();
        }

        private void buttonImposta_Click(object sender, EventArgs e)
        {
            cassaforte.ImpostaCod(Convert.ToInt32(textBoxImpostaCod.Text));
            AggiornaForm();
        }

        private void Form1_Load(object sender, EventArgs e)
        {
            cassaforte.Chiudi();
            AggiornaForm();
        }
    }
}
