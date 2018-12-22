namespace Administrador_de_Tareas
{
    partial class CrearEquipo
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
            this.textBoxName = new System.Windows.Forms.TextBox();
            this.labelNombreEquipo = new System.Windows.Forms.Label();
            this.labelDescripTeam = new System.Windows.Forms.Label();
            this.textBoxDescrip = new System.Windows.Forms.TextBox();
            this.buttonCrearTeam = new System.Windows.Forms.Button();
            this.listBoxConMiembrosNewTeam = new System.Windows.Forms.ListBox();
            this.labelMiembros = new System.Windows.Forms.Label();
            this.buttonAddMiembroAListaParaCrearTeam = new System.Windows.Forms.Button();
            this.buttonQuitarMiembroDeListaParaNewTeam = new System.Windows.Forms.Button();
            this.listBoxAllUsers = new System.Windows.Forms.ListBox();
            this.label1 = new System.Windows.Forms.Label();
            this.SuspendLayout();
            // 
            // textBoxName
            // 
            this.textBoxName.Location = new System.Drawing.Point(62, 27);
            this.textBoxName.Name = "textBoxName";
            this.textBoxName.Size = new System.Drawing.Size(163, 20);
            this.textBoxName.TabIndex = 0;
            // 
            // labelNombreEquipo
            // 
            this.labelNombreEquipo.AutoSize = true;
            this.labelNombreEquipo.Location = new System.Drawing.Point(12, 30);
            this.labelNombreEquipo.Name = "labelNombreEquipo";
            this.labelNombreEquipo.Size = new System.Drawing.Size(44, 13);
            this.labelNombreEquipo.TabIndex = 1;
            this.labelNombreEquipo.Text = "Nombre";
            // 
            // labelDescripTeam
            // 
            this.labelDescripTeam.AutoSize = true;
            this.labelDescripTeam.Location = new System.Drawing.Point(12, 60);
            this.labelDescripTeam.Name = "labelDescripTeam";
            this.labelDescripTeam.Size = new System.Drawing.Size(63, 13);
            this.labelDescripTeam.TabIndex = 2;
            this.labelDescripTeam.Text = "Descripcion";
            // 
            // textBoxDescrip
            // 
            this.textBoxDescrip.Location = new System.Drawing.Point(15, 76);
            this.textBoxDescrip.Name = "textBoxDescrip";
            this.textBoxDescrip.Size = new System.Drawing.Size(356, 20);
            this.textBoxDescrip.TabIndex = 3;
            // 
            // buttonCrearTeam
            // 
            this.buttonCrearTeam.Location = new System.Drawing.Point(286, 258);
            this.buttonCrearTeam.Name = "buttonCrearTeam";
            this.buttonCrearTeam.Size = new System.Drawing.Size(85, 24);
            this.buttonCrearTeam.TabIndex = 4;
            this.buttonCrearTeam.Text = "Crear";
            this.buttonCrearTeam.UseVisualStyleBackColor = true;
            this.buttonCrearTeam.Click += new System.EventHandler(this.buttonCrearTeam_Click);
            // 
            // listBoxConMiembrosNewTeam
            // 
            this.listBoxConMiembrosNewTeam.FormattingEnabled = true;
            this.listBoxConMiembrosNewTeam.Location = new System.Drawing.Point(214, 131);
            this.listBoxConMiembrosNewTeam.Name = "listBoxConMiembrosNewTeam";
            this.listBoxConMiembrosNewTeam.Size = new System.Drawing.Size(158, 121);
            this.listBoxConMiembrosNewTeam.TabIndex = 5;
            // 
            // labelMiembros
            // 
            this.labelMiembros.AutoSize = true;
            this.labelMiembros.Location = new System.Drawing.Point(211, 115);
            this.labelMiembros.Name = "labelMiembros";
            this.labelMiembros.Size = new System.Drawing.Size(104, 13);
            this.labelMiembros.TabIndex = 7;
            this.labelMiembros.Text = "Miembros del equipo";
            // 
            // buttonAddMiembroAListaParaCrearTeam
            // 
            this.buttonAddMiembroAListaParaCrearTeam.Location = new System.Drawing.Point(179, 174);
            this.buttonAddMiembroAListaParaCrearTeam.Name = "buttonAddMiembroAListaParaCrearTeam";
            this.buttonAddMiembroAListaParaCrearTeam.Size = new System.Drawing.Size(29, 23);
            this.buttonAddMiembroAListaParaCrearTeam.TabIndex = 8;
            this.buttonAddMiembroAListaParaCrearTeam.Text = "->";
            this.buttonAddMiembroAListaParaCrearTeam.UseVisualStyleBackColor = true;
            this.buttonAddMiembroAListaParaCrearTeam.Click += new System.EventHandler(this.buttonAddMiembroAListaParaCrearTeam_Click);
            // 
            // buttonQuitarMiembroDeListaParaNewTeam
            // 
            this.buttonQuitarMiembroDeListaParaNewTeam.Location = new System.Drawing.Point(179, 203);
            this.buttonQuitarMiembroDeListaParaNewTeam.Name = "buttonQuitarMiembroDeListaParaNewTeam";
            this.buttonQuitarMiembroDeListaParaNewTeam.Size = new System.Drawing.Size(28, 22);
            this.buttonQuitarMiembroDeListaParaNewTeam.TabIndex = 9;
            this.buttonQuitarMiembroDeListaParaNewTeam.Text = "<-";
            this.buttonQuitarMiembroDeListaParaNewTeam.UseVisualStyleBackColor = true;
            this.buttonQuitarMiembroDeListaParaNewTeam.Click += new System.EventHandler(this.buttonQuitarMiembroDeListaParaNewTeam_Click);
            // 
            // listBoxAllUsers
            // 
            this.listBoxAllUsers.FormattingEnabled = true;
            this.listBoxAllUsers.Location = new System.Drawing.Point(15, 131);
            this.listBoxAllUsers.Name = "listBoxAllUsers";
            this.listBoxAllUsers.Size = new System.Drawing.Size(158, 121);
            this.listBoxAllUsers.TabIndex = 11;
            // 
            // label1
            // 
            this.label1.AutoSize = true;
            this.label1.Location = new System.Drawing.Point(12, 115);
            this.label1.Name = "label1";
            this.label1.Size = new System.Drawing.Size(111, 13);
            this.label1.TabIndex = 12;
            this.label1.Text = "Usuarios para agregar";
            // 
            // CrearEquipo
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(6F, 13F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.AutoSizeMode = System.Windows.Forms.AutoSizeMode.GrowAndShrink;
            this.BackColor = System.Drawing.SystemColors.ActiveCaption;
            this.ClientSize = new System.Drawing.Size(390, 295);
            this.Controls.Add(this.label1);
            this.Controls.Add(this.listBoxAllUsers);
            this.Controls.Add(this.buttonQuitarMiembroDeListaParaNewTeam);
            this.Controls.Add(this.buttonAddMiembroAListaParaCrearTeam);
            this.Controls.Add(this.labelMiembros);
            this.Controls.Add(this.listBoxConMiembrosNewTeam);
            this.Controls.Add(this.buttonCrearTeam);
            this.Controls.Add(this.textBoxDescrip);
            this.Controls.Add(this.labelDescripTeam);
            this.Controls.Add(this.labelNombreEquipo);
            this.Controls.Add(this.textBoxName);
            this.MaximizeBox = false;
            this.MinimizeBox = false;
            this.Name = "CrearEquipo";
            this.ShowIcon = false;
            this.StartPosition = System.Windows.Forms.FormStartPosition.CenterScreen;
            this.Text = "Nuevo Equipo";
            this.Load += new System.EventHandler(this.CrearEquipo_Load);
            this.ResumeLayout(false);
            this.PerformLayout();

        }

        #endregion

        private System.Windows.Forms.TextBox textBoxName;
        private System.Windows.Forms.Label labelNombreEquipo;
        private System.Windows.Forms.Label labelDescripTeam;
        private System.Windows.Forms.TextBox textBoxDescrip;
        private System.Windows.Forms.Button buttonCrearTeam;
        private System.Windows.Forms.ListBox listBoxConMiembrosNewTeam;
        private System.Windows.Forms.Label labelMiembros;
        private System.Windows.Forms.Button buttonAddMiembroAListaParaCrearTeam;
        private System.Windows.Forms.Button buttonQuitarMiembroDeListaParaNewTeam;
        private System.Windows.Forms.ListBox listBoxAllUsers;
        private System.Windows.Forms.Label label1;
    }
}