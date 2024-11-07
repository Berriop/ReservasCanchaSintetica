namespace ReservasCanchaSintetica
{
    partial class AgregarEquipo
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
            combobox_torneo = new ComboBox();
            label3 = new Label();
            combobox_equipo = new ComboBox();
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
            label1.Location = new Point(343, 61);
            label1.Name = "label1";
            label1.Size = new Size(266, 32);
            label1.TabIndex = 0;
            label1.Text = "AGREGAR EQUIPO";
            // 
            // label2
            // 
            label2.AutoSize = true;
            label2.Font = new Font("Arial", 14F);
            label2.Location = new Point(70, 171);
            label2.Name = "label2";
            label2.Size = new Size(84, 27);
            label2.TabIndex = 7;
            label2.Text = "Torneo";
            // 
            // combobox_torneo
            // 
            combobox_torneo.FormattingEnabled = true;
            combobox_torneo.Location = new Point(208, 171);
            combobox_torneo.Margin = new Padding(3, 4, 3, 4);
            combobox_torneo.Name = "combobox_torneo";
            combobox_torneo.Size = new Size(138, 28);
            combobox_torneo.TabIndex = 2;
            // 
            // label3
            // 
            label3.AutoSize = true;
            label3.Font = new Font("Arial", 14F);
            label3.Location = new Point(70, 253);
            label3.Name = "label3";
            label3.Size = new Size(88, 27);
            label3.TabIndex = 6;
            label3.Text = "Equipo";
            // 
            // combobox_equipo
            // 
            combobox_equipo.FormattingEnabled = true;
            combobox_equipo.Location = new Point(208, 252);
            combobox_equipo.Margin = new Padding(3, 4, 3, 4);
            combobox_equipo.Name = "combobox_equipo";
            combobox_equipo.Size = new Size(138, 28);
            combobox_equipo.TabIndex = 4;
            // 
            // button1
            // 
            button1.Location = new Point(434, 253);
            button1.Margin = new Padding(3, 4, 3, 4);
            button1.Name = "button1";
            button1.Size = new Size(126, 31);
            button1.TabIndex = 5;
            button1.Text = "Crear Equipo";
            button1.UseVisualStyleBackColor = true;
            button1.Click += button1_Click;
            // 
            // button2
            // 
            button2.AutoSize = true;
            button2.Font = new Font("Arial", 12F, FontStyle.Bold);
            button2.Location = new Point(434, 504);
            button2.Margin = new Padding(3, 4, 3, 4);
            button2.Name = "button2";
            button2.Size = new Size(95, 39);
            button2.TabIndex = 0;
            button2.Text = "Agregar";
            button2.UseVisualStyleBackColor = true;
            button2.Click += button2_Click;
            // 
            // button3
            // 
            button3.AutoSize = true;
            button3.Font = new Font("Arial", 10F);
            button3.Location = new Point(767, 512);
            button3.Margin = new Padding(3, 4, 3, 4);
            button3.Name = "button3";
            button3.Size = new Size(86, 31);
            button3.TabIndex = 3;
            button3.Text = "Regresar";
            button3.UseVisualStyleBackColor = true;
            button3.Click += button3_Click;
            // 
            // AgregarEquipo
            // 
            AutoScaleDimensions = new SizeF(8F, 20F);
            AutoScaleMode = AutoScaleMode.Font;
            BackgroundImage = Properties.Resources.canchafondo;
            BackgroundImageLayout = ImageLayout.Stretch;
            ClientSize = new Size(914, 600);
            Controls.Add(button3);
            Controls.Add(button2);
            Controls.Add(button1);
            Controls.Add(combobox_equipo);
            Controls.Add(label3);
            Controls.Add(combobox_torneo);
            Controls.Add(label2);
            Controls.Add(label1);
            Margin = new Padding(3, 4, 3, 4);
            Name = "AgregarEquipo";
            Text = "AgregarEquipo";
            Load += AgregarEquipo_Load;
            ResumeLayout(false);
            PerformLayout();
        }

        #endregion

        private Label label1;
        private Label label2;
        private ComboBox combobox_torneo;
        private Label label3;
        private ComboBox combobox_equipo;
        private Button button1;
        private Button button2;
        private Button button3;
    }
}