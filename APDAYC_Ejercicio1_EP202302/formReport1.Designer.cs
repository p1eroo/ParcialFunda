namespace APDAYC_Ejercicio1_EP202302
{
    partial class formReport1
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
            btnSalir = new Button();
            groupBox2 = new GroupBox();
            btnBuscReg = new Button();
            label4 = new Label();
            groupBox1 = new GroupBox();
            button1 = new Button();
            label2 = new Label();
            cbGenero = new ComboBox();
            listView3 = new ListView();
            columnHeader8 = new ColumnHeader();
            columnHeader9 = new ColumnHeader();
            columnHeader10 = new ColumnHeader();
            columnHeader11 = new ColumnHeader();
            columnHeader12 = new ColumnHeader();
            columnHeader13 = new ColumnHeader();
            columnHeader14 = new ColumnHeader();
            groupBox2.SuspendLayout();
            groupBox1.SuspendLayout();
            SuspendLayout();
            // 
            // label1
            // 
            label1.AutoSize = true;
            label1.Font = new Font("Segoe UI", 15.75F, FontStyle.Bold, GraphicsUnit.Point);
            label1.Location = new Point(137, 23);
            label1.Name = "label1";
            label1.Size = new Size(91, 30);
            label1.TabIndex = 42;
            label1.Text = "Reporte";
            // 
            // btnSalir
            // 
            btnSalir.Location = new Point(93, 368);
            btnSalir.Name = "btnSalir";
            btnSalir.Size = new Size(197, 39);
            btnSalir.TabIndex = 41;
            btnSalir.Text = "Salir";
            btnSalir.UseVisualStyleBackColor = true;
            // 
            // groupBox2
            // 
            groupBox2.Controls.Add(btnBuscReg);
            groupBox2.Controls.Add(label4);
            groupBox2.Location = new Point(26, 218);
            groupBox2.Name = "groupBox2";
            groupBox2.Size = new Size(300, 86);
            groupBox2.TabIndex = 40;
            groupBox2.TabStop = false;
            // 
            // btnBuscReg
            // 
            btnBuscReg.Location = new Point(24, 48);
            btnBuscReg.Name = "btnBuscReg";
            btnBuscReg.Size = new Size(255, 23);
            btnBuscReg.TabIndex = 25;
            btnBuscReg.Text = "Buscar Duración Minima";
            btnBuscReg.UseVisualStyleBackColor = true;
            // 
            // label4
            // 
            label4.AutoSize = true;
            label4.Location = new Point(24, 19);
            label4.Name = "label4";
            label4.Size = new Size(58, 15);
            label4.TabIndex = 19;
            label4.Text = "Duración:";
            // 
            // groupBox1
            // 
            groupBox1.Controls.Add(button1);
            groupBox1.Controls.Add(label2);
            groupBox1.Controls.Add(cbGenero);
            groupBox1.Location = new Point(26, 91);
            groupBox1.Name = "groupBox1";
            groupBox1.Size = new Size(300, 100);
            groupBox1.TabIndex = 41;
            groupBox1.TabStop = false;
            // 
            // button1
            // 
            button1.Location = new Point(27, 60);
            button1.Name = "button1";
            button1.Size = new Size(255, 23);
            button1.TabIndex = 25;
            button1.Text = "Buscar por Género";
            button1.UseVisualStyleBackColor = true;
            button1.Click += button1_Click;
            // 
            // label2
            // 
            label2.AutoSize = true;
            label2.Location = new Point(27, 30);
            label2.Name = "label2";
            label2.Size = new Size(55, 15);
            label2.TabIndex = 19;
            label2.Text = "GÉNERO:";
            // 
            // cbGenero
            // 
            cbGenero.FormattingEnabled = true;
            cbGenero.Items.AddRange(new object[] { "Terror", "Comedia", "Drama", "Ciencia Ficción", "Anime" });
            cbGenero.Location = new Point(110, 22);
            cbGenero.Name = "cbGenero";
            cbGenero.Size = new Size(172, 23);
            cbGenero.TabIndex = 23;
            // 
            // listView3
            // 
            listView3.Columns.AddRange(new ColumnHeader[] { columnHeader8, columnHeader9, columnHeader10, columnHeader11, columnHeader12, columnHeader13, columnHeader14 });
            listView3.Location = new Point(352, 60);
            listView3.Name = "listView3";
            listView3.Size = new Size(563, 412);
            listView3.TabIndex = 43;
            listView3.UseCompatibleStateImageBehavior = false;
            listView3.View = View.Details;
            // 
            // columnHeader8
            // 
            columnHeader8.Text = "Código";
            // 
            // columnHeader9
            // 
            columnHeader9.Text = "Nombre";
            columnHeader9.Width = 80;
            // 
            // columnHeader10
            // 
            columnHeader10.Text = "Género";
            // 
            // columnHeader11
            // 
            columnHeader11.Text = "Estado";
            // 
            // columnHeader12
            // 
            columnHeader12.Text = "Duración";
            // 
            // columnHeader13
            // 
            columnHeader13.Text = "Taquilla Generada";
            columnHeader13.Width = 110;
            // 
            // columnHeader14
            // 
            columnHeader14.Text = "Año de Estreno";
            columnHeader14.Width = 110;
            // 
            // formReport1
            // 
            AutoScaleDimensions = new SizeF(7F, 15F);
            AutoScaleMode = AutoScaleMode.Font;
            BackColor = SystemColors.GradientActiveCaption;
            ClientSize = new Size(927, 553);
            Controls.Add(listView3);
            Controls.Add(groupBox1);
            Controls.Add(label1);
            Controls.Add(btnSalir);
            Controls.Add(groupBox2);
            Name = "formReport1";
            Text = "formReport1";
            groupBox2.ResumeLayout(false);
            groupBox2.PerformLayout();
            groupBox1.ResumeLayout(false);
            groupBox1.PerformLayout();
            ResumeLayout(false);
            PerformLayout();
        }

        #endregion

        private Label label1;
        private Button btnSalir;
        private GroupBox groupBox2;
        private Button btnBuscReg;
        private Label label4;
        private GroupBox groupBox1;
        private Button button1;
        private Label label2;
        private ComboBox cbGenero;
        private ListView listView3;
        private ColumnHeader columnHeader8;
        private ColumnHeader columnHeader9;
        private ColumnHeader columnHeader10;
        private ColumnHeader columnHeader11;
        private ColumnHeader columnHeader12;
        private ColumnHeader columnHeader13;
        private ColumnHeader columnHeader14;
    }
}