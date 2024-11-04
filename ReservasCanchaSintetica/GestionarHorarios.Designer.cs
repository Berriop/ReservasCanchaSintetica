namespace ReservasCanchaSintetica
{
    partial class GestionarHorarios
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
            button1 = new Button();
            button2 = new Button();
            button3 = new Button();
            SuspendLayout();
            // 
            // label1
            // 
            label1.AutoSize = true;
            label1.Font = new Font("Arial", 16F, FontStyle.Bold);
            label1.ForeColor = Color.Black;
            label1.Location = new Point(267, 47);
            label1.Name = "label1";
            label1.Size = new Size(266, 26);
            label1.TabIndex = 2;
            label1.Text = "GESTIONAR HORARIOS";
            // 
            // dateTimePicker1
            // 
            dateTimePicker1.Format = DateTimePickerFormat.Short;
            dateTimePicker1.Location = new Point(556, 108);
            dateTimePicker1.Name = "dateTimePicker1";
            dateTimePicker1.Size = new Size(200, 23);
            dateTimePicker1.TabIndex = 0;
            // 
            // button1
            // 
            button1.Font = new Font("Arial", 14F, FontStyle.Bold);
            button1.Location = new Point(99, 198);
            button1.Name = "button1";
            button1.Size = new Size(200, 80);
            button1.TabIndex = 0;
            button1.Text = "Activar";
            button1.UseVisualStyleBackColor = true;
            // 
            // button2
            // 
            button2.Font = new Font("Arial", 14F, FontStyle.Bold);
            button2.Location = new Point(509, 198);
            button2.Name = "button2";
            button2.Size = new Size(200, 80);
            button2.TabIndex = 1;
            button2.Text = "Desactivar";
            button2.UseVisualStyleBackColor = true;
            // 
            // button3
            // 
            button3.Location = new Point(673, 401);
            button3.Font = new Font("Arial", 10);
            button3.Name = "button3";
            button3.AutoSize = true;
            button3.TabIndex = 3;
            button3.Text = "Regresar";
            button3.UseVisualStyleBackColor = true;
            // 
            // GestionarHorarios
            // 
            AutoScaleDimensions = new SizeF(7F, 15F);
            AutoScaleMode = AutoScaleMode.Font;
            BackgroundImage = Properties.Resources.canchafondo;
            BackgroundImageLayout = ImageLayout.Stretch;
            ClientSize = new Size(800, 450);
            Controls.Add(button3);
            Controls.Add(button2);
            Controls.Add(button1);
            Controls.Add(dateTimePicker1);
            Controls.Add(label1);
            Name = "GestionarHorarios";
            Text = "GestionarHorarios";
            ResumeLayout(false);
            PerformLayout();
        }

        #endregion

        private Label label1;
        private DateTimePicker dateTimePicker1;
        private Button button1;
        private Button button2;
        private Button button3;
    }
}