namespace APDAYC_Ejercicio1_EP202302
{
    partial class formAgregarDirectorApeli
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
            listViewPrim = new ListView();
            columnHeader1 = new ColumnHeader();
            columnHeader2 = new ColumnHeader();
            columnHeader3 = new ColumnHeader();
            columnHeader4 = new ColumnHeader();
            columnHeader5 = new ColumnHeader();
            columnHeader6 = new ColumnHeader();
            columnHeader7 = new ColumnHeader();
            button1 = new Button();
            cbDirector = new ComboBox();
            label1 = new Label();
            listViewSEg = new ListView();
            DNI = new ColumnHeader();
            columnHeader15 = new ColumnHeader();
            listViewTree = new ListView();
            columnHeader8 = new ColumnHeader();
            columnHeader9 = new ColumnHeader();
            columnHeader10 = new ColumnHeader();
            columnHeader11 = new ColumnHeader();
            columnHeader12 = new ColumnHeader();
            columnHeader13 = new ColumnHeader();
            columnHeader14 = new ColumnHeader();
            label2 = new Label();
            label3 = new Label();
            groupBox1.SuspendLayout();
            SuspendLayout();
            // 
            // groupBox1
            // 
            groupBox1.Controls.Add(listViewPrim);
            groupBox1.Controls.Add(button1);
            groupBox1.Controls.Add(cbDirector);
            groupBox1.Controls.Add(label1);
            groupBox1.Location = new Point(12, 12);
            groupBox1.Name = "groupBox1";
            groupBox1.Size = new Size(604, 256);
            groupBox1.TabIndex = 0;
            groupBox1.TabStop = false;
            // 
            // listViewPrim
            // 
            listViewPrim.Columns.AddRange(new ColumnHeader[] { columnHeader1, columnHeader2, columnHeader3, columnHeader4, columnHeader5, columnHeader6, columnHeader7 });
            listViewPrim.Location = new Point(22, 65);
            listViewPrim.Name = "listViewPrim";
            listViewPrim.Size = new Size(563, 178);
            listViewPrim.TabIndex = 6;
            listViewPrim.UseCompatibleStateImageBehavior = false;
            listViewPrim.View = View.Details;
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
            // button1
            // 
            button1.Location = new Point(431, 23);
            button1.Name = "button1";
            button1.Size = new Size(117, 23);
            button1.TabIndex = 2;
            button1.Text = "Agregar";
            button1.UseVisualStyleBackColor = true;
            button1.Click += button1_Click;
            // 
            // cbDirector
            // 
            cbDirector.FormattingEnabled = true;
            cbDirector.Location = new Point(122, 23);
            cbDirector.Name = "cbDirector";
            cbDirector.Size = new Size(147, 23);
            cbDirector.TabIndex = 1;
            // 
            // label1
            // 
            label1.AutoSize = true;
            label1.Location = new Point(38, 26);
            label1.Name = "label1";
            label1.Size = new Size(52, 15);
            label1.TabIndex = 0;
            label1.Text = "Director:";
            // 
            // listViewSEg
            // 
            listViewSEg.Columns.AddRange(new ColumnHeader[] { DNI, columnHeader15 });
            listViewSEg.Location = new Point(25, 311);
            listViewSEg.Name = "listViewSEg";
            listViewSEg.Size = new Size(198, 147);
            listViewSEg.TabIndex = 1;
            listViewSEg.UseCompatibleStateImageBehavior = false;
            listViewSEg.View = View.Details;
            listViewSEg.SelectedIndexChanged += listViewSEg_SelectedIndexChanged;
            // 
            // DNI
            // 
            DNI.Text = "DNI";
            DNI.Width = 90;
            // 
            // columnHeader15
            // 
            columnHeader15.Text = "Nombre";
            columnHeader15.Width = 90;
            // 
            // listViewTree
            // 
            listViewTree.Columns.AddRange(new ColumnHeader[] { columnHeader8, columnHeader9, columnHeader10, columnHeader11, columnHeader12, columnHeader13, columnHeader14 });
            listViewTree.Location = new Point(251, 311);
            listViewTree.Name = "listViewTree";
            listViewTree.Size = new Size(563, 147);
            listViewTree.TabIndex = 7;
            listViewTree.UseCompatibleStateImageBehavior = false;
            listViewTree.View = View.Details;
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
            // label2
            // 
            label2.AutoSize = true;
            label2.Location = new Point(34, 284);
            label2.Name = "label2";
            label2.Size = new Size(49, 15);
            label2.TabIndex = 8;
            label2.Text = "Director";
            // 
            // label3
            // 
            label3.AutoSize = true;
            label3.Location = new Point(251, 284);
            label3.Name = "label3";
            label3.Size = new Size(53, 15);
            label3.TabIndex = 9;
            label3.Text = "Peliculas";
            // 
            // formAgregarDirectorApeli
            // 
            AutoScaleDimensions = new SizeF(7F, 15F);
            AutoScaleMode = AutoScaleMode.Font;
            ClientSize = new Size(835, 470);
            Controls.Add(label3);
            Controls.Add(label2);
            Controls.Add(listViewTree);
            Controls.Add(listViewSEg);
            Controls.Add(groupBox1);
            Name = "formAgregarDirectorApeli";
            Text = "formAgregarDirectorApeli";
            Load += formAgregarDirectorApeli_Load;
            groupBox1.ResumeLayout(false);
            groupBox1.PerformLayout();
            ResumeLayout(false);
            PerformLayout();
        }

        #endregion

        private GroupBox groupBox1;
        private Button button1;
        private ComboBox cbDirector;
        private Label label1;
        private ListView listViewPrim;
        private ColumnHeader columnHeader1;
        private ColumnHeader columnHeader2;
        private ColumnHeader columnHeader3;
        private ColumnHeader columnHeader4;
        private ColumnHeader columnHeader5;
        private ColumnHeader columnHeader6;
        private ColumnHeader columnHeader7;
        private ListView listViewSEg;
        private ColumnHeader DNI;
        private ColumnHeader columnHeader15;
        private ListView listViewTree;
        private ColumnHeader columnHeader8;
        private ColumnHeader columnHeader9;
        private ColumnHeader columnHeader10;
        private ColumnHeader columnHeader11;
        private ColumnHeader columnHeader12;
        private ColumnHeader columnHeader13;
        private ColumnHeader columnHeader14;
        private Label label2;
        private Label label3;
    }
}