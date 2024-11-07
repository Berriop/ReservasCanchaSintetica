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
            datetime_inicio = new DateTimePicker();
            datetime_final = new DateTimePicker();
            label2 = new Label();
            label3 = new Label();
            label4 = new Label();
            label5 = new Label();
            label6 = new Label();
            textbox_cantidad_equipos = new TextBox();
            textbox_valor_inscripcion = new TextBox();
            textbox_premio = new TextBox();
            button1 = new Button();
            button2 = new Button();
            label7 = new Label();
            textbox_nombre = new TextBox();
            SuspendLayout();
            // 
            // label1
            // 
            label1.AutoSize = true;
            label1.Font = new Font("Arial", 16F, FontStyle.Bold);
            label1.ForeColor = Color.Black;
            label1.Location = new Point(353, 60);
            label1.Name = "label1";
            label1.Size = new Size(237, 32);
            label1.TabIndex = 5;
            label1.Text = "CREAR TORNEO";
            // 
            // datetime_inicio
            // 
            datetime_inicio.Format = DateTimePickerFormat.Short;
            datetime_inicio.Location = new Point(344, 160);
            datetime_inicio.Margin = new Padding(3, 4, 3, 4);
            datetime_inicio.Name = "datetime_inicio";
            datetime_inicio.Size = new Size(228, 27);
            datetime_inicio.TabIndex = 1;
            // 
            // datetime_final
            // 
            datetime_final.Format = DateTimePickerFormat.Short;
            datetime_final.Location = new Point(344, 227);
            datetime_final.Margin = new Padding(3, 4, 3, 4);
            datetime_final.Name = "datetime_final";
            datetime_final.Size = new Size(228, 27);
            datetime_final.TabIndex = 2;
            // 
            // label2
            // 
            label2.AutoSize = true;
            label2.Font = new Font("Arial", 14F);
            label2.Location = new Point(70, 160);
            label2.Name = "label2";
            label2.Size = new Size(174, 27);
            label2.TabIndex = 4;
            label2.Text = "Fecha de inicio";
            // 
            // label3
            // 
            label3.AutoSize = true;
            label3.Font = new Font("Arial", 14F);
            label3.Location = new Point(70, 227);
            label3.Name = "label3";
            label3.Size = new Size(239, 27);
            label3.TabIndex = 3;
            label3.Text = "Fecha de finalización";
            // 
            // label4
            // 
            label4.AutoSize = true;
            label4.Font = new Font("Arial", 14F);
            label4.Location = new Point(70, 293);
            label4.Name = "label4";
            label4.Size = new Size(223, 27);
            label4.TabIndex = 2;
            label4.Text = "Número de equipos";
            // 
            // label5
            // 
            label5.AutoSize = true;
            label5.Font = new Font("Arial", 14F);
            label5.Location = new Point(70, 360);
            label5.Name = "label5";
            label5.Size = new Size(220, 27);
            label5.TabIndex = 1;
            label5.Text = "Valor de inscripción";
            // 
            // label6
            // 
            label6.AutoSize = true;
            label6.Font = new Font("Arial", 14F);
            label6.Location = new Point(70, 427);
            label6.Name = "label6";
            label6.Size = new Size(99, 27);
            label6.TabIndex = 0;
            label6.Text = "Premios";
            // 
            // textbox_cantidad_equipos
            // 
            textbox_cantidad_equipos.Location = new Point(344, 293);
            textbox_cantidad_equipos.Margin = new Padding(3, 4, 3, 4);
            textbox_cantidad_equipos.Name = "textbox_cantidad_equipos";
            textbox_cantidad_equipos.Size = new Size(114, 27);
            textbox_cantidad_equipos.TabIndex = 6;
            // 
            // textbox_valor_inscripcion
            // 
            textbox_valor_inscripcion.Location = new Point(344, 360);
            textbox_valor_inscripcion.Margin = new Padding(3, 4, 3, 4);
            textbox_valor_inscripcion.Name = "textbox_valor_inscripcion";
            textbox_valor_inscripcion.Size = new Size(114, 27);
            textbox_valor_inscripcion.TabIndex = 7;
            // 
            // textbox_premio
            // 
            textbox_premio.Location = new Point(344, 427);
            textbox_premio.Margin = new Padding(3, 4, 3, 4);
            textbox_premio.Name = "textbox_premio";
            textbox_premio.Size = new Size(114, 27);
            textbox_premio.TabIndex = 8;
            // 
            // button1
            // 
            button1.AutoSize = true;
            button1.Font = new Font("Arial", 12F, FontStyle.Bold);
            button1.Location = new Point(434, 504);
            button1.Margin = new Padding(3, 4, 3, 4);
            button1.Name = "button1";
            button1.Size = new Size(72, 39);
            button1.TabIndex = 0;
            button1.Text = "Crear";
            button1.UseVisualStyleBackColor = true;
            button1.Click += button1_Click;
            // 
            // button2
            // 
            button2.AutoSize = true;
            button2.Font = new Font("Arial", 10F);
            button2.Location = new Point(769, 535);
            button2.Margin = new Padding(3, 4, 3, 4);
            button2.Name = "button2";
            button2.Size = new Size(86, 31);
            button2.TabIndex = 3;
            button2.Text = "Regresar";
            button2.UseVisualStyleBackColor = true;
            button2.Click += button2_Click;
            // 
            // label7
            // 
            label7.AutoSize = true;
            label7.Font = new Font("Arial", 14F);
            label7.Location = new Point(521, 293);
            label7.Name = "label7";
            label7.Size = new Size(97, 27);
            label7.TabIndex = 9;
            label7.Text = "Nombre";
            // 
            // textBox1
            // 
            textbox_nombre.Location = new Point(649, 295);
            textbox_nombre.Margin = new Padding(3, 4, 3, 4);
            textbox_nombre.Name = "textbox_nombre";
            textbox_nombre.Size = new Size(114, 27);
            textbox_nombre.TabIndex = 10;
            // 
            // CrearTorneo
            // 
            AutoScaleDimensions = new SizeF(8F, 20F);
            AutoScaleMode = AutoScaleMode.Font;
            BackgroundImage = Properties.Resources.canchafondo;
            BackgroundImageLayout = ImageLayout.Stretch;
            ClientSize = new Size(914, 600);
            Controls.Add(textbox_nombre);
            Controls.Add(label7);
            Controls.Add(button2);
            Controls.Add(button1);
            Controls.Add(textbox_premio);
            Controls.Add(textbox_valor_inscripcion);
            Controls.Add(textbox_cantidad_equipos);
            Controls.Add(label6);
            Controls.Add(label5);
            Controls.Add(label4);
            Controls.Add(label3);
            Controls.Add(label2);
            Controls.Add(datetime_final);
            Controls.Add(datetime_inicio);
            Controls.Add(label1);
            Margin = new Padding(3, 4, 3, 4);
            Name = "CrearTorneo";
            Text = "CrearTorneo";
            ResumeLayout(false);
            PerformLayout();
        }

        #endregion

        private Label label1;
        private DateTimePicker datetime_inicio;
        private DateTimePicker datetime_final;
        private Label label2;
        private Label label3;
        private Label label4;
        private Label label5;
        private Label label6;
        private TextBox textbox_cantidad_equipos;
        private TextBox textbox_valor_inscripcion;
        private TextBox textbox_premio;
        private Button button1;
        private Button button2;
        private Label label7;
        private TextBox textbox_nombre;
    }
}