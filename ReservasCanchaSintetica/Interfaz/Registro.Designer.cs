namespace ReservasCanchaSintetica
{
    partial class Registro
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
            label5 = new Label();
            label6 = new Label();
            label7 = new Label();
            label8 = new Label();
            text_documento = new TextBox();
            text_nombre = new TextBox();
            text_apellido = new TextBox();
            text_telefono = new TextBox();
            text_correo = new TextBox();
            text_contraseña = new TextBox();
            text_saldo = new TextBox();
            button1 = new Button();
            button2 = new Button();
            SuspendLayout();
            // 
            // label1
            // 
            label1.AutoSize = true;
            label1.Font = new Font("Arial", 16F, FontStyle.Bold);
            label1.ForeColor = Color.Black;
            label1.Location = new Point(389, 53);
            label1.Name = "label1";
            label1.Size = new Size(158, 32);
            label1.TabIndex = 14;
            label1.Text = "REGISTRO";
            // 
            // label2
            // 
            label2.AutoSize = true;
            label2.Location = new Point(57, 133);
            label2.Name = "label2";
            label2.Size = new Size(87, 20);
            label2.TabIndex = 13;
            label2.Text = "Documento";
            // 
            // label3
            // 
            label3.AutoSize = true;
            label3.Location = new Point(57, 187);
            label3.Name = "label3";
            label3.Size = new Size(64, 20);
            label3.TabIndex = 12;
            label3.Text = "Nombre";
            // 
            // label4
            // 
            label4.AutoSize = true;
            label4.Location = new Point(57, 240);
            label4.Name = "label4";
            label4.Size = new Size(66, 20);
            label4.TabIndex = 11;
            label4.Text = "Apellido";
            // 
            // label5
            // 
            label5.AutoSize = true;
            label5.Location = new Point(57, 293);
            label5.Name = "label5";
            label5.Size = new Size(67, 20);
            label5.TabIndex = 10;
            label5.Text = "Teléfono";
            // 
            // label6
            // 
            label6.AutoSize = true;
            label6.Location = new Point(57, 347);
            label6.Name = "label6";
            label6.Size = new Size(54, 20);
            label6.TabIndex = 9;
            label6.Text = "Correo";
            // 
            // label7
            // 
            label7.AutoSize = true;
            label7.Location = new Point(57, 400);
            label7.Name = "label7";
            label7.Size = new Size(83, 20);
            label7.TabIndex = 8;
            label7.Text = "Contraseña";
            // 
            // label8
            // 
            label8.AutoSize = true;
            label8.Location = new Point(57, 453);
            label8.Name = "label8";
            label8.Size = new Size(47, 20);
            label8.TabIndex = 7;
            label8.Text = "Saldo";
            // 
            // text_documento
            // 
            text_documento.Location = new Point(183, 133);
            text_documento.Margin = new Padding(3, 4, 3, 4);
            text_documento.Name = "text_documento";
            text_documento.Size = new Size(114, 27);
            text_documento.TabIndex = 0;
            // 
            // text_nombre
            // 
            text_nombre.Location = new Point(183, 187);
            text_nombre.Margin = new Padding(3, 4, 3, 4);
            text_nombre.Name = "text_nombre";
            text_nombre.Size = new Size(114, 27);
            text_nombre.TabIndex = 1;
            // 
            // text_apellido
            // 
            text_apellido.Location = new Point(183, 240);
            text_apellido.Margin = new Padding(3, 4, 3, 4);
            text_apellido.Name = "text_apellido";
            text_apellido.Size = new Size(114, 27);
            text_apellido.TabIndex = 2;
            // 
            // text_telefono
            // 
            text_telefono.Location = new Point(183, 293);
            text_telefono.Margin = new Padding(3, 4, 3, 4);
            text_telefono.Name = "text_telefono";
            text_telefono.Size = new Size(114, 27);
            text_telefono.TabIndex = 3;
            // 
            // text_correo
            // 
            text_correo.Location = new Point(183, 347);
            text_correo.Margin = new Padding(3, 4, 3, 4);
            text_correo.Name = "text_correo";
            text_correo.Size = new Size(114, 27);
            text_correo.TabIndex = 4;
            // 
            // text_contraseña
            // 
            text_contraseña.Location = new Point(183, 400);
            text_contraseña.Margin = new Padding(3, 4, 3, 4);
            text_contraseña.Name = "text_contraseña";
            text_contraseña.Size = new Size(114, 27);
            text_contraseña.TabIndex = 5;
            // 
            // text_saldo
            // 
            text_saldo.Location = new Point(183, 453);
            text_saldo.Margin = new Padding(3, 4, 3, 4);
            text_saldo.Name = "text_saldo";
            text_saldo.Size = new Size(114, 27);
            text_saldo.TabIndex = 6;
            // 
            // button1
            // 
            button1.Location = new Point(400, 507);
            button1.Margin = new Padding(3, 4, 3, 4);
            button1.Name = "button1";
            button1.Size = new Size(103, 31);
            button1.TabIndex = 7;
            button1.Text = "Registrarse";
            button1.UseVisualStyleBackColor = true;
            button1.Click += button1_Click;
            // 
            // button2
            // 
            button2.Location = new Point(750, 507);
            button2.Margin = new Padding(3, 4, 3, 4);
            button2.Name = "button2";
            button2.Size = new Size(86, 31);
            button2.TabIndex = 15;
            button2.Text = "Regresar";
            button2.UseVisualStyleBackColor = true;
            button2.Click += button2_Click;
            // 
            // Registro
            // 
            AutoScaleDimensions = new SizeF(8F, 20F);
            AutoScaleMode = AutoScaleMode.Font;
            BackgroundImage = Properties.Resources.canchafondo;
            BackgroundImageLayout = ImageLayout.Stretch;
            ClientSize = new Size(914, 600);
            Controls.Add(button2);
            Controls.Add(button1);
            Controls.Add(text_saldo);
            Controls.Add(text_contraseña);
            Controls.Add(text_correo);
            Controls.Add(text_telefono);
            Controls.Add(text_apellido);
            Controls.Add(text_nombre);
            Controls.Add(text_documento);
            Controls.Add(label8);
            Controls.Add(label7);
            Controls.Add(label6);
            Controls.Add(label5);
            Controls.Add(label4);
            Controls.Add(label3);
            Controls.Add(label2);
            Controls.Add(label1);
            Margin = new Padding(3, 4, 3, 4);
            Name = "Registro";
            Text = "Form2";
            ResumeLayout(false);
            PerformLayout();
        }

        #endregion

        private Label label1;
        private Label label2;
        private Label label3;
        private Label label4;
        private Label label5;
        private Label label6;
        private Label label7;
        private Label label8;
        private TextBox text_documento;
        private TextBox text_nombre;
        private TextBox text_apellido;
        private TextBox text_telefono;
        private TextBox text_correo;
        private TextBox text_contraseña;
        private TextBox text_saldo;
        private Button button1;
        private Button button2;
    }
}