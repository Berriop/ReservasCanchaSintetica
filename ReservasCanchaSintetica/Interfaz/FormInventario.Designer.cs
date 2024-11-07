namespace ReservasCanchaSintetica
{
    partial class FormInventario : Form
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
            numericdown_aguas = new NumericUpDown();
            button1 = new Button();
            label3 = new Label();
            numericdown_balones = new NumericUpDown();
            button3 = new Button();
            datagrid_inventario = new DataGridView();
            CantidadBalones = new DataGridViewTextBoxColumn();
            CantidadAguas = new DataGridViewTextBoxColumn();
            ((System.ComponentModel.ISupportInitialize)numericdown_aguas).BeginInit();
            ((System.ComponentModel.ISupportInitialize)numericdown_balones).BeginInit();
            ((System.ComponentModel.ISupportInitialize)datagrid_inventario).BeginInit();
            SuspendLayout();
            // 
            // label1
            // 
            label1.AutoSize = true;
            label1.Font = new Font("Arial", 20F, FontStyle.Bold);
            label1.ForeColor = Color.Black;
            label1.Location = new Point(343, 27);
            label1.Name = "label1";
            label1.Size = new Size(223, 40);
            label1.TabIndex = 5;
            label1.Text = "INVENTARIO";
            // 
            // label2
            // 
            label2.AutoSize = true;
            label2.Font = new Font("Arial", 12F);
            label2.Location = new Point(158, 164);
            label2.Name = "label2";
            label2.Size = new Size(182, 23);
            label2.TabIndex = 6;
            label2.Text = "Cantidad de Aguas:";
            // 
            // numericdown_aguas
            // 
            numericdown_aguas.Font = new Font("Arial", 12F);
            numericdown_aguas.Location = new Point(376, 153);
            numericdown_aguas.Margin = new Padding(3, 4, 3, 4);
            numericdown_aguas.Name = "numericdown_aguas";
            numericdown_aguas.Size = new Size(114, 30);
            numericdown_aguas.TabIndex = 7;
            // 
            // button1
            // 
            button1.Font = new Font("Arial", 10F, FontStyle.Bold);
            button1.Location = new Point(523, 186);
            button1.Margin = new Padding(3, 4, 3, 4);
            button1.Name = "button1";
            button1.Size = new Size(114, 40);
            button1.TabIndex = 8;
            button1.Text = "Agregar Agua";
            button1.UseVisualStyleBackColor = true;
            button1.Click += button1_Click;
            // 
            // label3
            // 
            label3.AutoSize = true;
            label3.Font = new Font("Arial", 12F);
            label3.Location = new Point(158, 239);
            label3.Name = "label3";
            label3.Size = new Size(198, 23);
            label3.TabIndex = 9;
            label3.Text = "Cantidad de Balones:";
            // 
            // numericdown_balones
            // 
            numericdown_balones.Font = new Font("Arial", 12F);
            numericdown_balones.Location = new Point(376, 236);
            numericdown_balones.Margin = new Padding(3, 4, 3, 4);
            numericdown_balones.Name = "numericdown_balones";
            numericdown_balones.Size = new Size(114, 30);
            numericdown_balones.TabIndex = 10;
            // 
            // button3
            // 
            button3.AutoSize = true;
            button3.Font = new Font("Arial", 10F);
            button3.Location = new Point(769, 535);
            button3.Margin = new Padding(3, 4, 3, 4);
            button3.Name = "button3";
            button3.Size = new Size(86, 31);
            button3.TabIndex = 0;
            button3.Text = "Regresar";
            button3.UseVisualStyleBackColor = true;
            button3.Click += button3_Click;
            // 
            // dataGridView1
            // 
            datagrid_inventario.ColumnHeadersHeightSizeMode = DataGridViewColumnHeadersHeightSizeMode.AutoSize;
            datagrid_inventario.Columns.AddRange(new DataGridViewColumn[] { CantidadBalones, CantidadAguas });
            datagrid_inventario.Location = new Point(262, 371);
            datagrid_inventario.Name = "dataGridView1";
            datagrid_inventario.RowHeadersWidth = 51;
            datagrid_inventario.Size = new Size(304, 60);
            datagrid_inventario.TabIndex = 11;
            // 
            // CantidadBalones
            // 
            CantidadBalones.HeaderText = "CantidadBalones";
            CantidadBalones.MinimumWidth = 6;
            CantidadBalones.Name = "CantidadBalones";
            CantidadBalones.Width = 125;
            // 
            // CantidadAguas
            // 
            CantidadAguas.HeaderText = "CantidadAguas";
            CantidadAguas.MinimumWidth = 6;
            CantidadAguas.Name = "CantidadAguas";
            CantidadAguas.Width = 125;
            // 
            // FormInventario
            // 
            AutoScaleDimensions = new SizeF(8F, 20F);
            AutoScaleMode = AutoScaleMode.Font;
            BackgroundImage = Properties.Resources.canchafondo;
            BackgroundImageLayout = ImageLayout.Stretch;
            ClientSize = new Size(914, 600);
            Controls.Add(datagrid_inventario);
            Controls.Add(button3);
            Controls.Add(numericdown_balones);
            Controls.Add(label3);
            Controls.Add(button1);
            Controls.Add(numericdown_aguas);
            Controls.Add(label2);
            Controls.Add(label1);
            Margin = new Padding(3, 4, 3, 4);
            Name = "FormInventario";
            Text = "Inventario";
            Load += FormInventario_Load;
            ((System.ComponentModel.ISupportInitialize)numericdown_aguas).EndInit();
            ((System.ComponentModel.ISupportInitialize)numericdown_balones).EndInit();
            ((System.ComponentModel.ISupportInitialize)datagrid_inventario).EndInit();
            ResumeLayout(false);
            PerformLayout();
        }


        #endregion

        private Label label1;
        private Label label2;
        private NumericUpDown numericdown_aguas;
        private Button button1;
        private Label label3;
        private NumericUpDown numericdown_balones;
        private Button button3;
        private DataGridView datagrid_inventario;
        private DataGridViewTextBoxColumn CantidadBalones;
        private DataGridViewTextBoxColumn CantidadAguas;
    }
}