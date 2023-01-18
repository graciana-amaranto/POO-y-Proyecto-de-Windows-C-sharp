namespace WindowsEFDatos
{
    partial class frmAvion
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
            this.gridAvion = new System.Windows.Forms.DataGridView();
            this.btnAvion = new System.Windows.Forms.Button();
            this.lblCapacidad = new System.Windows.Forms.Label();
            this.txtCapacidad = new System.Windows.Forms.TextBox();
            this.Denominacion = new System.Windows.Forms.Label();
            this.txtDenominacion = new System.Windows.Forms.TextBox();
            this.lblLineaAerea = new System.Windows.Forms.Label();
            this.btnEditarAvion = new System.Windows.Forms.Button();
            this.lblId = new System.Windows.Forms.Label();
            this.txtId = new System.Windows.Forms.TextBox();
            ((System.ComponentModel.ISupportInitialize)(this.gridAvion)).BeginInit();
            this.SuspendLayout();
            // 
            // gridAvion
            // 
            this.gridAvion.ColumnHeadersHeightSizeMode = System.Windows.Forms.DataGridViewColumnHeadersHeightSizeMode.AutoSize;
            this.gridAvion.Location = new System.Drawing.Point(42, 132);
            this.gridAvion.Name = "gridAvion";
            this.gridAvion.Size = new System.Drawing.Size(300, 139);
            this.gridAvion.TabIndex = 0;
            // 
            // btnAvion
            // 
            this.btnAvion.Location = new System.Drawing.Point(417, 77);
            this.btnAvion.Name = "btnAvion";
            this.btnAvion.Size = new System.Drawing.Size(81, 39);
            this.btnAvion.TabIndex = 1;
            this.btnAvion.Text = "Agregar avion";
            this.btnAvion.UseVisualStyleBackColor = true;
            this.btnAvion.Click += new System.EventHandler(this.btnAvion_Click_1);
            // 
            // lblCapacidad
            // 
            this.lblCapacidad.AutoSize = true;
            this.lblCapacidad.Location = new System.Drawing.Point(440, 184);
            this.lblCapacidad.Name = "lblCapacidad";
            this.lblCapacidad.Size = new System.Drawing.Size(58, 13);
            this.lblCapacidad.TabIndex = 2;
            this.lblCapacidad.Text = "Capacidad";
            // 
            // txtCapacidad
            // 
            this.txtCapacidad.Location = new System.Drawing.Point(536, 177);
            this.txtCapacidad.Name = "txtCapacidad";
            this.txtCapacidad.Size = new System.Drawing.Size(100, 20);
            this.txtCapacidad.TabIndex = 3;
            // 
            // Denominacion
            // 
            this.Denominacion.AutoSize = true;
            this.Denominacion.Location = new System.Drawing.Point(440, 222);
            this.Denominacion.Name = "Denominacion";
            this.Denominacion.Size = new System.Drawing.Size(75, 13);
            this.Denominacion.TabIndex = 4;
            this.Denominacion.Text = "Denominacion";
            // 
            // txtDenominacion
            // 
            this.txtDenominacion.Location = new System.Drawing.Point(536, 222);
            this.txtDenominacion.Name = "txtDenominacion";
            this.txtDenominacion.Size = new System.Drawing.Size(100, 20);
            this.txtDenominacion.TabIndex = 5;
            // 
            // lblLineaAerea
            // 
            this.lblLineaAerea.AutoSize = true;
            this.lblLineaAerea.Location = new System.Drawing.Point(440, 241);
            this.lblLineaAerea.Name = "lblLineaAerea";
            this.lblLineaAerea.Size = new System.Drawing.Size(0, 13);
            this.lblLineaAerea.TabIndex = 6;
            // 
            // btnEditarAvion
            // 
            this.btnEditarAvion.Location = new System.Drawing.Point(521, 77);
            this.btnEditarAvion.Name = "btnEditarAvion";
            this.btnEditarAvion.Size = new System.Drawing.Size(81, 39);
            this.btnEditarAvion.TabIndex = 7;
            this.btnEditarAvion.Text = "Editar Avion";
            this.btnEditarAvion.UseVisualStyleBackColor = true;
            this.btnEditarAvion.Click += new System.EventHandler(this.btnEditarAvion_Click);
            // 
            // lblId
            // 
            this.lblId.AutoSize = true;
            this.lblId.Location = new System.Drawing.Point(440, 139);
            this.lblId.Name = "lblId";
            this.lblId.Size = new System.Drawing.Size(16, 13);
            this.lblId.TabIndex = 8;
            this.lblId.Text = "Id";
            // 
            // txtId
            // 
            this.txtId.Location = new System.Drawing.Point(536, 136);
            this.txtId.Name = "txtId";
            this.txtId.Size = new System.Drawing.Size(100, 20);
            this.txtId.TabIndex = 9;
            // 
            // frmAvion
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(6F, 13F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.ClientSize = new System.Drawing.Size(800, 450);
            this.Controls.Add(this.txtId);
            this.Controls.Add(this.lblId);
            this.Controls.Add(this.btnEditarAvion);
            this.Controls.Add(this.lblLineaAerea);
            this.Controls.Add(this.txtDenominacion);
            this.Controls.Add(this.Denominacion);
            this.Controls.Add(this.txtCapacidad);
            this.Controls.Add(this.lblCapacidad);
            this.Controls.Add(this.btnAvion);
            this.Controls.Add(this.gridAvion);
            this.Name = "frmAvion";
            this.Text = "frmAvion";
            ((System.ComponentModel.ISupportInitialize)(this.gridAvion)).EndInit();
            this.ResumeLayout(false);
            this.PerformLayout();

        }

        #endregion

        private System.Windows.Forms.DataGridView gridAvion;
        private System.Windows.Forms.Button btnAvion;
        private System.Windows.Forms.Label lblCapacidad;
        private System.Windows.Forms.TextBox txtCapacidad;
        private System.Windows.Forms.Label Denominacion;
        private System.Windows.Forms.TextBox txtDenominacion;
        private System.Windows.Forms.Label lblLineaAerea;
        private System.Windows.Forms.Button btnEditarAvion;
        private System.Windows.Forms.Label lblId;
        private System.Windows.Forms.TextBox txtId;
    }
}