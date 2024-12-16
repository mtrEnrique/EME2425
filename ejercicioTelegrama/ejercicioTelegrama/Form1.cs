namespace ejercicioTelegrama
{
    public partial class Form1 : Form
    {
        public Form1()
        {
            InitializeComponent();
        }

        private void btnCalcularPrecio_Click(object sender, EventArgs e)
        {
            string textoTelegrama;
            char tipoTelegrama = ' ';
            int numPalabras = 0;
            double coste;
            //Leo el telegrama 
            textoTelegrama = txtTelegrama.Text;
            // telegrama urgente?

            if (chkUrgente.Checked)
            {
                chkOrdinario.Checked = false;
                tipoTelegrama = 'u';
            }
            if (chkOrdinario.Checked)
            {
                tipoTelegrama = 'o';
                chkUrgente.Checked = false;
            }
            if (!(chkOrdinario.Checked || chkUrgente.Checked))
            {
                throw new Exception("Debes seleccionar el tipo de telegrama que quieres enviar.");
            }
            //Obtengo el número de palabras que forma el telegrama 
            numPalabras = textoTelegrama.Length;
            //Si el telegrama es ordinario
            if (tipoTelegrama == 'o')
            {
                if (numPalabras <= 50)
                {
                    coste = 2.5;
                }
                else
                {
                    coste = 0.5 * numPalabras;
                }
            }
            else
            //Si el telegrama es urgente
            {
                if (tipoTelegrama == 'u')
                {
                    if (numPalabras <= 10)
                    {
                        coste = 5;
                    }
                    else
                    {
                        coste = 5 + 0.75 * (numPalabras - 10);
                    }
                }
                else
                {
                    coste = 10;
                }
            }
            txtPrecio.Text = coste.ToString() + " euros";
        }

        private void chkOrdinario_CheckedChanged(object sender, EventArgs e)
        {

        }
    }
}
