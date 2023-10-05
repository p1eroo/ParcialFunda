namespace APDAYC_Ejercicio1_EP202302
{
    partial class formReport2
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
            btnBuscReg = new Button();
            groupBox2 = new GroupBox();
            tbNombre = new TextBox();
            label4 = new Label();
            btnSalir = new Button();
            label1 = new Label();
            listView3 = new ListView();
            columnHeader8 = new ColumnHeader();
            columnHeader9 = new ColumnHeader();
            columnHeader10 = new ColumnHeader();
            columnHeader11 = new ColumnHeader();
            columnHeader12 = new ColumnHeader();
            columnHeader13 = new ColumnHeader();
            columnHeader14 = new ColumnHeader();
            groupBox2.SuspendLayout();
            SuspendLayout();
            // 
            // btnBuscReg
            // 
            btnBuscReg.Location = new Point(27, 60);
            btnBuscReg.Name = "btnBuscReg";
            btnBuscReg.Size = new Size(255, 23);
            btnBuscReg.TabIndex = 25;
            btnBuscReg.Text = "Buscar por Nombre";
            btnBuscReg.UseVisualStyleBackColor = true;
            btnBuscReg.Click += btnBuscReg_Click;
            // 
            // groupBox2
            // 
            groupBox2.Controls.Add(tbNombre);
            groupBox2.Controls.Add(btnBuscReg);
            groupBox2.Controls.Add(label4);
            groupBox2.Location = new Point(27, 99);
            groupBox2.Name = "groupBox2";
            groupBox2.Size = new Size(300, 100);
            groupBox2.TabIndex = 44;
            groupBox2.TabStop = false;
            // 
            // tbNombre
            // 
            tbNombre.Location = new Point(127, 27);
            tbNombre.Name = "tbNombre";
            tbNombre.Size = new Size(155, 23);
            tbNombre.TabIndex = 26;
            
            // 
            // label4
            // 
            label4.AutoSize = true;
            label4.Location = new Point(19, 31);
            label4.Name = "label4";
            label4.Size = new Size(98, 15);
            label4.TabIndex = 19;
            label4.Text = "Nombre director:";
            // 
            // btnSalir
            // 
            btnSalir.Location = new Point(88, 359);
            btnSalir.Name = "btnSalir";
            btnSalir.Size = new Size(197, 39);
            btnSalir.TabIndex = 46;
            btnSalir.Text = "Salir";
            btnSalir.UseVisualStyleBackColor = true;
            // 
            // label1
            // 
            label1.AutoSize = true;
            label1.Font = new Font("Segoe UI", 15.75F, FontStyle.Bold, GraphicsUnit.Point);
            label1.Location = new Point(417, 9);
            label1.Name = "label1";
            label1.Size = new Size(91, 30);
            label1.TabIndex = 47;
            label1.Text = "Reporte";
            // 
            // listView3
            // 
            listView3.Columns.AddRange(new ColumnHeader[] { columnHeader8, columnHeader9, columnHeader10, columnHeader11, columnHeader12, columnHeader13, columnHeader14 });
            listView3.Location = new Point(346, 65);
            listView3.Name = "listView3";
            listView3.Size = new Size(563, 412);
            listView3.TabIndex = 48;
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
            // formReport2
            // 
            AutoScaleDimensions = new SizeF(7F, 15F);
            AutoScaleMode = AutoScaleMode.Font;
            BackColor = SystemColors.GradientActiveCaption;
            ClientSize = new Size(921, 489);
            Controls.Add(listView3);
            Controls.Add(label1);
            Controls.Add(btnSalir);
            Controls.Add(groupBox2);
            Name = "formReport2";
            Text = "formReport2";
            groupBox2.ResumeLayout(false);
            groupBox2.PerformLayout();
            ResumeLayout(false);
            PerformLayout();
        }

        #endregion
        private Button btnBuscReg;
        private GroupBox groupBox2;
        private Button btnSalir;
        private Label label1;
        private TextBox tbNombre;
        private Label label4;
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