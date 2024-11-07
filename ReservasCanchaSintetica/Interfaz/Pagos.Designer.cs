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
            label_pago = new Label();
            label4 = new Label();
            datetime_mes = new DateTimePicker();
            label_cantidad_reservas = new Label();
            label6 = new Label();
            label_promedio = new Label();
            button1 = new Button();
            btn_mostrar = new Button();
            SuspendLayout();
            // 
            // label1
            // 
            label1.AutoSize = true;
            label1.Font = new Font("Arial", 16F, FontStyle.Bold);
            label1.ForeColor = Color.Black;
            label1.Location = new Point(402, 61);
            label1.Name = "label1";
            label1.Size = new Size(214, 32);
            label1.TabIndex = 5;
            label1.Text = "ESTADISTICAS";
            // 
            // label2
            // 
            label2.AutoSize = true;
            label2.Font = new Font("Arial", 14F);
            label2.Location = new Point(95, 156);
            label2.Name = "label2";
            label2.Size = new Size(212, 27);
            label2.TabIndex = 4;
            label2.Text = "Ganancias totales:";
            // 
            // label3
            // 
            label_pago.Location = new Point(369, 156);
            label_pago.Name = "label_pago";
            label_pago.Size = new Size(149, 29);
            label_pago.TabIndex = 2;
            label_pago.Text = "PAGO";
            // 
            // label4
            // 
            label4.AutoSize = true;
            label4.Font = new Font("Arial", 14F);
            label4.Location = new Point(95, 253);
            label4.Name = "label4";
            label4.Size = new Size(247, 27);
            label4.TabIndex = 3;
            label4.Text = "Cantidad de reservas:";
            // 
            // datetime_mes
            // 
            datetime_mes.CustomFormat = "MMMM yyyy";
            datetime_mes.Format = DateTimePickerFormat.Custom;
            datetime_mes.Location = new Point(669, 145);
            datetime_mes.Margin = new Padding(3, 4, 3, 4);
            datetime_mes.Name = "datetime_mes";
            datetime_mes.Size = new Size(171, 27);
            datetime_mes.TabIndex = 4;
            // 
            // label5
            // 
            label_cantidad_reservas.Location = new Point(369, 253);
            label_cantidad_reservas.Name = "label_cantidad_reservas";
            label_cantidad_reservas.Size = new Size(149, 29);
            label_cantidad_reservas.TabIndex = 6;
            label_cantidad_reservas.Text = "RESERVAS";
            // 
            // label6
            // 
            label6.AutoSize = true;
            label6.Font = new Font("Arial", 14F);
            label6.Location = new Point(95, 365);
            label6.Name = "label6";
            label6.Size = new Size(182, 27);
            label6.TabIndex = 7;
            label6.Text = "Pago promedio:";
            // 
            // label7
            // 
            label_promedio.Location = new Point(369, 365);
            label_promedio.Name = "label_promedio";
            label_promedio.Size = new Size(149, 29);
            label_promedio.TabIndex = 8;
            label_promedio.Text = "PAGO PROMEDIO";
            // 
            // button1
            // 
            button1.AutoSize = true;
            button1.Font = new Font("Arial", 10F);
            button1.Location = new Point(769, 535);
            button1.Margin = new Padding(3, 4, 3, 4);
            button1.Name = "button1";
            button1.Size = new Size(86, 31);
            button1.TabIndex = 3;
            button1.Text = "Regresar";
            button1.UseVisualStyleBackColor = true;
            button1.Click += button1_Click;
            // 
            // btn_mostrar
            // 
            btn_mostrar.Location = new Point(689, 263);
            btn_mostrar.Name = "btn_mostrar";
            btn_mostrar.Size = new Size(94, 29);
            btn_mostrar.TabIndex = 9;
            btn_mostrar.Text = "Mostrar";
            btn_mostrar.UseVisualStyleBackColor = true;
            btn_mostrar.Click += btn_mostrar_Click;
            // 
            // Pagos
            // 
            AutoScaleDimensions = new SizeF(8F, 20F);
            AutoScaleMode = AutoScaleMode.Font;
            BackgroundImage = Properties.Resources.canchafondo;
            BackgroundImageLayout = ImageLayout.Stretch;
            ClientSize = new Size(914, 600);
            Controls.Add(btn_mostrar);
            Controls.Add(button1);
            Controls.Add(label_promedio);
            Controls.Add(label6);
            Controls.Add(label_cantidad_reservas);
            Controls.Add(datetime_mes);
            Controls.Add(label4);
            Controls.Add(label_pago);
            Controls.Add(label2);
            Controls.Add(label1);
            Margin = new Padding(3, 4, 3, 4);
            Name = "Pagos";
            Text = "Pagos";
            ResumeLayout(false);
            PerformLayout();
        }

        #endregion

        private Label label1;
        private Label label2;
        private Label label_pago;
        private Label label4;
        private DateTimePicker datetime_mes;
        private Label label_cantidad_reservas;
        private Label label6;
        private Label label_promedio;
        private Button button1;
        private Button btn_mostrar;
    }
}