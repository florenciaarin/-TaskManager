namespace Administrador_de_Tareas
{
    partial class MenuAddOrChangeTeamToTablero
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
            this.labelEquipos = new System.Windows.Forms.Label();
            this.comboBoxTodosLosEquiposDelUsuario = new System.Windows.Forms.ComboBox();
            this.buttonAgregarOcambiarTeamATablero = new System.Windows.Forms.Button();
            this.linkLabelGoToCreateTeam = new System.Windows.Forms.LinkLabel();
            this.SuspendLayout();
            // 
            // labelEquipos
            // 
            this.labelEquipos.AutoSize = true;
            this.labelEquipos.Location = new System.Drawing.Point(28, 23);
            this.labelEquipos.Name = "labelEquipos";
            this.labelEquipos.Size = new System.Drawing.Size(45, 13);
            this.labelEquipos.TabIndex = 0;
            this.labelEquipos.Text = "Equipos";
            // 
            // comboBoxTodosLosEquiposDelUsuario
            // 
            this.comboBoxTodosLosEquiposDelUsuario.FormattingEnabled = true;
            this.comboBoxTodosLosEquiposDelUsuario.Location = new System.Drawing.Point(31, 48);
            this.comboBoxTodosLosEquiposDelUsuario.Name = "comboBoxTodosLosEquiposDelUsuario";
            this.comboBoxTodosLosEquiposDelUsuario.Size = new System.Drawing.Size(191, 21);
            this.comboBoxTodosLosEquiposDelUsuario.TabIndex = 1;
            // 
            // buttonAgregarOcambiarTeamATablero
            // 
            this.buttonAgregarOcambiarTeamATablero.Location = new System.Drawing.Point(31, 94);
            this.buttonAgregarOcambiarTeamATablero.Name = "buttonAgregarOcambiarTeamATablero";
            this.buttonAgregarOcambiarTeamATablero.Size = new System.Drawing.Size(75, 23);
            this.buttonAgregarOcambiarTeamATablero.TabIndex = 2;
            this.buttonAgregarOcambiarTeamATablero.Text = "Guardar";
            this.buttonAgregarOcambiarTeamATablero.UseVisualStyleBackColor = true;
            this.buttonAgregarOcambiarTeamATablero.Click += new System.EventHandler(this.buttonAgregarOcambiarTeamATablero_Click);
            // 
            // linkLabelGoToCreateTeam
            // 
            this.linkLabelGoToCreateTeam.AutoSize = true;
            this.linkLabelGoToCreateTeam.Location = new System.Drawing.Point(154, 99);
            this.linkLabelGoToCreateTeam.Name = "linkLabelGoToCreateTeam";
            this.linkLabelGoToCreateTeam.Size = new System.Drawing.Size(68, 13);
            this.linkLabelGoToCreateTeam.TabIndex = 3;
            this.linkLabelGoToCreateTeam.TabStop = true;
            this.linkLabelGoToCreateTeam.Text = "Crear Equipo";
            this.linkLabelGoToCreateTeam.LinkClicked += new System.Windows.Forms.LinkLabelLinkClickedEventHandler(this.linkLabelGoToCreateTeam_LinkClicked);
            // 
            // MenuAddOrChangeTeamToTablero
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(6F, 13F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.AutoSizeMode = System.Windows.Forms.AutoSizeMode.GrowAndShrink;
            this.BackColor = System.Drawing.SystemColors.ActiveCaption;
            this.ClientSize = new System.Drawing.Size(251, 138);
            this.Controls.Add(this.linkLabelGoToCreateTeam);
            this.Controls.Add(this.buttonAgregarOcambiarTeamATablero);
            this.Controls.Add(this.comboBoxTodosLosEquiposDelUsuario);
            this.Controls.Add(this.labelEquipos);
            this.MaximizeBox = false;
            this.MinimizeBox = false;
            this.Name = "MenuAddOrChangeTeamToTablero";
            this.ShowIcon = false;
            this.StartPosition = System.Windows.Forms.FormStartPosition.CenterScreen;
            this.Text = "Cambiar equipo del tablero";
            this.Load += new System.EventHandler(this.MenuAddOrChangeTeamToTablero_Load);
            this.ResumeLayout(false);
            this.PerformLayout();

        }

        #endregion

        private System.Windows.Forms.Label labelEquipos;
        private System.Windows.Forms.ComboBox comboBoxTodosLosEquiposDelUsuario;
        private System.Windows.Forms.Button buttonAgregarOcambiarTeamATablero;
        private System.Windows.Forms.LinkLabel linkLabelGoToCreateTeam;
    }
}