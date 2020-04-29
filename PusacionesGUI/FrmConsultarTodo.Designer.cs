namespace PusacionesGUI
{
    partial class FrmConsultarTodo
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
            this.BtnConsultar = new System.Windows.Forms.Button();
            this.TablaPersonas = new System.Windows.Forms.DataGridView();
            this.TxtTotalPersonas = new System.Windows.Forms.TextBox();
            this.TxtTotalHombres = new System.Windows.Forms.TextBox();
            this.TxtTotalMujeres = new System.Windows.Forms.TextBox();
            this.TxtSumaPulsaciones = new System.Windows.Forms.TextBox();
            this.TxtSumaPulsacionHombre = new System.Windows.Forms.TextBox();
            this.TxtSumaPulsacionMujeres = new System.Windows.Forms.TextBox();
            this.label1 = new System.Windows.Forms.Label();
            this.label2 = new System.Windows.Forms.Label();
            this.label3 = new System.Windows.Forms.Label();
            this.label4 = new System.Windows.Forms.Label();
            this.label5 = new System.Windows.Forms.Label();
            this.label6 = new System.Windows.Forms.Label();
            this.label7 = new System.Windows.Forms.Label();
            this.CmbConsultarPorSexo = new System.Windows.Forms.ComboBox();
            this.BtnGenerarPdf = new System.Windows.Forms.Button();
            ((System.ComponentModel.ISupportInitialize)(this.TablaPersonas)).BeginInit();
            this.SuspendLayout();
            // 
            // BtnConsultar
            // 
            this.BtnConsultar.BackColor = System.Drawing.SystemColors.ActiveCaption;
            this.BtnConsultar.Image = global::PusacionesGUI.Properties.Resources.buscar;
            this.BtnConsultar.ImageAlign = System.Drawing.ContentAlignment.TopCenter;
            this.BtnConsultar.Location = new System.Drawing.Point(177, 323);
            this.BtnConsultar.Name = "BtnConsultar";
            this.BtnConsultar.Size = new System.Drawing.Size(360, 56);
            this.BtnConsultar.TabIndex = 1;
            this.BtnConsultar.Text = "Consultar";
            this.BtnConsultar.TextAlign = System.Drawing.ContentAlignment.BottomCenter;
            this.BtnConsultar.UseVisualStyleBackColor = false;
            this.BtnConsultar.Click += new System.EventHandler(this.BtnConsultar_Click);
            // 
            // TablaPersonas
            // 
            this.TablaPersonas.ColumnHeadersHeightSizeMode = System.Windows.Forms.DataGridViewColumnHeadersHeightSizeMode.AutoSize;
            this.TablaPersonas.Location = new System.Drawing.Point(92, 47);
            this.TablaPersonas.Name = "TablaPersonas";
            this.TablaPersonas.Size = new System.Drawing.Size(542, 264);
            this.TablaPersonas.TabIndex = 0;
            this.TablaPersonas.CellContentClick += new System.Windows.Forms.DataGridViewCellEventHandler(this.TablaPersonas_CellContentClick);
            this.TablaPersonas.CellDoubleClick += new System.Windows.Forms.DataGridViewCellEventHandler(this.TablaPersonas_CellDoubleClick);
           
            // 
            // TxtTotalPersonas
            // 
            this.TxtTotalPersonas.BackColor = System.Drawing.Color.Lavender;
            this.TxtTotalPersonas.BorderStyle = System.Windows.Forms.BorderStyle.FixedSingle;
            this.TxtTotalPersonas.Location = new System.Drawing.Point(88, 391);
            this.TxtTotalPersonas.Name = "TxtTotalPersonas";
            this.TxtTotalPersonas.ReadOnly = true;
            this.TxtTotalPersonas.Size = new System.Drawing.Size(61, 20);
            this.TxtTotalPersonas.TabIndex = 2;
            // 
            // TxtTotalHombres
            // 
            this.TxtTotalHombres.BackColor = System.Drawing.Color.Lavender;
            this.TxtTotalHombres.BorderStyle = System.Windows.Forms.BorderStyle.FixedSingle;
            this.TxtTotalHombres.Location = new System.Drawing.Point(288, 391);
            this.TxtTotalHombres.Name = "TxtTotalHombres";
            this.TxtTotalHombres.ReadOnly = true;
            this.TxtTotalHombres.Size = new System.Drawing.Size(61, 20);
            this.TxtTotalHombres.TabIndex = 3;
            // 
            // TxtTotalMujeres
            // 
            this.TxtTotalMujeres.BackColor = System.Drawing.Color.Lavender;
            this.TxtTotalMujeres.BorderStyle = System.Windows.Forms.BorderStyle.FixedSingle;
            this.TxtTotalMujeres.Location = new System.Drawing.Point(188, 391);
            this.TxtTotalMujeres.Name = "TxtTotalMujeres";
            this.TxtTotalMujeres.ReadOnly = true;
            this.TxtTotalMujeres.Size = new System.Drawing.Size(61, 20);
            this.TxtTotalMujeres.TabIndex = 4;
            // 
            // TxtSumaPulsaciones
            // 
            this.TxtSumaPulsaciones.BackColor = System.Drawing.Color.Lavender;
            this.TxtSumaPulsaciones.BorderStyle = System.Windows.Forms.BorderStyle.FixedSingle;
            this.TxtSumaPulsaciones.Location = new System.Drawing.Point(388, 391);
            this.TxtSumaPulsaciones.Name = "TxtSumaPulsaciones";
            this.TxtSumaPulsaciones.ReadOnly = true;
            this.TxtSumaPulsaciones.Size = new System.Drawing.Size(61, 20);
            this.TxtSumaPulsaciones.TabIndex = 5;
            // 
            // TxtSumaPulsacionHombre
            // 
            this.TxtSumaPulsacionHombre.BackColor = System.Drawing.Color.Lavender;
            this.TxtSumaPulsacionHombre.BorderStyle = System.Windows.Forms.BorderStyle.FixedSingle;
            this.TxtSumaPulsacionHombre.Location = new System.Drawing.Point(488, 391);
            this.TxtSumaPulsacionHombre.Name = "TxtSumaPulsacionHombre";
            this.TxtSumaPulsacionHombre.ReadOnly = true;
            this.TxtSumaPulsacionHombre.Size = new System.Drawing.Size(61, 20);
            this.TxtSumaPulsacionHombre.TabIndex = 6;
            // 
            // TxtSumaPulsacionMujeres
            // 
            this.TxtSumaPulsacionMujeres.BackColor = System.Drawing.Color.Lavender;
            this.TxtSumaPulsacionMujeres.BorderStyle = System.Windows.Forms.BorderStyle.FixedSingle;
            this.TxtSumaPulsacionMujeres.Location = new System.Drawing.Point(588, 391);
            this.TxtSumaPulsacionMujeres.Name = "TxtSumaPulsacionMujeres";
            this.TxtSumaPulsacionMujeres.ReadOnly = true;
            this.TxtSumaPulsacionMujeres.Size = new System.Drawing.Size(61, 20);
            this.TxtSumaPulsacionMujeres.TabIndex = 8;
            // 
            // label1
            // 
            this.label1.AutoSize = true;
            this.label1.Location = new System.Drawing.Point(85, 414);
            this.label1.Name = "label1";
            this.label1.Size = new System.Drawing.Size(75, 13);
            this.label1.TabIndex = 9;
            this.label1.Text = "TotalPersonas";
            // 
            // label2
            // 
            this.label2.AutoSize = true;
            this.label2.Location = new System.Drawing.Point(184, 414);
            this.label2.Name = "label2";
            this.label2.Size = new System.Drawing.Size(68, 13);
            this.label2.TabIndex = 10;
            this.label2.Text = "TotalMujeres";
            // 
            // label3
            // 
            this.label3.AutoSize = true;
            this.label3.Location = new System.Drawing.Point(281, 414);
            this.label3.Name = "label3";
            this.label3.Size = new System.Drawing.Size(73, 13);
            this.label3.TabIndex = 11;
            this.label3.Text = "TotalHombres";
            // 
            // label4
            // 
            this.label4.AutoSize = true;
            this.label4.Location = new System.Drawing.Point(385, 414);
            this.label4.Name = "label4";
            this.label4.Size = new System.Drawing.Size(80, 13);
            this.label4.TabIndex = 12;
            this.label4.Text = "SumaPulsacion";
            // 
            // label5
            // 
            this.label5.AutoSize = true;
            this.label5.Location = new System.Drawing.Point(471, 414);
            this.label5.Name = "label5";
            this.label5.Size = new System.Drawing.Size(95, 13);
            this.label5.TabIndex = 13;
            this.label5.Text = "PulsacionHombres";
            // 
            // label6
            // 
            this.label6.AutoSize = true;
            this.label6.Location = new System.Drawing.Point(572, 414);
            this.label6.Name = "label6";
            this.label6.Size = new System.Drawing.Size(90, 13);
            this.label6.TabIndex = 14;
            this.label6.Text = "PulsacionMujeres";
            // 
            // label7
            // 
            this.label7.AutoSize = true;
            this.label7.BackColor = System.Drawing.Color.Goldenrod;
            this.label7.Location = new System.Drawing.Point(207, 19);
            this.label7.Name = "label7";
            this.label7.Size = new System.Drawing.Size(42, 13);
            this.label7.TabIndex = 15;
            this.label7.Text = "SEXO: ";
            // 
            // CmbConsultarPorSexo
            // 
            this.CmbConsultarPorSexo.FormattingEnabled = true;
            this.CmbConsultarPorSexo.Items.AddRange(new object[] {
            "FEMENINO",
            "MASCULINO",
            "TODOS"});
            this.CmbConsultarPorSexo.Location = new System.Drawing.Point(284, 16);
            this.CmbConsultarPorSexo.Name = "CmbConsultarPorSexo";
            this.CmbConsultarPorSexo.Size = new System.Drawing.Size(121, 21);
            this.CmbConsultarPorSexo.TabIndex = 16;
            // 
            // BtnGenerarPdf
            // 
            this.BtnGenerarPdf.BackColor = System.Drawing.SystemColors.ActiveCaption;
            this.BtnGenerarPdf.Image = global::PusacionesGUI.Properties.Resources.buscar;
            this.BtnGenerarPdf.ImageAlign = System.Drawing.ContentAlignment.TopCenter;
            this.BtnGenerarPdf.Location = new System.Drawing.Point(678, 147);
            this.BtnGenerarPdf.Name = "BtnGenerarPdf";
            this.BtnGenerarPdf.Size = new System.Drawing.Size(98, 56);
            this.BtnGenerarPdf.TabIndex = 17;
            this.BtnGenerarPdf.Text = "GenerarPdf";
            this.BtnGenerarPdf.TextAlign = System.Drawing.ContentAlignment.BottomCenter;
            this.BtnGenerarPdf.UseVisualStyleBackColor = false;
            this.BtnGenerarPdf.Click += new System.EventHandler(this.BtnGenerarPdf_Click);
            // 
            // FrmConsultarTodo
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(6F, 13F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.BackColor = System.Drawing.SystemColors.Control;
            this.ClientSize = new System.Drawing.Size(812, 487);
            this.Controls.Add(this.BtnGenerarPdf);
            this.Controls.Add(this.CmbConsultarPorSexo);
            this.Controls.Add(this.label7);
            this.Controls.Add(this.label6);
            this.Controls.Add(this.label5);
            this.Controls.Add(this.label4);
            this.Controls.Add(this.label3);
            this.Controls.Add(this.label2);
            this.Controls.Add(this.label1);
            this.Controls.Add(this.TxtSumaPulsacionMujeres);
            this.Controls.Add(this.TxtSumaPulsacionHombre);
            this.Controls.Add(this.TxtSumaPulsaciones);
            this.Controls.Add(this.TxtTotalMujeres);
            this.Controls.Add(this.TxtTotalHombres);
            this.Controls.Add(this.TxtTotalPersonas);
            this.Controls.Add(this.BtnConsultar);
            this.Controls.Add(this.TablaPersonas);
            this.Location = new System.Drawing.Point(50, 25);
            this.Name = "FrmConsultarTodo";
            this.Text = "FrmConsultarTodo";
            this.Load += new System.EventHandler(this.FrmConsultarTodo_Load);
            ((System.ComponentModel.ISupportInitialize)(this.TablaPersonas)).EndInit();
            this.ResumeLayout(false);
            this.PerformLayout();

        }

        #endregion
        private System.Windows.Forms.Button BtnConsultar;
        private System.Windows.Forms.DataGridView TablaPersonas;
        private System.Windows.Forms.TextBox TxtTotalPersonas;
        private System.Windows.Forms.TextBox TxtTotalHombres;
        private System.Windows.Forms.TextBox TxtTotalMujeres;
        private System.Windows.Forms.TextBox TxtSumaPulsaciones;
        private System.Windows.Forms.TextBox TxtSumaPulsacionHombre;
        private System.Windows.Forms.TextBox TxtSumaPulsacionMujeres;
        private System.Windows.Forms.Label label1;
        private System.Windows.Forms.Label label2;
        private System.Windows.Forms.Label label3;
        private System.Windows.Forms.Label label4;
        private System.Windows.Forms.Label label5;
        private System.Windows.Forms.Label label6;
        private System.Windows.Forms.Label label7;
        private System.Windows.Forms.ComboBox CmbConsultarPorSexo;
        private System.Windows.Forms.Button BtnGenerarPdf;
    }
}