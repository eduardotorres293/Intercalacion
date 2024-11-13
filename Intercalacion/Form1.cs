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

                // Separar los n�meros de cada cuadro de texto usando la coma como delimitador
                string[] numeros1 = texto1.Split(',');
                string[] numeros2 = texto2.Split(',');

                // Convertir las cadenas a enteros, eliminando espacios innecesarios
                var numerosConvertidos1 = numeros1.Select(num => Convert.ToInt32(num.Trim())).ToList();
                var numerosConvertidos2 = numeros2.Select(num => Convert.ToInt32(num.Trim())).ToList();

                // Realizar la intercalaci�n de las dos listas
                List<int> listaIntercalada = intercalador.IntercalarListas(numerosConvertidos1, numerosConvertidos2);

                // Mostrar los n�meros intercalados en el TextBox de resultado
                txtResultado.Text = string.Join(", ", listaIntercalada);
            }
            catch (Exception ex)
            {
                // Capturar cualquier excepci�n y mostrar un mensaje
                MessageBox.Show($"Ocurri� un error: {ex.Message}");
            }
        }
    }
}
