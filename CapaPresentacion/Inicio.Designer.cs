
namespace CapaPresentacion
{
    partial class Inicio
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
            this.menutitulo = new System.Windows.Forms.MenuStrip();
            this.label1 = new System.Windows.Forms.Label();
            this.contenedor = new System.Windows.Forms.Panel();
            this.iconMenuItem6 = new FontAwesome.Sharp.IconMenuItem();
            this.iconMenuItem3 = new FontAwesome.Sharp.IconMenuItem();
            this.iconMenuItem1 = new FontAwesome.Sharp.IconMenuItem();
            this.menu = new System.Windows.Forms.MenuStrip();
            this.iconMenuItem2 = new FontAwesome.Sharp.IconMenuItem();
            this.iconMenuItem4 = new FontAwesome.Sharp.IconMenuItem();
            this.iconMenuItem5 = new FontAwesome.Sharp.IconMenuItem();
            this.iconMenuItem7 = new FontAwesome.Sharp.IconMenuItem();
            this.iconMenuItem8 = new FontAwesome.Sharp.IconMenuItem();
            this.menu.SuspendLayout();
            this.SuspendLayout();
            // 
            // menutitulo
            // 
            this.menutitulo.AutoSize = false;
            this.menutitulo.BackColor = System.Drawing.Color.SteelBlue;
            this.menutitulo.Location = new System.Drawing.Point(0, 0);
            this.menutitulo.Name = "menutitulo";
            this.menutitulo.RightToLeft = System.Windows.Forms.RightToLeft.Yes;
            this.menutitulo.Size = new System.Drawing.Size(978, 71);
            this.menutitulo.TabIndex = 1;
            this.menutitulo.Text = "menuStrip2";
            // 
            // label1
            // 
            this.label1.AutoSize = true;
            this.label1.BackColor = System.Drawing.Color.SteelBlue;
            this.label1.Font = new System.Drawing.Font("Microsoft Sans Serif", 17F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.label1.ForeColor = System.Drawing.Color.FloralWhite;
            this.label1.Location = new System.Drawing.Point(12, 20);
            this.label1.Name = "label1";
            this.label1.Size = new System.Drawing.Size(242, 29);
            this.label1.TabIndex = 3;
            this.label1.Text = "Bienvenido a NTEAN";
            // 
            // contenedor
            // 
            this.contenedor.Dock = System.Windows.Forms.DockStyle.Fill;
            this.contenedor.Location = new System.Drawing.Point(0, 144);
            this.contenedor.Name = "contenedor";
            this.contenedor.Size = new System.Drawing.Size(978, 420);
            this.contenedor.TabIndex = 12;
            // 
            // iconMenuItem6
            // 
            this.iconMenuItem6.AutoSize = false;
            this.iconMenuItem6.IconChar = FontAwesome.Sharp.IconChar.Users;
            this.iconMenuItem6.IconColor = System.Drawing.Color.Black;
            this.iconMenuItem6.IconFont = FontAwesome.Sharp.IconFont.Auto;
            this.iconMenuItem6.IconSize = 50;
            this.iconMenuItem6.ImageScaling = System.Windows.Forms.ToolStripItemImageScaling.None;
            this.iconMenuItem6.Name = "iconMenuItem6";
            this.iconMenuItem6.Size = new System.Drawing.Size(64, 69);
            this.iconMenuItem6.Text = "Usuarios";
            this.iconMenuItem6.TextImageRelation = System.Windows.Forms.TextImageRelation.TextAboveImage;
            this.iconMenuItem6.Click += new System.EventHandler(this.iconMenuItem6_Click);
            // 
            // iconMenuItem3
            // 
            this.iconMenuItem3.AutoSize = false;
            this.iconMenuItem3.IconChar = FontAwesome.Sharp.IconChar.HouseFlag;
            this.iconMenuItem3.IconColor = System.Drawing.Color.Black;
            this.iconMenuItem3.IconFont = FontAwesome.Sharp.IconFont.Auto;
            this.iconMenuItem3.IconSize = 50;
            this.iconMenuItem3.ImageScaling = System.Windows.Forms.ToolStripItemImageScaling.None;
            this.iconMenuItem3.Name = "iconMenuItem3";
            this.iconMenuItem3.Size = new System.Drawing.Size(80, 69);
            this.iconMenuItem3.Text = "Reservacion";
            this.iconMenuItem3.TextImageRelation = System.Windows.Forms.TextImageRelation.TextAboveImage;
            this.iconMenuItem3.Click += new System.EventHandler(this.iconMenuItem3_Click);
            // 
            // iconMenuItem1
            // 
            this.iconMenuItem1.AutoSize = false;
            this.iconMenuItem1.IconChar = FontAwesome.Sharp.IconChar.Pager;
            this.iconMenuItem1.IconColor = System.Drawing.Color.Black;
            this.iconMenuItem1.IconFont = FontAwesome.Sharp.IconFont.Auto;
            this.iconMenuItem1.IconSize = 50;
            this.iconMenuItem1.ImageScaling = System.Windows.Forms.ToolStripItemImageScaling.None;
            this.iconMenuItem1.Name = "iconMenuItem1";
            this.iconMenuItem1.Size = new System.Drawing.Size(80, 69);
            this.iconMenuItem1.Text = "Reportes";
            this.iconMenuItem1.TextImageRelation = System.Windows.Forms.TextImageRelation.TextAboveImage;
            this.iconMenuItem1.Click += new System.EventHandler(this.iconMenuItem1_Click);
            // 
            // menu
            // 
            this.menu.Items.AddRange(new System.Windows.Forms.ToolStripItem[] {
            this.iconMenuItem6,
            this.iconMenuItem2,
            this.iconMenuItem7,
            this.iconMenuItem3,
            this.iconMenuItem1,
            this.iconMenuItem8});
            this.menu.Location = new System.Drawing.Point(0, 71);
            this.menu.Name = "menu";
            this.menu.Size = new System.Drawing.Size(978, 73);
            this.menu.TabIndex = 0;
            this.menu.Text = "menuStrip1";
            // 
            // iconMenuItem2
            // 
            this.iconMenuItem2.AutoSize = false;
            this.iconMenuItem2.DropDownItems.AddRange(new System.Windows.Forms.ToolStripItem[] {
            this.iconMenuItem4,
            this.iconMenuItem5});
            this.iconMenuItem2.IconChar = FontAwesome.Sharp.IconChar.User;
            this.iconMenuItem2.IconColor = System.Drawing.Color.Black;
            this.iconMenuItem2.IconFont = FontAwesome.Sharp.IconFont.Auto;
            this.iconMenuItem2.IconSize = 50;
            this.iconMenuItem2.ImageScaling = System.Windows.Forms.ToolStripItemImageScaling.None;
            this.iconMenuItem2.Name = "iconMenuItem2";
            this.iconMenuItem2.Size = new System.Drawing.Size(80, 69);
            this.iconMenuItem2.Text = "Admin";
            this.iconMenuItem2.TextImageRelation = System.Windows.Forms.TextImageRelation.TextAboveImage;
            // 
            // iconMenuItem4
            // 
            this.iconMenuItem4.IconChar = FontAwesome.Sharp.IconChar.None;
            this.iconMenuItem4.IconColor = System.Drawing.Color.Black;
            this.iconMenuItem4.IconFont = FontAwesome.Sharp.IconFont.Auto;
            this.iconMenuItem4.Name = "iconMenuItem4";
            this.iconMenuItem4.Size = new System.Drawing.Size(132, 22);
            this.iconMenuItem4.Text = "Hotel";
            this.iconMenuItem4.Click += new System.EventHandler(this.iconMenuItem4_Click);
            // 
            // iconMenuItem5
            // 
            this.iconMenuItem5.IconChar = FontAwesome.Sharp.IconChar.None;
            this.iconMenuItem5.IconColor = System.Drawing.Color.Black;
            this.iconMenuItem5.IconFont = FontAwesome.Sharp.IconFont.Auto;
            this.iconMenuItem5.Name = "iconMenuItem5";
            this.iconMenuItem5.Size = new System.Drawing.Size(132, 22);
            this.iconMenuItem5.Text = "Habitacion";
            this.iconMenuItem5.Click += new System.EventHandler(this.iconMenuItem5_Click);
            // 
            // iconMenuItem7
            // 
            this.iconMenuItem7.AutoSize = false;
            this.iconMenuItem7.IconChar = FontAwesome.Sharp.IconChar.Key;
            this.iconMenuItem7.IconColor = System.Drawing.Color.Black;
            this.iconMenuItem7.IconFont = FontAwesome.Sharp.IconFont.Auto;
            this.iconMenuItem7.IconSize = 50;
            this.iconMenuItem7.ImageScaling = System.Windows.Forms.ToolStripItemImageScaling.None;
            this.iconMenuItem7.Name = "iconMenuItem7";
            this.iconMenuItem7.Size = new System.Drawing.Size(80, 69);
            this.iconMenuItem7.Text = "Servicios";
            this.iconMenuItem7.TextImageRelation = System.Windows.Forms.TextImageRelation.TextAboveImage;
            this.iconMenuItem7.Click += new System.EventHandler(this.iconMenuItem7_Click);
            // 
            // iconMenuItem8
            // 
            this.iconMenuItem8.AutoSize = false;
            this.iconMenuItem8.IconChar = FontAwesome.Sharp.IconChar.Paperclip;
            this.iconMenuItem8.IconColor = System.Drawing.Color.Black;
            this.iconMenuItem8.IconFont = FontAwesome.Sharp.IconFont.Auto;
            this.iconMenuItem8.IconSize = 50;
            this.iconMenuItem8.ImageScaling = System.Windows.Forms.ToolStripItemImageScaling.None;
            this.iconMenuItem8.Name = "iconMenuItem8";
            this.iconMenuItem8.Size = new System.Drawing.Size(80, 69);
            this.iconMenuItem8.Text = "Factura";
            this.iconMenuItem8.TextImageRelation = System.Windows.Forms.TextImageRelation.TextAboveImage;
            this.iconMenuItem8.Click += new System.EventHandler(this.iconMenuItem8_Click);
            // 
            // Inicio
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(6F, 13F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.ClientSize = new System.Drawing.Size(978, 564);
            this.Controls.Add(this.contenedor);
            this.Controls.Add(this.label1);
            this.Controls.Add(this.menu);
            this.Controls.Add(this.menutitulo);
            this.Name = "Inicio";
            this.Text = "Inicio";
            this.WindowState = System.Windows.Forms.FormWindowState.Maximized;
            this.Load += new System.EventHandler(this.Inicio_Load);
            this.menu.ResumeLayout(false);
            this.menu.PerformLayout();
            this.ResumeLayout(false);
            this.PerformLayout();

        }

        #endregion
        private System.Windows.Forms.MenuStrip menutitulo;
        private System.Windows.Forms.Label label1;
        private System.Windows.Forms.Panel contenedor;
        private FontAwesome.Sharp.IconMenuItem iconMenuItem6;
        private FontAwesome.Sharp.IconMenuItem iconMenuItem3;
        private FontAwesome.Sharp.IconMenuItem iconMenuItem1;
        private System.Windows.Forms.MenuStrip menu;
        private FontAwesome.Sharp.IconMenuItem iconMenuItem2;
        private FontAwesome.Sharp.IconMenuItem iconMenuItem4;
        private FontAwesome.Sharp.IconMenuItem iconMenuItem5;
        private FontAwesome.Sharp.IconMenuItem iconMenuItem7;
        private FontAwesome.Sharp.IconMenuItem iconMenuItem8;
    }
}