namespace Administrador_de_Tareas
{
    partial class VerEditarEliminarTeam
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
            this.labelNombre = new System.Windows.Forms.Label();
            this.labelDescri = new System.Windows.Forms.Label();
            this.labelMiembros = new System.Windows.Forms.Label();
            this.listBoxAparecenMiembrosTeam = new System.Windows.Forms.ListBox();
            this.buttonSacarMiembro = new System.Windows.Forms.Button();
            this.labelUsuarios = new System.Windows.Forms.Label();
            this.buttonAgregarMiembroALista = new System.Windows.Forms.Button();
            this.buttonGuardarCambiosTeam = new System.Windows.Forms.Button();
            this.buttonDeleteTeam = new System.Windows.Forms.Button();
            this.labelTablerosDelTeam = new System.Windows.Forms.Label();
            this.dgvTablerosDelEquipo = new System.Windows.Forms.DataGridView();
            this.listBoxAllUsers = new System.Windows.Forms.ListBox();
            this.linkLabel1 = new System.Windows.Forms.LinkLabel();
            this.textBoxNombre = new System.Windows.Forms.TextBox();
            this.textBoxDescripcion = new System.Windows.Forms.TextBox();
            this.labelUserLog = new System.Windows.Forms.Label();
            ((System.ComponentModel.ISupportInitialize)(this.dgvTablerosDelEquipo)).BeginInit();
            this.SuspendLayout();
            // 
            // labelNombre
            // 
            this.labelNombre.AutoSize = true;
            this.labelNombre.Location = new System.Drawing.Point(44, 24);
            this.labelNombre.Name = "labelNombre";
            this.labelNombre.Size = new System.Drawing.Size(47, 13);
            this.labelNombre.TabIndex = 0;
            this.labelNombre.Text = "Nombre:";
            // 
            // labelDescri
            // 
            this.labelDescri.AutoSize = true;
            this.labelDescri.Location = new System.Drawing.Point(44, 76);
            this.labelDescri.Name = "labelDescri";
            this.labelDescri.Size = new System.Drawing.Size(66, 13);
            this.labelDescri.TabIndex = 2;
            this.labelDescri.Text = "Descripcion:";
            // 
            // labelMiembros
            // 
            this.labelMiembros.AutoSize = true;
            this.labelMiembros.Location = new System.Drawing.Point(44, 265);
            this.labelMiembros.Name = "labelMiembros";
            this.labelMiembros.Size = new System.Drawing.Size(55, 13);
            this.labelMiembros.TabIndex = 4;
            this.labelMiembros.Text = "Miembros:";
            // 
            // listBoxAparecenMiembrosTeam
            // 
            this.listBoxAparecenMiembrosTeam.FormattingEnabled = true;
            this.listBoxAparecenMiembrosTeam.Location = new System.Drawing.Point(45, 281);
            this.listBoxAparecenMiembrosTeam.Name = "listBoxAparecenMiembrosTeam";
            this.listBoxAparecenMiembrosTeam.Size = new System.Drawing.Size(158, 147);
            this.listBoxAparecenMiembrosTeam.TabIndex = 5;
            // 
            // buttonSacarMiembro
            // 
            this.buttonSacarMiembro.Location = new System.Drawing.Point(207, 324);
            this.buttonSacarMiembro.Name = "buttonSacarMiembro";
            this.buttonSacarMiembro.Size = new System.Drawing.Size(33, 23);
            this.buttonSacarMiembro.TabIndex = 6;
            this.buttonSacarMiembro.Text = "->";
            this.buttonSacarMiembro.UseVisualStyleBackColor = true;
            this.buttonSacarMiembro.Click += new System.EventHandler(this.buttonSacarMiembro_Click);
            // 
            // labelUsuarios
            // 
            this.labelUsuarios.AutoSize = true;
            this.labelUsuarios.Location = new System.Drawing.Point(243, 265);
            this.labelUsuarios.Name = "labelUsuarios";
            this.labelUsuarios.Size = new System.Drawing.Size(51, 13);
            this.labelUsuarios.TabIndex = 7;
            this.labelUsuarios.Text = "Usuarios:";
            // 
            // buttonAgregarMiembroALista
            // 
            this.buttonAgregarMiembroALista.Location = new System.Drawing.Point(207, 353);
            this.buttonAgregarMiembroALista.Name = "buttonAgregarMiembroALista";
            this.buttonAgregarMiembroALista.Size = new System.Drawing.Size(33, 23);
            this.buttonAgregarMiembroALista.TabIndex = 9;
            this.buttonAgregarMiembroALista.Text = "<-";
            this.buttonAgregarMiembroALista.UseVisualStyleBackColor = true;
            this.buttonAgregarMiembroALista.Click += new System.EventHandler(this.buttonAgregarMiembroALista_Click);
            // 
            // buttonGuardarCambiosTeam
            // 
            this.buttonGuardarCambiosTeam.Location = new System.Drawing.Point(45, 434);
            this.buttonGuardarCambiosTeam.Name = "buttonGuardarCambiosTeam";
            this.buttonGuardarCambiosTeam.Size = new System.Drawing.Size(75, 39);
            this.buttonGuardarCambiosTeam.TabIndex = 10;
            this.buttonGuardarCambiosTeam.Text = "Guardar Cambios";
            this.buttonGuardarCambiosTeam.UseVisualStyleBackColor = true;
            this.buttonGuardarCambiosTeam.Click += new System.EventHandler(this.buttonGuardarCambiosTeam_Click);
            // 
            // buttonDeleteTeam
            // 
            this.buttonDeleteTeam.Location = new System.Drawing.Point(126, 434);
            this.buttonDeleteTeam.Name = "buttonDeleteTeam";
            this.buttonDeleteTeam.Size = new System.Drawing.Size(75, 39);
            this.buttonDeleteTeam.TabIndex = 11;
            this.buttonDeleteTeam.Text = "Eliminar Equipo";
            this.buttonDeleteTeam.UseVisualStyleBackColor = true;
            this.buttonDeleteTeam.Visible = false;
            this.buttonDeleteTeam.Click += new System.EventHandler(this.buttonDeleteTeam_Click);
            // 
            // labelTablerosDelTeam
            // 
            this.labelTablerosDelTeam.AutoSize = true;
            this.labelTablerosDelTeam.Location = new System.Drawing.Point(44, 136);
            this.labelTablerosDelTeam.Name = "labelTablerosDelTeam";
            this.labelTablerosDelTeam.Size = new System.Drawing.Size(101, 13);
            this.labelTablerosDelTeam.TabIndex = 14;
            this.labelTablerosDelTeam.Text = "Tableros del Equipo";
            // 
            // dgvTablerosDelEquipo
            // 
            this.dgvTablerosDelEquipo.BackgroundColor = System.Drawing.SystemColors.Window;
            this.dgvTablerosDelEquipo.ColumnHeadersHeightSizeMode = System.Windows.Forms.DataGridViewColumnHeadersHeightSizeMode.AutoSize;
            this.dgvTablerosDelEquipo.Location = new System.Drawing.Point(45, 152);
            this.dgvTablerosDelEquipo.Name = "dgvTablerosDelEquipo";
            this.dgvTablerosDelEquipo.Size = new System.Drawing.Size(159, 97);
            this.dgvTablerosDelEquipo.TabIndex = 15;
            // 
            // listBoxAllUsers
            // 
            this.listBoxAllUsers.FormattingEnabled = true;
            this.listBoxAllUsers.Location = new System.Drawing.Point(246, 281);
            this.listBoxAllUsers.Name = "listBoxAllUsers";
            this.listBoxAllUsers.Size = new System.Drawing.Size(158, 147);
            this.listBoxAllUsers.TabIndex = 16;
            // 
            // linkLabel1
            // 
            this.linkLabel1.AutoSize = true;
            this.linkLabel1.Location = new System.Drawing.Point(12, 265);
            this.linkLabel1.Name = "linkLabel1";
            this.linkLabel1.Size = new System.Drawing.Size(34, 13);
            this.linkLabel1.TabIndex = 17;
            this.linkLabel1.TabStop = true;
            this.linkLabel1.Text = "Editar";
            this.linkLabel1.LinkClicked += new System.Windows.Forms.LinkLabelLinkClickedEventHandler(this.linkLabel1_LinkClicked_1);
            // 
            // textBoxNombre
            // 
            this.textBoxNombre.Location = new System.Drawing.Point(45, 40);
            this.textBoxNombre.Name = "textBoxNombre";
            this.textBoxNombre.Size = new System.Drawing.Size(359, 20);
            this.textBoxNombre.TabIndex = 18;
            // 
            // textBoxDescripcion
            // 
            this.textBoxDescripcion.Location = new System.Drawing.Point(47, 92);
            this.textBoxDescripcion.Name = "textBoxDescripcion";
            this.textBoxDescripcion.Size = new System.Drawing.Size(357, 20);
            this.textBoxDescripcion.TabIndex = 19;
            // 
            // labelUserLog
            // 
            this.labelUserLog.AutoSize = true;
            this.labelUserLog.Location = new System.Drawing.Point(105, 265);
            this.labelUserLog.Name = "labelUserLog";
            this.labelUserLog.Size = new System.Drawing.Size(35, 13);
            this.labelUserLog.TabIndex = 20;
            this.labelUserLog.Text = "label1";
            // 
            // VerEditarEliminarTeam
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(6F, 13F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.AutoSizeMode = System.Windows.Forms.AutoSizeMode.GrowAndShrink;
            this.BackColor = System.Drawing.SystemColors.ActiveCaption;
            this.ClientSize = new System.Drawing.Size(434, 483);
            this.Controls.Add(this.labelUserLog);
            this.Controls.Add(this.textBoxDescripcion);
            this.Controls.Add(this.textBoxNombre);
            this.Controls.Add(this.linkLabel1);
            this.Controls.Add(this.listBoxAllUsers);
            this.Controls.Add(this.dgvTablerosDelEquipo);
            this.Controls.Add(this.labelTablerosDelTeam);
            this.Controls.Add(this.buttonDeleteTeam);
            this.Controls.Add(this.buttonGuardarCambiosTeam);
            this.Controls.Add(this.buttonAgregarMiembroALista);
            this.Controls.Add(this.labelUsuarios);
            this.Controls.Add(this.buttonSacarMiembro);
            this.Controls.Add(this.listBoxAparecenMiembrosTeam);
            this.Controls.Add(this.labelMiembros);
            this.Controls.Add(this.labelDescri);
            this.Controls.Add(this.labelNombre);
            this.MaximizeBox = false;
            this.MinimizeBox = false;
            this.Name = "VerEditarEliminarTeam";
            this.ShowIcon = false;
            this.StartPosition = System.Windows.Forms.FormStartPosition.CenterScreen;
            this.Text = "Equipo";
            this.Load += new System.EventHandler(this.VerEditarEliminarTeam_Load);
            ((System.ComponentModel.ISupportInitialize)(this.dgvTablerosDelEquipo)).EndInit();
            this.ResumeLayout(false);
            this.PerformLayout();

        }

        #endregion

        private System.Windows.Forms.Label labelNombre;
        private System.Windows.Forms.Label labelDescri;
        private System.Windows.Forms.Label labelMiembros;
        private System.Windows.Forms.ListBox listBoxAparecenMiembrosTeam;
        private System.Windows.Forms.Button buttonSacarMiembro;
        private System.Windows.Forms.Label labelUsuarios;
        private System.Windows.Forms.Button buttonAgregarMiembroALista;
        private System.Windows.Forms.Button buttonGuardarCambiosTeam;
        private System.Windows.Forms.Button buttonDeleteTeam;
        private System.Windows.Forms.Label labelTablerosDelTeam;
        private System.Windows.Forms.DataGridView dgvTablerosDelEquipo;
        private System.Windows.Forms.ListBox listBoxAllUsers;
        private System.Windows.Forms.LinkLabel linkLabel1;
        private System.Windows.Forms.TextBox textBoxNombre;
        private System.Windows.Forms.TextBox textBoxDescripcion;
        private System.Windows.Forms.Label labelUserLog;
    }
}