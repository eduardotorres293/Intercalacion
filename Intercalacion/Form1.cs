namespace Intercalacion
{
    public partial class Form1 : Form
    {
        public Form1()
        {
            InitializeComponent();
        }

        private void btnIntercalar_Click(object sender, EventArgs e)
        {
            try
            {
                Intercalacion intercalador = new Intercalacion();

                string texto1 = txtArchivo1.Text;
                string texto2 = txtArchivo2.Text;

                string[] numeros1 = texto1.Split(',');
                string[] numeros2 = texto2.Split(',');

                var numerosConvertidos1 = numeros1.Select(num => Convert.ToInt32(num.Trim())).ToList();
                var numerosConvertidos2 = numeros2.Select(num => Convert.ToInt32(num.Trim())).ToList();

                List<int> listaIntercalada = intercalador.IntercalarListas(numerosConvertidos1, numerosConvertidos2);

                txtResultado.Text = string.Join(", ", listaIntercalada);
            }
            catch (Exception ex)
            {
                MessageBox.Show($"Inserta un elemento válido");
            }
        }
    }
}
