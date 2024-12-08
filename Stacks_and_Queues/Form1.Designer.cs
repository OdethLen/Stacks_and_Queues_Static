namespace Stacks_and_Queues
{
    partial class Form1
    {
        /// <summary>
        ///  Required designer variable.
        /// </summary>
        private System.ComponentModel.IContainer components = null;

        /// <summary>
        ///  Clean up any resources being used.
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
        ///  Required method for Designer support - do not modify
        ///  the contents of this method with the code editor.
        /// </summary>
        private void InitializeComponent()
        {
            label1 = new Label();
            btnPush = new Button();
            txtNumber = new TextBox();
            btnPop = new Button();
            btnTop = new Button();
            groupBox1 = new GroupBox();
            btnSize = new Button();
            btnIsEmpty = new Button();
            groupBox1.SuspendLayout();
            SuspendLayout();
            // 
            // label1
            // 
            label1.AutoSize = true;
            label1.Location = new Point(32, 38);
            label1.Name = "label1";
            label1.Size = new Size(51, 15);
            label1.TabIndex = 0;
            label1.Text = "Number";
            // 
            // btnPush
            // 
            btnPush.Location = new Point(47, 73);
            btnPush.Name = "btnPush";
            btnPush.Size = new Size(91, 28);
            btnPush.TabIndex = 1;
            btnPush.Text = "Push";
            btnPush.UseVisualStyleBackColor = true;
            btnPush.Click += btnPush_Click;
            // 
            // txtNumber
            // 
            txtNumber.Location = new Point(89, 35);
            txtNumber.Name = "txtNumber";
            txtNumber.Size = new Size(100, 23);
            txtNumber.TabIndex = 2;
            // 
            // btnPop
            // 
            btnPop.Location = new Point(47, 107);
            btnPop.Name = "btnPop";
            btnPop.Size = new Size(91, 28);
            btnPop.TabIndex = 3;
            btnPop.Text = "Pop";
            btnPop.UseVisualStyleBackColor = true;
            btnPop.Click += btnPop_Click;
            // 
            // btnTop
            // 
            btnTop.Location = new Point(47, 141);
            btnTop.Name = "btnTop";
            btnTop.Size = new Size(91, 28);
            btnTop.TabIndex = 4;
            btnTop.Text = "Top";
            btnTop.UseVisualStyleBackColor = true;
            btnTop.Click += btnTop_Click;
            // 
            // groupBox1
            // 
            groupBox1.BackColor = SystemColors.ActiveCaption;
            groupBox1.Controls.Add(btnSize);
            groupBox1.Controls.Add(btnIsEmpty);
            groupBox1.Controls.Add(txtNumber);
            groupBox1.Controls.Add(btnTop);
            groupBox1.Controls.Add(label1);
            groupBox1.Controls.Add(btnPop);
            groupBox1.Controls.Add(btnPush);
            groupBox1.Location = new Point(95, 46);
            groupBox1.Name = "groupBox1";
            groupBox1.Size = new Size(295, 206);
            groupBox1.TabIndex = 5;
            groupBox1.TabStop = false;
            groupBox1.Text = "Stack";
            // 
            // btnSize
            // 
            btnSize.Location = new Point(144, 107);
            btnSize.Name = "btnSize";
            btnSize.Size = new Size(91, 28);
            btnSize.TabIndex = 6;
            btnSize.Text = "Size";
            btnSize.UseVisualStyleBackColor = true;
            btnSize.Click += btnSize_Click;
            // 
            // btnIsEmpty
            // 
            btnIsEmpty.Location = new Point(144, 73);
            btnIsEmpty.Name = "btnIsEmpty";
            btnIsEmpty.Size = new Size(91, 28);
            btnIsEmpty.TabIndex = 5;
            btnIsEmpty.Text = "Is Empty";
            btnIsEmpty.UseVisualStyleBackColor = true;
            btnIsEmpty.Click += btnIsEmpty_Click;
            // 
            // Form1
            // 
            AutoScaleDimensions = new SizeF(7F, 15F);
            AutoScaleMode = AutoScaleMode.Font;
            ClientSize = new Size(513, 306);
            Controls.Add(groupBox1);
            Name = "Form1";
            Text = "Form1";
            Load += Form1_Load;
            groupBox1.ResumeLayout(false);
            groupBox1.PerformLayout();
            ResumeLayout(false);
        }

        #endregion

        private Label label1;
        private Button btnPush;
        private TextBox txtNumber;
        private Button btnPop;
        private Button btnTop;
        private GroupBox groupBox1;
        private Button btnIsEmpty;
        private Button btnSize;
    }
}
