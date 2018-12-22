namespace Administrador_de_Tareas
{
    partial class HOME
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
            this.labelTableros = new System.Windows.Forms.Label();
            this.buttonGoTablero = new System.Windows.Forms.Button();
            this.buttonNewTablero = new System.Windows.Forms.Button();
            this.buttonNewTeam = new System.Windows.Forms.Button();
            this.dgvEquipos = new System.Windows.Forms.DataGridView();
            this.labelListadoEquipos = new System.Windows.Forms.Label();
            this.buttonVerTeam = new System.Windows.Forms.Button();
            this.dgvTableros = new System.Windows.Forms.DataGridView();
            this.dgvNotificaciones = new System.Windows.Forms.DataGridView();
            this.labelNotificaciones = new System.Windows.Forms.Label();
            this.buttonMenuPerfil = new System.Windows.Forms.Button();
            this.buttonEliminarTablero = new System.Windows.Forms.Button();
            ((System.ComponentModel.ISupportInitialize)(this.dgvEquipos)).BeginInit();
            ((System.ComponentModel.ISupportInitialize)(this.dgvTableros)).BeginInit();
            ((System.ComponentModel.ISupportInitialize)(this.dgvNotificaciones)).BeginInit();
            this.SuspendLayout();
            // 
            // labelTableros
            // 
            this.labelTableros.AutoSize = true;
            this.labelTableros.BackColor = System.Drawing.SystemColors.Window;
            this.labelTableros.Location = new System.Drawing.Point(33, 21);
            this.labelTableros.Name = "labelTableros";
            this.labelTableros.Size = new System.Drawing.Size(106, 13);
            this.labelTableros.TabIndex = 1;
            this.labelTableros.Text = "Seleccioná el tablero";
            // 
            // buttonGoTablero
            // 
            this.buttonGoTablero.BackColor = System.Drawing.SystemColors.HotTrack;
            this.buttonGoTablero.ForeColor = System.Drawing.SystemColors.Info;
            this.buttonGoTablero.Location = new System.Drawing.Point(24, 250);
            this.buttonGoTablero.Name = "buttonGoTablero";
            this.buttonGoTablero.Size = new System.Drawing.Size(48, 27);
            this.buttonGoTablero.TabIndex = 2;
            this.buttonGoTablero.Text = "Go";
            this.buttonGoTablero.UseVisualStyleBackColor = false;
            this.buttonGoTablero.Click += new System.EventHandler(this.buttonGoTablero_Click);
            // 
            // buttonNewTablero
            // 
            this.buttonNewTablero.BackColor = System.Drawing.SystemColors.HotTrack;
            this.buttonNewTablero.ForeColor = System.Drawing.SystemColors.Info;
            this.buttonNewTablero.Location = new System.Drawing.Point(118, 250);
            this.buttonNewTablero.Name = "buttonNewTablero";
            this.buttonNewTablero.Size = new System.Drawing.Size(53, 27);
            this.buttonNewTablero.TabIndex = 3;
            this.buttonNewTablero.Text = "New";
            this.buttonNewTablero.UseVisualStyleBackColor = false;
            this.buttonNewTablero.Click += new System.EventHandler(this.buttonNewTablero_Click);
            // 
            // buttonNewTeam
            // 
            this.buttonNewTeam.BackColor = System.Drawing.SystemColors.Highlight;
            this.buttonNewTeam.ForeColor = System.Drawing.SystemColors.HighlightText;
            this.buttonNewTeam.Location = new System.Drawing.Point(265, 251);
            this.buttonNewTeam.Name = "buttonNewTeam";
            this.buttonNewTeam.Size = new System.Drawing.Size(54, 30);
            this.buttonNewTeam.TabIndex = 4;
            this.buttonNewTeam.Text = "New";
            this.buttonNewTeam.UseVisualStyleBackColor = false;
            this.buttonNewTeam.Click += new System.EventHandler(this.buttonNewTeam_Click);
            // 
            // dgvEquipos
            // 
            this.dgvEquipos.AllowUserToDeleteRows = false;
            this.dgvEquipos.BackgroundColor = System.Drawing.SystemColors.ControlLightLight;
            this.dgvEquipos.ColumnHeadersHeightSizeMode = System.Windows.Forms.DataGridViewColumnHeadersHeightSizeMode.AutoSize;
            this.dgvEquipos.GridColor = System.Drawing.SystemColors.Window;
            this.dgvEquipos.Location = new System.Drawing.Point(192, 37);
            this.dgvEquipos.Name = "dgvEquipos";
            this.dgvEquipos.ReadOnly = true;
            this.dgvEquipos.SelectionMode = System.Windows.Forms.DataGridViewSelectionMode.FullRowSelect;
            this.dgvEquipos.Size = new System.Drawing.Size(144, 208);
            this.dgvEquipos.TabIndex = 5;
            this.dgvEquipos.CellClick += new System.Windows.Forms.DataGridViewCellEventHandler(this.dgvEquipos_CellClick);
            this.dgvEquipos.CellDoubleClick += new System.Windows.Forms.DataGridViewCellEventHandler(this.dgvEquipos_CellDoubleClick);
            // 
            // labelListadoEquipos
            // 
            this.labelListadoEquipos.AutoSize = true;
            this.labelListadoEquipos.BackColor = System.Drawing.SystemColors.Window;
            this.labelListadoEquipos.Location = new System.Drawing.Point(204, 21);
            this.labelListadoEquipos.Name = "labelListadoEquipos";
            this.labelListadoEquipos.Size = new System.Drawing.Size(66, 13);
            this.labelListadoEquipos.TabIndex = 6;
            this.labelListadoEquipos.Text = "Tus Equipos";
            // 
            // buttonVerTeam
            // 
            this.buttonVerTeam.BackColor = System.Drawing.SystemColors.Highlight;
            this.buttonVerTeam.ForeColor = System.Drawing.SystemColors.HighlightText;
            this.buttonVerTeam.Location = new System.Drawing.Point(216, 250);
            this.buttonVerTeam.Name = "buttonVerTeam";
            this.buttonVerTeam.Size = new System.Drawing.Size(54, 31);
            this.buttonVerTeam.TabIndex = 7;
            this.buttonVerTeam.Text = "Ver";
            this.buttonVerTeam.UseVisualStyleBackColor = false;
            this.buttonVerTeam.Click += new System.EventHandler(this.buttonVerTeam_Click);
            // 
            // dgvTableros
            // 
            this.dgvTableros.AllowUserToDeleteRows = false;
            this.dgvTableros.BackgroundColor = System.Drawing.SystemColors.ControlLightLight;
            this.dgvTableros.ColumnHeadersHeightSizeMode = System.Windows.Forms.DataGridViewColumnHeadersHeightSizeMode.AutoSize;
            this.dgvTableros.GridColor = System.Drawing.SystemColors.Window;
            this.dgvTableros.Location = new System.Drawing.Point(24, 37);
            this.dgvTableros.Name = "dgvTableros";
            this.dgvTableros.ReadOnly = true;
            this.dgvTableros.SelectionMode = System.Windows.Forms.DataGridViewSelectionMode.FullRowSelect;
            this.dgvTableros.Size = new System.Drawing.Size(148, 207);
            this.dgvTableros.TabIndex = 8;
            this.dgvTableros.CellClick += new System.Windows.Forms.DataGridViewCellEventHandler(this.dgvTableros_CellClick);
            this.dgvTableros.CellDoubleClick += new System.Windows.Forms.DataGridViewCellEventHandler(this.dgvTableros_CellDoubleClick);
            // 
            // dgvNotificaciones
            // 
            this.dgvNotificaciones.AllowUserToDeleteRows = false;
            this.dgvNotificaciones.BackgroundColor = System.Drawing.SystemColors.InactiveCaption;
            this.dgvNotificaciones.ColumnHeadersHeightSizeMode = System.Windows.Forms.DataGridViewColumnHeadersHeightSizeMode.AutoSize;
            this.dgvNotificaciones.Location = new System.Drawing.Point(380, 79);
            this.dgvNotificaciones.Name = "dgvNotificaciones";
            this.dgvNotificaciones.ReadOnly = true;
            this.dgvNotificaciones.Size = new System.Drawing.Size(242, 198);
            this.dgvNotificaciones.TabIndex = 9;
            this.dgvNotificaciones.Visible = false;
            // 
            // labelNotificaciones
            // 
            this.labelNotificaciones.AutoSize = true;
            this.labelNotificaciones.Location = new System.Drawing.Point(386, 63);
            this.labelNotificaciones.Name = "labelNotificaciones";
            this.labelNotificaciones.Size = new System.Drawing.Size(74, 13);
            this.labelNotificaciones.TabIndex = 10;
            this.labelNotificaciones.Text = "Notificaciones";
            this.labelNotificaciones.Visible = false;
            // 
            // buttonMenuPerfil
            // 
            this.buttonMenuPerfil.BackColor = System.Drawing.SystemColors.Highlight;
            this.buttonMenuPerfil.Font = new System.Drawing.Font("Farsi Simple Outline", 11.25F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(178)));
            this.buttonMenuPerfil.ForeColor = System.Drawing.Color.White;
            this.buttonMenuPerfil.Location = new System.Drawing.Point(366, 12);
            this.buttonMenuPerfil.Name = "buttonMenuPerfil";
            this.buttonMenuPerfil.Size = new System.Drawing.Size(55, 35);
            this.buttonMenuPerfil.TabIndex = 11;
            this.buttonMenuPerfil.Text = "NN";
            this.buttonMenuPerfil.UseVisualStyleBackColor = false;
            this.buttonMenuPerfil.Click += new System.EventHandler(this.buttonMenuPerfil_Click);
            // 
            // buttonEliminarTablero
            // 
            this.buttonEliminarTablero.BackColor = System.Drawing.SystemColors.HotTrack;
            this.buttonEliminarTablero.ForeColor = System.Drawing.SystemColors.Info;
            this.buttonEliminarTablero.Location = new System.Drawing.Point(69, 250);
            this.buttonEliminarTablero.Name = "buttonEliminarTablero";
            this.buttonEliminarTablero.Size = new System.Drawing.Size(53, 27);
            this.buttonEliminarTablero.TabIndex = 12;
            this.buttonEliminarTablero.Text = "Delete";
            this.buttonEliminarTablero.UseVisualStyleBackColor = false;
            this.buttonEliminarTablero.Click += new System.EventHandler(this.buttonEliminarTablero_Click);
            // 
            // HOME
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(6F, 13F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.AutoSizeMode = System.Windows.Forms.AutoSizeMode.GrowAndShrink;
            this.BackgroundImage = global::Administrador_de_Tareas.Properties.Resources.marYarena;
            this.ClientSize = new System.Drawing.Size(434, 293);
            this.Controls.Add(this.buttonEliminarTablero);
            this.Controls.Add(this.buttonMenuPerfil);
            this.Controls.Add(this.labelNotificaciones);
            this.Controls.Add(this.dgvNotificaciones);
            this.Controls.Add(this.dgvTableros);
            this.Controls.Add(this.buttonVerTeam);
            this.Controls.Add(this.labelListadoEquipos);
            this.Controls.Add(this.dgvEquipos);
            this.Controls.Add(this.buttonNewTeam);
            this.Controls.Add(this.buttonNewTablero);
            this.Controls.Add(this.buttonGoTablero);
            this.Controls.Add(this.labelTableros);
            this.MaximizeBox = false;
            this.MinimizeBox = false;
            this.Name = "HOME";
            this.ShowIcon = false;
            this.StartPosition = System.Windows.Forms.FormStartPosition.CenterScreen;
            this.Text = "HOME";
            this.TransparencyKey = System.Drawing.Color.LightGray;
            this.Load += new System.EventHandler(this.HOME_Load);
            ((System.ComponentModel.ISupportInitialize)(this.dgvEquipos)).EndInit();
            ((System.ComponentModel.ISupportInitialize)(this.dgvTableros)).EndInit();
            ((System.ComponentModel.ISupportInitialize)(this.dgvNotificaciones)).EndInit();
            this.ResumeLayout(false);
            this.PerformLayout();

        }

        #endregion
        private System.Windows.Forms.Label labelTableros;
        private System.Windows.Forms.Button buttonGoTablero;
        private System.Windows.Forms.Button buttonNewTablero;
        private System.Windows.Forms.Button buttonNewTeam;
        private System.Windows.Forms.DataGridView dgvEquipos;
        private System.Windows.Forms.Label labelListadoEquipos;
        private System.Windows.Forms.Button buttonVerTeam;
        private System.Windows.Forms.DataGridView dgvTableros;
        private System.Windows.Forms.DataGridView dgvNotificaciones;
        private System.Windows.Forms.Label labelNotificaciones;
        private System.Windows.Forms.Button buttonMenuPerfil;
        private System.Windows.Forms.Button buttonEliminarTablero;
    }
}

