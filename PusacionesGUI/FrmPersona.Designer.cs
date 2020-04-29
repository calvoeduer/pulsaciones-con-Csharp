namespace PusacionesGUI
{
    partial class FrmPersona
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
            this.label1 = new System.Windows.Forms.Label();
            this.TxtIdendificacion = new System.Windows.Forms.TextBox();
            this.TxtNombre = new System.Windows.Forms.TextBox();
            this.Nombre = new System.Windows.Forms.Label();
            this.TxtEdad = new System.Windows.Forms.TextBox();
            this.Sexo = new System.Windows.Forms.Label();
            this.label4 = new System.Windows.Forms.Label();
            this.TxtPulsaciones = new System.Windows.Forms.TextBox();
            this.label5 = new System.Windows.Forms.Label();
            this.CmbSexo = new System.Windows.Forms.ComboBox();
            this.BtnGuardar = new System.Windows.Forms.Button();
            this.BtnEliminar = new System.Windows.Forms.Button();
            this.BtnEditar = new System.Windows.Forms.Button();
            this.BtnBuscar = new System.Windows.Forms.Button();
            this.BtnCalcularPulsacion = new System.Windows.Forms.Button();
            this.TxtEmail = new System.Windows.Forms.TextBox();
            this.label2 = new System.Windows.Forms.Label();
            this.Consultar = new System.Windows.Forms.Button();
            this.SuspendLayout();
            // 
            // label1
            // 
            this.label1.AutoSize = true;
            this.label1.Location = new System.Drawing.Point(52, 68);
            this.label1.Name = "label1";
            this.label1.Size = new System.Drawing.Size(70, 13);
            this.label1.TabIndex = 0;
            this.label1.Text = "Identificacion";
            this.label1.Click += new System.EventHandler(this.Label1_Click);
            // 
            // TxtIdendificacion
            // 
            this.TxtIdendificacion.Location = new System.Drawing.Point(155, 65);
            this.TxtIdendificacion.Name = "TxtIdendificacion";
            this.TxtIdendificacion.Size = new System.Drawing.Size(171, 20);
            this.TxtIdendificacion.TabIndex = 1;
            // 
            // TxtNombre
            // 
            this.TxtNombre.Location = new System.Drawing.Point(155, 108);
            this.TxtNombre.Name = "TxtNombre";
            this.TxtNombre.Size = new System.Drawing.Size(171, 20);
            this.TxtNombre.TabIndex = 3;
            // 
            // Nombre
            // 
            this.Nombre.AutoSize = true;
            this.Nombre.Location = new System.Drawing.Point(78, 111);
            this.Nombre.Name = "Nombre";
            this.Nombre.Size = new System.Drawing.Size(44, 13);
            this.Nombre.TabIndex = 2;
            this.Nombre.Text = "Nombre";
            // 
            // TxtEdad
            // 
            this.TxtEdad.Location = new System.Drawing.Point(155, 151);
            this.TxtEdad.Name = "TxtEdad";
            this.TxtEdad.Size = new System.Drawing.Size(171, 20);
            this.TxtEdad.TabIndex = 5;
            // 
            // Sexo
            // 
            this.Sexo.AutoSize = true;
            this.Sexo.Location = new System.Drawing.Point(90, 154);
            this.Sexo.Name = "Sexo";
            this.Sexo.Size = new System.Drawing.Size(32, 13);
            this.Sexo.TabIndex = 4;
            this.Sexo.Text = "Edad";
            // 
            // label4
            // 
            this.label4.AutoSize = true;
            this.label4.Location = new System.Drawing.Point(91, 197);
            this.label4.Name = "label4";
            this.label4.Size = new System.Drawing.Size(31, 13);
            this.label4.TabIndex = 6;
            this.label4.Text = "Sexo";
            // 
            // TxtPulsaciones
            // 
            this.TxtPulsaciones.Location = new System.Drawing.Point(155, 265);
            this.TxtPulsaciones.Name = "TxtPulsaciones";
            this.TxtPulsaciones.ReadOnly = true;
            this.TxtPulsaciones.Size = new System.Drawing.Size(171, 20);
            this.TxtPulsaciones.TabIndex = 9;
            // 
            // label5
            // 
            this.label5.AutoSize = true;
            this.label5.Location = new System.Drawing.Point(69, 267);
            this.label5.Name = "label5";
            this.label5.Size = new System.Drawing.Size(53, 13);
            this.label5.TabIndex = 8;
            this.label5.Text = "Pulsacion";
            // 
            // CmbSexo
            // 
            this.CmbSexo.FormattingEnabled = true;
            this.CmbSexo.Items.AddRange(new object[] {
            "M",
            "F"});
            this.CmbSexo.Location = new System.Drawing.Point(155, 193);
            this.CmbSexo.Name = "CmbSexo";
            this.CmbSexo.Size = new System.Drawing.Size(171, 21);
            this.CmbSexo.TabIndex = 10;
            // 
            // BtnGuardar
            // 
            this.BtnGuardar.BackColor = System.Drawing.Color.CadetBlue;
            this.BtnGuardar.BackgroundImage = global::PusacionesGUI.Properties.Resources.fondo_tra_;
            this.BtnGuardar.Image = global::PusacionesGUI.Properties.Resources.save_78348__1_;
            this.BtnGuardar.ImageAlign = System.Drawing.ContentAlignment.TopCenter;
            this.BtnGuardar.Location = new System.Drawing.Point(43, 305);
            this.BtnGuardar.Margin = new System.Windows.Forms.Padding(0);
            this.BtnGuardar.Name = "BtnGuardar";
            this.BtnGuardar.Size = new System.Drawing.Size(112, 59);
            this.BtnGuardar.TabIndex = 11;
            this.BtnGuardar.Text = "Guardar";
            this.BtnGuardar.TextAlign = System.Drawing.ContentAlignment.BottomCenter;
            this.BtnGuardar.UseVisualStyleBackColor = false;
            this.BtnGuardar.Click += new System.EventHandler(this.BtnGuardar_Click);
            // 
            // BtnEliminar
            // 
            this.BtnEliminar.BackColor = System.Drawing.Color.CadetBlue;
            this.BtnEliminar.Image = global::PusacionesGUI.Properties.Resources.garbage_78344;
            this.BtnEliminar.ImageAlign = System.Drawing.ContentAlignment.TopCenter;
            this.BtnEliminar.Location = new System.Drawing.Point(409, 305);
            this.BtnEliminar.Name = "BtnEliminar";
            this.BtnEliminar.Size = new System.Drawing.Size(112, 59);
            this.BtnEliminar.TabIndex = 15;
            this.BtnEliminar.Text = "Eliminar";
            this.BtnEliminar.TextAlign = System.Drawing.ContentAlignment.BottomCenter;
            this.BtnEliminar.UseVisualStyleBackColor = false;
            this.BtnEliminar.Click += new System.EventHandler(this.BtnEliminar_Click);
            // 
            // BtnEditar
            // 
            this.BtnEditar.BackColor = System.Drawing.Color.CadetBlue;
            this.BtnEditar.Image = global::PusacionesGUI.Properties.Resources.flat_style_circle_edit_icon_icons_com_66939;
            this.BtnEditar.ImageAlign = System.Drawing.ContentAlignment.TopCenter;
            this.BtnEditar.Location = new System.Drawing.Point(287, 305);
            this.BtnEditar.Name = "BtnEditar";
            this.BtnEditar.Size = new System.Drawing.Size(98, 59);
            this.BtnEditar.TabIndex = 14;
            this.BtnEditar.Text = "Editar";
            this.BtnEditar.TextAlign = System.Drawing.ContentAlignment.BottomCenter;
            this.BtnEditar.UseVisualStyleBackColor = false;
            this.BtnEditar.Click += new System.EventHandler(this.BtnEditar_Click);
            // 
            // BtnBuscar
            // 
            this.BtnBuscar.BackColor = System.Drawing.Color.CadetBlue;
            this.BtnBuscar.Image = global::PusacionesGUI.Properties.Resources.buscar;
            this.BtnBuscar.ImageAlign = System.Drawing.ContentAlignment.TopCenter;
            this.BtnBuscar.Location = new System.Drawing.Point(165, 305);
            this.BtnBuscar.Name = "BtnBuscar";
            this.BtnBuscar.Size = new System.Drawing.Size(112, 59);
            this.BtnBuscar.TabIndex = 12;
            this.BtnBuscar.Text = "Buscar";
            this.BtnBuscar.TextAlign = System.Drawing.ContentAlignment.BottomCenter;
            this.BtnBuscar.UseVisualStyleBackColor = false;
            this.BtnBuscar.Click += new System.EventHandler(this.BtnBuscar_Click);
            // 
            // BtnCalcularPulsacion
            // 
            this.BtnCalcularPulsacion.Image = global::PusacionesGUI.Properties.Resources._1486504349_calculate_calculation_education_business_calculator_math_81324;
            this.BtnCalcularPulsacion.ImageAlign = System.Drawing.ContentAlignment.TopCenter;
            this.BtnCalcularPulsacion.Location = new System.Drawing.Point(384, 147);
            this.BtnCalcularPulsacion.Name = "BtnCalcularPulsacion";
            this.BtnCalcularPulsacion.Size = new System.Drawing.Size(75, 66);
            this.BtnCalcularPulsacion.TabIndex = 16;
            this.BtnCalcularPulsacion.Text = "Pulsacion";
            this.BtnCalcularPulsacion.TextAlign = System.Drawing.ContentAlignment.BottomCenter;
            this.BtnCalcularPulsacion.UseVisualStyleBackColor = true;
            this.BtnCalcularPulsacion.Click += new System.EventHandler(this.BtnCalcularPulsacion_Click);
            // 
            // TxtEmail
            // 
            this.TxtEmail.Location = new System.Drawing.Point(154, 229);
            this.TxtEmail.Name = "TxtEmail";
            this.TxtEmail.Size = new System.Drawing.Size(171, 20);
            this.TxtEmail.TabIndex = 17;
            // 
            // label2
            // 
            this.label2.AutoSize = true;
            this.label2.Location = new System.Drawing.Point(87, 232);
            this.label2.Name = "label2";
            this.label2.Size = new System.Drawing.Size(35, 13);
            this.label2.TabIndex = 18;
            this.label2.Text = "E-mail";
            // 
            // Consultar
            // 
            this.Consultar.Image = global::PusacionesGUI.Properties.Resources.buscar;
            this.Consultar.ImageAlign = System.Drawing.ContentAlignment.TopCenter;
            this.Consultar.Location = new System.Drawing.Point(351, 65);
            this.Consultar.Name = "Consultar";
            this.Consultar.Size = new System.Drawing.Size(108, 20);
            this.Consultar.TabIndex = 19;
            this.Consultar.Text = "Consultar";
            this.Consultar.TextAlign = System.Drawing.ContentAlignment.BottomCenter;
            this.Consultar.UseVisualStyleBackColor = true;
            this.Consultar.Click += new System.EventHandler(this.Consultar_Click);
            // 
            // FrmPersona
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(6F, 13F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.BackgroundImage = global::PusacionesGUI.Properties.Resources.fondo_tra_;
            this.ClientSize = new System.Drawing.Size(598, 393);
            this.Controls.Add(this.Consultar);
            this.Controls.Add(this.label2);
            this.Controls.Add(this.TxtEmail);
            this.Controls.Add(this.BtnCalcularPulsacion);
            this.Controls.Add(this.BtnGuardar);
            this.Controls.Add(this.BtnEliminar);
            this.Controls.Add(this.BtnEditar);
            this.Controls.Add(this.BtnBuscar);
            this.Controls.Add(this.CmbSexo);
            this.Controls.Add(this.TxtPulsaciones);
            this.Controls.Add(this.label5);
            this.Controls.Add(this.label4);
            this.Controls.Add(this.TxtEdad);
            this.Controls.Add(this.Sexo);
            this.Controls.Add(this.TxtNombre);
            this.Controls.Add(this.Nombre);
            this.Controls.Add(this.TxtIdendificacion);
            this.Controls.Add(this.label1);
            this.Name = "FrmPersona";
            this.Text = "FrmPersona";
            this.Load += new System.EventHandler(this.FrmPersona_Load);
            this.MouseMove += new System.Windows.Forms.MouseEventHandler(this.FrmPersona_MouseMove);
            this.ResumeLayout(false);
            this.PerformLayout();

        }

        #endregion

        private System.Windows.Forms.Label label1;
        private System.Windows.Forms.TextBox TxtIdendificacion;
        private System.Windows.Forms.TextBox TxtNombre;
        private System.Windows.Forms.Label Nombre;
        private System.Windows.Forms.TextBox TxtEdad;
        private System.Windows.Forms.Label Sexo;
        private System.Windows.Forms.Label label4;
        private System.Windows.Forms.TextBox TxtPulsaciones;
        private System.Windows.Forms.Label label5;
        private System.Windows.Forms.ComboBox CmbSexo;
        private System.Windows.Forms.Button BtnGuardar;
        private System.Windows.Forms.Button BtnBuscar;
        private System.Windows.Forms.Button BtnEditar;
        private System.Windows.Forms.Button BtnEliminar;
        private System.Windows.Forms.Button BtnCalcularPulsacion;
        private System.Windows.Forms.TextBox TxtEmail;
        private System.Windows.Forms.Label label2;
        private System.Windows.Forms.Button Consultar;
    }
}