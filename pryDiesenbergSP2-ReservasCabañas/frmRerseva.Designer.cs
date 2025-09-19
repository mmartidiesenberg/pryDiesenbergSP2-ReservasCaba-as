namespace pryDiesenbergSP2_ReservasCabañas
{
    partial class frmRerseva
    {
        /// <summary>
        /// Variable del diseñador necesaria.
        /// </summary>
        private System.ComponentModel.IContainer components = null;

        /// <summary>
        /// Limpiar los recursos que se estén usando.
        /// </summary>
        /// <param name="disposing">true si los recursos administrados se deben desechar; false en caso contrario.</param>
        protected override void Dispose(bool disposing)
        {
            if (disposing && (components != null))
            {
                components.Dispose();
            }
            base.Dispose(disposing);
        }

        #region Código generado por el Diseñador de Windows Forms

        /// <summary>
        /// Método necesario para admitir el Diseñador. No se puede modificar
        /// el contenido de este método con el editor de código.
        /// </summary>
        private void InitializeComponent()
        {
            this.lblTipo = new System.Windows.Forms.Label();
            this.lblPersonas = new System.Windows.Forms.Label();
            this.blDias = new System.Windows.Forms.Label();
            this.lblTarjetas = new System.Windows.Forms.Label();
            this.lblNombre = new System.Windows.Forms.Label();
            this.lblTelefonos = new System.Windows.Forms.Label();
            this.mrcTipoCabaña = new System.Windows.Forms.GroupBox();
            this.txtTipo = new System.Windows.Forms.ComboBox();
            this.txtPersonas = new System.Windows.Forms.ComboBox();
            this.txtDias = new System.Windows.Forms.MaskedTextBox();
            this.mrcAdicionales = new System.Windows.Forms.GroupBox();
            this.mrcPago = new System.Windows.Forms.GroupBox();
            this.chkCocina = new System.Windows.Forms.CheckBox();
            this.chkHeladera = new System.Windows.Forms.CheckBox();
            this.chkTelevisor = new System.Windows.Forms.CheckBox();
            this.btnEfectivo = new System.Windows.Forms.RadioButton();
            this.btnTarjeta = new System.Windows.Forms.RadioButton();
            this.txtTarjetas = new System.Windows.Forms.ComboBox();
            this.mrcTitular = new System.Windows.Forms.GroupBox();
            this.txtNombre = new System.Windows.Forms.TextBox();
            this.txtNumerosTelefono = new System.Windows.Forms.MaskedTextBox();
            this.btnAceptar = new System.Windows.Forms.Button();
            this.mrcTipoCabaña.SuspendLayout();
            this.mrcAdicionales.SuspendLayout();
            this.mrcPago.SuspendLayout();
            this.mrcTitular.SuspendLayout();
            this.SuspendLayout();
            // 
            // lblTipo
            // 
            this.lblTipo.AutoSize = true;
            this.lblTipo.Location = new System.Drawing.Point(6, 37);
            this.lblTipo.Name = "lblTipo";
            this.lblTipo.Size = new System.Drawing.Size(28, 13);
            this.lblTipo.TabIndex = 1;
            this.lblTipo.Text = "Tipo";
            // 
            // lblPersonas
            // 
            this.lblPersonas.AutoSize = true;
            this.lblPersonas.Location = new System.Drawing.Point(171, 37);
            this.lblPersonas.Name = "lblPersonas";
            this.lblPersonas.Size = new System.Drawing.Size(51, 13);
            this.lblPersonas.TabIndex = 2;
            this.lblPersonas.Text = "Personas";
            // 
            // blDias
            // 
            this.blDias.AutoSize = true;
            this.blDias.Location = new System.Drawing.Point(335, 37);
            this.blDias.Name = "blDias";
            this.blDias.Size = new System.Drawing.Size(30, 13);
            this.blDias.TabIndex = 3;
            this.blDias.Text = "Días";
            // 
            // lblTarjetas
            // 
            this.lblTarjetas.AutoSize = true;
            this.lblTarjetas.Location = new System.Drawing.Point(93, 55);
            this.lblTarjetas.Name = "lblTarjetas";
            this.lblTarjetas.Size = new System.Drawing.Size(45, 13);
            this.lblTarjetas.TabIndex = 5;
            this.lblTarjetas.Text = "Tarjetas";
            // 
            // lblNombre
            // 
            this.lblNombre.AutoSize = true;
            this.lblNombre.Location = new System.Drawing.Point(16, 32);
            this.lblNombre.Name = "lblNombre";
            this.lblNombre.Size = new System.Drawing.Size(44, 13);
            this.lblNombre.TabIndex = 6;
            this.lblNombre.Text = "Nombre";
            // 
            // lblTelefonos
            // 
            this.lblTelefonos.AutoSize = true;
            this.lblTelefonos.Location = new System.Drawing.Point(16, 75);
            this.lblTelefonos.Name = "lblTelefonos";
            this.lblTelefonos.Size = new System.Drawing.Size(54, 13);
            this.lblTelefonos.TabIndex = 7;
            this.lblTelefonos.Text = "Teléfonos";
            // 
            // mrcTipoCabaña
            // 
            this.mrcTipoCabaña.Controls.Add(this.txtDias);
            this.mrcTipoCabaña.Controls.Add(this.txtTipo);
            this.mrcTipoCabaña.Controls.Add(this.txtPersonas);
            this.mrcTipoCabaña.Controls.Add(this.lblPersonas);
            this.mrcTipoCabaña.Controls.Add(this.lblTipo);
            this.mrcTipoCabaña.Controls.Add(this.blDias);
            this.mrcTipoCabaña.Location = new System.Drawing.Point(34, 12);
            this.mrcTipoCabaña.Name = "mrcTipoCabaña";
            this.mrcTipoCabaña.Size = new System.Drawing.Size(473, 82);
            this.mrcTipoCabaña.TabIndex = 9;
            this.mrcTipoCabaña.TabStop = false;
            this.mrcTipoCabaña.Text = "Tipo de Cabaña";
            this.mrcTipoCabaña.Enter += new System.EventHandler(this.groupBox1_Enter);
            // 
            // txtTipo
            // 
            this.txtTipo.FormattingEnabled = true;
            this.txtTipo.Location = new System.Drawing.Point(45, 34);
            this.txtTipo.Name = "txtTipo";
            this.txtTipo.Size = new System.Drawing.Size(110, 21);
            this.txtTipo.TabIndex = 10;
            // 
            // txtPersonas
            // 
            this.txtPersonas.FormattingEnabled = true;
            this.txtPersonas.Location = new System.Drawing.Point(228, 34);
            this.txtPersonas.Name = "txtPersonas";
            this.txtPersonas.Size = new System.Drawing.Size(95, 21);
            this.txtPersonas.TabIndex = 11;
            // 
            // txtDias
            // 
            this.txtDias.Location = new System.Drawing.Point(381, 35);
            this.txtDias.Mask = "99999";
            this.txtDias.Name = "txtDias";
            this.txtDias.Size = new System.Drawing.Size(65, 20);
            this.txtDias.TabIndex = 12;
            this.txtDias.ValidatingType = typeof(int);
            // 
            // mrcAdicionales
            // 
            this.mrcAdicionales.Controls.Add(this.chkTelevisor);
            this.mrcAdicionales.Controls.Add(this.chkHeladera);
            this.mrcAdicionales.Controls.Add(this.chkCocina);
            this.mrcAdicionales.Location = new System.Drawing.Point(34, 123);
            this.mrcAdicionales.Name = "mrcAdicionales";
            this.mrcAdicionales.Size = new System.Drawing.Size(155, 111);
            this.mrcAdicionales.TabIndex = 13;
            this.mrcAdicionales.TabStop = false;
            this.mrcAdicionales.Text = "Adicionales";
            // 
            // mrcPago
            // 
            this.mrcPago.Controls.Add(this.txtTarjetas);
            this.mrcPago.Controls.Add(this.btnEfectivo);
            this.mrcPago.Controls.Add(this.btnTarjeta);
            this.mrcPago.Controls.Add(this.lblTarjetas);
            this.mrcPago.Location = new System.Drawing.Point(232, 123);
            this.mrcPago.Name = "mrcPago";
            this.mrcPago.Size = new System.Drawing.Size(275, 111);
            this.mrcPago.TabIndex = 10;
            this.mrcPago.TabStop = false;
            this.mrcPago.Text = "Forma de Pago";
            // 
            // chkCocina
            // 
            this.chkCocina.AutoSize = true;
            this.chkCocina.Location = new System.Drawing.Point(19, 19);
            this.chkCocina.Name = "chkCocina";
            this.chkCocina.Size = new System.Drawing.Size(59, 17);
            this.chkCocina.TabIndex = 14;
            this.chkCocina.Text = "&Cocina";
            this.chkCocina.UseVisualStyleBackColor = true;
            // 
            // chkHeladera
            // 
            this.chkHeladera.AutoSize = true;
            this.chkHeladera.Location = new System.Drawing.Point(19, 51);
            this.chkHeladera.Name = "chkHeladera";
            this.chkHeladera.Size = new System.Drawing.Size(69, 17);
            this.chkHeladera.TabIndex = 15;
            this.chkHeladera.Text = "&Heladera";
            this.chkHeladera.UseVisualStyleBackColor = true;
            // 
            // chkTelevisor
            // 
            this.chkTelevisor.AutoSize = true;
            this.chkTelevisor.Location = new System.Drawing.Point(19, 83);
            this.chkTelevisor.Name = "chkTelevisor";
            this.chkTelevisor.Size = new System.Drawing.Size(69, 17);
            this.chkTelevisor.TabIndex = 16;
            this.chkTelevisor.Text = "&Televisor";
            this.chkTelevisor.UseVisualStyleBackColor = true;
            this.chkTelevisor.CheckedChanged += new System.EventHandler(this.checkBox3_CheckedChanged);
            // 
            // btnEfectivo
            // 
            this.btnEfectivo.AutoSize = true;
            this.btnEfectivo.Location = new System.Drawing.Point(6, 19);
            this.btnEfectivo.Name = "btnEfectivo";
            this.btnEfectivo.Size = new System.Drawing.Size(64, 17);
            this.btnEfectivo.TabIndex = 17;
            this.btnEfectivo.TabStop = true;
            this.btnEfectivo.Text = "&Efectivo";
            this.btnEfectivo.UseVisualStyleBackColor = true;
            // 
            // btnTarjeta
            // 
            this.btnTarjeta.AutoSize = true;
            this.btnTarjeta.Location = new System.Drawing.Point(10, 51);
            this.btnTarjeta.Name = "btnTarjeta";
            this.btnTarjeta.Size = new System.Drawing.Size(58, 17);
            this.btnTarjeta.TabIndex = 18;
            this.btnTarjeta.TabStop = true;
            this.btnTarjeta.Text = "&Tarjeta";
            this.btnTarjeta.UseVisualStyleBackColor = true;
            // 
            // txtTarjetas
            // 
            this.txtTarjetas.FormattingEnabled = true;
            this.txtTarjetas.Location = new System.Drawing.Point(96, 79);
            this.txtTarjetas.Name = "txtTarjetas";
            this.txtTarjetas.Size = new System.Drawing.Size(152, 21);
            this.txtTarjetas.TabIndex = 19;
            // 
            // mrcTitular
            // 
            this.mrcTitular.Controls.Add(this.txtNumerosTelefono);
            this.mrcTitular.Controls.Add(this.txtNombre);
            this.mrcTitular.Controls.Add(this.lblNombre);
            this.mrcTitular.Controls.Add(this.lblTelefonos);
            this.mrcTitular.Location = new System.Drawing.Point(34, 269);
            this.mrcTitular.Name = "mrcTitular";
            this.mrcTitular.Size = new System.Drawing.Size(473, 111);
            this.mrcTitular.TabIndex = 17;
            this.mrcTitular.TabStop = false;
            this.mrcTitular.Text = "Titular de la Reserva";
            // 
            // txtNombre
            // 
            this.txtNombre.Location = new System.Drawing.Point(103, 29);
            this.txtNombre.Name = "txtNombre";
            this.txtNombre.Size = new System.Drawing.Size(343, 20);
            this.txtNombre.TabIndex = 18;
            // 
            // txtNumerosTelefono
            // 
            this.txtNumerosTelefono.Location = new System.Drawing.Point(103, 72);
            this.txtNumerosTelefono.Mask = "(999)000-0000";
            this.txtNumerosTelefono.Name = "txtNumerosTelefono";
            this.txtNumerosTelefono.Size = new System.Drawing.Size(343, 20);
            this.txtNumerosTelefono.TabIndex = 19;
            // 
            // btnAceptar
            // 
            this.btnAceptar.Font = new System.Drawing.Font("Microsoft Sans Serif", 9.75F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.btnAceptar.Location = new System.Drawing.Point(415, 401);
            this.btnAceptar.Name = "btnAceptar";
            this.btnAceptar.Size = new System.Drawing.Size(92, 37);
            this.btnAceptar.TabIndex = 20;
            this.btnAceptar.Text = "&Aceptar";
            this.btnAceptar.UseVisualStyleBackColor = true;
            // 
            // frmRerseva
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(6F, 13F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.ClientSize = new System.Drawing.Size(546, 450);
            this.Controls.Add(this.btnAceptar);
            this.Controls.Add(this.mrcTitular);
            this.Controls.Add(this.mrcAdicionales);
            this.Controls.Add(this.mrcPago);
            this.Controls.Add(this.mrcTipoCabaña);
            this.Name = "frmRerseva";
            this.Text = "Reserva de Cabañas";
            this.mrcTipoCabaña.ResumeLayout(false);
            this.mrcTipoCabaña.PerformLayout();
            this.mrcAdicionales.ResumeLayout(false);
            this.mrcAdicionales.PerformLayout();
            this.mrcPago.ResumeLayout(false);
            this.mrcPago.PerformLayout();
            this.mrcTitular.ResumeLayout(false);
            this.mrcTitular.PerformLayout();
            this.ResumeLayout(false);

        }

        #endregion
        private System.Windows.Forms.Label lblTipo;
        private System.Windows.Forms.Label lblPersonas;
        private System.Windows.Forms.Label blDias;
        private System.Windows.Forms.Label lblTarjetas;
        private System.Windows.Forms.Label lblNombre;
        private System.Windows.Forms.Label lblTelefonos;
        private System.Windows.Forms.GroupBox mrcTipoCabaña;
        private System.Windows.Forms.MaskedTextBox txtDias;
        private System.Windows.Forms.ComboBox txtTipo;
        private System.Windows.Forms.ComboBox txtPersonas;
        private System.Windows.Forms.GroupBox mrcAdicionales;
        private System.Windows.Forms.GroupBox mrcPago;
        private System.Windows.Forms.CheckBox chkTelevisor;
        private System.Windows.Forms.CheckBox chkHeladera;
        private System.Windows.Forms.CheckBox chkCocina;
        private System.Windows.Forms.ComboBox txtTarjetas;
        private System.Windows.Forms.RadioButton btnEfectivo;
        private System.Windows.Forms.RadioButton btnTarjeta;
        private System.Windows.Forms.GroupBox mrcTitular;
        private System.Windows.Forms.MaskedTextBox txtNumerosTelefono;
        private System.Windows.Forms.TextBox txtNombre;
        private System.Windows.Forms.Button btnAceptar;
    }
}

