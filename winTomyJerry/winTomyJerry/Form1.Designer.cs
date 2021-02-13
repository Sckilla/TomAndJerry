namespace winTomyJerry
{
    partial class frmTomyJerry
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
            this.components = new System.ComponentModel.Container();
            System.ComponentModel.ComponentResourceManager resources = new System.ComponentModel.ComponentResourceManager(typeof(frmTomyJerry));
            this.grbTamaño = new System.Windows.Forms.GroupBox();
            this.btnAceptarEsp = new System.Windows.Forms.Button();
            this.txtN = new System.Windows.Forms.TextBox();
            this.txtM = new System.Windows.Forms.TextBox();
            this.lblColumnas = new System.Windows.Forms.Label();
            this.lblFilas = new System.Windows.Forms.Label();
            this.grbUbicaciones = new System.Windows.Forms.GroupBox();
            this.lblIndUbic = new System.Windows.Forms.Label();
            this.btnAceptarUbi = new System.Windows.Forms.Button();
            this.lblColumnaJ = new System.Windows.Forms.Label();
            this.lblColumnaT = new System.Windows.Forms.Label();
            this.lblFilaJ = new System.Windows.Forms.Label();
            this.lblFilaT = new System.Windows.Forms.Label();
            this.txtColumnaT = new System.Windows.Forms.TextBox();
            this.txtFilaT = new System.Windows.Forms.TextBox();
            this.txtColumnaJ = new System.Windows.Forms.TextBox();
            this.txtFilaJ = new System.Windows.Forms.TextBox();
            this.lblJerry = new System.Windows.Forms.Label();
            this.lblTom = new System.Windows.Forms.Label();
            this.grbObstáculos = new System.Windows.Forms.GroupBox();
            this.btnRestObst = new System.Windows.Forms.Button();
            this.label6 = new System.Windows.Forms.Label();
            this.btnIntObst = new System.Windows.Forms.Button();
            this.lblColumna2 = new System.Windows.Forms.Label();
            this.lblColumna1 = new System.Windows.Forms.Label();
            this.lblFila2 = new System.Windows.Forms.Label();
            this.lblFila1 = new System.Windows.Forms.Label();
            this.txtColumnaOSI = new System.Windows.Forms.TextBox();
            this.txtFilaOSI = new System.Windows.Forms.TextBox();
            this.txtColumnaOID = new System.Windows.Forms.TextBox();
            this.txtFilaOID = new System.Windows.Forms.TextBox();
            this.lblInfDer = new System.Windows.Forms.Label();
            this.lblSupIzq = new System.Windows.Forms.Label();
            this.btnGenEsp = new System.Windows.Forms.Button();
            this.btnRestAll = new System.Windows.Forms.Button();
            this.btnSalir = new System.Windows.Forms.Button();
            this.erpNumeros = new System.Windows.Forms.ErrorProvider(this.components);
            this.grbCargarArchivo = new System.Windows.Forms.GroupBox();
            this.lblIndic0 = new System.Windows.Forms.Label();
            this.btnCargarArch = new System.Windows.Forms.Button();
            this.txtNArch = new System.Windows.Forms.TextBox();
            this.lblNombreArch = new System.Windows.Forms.Label();
            this.lblAlumno = new System.Windows.Forms.Label();
            this.grbTamaño.SuspendLayout();
            this.grbUbicaciones.SuspendLayout();
            this.grbObstáculos.SuspendLayout();
            ((System.ComponentModel.ISupportInitialize)(this.erpNumeros)).BeginInit();
            this.grbCargarArchivo.SuspendLayout();
            this.SuspendLayout();
            // 
            // grbTamaño
            // 
            this.grbTamaño.Controls.Add(this.btnAceptarEsp);
            this.grbTamaño.Controls.Add(this.txtN);
            this.grbTamaño.Controls.Add(this.txtM);
            this.grbTamaño.Controls.Add(this.lblColumnas);
            this.grbTamaño.Controls.Add(this.lblFilas);
            this.grbTamaño.Font = new System.Drawing.Font("Maiandra GD", 11.25F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.grbTamaño.ForeColor = System.Drawing.SystemColors.ControlLightLight;
            this.grbTamaño.Location = new System.Drawing.Point(22, 115);
            this.grbTamaño.Name = "grbTamaño";
            this.grbTamaño.Size = new System.Drawing.Size(401, 113);
            this.grbTamaño.TabIndex = 1;
            this.grbTamaño.TabStop = false;
            this.grbTamaño.Text = "Espacio";
            // 
            // btnAceptarEsp
            // 
            this.btnAceptarEsp.Font = new System.Drawing.Font("Maiandra GD", 9F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.btnAceptarEsp.ForeColor = System.Drawing.SystemColors.ControlText;
            this.btnAceptarEsp.Location = new System.Drawing.Point(310, 77);
            this.btnAceptarEsp.Name = "btnAceptarEsp";
            this.btnAceptarEsp.Size = new System.Drawing.Size(75, 23);
            this.btnAceptarEsp.TabIndex = 4;
            this.btnAceptarEsp.Text = "Aceptar";
            this.btnAceptarEsp.UseVisualStyleBackColor = true;
            this.btnAceptarEsp.Click += new System.EventHandler(this.btnAceptarEsp_Click);
            // 
            // txtN
            // 
            this.txtN.BackColor = System.Drawing.SystemColors.Menu;
            this.txtN.Location = new System.Drawing.Point(350, 46);
            this.txtN.Name = "txtN";
            this.txtN.Size = new System.Drawing.Size(35, 25);
            this.txtN.TabIndex = 3;
            this.txtN.KeyPress += new System.Windows.Forms.KeyPressEventHandler(this.txtN_KeyPress);
            // 
            // txtM
            // 
            this.txtM.BackColor = System.Drawing.SystemColors.Menu;
            this.txtM.Location = new System.Drawing.Point(350, 19);
            this.txtM.Name = "txtM";
            this.txtM.Size = new System.Drawing.Size(35, 25);
            this.txtM.TabIndex = 2;
            this.txtM.KeyPress += new System.Windows.Forms.KeyPressEventHandler(this.txtM_KeyPress);
            // 
            // lblColumnas
            // 
            this.lblColumnas.AutoSize = true;
            this.lblColumnas.Location = new System.Drawing.Point(6, 53);
            this.lblColumnas.Name = "lblColumnas";
            this.lblColumnas.Size = new System.Drawing.Size(259, 18);
            this.lblColumnas.TabIndex = 1;
            this.lblColumnas.Text = "Introduce el número de columnas:";
            // 
            // lblFilas
            // 
            this.lblFilas.AutoSize = true;
            this.lblFilas.Location = new System.Drawing.Point(6, 26);
            this.lblFilas.Name = "lblFilas";
            this.lblFilas.Size = new System.Drawing.Size(221, 18);
            this.lblFilas.TabIndex = 0;
            this.lblFilas.Text = "Introduce el número de filas:";
            // 
            // grbUbicaciones
            // 
            this.grbUbicaciones.Controls.Add(this.lblIndUbic);
            this.grbUbicaciones.Controls.Add(this.btnAceptarUbi);
            this.grbUbicaciones.Controls.Add(this.lblColumnaJ);
            this.grbUbicaciones.Controls.Add(this.lblColumnaT);
            this.grbUbicaciones.Controls.Add(this.lblFilaJ);
            this.grbUbicaciones.Controls.Add(this.lblFilaT);
            this.grbUbicaciones.Controls.Add(this.txtColumnaT);
            this.grbUbicaciones.Controls.Add(this.txtFilaT);
            this.grbUbicaciones.Controls.Add(this.txtColumnaJ);
            this.grbUbicaciones.Controls.Add(this.txtFilaJ);
            this.grbUbicaciones.Controls.Add(this.lblJerry);
            this.grbUbicaciones.Controls.Add(this.lblTom);
            this.grbUbicaciones.Font = new System.Drawing.Font("Maiandra GD", 11.25F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.grbUbicaciones.ForeColor = System.Drawing.SystemColors.ControlLightLight;
            this.grbUbicaciones.Location = new System.Drawing.Point(22, 234);
            this.grbUbicaciones.Name = "grbUbicaciones";
            this.grbUbicaciones.Size = new System.Drawing.Size(401, 144);
            this.grbUbicaciones.TabIndex = 2;
            this.grbUbicaciones.TabStop = false;
            this.grbUbicaciones.Text = "Ubicaciones";
            // 
            // lblIndUbic
            // 
            this.lblIndUbic.AutoSize = true;
            this.lblIndUbic.Font = new System.Drawing.Font("Maiandra GD", 9F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.lblIndUbic.Location = new System.Drawing.Point(6, 21);
            this.lblIndUbic.Name = "lblIndUbic";
            this.lblIndUbic.Size = new System.Drawing.Size(228, 15);
            this.lblIndUbic.TabIndex = 12;
            this.lblIndUbic.Text = "Introduce las coordenadas iniciales.";
            // 
            // btnAceptarUbi
            // 
            this.btnAceptarUbi.Font = new System.Drawing.Font("Maiandra GD", 9F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.btnAceptarUbi.ForeColor = System.Drawing.SystemColors.ControlText;
            this.btnAceptarUbi.Location = new System.Drawing.Point(310, 104);
            this.btnAceptarUbi.Name = "btnAceptarUbi";
            this.btnAceptarUbi.Size = new System.Drawing.Size(75, 23);
            this.btnAceptarUbi.TabIndex = 11;
            this.btnAceptarUbi.Text = "Aceptar";
            this.btnAceptarUbi.UseVisualStyleBackColor = true;
            this.btnAceptarUbi.Click += new System.EventHandler(this.btnAceptarUbi_Click);
            // 
            // lblColumnaJ
            // 
            this.lblColumnaJ.AutoSize = true;
            this.lblColumnaJ.Location = new System.Drawing.Point(264, 76);
            this.lblColumnaJ.Name = "lblColumnaJ";
            this.lblColumnaJ.Size = new System.Drawing.Size(80, 18);
            this.lblColumnaJ.TabIndex = 10;
            this.lblColumnaJ.Text = "Columna:";
            // 
            // lblColumnaT
            // 
            this.lblColumnaT.AutoSize = true;
            this.lblColumnaT.Location = new System.Drawing.Point(264, 49);
            this.lblColumnaT.Name = "lblColumnaT";
            this.lblColumnaT.Size = new System.Drawing.Size(80, 18);
            this.lblColumnaT.TabIndex = 9;
            this.lblColumnaT.Text = "Columna:";
            // 
            // lblFilaJ
            // 
            this.lblFilaJ.AutoSize = true;
            this.lblFilaJ.Location = new System.Drawing.Point(172, 76);
            this.lblFilaJ.Name = "lblFilaJ";
            this.lblFilaJ.Size = new System.Drawing.Size(41, 18);
            this.lblFilaJ.TabIndex = 8;
            this.lblFilaJ.Text = "Fila:";
            // 
            // lblFilaT
            // 
            this.lblFilaT.AutoSize = true;
            this.lblFilaT.Location = new System.Drawing.Point(172, 49);
            this.lblFilaT.Name = "lblFilaT";
            this.lblFilaT.Size = new System.Drawing.Size(41, 18);
            this.lblFilaT.TabIndex = 7;
            this.lblFilaT.Text = "Fila:";
            // 
            // txtColumnaT
            // 
            this.txtColumnaT.BackColor = System.Drawing.SystemColors.Menu;
            this.txtColumnaT.Location = new System.Drawing.Point(350, 46);
            this.txtColumnaT.Name = "txtColumnaT";
            this.txtColumnaT.Size = new System.Drawing.Size(35, 25);
            this.txtColumnaT.TabIndex = 3;
            this.txtColumnaT.KeyPress += new System.Windows.Forms.KeyPressEventHandler(this.txtColumnaT_KeyPress);
            // 
            // txtFilaT
            // 
            this.txtFilaT.BackColor = System.Drawing.SystemColors.Menu;
            this.txtFilaT.Location = new System.Drawing.Point(219, 46);
            this.txtFilaT.Name = "txtFilaT";
            this.txtFilaT.Size = new System.Drawing.Size(35, 25);
            this.txtFilaT.TabIndex = 2;
            this.txtFilaT.KeyPress += new System.Windows.Forms.KeyPressEventHandler(this.txtFilaT_KeyPress);
            // 
            // txtColumnaJ
            // 
            this.txtColumnaJ.BackColor = System.Drawing.SystemColors.Menu;
            this.txtColumnaJ.Location = new System.Drawing.Point(350, 73);
            this.txtColumnaJ.Name = "txtColumnaJ";
            this.txtColumnaJ.Size = new System.Drawing.Size(35, 25);
            this.txtColumnaJ.TabIndex = 6;
            this.txtColumnaJ.KeyPress += new System.Windows.Forms.KeyPressEventHandler(this.txtColumnaJ_KeyPress);
            // 
            // txtFilaJ
            // 
            this.txtFilaJ.BackColor = System.Drawing.SystemColors.Menu;
            this.txtFilaJ.Location = new System.Drawing.Point(219, 73);
            this.txtFilaJ.Name = "txtFilaJ";
            this.txtFilaJ.Size = new System.Drawing.Size(35, 25);
            this.txtFilaJ.TabIndex = 5;
            this.txtFilaJ.KeyPress += new System.Windows.Forms.KeyPressEventHandler(this.txtFilaJ_KeyPress_1);
            // 
            // lblJerry
            // 
            this.lblJerry.AutoSize = true;
            this.lblJerry.Location = new System.Drawing.Point(6, 76);
            this.lblJerry.Name = "lblJerry";
            this.lblJerry.Size = new System.Drawing.Size(95, 18);
            this.lblJerry.TabIndex = 1;
            this.lblJerry.Text = "JERRY    ->";
            // 
            // lblTom
            // 
            this.lblTom.AutoSize = true;
            this.lblTom.Location = new System.Drawing.Point(6, 49);
            this.lblTom.Name = "lblTom";
            this.lblTom.Size = new System.Drawing.Size(96, 18);
            this.lblTom.TabIndex = 0;
            this.lblTom.Text = "TOM      ->";
            // 
            // grbObstáculos
            // 
            this.grbObstáculos.Controls.Add(this.btnRestObst);
            this.grbObstáculos.Controls.Add(this.label6);
            this.grbObstáculos.Controls.Add(this.btnIntObst);
            this.grbObstáculos.Controls.Add(this.lblColumna2);
            this.grbObstáculos.Controls.Add(this.lblColumna1);
            this.grbObstáculos.Controls.Add(this.lblFila2);
            this.grbObstáculos.Controls.Add(this.lblFila1);
            this.grbObstáculos.Controls.Add(this.txtColumnaOSI);
            this.grbObstáculos.Controls.Add(this.txtFilaOSI);
            this.grbObstáculos.Controls.Add(this.txtColumnaOID);
            this.grbObstáculos.Controls.Add(this.txtFilaOID);
            this.grbObstáculos.Controls.Add(this.lblInfDer);
            this.grbObstáculos.Controls.Add(this.lblSupIzq);
            this.grbObstáculos.Font = new System.Drawing.Font("Maiandra GD", 11.25F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.grbObstáculos.ForeColor = System.Drawing.SystemColors.ControlLightLight;
            this.grbObstáculos.Location = new System.Drawing.Point(22, 384);
            this.grbObstáculos.Name = "grbObstáculos";
            this.grbObstáculos.Size = new System.Drawing.Size(401, 160);
            this.grbObstáculos.TabIndex = 3;
            this.grbObstáculos.TabStop = false;
            this.grbObstáculos.Text = "Obstáculos";
            // 
            // btnRestObst
            // 
            this.btnRestObst.Font = new System.Drawing.Font("Maiandra GD", 9F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.btnRestObst.ForeColor = System.Drawing.SystemColors.ControlText;
            this.btnRestObst.Location = new System.Drawing.Point(219, 104);
            this.btnRestObst.Name = "btnRestObst";
            this.btnRestObst.Size = new System.Drawing.Size(85, 39);
            this.btnRestObst.TabIndex = 14;
            this.btnRestObst.Text = "Reestablecer Obstáculos";
            this.btnRestObst.UseVisualStyleBackColor = true;
            this.btnRestObst.Click += new System.EventHandler(this.btnRestObst_Click);
            // 
            // label6
            // 
            this.label6.AutoSize = true;
            this.label6.Font = new System.Drawing.Font("Maiandra GD", 9F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.label6.Location = new System.Drawing.Point(6, 21);
            this.label6.Name = "label6";
            this.label6.Size = new System.Drawing.Size(383, 15);
            this.label6.TabIndex = 13;
            this.label6.Text = "Introduce las coordenadas de las esquinas de los obstáculos.";
            // 
            // btnIntObst
            // 
            this.btnIntObst.Font = new System.Drawing.Font("Maiandra GD", 9F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.btnIntObst.ForeColor = System.Drawing.SystemColors.ControlText;
            this.btnIntObst.Location = new System.Drawing.Point(310, 104);
            this.btnIntObst.Name = "btnIntObst";
            this.btnIntObst.Size = new System.Drawing.Size(75, 39);
            this.btnIntObst.TabIndex = 11;
            this.btnIntObst.Text = "Introducir Obstáculo";
            this.btnIntObst.UseVisualStyleBackColor = true;
            this.btnIntObst.Click += new System.EventHandler(this.btnIntObst_Click);
            // 
            // lblColumna2
            // 
            this.lblColumna2.AutoSize = true;
            this.lblColumna2.Location = new System.Drawing.Point(264, 76);
            this.lblColumna2.Name = "lblColumna2";
            this.lblColumna2.Size = new System.Drawing.Size(80, 18);
            this.lblColumna2.TabIndex = 10;
            this.lblColumna2.Text = "Columna:";
            // 
            // lblColumna1
            // 
            this.lblColumna1.AutoSize = true;
            this.lblColumna1.Location = new System.Drawing.Point(264, 49);
            this.lblColumna1.Name = "lblColumna1";
            this.lblColumna1.Size = new System.Drawing.Size(80, 18);
            this.lblColumna1.TabIndex = 9;
            this.lblColumna1.Text = "Columna:";
            // 
            // lblFila2
            // 
            this.lblFila2.AutoSize = true;
            this.lblFila2.Location = new System.Drawing.Point(172, 76);
            this.lblFila2.Name = "lblFila2";
            this.lblFila2.Size = new System.Drawing.Size(41, 18);
            this.lblFila2.TabIndex = 8;
            this.lblFila2.Text = "Fila:";
            // 
            // lblFila1
            // 
            this.lblFila1.AutoSize = true;
            this.lblFila1.Location = new System.Drawing.Point(172, 49);
            this.lblFila1.Name = "lblFila1";
            this.lblFila1.Size = new System.Drawing.Size(41, 18);
            this.lblFila1.TabIndex = 7;
            this.lblFila1.Text = "Fila:";
            // 
            // txtColumnaOSI
            // 
            this.txtColumnaOSI.BackColor = System.Drawing.SystemColors.Menu;
            this.txtColumnaOSI.Location = new System.Drawing.Point(350, 46);
            this.txtColumnaOSI.Name = "txtColumnaOSI";
            this.txtColumnaOSI.Size = new System.Drawing.Size(35, 25);
            this.txtColumnaOSI.TabIndex = 3;
            this.txtColumnaOSI.KeyPress += new System.Windows.Forms.KeyPressEventHandler(this.txtColumnaOSI_KeyPress);
            // 
            // txtFilaOSI
            // 
            this.txtFilaOSI.BackColor = System.Drawing.SystemColors.Menu;
            this.txtFilaOSI.Location = new System.Drawing.Point(219, 46);
            this.txtFilaOSI.Name = "txtFilaOSI";
            this.txtFilaOSI.Size = new System.Drawing.Size(35, 25);
            this.txtFilaOSI.TabIndex = 2;
            this.txtFilaOSI.KeyPress += new System.Windows.Forms.KeyPressEventHandler(this.txtFilaOSI_KeyPress);
            // 
            // txtColumnaOID
            // 
            this.txtColumnaOID.BackColor = System.Drawing.SystemColors.Menu;
            this.txtColumnaOID.Location = new System.Drawing.Point(350, 73);
            this.txtColumnaOID.Name = "txtColumnaOID";
            this.txtColumnaOID.Size = new System.Drawing.Size(35, 25);
            this.txtColumnaOID.TabIndex = 6;
            this.txtColumnaOID.KeyPress += new System.Windows.Forms.KeyPressEventHandler(this.txtColumnaOID_KeyPress);
            // 
            // txtFilaOID
            // 
            this.txtFilaOID.BackColor = System.Drawing.SystemColors.Menu;
            this.txtFilaOID.Location = new System.Drawing.Point(219, 73);
            this.txtFilaOID.Name = "txtFilaOID";
            this.txtFilaOID.Size = new System.Drawing.Size(35, 25);
            this.txtFilaOID.TabIndex = 5;
            this.txtFilaOID.KeyPress += new System.Windows.Forms.KeyPressEventHandler(this.txtFilaOID_KeyPress);
            // 
            // lblInfDer
            // 
            this.lblInfDer.AutoSize = true;
            this.lblInfDer.Location = new System.Drawing.Point(6, 76);
            this.lblInfDer.Name = "lblInfDer";
            this.lblInfDer.Size = new System.Drawing.Size(124, 18);
            this.lblInfDer.TabIndex = 1;
            this.lblInfDer.Text = "Inferior derecha";
            // 
            // lblSupIzq
            // 
            this.lblSupIzq.AutoSize = true;
            this.lblSupIzq.Location = new System.Drawing.Point(6, 49);
            this.lblSupIzq.Name = "lblSupIzq";
            this.lblSupIzq.Size = new System.Drawing.Size(143, 18);
            this.lblSupIzq.TabIndex = 0;
            this.lblSupIzq.Text = "Superior izquierda";
            // 
            // btnGenEsp
            // 
            this.btnGenEsp.Enabled = false;
            this.btnGenEsp.Font = new System.Drawing.Font("Maiandra GD", 9F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.btnGenEsp.ForeColor = System.Drawing.SystemColors.ControlText;
            this.btnGenEsp.Location = new System.Drawing.Point(117, 550);
            this.btnGenEsp.Name = "btnGenEsp";
            this.btnGenEsp.Size = new System.Drawing.Size(100, 23);
            this.btnGenEsp.TabIndex = 13;
            this.btnGenEsp.Text = "Generar Espacio";
            this.btnGenEsp.UseVisualStyleBackColor = true;
            this.btnGenEsp.Click += new System.EventHandler(this.btnGenEsp_Click);
            // 
            // btnRestAll
            // 
            this.btnRestAll.Font = new System.Drawing.Font("Maiandra GD", 9F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.btnRestAll.ForeColor = System.Drawing.SystemColors.ControlText;
            this.btnRestAll.Location = new System.Drawing.Point(223, 550);
            this.btnRestAll.Name = "btnRestAll";
            this.btnRestAll.Size = new System.Drawing.Size(119, 23);
            this.btnRestAll.TabIndex = 14;
            this.btnRestAll.Text = "Reestablecer todo";
            this.btnRestAll.UseVisualStyleBackColor = true;
            this.btnRestAll.Click += new System.EventHandler(this.btnRestAll_Click);
            // 
            // btnSalir
            // 
            this.btnSalir.Font = new System.Drawing.Font("Maiandra GD", 9F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.btnSalir.ForeColor = System.Drawing.SystemColors.ControlText;
            this.btnSalir.Location = new System.Drawing.Point(348, 550);
            this.btnSalir.Name = "btnSalir";
            this.btnSalir.Size = new System.Drawing.Size(75, 23);
            this.btnSalir.TabIndex = 15;
            this.btnSalir.Text = "Salir";
            this.btnSalir.UseVisualStyleBackColor = true;
            this.btnSalir.Click += new System.EventHandler(this.btnSalir_Click);
            // 
            // erpNumeros
            // 
            this.erpNumeros.ContainerControl = this;
            // 
            // grbCargarArchivo
            // 
            this.grbCargarArchivo.Controls.Add(this.lblIndic0);
            this.grbCargarArchivo.Controls.Add(this.btnCargarArch);
            this.grbCargarArchivo.Controls.Add(this.txtNArch);
            this.grbCargarArchivo.Controls.Add(this.lblNombreArch);
            this.grbCargarArchivo.Font = new System.Drawing.Font("Maiandra GD", 11.25F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.grbCargarArchivo.ForeColor = System.Drawing.SystemColors.ControlLightLight;
            this.grbCargarArchivo.Location = new System.Drawing.Point(22, 12);
            this.grbCargarArchivo.Name = "grbCargarArchivo";
            this.grbCargarArchivo.Size = new System.Drawing.Size(401, 97);
            this.grbCargarArchivo.TabIndex = 0;
            this.grbCargarArchivo.TabStop = false;
            this.grbCargarArchivo.Text = "Cargar Archivo";
            // 
            // lblIndic0
            // 
            this.lblIndic0.AutoSize = true;
            this.lblIndic0.Font = new System.Drawing.Font("Maiandra GD", 9F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.lblIndic0.Location = new System.Drawing.Point(6, 21);
            this.lblIndic0.Name = "lblIndic0";
            this.lblIndic0.Size = new System.Drawing.Size(346, 15);
            this.lblIndic0.TabIndex = 14;
            this.lblIndic0.Text = "Puedes cargar un archivo .DAT  anteriormente creado.";
            // 
            // btnCargarArch
            // 
            this.btnCargarArch.Font = new System.Drawing.Font("Maiandra GD", 9F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.btnCargarArch.ForeColor = System.Drawing.SystemColors.ControlText;
            this.btnCargarArch.Location = new System.Drawing.Point(310, 53);
            this.btnCargarArch.Name = "btnCargarArch";
            this.btnCargarArch.Size = new System.Drawing.Size(75, 23);
            this.btnCargarArch.TabIndex = 4;
            this.btnCargarArch.Text = "Cargar";
            this.btnCargarArch.UseVisualStyleBackColor = true;
            this.btnCargarArch.Click += new System.EventHandler(this.btnCargarArch_Click);
            // 
            // txtNArch
            // 
            this.txtNArch.BackColor = System.Drawing.SystemColors.Menu;
            this.txtNArch.Location = new System.Drawing.Point(175, 50);
            this.txtNArch.Name = "txtNArch";
            this.txtNArch.Size = new System.Drawing.Size(129, 25);
            this.txtNArch.TabIndex = 3;
            this.txtNArch.KeyPress += new System.Windows.Forms.KeyPressEventHandler(this.txtNArch_KeyPress);
            // 
            // lblNombreArch
            // 
            this.lblNombreArch.AutoSize = true;
            this.lblNombreArch.Location = new System.Drawing.Point(6, 53);
            this.lblNombreArch.Name = "lblNombreArch";
            this.lblNombreArch.Size = new System.Drawing.Size(161, 18);
            this.lblNombreArch.TabIndex = 1;
            this.lblNombreArch.Text = "Nombre del archivo:";
            // 
            // lblAlumno
            // 
            this.lblAlumno.AutoSize = true;
            this.lblAlumno.Font = new System.Drawing.Font("Maiandra GD", 8.25F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.lblAlumno.ForeColor = System.Drawing.SystemColors.ControlLightLight;
            this.lblAlumno.Location = new System.Drawing.Point(12, 576);
            this.lblAlumno.Name = "lblAlumno";
            this.lblAlumno.Size = new System.Drawing.Size(156, 14);
            this.lblAlumno.TabIndex = 16;
            this.lblAlumno.Text = "Leonardo Daniel Sánchez López";
            // 
            // frmTomyJerry
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(6F, 13F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.BackColor = System.Drawing.SystemColors.WindowFrame;
            this.ClientSize = new System.Drawing.Size(446, 596);
            this.ControlBox = false;
            this.Controls.Add(this.lblAlumno);
            this.Controls.Add(this.grbCargarArchivo);
            this.Controls.Add(this.btnSalir);
            this.Controls.Add(this.btnRestAll);
            this.Controls.Add(this.btnGenEsp);
            this.Controls.Add(this.grbObstáculos);
            this.Controls.Add(this.grbUbicaciones);
            this.Controls.Add(this.grbTamaño);
            this.FormBorderStyle = System.Windows.Forms.FormBorderStyle.FixedSingle;
            this.Icon = ((System.Drawing.Icon)(resources.GetObject("$this.Icon")));
            this.Name = "frmTomyJerry";
            this.StartPosition = System.Windows.Forms.FormStartPosition.CenterScreen;
            this.Text = "Tom y Jerry";
            this.Load += new System.EventHandler(this.frmTomyJerry_Load);
            this.grbTamaño.ResumeLayout(false);
            this.grbTamaño.PerformLayout();
            this.grbUbicaciones.ResumeLayout(false);
            this.grbUbicaciones.PerformLayout();
            this.grbObstáculos.ResumeLayout(false);
            this.grbObstáculos.PerformLayout();
            ((System.ComponentModel.ISupportInitialize)(this.erpNumeros)).EndInit();
            this.grbCargarArchivo.ResumeLayout(false);
            this.grbCargarArchivo.PerformLayout();
            this.ResumeLayout(false);
            this.PerformLayout();

        }

        #endregion

        private System.Windows.Forms.GroupBox grbTamaño;
        private System.Windows.Forms.TextBox txtN;
        private System.Windows.Forms.TextBox txtM;
        private System.Windows.Forms.Label lblColumnas;
        private System.Windows.Forms.Label lblFilas;
        private System.Windows.Forms.Button btnAceptarEsp;
        private System.Windows.Forms.GroupBox grbUbicaciones;
        private System.Windows.Forms.Label lblFilaJ;
        private System.Windows.Forms.Label lblFilaT;
        private System.Windows.Forms.TextBox txtColumnaJ;
        private System.Windows.Forms.TextBox txtFilaJ;
        private System.Windows.Forms.TextBox txtColumnaT;
        private System.Windows.Forms.TextBox txtFilaT;
        private System.Windows.Forms.Label lblJerry;
        private System.Windows.Forms.Label lblTom;
        private System.Windows.Forms.Label lblColumnaJ;
        private System.Windows.Forms.Label lblColumnaT;
        private System.Windows.Forms.Button btnAceptarUbi;
        private System.Windows.Forms.Label lblIndUbic;
        private System.Windows.Forms.GroupBox grbObstáculos;
        private System.Windows.Forms.Label label6;
        private System.Windows.Forms.Button btnIntObst;
        private System.Windows.Forms.Label lblColumna2;
        private System.Windows.Forms.Label lblColumna1;
        private System.Windows.Forms.Label lblFila2;
        private System.Windows.Forms.Label lblFila1;
        private System.Windows.Forms.TextBox txtColumnaOSI;
        private System.Windows.Forms.TextBox txtFilaOSI;
        private System.Windows.Forms.TextBox txtColumnaOID;
        private System.Windows.Forms.TextBox txtFilaOID;
        private System.Windows.Forms.Label lblInfDer;
        private System.Windows.Forms.Label lblSupIzq;
        private System.Windows.Forms.Button btnRestObst;
        private System.Windows.Forms.Button btnGenEsp;
        private System.Windows.Forms.Button btnRestAll;
        private System.Windows.Forms.Button btnSalir;
        private System.Windows.Forms.ErrorProvider erpNumeros;
        private System.Windows.Forms.GroupBox grbCargarArchivo;
        private System.Windows.Forms.Label lblIndic0;
        private System.Windows.Forms.Button btnCargarArch;
        private System.Windows.Forms.TextBox txtNArch;
        private System.Windows.Forms.Label lblNombreArch;
        private System.Windows.Forms.Label lblAlumno;
    }
}

