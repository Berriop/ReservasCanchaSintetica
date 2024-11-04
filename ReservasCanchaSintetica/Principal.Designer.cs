namespace ReservasCanchaSintetica
{
    partial class Principal
    {
        private System.ComponentModel.IContainer components = null;

        protected override void Dispose(bool disposing)
        {
            if (disposing && (components != null))
            {
                components.Dispose();
            }
            base.Dispose(disposing);
        }

        #region Windows Form Designer generated code

        private void InitializeComponent()
        {
            label1 = new Label();
            label2 = new Label();
            label3 = new Label();
            textBox1 = new TextBox();
            textBox2 = new TextBox();
            label4 = new Label();
            button1 = new Button();
            button2 = new Button();
            SuspendLayout();
            // 
            // label1
            // 
            label1.AutoSize = true;
            label1.Font = new Font("Arial", 16F, FontStyle.Bold);
            label1.ForeColor = Color.Black;
            label1.Location = new Point(173, 43);
            label1.Name = "label1";
            label1.Size = new Size(462, 26);
            label1.TabIndex = 4;
            label1.Text = "BIENVENIDO A LA RESERVA DE CANCHAS";
            // 
            // label2
            // 
            label2.AutoSize = true;
            label2.Font = new Font("Arial", 12F);
            label2.Location = new Point(50, 153);
            label2.Name = "label2";
            label2.Size = new Size(66, 18);
            label2.TabIndex = 3;
            label2.Text = "Usuario:";
            // 
            // label3
            // 
            label3.AutoSize = true;
            label3.Font = new Font("Arial", 12F);
            label3.Location = new Point(50, 224);
            label3.Name = "label3";
            label3.Size = new Size(93, 18);
            label3.TabIndex = 2;
            label3.Text = "Contraseña:";
            // 
            // textBox1
            // 
            textBox1.Location = new Point(200, 153);
            textBox1.Name = "textBox1";
            textBox1.Size = new Size(200, 23);
            textBox1.TabIndex = 0;
            // 
            // textBox2
            // 
            textBox2.Location = new Point(200, 224);
            textBox2.Name = "textBox2";
            textBox2.Size = new Size(200, 23);
            textBox2.TabIndex = 1;
            // 
            // label4
            // 
            label4.AutoSize = true;
            label4.Location = new Point(300, 385);
            label4.Name = "label4";
            label4.Size = new Size(106, 15);
            label4.TabIndex = 4;
            label4.Text = "¿No tienes cuenta?";
            // 
            // button1
            // 
            button1.AutoSize = true;
            button1.Location = new Point(366, 328);
            button1.Name = "button1";
            button1.Size = new Size(85, 25);
            button1.TabIndex = 2;
            button1.Text = "Iniciar sesión";
            button1.UseVisualStyleBackColor = true;
            // 
            // button2
            // 
            button2.AutoSize = true;
            button2.Location = new Point(433, 380);
            button2.Name = "button2";
            button2.Size = new Size(75, 25);
            button2.TabIndex = 3;
            button2.Text = "Regístrate";
            button2.UseVisualStyleBackColor = true;
            // 
            // Principal
            // 
            AutoScaleDimensions = new SizeF(7F, 15F);
            AutoScaleMode = AutoScaleMode.Font;
            BackgroundImage = Properties.Resources.canchafondo;
            BackgroundImageLayout = ImageLayout.Stretch;
            ClientSize = new Size(800, 450);
            Controls.Add(button2);
            Controls.Add(button1);
            Controls.Add(label4);
            Controls.Add(textBox2);
            Controls.Add(textBox1);
            Controls.Add(label3);
            Controls.Add(label2);
            Controls.Add(label1);
            Name = "Principal";
            Text = "Reservas Cancha Sintética";
            ResumeLayout(false);
            PerformLayout();
        }

        #endregion

        private Label label1;
        private Label label2;
        private Label label3;
        private TextBox textBox1;
        private TextBox textBox2;
        private Label label4;
        private Button button1;
        private Button button2;
    }
}


