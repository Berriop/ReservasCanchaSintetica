namespace ReservasCanchaSintetica
{
    partial class Pagos
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
            label2 = new Label();
            label3 = new Label();
            label4 = new Label();
            dateTimePicker1 = new DateTimePicker();
            label5 = new Label();
            label6 = new Label();
            label7 = new Label();
            button1 = new Button();
            SuspendLayout();
            // 
            // label1
            // 
            label1.AutoSize = true;
            label1.Font = new Font("Arial", 16F, FontStyle.Bold);
            label1.ForeColor = Color.Black;
            label1.Location = new Point(352, 46);
            label1.Name = "label1";
            label1.Size = new Size(172, 26);
            label1.TabIndex = 5;
            label1.Text = "ESTADISTICAS";
            // 
            // label2
            // 
            label2.AutoSize = true;
            label2.Font = new Font("Arial", 14F);
            label2.Location = new Point(83, 117);
            label2.Name = "label2";
            label2.Size = new Size(165, 22);
            label2.TabIndex = 4;
            label2.Text = "Ganancias totales:";
            // 
            // label3
            // 
            label3.Location = new Point(323, 117);
            label3.Name = "label3";
            label3.Size = new Size(130, 22);
            label3.TabIndex = 2;
            label3.Text = "PAGO";
            // 
            // label4
            // 
            label4.AutoSize = true;
            label4.Font = new Font("Arial", 14F);
            label4.Location = new Point(83, 190);
            label4.Name = "label4";
            label4.Size = new Size(195, 22);
            label4.TabIndex = 3;
            label4.Text = "Cantidad de reservas:";
            // 
            // dateTimePicker1
            // 
            dateTimePicker1.CustomFormat = "MMMM yyyy";
            dateTimePicker1.Format = DateTimePickerFormat.Custom;
            dateTimePicker1.Location = new Point(585, 109);
            dateTimePicker1.Name = "dateTimePicker1";
            dateTimePicker1.Size = new Size(150, 23);
            dateTimePicker1.TabIndex = 4;
            // 
            // label5
            // 
            label5.Location = new Point(323, 190);
            label5.Name = "label5";
            label5.Size = new Size(130, 22);
            label5.TabIndex = 6;
            label5.Text = "label5";
            // 
            // label6
            // 
            label6.AutoSize = true;
            label6.Font = new Font("Arial", 14F);
            label6.Location = new Point(83, 274);
            label6.Name = "label6";
            label6.Size = new Size(146, 22);
            label6.TabIndex = 7;
            label6.Text = "Pago promedio:";
            // 
            // label7
            // 
            label7.Location = new Point(323, 274);
            label7.Name = "label7";
            label7.Size = new Size(130, 22);
            label7.TabIndex = 8;
            label7.Text = "label7";
            // 
            // button1
            // 
            button1.Location = new Point(673, 401);
            button1.Font = new Font("Arial", 10);
            button1.Name = "button1";
            button1.AutoSize = true;
            button1.TabIndex = 3;
            button1.Text = "Regresar";
            button1.UseVisualStyleBackColor = true;
            // 
            // Pagos
            // 
            AutoScaleDimensions = new SizeF(7F, 15F);
            AutoScaleMode = AutoScaleMode.Font;
            BackgroundImage = Properties.Resources.canchafondo;
            BackgroundImageLayout = ImageLayout.Stretch;
            ClientSize = new Size(800, 450);
            Controls.Add(button1);
            Controls.Add(label7);
            Controls.Add(label6);
            Controls.Add(label5);
            Controls.Add(dateTimePicker1);
            Controls.Add(label4);
            Controls.Add(label3);
            Controls.Add(label2);
            Controls.Add(label1);
            Name = "Pagos";
            Text = "Pagos";
            ResumeLayout(false);
            PerformLayout();
        }

        #endregion

        private Label label1;
        private Label label2;
        private Label label3;
        private Label label4;
        private DateTimePicker dateTimePicker1;
        private Label label5;
        private Label label6;
        private Label label7;
        private Button button1;
    }
}