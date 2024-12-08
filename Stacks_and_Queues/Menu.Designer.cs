namespace Stacks_and_Queues
{
    partial class Menu
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
            btnStack = new Button();
            button2 = new Button();
            btnQueue = new Button();
            label1 = new Label();
            groupBox1 = new GroupBox();
            groupBox1.SuspendLayout();
            SuspendLayout();
            // 
            // btnStack
            // 
            btnStack.Font = new Font("Segoe UI", 9.75F);
            btnStack.Location = new Point(65, 77);
            btnStack.Name = "btnStack";
            btnStack.Size = new Size(150, 47);
            btnStack.TabIndex = 0;
            btnStack.Text = "Stack";
            btnStack.UseVisualStyleBackColor = true;
            btnStack.Click += btnStack_Click;
            // 
            // button2
            // 
            button2.Font = new Font("Segoe UI", 9.75F);
            button2.Location = new Point(322, 175);
            button2.Name = "button2";
            button2.Size = new Size(0, 0);
            button2.TabIndex = 1;
            button2.Text = "button2";
            button2.UseVisualStyleBackColor = true;
            // 
            // btnQueue
            // 
            btnQueue.Font = new Font("Segoe UI", 9.75F);
            btnQueue.Location = new Point(65, 130);
            btnQueue.Name = "btnQueue";
            btnQueue.Size = new Size(150, 47);
            btnQueue.TabIndex = 2;
            btnQueue.Text = "Queue";
            btnQueue.UseVisualStyleBackColor = true;
            btnQueue.Click += btnQueue_Click;
            // 
            // label1
            // 
            label1.AutoSize = true;
            label1.Font = new Font("Segoe UI", 12F, FontStyle.Regular, GraphicsUnit.Point, 0);
            label1.Location = new Point(112, 40);
            label1.Name = "label1";
            label1.Size = new Size(57, 21);
            label1.TabIndex = 3;
            label1.Text = "STATIC";
            // 
            // groupBox1
            // 
            groupBox1.Controls.Add(btnQueue);
            groupBox1.Controls.Add(label1);
            groupBox1.Controls.Add(btnStack);
            groupBox1.Location = new Point(103, 58);
            groupBox1.Name = "groupBox1";
            groupBox1.Size = new Size(280, 198);
            groupBox1.TabIndex = 4;
            groupBox1.TabStop = false;
            // 
            // Menu
            // 
            AutoScaleDimensions = new SizeF(7F, 15F);
            AutoScaleMode = AutoScaleMode.Font;
            ClientSize = new Size(513, 306);
            Controls.Add(groupBox1);
            Controls.Add(button2);
            Name = "Menu";
            Text = "Menu";
            groupBox1.ResumeLayout(false);
            groupBox1.PerformLayout();
            ResumeLayout(false);
        }

        #endregion

        private Button btnStack;
        private Button button2;
        private Button btnQueue;
        private Label label1;
        private GroupBox groupBox1;
    }
}