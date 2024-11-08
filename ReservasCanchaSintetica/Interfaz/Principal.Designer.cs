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
            text_usuario = new TextBox();
            text_contraseña = new TextBox();
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
            label1.Location = new Point(198, 57);
            label1.Name = "label1";
            label1.Size = new Size(579, 32);
            label1.TabIndex = 4;
            label1.Text = "BIENVENIDO A LA RESERVA DE CANCHAS";
            // 
            // label2
            // 
            label2.AutoSize = true;
            label2.Font = new Font("Arial", 12F);
            label2.Location = new Point(57, 204);
            label2.Name = "label2";
            label2.Size = new Size(82, 23);
            label2.TabIndex = 3;
            label2.Text = "Documento:";
            // 
            // label3
            // 
            label3.AutoSize = true;
            label3.Font = new Font("Arial", 12F);
            label3.Location = new Point(57, 299);
            label3.Name = "label3";
            label3.Size = new Size(118, 23);
            label3.TabIndex = 2;
            label3.Text = "Contraseña:";
            // 
            // text_usuario
            // 
            text_usuario.Location = new Point(229, 204);
            text_usuario.Margin = new Padding(3, 4, 3, 4);
            text_usuario.Name = "text_usuario";
            text_usuario.Size = new Size(228, 27);
            text_usuario.TabIndex = 0;
            // 
            // text_contraseña
            // 
            text_contraseña.Location = new Point(229, 299);
            text_contraseña.Margin = new Padding(3, 4, 3, 4);
            text_contraseña.Name = "text_contraseña";
            text_contraseña.Size = new Size(228, 27);
            text_contraseña.TabIndex = 1;
            // 
            // label4
            // 
            label4.AutoSize = true;
            label4.Location = new Point(343, 513);
            label4.Name = "label4";
            label4.Size = new Size(134, 20);
            label4.TabIndex = 4;
            label4.Text = "¿No tienes cuenta?";
            // 
            // button1
            // 
            button1.AutoSize = true;
            button1.Location = new Point(418, 437);
            button1.Margin = new Padding(3, 4, 3, 4);
            button1.Name = "button1";
            button1.Size = new Size(104, 33);
            button1.TabIndex = 2;
            button1.Text = "Iniciar sesión";
            button1.UseVisualStyleBackColor = true;
            button1.Click += button1_Click;
            // 
            // button2
            // 
            button2.AutoSize = true;
            button2.Location = new Point(495, 507);
            button2.Margin = new Padding(3, 4, 3, 4);
            button2.Name = "button2";
            button2.Size = new Size(86, 33);
            button2.TabIndex = 3;
            button2.Text = "Regístrate";
            button2.UseVisualStyleBackColor = true;
            button2.Click += button2_Click;
            // 
            // Principal
            // 
            AutoScaleDimensions = new SizeF(8F, 20F);
            AutoScaleMode = AutoScaleMode.Font;
            BackgroundImage = Properties.Resources.canchafondo;
            BackgroundImageLayout = ImageLayout.Stretch;
            ClientSize = new Size(914, 600);
            Controls.Add(button2);
            Controls.Add(button1);
            Controls.Add(label4);
            Controls.Add(text_contraseña);
            Controls.Add(text_usuario);
            Controls.Add(label3);
            Controls.Add(label2);
            Controls.Add(label1);
            Margin = new Padding(3, 4, 3, 4);
            Name = "Principal";
            Text = "Reservas Cancha Sintética";
            ResumeLayout(false);
            PerformLayout();
        }

        #endregion

        private Label label1;
        private Label label2;
        private Label label3;
        private TextBox text_usuario;
        private TextBox text_contraseña;
        private Label label4;
        private Button button1;
        private Button button2;
    }
}


