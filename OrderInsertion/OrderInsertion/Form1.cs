namespace OrderInsertion
{
    public partial class Form1 : Form
    {
        private int[] vectorins = new int[10]; // Arreglo con espacio para 10 elementos

        public Form1()
        {
            InitializeComponent();
        }
        private void btnOrdenar_Click(object sender, EventArgs e)
        {


            // Imprimir el vector desordenado en el ListBox
            listViewCambios.Items.Clear();
            listViewCambios.Items.Add("Vector original: " + string.Join(", ", vectorins));

            // Llamada al método de ordenamiento por inserción
            Insertionsort(vectorins);

            // Imprimir el vector ordenado en el ListBox
            listViewCambios.Items.Add("Vector ordenado: " + string.Join(", ", vectorins));
        }

        private void Insertionsort(int[] vectorins)
        {
            int largo = vectorins.Length;

            for (int i = 1; i < largo; i++)
            {
                int elemento = vectorins[i];
                int j = i - 1;

                // Mover elementos mayores a una posición adelante
                while (j >= 0 && vectorins[j] > elemento)
                {
                    vectorins[j + 1] = vectorins[j];
                    j--;
                    listViewCambios.Items.Add("Vector : " + string.Join(", ", vectorins));
                }
                vectorins[j + 1] = elemento;
                listViewCambios.Items.Add("Vector  " + string.Join(", ", vectorins));
            }
        }

        private void btnAgregar_Click(object sender, EventArgs e)
        {
            string[] entradas = txtNumero.Text.Split(',');

            if (entradas.Length == 10 && entradas.All(x => int.TryParse(x.Trim(), out _)))
            {
                vectorins = entradas.Select(int.Parse).ToArray(); // Llena el arreglo con los números

                txtNumero.Clear(); // Limpia el cuadro de texto
            }
            else
            {
                MessageBox.Show("Por favor, ingrese exactamente 10 números separados por comas.");
            }
        }

     

       
    }
}
