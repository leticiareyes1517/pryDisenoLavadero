namespace pryDisenoLavadero
{
    partial class formLavado
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
            System.ComponentModel.ComponentResourceManager resources = new System.ComponentModel.ComponentResourceManager(typeof(formLavado));
            lblcliente = new Label();
            lblpatente = new Label();
            lblservicio = new Label();
            lblvehiculo = new Label();
            txtcliente = new TextBox();
            txtpatente = new TextBox();
            txtvehiculo = new TextBox();
            cboservicio = new ComboBox();
            grpentrega = new GroupBox();
            rdbexpress = new RadioButton();
            rdbnormal = new RadioButton();
            chkcliente = new CheckBox();
            btncalcular = new Button();
            btnlimpiar = new Button();
            lblsubtotal = new Label();
            lblrecargo = new Label();
            lbldescuento = new Label();
            lbltotal = new Label();
            grpimporte = new GroupBox();
            grpdatos = new GroupBox();
            grpentrega.SuspendLayout();
            SuspendLayout();
            // 
            // lblcliente
            // 
            lblcliente.AutoSize = true;
            lblcliente.Location = new Point(22, 29);
            lblcliente.Name = "lblcliente";
            lblcliente.Size = new Size(47, 15);
            lblcliente.TabIndex = 0;
            lblcliente.Text = "Cliente:";
            // 
            // lblpatente
            // 
            lblpatente.AutoSize = true;
            lblpatente.Location = new Point(23, 57);
            lblpatente.Name = "lblpatente";
            lblpatente.Size = new Size(50, 15);
            lblpatente.TabIndex = 1;
            lblpatente.Text = "Patente:";
            // 
            // lblservicio
            // 
            lblservicio.AutoSize = true;
            lblservicio.Location = new Point(22, 89);
            lblservicio.Name = "lblservicio";
            lblservicio.Size = new Size(51, 15);
            lblservicio.TabIndex = 2;
            lblservicio.Text = "Servicio:";
            // 
            // lblvehiculo
            // 
            lblvehiculo.AutoSize = true;
            lblvehiculo.Location = new Point(23, 118);
            lblvehiculo.Name = "lblvehiculo";
            lblvehiculo.Size = new Size(95, 15);
            lblvehiculo.TabIndex = 3;
            lblvehiculo.Text = "Vehículos (1 a 5):";
            // 
            // txtcliente
            // 
            txtcliente.Location = new Point(158, 21);
            txtcliente.Name = "txtcliente";
            txtcliente.Size = new Size(159, 23);
            txtcliente.TabIndex = 1;
            // 
            // txtpatente
            // 
            txtpatente.Location = new Point(158, 49);
            txtpatente.MaxLength = 7;
            txtpatente.Name = "txtpatente";
            txtpatente.Size = new Size(89, 23);
            txtpatente.TabIndex = 2;
            // 
            // txtvehiculo
            // 
            txtvehiculo.Location = new Point(158, 110);
            txtvehiculo.MaxLength = 5;
            txtvehiculo.Name = "txtvehiculo";
            txtvehiculo.Size = new Size(44, 23);
            txtvehiculo.TabIndex = 4;
            txtvehiculo.KeyPress += txtvehiculo_KeyPress;
            // 
            // cboservicio
            // 
            cboservicio.FormattingEnabled = true;
            cboservicio.Items.AddRange(new object[] { "Lavado exterior $ 8.000 ", "Lavado completo $ 14.000 ", "Lavado con encerado $ 20.000" });
            cboservicio.Location = new Point(158, 81);
            cboservicio.Name = "cboservicio";
            cboservicio.Size = new Size(121, 23);
            cboservicio.TabIndex = 3;
            // 
            // grpentrega
            // 
            grpentrega.Controls.Add(rdbexpress);
            grpentrega.Controls.Add(rdbnormal);
            grpentrega.Location = new Point(12, 150);
            grpentrega.Name = "grpentrega";
            grpentrega.Size = new Size(305, 63);
            grpentrega.TabIndex = 8;
            grpentrega.TabStop = false;
            grpentrega.Text = "Entrega";
            // 
            // rdbexpress
            // 
            rdbexpress.AutoSize = true;
            rdbexpress.Location = new Point(160, 31);
            rdbexpress.Name = "rdbexpress";
            rdbexpress.Size = new Size(107, 19);
            rdbexpress.TabIndex = 6;
            rdbexpress.TabStop = true;
            rdbexpress.Text = "Express (+25 %)";
            rdbexpress.UseVisualStyleBackColor = true;
            // 
            // rdbnormal
            // 
            rdbnormal.AutoSize = true;
            rdbnormal.Location = new Point(30, 31);
            rdbnormal.Name = "rdbnormal";
            rdbnormal.Size = new Size(65, 19);
            rdbnormal.TabIndex = 5;
            rdbnormal.TabStop = true;
            rdbnormal.Text = "Normal";
            rdbnormal.UseVisualStyleBackColor = true;
            // 
            // chkcliente
            // 
            chkcliente.AutoSize = true;
            chkcliente.Location = new Point(18, 224);
            chkcliente.Name = "chkcliente";
            chkcliente.Size = new Size(171, 19);
            chkcliente.TabIndex = 7;
            chkcliente.Text = "Cliente frecuente (5% extra)";
            chkcliente.UseVisualStyleBackColor = true;
            // 
            // btncalcular
            // 
            btncalcular.Location = new Point(12, 253);
            btncalcular.Name = "btncalcular";
            btncalcular.Size = new Size(141, 23);
            btncalcular.TabIndex = 8;
            btncalcular.Text = "Calcular";
            btncalcular.UseVisualStyleBackColor = true;
            // 
            // btnlimpiar
            // 
            btnlimpiar.Location = new Point(172, 253);
            btnlimpiar.Name = "btnlimpiar";
            btnlimpiar.Size = new Size(145, 23);
            btnlimpiar.TabIndex = 9;
            btnlimpiar.Text = "Limpiar";
            btnlimpiar.UseVisualStyleBackColor = true;
            // 
            // lblsubtotal
            // 
            lblsubtotal.AutoSize = true;
            lblsubtotal.Location = new Point(24, 309);
            lblsubtotal.Name = "lblsubtotal";
            lblsubtotal.Size = new Size(54, 15);
            lblsubtotal.TabIndex = 12;
            lblsubtotal.Text = "Subtotal:";
            // 
            // lblrecargo
            // 
            lblrecargo.AutoSize = true;
            lblrecargo.Location = new Point(24, 339);
            lblrecargo.Name = "lblrecargo";
            lblrecargo.Size = new Size(53, 15);
            lblrecargo.TabIndex = 13;
            lblrecargo.Text = "Recargo:";
            // 
            // lbldescuento
            // 
            lbldescuento.AutoSize = true;
            lbldescuento.Location = new Point(24, 368);
            lbldescuento.Name = "lbldescuento";
            lbldescuento.Size = new Size(66, 15);
            lbldescuento.TabIndex = 14;
            lbldescuento.Text = "Descuento:";
            // 
            // lbltotal
            // 
            lbltotal.AutoSize = true;
            lbltotal.Location = new Point(24, 398);
            lbltotal.Name = "lbltotal";
            lbltotal.Size = new Size(78, 15);
            lbltotal.TabIndex = 15;
            lbltotal.Text = "Total a pagar:";
            lbltotal.Click += label2_Click;
            // 
            // grpimporte
            // 
            grpimporte.Location = new Point(10, 291);
            grpimporte.Name = "grpimporte";
            grpimporte.Size = new Size(307, 150);
            grpimporte.TabIndex = 10;
            grpimporte.TabStop = false;
            grpimporte.Text = "Importe";
            // 
            // grpdatos
            // 
            grpdatos.Location = new Point(11, 9);
            grpdatos.Name = "grpdatos";
            grpdatos.Size = new Size(306, 276);
            grpdatos.TabIndex = 17;
            grpdatos.TabStop = false;
            grpdatos.Text = "Datos del lavado:";
            // 
            // formLavado
            // 
            AutoScaleDimensions = new SizeF(7F, 15F);
            AutoScaleMode = AutoScaleMode.Font;
            ClientSize = new Size(329, 461);
            Controls.Add(lbltotal);
            Controls.Add(lbldescuento);
            Controls.Add(lblrecargo);
            Controls.Add(lblsubtotal);
            Controls.Add(btnlimpiar);
            Controls.Add(btncalcular);
            Controls.Add(chkcliente);
            Controls.Add(cboservicio);
            Controls.Add(txtvehiculo);
            Controls.Add(txtpatente);
            Controls.Add(txtcliente);
            Controls.Add(lblvehiculo);
            Controls.Add(lblservicio);
            Controls.Add(lblpatente);
            Controls.Add(lblcliente);
            Controls.Add(grpentrega);
            Controls.Add(grpimporte);
            Controls.Add(grpdatos);
            Icon = (Icon)resources.GetObject("$this.Icon");
            Name = "formLavado";
            StartPosition = FormStartPosition.CenterScreen;
            Text = "Lavadero Los Andes - Cálculo del servicio";
            grpentrega.ResumeLayout(false);
            grpentrega.PerformLayout();
            ResumeLayout(false);
            PerformLayout();
        }

        #endregion

        private Label lblcliente;
        private Label lblpatente;
        private Label lblservicio;
        private Label lblvehiculo;
        private TextBox txtcliente;
        private TextBox txtpatente;
        private TextBox txtvehiculo;
        private ComboBox cboservicio;
        private GroupBox grpentrega;
        private RadioButton rdbexpress;
        private RadioButton rdbnormal;
        private CheckBox chkcliente;
        private Button btncalcular;
        private Button btnlimpiar;
        private Label lblsubtotal;
        private Label lblrecargo;
        private Label lbldescuento;
        private Label lbltotal;
        private GroupBox grpimporte;
        private GroupBox grpdatos;
    }
}
