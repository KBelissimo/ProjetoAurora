namespace ProjetoAurora
{
    partial class Form1
    {
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
            trackOxigenio = new TrackBar();
            lblPor = new Label();
            ((System.ComponentModel.ISupportInitialize)trackOxigenio).BeginInit();
            SuspendLayout();
            // 
            // trackOxigenio
            // 
            trackOxigenio.LargeChange = 1;
            trackOxigenio.Location = new Point(315, 258);
            trackOxigenio.Maximum = 100;
            trackOxigenio.Name = "trackOxigenio";
            trackOxigenio.Size = new Size(104, 45);
            trackOxigenio.TabIndex = 0;
            trackOxigenio.Value = 10;
            trackOxigenio.Scroll += trackOxigenio_Scroll;
            // 
            // lblPor
            // 
            lblPor.AutoSize = true;
            lblPor.ForeColor = SystemColors.ButtonHighlight;
            lblPor.Location = new Point(443, 258);
            lblPor.Name = "lblPor";
            lblPor.Size = new Size(0, 15);
            lblPor.TabIndex = 1;
            lblPor.Click += label1_Click;
            // 
            // Form1
            // 
            AutoScaleDimensions = new SizeF(7F, 15F);
            AutoScaleMode = AutoScaleMode.Font;
            BackColor = Color.Navy;
            ClientSize = new Size(800, 450);
            Controls.Add(lblPor);
            Controls.Add(trackOxigenio);
            Name = "Form1";
            Text = "Form1";
            ((System.ComponentModel.ISupportInitialize)trackOxigenio).EndInit();
            ResumeLayout(false);
            PerformLayout();
        }

        #endregion

        private TrackBar trackOxigenio;
        private Label lblPor;
    }
}
