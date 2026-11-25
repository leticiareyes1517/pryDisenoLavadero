using System;


namespace pryDisenoLavadero
{
    partial class frmLavado


    {
        /// <summary>
        ///  Required designer variable.
        /// </summary>
        private System.ComponentModel.IContainer components = null;

        /// <summary>
        ///  Clean up any resources being used.
        /// </summary>
        /// <param name="disposing">true if managed resources should be disposed; otherwise, false.</param>
        protected void Dispose(bool disposing)
        {
            if (disposing && (components != null))
            {
                components.Dispose();
            }
            //  base.Dispose(disposing);
        }

        #region Windows Form Designer generated code

        /// <summary>
        ///  Required method for Designer support - do not modify
        ///  the contents of this method with the code editor.
        /// </summary>
        private void InitializeComponent()
        {
            lblcliente = new Label();
            lblpatente = new Label();
            lblservicio = new Label();
            lblvehiculos = new Label();
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
            grpdatos = new GroupBox();
            lblsubtotal = new Label();
            lblrecargo = new Label();
            lbldescuento = new Label();
            lbltotal = new Label();
            grpimporte = new GroupBox();
            lblsub = new Label();
            grpentrega.SuspendLayout();
            grpdatos.SuspendLayout();
            grpimporte.SuspendLayout();
            // SuspendLayout();
            // 
            // lblcliente
            // 
            lblcliente.AutoSize = true;
            lblcliente.Location = new Point(13, 29);
            lblcliente.Name = "lblcliente";
            lblcliente.Size = new Size(47, 15);
            lblcliente.TabIndex = 0;
            lblcliente.Text = "Cliente:";
            // 
            // lblpatente
            // 
            lblpatente.AutoSize = true;
            lblpatente.Location = new Point(14, 59);
            lblpatente.Name = "lblpatente";
            lblpatente.Size = new Size(50, 15);
            lblpatente.TabIndex = 1;
            lblpatente.Text = "Patente:";
            // 
            // lblservicio
            // 
            lblservicio.AutoSize = true;
            lblservicio.Location = new Point(13, 94);
            lblservicio.Name = "lblservicio";
            lblservicio.Size = new Size(51, 15);
            lblservicio.TabIndex = 2;
            lblservicio.Text = "Servicio:";
            // 
            // lblvehiculos
            // 
            lblvehiculos.AutoSize = true;
            lblvehiculos.Location = new Point(12, 129);
            lblvehiculos.Name = "lblvehiculos";
            lblvehiculos.Size = new Size(95, 15);
            lblvehiculos.TabIndex = 3;
            lblvehiculos.Text = "Vehículos (1 a 5):";
            // 
            // txtcliente
            // 
            txtcliente.Location = new Point(154, 26);
            txtcliente.Name = "txtcliente";
            txtcliente.Size = new Size(160, 23);
            txtcliente.TabIndex = 4;
            // 
            // txtpatente
            // 
            txtpatente.Location = new Point(154, 56);
            txtpatente.Name = "txtpatente";
            txtpatente.Size = new Size(108, 23);
            txtpatente.TabIndex = 5;
            // 
            // txtvehiculo
            // 
            txtvehiculo.Location = new Point(154, 121);
            txtvehiculo.Name = "txtvehiculo";
            txtvehiculo.Size = new Size(46, 23);
            txtvehiculo.TabIndex = 6;
            // 
            // cboservicio
            // 
            cboservicio.FormattingEnabled = true;
            cboservicio.Location = new Point(154, 86);
            cboservicio.Name = "cboservicio";
            cboservicio.Size = new Size(160, 23);
            cboservicio.TabIndex = 7;
            // 
            // grpentrega
            // 
            grpentrega.Controls.Add(rdbexpress);
            grpentrega.Controls.Add(rdbnormal);
            grpentrega.Location = new Point(14, 163);
            grpentrega.Name = "grpentrega";
            grpentrega.Size = new Size(323, 53);
            grpentrega.TabIndex = 8;
            grpentrega.TabStop = false;
            grpentrega.Text = "Entrega";
            // 
            // rdbexpress
            // 
            rdbexpress.AutoSize = true;
            rdbexpress.Location = new Point(154, 22);
            rdbexpress.Name = "rdbexpress";
            rdbexpress.Size = new Size(107, 19);
            rdbexpress.TabIndex = 1;
            rdbexpress.TabStop = true;
            rdbexpress.Text = "Express (+25 %)";
            rdbexpress.UseVisualStyleBackColor = true;
            // 
            // rdbnormal
            // 
            rdbnormal.AutoSize = true;
            rdbnormal.Location = new Point(35, 22);
            rdbnormal.Name = "rdbnormal";
            rdbnormal.Size = new Size(65, 19);
            rdbnormal.TabIndex = 0;
            rdbnormal.TabStop = true;
            rdbnormal.Text = "Normal";
            rdbnormal.UseVisualStyleBackColor = true;
            // 
            // chkcliente
            // 
            chkcliente.AutoSize = true;
            chkcliente.Location = new Point(14, 231);
            chkcliente.Name = "chkcliente";
            chkcliente.Size = new Size(174, 19);
            chkcliente.TabIndex = 9;
            chkcliente.Text = "Cliente frecuente (5 % extra)";
            chkcliente.UseVisualStyleBackColor = true;
            // 
            // btncalcular
            // 
            btncalcular.Location = new Point(14, 256);
            btncalcular.Name = "btncalcular";
            btncalcular.Size = new Size(145, 23);
            btncalcular.TabIndex = 10;
            btncalcular.Text = "Calcular";
            btncalcular.UseVisualStyleBackColor = true;
            // 
            // btnlimpiar
            // 
            btnlimpiar.Location = new Point(186, 250);
            btnlimpiar.Name = "btnlimpiar";
            btnlimpiar.Size = new Size(145, 23);
            btnlimpiar.TabIndex = 11;
            btnlimpiar.Text = "Limpiar";
            btnlimpiar.UseVisualStyleBackColor = true;
            // 
            // grpdatos
            // 
            grpdatos.Controls.Add(btnlimpiar);
            grpdatos.Location = new Point(6, 6);
            grpdatos.Name = "grpdatos";
            grpdatos.Size = new Size(339, 298);
            grpdatos.TabIndex = 9;
            grpdatos.TabStop = false;
            grpdatos.Text = "Entrega";
            // 
            // lblsubtotal
            // 
            lblsubtotal.AutoSize = true;
            lblsubtotal.Location = new Point(14, 329);
            lblsubtotal.Name = "lblsubtotal";
            lblsubtotal.Size = new Size(54, 15);
            lblsubtotal.TabIndex = 11;
            lblsubtotal.Text = "Subtotal:";
            // 
            // lblrecargo
            // 
            lblrecargo.AutoSize = true;
            lblrecargo.Location = new Point(14, 354);
            lblrecargo.Name = "lblrecargo";
            lblrecargo.Size = new Size(53, 15);
            lblrecargo.TabIndex = 12;
            lblrecargo.Text = "Recargo:";
            // 
            // lbldescuento
            // 
            lbldescuento.AutoSize = true;
            lbldescuento.Location = new Point(13, 379);
            lbldescuento.Name = "lbldescuento";
            lbldescuento.Size = new Size(66, 15);
            lbldescuento.TabIndex = 13;
            lbldescuento.Text = "Descuento:";
            // 
            // lbltotal
            // 
            lbltotal.AutoSize = true;
            lbltotal.Location = new Point(12, 407);
            lbltotal.Name = "lbltotal";
            lbltotal.Size = new Size(78, 15);
            lbltotal.TabIndex = 14;
            lbltotal.Text = "Total a pagar:";
            // 
            // grpimporte
            // 
            grpimporte.Controls.Add(lblsub);
            grpimporte.Location = new Point(6, 303);
            grpimporte.Name = "grpimporte";
            grpimporte.Size = new Size(331, 129);
            grpimporte.TabIndex = 9;
            grpimporte.TabStop = false;
            grpimporte.Text = "Importe";
            // 
            // lblsub
            // 
            lblsub.AutoSize = true;
            lblsub.Location = new Point(127, 26);
            lblsub.Name = "lblsub";
            lblsub.Size = new Size(22, 15);
            lblsub.TabIndex = 0;
            lblsub.Text = "$ 0";
            // lblsub.Click += lblsub_Click;
            // 
            // Form1
            // 

        }

        #endregion

        private Label lblcliente;
        private Label lblpatente;
        private Label lblservicio;
        private Label lblvehiculos;
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
        private GroupBox grpdatos;
        private Label lblsubtotal;
        private Label lblrecargo;
        private Label lbldescuento;
        private Label lbltotal;
        private GroupBox grpimporte;
        private Label lblsub;
    }
}