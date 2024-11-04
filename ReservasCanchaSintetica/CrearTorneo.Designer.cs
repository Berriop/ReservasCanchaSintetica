namespace ReservasCanchaSintetica
{
    partial class CrearTorneo
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
            dateTimePicker1 = new DateTimePicker();
            dateTimePicker2 = new DateTimePicker();
            label2 = new Label();
            label3 = new Label();
            label4 = new Label();
            label5 = new Label();
            label6 = new Label();
            textBox1 = new TextBox();
            textBox2 = new TextBox();
            textBox3 = new TextBox();
            button1 = new Button();
            button2 = new Button();
            SuspendLayout();
            // 
            // label1
            // 
            label1.AutoSize = true;
            label1.Font = new Font("Arial", 16F, FontStyle.Bold);
            label1.ForeColor = Color.Black;
            label1.Location = new Point(309, 45);
            label1.Name = "label1";
            label1.Size = new Size(192, 26);
            label1.TabIndex = 5;
            label1.Text = "CREAR TORNEO";
            // 
            // dateTimePicker1
            // 
            dateTimePicker1.Format = DateTimePickerFormat.Short;
            dateTimePicker1.Location = new Point(301, 120);
            dateTimePicker1.Name = "dateTimePicker1";
            dateTimePicker1.Size = new Size(200, 23);
            dateTimePicker1.TabIndex = 1;
            // 
            // dateTimePicker2
            // 
            dateTimePicker2.Format = DateTimePickerFormat.Short;
            dateTimePicker2.Location = new Point(301, 170);
            dateTimePicker2.Name = "dateTimePicker2";
            dateTimePicker2.Size = new Size(200, 23);
            dateTimePicker2.TabIndex = 2;
            // 
            // label2
            // 
            label2.AutoSize = true;
            label2.Font = new Font("Arial", 14F);
            label2.Location = new Point(61, 120);
            label2.Name = "label2";
            label2.Size = new Size(138, 22);
            label2.TabIndex = 4;
            label2.Text = "Fecha de inicio";
            // 
            // label3
            // 
            label3.AutoSize = true;
            label3.Font = new Font("Arial", 14F);
            label3.Location = new Point(61, 170);
            label3.Name = "label3";
            label3.Size = new Size(187, 22);
            label3.TabIndex = 3;
            label3.Text = "Fecha de finalización";
            // 
            // label4
            // 
            label4.AutoSize = true;
            label4.Font = new Font("Arial", 14F);
            label4.Location = new Point(61, 220);
            label4.Name = "label4";
            label4.Size = new Size(177, 22);
            label4.TabIndex = 2;
            label4.Text = "Número de equipos";
            // 
            // label5
            // 
            label5.AutoSize = true;
            label5.Font = new Font("Arial", 14F);
            label5.Location = new Point(61, 270);
            label5.Name = "label5";
            label5.Size = new Size(175, 22);
            label5.TabIndex = 1;
            label5.Text = "Valor de inscripción";
            // 
            // label6
            // 
            label6.AutoSize = true;
            label6.Font = new Font("Arial", 14F);
            label6.Location = new Point(61, 320);
            label6.Name = "label6";
            label6.Size = new Size(81, 22);
            label6.TabIndex = 0;
            label6.Text = "Premios";
            // 
            // textBox1
            // 
            textBox1.Location = new Point(301, 220);
            textBox1.Name = "textBox1";
            textBox1.Size = new Size(100, 23);
            textBox1.TabIndex = 6;
            // 
            // textBox2
            // 
            textBox2.Location = new Point(301, 270);
            textBox2.Name = "textBox2";
            textBox2.Size = new Size(100, 23);
            textBox2.TabIndex = 7;
            // 
            // textBox3
            // 
            textBox3.Location = new Point(301, 320);
            textBox3.Name = "textBox3";
            textBox3.Size = new Size(100, 23);
            textBox3.TabIndex = 8;
            // 
            // button1
            // 
            button1.AutoSize = true;
            button1.Font = new Font("Arial", 12F, FontStyle.Bold);
            button1.Location = new Point(380, 378);
            button1.Name = "button1";
            button1.Size = new Size(61, 29);
            button1.TabIndex = 0;
            button1.Text = "Crear";
            button1.UseVisualStyleBackColor = true;
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
            // CrearTorneo
            // 
            AutoScaleDimensions = new SizeF(7F, 15F);
            AutoScaleMode = AutoScaleMode.Font;
            BackgroundImage = Properties.Resources.canchafondo;
            BackgroundImageLayout = ImageLayout.Stretch;
            ClientSize = new Size(800, 450);
            Controls.Add(button2);
            Controls.Add(button1);
            Controls.Add(textBox3);
            Controls.Add(textBox2);
            Controls.Add(textBox1);
            Controls.Add(label6);
            Controls.Add(label5);
            Controls.Add(label4);
            Controls.Add(label3);
            Controls.Add(label2);
            Controls.Add(dateTimePicker2);
            Controls.Add(dateTimePicker1);
            Controls.Add(label1);
            Name = "CrearTorneo";
            Text = "CrearTorneo";
            ResumeLayout(false);
            PerformLayout();
        }

        #endregion

        private Label label1;
        private DateTimePicker dateTimePicker1;
        private DateTimePicker dateTimePicker2;
        private Label label2;
        private Label label3;
        private Label label4;
        private Label label5;
        private Label label6;
        private TextBox textBox1;
        private TextBox textBox2;
        private TextBox textBox3;
        private Button button1;
        private Button button2;
    }
}