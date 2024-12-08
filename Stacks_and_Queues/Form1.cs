namespace Stacks_and_Queues
{
    public partial class Form1 : Form
    {
        Stack stack;
        public Form1()
        {
            InitializeComponent();
            stack = new Stack(5);
        }

        private void Form1_Load(object sender, EventArgs e)
        {

        }

        private void btnPush_Click(object sender, EventArgs e)
        {
            try
            {
                int value = Convert.ToInt32(txtNumber.Text); // Convertimos el texto ingresado
                stack.Push(value); // Agregamos el valor a la pila
                MessageBox.Show("Element " + value + " added to stack.");
                UpdateStackDisplay(); // Actualizamos la visualización
                txtNumber.Clear(); // Limpiamos el cuadro de texto
            }
            catch (Exception)
            {
                MessageBox.Show("Please, Enter a valid number .");
            }
        }

        private void UpdateStackDisplay()
        {
            txtNumber.Text = stack.GetElements(); // Mostramos los elementos en un TextBox
        }

        private void btnPop_Click(object sender, EventArgs e)
        {

            try
            {
                int removed = stack.Pop(); // Eliminamos el elemento superior
                MessageBox.Show("Elment " + removed + " removed from the stack.");
                UpdateStackDisplay(); // Actualizamos la visualización
            }
            catch (InvalidOperationException ex)
            {
                MessageBox.Show(ex.Message);
            }
        }

        private void btnTop_Click(object sender, EventArgs e)
        {
            try
            {
                int topValue = stack.Top(); // Obtenemos el elemento superior
                MessageBox.Show("Element at the top of the stack: " + topValue);
            }
            catch (InvalidOperationException ex)
            {
                MessageBox.Show(ex.Message);
            }
        }


        private void btnIsEmpty_Click(object sender, EventArgs e)
        {
            if (stack.IsEmpty())
            {
                MessageBox.Show("The stack is empty.");
            }
            else
            {
                MessageBox.Show("The stack is not empty.");
            }
        }

        private void btnSize_Click(object sender, EventArgs e)
        {
            if (stack == null)
            {
                MessageBox.Show("The stack has not been initialized.");
                return;
            }
            MessageBox.Show("Size: " + stack.GetSize());
        }
    }
}
