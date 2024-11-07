namespace ReservasCanchaSintetica
{
    partial class CrearEquipo
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
            textbox_nombre = new TextBox();
            label3 = new Label();
            textbox_cantidad_jugadores = new TextBox();
            button1 = new Button();
            button2 = new Button();
            SuspendLayout();
            // 
            // label1
            // 
            label1.AutoSize = true;
            label1.Font = new Font("Arial", 16F, FontStyle.Bold);
            label1.ForeColor = Color.Black;
            label1.Location = new Point(359, 61);
            label1.Name = "label1";
            label1.Size = new Size(225, 32);
            label1.TabIndex = 4;
            label1.Text = "CREAR EQUIPO";
            // 
            // label2
            // 
            label2.AutoSize = true;
            label2.Font = new Font("Arial", 14F);
            label2.Location = new Point(70, 171);
            label2.Name = "label2";
            label2.Size = new Size(211, 27);
            label2.TabIndex = 3;
            label2.Text = "Nombre de equipo";
            // 
            // textBox1
            // 
            textbox_nombre.Location = new Point(326, 171);
            textbox_nombre.Margin = new Padding(3, 4, 3, 4);
            textbox_nombre.Name = "textbox_nombre";
            textbox_nombre.Size = new Size(114, 27);
            textbox_nombre.TabIndex = 0;
            // 
            // label3
            // 
            label3.AutoSize = true;
            label3.Font = new Font("Arial", 14F);
            label3.Location = new Point(70, 253);
            label3.Name = "label3";
            label3.Size = new Size(245, 27);
            label3.TabIndex = 2;
            label3.Text = "Número de jugadores";
            // 
            // textBox2
            // 
            textbox_cantidad_jugadores.Location = new Point(326, 252);
            textbox_cantidad_jugadores.Margin = new Padding(3, 4, 3, 4);
            textbox_cantidad_jugadores.Name = "textbox_cantidad_jugadores";
            textbox_cantidad_jugadores.Size = new Size(114, 27);
            textbox_cantidad_jugadores.TabIndex = 1;
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
            button2.Location = new Point(758, 512);
            button2.Margin = new Padding(3, 4, 3, 4);
            button2.Name = "button2";
            button2.Size = new Size(86, 31);
            button2.TabIndex = 3;
            button2.Text = "Regresar";
            button2.UseVisualStyleBackColor = true;
            button2.Click += button2_Click;
            // 
            // CrearEquipo
            // 
            AutoScaleDimensions = new SizeF(8F, 20F);
            AutoScaleMode = AutoScaleMode.Font;
            BackgroundImage = Properties.Resources.canchafondo;
            BackgroundImageLayout = ImageLayout.Stretch;
            ClientSize = new Size(914, 600);
            Controls.Add(button2);
            Controls.Add(button1);
            Controls.Add(textbox_cantidad_jugadores);
            Controls.Add(label3);
            Controls.Add(textbox_nombre);
            Controls.Add(label2);
            Controls.Add(label1);
            Margin = new Padding(3, 4, 3, 4);
            Name = "CrearEquipo";
            Text = "CrearEquipo";
            Load += CrearEquipo_Load;
            ResumeLayout(false);
            PerformLayout();
        }

        #endregion

        private Label label1;
        private Label label2;
        private TextBox textbox_nombre;
        private Label label3;
        private TextBox textbox_cantidad_jugadores;
        private Button button1;
        private Button button2;
    }
}