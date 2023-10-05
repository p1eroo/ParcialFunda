namespace APDAYC_Ejercicio1_EP202302
{
    partial class formDirector
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
            groupBox1 = new GroupBox();
            tbCod = new TextBox();
            cbEstado = new ComboBox();
            cbSexo = new ComboBox();
            tbTelef = new TextBox();
            label5 = new Label();
            tbName = new TextBox();
            label4 = new Label();
            label3 = new Label();
            label2 = new Label();
            label1 = new Label();
            listView1 = new ListView();
            columnHeader1 = new ColumnHeader();
            columnHeader2 = new ColumnHeader();
            columnHeader3 = new ColumnHeader();
            columnHeader4 = new ColumnHeader();
            columnHeader5 = new ColumnHeader();
            btnAgregar = new Button();
            groupBox1.SuspendLayout();
            SuspendLayout();
            // 
            // groupBox1
            // 
            groupBox1.Controls.Add(tbCod);
            groupBox1.Controls.Add(cbEstado);
            groupBox1.Controls.Add(cbSexo);
            groupBox1.Controls.Add(tbTelef);
            groupBox1.Controls.Add(label5);
            groupBox1.Controls.Add(tbName);
            groupBox1.Controls.Add(label4);
            groupBox1.Controls.Add(label3);
            groupBox1.Controls.Add(label2);
            groupBox1.Controls.Add(label1);
            groupBox1.Location = new Point(26, 23);
            groupBox1.Name = "groupBox1";
            groupBox1.Size = new Size(356, 211);
            groupBox1.TabIndex = 4;
            groupBox1.TabStop = false;
            groupBox1.Text = "Director";
            // 
            // tbCod
            // 
            tbCod.Location = new Point(141, 35);
            tbCod.Name = "tbCod";
            tbCod.Size = new Size(142, 23);
            tbCod.TabIndex = 10;
            // 
            // cbEstado
            // 
            cbEstado.FormattingEnabled = true;
            cbEstado.Items.AddRange(new object[] { "Terror", "Comedia", "Drama", "Ciencia Ficción", "Anime" });
            cbEstado.Location = new Point(141, 132);
            cbEstado.Name = "cbEstado";
            cbEstado.Size = new Size(142, 23);
            cbEstado.TabIndex = 9;
            // 
            // cbSexo
            // 
            cbSexo.FormattingEnabled = true;
            cbSexo.Items.AddRange(new object[] { "Femenino", "Masculino" });
            cbSexo.Location = new Point(141, 98);
            cbSexo.Name = "cbSexo";
            cbSexo.Size = new Size(142, 23);
            cbSexo.TabIndex = 8;
            // 
            // tbTelef
            // 
            tbTelef.Location = new Point(141, 161);
            tbTelef.Name = "tbTelef";
            tbTelef.Size = new Size(142, 23);
            tbTelef.TabIndex = 7;
            // 
            // label5
            // 
            label5.AutoSize = true;
            label5.Location = new Point(18, 169);
            label5.Name = "label5";
            label5.Size = new Size(55, 15);
            label5.TabIndex = 6;
            label5.Text = "Telefono:";
            // 
            // tbName
            // 
            tbName.Location = new Point(141, 69);
            tbName.Name = "tbName";
            tbName.Size = new Size(142, 23);
            tbName.TabIndex = 5;
            // 
            // label4
            // 
            label4.AutoSize = true;
            label4.Location = new Point(18, 140);
            label4.Name = "label4";
            label4.Size = new Size(45, 15);
            label4.TabIndex = 3;
            label4.Text = "Estado:";
            // 
            // label3
            // 
            label3.AutoSize = true;
            label3.Location = new Point(18, 106);
            label3.Name = "label3";
            label3.Size = new Size(35, 15);
            label3.TabIndex = 2;
            label3.Text = "Sexo:";
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
            label1.Size = new Size(30, 15);
            label1.TabIndex = 0;
            label1.Text = "DNI:";
            // 
            // listView1
            // 
            listView1.Columns.AddRange(new ColumnHeader[] { columnHeader1, columnHeader2, columnHeader3, columnHeader4, columnHeader5 });
            listView1.Location = new Point(26, 298);
            listView1.Name = "listView1";
            listView1.Size = new Size(359, 213);
            listView1.TabIndex = 1;
            listView1.UseCompatibleStateImageBehavior = false;
            listView1.View = View.Details;
            listView1.SelectedIndexChanged += listView1_SelectedIndexChanged;
            // 
            // columnHeader1
            // 
            columnHeader1.Text = "DNI";
            // 
            // columnHeader2
            // 
            columnHeader2.Text = "Nombre";
            columnHeader2.Width = 80;
            // 
            // columnHeader3
            // 
            columnHeader3.Text = "Sexo";
            // 
            // columnHeader4
            // 
            columnHeader4.Text = "Estado";
            // 
            // columnHeader5
            // 
            columnHeader5.Text = "Télefono";
            // 
            // btnAgregar
            // 
            btnAgregar.Location = new Point(307, 252);
            btnAgregar.Name = "btnAgregar";
            btnAgregar.Size = new Size(75, 23);
            btnAgregar.TabIndex = 2;
            btnAgregar.Text = "Agregar";
            btnAgregar.UseVisualStyleBackColor = true;
            btnAgregar.Click += btnAgregar_Click;
            // 
            // formDirector
            // 
            AutoScaleDimensions = new SizeF(7F, 15F);
            AutoScaleMode = AutoScaleMode.Font;
            ClientSize = new Size(406, 522);
            Controls.Add(btnAgregar);
            Controls.Add(listView1);
            Controls.Add(groupBox1);
            Name = "formDirector";
            Text = "v";
            Load += formDirector_Load;
            groupBox1.ResumeLayout(false);
            groupBox1.PerformLayout();
            ResumeLayout(false);
        }

        #endregion

        private GroupBox groupBox1;
        private ComboBox cbEstado;
        private ComboBox cbSexo;
        private TextBox tbTelef;
        private Label label5;
        private TextBox tbName;
        private Label label4;
        private Label label3;
        private Label label2;
        private Label label1;
        private ListView listView1;
        private ColumnHeader columnHeader1;
        private ColumnHeader columnHeader2;
        private ColumnHeader columnHeader3;
        private ColumnHeader columnHeader4;
        private ColumnHeader columnHeader5;
        private Button btnAgregar;
        private TextBox tbCod;
    }
}