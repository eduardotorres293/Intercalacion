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
                // Crear instancia del intercalador
                Intercalacion intercalador = new Intercalacion();

                // Obtener los textos de los dos cuadros de texto
                string texto1 = txtArchivo1.Text;
                string texto2 = txtArchivo2.Text;

                // Separar los números de cada cuadro de texto usando la coma como delimitador
                string[] numeros1 = texto1.Split(',');
                string[] numeros2 = texto2.Split(',');

                // Convertir las cadenas a enteros, eliminando espacios innecesarios
                var numerosConvertidos1 = numeros1.Select(num => Convert.ToInt32(num.Trim())).ToList();
                var numerosConvertidos2 = numeros2.Select(num => Convert.ToInt32(num.Trim())).ToList();

                // Realizar la intercalación de las dos listas
                List<int> listaIntercalada = intercalador.IntercalarListas(numerosConvertidos1, numerosConvertidos2);

                // Mostrar los números intercalados en el TextBox de resultado
                txtResultado.Text = string.Join(", ", listaIntercalada);
            }
            catch (Exception ex)
            {
                // Capturar cualquier excepción y mostrar un mensaje
                MessageBox.Show($"Ocurrió un error: {ex.Message}");
            }
        }
    }
}
