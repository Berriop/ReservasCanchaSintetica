namespace ReservasCanchaSintetica
{
    partial class PrincipalAdministrador
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
            button1 = new Button();
            button2 = new Button();
            button3 = new Button();
            button4 = new Button();
            SuspendLayout();
            // 
            // label1
            // 
            label1.AutoSize = true;
            label1.Font = new Font("Arial", 16F, FontStyle.Bold);
            label1.ForeColor = Color.Black;
            label1.Location = new Point(335, 44);
            label1.Name = "label1";
            label1.Size = new Size(148, 26);
            label1.TabIndex = 4;
            label1.Text = "BIENVENIDO";
            // 
            // button1
            // 
            button1.Font = new Font("Arial", 14F, FontStyle.Bold);
            button1.Location = new Point(111, 124);
            button1.Name = "button1";
            button1.Size = new Size(200, 80);
            button1.TabIndex = 0;
            button1.Text = "Gestionar Horarios";
            button1.UseVisualStyleBackColor = true;
            // 
            // button2
            // 
            button2.Font = new Font("Arial", 14F, FontStyle.Bold);
            button2.Location = new Point(494, 124);
            button2.Name = "button2";
            button2.Size = new Size(200, 80);
            button2.TabIndex = 1;
            button2.Text = "Estadísticas";
            button2.UseVisualStyleBackColor = true;
            // 
            // button3
            // 
            button3.Font = new Font("Arial", 14F, FontStyle.Bold);
            button3.Location = new Point(111, 271);
            button3.Name = "button3";
            button3.Size = new Size(200, 80);
            button3.TabIndex = 2;
            button3.Text = "Torneos";
            button3.UseVisualStyleBackColor = true;
            // 
            // button4
            // 
            button4.Font = new Font("Arial", 14F, FontStyle.Bold);
            button4.Location = new Point(494, 271);
            button4.Name = "button4";
            button4.Size = new Size(200, 80);
            button4.TabIndex = 3;
            button4.Text = "Inventario";
            button4.UseVisualStyleBackColor = true;
            // 
            // PrincipalAdministrador
            // 
            AutoScaleDimensions = new SizeF(7F, 15F);
            AutoScaleMode = AutoScaleMode.Font;
            BackgroundImage = Properties.Resources.canchafondo;
            BackgroundImageLayout = ImageLayout.Stretch;
            ClientSize = new Size(800, 450);
            Controls.Add(button4);
            Controls.Add(button3);
            Controls.Add(button2);
            Controls.Add(button1);
            Controls.Add(label1);
            Name = "PrincipalAdministrador";
            Text = "PrincipalAdministrador";
            Load += PrincipalAdministrador_Load;
            ResumeLayout(false);
            PerformLayout();
        }

        #endregion

        private Label label1;
        private Button button1;
        private Button button2;
        private Button button3;
        private Button button4;
    }
}