namespace APDAYC_Ejercicio1_EP202302
{
    partial class formPelicula
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
            btnAgregar = new Button();
            listView1 = new ListView();
            columnHeader1 = new ColumnHeader();
            columnHeader2 = new ColumnHeader();
            columnHeader3 = new ColumnHeader();
            columnHeader4 = new ColumnHeader();
            columnHeader5 = new ColumnHeader();
            columnHeader6 = new ColumnHeader();
            columnHeader7 = new ColumnHeader();
            groupBox1 = new GroupBox();
            tbDuracion = new TextBox();
            tbEstado = new TextBox();
            label7 = new Label();
            label6 = new Label();
            tbAnioEstreno = new TextBox();
            cbGenero = new ComboBox();
            tbTaquillaG = new TextBox();
            label5 = new Label();
            tbName = new TextBox();
            tbCod = new TextBox();
            label4 = new Label();
            label3 = new Label();
            label2 = new Label();
            label1 = new Label();
            groupBox1.SuspendLayout();
            SuspendLayout();
            // 
            // btnAgregar
            // 
            btnAgregar.Location = new Point(479, 320);
            btnAgregar.Name = "btnAgregar";
            btnAgregar.Size = new Size(97, 23);
            btnAgregar.TabIndex = 5;
            btnAgregar.Text = "Agregar";
            btnAgregar.UseVisualStyleBackColor = true;
            btnAgregar.Click += btnAgregar_Click;
            // 
            // listView1
            // 
            listView1.Columns.AddRange(new ColumnHeader[] { columnHeader1, columnHeader2, columnHeader3, columnHeader4, columnHeader5, columnHeader6, columnHeader7 });
            listView1.Location = new Point(26, 349);
            listView1.Name = "listView1";
            listView1.Size = new Size(563, 213);
            listView1.TabIndex = 4;
            listView1.UseCompatibleStateImageBehavior = false;
            listView1.View = View.Details;
            // 
            // columnHeader1
            // 
            columnHeader1.Text = "Código";
            // 
            // columnHeader2
            // 
            columnHeader2.Text = "Nombre";
            columnHeader2.Width = 80;
            // 
            // columnHeader3
            // 
            columnHeader3.Text = "Género";
            // 
            // columnHeader4
            // 
            columnHeader4.Text = "Estado";
            // 
            // columnHeader5
            // 
            columnHeader5.Text = "Duración";
            // 
            // columnHeader6
            // 
            columnHeader6.Text = "Taquilla Generada";
            columnHeader6.Width = 110;
            // 
            // columnHeader7
            // 
            columnHeader7.Text = "Año de Estreno";
            columnHeader7.Width = 110;
            // 
            // groupBox1
            // 
            groupBox1.Controls.Add(tbDuracion);
            groupBox1.Controls.Add(tbEstado);
            groupBox1.Controls.Add(label7);
            groupBox1.Controls.Add(label6);
            groupBox1.Controls.Add(tbAnioEstreno);
            groupBox1.Controls.Add(cbGenero);
            groupBox1.Controls.Add(tbTaquillaG);
            groupBox1.Controls.Add(label5);
            groupBox1.Controls.Add(tbName);
            groupBox1.Controls.Add(tbCod);
            groupBox1.Controls.Add(label4);
            groupBox1.Controls.Add(label3);
            groupBox1.Controls.Add(label2);
            groupBox1.Controls.Add(label1);
            groupBox1.Location = new Point(26, 26);
            groupBox1.Name = "groupBox1";
            groupBox1.Size = new Size(320, 287);
            groupBox1.TabIndex = 3;
            groupBox1.TabStop = false;
            groupBox1.Text = "Director";
            // 
            // tbDuracion
            // 
            tbDuracion.Location = new Point(141, 163);
            tbDuracion.Name = "tbDuracion";
            tbDuracion.Size = new Size(142, 23);
            tbDuracion.TabIndex = 14;
            // 
            // tbEstado
            // 
            tbEstado.Location = new Point(141, 132);
            tbEstado.Name = "tbEstado";
            tbEstado.Size = new Size(142, 23);
            tbEstado.TabIndex = 13;
            // 
            // label7
            // 
            label7.AutoSize = true;
            label7.Location = new Point(18, 171);
            label7.Name = "label7";
            label7.Size = new Size(58, 15);
            label7.TabIndex = 12;
            label7.Text = "Duración:";
            // 
            // label6
            // 
            label6.AutoSize = true;
            label6.Location = new Point(18, 140);
            label6.Name = "label6";
            label6.Size = new Size(42, 15);
            label6.TabIndex = 11;
            label6.Text = "Estado";
            // 
            // tbAnioEstreno
            // 
            tbAnioEstreno.Location = new Point(141, 225);
            tbAnioEstreno.Name = "tbAnioEstreno";
            tbAnioEstreno.Size = new Size(142, 23);
            tbAnioEstreno.TabIndex = 10;
            // 
            // cbGenero
            // 
            cbGenero.FormattingEnabled = true;
            cbGenero.Items.AddRange(new object[] { "Terror", "Comedia", "Drama", "Ciencia Ficción", "Anime" });
            cbGenero.Location = new Point(141, 98);
            cbGenero.Name = "cbGenero";
            cbGenero.Size = new Size(142, 23);
            cbGenero.TabIndex = 9;
            // 
            // tbTaquillaG
            // 
            tbTaquillaG.Location = new Point(141, 196);
            tbTaquillaG.Name = "tbTaquillaG";
            tbTaquillaG.Size = new Size(142, 23);
            tbTaquillaG.TabIndex = 7;
            // 
            // label5
            // 
            label5.AutoSize = true;
            label5.Location = new Point(18, 204);
            label5.Name = "label5";
            label5.Size = new Size(103, 15);
            label5.TabIndex = 6;
            label5.Text = "Taquilla Generada:";
            // 
            // tbName
            // 
            tbName.Location = new Point(141, 69);
            tbName.Name = "tbName";
            tbName.Size = new Size(142, 23);
            tbName.TabIndex = 5;
            // 
            // tbCod
            // 
            tbCod.Location = new Point(141, 40);
            tbCod.Name = "tbCod";
            tbCod.Size = new Size(142, 23);
            tbCod.TabIndex = 4;
            // 
            // label4
            // 
            label4.AutoSize = true;
            label4.Location = new Point(18, 107);
            label4.Name = "label4";
            label4.Size = new Size(48, 15);
            label4.TabIndex = 3;
            label4.Text = "Género:";
            // 
            // label3
            // 
            label3.AutoSize = true;
            label3.Location = new Point(18, 234);
            label3.Name = "label3";
            label3.Size = new Size(90, 15);
            label3.TabIndex = 2;
            label3.Text = "Año de estreno:";
            // 
            // label2
            // 
            label2.AutoSize = true;
            label2.Location = new Point(18, 76);
            label2.Name = "label2";
            label2.Size = new Size(54, 15);
            label2.TabIndex = 1;
            label2.Text = "Nombre:";
            // 
            // label1
            // 
            label1.AutoSize = true;
            label1.Location = new Point(18, 43);
            label1.Name = "label1";
            label1.Size = new Size(49, 15);
            label1.TabIndex = 0;
            label1.Text = "Código:";
            // 
            // formPelicula
            // 
            AutoScaleDimensions = new SizeF(7F, 15F);
            AutoScaleMode = AutoScaleMode.Font;
            ClientSize = new Size(609, 575);
            Controls.Add(btnAgregar);
            Controls.Add(listView1);
            Controls.Add(groupBox1);
            Name = "formPelicula";
            Text = "formPelicula";
            groupBox1.ResumeLayout(false);
            groupBox1.PerformLayout();
            ResumeLayout(false);
        }

        #endregion

        private Button btnAgregar;
        private ListView listView1;
        private ColumnHeader columnHeader1;
        private ColumnHeader columnHeader2;
        private ColumnHeader columnHeader3;
        private ColumnHeader columnHeader4;
        private ColumnHeader columnHeader5;
        private GroupBox groupBox1;
        private ComboBox cbGenero;
        private TextBox tbTaquillaG;
        private Label label5;
        private TextBox tbName;
        private TextBox tbCod;
        private Label label4;
        private Label label3;
        private Label label2;
        private Label label1;
        private TextBox tbDuracion;
        private TextBox tbEstado;
        private Label label7;
        private Label label6;
        private TextBox tbAnioEstreno;
        private ColumnHeader columnHeader6;
        private ColumnHeader columnHeader7;
    }
}