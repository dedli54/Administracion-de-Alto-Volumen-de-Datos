
namespace CapaPresentacion
{
    partial class frmHabitacion
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
            this.label16 = new System.Windows.Forms.Label();
            this.btnLimpiar = new FontAwesome.Sharp.IconButton();
            this.txtPR = new System.Windows.Forms.NumericUpDown();
            this.label9 = new System.Windows.Forms.Label();
            this.cboestado = new System.Windows.Forms.ComboBox();
            this.btnLimpiarBuscador = new FontAwesome.Sharp.IconButton();
            this.btnBuscar = new FontAwesome.Sharp.IconButton();
            this.txtBuscar = new System.Windows.Forms.TextBox();
            this.cboBuscar = new System.Windows.Forms.ComboBox();
            this.label15 = new System.Windows.Forms.Label();
            this.txtindice = new System.Windows.Forms.TextBox();
            this.textId = new System.Windows.Forms.TextBox();
            this.label11 = new System.Windows.Forms.Label();
            this.label8 = new System.Windows.Forms.Label();
            this.label3 = new System.Windows.Forms.Label();
            this.txtDescripcion = new System.Windows.Forms.TextBox();
            this.textNombre = new System.Windows.Forms.TextBox();
            this.label10 = new System.Windows.Forms.Label();
            this.iconButton3 = new FontAwesome.Sharp.IconButton();
            this.iconButton1 = new FontAwesome.Sharp.IconButton();
            this.label2 = new System.Windows.Forms.Label();
            this.label1 = new System.Windows.Forms.Label();
            this.cbohabitacion = new System.Windows.Forms.ComboBox();
            this.label4 = new System.Windows.Forms.Label();
            this.txtPersona = new System.Windows.Forms.NumericUpDown();
            this.dataUser = new System.Windows.Forms.DataGridView();
            this.btnseleccionar = new System.Windows.Forms.DataGridViewButtonColumn();
            this.Nom_Hab = new System.Windows.Forms.DataGridViewTextBoxColumn();
            this.Desc_Hab = new System.Windows.Forms.DataGridViewTextBoxColumn();
            this.Costo = new System.Windows.Forms.DataGridViewTextBoxColumn();
            this.Estado = new System.Windows.Forms.DataGridViewTextBoxColumn();
            this.EstadoHab = new System.Windows.Forms.DataGridViewTextBoxColumn();
            this.Cam_Hab = new System.Windows.Forms.DataGridViewTextBoxColumn();
            this.Tipo = new System.Windows.Forms.DataGridViewTextBoxColumn();
            this.Tipo_Hab = new System.Windows.Forms.DataGridViewTextBoxColumn();
            this.Fecha = new System.Windows.Forms.DataGridViewTextBoxColumn();
            this.iconButton2 = new FontAwesome.Sharp.IconButton();
            ((System.ComponentModel.ISupportInitialize)(this.txtPR)).BeginInit();
            ((System.ComponentModel.ISupportInitialize)(this.txtPersona)).BeginInit();
            ((System.ComponentModel.ISupportInitialize)(this.dataUser)).BeginInit();
            this.SuspendLayout();
            // 
            // label16
            // 
            this.label16.AutoSize = true;
            this.label16.BackColor = System.Drawing.Color.WhiteSmoke;
            this.label16.Location = new System.Drawing.Point(4, 163);
            this.label16.Name = "label16";
            this.label16.Size = new System.Drawing.Size(13, 13);
            this.label16.TabIndex = 167;
            this.label16.Text = "$";
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
            this.btnLimpiar.Location = new System.Drawing.Point(43, 301);
            this.btnLimpiar.Name = "btnLimpiar";
            this.btnLimpiar.Size = new System.Drawing.Size(168, 23);
            this.btnLimpiar.TabIndex = 159;
            this.btnLimpiar.Text = "Limpiar";
            this.btnLimpiar.TextAlign = System.Drawing.ContentAlignment.MiddleRight;
            this.btnLimpiar.TextImageRelation = System.Windows.Forms.TextImageRelation.ImageBeforeText;
            this.btnLimpiar.UseVisualStyleBackColor = false;
            this.btnLimpiar.Click += new System.EventHandler(this.btnLimpiar_Click);
            // 
            // txtPR
            // 
            this.txtPR.Increment = new decimal(new int[] {
            5,
            0,
            0,
            0});
            this.txtPR.Location = new System.Drawing.Point(13, 123);
            this.txtPR.Maximum = new decimal(new int[] {
            1000,
            0,
            0,
            0});
            this.txtPR.Name = "txtPR";
            this.txtPR.Size = new System.Drawing.Size(236, 20);
            this.txtPR.TabIndex = 158;
            this.txtPR.Value = new decimal(new int[] {
            1,
            0,
            0,
            0});
            // 
            // label9
            // 
            this.label9.AutoSize = true;
            this.label9.BackColor = System.Drawing.Color.White;
            this.label9.Location = new System.Drawing.Point(15, 185);
            this.label9.Name = "label9";
            this.label9.Size = new System.Drawing.Size(40, 13);
            this.label9.TabIndex = 157;
            this.label9.Text = "Estado";
            // 
            // cboestado
            // 
            this.cboestado.DropDownStyle = System.Windows.Forms.ComboBoxStyle.DropDownList;
            this.cboestado.FormattingEnabled = true;
            this.cboestado.Location = new System.Drawing.Point(18, 202);
            this.cboestado.Name = "cboestado";
            this.cboestado.Size = new System.Drawing.Size(110, 21);
            this.cboestado.TabIndex = 156;
            // 
            // btnLimpiarBuscador
            // 
            this.btnLimpiarBuscador.BackColor = System.Drawing.Color.Transparent;
            this.btnLimpiarBuscador.IconChar = FontAwesome.Sharp.IconChar.Broom;
            this.btnLimpiarBuscador.IconColor = System.Drawing.Color.Black;
            this.btnLimpiarBuscador.IconFont = FontAwesome.Sharp.IconFont.Auto;
            this.btnLimpiarBuscador.IconSize = 18;
            this.btnLimpiarBuscador.Location = new System.Drawing.Point(958, 12);
            this.btnLimpiarBuscador.Name = "btnLimpiarBuscador";
            this.btnLimpiarBuscador.Size = new System.Drawing.Size(39, 20);
            this.btnLimpiarBuscador.TabIndex = 153;
            this.btnLimpiarBuscador.UseVisualStyleBackColor = false;
            this.btnLimpiarBuscador.Click += new System.EventHandler(this.btnLimpiarBuscador_Click);
            // 
            // btnBuscar
            // 
            this.btnBuscar.BackColor = System.Drawing.Color.Transparent;
            this.btnBuscar.IconChar = FontAwesome.Sharp.IconChar.MagnifyingGlass;
            this.btnBuscar.IconColor = System.Drawing.Color.Black;
            this.btnBuscar.IconFont = FontAwesome.Sharp.IconFont.Auto;
            this.btnBuscar.IconSize = 18;
            this.btnBuscar.Location = new System.Drawing.Point(913, 12);
            this.btnBuscar.Name = "btnBuscar";
            this.btnBuscar.Size = new System.Drawing.Size(39, 20);
            this.btnBuscar.TabIndex = 152;
            this.btnBuscar.UseVisualStyleBackColor = false;
            this.btnBuscar.Click += new System.EventHandler(this.btnBuscar_Click);
            // 
            // txtBuscar
            // 
            this.txtBuscar.Location = new System.Drawing.Point(679, 12);
            this.txtBuscar.Name = "txtBuscar";
            this.txtBuscar.Size = new System.Drawing.Size(228, 20);
            this.txtBuscar.TabIndex = 151;
            // 
            // cboBuscar
            // 
            this.cboBuscar.DropDownStyle = System.Windows.Forms.ComboBoxStyle.DropDownList;
            this.cboBuscar.FormattingEnabled = true;
            this.cboBuscar.Location = new System.Drawing.Point(545, 11);
            this.cboBuscar.Name = "cboBuscar";
            this.cboBuscar.Size = new System.Drawing.Size(128, 21);
            this.cboBuscar.TabIndex = 150;
            // 
            // label15
            // 
            this.label15.AutoSize = true;
            this.label15.BackColor = System.Drawing.Color.White;
            this.label15.Location = new System.Drawing.Point(478, 15);
            this.label15.Name = "label15";
            this.label15.Size = new System.Drawing.Size(61, 13);
            this.label15.TabIndex = 149;
            this.label15.Text = "Buscar por:";
            // 
            // txtindice
            // 
            this.txtindice.Location = new System.Drawing.Point(214, 8);
            this.txtindice.Name = "txtindice";
            this.txtindice.Size = new System.Drawing.Size(33, 20);
            this.txtindice.TabIndex = 147;
            this.txtindice.Text = "-1";
            this.txtindice.Visible = false;
            // 
            // textId
            // 
            this.textId.Location = new System.Drawing.Point(104, 8);
            this.textId.Name = "textId";
            this.textId.Size = new System.Drawing.Size(104, 20);
            this.textId.TabIndex = 146;
            this.textId.Text = "-1";
            this.textId.Visible = false;
            // 
            // label11
            // 
            this.label11.AutoSize = true;
            this.label11.BackColor = System.Drawing.Color.White;
            this.label11.Location = new System.Drawing.Point(10, 106);
            this.label11.Name = "label11";
            this.label11.Size = new System.Drawing.Size(93, 13);
            this.label11.TabIndex = 145;
            this.label11.Text = "Numero de camas";
            // 
            // label8
            // 
            this.label8.AutoSize = true;
            this.label8.BackColor = System.Drawing.Color.White;
            this.label8.Location = new System.Drawing.Point(13, 146);
            this.label8.Name = "label8";
            this.label8.Size = new System.Drawing.Size(93, 13);
            this.label8.TabIndex = 141;
            this.label8.Text = "Costo por persona";
            // 
            // label3
            // 
            this.label3.AutoSize = true;
            this.label3.BackColor = System.Drawing.Color.White;
            this.label3.Location = new System.Drawing.Point(10, 65);
            this.label3.Name = "label3";
            this.label3.Size = new System.Drawing.Size(63, 13);
            this.label3.TabIndex = 137;
            this.label3.Text = "Descripcion";
            // 
            // txtDescripcion
            // 
            this.txtDescripcion.Location = new System.Drawing.Point(13, 81);
            this.txtDescripcion.Name = "txtDescripcion";
            this.txtDescripcion.Size = new System.Drawing.Size(236, 20);
            this.txtDescripcion.TabIndex = 136;
            this.txtDescripcion.KeyPress += new System.Windows.Forms.KeyPressEventHandler(this.txtdescrip_KeyPress);
            // 
            // textNombre
            // 
            this.textNombre.Location = new System.Drawing.Point(13, 42);
            this.textNombre.Name = "textNombre";
            this.textNombre.Size = new System.Drawing.Size(236, 20);
            this.textNombre.TabIndex = 135;
            this.textNombre.KeyPress += new System.Windows.Forms.KeyPressEventHandler(this.textNombre_KeyPress);
            // 
            // label10
            // 
            this.label10.BackColor = System.Drawing.Color.White;
            this.label10.Font = new System.Drawing.Font("Microsoft Sans Serif", 15F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.label10.Location = new System.Drawing.Point(278, 8);
            this.label10.Name = "label10";
            this.label10.Size = new System.Drawing.Size(732, 27);
            this.label10.TabIndex = 134;
            this.label10.Text = "Lista de Habitaciones";
            this.label10.TextAlign = System.Drawing.ContentAlignment.MiddleLeft;
            // 
            // iconButton3
            // 
            this.iconButton3.BackColor = System.Drawing.Color.Firebrick;
            this.iconButton3.FlatAppearance.BorderColor = System.Drawing.Color.Black;
            this.iconButton3.FlatStyle = System.Windows.Forms.FlatStyle.Flat;
            this.iconButton3.ForeColor = System.Drawing.Color.White;
            this.iconButton3.IconChar = FontAwesome.Sharp.IconChar.TrashAlt;
            this.iconButton3.IconColor = System.Drawing.Color.White;
            this.iconButton3.IconFont = FontAwesome.Sharp.IconFont.Auto;
            this.iconButton3.IconSize = 20;
            this.iconButton3.Location = new System.Drawing.Point(43, 330);
            this.iconButton3.Name = "iconButton3";
            this.iconButton3.Size = new System.Drawing.Size(168, 23);
            this.iconButton3.TabIndex = 133;
            this.iconButton3.Text = "Eliminar";
            this.iconButton3.TextAlign = System.Drawing.ContentAlignment.MiddleRight;
            this.iconButton3.TextImageRelation = System.Windows.Forms.TextImageRelation.ImageBeforeText;
            this.iconButton3.UseVisualStyleBackColor = false;
            this.iconButton3.Click += new System.EventHandler(this.iconButton3_Click);
            // 
            // iconButton1
            // 
            this.iconButton1.BackColor = System.Drawing.Color.Chartreuse;
            this.iconButton1.FlatAppearance.BorderColor = System.Drawing.Color.Black;
            this.iconButton1.FlatStyle = System.Windows.Forms.FlatStyle.Flat;
            this.iconButton1.ForeColor = System.Drawing.Color.White;
            this.iconButton1.IconChar = FontAwesome.Sharp.IconChar.ExternalLinkSquareAlt;
            this.iconButton1.IconColor = System.Drawing.Color.White;
            this.iconButton1.IconFont = FontAwesome.Sharp.IconFont.Auto;
            this.iconButton1.IconSize = 20;
            this.iconButton1.Location = new System.Drawing.Point(43, 247);
            this.iconButton1.Name = "iconButton1";
            this.iconButton1.Size = new System.Drawing.Size(168, 23);
            this.iconButton1.TabIndex = 132;
            this.iconButton1.Text = "Agregar";
            this.iconButton1.TextAlign = System.Drawing.ContentAlignment.MiddleRight;
            this.iconButton1.TextImageRelation = System.Windows.Forms.TextImageRelation.ImageBeforeText;
            this.iconButton1.UseVisualStyleBackColor = false;
            this.iconButton1.Click += new System.EventHandler(this.iconButton1_Click);
            // 
            // label2
            // 
            this.label2.AutoSize = true;
            this.label2.BackColor = System.Drawing.Color.White;
            this.label2.Location = new System.Drawing.Point(10, 26);
            this.label2.Name = "label2";
            this.label2.Size = new System.Drawing.Size(44, 13);
            this.label2.TabIndex = 131;
            this.label2.Text = "Nombre";
            // 
            // label1
            // 
            this.label1.BackColor = System.Drawing.Color.White;
            this.label1.Dock = System.Windows.Forms.DockStyle.Left;
            this.label1.Location = new System.Drawing.Point(0, 0);
            this.label1.Name = "label1";
            this.label1.Size = new System.Drawing.Size(267, 450);
            this.label1.TabIndex = 130;
            // 
            // cbohabitacion
            // 
            this.cbohabitacion.DropDownStyle = System.Windows.Forms.ComboBoxStyle.DropDownList;
            this.cbohabitacion.FormattingEnabled = true;
            this.cbohabitacion.Location = new System.Drawing.Point(143, 202);
            this.cbohabitacion.Name = "cbohabitacion";
            this.cbohabitacion.Size = new System.Drawing.Size(110, 21);
            this.cbohabitacion.TabIndex = 169;
            // 
            // label4
            // 
            this.label4.AutoSize = true;
            this.label4.BackColor = System.Drawing.Color.White;
            this.label4.Location = new System.Drawing.Point(140, 185);
            this.label4.Name = "label4";
            this.label4.Size = new System.Drawing.Size(95, 13);
            this.label4.TabIndex = 170;
            this.label4.Text = "Tipo de habitacion";
            // 
            // txtPersona
            // 
            this.txtPersona.DecimalPlaces = 2;
            this.txtPersona.Increment = new decimal(new int[] {
            5,
            0,
            0,
            0});
            this.txtPersona.Location = new System.Drawing.Point(13, 163);
            this.txtPersona.Maximum = new decimal(new int[] {
            1000,
            0,
            0,
            0});
            this.txtPersona.Name = "txtPersona";
            this.txtPersona.Size = new System.Drawing.Size(236, 20);
            this.txtPersona.TabIndex = 171;
            this.txtPersona.Value = new decimal(new int[] {
            1,
            0,
            0,
            0});
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
            this.Nom_Hab,
            this.Desc_Hab,
            this.Costo,
            this.Estado,
            this.EstadoHab,
            this.Cam_Hab,
            this.Tipo,
            this.Tipo_Hab,
            this.Fecha});
            this.dataUser.Location = new System.Drawing.Point(273, 42);
            this.dataUser.MultiSelect = false;
            this.dataUser.Name = "dataUser";
            this.dataUser.ReadOnly = true;
            dataGridViewCellStyle6.SelectionBackColor = System.Drawing.Color.White;
            dataGridViewCellStyle6.SelectionForeColor = System.Drawing.Color.Black;
            this.dataUser.RowsDefaultCellStyle = dataGridViewCellStyle6;
            this.dataUser.RowTemplate.Height = 25;
            this.dataUser.Size = new System.Drawing.Size(737, 389);
            this.dataUser.TabIndex = 185;
            this.dataUser.CellContentClick += new System.Windows.Forms.DataGridViewCellEventHandler(this.dataUser_CellContentClick);
            // 
            // btnseleccionar
            // 
            this.btnseleccionar.HeaderText = "";
            this.btnseleccionar.Name = "btnseleccionar";
            this.btnseleccionar.ReadOnly = true;
            this.btnseleccionar.Width = 30;
            // 
            // Nom_Hab
            // 
            this.Nom_Hab.HeaderText = "Nombre habitacion";
            this.Nom_Hab.Name = "Nom_Hab";
            this.Nom_Hab.ReadOnly = true;
            this.Nom_Hab.Width = 120;
            // 
            // Desc_Hab
            // 
            this.Desc_Hab.HeaderText = "Descripcion habitacion";
            this.Desc_Hab.Name = "Desc_Hab";
            this.Desc_Hab.ReadOnly = true;
            this.Desc_Hab.Width = 300;
            // 
            // Costo
            // 
            this.Costo.HeaderText = "Costo persona";
            this.Costo.Name = "Costo";
            this.Costo.ReadOnly = true;
            // 
            // Estado
            // 
            this.Estado.HeaderText = "Estado";
            this.Estado.Name = "Estado";
            this.Estado.ReadOnly = true;
            this.Estado.Visible = false;
            this.Estado.Width = 80;
            // 
            // EstadoHab
            // 
            this.EstadoHab.HeaderText = "Estado habitacion";
            this.EstadoHab.Name = "EstadoHab";
            this.EstadoHab.ReadOnly = true;
            this.EstadoHab.Width = 70;
            // 
            // Cam_Hab
            // 
            this.Cam_Hab.HeaderText = "Numero camas";
            this.Cam_Hab.Name = "Cam_Hab";
            this.Cam_Hab.ReadOnly = true;
            this.Cam_Hab.Width = 60;
            // 
            // Tipo
            // 
            this.Tipo.HeaderText = "Tipo";
            this.Tipo.Name = "Tipo";
            this.Tipo.ReadOnly = true;
            this.Tipo.Visible = false;
            this.Tipo.Width = 50;
            // 
            // Tipo_Hab
            // 
            this.Tipo_Hab.HeaderText = "Tipo Habitacion";
            this.Tipo_Hab.Name = "Tipo_Hab";
            this.Tipo_Hab.ReadOnly = true;
            // 
            // Fecha
            // 
            this.Fecha.HeaderText = "Fecha registro";
            this.Fecha.Name = "Fecha";
            this.Fecha.ReadOnly = true;
            // 
            // iconButton2
            // 
            this.iconButton2.BackColor = System.Drawing.Color.DarkOrange;
            this.iconButton2.FlatAppearance.BorderColor = System.Drawing.Color.Black;
            this.iconButton2.FlatStyle = System.Windows.Forms.FlatStyle.Flat;
            this.iconButton2.ForeColor = System.Drawing.Color.White;
            this.iconButton2.IconChar = FontAwesome.Sharp.IconChar.ArrowLeft;
            this.iconButton2.IconColor = System.Drawing.Color.White;
            this.iconButton2.IconFont = FontAwesome.Sharp.IconFont.Auto;
            this.iconButton2.IconSize = 20;
            this.iconButton2.Location = new System.Drawing.Point(43, 272);
            this.iconButton2.Name = "iconButton2";
            this.iconButton2.Size = new System.Drawing.Size(168, 23);
            this.iconButton2.TabIndex = 186;
            this.iconButton2.Text = "Actualizar";
            this.iconButton2.TextAlign = System.Drawing.ContentAlignment.MiddleRight;
            this.iconButton2.TextImageRelation = System.Windows.Forms.TextImageRelation.ImageBeforeText;
            this.iconButton2.UseVisualStyleBackColor = false;
            this.iconButton2.Click += new System.EventHandler(this.iconButton2_Click);
            // 
            // frmHabitacion
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(6F, 13F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.BackColor = System.Drawing.Color.SteelBlue;
            this.ClientSize = new System.Drawing.Size(1036, 450);
            this.Controls.Add(this.iconButton2);
            this.Controls.Add(this.dataUser);
            this.Controls.Add(this.txtPersona);
            this.Controls.Add(this.label4);
            this.Controls.Add(this.cbohabitacion);
            this.Controls.Add(this.label16);
            this.Controls.Add(this.btnLimpiar);
            this.Controls.Add(this.txtPR);
            this.Controls.Add(this.label9);
            this.Controls.Add(this.cboestado);
            this.Controls.Add(this.btnLimpiarBuscador);
            this.Controls.Add(this.btnBuscar);
            this.Controls.Add(this.txtBuscar);
            this.Controls.Add(this.cboBuscar);
            this.Controls.Add(this.label15);
            this.Controls.Add(this.txtindice);
            this.Controls.Add(this.textId);
            this.Controls.Add(this.label11);
            this.Controls.Add(this.label8);
            this.Controls.Add(this.label3);
            this.Controls.Add(this.txtDescripcion);
            this.Controls.Add(this.textNombre);
            this.Controls.Add(this.label10);
            this.Controls.Add(this.iconButton3);
            this.Controls.Add(this.iconButton1);
            this.Controls.Add(this.label2);
            this.Controls.Add(this.label1);
            this.Name = "frmHabitacion";
            this.Text = "frmHabitacion";
            this.Load += new System.EventHandler(this.frmHabitacion_Load);
            ((System.ComponentModel.ISupportInitialize)(this.txtPR)).EndInit();
            ((System.ComponentModel.ISupportInitialize)(this.txtPersona)).EndInit();
            ((System.ComponentModel.ISupportInitialize)(this.dataUser)).EndInit();
            this.ResumeLayout(false);
            this.PerformLayout();

        }

        #endregion
        private System.Windows.Forms.Label label16;
        private FontAwesome.Sharp.IconButton btnLimpiar;
        private System.Windows.Forms.NumericUpDown txtPR;
        private System.Windows.Forms.Label label9;
        private System.Windows.Forms.ComboBox cboestado;
        private FontAwesome.Sharp.IconButton btnLimpiarBuscador;
        private FontAwesome.Sharp.IconButton btnBuscar;
        private System.Windows.Forms.TextBox txtBuscar;
        private System.Windows.Forms.ComboBox cboBuscar;
        private System.Windows.Forms.Label label15;
        private System.Windows.Forms.TextBox txtindice;
        private System.Windows.Forms.TextBox textId;
        private System.Windows.Forms.Label label11;
        private System.Windows.Forms.Label label8;
        private System.Windows.Forms.Label label3;
        private System.Windows.Forms.TextBox txtDescripcion;
        private System.Windows.Forms.TextBox textNombre;
        private System.Windows.Forms.Label label10;
        private FontAwesome.Sharp.IconButton iconButton3;
        private FontAwesome.Sharp.IconButton iconButton1;
        private System.Windows.Forms.Label label2;
        private System.Windows.Forms.Label label1;
        private System.Windows.Forms.ComboBox cbohabitacion;
        private System.Windows.Forms.Label label4;
        private System.Windows.Forms.NumericUpDown txtPersona;
        private System.Windows.Forms.DataGridView dataUser;
        private System.Windows.Forms.DataGridViewButtonColumn btnseleccionar;
        private System.Windows.Forms.DataGridViewTextBoxColumn Nom_Hab;
        private System.Windows.Forms.DataGridViewTextBoxColumn Desc_Hab;
        private System.Windows.Forms.DataGridViewTextBoxColumn Costo;
        private System.Windows.Forms.DataGridViewTextBoxColumn Estado;
        private System.Windows.Forms.DataGridViewTextBoxColumn EstadoHab;
        private System.Windows.Forms.DataGridViewTextBoxColumn Cam_Hab;
        private System.Windows.Forms.DataGridViewTextBoxColumn Tipo;
        private System.Windows.Forms.DataGridViewTextBoxColumn Tipo_Hab;
        private System.Windows.Forms.DataGridViewTextBoxColumn Fecha;
        private FontAwesome.Sharp.IconButton iconButton2;
    }
}