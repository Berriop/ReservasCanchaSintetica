namespace ReservasCanchaSintetica
{
    partial class Inventario
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
            numericUpDown1 = new NumericUpDown();
            button1 = new Button();
            label3 = new Label();
            numericUpDown2 = new NumericUpDown();
            button2 = new Button();
            listView1 = new ListView();
            ((System.ComponentModel.ISupportInitialize)numericUpDown1).BeginInit();
            ((System.ComponentModel.ISupportInitialize)numericUpDown2).BeginInit();
            SuspendLayout();
            // 
            // label1
            // 
            label1.AutoSize = true;
            label1.Font = new Font("Arial", 20F, FontStyle.Bold);
            label1.ForeColor = Color.Black;
            label1.Location = new Point(300, 20);
            label1.Name = "label1";
            label1.Size = new Size(182, 32);
            label1.TabIndex = 5;
            label1.Text = "INVENTARIO";
            // 
            // label2
            // 
            label2.AutoSize = true;
            label2.Font = new Font("Arial", 12F);
            label2.Location = new Point(138, 123);
            label2.Name = "label2";
            label2.Size = new Size(146, 18);
            label2.TabIndex = 6;
            label2.Text = "Cantidad de Aguas:";
            // 
            // numericUpDown1
            // 
            numericUpDown1.Font = new Font("Arial", 12F);
            numericUpDown1.Location = new Point(329, 115);
            numericUpDown1.Name = "numericUpDown1";
            numericUpDown1.Size = new Size(100, 26);
            numericUpDown1.TabIndex = 7;
            // 
            // button1
            // 
            button1.Font = new Font("Arial", 10F, FontStyle.Bold);
            button1.Location = new Point(463, 115);
            button1.Name = "button1";
            button1.Size = new Size(100, 30);
            button1.TabIndex = 8;
            button1.Text = "Agregar Agua";
            button1.UseVisualStyleBackColor = true;
            // 
            // label3
            // 
            label3.AutoSize = true;
            label3.Font = new Font("Arial", 12F);
            label3.Location = new Point(138, 179);
            label3.Name = "label3";
            label3.Size = new Size(159, 18);
            label3.TabIndex = 9;
            label3.Text = "Cantidad de Balones:";
            // 
            // numericUpDown2
            // 
            numericUpDown2.Font = new Font("Arial", 12F);
            numericUpDown2.Location = new Point(329, 177);
            numericUpDown2.Name = "numericUpDown2";
            numericUpDown2.Size = new Size(100, 26);
            numericUpDown2.TabIndex = 10;
            // 
            // button2
            // 
            button2.Font = new Font("Arial", 10F, FontStyle.Bold);
            button2.Location = new Point(463, 174);
            button2.Name = "button2";
            button2.Size = new Size(100, 30);
            button2.TabIndex = 11;
            button2.Text = "Agregar Balón";
            button2.UseVisualStyleBackColor = true;
            // 
            // listView1
            // 
            listView1.Font = new Font("Arial", 10F);
            listView1.Location = new Point(300, 250);
            listView1.Name = "listView1";
            listView1.Size = new Size(200, 150);
            listView1.TabIndex = 12;
            listView1.UseCompatibleStateImageBehavior = false;
            listView1.View = View.Details;
            // 
            // Inventario
            // 
            AutoScaleDimensions = new SizeF(7F, 15F);
            AutoScaleMode = AutoScaleMode.Font;
            BackgroundImage = Properties.Resources.canchafondo;
            BackgroundImageLayout = ImageLayout.Stretch;
            ClientSize = new Size(800, 450);
            Controls.Add(listView1);
            Controls.Add(button2);
            Controls.Add(numericUpDown2);
            Controls.Add(label3);
            Controls.Add(button1);
            Controls.Add(numericUpDown1);
            Controls.Add(label2);
            Controls.Add(label1);
            Name = "Inventario";
            Text = "Inventario";
            ((System.ComponentModel.ISupportInitialize)numericUpDown1).EndInit();
            ((System.ComponentModel.ISupportInitialize)numericUpDown2).EndInit();
            ResumeLayout(false);
            PerformLayout();
        }


        #endregion

        private Label label1;
        private Label label2;
        private NumericUpDown numericUpDown1;
        private Button button1;
        private Label label3;
        private NumericUpDown numericUpDown2;
        private Button button2;
        private ListView listView1;
    }
}