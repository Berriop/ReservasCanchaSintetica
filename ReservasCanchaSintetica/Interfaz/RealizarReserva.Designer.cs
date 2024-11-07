using System.Windows.Forms;

namespace ReservasCanchaSintetica
{
    partial class RealizarReserva
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
            datetimepicker_fecha = new DateTimePicker();
            combobox_hora = new ComboBox();
            label2 = new Label();
            label3 = new Label();
            button1 = new Button();
            combobox_cancha = new ComboBox();
            label4 = new Label();
            combo_cantidad_horas = new ComboBox();
            label5 = new Label();
            SuspendLayout();
            // 
            // label1
            // 
            label1.AutoSize = true;
            label1.Font = new Font("Arial", 16F, FontStyle.Bold);
            label1.ForeColor = Color.Black;
            label1.Location = new Point(416, 61);
            label1.Name = "label1";
            label1.Size = new Size(143, 32);
            label1.TabIndex = 5;
            label1.Text = "RESERVA";
            // 
            // datetimepicker_fecha
            // 
            datetimepicker_fecha.Format = DateTimePickerFormat.Short;
            datetimepicker_fecha.Location = new Point(199, 261);
            datetimepicker_fecha.Margin = new Padding(3, 4, 3, 4);
            datetimepicker_fecha.Name = "datetimepicker_fecha";
            datetimepicker_fecha.Size = new Size(228, 27);
            datetimepicker_fecha.TabIndex = 1;
            // 
            // combobox_hora
            // 
            combobox_hora.FormattingEnabled = true;
            combobox_hora.Location = new Point(199, 333);
            combobox_hora.Margin = new Padding(3, 4, 3, 4);
            combobox_hora.Name = "combobox_hora";
            combobox_hora.Size = new Size(138, 28);
            combobox_hora.TabIndex = 2;
            // 
            // label2
            // 
            label2.AutoSize = true;
            label2.Font = new Font("Arial", 14F);
            label2.Location = new Point(70, 263);
            label2.Name = "label2";
            label2.Size = new Size(48, 27);
            label2.TabIndex = 4;
            label2.Text = "Día";
            // 
            // label3
            // 
            label3.AutoSize = true;
            label3.Font = new Font("Arial", 14F);
            label3.Location = new Point(70, 335);
            label3.Name = "label3";
            label3.Size = new Size(63, 27);
            label3.TabIndex = 3;
            label3.Text = "Hora";
            // 
            // button1
            // 
            button1.AutoSize = true;
            button1.Font = new Font("Arial", 12F, FontStyle.Bold);
            button1.Location = new Point(434, 504);
            button1.Margin = new Padding(3, 4, 3, 4);
            button1.Name = "button1";
            button1.Size = new Size(105, 39);
            button1.TabIndex = 0;
            button1.Text = "Reservar";
            button1.UseVisualStyleBackColor = true;
            button1.Click += button1_Click;
            // 
            // combobox_cancha
            // 
            combobox_cancha.FormattingEnabled = true;
            combobox_cancha.Location = new Point(199, 199);
            combobox_cancha.Margin = new Padding(3, 4, 3, 4);
            combobox_cancha.Name = "combobox_cancha";
            combobox_cancha.Size = new Size(138, 28);
            combobox_cancha.TabIndex = 6;
            // 
            // label4
            // 
            label4.AutoSize = true;
            label4.Font = new Font("Arial", 14F);
            label4.Location = new Point(70, 200);
            label4.Name = "label4";
            label4.Size = new Size(95, 27);
            label4.TabIndex = 4;
            label4.Text = "Cancha";
            // 
            // combo_cantidad_horas
            // 
            combo_cantidad_horas.FormattingEnabled = true;
            combo_cantidad_horas.Location = new Point(289, 413);
            combo_cantidad_horas.Margin = new Padding(3, 4, 3, 4);
            combo_cantidad_horas.Name = "combo_cantidad_horas";
            combo_cantidad_horas.Size = new Size(138, 28);
            combo_cantidad_horas.TabIndex = 7;
            // 
            // label5
            // 
            label5.AutoSize = true;
            label5.Font = new Font("Arial", 14F);
            label5.Location = new Point(70, 413);
            label5.Name = "label5";
            label5.Size = new Size(179, 27);
            label5.TabIndex = 8;
            label5.Text = "Cantidad Horas";
            // 
            // RealizarReserva
            // 
            AutoScaleDimensions = new SizeF(8F, 20F);
            AutoScaleMode = AutoScaleMode.Font;
            BackgroundImage = Properties.Resources.canchafondo;
            BackgroundImageLayout = ImageLayout.Stretch;
            ClientSize = new Size(914, 600);
            Controls.Add(label5);
            Controls.Add(combo_cantidad_horas);
            Controls.Add(label4);
            Controls.Add(combobox_cancha);
            Controls.Add(button1);
            Controls.Add(label3);
            Controls.Add(label2);
            Controls.Add(combobox_hora);
            Controls.Add(datetimepicker_fecha);
            Controls.Add(label1);
            Margin = new Padding(3, 4, 3, 4);
            Name = "RealizarReserva";
            Text = "RealizarReserva";
            Load += RealizarReserva_Load;
            ResumeLayout(false);
            PerformLayout();
        }

        #endregion

        private Label label1;
        private DateTimePicker datetimepicker_fecha;
        private ComboBox combobox_hora;
        private Label label2;
        private Label label3;
        private Button button1;
        private ComboBox combobox_cancha;
        private Label label4;
        private ComboBox combo_cantidad_horas;
        private Label label5;
    }
}