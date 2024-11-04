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
            numericUpDown1 = new NumericUpDown();
            label2 = new Label();
            button1 = new Button();
            comboBox1 = new ComboBox();
            button2 = new Button();
            ((System.ComponentModel.ISupportInitialize)numericUpDown1).BeginInit();
            SuspendLayout();
            // 
            // label1
            // 
            label1.AutoSize = true;
            label1.Font = new Font("Arial", 16F, FontStyle.Bold);
            label1.ForeColor = Color.Black;
            label1.Location = new Point(352, 46);
            label1.Name = "label1";
            label1.Size = new Size(117, 26);
            label1.TabIndex = 5;
            label1.Text = "RESERVA";
            // 
            // numericUpDown1
            // 
            numericUpDown1.Location = new Point(419, 162);
            numericUpDown1.Maximum = new decimal(new int[] { 10, 0, 0, 0 });
            numericUpDown1.Minimum = new decimal(new int[] { 1, 0, 0, 0 });
            numericUpDown1.Name = "numericUpDown1";
            numericUpDown1.Size = new Size(120, 23);
            numericUpDown1.TabIndex = 0;
            numericUpDown1.Value = new decimal(new int[] { 1, 0, 0, 0 });
            // 
            // label2
            // 
            label2.AutoSize = true;
            label2.Font = new Font("Arial", 14F);
            label2.Location = new Point(69, 377);
            label2.Name = "label2";
            label2.Size = new Size(55, 22);
            label2.TabIndex = 4;
            label2.Text = "Total:";
            // 
            // button1
            // 
            button1.AutoSize = true;
            button1.Font = new Font("Arial", 12F, FontStyle.Bold);
            button1.Location = new Point(337, 375);
            button1.Name = "button1";
            button1.Size = new Size(156, 29);
            button1.TabIndex = 0;
            button1.Text = "Confirmar reserva";
            button1.UseVisualStyleBackColor = true;
            // 
            // comboBox1
            // 
            comboBox1.FormattingEnabled = true;
            comboBox1.Location = new Point(242, 162);
            comboBox1.Name = "comboBox1";
            comboBox1.Size = new Size(121, 23);
            comboBox1.TabIndex = 6;
            // 
            // button2
            // 
            button2.Location = new Point(673, 401);
            button2.Font = new Font("Arial", 10);
            button2.Name = "button2";
            button2.AutoSize = true;
            button2.TabIndex = 3;
            button2.Text = "Regresar";
            button2.UseVisualStyleBackColor = true;
            // 
            // ConfirmarReserva
            // 
            AutoScaleDimensions = new SizeF(7F, 15F);
            AutoScaleMode = AutoScaleMode.Font;
            BackgroundImage = Properties.Resources.canchafondo;
            BackgroundImageLayout = ImageLayout.Stretch;
            ClientSize = new Size(800, 450);
            Controls.Add(button2);
            Controls.Add(comboBox1);
            Controls.Add(button1);
            Controls.Add(label2);
            Controls.Add(numericUpDown1);
            Controls.Add(label1);
            Name = "ConfirmarReserva";
            Text = "ConfirmarReserva";
            ((System.ComponentModel.ISupportInitialize)numericUpDown1).EndInit();
            ResumeLayout(false);
            PerformLayout();
        }

        #endregion

        private Label label1;
        private NumericUpDown numericUpDown1;
        private Label label2;
        private Button button1;
        private ComboBox comboBox1;
        private Button button2;
    }
}