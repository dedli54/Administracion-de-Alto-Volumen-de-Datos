
namespace CapaPresentacion
{
    partial class frmHotel
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
            System.Windows.Forms.DataGridViewCellStyle dataGridViewCellStyle5 = new System.Windows.Forms.DataGridViewCellStyle();
            System.Windows.Forms.DataGridViewCellStyle dataGridViewCellStyle6 = new System.Windows.Forms.DataGridViewCellStyle();
            this.textPisos = new System.Windows.Forms.NumericUpDown();
            this.txtindice = new System.Windows.Forms.TextBox();
            this.textId = new System.Windows.Forms.TextBox();
            this.btnBuscar = new FontAwesome.Sharp.IconButton();
            this.txtBuscar = new System.Windows.Forms.TextBox();
            this.cboBuscar = new System.Windows.Forms.ComboBox();
            this.label15 = new System.Windows.Forms.Label();
            this.btnLimpiar = new FontAwesome.Sharp.IconButton();
            this.cboestado = new System.Windows.Forms.ComboBox();
            this.label9 = new System.Windows.Forms.Label();
            this.label10 = new System.Windows.Forms.Label();
            this.iconEliminar = new FontAwesome.Sharp.IconButton();
            this.iconGuardar = new FontAwesome.Sharp.IconButton();
            this.label3 = new System.Windows.Forms.Label();
            this.textNombre = new System.Windows.Forms.TextBox();
            this.label1 = new System.Windows.Forms.Label();
            this.label2 = new System.Windows.Forms.Label();
            this.label4 = new System.Windows.Forms.Label();
            this.txtDireccion = new System.Windows.Forms.TextBox();
            this.label5 = new System.Windows.Forms.Label();
            this.txtDescripcion = new System.Windows.Forms.TextBox();
            this.textHab = new System.Windows.Forms.NumericUpDown();
            this.label6 = new System.Windows.Forms.Label();
            this.btnLimpiarBuscador = new FontAwesome.Sharp.IconButton();
            this.dataUser = new System.Windows.Forms.DataGridView();
            this.btnseleccionar = new System.Windows.Forms.DataGridViewButtonColumn();
            this.Nom_Hot = new System.Windows.Forms.DataGridViewTextBoxColumn();
            this.Desc_Hot = new System.Windows.Forms.DataGridViewTextBoxColumn();
            this.Dir_Hot = new System.Windows.Forms.DataGridViewTextBoxColumn();
            this.Estado = new System.Windows.Forms.DataGridViewTextBoxColumn();
            this.EstadoHotel = new System.Windows.Forms.DataGridViewTextBoxColumn();
            this.Habitaciones = new System.Windows.Forms.DataGridViewTextBoxColumn();
            this.Pisos = new System.Windows.Forms.DataGridViewTextBoxColumn();
            this.Fecha = new System.Windows.Forms.DataGridViewTextBoxColumn();
            this.iconButton3 = new FontAwesome.Sharp.IconButton();
            ((System.ComponentModel.ISupportInitialize)(this.textPisos)).BeginInit();
            ((System.ComponentModel.ISupportInitialize)(this.textHab)).BeginInit();
            ((System.ComponentModel.ISupportInitialize)(this.dataUser)).BeginInit();
            this.SuspendLayout();
            // 
            // textPisos
            // 
            this.textPisos.Increment = new decimal(new int[] {
            5,
            0,
            0,
            0});
            this.textPisos.Location = new System.Drawing.Point(12, 190);
            this.textPisos.Name = "textPisos";
            this.textPisos.Size = new System.Drawing.Size(237, 20);
            this.textPisos.TabIndex = 99;
            this.textPisos.Value = new decimal(new int[] {
            1,
            0,
            0,
            0});
            // 
            // txtindice
            // 
            this.txtindice.Location = new System.Drawing.Point(51, 30);
            this.txtindice.Name = "txtindice";
            this.txtindice.Size = new System.Drawing.Size(33, 20);
            this.txtindice.TabIndex = 97;
            this.txtindice.Text = "-1";
            this.txtindice.Visible = false;
            // 
            // textId
            // 
            this.textId.Location = new System.Drawing.Point(12, 30);
            this.textId.Name = "textId";
            this.textId.Size = new System.Drawing.Size(33, 20);
            this.textId.TabIndex = 96;
            this.textId.Text = "-1";
            this.textId.Visible = false;
            // 
            // btnBuscar
            // 
            this.btnBuscar.BackColor = System.Drawing.Color.Transparent;
            this.btnBuscar.IconChar = FontAwesome.Sharp.IconChar.MagnifyingGlass;
            this.btnBuscar.IconColor = System.Drawing.Color.Black;
            this.btnBuscar.IconFont = FontAwesome.Sharp.IconFont.Auto;
            this.btnBuscar.IconSize = 18;
            this.btnBuscar.Location = new System.Drawing.Point(1106, 19);
            this.btnBuscar.Name = "btnBuscar";
            this.btnBuscar.Size = new System.Drawing.Size(39, 20);
            this.btnBuscar.TabIndex = 95;
            this.btnBuscar.UseVisualStyleBackColor = false;
            this.btnBuscar.Click += new System.EventHandler(this.btnBuscar_Click);
            // 
            // txtBuscar
            // 
            this.txtBuscar.Location = new System.Drawing.Point(622, 19);
            this.txtBuscar.Name = "txtBuscar";
            this.txtBuscar.Size = new System.Drawing.Size(478, 20);
            this.txtBuscar.TabIndex = 94;
            // 
            // cboBuscar
            // 
            this.cboBuscar.DropDownStyle = System.Windows.Forms.ComboBoxStyle.DropDownList;
            this.cboBuscar.FormattingEnabled = true;
            this.cboBuscar.Location = new System.Drawing.Point(488, 18);
            this.cboBuscar.Name = "cboBuscar";
            this.cboBuscar.Size = new System.Drawing.Size(128, 21);
            this.cboBuscar.TabIndex = 93;
            // 
            // label15
            // 
            this.label15.AutoSize = true;
            this.label15.BackColor = System.Drawing.Color.White;
            this.label15.Location = new System.Drawing.Point(421, 22);
            this.label15.Name = "label15";
            this.label15.Size = new System.Drawing.Size(61, 13);
            this.label15.TabIndex = 92;
            this.label15.Text = "Buscar por:";
            // 
            // btnLimpiar
            // 
            this.btnLimpiar.BackColor = System.Drawing.Color.SteelBlue;
            this.btnLimpiar.FlatAppearance.BorderColor = System.Drawing.Color.Black;
            this.btnLimpiar.FlatStyle = System.Windows.Forms.FlatStyle.Flat;
            this.btnLimpiar.ForeColor = System.Drawing.Color.White;
            this.btnLimpiar.IconChar = FontAwesome.Sharp.IconChar.Broom;
            this.btnLimpiar.IconColor = System.Drawing.Color.White;
            this.btnLimpiar.IconFont = FontAwesome.Sharp.IconFont.Auto;
            this.btnLimpiar.IconSize = 20;
            this.btnLimpiar.Location = new System.Drawing.Point(51, 382);
            this.btnLimpiar.Name = "btnLimpiar";
            this.btnLimpiar.Size = new System.Drawing.Size(168, 23);
            this.btnLimpiar.TabIndex = 91;
            this.btnLimpiar.Text = "Limpiar";
            this.btnLimpiar.TextAlign = System.Drawing.ContentAlignment.MiddleRight;
            this.btnLimpiar.TextImageRelation = System.Windows.Forms.TextImageRelation.ImageBeforeText;
            this.btnLimpiar.UseVisualStyleBackColor = false;
            this.btnLimpiar.Click += new System.EventHandler(this.btnLimpiar_Click);
            // 
            // cboestado
            // 
            this.cboestado.DropDownStyle = System.Windows.Forms.ComboBoxStyle.DropDownList;
            this.cboestado.FormattingEnabled = true;
            this.cboestado.Location = new System.Drawing.Point(14, 271);
            this.cboestado.Name = "cboestado";
            this.cboestado.Size = new System.Drawing.Size(235, 21);
            this.cboestado.TabIndex = 88;
            // 
            // label9
            // 
            this.label9.AutoSize = true;
            this.label9.BackColor = System.Drawing.Color.White;
            this.label9.Location = new System.Drawing.Point(15, 255);
            this.label9.Name = "label9";
            this.label9.Size = new System.Drawing.Size(83, 13);
            this.label9.TabIndex = 87;
            this.label9.Text = "Estado de Hotel";
            // 
            // label10
            // 
            this.label10.BackColor = System.Drawing.Color.White;
            this.label10.Font = new System.Drawing.Font("Microsoft Sans Serif", 15F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.label10.Location = new System.Drawing.Point(269, 15);
            this.label10.Name = "label10";
            this.label10.Size = new System.Drawing.Size(925, 27);
            this.label10.TabIndex = 85;
            this.label10.Text = "Lista de Hoteles";
            this.label10.TextAlign = System.Drawing.ContentAlignment.MiddleLeft;
            // 
            // iconEliminar
            // 
            this.iconEliminar.BackColor = System.Drawing.Color.Firebrick;
            this.iconEliminar.FlatAppearance.BorderColor = System.Drawing.Color.Black;
            this.iconEliminar.FlatStyle = System.Windows.Forms.FlatStyle.Flat;
            this.iconEliminar.ForeColor = System.Drawing.Color.White;
            this.iconEliminar.IconChar = FontAwesome.Sharp.IconChar.TrashAlt;
            this.iconEliminar.IconColor = System.Drawing.Color.White;
            this.iconEliminar.IconFont = FontAwesome.Sharp.IconFont.Auto;
            this.iconEliminar.IconSize = 20;
            this.iconEliminar.Location = new System.Drawing.Point(51, 411);
            this.iconEliminar.Name = "iconEliminar";
            this.iconEliminar.Size = new System.Drawing.Size(168, 23);
            this.iconEliminar.TabIndex = 84;
            this.iconEliminar.Text = "Eliminar";
            this.iconEliminar.TextAlign = System.Drawing.ContentAlignment.MiddleRight;
            this.iconEliminar.TextImageRelation = System.Windows.Forms.TextImageRelation.ImageBeforeText;
            this.iconEliminar.UseVisualStyleBackColor = false;
            this.iconEliminar.Click += new System.EventHandler(this.iconEliminar_Click);
            // 
            // iconGuardar
            // 
            this.iconGuardar.BackColor = System.Drawing.Color.Chartreuse;
            this.iconGuardar.FlatAppearance.BorderColor = System.Drawing.Color.Black;
            this.iconGuardar.FlatStyle = System.Windows.Forms.FlatStyle.Flat;
            this.iconGuardar.ForeColor = System.Drawing.Color.White;
            this.iconGuardar.IconChar = FontAwesome.Sharp.IconChar.ExternalLinkSquareAlt;
            this.iconGuardar.IconColor = System.Drawing.Color.White;
            this.iconGuardar.IconFont = FontAwesome.Sharp.IconFont.Auto;
            this.iconGuardar.IconSize = 20;
            this.iconGuardar.Location = new System.Drawing.Point(51, 326);
            this.iconGuardar.Name = "iconGuardar";
            this.iconGuardar.Size = new System.Drawing.Size(168, 23);
            this.iconGuardar.TabIndex = 83;
            this.iconGuardar.Text = "Agregar";
            this.iconGuardar.TextAlign = System.Drawing.ContentAlignment.MiddleRight;
            this.iconGuardar.TextImageRelation = System.Windows.Forms.TextImageRelation.ImageBeforeText;
            this.iconGuardar.UseVisualStyleBackColor = false;
            this.iconGuardar.Click += new System.EventHandler(this.iconGuardar_Click);
            // 
            // label3
            // 
            this.label3.AutoSize = true;
            this.label3.BackColor = System.Drawing.Color.White;
            this.label3.Location = new System.Drawing.Point(9, 174);
            this.label3.Name = "label3";
            this.label3.Size = new System.Drawing.Size(87, 13);
            this.label3.TabIndex = 82;
            this.label3.Text = "Numero de Pisos";
            // 
            // textNombre
            // 
            this.textNombre.Location = new System.Drawing.Point(12, 69);
            this.textNombre.Name = "textNombre";
            this.textNombre.Size = new System.Drawing.Size(237, 20);
            this.textNombre.TabIndex = 81;
            this.textNombre.KeyPress += new System.Windows.Forms.KeyPressEventHandler(this.textNombre_KeyPress);
            // 
            // label1
            // 
            this.label1.BackColor = System.Drawing.Color.White;
            this.label1.Dock = System.Windows.Forms.DockStyle.Left;
            this.label1.ImageAlign = System.Drawing.ContentAlignment.MiddleLeft;
            this.label1.Location = new System.Drawing.Point(0, 0);
            this.label1.Name = "label1";
            this.label1.Size = new System.Drawing.Size(263, 450);
            this.label1.TabIndex = 86;
            // 
            // label2
            // 
            this.label2.AutoSize = true;
            this.label2.BackColor = System.Drawing.Color.White;
            this.label2.Location = new System.Drawing.Point(9, 53);
            this.label2.Name = "label2";
            this.label2.Size = new System.Drawing.Size(44, 13);
            this.label2.TabIndex = 100;
            this.label2.Text = "Nombre";
            // 
            // label4
            // 
            this.label4.AutoSize = true;
            this.label4.BackColor = System.Drawing.Color.White;
            this.label4.Location = new System.Drawing.Point(9, 92);
            this.label4.Name = "label4";
            this.label4.Size = new System.Drawing.Size(52, 13);
            this.label4.TabIndex = 102;
            this.label4.Text = "Direccion";
            // 
            // txtDireccion
            // 
            this.txtDireccion.Location = new System.Drawing.Point(12, 108);
            this.txtDireccion.Name = "txtDireccion";
            this.txtDireccion.Size = new System.Drawing.Size(237, 20);
            this.txtDireccion.TabIndex = 101;
            // 
            // label5
            // 
            this.label5.AutoSize = true;
            this.label5.BackColor = System.Drawing.Color.White;
            this.label5.Location = new System.Drawing.Point(12, 131);
            this.label5.Name = "label5";
            this.label5.Size = new System.Drawing.Size(63, 13);
            this.label5.TabIndex = 180;
            this.label5.Text = "Descripcion";
            // 
            // txtDescripcion
            // 
            this.txtDescripcion.Location = new System.Drawing.Point(15, 147);
            this.txtDescripcion.Name = "txtDescripcion";
            this.txtDescripcion.Size = new System.Drawing.Size(237, 20);
            this.txtDescripcion.TabIndex = 179;
            this.txtDescripcion.KeyPress += new System.Windows.Forms.KeyPressEventHandler(this.textBox2_KeyPress);
            // 
            // textHab
            // 
            this.textHab.Increment = new decimal(new int[] {
            5,
            0,
            0,
            0});
            this.textHab.Location = new System.Drawing.Point(12, 232);
            this.textHab.Name = "textHab";
            this.textHab.Size = new System.Drawing.Size(237, 20);
            this.textHab.TabIndex = 182;
            this.textHab.Value = new decimal(new int[] {
            1,
            0,
            0,
            0});
            // 
            // label6
            // 
            this.label6.AutoSize = true;
            this.label6.BackColor = System.Drawing.Color.White;
            this.label6.Location = new System.Drawing.Point(9, 216);
            this.label6.Name = "label6";
            this.label6.Size = new System.Drawing.Size(124, 13);
            this.label6.TabIndex = 181;
            this.label6.Text = "Numero de Habitaciones";
            // 
            // btnLimpiarBuscador
            // 
            this.btnLimpiarBuscador.BackColor = System.Drawing.Color.Transparent;
            this.btnLimpiarBuscador.IconChar = FontAwesome.Sharp.IconChar.Broom;
            this.btnLimpiarBuscador.IconColor = System.Drawing.Color.Black;
            this.btnLimpiarBuscador.IconFont = FontAwesome.Sharp.IconFont.Auto;
            this.btnLimpiarBuscador.IconSize = 18;
            this.btnLimpiarBuscador.Location = new System.Drawing.Point(1151, 19);
            this.btnLimpiarBuscador.Name = "btnLimpiarBuscador";
            this.btnLimpiarBuscador.Size = new System.Drawing.Size(39, 20);
            this.btnLimpiarBuscador.TabIndex = 183;
            this.btnLimpiarBuscador.UseVisualStyleBackColor = false;
            this.btnLimpiarBuscador.Click += new System.EventHandler(this.btnLimpiarBuscador_Click);
            // 
            // dataUser
            // 
            this.dataUser.AllowUserToAddRows = false;
            dataGridViewCellStyle5.Alignment = System.Windows.Forms.DataGridViewContentAlignment.MiddleLeft;
            dataGridViewCellStyle5.BackColor = System.Drawing.SystemColors.Control;
            dataGridViewCellStyle5.Font = new System.Drawing.Font("Microsoft Sans Serif", 9F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            dataGridViewCellStyle5.ForeColor = System.Drawing.SystemColors.WindowText;
            dataGridViewCellStyle5.Padding = new System.Windows.Forms.Padding(2);
            dataGridViewCellStyle5.SelectionBackColor = System.Drawing.SystemColors.Highlight;
            dataGridViewCellStyle5.SelectionForeColor = System.Drawing.SystemColors.HighlightText;
            dataGridViewCellStyle5.WrapMode = System.Windows.Forms.DataGridViewTriState.True;
            this.dataUser.ColumnHeadersDefaultCellStyle = dataGridViewCellStyle5;
            this.dataUser.ColumnHeadersHeightSizeMode = System.Windows.Forms.DataGridViewColumnHeadersHeightSizeMode.AutoSize;
            this.dataUser.Columns.AddRange(new System.Windows.Forms.DataGridViewColumn[] {
            this.btnseleccionar,
            this.Nom_Hot,
            this.Desc_Hot,
            this.Dir_Hot,
            this.Estado,
            this.EstadoHotel,
            this.Habitaciones,
            this.Pisos,
            this.Fecha});
            this.dataUser.Location = new System.Drawing.Point(269, 49);
            this.dataUser.MultiSelect = false;
            this.dataUser.Name = "dataUser";
            this.dataUser.ReadOnly = true;
            dataGridViewCellStyle6.SelectionBackColor = System.Drawing.Color.White;
            dataGridViewCellStyle6.SelectionForeColor = System.Drawing.Color.Black;
            this.dataUser.RowsDefaultCellStyle = dataGridViewCellStyle6;
            this.dataUser.RowTemplate.Height = 25;
            this.dataUser.Size = new System.Drawing.Size(925, 389);
            this.dataUser.TabIndex = 184;
            this.dataUser.CellContentClick += new System.Windows.Forms.DataGridViewCellEventHandler(this.dataUser_CellContentClick);
            // 
            // btnseleccionar
            // 
            this.btnseleccionar.HeaderText = "";
            this.btnseleccionar.Name = "btnseleccionar";
            this.btnseleccionar.ReadOnly = true;
            this.btnseleccionar.Width = 30;
            // 
            // Nom_Hot
            // 
            this.Nom_Hot.HeaderText = "Nombre hotel";
            this.Nom_Hot.Name = "Nom_Hot";
            this.Nom_Hot.ReadOnly = true;
            this.Nom_Hot.Width = 120;
            // 
            // Desc_Hot
            // 
            this.Desc_Hot.HeaderText = "Descripcion hotel";
            this.Desc_Hot.Name = "Desc_Hot";
            this.Desc_Hot.ReadOnly = true;
            this.Desc_Hot.Width = 300;
            // 
            // Dir_Hot
            // 
            this.Dir_Hot.HeaderText = "Direccion hotel";
            this.Dir_Hot.Name = "Dir_Hot";
            this.Dir_Hot.ReadOnly = true;
            this.Dir_Hot.Width = 200;
            // 
            // Estado
            // 
            this.Estado.HeaderText = "Estado";
            this.Estado.Name = "Estado";
            this.Estado.ReadOnly = true;
            this.Estado.Visible = false;
            // 
            // EstadoHotel
            // 
            this.EstadoHotel.HeaderText = "Estado hotel";
            this.EstadoHotel.Name = "EstadoHotel";
            this.EstadoHotel.ReadOnly = true;
            this.EstadoHotel.Width = 60;
            // 
            // Habitaciones
            // 
            this.Habitaciones.HeaderText = "Habitaciones";
            this.Habitaciones.Name = "Habitaciones";
            this.Habitaciones.ReadOnly = true;
            // 
            // Pisos
            // 
            this.Pisos.HeaderText = "Pisos";
            this.Pisos.Name = "Pisos";
            this.Pisos.ReadOnly = true;
            this.Pisos.Width = 50;
            // 
            // Fecha
            // 
            this.Fecha.HeaderText = "Fecha registro";
            this.Fecha.Name = "Fecha";
            this.Fecha.ReadOnly = true;
            // 
            // iconButton3
            // 
            this.iconButton3.BackColor = System.Drawing.Color.DarkOrange;
            this.iconButton3.FlatAppearance.BorderColor = System.Drawing.Color.Black;
            this.iconButton3.FlatStyle = System.Windows.Forms.FlatStyle.Flat;
            this.iconButton3.ForeColor = System.Drawing.Color.White;
            this.iconButton3.IconChar = FontAwesome.Sharp.IconChar.ArrowLeft;
            this.iconButton3.IconColor = System.Drawing.Color.White;
            this.iconButton3.IconFont = FontAwesome.Sharp.IconFont.Auto;
            this.iconButton3.IconSize = 20;
            this.iconButton3.Location = new System.Drawing.Point(51, 353);
            this.iconButton3.Name = "iconButton3";
            this.iconButton3.Size = new System.Drawing.Size(168, 23);
            this.iconButton3.TabIndex = 185;
            this.iconButton3.Text = "Actualizar";
            this.iconButton3.TextAlign = System.Drawing.ContentAlignment.MiddleRight;
            this.iconButton3.TextImageRelation = System.Windows.Forms.TextImageRelation.ImageBeforeText;
            this.iconButton3.UseVisualStyleBackColor = false;
            this.iconButton3.Click += new System.EventHandler(this.iconButton3_Click);
            // 
            // frmHotel
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(6F, 13F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.BackColor = System.Drawing.Color.SteelBlue;
            this.ClientSize = new System.Drawing.Size(1206, 450);
            this.Controls.Add(this.iconButton3);
            this.Controls.Add(this.dataUser);
            this.Controls.Add(this.btnLimpiarBuscador);
            this.Controls.Add(this.textHab);
            this.Controls.Add(this.label6);
            this.Controls.Add(this.label5);
            this.Controls.Add(this.txtDescripcion);
            this.Controls.Add(this.label4);
            this.Controls.Add(this.txtDireccion);
            this.Controls.Add(this.label2);
            this.Controls.Add(this.textPisos);
            this.Controls.Add(this.txtindice);
            this.Controls.Add(this.textId);
            this.Controls.Add(this.btnBuscar);
            this.Controls.Add(this.txtBuscar);
            this.Controls.Add(this.cboBuscar);
            this.Controls.Add(this.label15);
            this.Controls.Add(this.btnLimpiar);
            this.Controls.Add(this.cboestado);
            this.Controls.Add(this.label9);
            this.Controls.Add(this.label10);
            this.Controls.Add(this.iconEliminar);
            this.Controls.Add(this.iconGuardar);
            this.Controls.Add(this.label3);
            this.Controls.Add(this.textNombre);
            this.Controls.Add(this.label1);
            this.Name = "frmHotel";
            this.Text = "Hotel";
            this.Load += new System.EventHandler(this.frmHotel_Load);
            ((System.ComponentModel.ISupportInitialize)(this.textPisos)).EndInit();
            ((System.ComponentModel.ISupportInitialize)(this.textHab)).EndInit();
            ((System.ComponentModel.ISupportInitialize)(this.dataUser)).EndInit();
            this.ResumeLayout(false);
            this.PerformLayout();

        }

        #endregion

        private System.Windows.Forms.NumericUpDown textPisos;
        private System.Windows.Forms.TextBox txtindice;
        private System.Windows.Forms.TextBox textId;
        private FontAwesome.Sharp.IconButton btnBuscar;
        private System.Windows.Forms.TextBox txtBuscar;
        private System.Windows.Forms.ComboBox cboBuscar;
        private System.Windows.Forms.Label label15;
        private FontAwesome.Sharp.IconButton btnLimpiar;
        private System.Windows.Forms.ComboBox cboestado;
        private System.Windows.Forms.Label label9;
        private System.Windows.Forms.Label label10;
        private FontAwesome.Sharp.IconButton iconEliminar;
        private FontAwesome.Sharp.IconButton iconGuardar;
        private System.Windows.Forms.Label label3;
        private System.Windows.Forms.TextBox textNombre;
        private System.Windows.Forms.Label label1;
        private System.Windows.Forms.Label label2;
        private System.Windows.Forms.Label label4;
        private System.Windows.Forms.TextBox txtDireccion;
        private System.Windows.Forms.Label label5;
        private System.Windows.Forms.TextBox txtDescripcion;
        private System.Windows.Forms.NumericUpDown textHab;
        private System.Windows.Forms.Label label6;
        private FontAwesome.Sharp.IconButton btnLimpiarBuscador;
        private System.Windows.Forms.DataGridView dataUser;
        private System.Windows.Forms.DataGridViewButtonColumn btnseleccionar;
        private System.Windows.Forms.DataGridViewTextBoxColumn Nom_Hot;
        private System.Windows.Forms.DataGridViewTextBoxColumn Desc_Hot;
        private System.Windows.Forms.DataGridViewTextBoxColumn Dir_Hot;
        private System.Windows.Forms.DataGridViewTextBoxColumn Estado;
        private System.Windows.Forms.DataGridViewTextBoxColumn EstadoHotel;
        private System.Windows.Forms.DataGridViewTextBoxColumn Habitaciones;
        private System.Windows.Forms.DataGridViewTextBoxColumn Pisos;
        private System.Windows.Forms.DataGridViewTextBoxColumn Fecha;
        private FontAwesome.Sharp.IconButton iconButton3;
    }
}