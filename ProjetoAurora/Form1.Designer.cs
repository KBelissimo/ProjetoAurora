namespace ProjetoAurora
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
            numPotencia = new NumericUpDown();
            button1 = new Button();
            lblv = new Label();
            ((System.ComponentModel.ISupportInitialize)numPotencia).BeginInit();
            SuspendLayout();
            // 
            // label1
            // 
            label1.Anchor = AnchorStyles.Top | AnchorStyles.Left | AnchorStyles.Right;
            label1.AutoSize = true;
            label1.Location = new Point(303, 84);
            label1.Name = "label1";
            label1.Size = new Size(164, 15);
            label1.TabIndex = 0;
            label1.Text = "SISTEMA DE BORDO AURORA";
            label1.TextAlign = ContentAlignment.BottomLeft;
            // 
            // numPotencia
            // 
            numPotencia.Location = new Point(303, 136);
            numPotencia.Name = "numPotencia";
            numPotencia.Size = new Size(120, 23);
            numPotencia.TabIndex = 1;
            // 
            // button1
            // 
            button1.Location = new Point(429, 136);
            button1.Name = "button1";
            button1.Size = new Size(75, 23);
            button1.TabIndex = 2;
            button1.Text = "ACELERAR";
            button1.UseVisualStyleBackColor = true;
            button1.Click += button1_Click;
            // 
            // lblv
            // 
            lblv.AutoSize = true;
            lblv.Location = new Point(366, 238);
            lblv.Name = "lblv";
            lblv.Size = new Size(0, 15);
            lblv.TabIndex = 3;
            // 
            // Form1
            // 
            AutoScaleDimensions = new SizeF(7F, 15F);
            AutoScaleMode = AutoScaleMode.Font;
            ClientSize = new Size(800, 450);
            Controls.Add(lblv);
            Controls.Add(button1);
            Controls.Add(numPotencia);
            Controls.Add(label1);
            Name = "Form1";
            Text = "Form1";
            Load += Form1_Load;
            ((System.ComponentModel.ISupportInitialize)numPotencia).EndInit();
            ResumeLayout(false);
            PerformLayout();
        }

        #endregion

        private Label label1;
        private NumericUpDown numPotencia;
        private Button button1;
        private Label lblv;
    }
}