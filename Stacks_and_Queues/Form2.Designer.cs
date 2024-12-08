namespace Stacks_and_Queues
{
    partial class Form2
    {
        /// <summary>
        /// Required designer variable.
        /// </summary>
        private System.ComponentModel.IContainer components = null;

        /// <summary>
        /// Clean up any resources being used.
        /// </summary>
        /// <param name="disposing">true if managed resources should be disposed; otherwise, false.</param>
        protected override void Dispose(bool disposing)
        {
            if (disposing && (components != null))
            {
                components.Dispose();
            }
            base.Dispose(disposing);
        }

        #region Windows Form Designer generated code

        /// <summary>
        /// Required method for Designer support - do not modify
        /// the contents of this method with the code editor.
        /// </summary>
        private void InitializeComponent()
        {
            label1 = new Label();
            Queue = new GroupBox();
            btnRear = new Button();
            btnPeek = new Button();
            btnDequeue = new Button();
            btnEnqueue = new Button();
            txtNumber = new TextBox();
            lblStatus = new Label();
            Queue.SuspendLayout();
            SuspendLayout();
            // 
            // label1
            // 
            label1.AutoSize = true;
            label1.Location = new Point(28, 39);
            label1.Name = "label1";
            label1.Size = new Size(51, 15);
            label1.TabIndex = 0;
            label1.Text = "Number";
            // 
            // Queue
            // 
            Queue.BackColor = Color.RosyBrown;
            Queue.Controls.Add(lblStatus);
            Queue.Controls.Add(btnRear);
            Queue.Controls.Add(btnPeek);
            Queue.Controls.Add(btnDequeue);
            Queue.Controls.Add(btnEnqueue);
            Queue.Controls.Add(txtNumber);
            Queue.Controls.Add(label1);
            Queue.Location = new Point(59, 51);
            Queue.Name = "Queue";
            Queue.Size = new Size(378, 234);
            Queue.TabIndex = 1;
            Queue.TabStop = false;
            Queue.Text = "Queue";
            // 
            // btnRear
            // 
            btnRear.Location = new Point(46, 165);
            btnRear.Name = "btnRear";
            btnRear.Size = new Size(75, 23);
            btnRear.TabIndex = 5;
            btnRear.Text = "Rear";
            btnRear.UseVisualStyleBackColor = true;
            btnRear.Click += btnRear_Click;
            // 
            // btnPeek
            // 
            btnPeek.Location = new Point(46, 136);
            btnPeek.Name = "btnPeek";
            btnPeek.Size = new Size(75, 23);
            btnPeek.TabIndex = 4;
            btnPeek.Text = "Peek";
            btnPeek.UseVisualStyleBackColor = true;
            btnPeek.Click += btnPeek_Click;
            // 
            // btnDequeue
            // 
            btnDequeue.Location = new Point(46, 107);
            btnDequeue.Name = "btnDequeue";
            btnDequeue.Size = new Size(75, 23);
            btnDequeue.TabIndex = 3;
            btnDequeue.Text = "Dequeue";
            btnDequeue.UseVisualStyleBackColor = true;
            btnDequeue.Click += btnDequeue_Click;
            // 
            // btnEnqueue
            // 
            btnEnqueue.Location = new Point(46, 78);
            btnEnqueue.Name = "btnEnqueue";
            btnEnqueue.Size = new Size(75, 23);
            btnEnqueue.TabIndex = 2;
            btnEnqueue.Text = "Enqueue";
            btnEnqueue.UseVisualStyleBackColor = true;
            btnEnqueue.Click += btnEnqueue_Click;
            // 
            // txtNumber
            // 
            txtNumber.Location = new Point(85, 36);
            txtNumber.Name = "txtNumber";
            txtNumber.Size = new Size(100, 23);
            txtNumber.TabIndex = 1;
            // 
            // lblStatus
            // 
            lblStatus.AutoSize = true;
            lblStatus.Font = new Font("Segoe UI", 11.25F, FontStyle.Regular, GraphicsUnit.Point, 0);
            lblStatus.Location = new Point(158, 81);
            lblStatus.Name = "lblStatus";
            lblStatus.Size = new Size(49, 20);
            lblStatus.TabIndex = 2;
            lblStatus.Text = "Status";
            // 
            // Form2
            // 
            AutoScaleDimensions = new SizeF(7F, 15F);
            AutoScaleMode = AutoScaleMode.Font;
            BackColor = SystemColors.Control;
            ClientSize = new Size(578, 311);
            Controls.Add(Queue);
            Name = "Form2";
            Text = "Form2";
            Queue.ResumeLayout(false);
            Queue.PerformLayout();
            ResumeLayout(false);
        }

        #endregion

        private Label label1;
        private GroupBox Queue;
        private TextBox txtNumber;
        private Button btnEnqueue;
        private Button btnDequeue;
        private Button btnRear;
        private Button btnPeek;
        private Label lblStatus;
    }
}