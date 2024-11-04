namespace ReservasCanchaSintetica
{
    partial class MisReservas
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
            button1 = new Button();
            button2 = new Button();
            SuspendLayout();
            // 
            // label1
            // 
            label1.AutoSize = true;
            label1.Font = new Font("Arial", 16F, FontStyle.Bold);
            label1.ForeColor = Color.Black;
            label1.Location = new Point(299, 47);
            label1.Name = "label1";
            label1.Size = new Size(175, 26);
            label1.TabIndex = 0;
            label1.Text = "MIS RESERVAS";
            // 
            // label2
            // 
            label2.AutoSize = true;
            label2.Font = new Font("Arial", 14F);
            label2.Location = new Point(53, 118);
            label2.Name = "label2";
            label2.Size = new Size(357, 22);
            label2.TabIndex = 1;
            label2.Text = "Tienes una reserva el desde las hasta las";
            // 
            // button1
            // 
            button1.AutoSize = true;
            button1.Font = new Font("Arial", 14F, FontStyle.Bold);
            button1.Location = new Point(623, 113);
            button1.Name = "button1";
            button1.Size = new Size(125, 32);
            button1.TabIndex = 2;
            button1.Text = "CANCELAR";
            button1.UseVisualStyleBackColor = true;
            // 
            // button2
            // 
            button2.Location = new Point(673, 401);
            button2.Font = new Font("Arial", 10);
            button2.Name = "button2";
            button2.AutoSize = true;
            button2.TabIndex = 3;
            button2.Text = "Regresar";
            button2.UseVisualStyleBackColor = true;
            // 
            // MisReservas
            // 
            AutoScaleDimensions = new SizeF(7F, 15F);
            AutoScaleMode = AutoScaleMode.Font;
            BackgroundImage = Properties.Resources.canchafondo;
            BackgroundImageLayout = ImageLayout.Stretch;
            ClientSize = new Size(800, 450);
            Controls.Add(button2);
            Controls.Add(button1);
            Controls.Add(label2);
            Controls.Add(label1);
            Name = "MisReservas";
            Text = "MisReservas";
            ResumeLayout(false);
            PerformLayout();
        }

        #endregion

        private Label label1;
        private Label label2;
        private Button button1;
        private Button button2;
    }
}