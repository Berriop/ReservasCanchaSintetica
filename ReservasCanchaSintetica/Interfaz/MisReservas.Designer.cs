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
            button1 = new Button();
            button2 = new Button();
            dataGridView1 = new DataGridView();
            Id = new DataGridViewTextBoxColumn();
            Fecha = new DataGridViewTextBoxColumn();
            CanchaId = new DataGridViewTextBoxColumn();
            CantidadHoras = new DataGridViewTextBoxColumn();
            CantidadAguas = new DataGridViewTextBoxColumn();
            CantidadBalones = new DataGridViewTextBoxColumn();
            HoraInicio = new DataGridViewTextBoxColumn();
            Precio = new DataGridViewTextBoxColumn();
            ((System.ComponentModel.ISupportInitialize)dataGridView1).BeginInit();
            SuspendLayout();
            // 
            // label1
            // 
            label1.AutoSize = true;
            label1.Font = new Font("Arial", 16F, FontStyle.Bold);
            label1.ForeColor = Color.Black;
            label1.Location = new Point(434, 47);
            label1.Name = "label1";
            label1.Size = new Size(216, 32);
            label1.TabIndex = 0;
            label1.Text = "MIS RESERVAS";
            // 
            // button1
            // 
            button1.AutoSize = true;
            button1.Font = new Font("Arial", 14F, FontStyle.Bold);
            button1.Location = new Point(454, 535);
            button1.Margin = new Padding(3, 4, 3, 4);
            button1.Name = "button1";
            button1.Size = new Size(156, 43);
            button1.TabIndex = 2;
            button1.Text = "CANCELAR";
            button1.UseVisualStyleBackColor = true;
            button1.Click += button1_Click;
            // 
            // button2
            // 
            button2.AutoSize = true;
            button2.Font = new Font("Arial", 10F);
            button2.Location = new Point(769, 535);
            button2.Margin = new Padding(3, 4, 3, 4);
            button2.Name = "button2";
            button2.Size = new Size(86, 31);
            button2.TabIndex = 3;
            button2.Text = "Regresar";
            button2.UseVisualStyleBackColor = true;
            button2.Click += button2_Click;
            // 
            // dataGridView1
            // 
            dataGridView1.ColumnHeadersHeightSizeMode = DataGridViewColumnHeadersHeightSizeMode.AutoSize;
            dataGridView1.Columns.AddRange(new DataGridViewColumn[] { Id, Fecha, CanchaId, CantidadHoras, CantidadAguas, CantidadBalones, HoraInicio, Precio });
            dataGridView1.Location = new Point(12, 107);
            dataGridView1.Name = "dataGridView1";
            dataGridView1.RowHeadersWidth = 51;
            dataGridView1.Size = new Size(1043, 377);
            dataGridView1.TabIndex = 4;
            // 
            // Id
            // 
            Id.HeaderText = "Id";
            Id.MinimumWidth = 6;
            Id.Name = "Id";
            Id.Width = 125;
            // 
            // Fecha
            // 
            Fecha.HeaderText = "Fecha";
            Fecha.MinimumWidth = 6;
            Fecha.Name = "Fecha";
            Fecha.Width = 125;
            // 
            // CanchaId
            // 
            CanchaId.HeaderText = "Cancha";
            CanchaId.MinimumWidth = 6;
            CanchaId.Name = "CanchaId";
            CanchaId.Width = 125;
            // 
            // CantidadHoras
            // 
            CantidadHoras.HeaderText = "Cantidad Horas";
            CantidadHoras.MinimumWidth = 6;
            CantidadHoras.Name = "CantidadHoras";
            CantidadHoras.Width = 125;
            // 
            // CantidadAguas
            // 
            CantidadAguas.HeaderText = "Cantidad Aguas";
            CantidadAguas.MinimumWidth = 6;
            CantidadAguas.Name = "CantidadAguas";
            CantidadAguas.Width = 125;
            // 
            // CantidadBalones
            // 
            CantidadBalones.HeaderText = "Cantidad Balones";
            CantidadBalones.MinimumWidth = 6;
            CantidadBalones.Name = "CantidadBalones";
            CantidadBalones.Width = 125;
            // 
            // HoraInicio
            // 
            HoraInicio.HeaderText = "Hora Inicio";
            HoraInicio.MinimumWidth = 6;
            HoraInicio.Name = "HoraInicio";
            HoraInicio.Width = 125;
            // 
            // Precio
            // 
            Precio.HeaderText = "Precio";
            Precio.MinimumWidth = 6;
            Precio.Name = "Precio";
            Precio.Width = 125;
            // 
            // MisReservas
            // 
            AutoScaleDimensions = new SizeF(8F, 20F);
            AutoScaleMode = AutoScaleMode.Font;
            BackgroundImage = Properties.Resources.canchafondo;
            BackgroundImageLayout = ImageLayout.Stretch;
            ClientSize = new Size(1067, 672);
            Controls.Add(dataGridView1);
            Controls.Add(button2);
            Controls.Add(button1);
            Controls.Add(label1);
            Margin = new Padding(3, 4, 3, 4);
            Name = "MisReservas";
            Text = "MisReservas";
            Load += MisReservas_Load;
            ((System.ComponentModel.ISupportInitialize)dataGridView1).EndInit();
            ResumeLayout(false);
            PerformLayout();
        }

        #endregion

        private Label label1;
        private Button button1;
        private Button button2;
        private DataGridView dataGridView1;
        private DataGridViewTextBoxColumn Id;
        private DataGridViewTextBoxColumn Fecha;
        private DataGridViewTextBoxColumn CanchaId;
        private DataGridViewTextBoxColumn CantidadHoras;
        private DataGridViewTextBoxColumn CantidadAguas;
        private DataGridViewTextBoxColumn CantidadBalones;
        private DataGridViewTextBoxColumn HoraInicio;
        private DataGridViewTextBoxColumn Precio;
    }
}