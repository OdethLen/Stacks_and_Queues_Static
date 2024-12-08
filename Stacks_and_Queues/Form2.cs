
namespace Stacks_and_Queues
{
    
    public partial class Form2 : Form
    {
        Queue queue;
        public Form2()
        {
            InitializeComponent();
            queue = new Queue(5);
        }

        private void btnEnqueue_Click(object sender, EventArgs e)
        {
            int value = Convert.ToInt32(txtNumber.Text);
            queue.Enqueue(value);
            MessageBox.Show("Value " + value + " Added to the queue.");
            UpdateQueueStatus();
            queue.DisplayQueue();
        }

        private void btnDequeue_Click(object sender, EventArgs e)
        {
            int value = queue.Dequeue();

            if (value != -1) // Si no está vacío.
            {
                MessageBox.Show("Value " + value + " was removed from the queue.");
                UpdateQueueStatus(); // Actualizar el estado del Label.
                queue.DisplayQueue();
            }
            
        }

        private void btnPeek_Click(object sender, EventArgs e)
        {
            int value = queue.Peek();
            if (queue.IsEmpty())
            {
                MessageBox.Show("Queue is empty, no element in front.");
                return;
            }
            MessageBox.Show("The front element is:"  + value );
        }

        private void btnRear_Click(object sender, EventArgs e)
        {
            int value= queue.Rear();
            if(queue.IsEmpty())
            {
                MessageBox.Show("Queue is empty, no last element.");
                return;
            }
            MessageBox.Show("The last element is: " + value );
        }

      
      

        private void UpdateQueueStatus()
        {
            lblStatus.Text = "\nSize: " + queue.Size() +
                             "\nEmpty: " + queue.IsEmpty() +
                             "\nFull: " + queue.IsFull();
        }

    }
}
