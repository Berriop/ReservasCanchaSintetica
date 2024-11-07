namespace ReservasCanchaSintetica
{
    partial class ConfirmarReserva
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
            numericdowm_aguas = new NumericUpDown();
            button1 = new Button();
            numericdown_balones = new NumericUpDown();
            label3 = new Label();
            label4 = new Label();
            ((System.ComponentModel.ISupportInitialize)numericdowm_aguas).BeginInit();
            ((System.ComponentModel.ISupportInitialize)numericdown_balones).BeginInit();
            SuspendLayout();
            // 
            // label1
            // 
            label1.AutoSize = true;
            label1.Font = new Font("Arial", 16F, FontStyle.Bold);
            label1.ForeColor = Color.Black;
            label1.Location = new Point(402, 61);
            label1.Name = "label1";
            label1.Size = new Size(143, 32);
            label1.TabIndex = 5;
            label1.Text = "RESERVA";
            // 
            // numericdowm_aguas
            // 
            numericdowm_aguas.Location = new Point(479, 216);
            numericdowm_aguas.Margin = new Padding(3, 4, 3, 4);
            numericdowm_aguas.Maximum = new decimal(new int[] { 10, 0, 0, 0 });
            numericdowm_aguas.Minimum = new decimal(new int[] { 1, 0, 0, 0 });
            numericdowm_aguas.Name = "numericdowm_aguas";
            numericdowm_aguas.Size = new Size(137, 27);
            numericdowm_aguas.TabIndex = 0;
            numericdowm_aguas.Value = new decimal(new int[] { 1, 0, 0, 0 });
            // 
            // button1
            // 
            button1.AutoSize = true;
            button1.Font = new Font("Arial", 12F, FontStyle.Bold);
            button1.Location = new Point(385, 500);
            button1.Margin = new Padding(3, 4, 3, 4);
            button1.Name = "button1";
            button1.Size = new Size(191, 39);
            button1.TabIndex = 0;
            button1.Text = "Confirmar reserva";
            button1.UseVisualStyleBackColor = true;
            button1.Click += button1_Click;
            // 
            // numericdown_balones
            // 
            numericdown_balones.Location = new Point(479, 279);
            numericdown_balones.Margin = new Padding(3, 4, 3, 4);
            numericdown_balones.Maximum = new decimal(new int[] { 10, 0, 0, 0 });
            numericdown_balones.Minimum = new decimal(new int[] { 1, 0, 0, 0 });
            numericdown_balones.Name = "numericdown_balones";
            numericdown_balones.Size = new Size(137, 27);
            numericdown_balones.TabIndex = 7;
            numericdown_balones.Value = new decimal(new int[] { 1, 0, 0, 0 });
            // 
            // label3
            // 
            label3.AutoSize = true;
            label3.Location = new Point(322, 223);
            label3.Name = "label3";
            label3.Size = new Size(114, 20);
            label3.TabIndex = 8;
            label3.Text = "Cantidad Aguas";
            // 
            // label4
            // 
            label4.AutoSize = true;
            label4.Location = new Point(322, 286);
            label4.Name = "label4";
            label4.Size = new Size(125, 20);
            label4.TabIndex = 9;
            label4.Text = "Cantidad Balones";
            // 
            // ConfirmarReserva
            // 
            AutoScaleDimensions = new SizeF(8F, 20F);
            AutoScaleMode = AutoScaleMode.Font;
            BackgroundImage = Properties.Resources.canchafondo;
            BackgroundImageLayout = ImageLayout.Stretch;
            ClientSize = new Size(914, 600);
            Controls.Add(label4);
            Controls.Add(label3);
            Controls.Add(numericdown_balones);
            Controls.Add(button1);
            Controls.Add(numericdowm_aguas);
            Controls.Add(label1);
            Margin = new Padding(3, 4, 3, 4);
            Name = "ConfirmarReserva";
            Text = "ConfirmarReserva";
            ((System.ComponentModel.ISupportInitialize)numericdowm_aguas).EndInit();
            ((System.ComponentModel.ISupportInitialize)numericdown_balones).EndInit();
            ResumeLayout(false);
            PerformLayout();
        }

        #endregion

        private Label label1;
        private NumericUpDown numericdowm_aguas;
        private Button button1;
        private NumericUpDown numericdown_balones;
        private Label label3;
        private Label label4;
    }
}