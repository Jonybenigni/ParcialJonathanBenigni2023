namespace ParcialJonathanBenigni2023
{
    partial class FormularioAgregarCubo
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
            comboBox1 = new ComboBox();
            ColorCubo = new Label();
            button1 = new Button();
            button2 = new Button();
            comboBox2 = new ComboBox();
            label1 = new Label();
            SuspendLayout();
            // 
            // comboBox1
            // 
            comboBox1.FormattingEnabled = true;
            comboBox1.Location = new Point(174, 55);
            comboBox1.Name = "comboBox1";
            comboBox1.Size = new Size(151, 28);
            comboBox1.TabIndex = 0;
            comboBox1.SelectedIndexChanged += comboBox1_SelectedIndexChanged;
            // 
            // ColorCubo
            // 
            ColorCubo.AutoSize = true;
            ColorCubo.Location = new Point(32, 58);
            ColorCubo.Name = "ColorCubo";
            ColorCubo.Size = new Size(109, 20);
            ColorCubo.TabIndex = 1;
            ColorCubo.Text = "Color del Cubo";
            // 
            // button1
            // 
            button1.Location = new Point(499, 20);
            button1.Name = "button1";
            button1.Size = new Size(166, 97);
            button1.TabIndex = 2;
            button1.Text = "Aceptar";
            button1.UseVisualStyleBackColor = true;
            button1.Click += button1_Click;
            // 
            // button2
            // 
            button2.Location = new Point(499, 143);
            button2.Name = "button2";
            button2.Size = new Size(166, 97);
            button2.TabIndex = 3;
            button2.Text = "Cancelar";
            button2.UseVisualStyleBackColor = true;
            // 
            // comboBox2
            // 
            comboBox2.FormattingEnabled = true;
            comboBox2.Location = new Point(174, 106);
            comboBox2.Name = "comboBox2";
            comboBox2.Size = new Size(151, 28);
            comboBox2.TabIndex = 4;
            comboBox2.SelectedIndexChanged += comboBox2_SelectedIndexChanged;
            // 
            // label1
            // 
            label1.AutoSize = true;
            label1.Location = new Point(32, 106);
            label1.Name = "label1";
            label1.Size = new Size(109, 20);
            label1.TabIndex = 5;
            label1.Text = "Trazo del Cubo";
            // 
            // FormularioAgregarCubo
            // 
            AutoScaleDimensions = new SizeF(8F, 20F);
            AutoScaleMode = AutoScaleMode.Font;
            ClientSize = new Size(800, 287);
            Controls.Add(label1);
            Controls.Add(comboBox2);
            Controls.Add(button2);
            Controls.Add(button1);
            Controls.Add(ColorCubo);
            Controls.Add(comboBox1);
            Name = "FormularioAgregarCubo";
            Text = "Agregar Cubo";
            Load += FormularioAgregarCubo_Load;
            ResumeLayout(false);
            PerformLayout();
        }

        #endregion

        private ComboBox comboBox1;
        private Label ColorCubo;
        private Button button1;
        private Button button2;
        private ComboBox comboBox2;
        private Label label1;
    }
}