namespace ParcialJonathanBenigni2023
{
    partial class Form1
    {
        /// <summary>
        ///  Required designer variable.
        /// </summary>
        private System.ComponentModel.IContainer components = null;

        /// <summary>
        ///  Clean up any resources being used.
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
        ///  Required method for Designer support - do not modify
        ///  the contents of this method with the code editor.
        /// </summary>
        private void InitializeComponent()
        {
            panel1 = new Panel();
            dataGridView1 = new DataGridView();
            ColorCubo = new DataGridViewTextBoxColumn();
            Trazos = new DataGridViewTextBoxColumn();
            Arista = new DataGridViewTextBoxColumn();
            Volumen = new DataGridViewTextBoxColumn();
            Area = new DataGridViewTextBoxColumn();
            button1 = new Button();
            label1 = new Label();
            comboBox1 = new ComboBox();
            button2 = new Button();
            button3 = new Button();
            button4 = new Button();
            button5 = new Button();
            panel1.SuspendLayout();
            ((System.ComponentModel.ISupportInitialize)dataGridView1).BeginInit();
            SuspendLayout();
            // 
            // panel1
            // 
            panel1.Controls.Add(dataGridView1);
            panel1.Dock = DockStyle.Top;
            panel1.Location = new Point(0, 0);
            panel1.Name = "panel1";
            panel1.Size = new Size(800, 404);
            panel1.TabIndex = 0;
            // 
            // dataGridView1
            // 
            dataGridView1.ColumnHeadersHeightSizeMode = DataGridViewColumnHeadersHeightSizeMode.AutoSize;
            dataGridView1.Columns.AddRange(new DataGridViewColumn[] { ColorCubo, Trazos, Arista, Volumen, Area });
            dataGridView1.Dock = DockStyle.Fill;
            dataGridView1.Location = new Point(0, 0);
            dataGridView1.Name = "dataGridView1";
            dataGridView1.RowHeadersWidth = 51;
            dataGridView1.RowTemplate.Height = 29;
            dataGridView1.Size = new Size(800, 404);
            dataGridView1.TabIndex = 0;
            dataGridView1.CellContentClick += dataGridView1_CellContentClick;
            // 
            // ColorCubo
            // 
            ColorCubo.HeaderText = "Color";
            ColorCubo.MinimumWidth = 6;
            ColorCubo.Name = "ColorCubo";
            ColorCubo.Width = 125;
            // 
            // Trazos
            // 
            Trazos.HeaderText = "Trazos";
            Trazos.MinimumWidth = 6;
            Trazos.Name = "Trazos";
            Trazos.Width = 125;
            // 
            // Arista
            // 
            Arista.HeaderText = "Arista";
            Arista.MinimumWidth = 6;
            Arista.Name = "Arista";
            Arista.Width = 125;
            // 
            // Volumen
            // 
            Volumen.HeaderText = "Volumen";
            Volumen.MinimumWidth = 6;
            Volumen.Name = "Volumen";
            Volumen.Width = 125;
            // 
            // Area
            // 
            Area.HeaderText = "Area";
            Area.MinimumWidth = 6;
            Area.Name = "Area";
            Area.Width = 125;
            // 
            // button1
            // 
            button1.Location = new Point(12, 410);
            button1.Name = "button1";
            button1.Size = new Size(105, 39);
            button1.TabIndex = 1;
            button1.Text = "Agregar";
            button1.UseVisualStyleBackColor = true;
            button1.Click += button1_Click;
            // 
            // label1
            // 
            label1.AutoSize = true;
            label1.Location = new Point(624, 419);
            label1.Name = "label1";
            label1.Size = new Size(70, 20);
            label1.TabIndex = 2;
            label1.Text = "Registros";
            // 
            // comboBox1
            // 
            comboBox1.AllowDrop = true;
            comboBox1.FormattingEnabled = true;
            comboBox1.Location = new Point(721, 416);
            comboBox1.Name = "comboBox1";
            comboBox1.Size = new Size(67, 28);
            comboBox1.TabIndex = 3;
            comboBox1.SelectedIndexChanged += comboBox1_SelectedIndexChanged;
            // 
            // button2
            // 
            button2.Location = new Point(135, 410);
            button2.Name = "button2";
            button2.Size = new Size(105, 39);
            button2.TabIndex = 4;
            button2.Text = "Editar";
            button2.UseVisualStyleBackColor = true;
            // 
            // button3
            // 
            button3.Location = new Point(258, 410);
            button3.Name = "button3";
            button3.Size = new Size(105, 39);
            button3.TabIndex = 5;
            button3.Text = "Borrar";
            button3.UseVisualStyleBackColor = true;
            // 
            // button4
            // 
            button4.Location = new Point(386, 410);
            button4.Name = "button4";
            button4.Size = new Size(105, 39);
            button4.TabIndex = 6;
            button4.Text = "Ordenar";
            button4.UseVisualStyleBackColor = true;
            // 
            // button5
            // 
            button5.Location = new Point(497, 410);
            button5.Name = "button5";
            button5.Size = new Size(105, 39);
            button5.TabIndex = 7;
            button5.Text = "Filtrar";
            button5.UseVisualStyleBackColor = true;
            // 
            // Form1
            // 
            AutoScaleDimensions = new SizeF(8F, 20F);
            AutoScaleMode = AutoScaleMode.Font;
            ClientSize = new Size(800, 450);
            Controls.Add(button5);
            Controls.Add(button4);
            Controls.Add(button3);
            Controls.Add(button2);
            Controls.Add(comboBox1);
            Controls.Add(label1);
            Controls.Add(button1);
            Controls.Add(panel1);
            Name = "Form1";
            Text = "Form1";
            Load += Form1_Load;
            panel1.ResumeLayout(false);
            ((System.ComponentModel.ISupportInitialize)dataGridView1).EndInit();
            ResumeLayout(false);
            PerformLayout();
        }

        #endregion

        private Panel panel1;
        private Button button1;
        private DataGridView dataGridView1;
        private Label label1;
        private ComboBox comboBox1;
        private Button button2;
        private Button button3;
        private Button button4;
        private Button button5;
        private DataGridViewTextBoxColumn ColorCubo;
        private DataGridViewTextBoxColumn Trazos;
        private DataGridViewTextBoxColumn Arista;
        private DataGridViewTextBoxColumn Volumen;
        private DataGridViewTextBoxColumn Area;
    }
}