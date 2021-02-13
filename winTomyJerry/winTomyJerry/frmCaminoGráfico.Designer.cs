namespace winTomyJerry
{
    partial class frmCaminoGráfico
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
            this.components = new System.ComponentModel.Container();
            System.ComponentModel.ComponentResourceManager resources = new System.ComponentModel.ComponentResourceManager(typeof(frmCaminoGráfico));
            this.cmbCaminos = new System.Windows.Forms.ComboBox();
            this.btnVerCamino = new System.Windows.Forms.Button();
            this.lblInd = new System.Windows.Forms.Label();
            this.tmrAvanzar = new System.Windows.Forms.Timer(this.components);
            this.picTom = new System.Windows.Forms.PictureBox();
            this.picJerry = new System.Windows.Forms.PictureBox();
            this.lblJerry1 = new System.Windows.Forms.Label();
            this.lblTom1 = new System.Windows.Forms.Label();
            this.btnSalir = new System.Windows.Forms.Button();
            this.lblCosto = new System.Windows.Forms.Label();
            ((System.ComponentModel.ISupportInitialize)(this.picTom)).BeginInit();
            ((System.ComponentModel.ISupportInitialize)(this.picJerry)).BeginInit();
            this.SuspendLayout();
            // 
            // cmbCaminos
            // 
            this.cmbCaminos.FormattingEnabled = true;
            this.cmbCaminos.Location = new System.Drawing.Point(12, 28);
            this.cmbCaminos.Name = "cmbCaminos";
            this.cmbCaminos.Size = new System.Drawing.Size(44, 24);
            this.cmbCaminos.TabIndex = 0;
            this.cmbCaminos.KeyPress += new System.Windows.Forms.KeyPressEventHandler(this.cmbCaminos_KeyPress);
            // 
            // btnVerCamino
            // 
            this.btnVerCamino.Enabled = false;
            this.btnVerCamino.Location = new System.Drawing.Point(62, 29);
            this.btnVerCamino.Name = "btnVerCamino";
            this.btnVerCamino.Size = new System.Drawing.Size(84, 23);
            this.btnVerCamino.TabIndex = 1;
            this.btnVerCamino.TabStop = false;
            this.btnVerCamino.Text = "Ver camino";
            this.btnVerCamino.UseVisualStyleBackColor = true;
            this.btnVerCamino.Click += new System.EventHandler(this.btnVerCamino_Click);
            // 
            // lblInd
            // 
            this.lblInd.AutoSize = true;
            this.lblInd.ForeColor = System.Drawing.SystemColors.ControlLightLight;
            this.lblInd.Location = new System.Drawing.Point(38, 9);
            this.lblInd.Name = "lblInd";
            this.lblInd.Size = new System.Drawing.Size(121, 16);
            this.lblInd.TabIndex = 2;
            this.lblInd.Text = "Caminos generados:";
            // 
            // tmrAvanzar
            // 
            this.tmrAvanzar.Interval = 200;
            this.tmrAvanzar.Tick += new System.EventHandler(this.tmrAvanzar_Tick);
            // 
            // picTom
            // 
            this.picTom.Image = global::winTomyJerry.Properties.Resources.Tom;
            this.picTom.Location = new System.Drawing.Point(25, 72);
            this.picTom.Name = "picTom";
            this.picTom.Size = new System.Drawing.Size(25, 25);
            this.picTom.TabIndex = 3;
            this.picTom.TabStop = false;
            // 
            // picJerry
            // 
            this.picJerry.Image = global::winTomyJerry.Properties.Resources.Jerry;
            this.picJerry.Location = new System.Drawing.Point(104, 72);
            this.picJerry.Name = "picJerry";
            this.picJerry.Size = new System.Drawing.Size(25, 25);
            this.picJerry.TabIndex = 4;
            this.picJerry.TabStop = false;
            // 
            // lblJerry1
            // 
            this.lblJerry1.AutoSize = true;
            this.lblJerry1.Font = new System.Drawing.Font("Maiandra GD", 9.75F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.lblJerry1.ForeColor = System.Drawing.SystemColors.ControlLightLight;
            this.lblJerry1.Location = new System.Drawing.Point(135, 72);
            this.lblJerry1.Name = "lblJerry1";
            this.lblJerry1.Size = new System.Drawing.Size(41, 16);
            this.lblJerry1.TabIndex = 5;
            this.lblJerry1.Text = "Jerry";
            // 
            // lblTom1
            // 
            this.lblTom1.AutoSize = true;
            this.lblTom1.Font = new System.Drawing.Font("Maiandra GD", 9.75F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.lblTom1.ForeColor = System.Drawing.SystemColors.ControlLightLight;
            this.lblTom1.Location = new System.Drawing.Point(56, 72);
            this.lblTom1.Name = "lblTom1";
            this.lblTom1.Size = new System.Drawing.Size(38, 16);
            this.lblTom1.TabIndex = 6;
            this.lblTom1.Text = "Tom";
            // 
            // btnSalir
            // 
            this.btnSalir.Location = new System.Drawing.Point(143, 176);
            this.btnSalir.Name = "btnSalir";
            this.btnSalir.Size = new System.Drawing.Size(44, 23);
            this.btnSalir.TabIndex = 7;
            this.btnSalir.Text = "Salir";
            this.btnSalir.UseVisualStyleBackColor = true;
            this.btnSalir.Click += new System.EventHandler(this.btnSalir_Click);
            // 
            // lblCosto
            // 
            this.lblCosto.AutoSize = true;
            this.lblCosto.Font = new System.Drawing.Font("Maiandra GD", 11.25F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.lblCosto.ForeColor = System.Drawing.SystemColors.ControlLightLight;
            this.lblCosto.Location = new System.Drawing.Point(12, 179);
            this.lblCosto.Name = "lblCosto";
            this.lblCosto.Size = new System.Drawing.Size(0, 18);
            this.lblCosto.TabIndex = 8;
            // 
            // frmCaminoGráfico
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(7F, 16F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.BackColor = System.Drawing.SystemColors.WindowFrame;
            this.ClientSize = new System.Drawing.Size(199, 211);
            this.ControlBox = false;
            this.Controls.Add(this.lblCosto);
            this.Controls.Add(this.btnSalir);
            this.Controls.Add(this.lblTom1);
            this.Controls.Add(this.lblJerry1);
            this.Controls.Add(this.picJerry);
            this.Controls.Add(this.picTom);
            this.Controls.Add(this.lblInd);
            this.Controls.Add(this.btnVerCamino);
            this.Controls.Add(this.cmbCaminos);
            this.Font = new System.Drawing.Font("Maiandra GD", 9.75F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.FormBorderStyle = System.Windows.Forms.FormBorderStyle.FixedSingle;
            this.Icon = ((System.Drawing.Icon)(resources.GetObject("$this.Icon")));
            this.Margin = new System.Windows.Forms.Padding(3, 4, 3, 4);
            this.Name = "frmCaminoGráfico";
            this.StartPosition = System.Windows.Forms.FormStartPosition.CenterScreen;
            this.Text = "Camino(s) Generados";
            this.TopMost = true;
            this.Load += new System.EventHandler(this.frmCaminoGráfico_Load);
            ((System.ComponentModel.ISupportInitialize)(this.picTom)).EndInit();
            ((System.ComponentModel.ISupportInitialize)(this.picJerry)).EndInit();
            this.ResumeLayout(false);
            this.PerformLayout();

        }

        #endregion

        private System.Windows.Forms.ComboBox cmbCaminos;
        private System.Windows.Forms.Button btnVerCamino;
        private System.Windows.Forms.Label lblInd;
        private System.Windows.Forms.Timer tmrAvanzar;
        private System.Windows.Forms.PictureBox picTom;
        private System.Windows.Forms.PictureBox picJerry;
        private System.Windows.Forms.Label lblJerry1;
        private System.Windows.Forms.Label lblTom1;
        private System.Windows.Forms.Button btnSalir;
        private System.Windows.Forms.Label lblCosto;
    }
}