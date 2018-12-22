namespace Administrador_de_Tareas
{
    partial class MenuSiYaTieneEquipoTablero
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
            this.linkLabelGoToMenuAddOrChangeTeamTablero = new System.Windows.Forms.LinkLabel();
            this.linkLabelGoToVerEditarElimTeam = new System.Windows.Forms.LinkLabel();
            this.SuspendLayout();
            // 
            // linkLabelGoToMenuAddOrChangeTeamTablero
            // 
            this.linkLabelGoToMenuAddOrChangeTeamTablero.AutoSize = true;
            this.linkLabelGoToMenuAddOrChangeTeamTablero.Location = new System.Drawing.Point(33, 38);
            this.linkLabelGoToMenuAddOrChangeTeamTablero.Name = "linkLabelGoToMenuAddOrChangeTeamTablero";
            this.linkLabelGoToMenuAddOrChangeTeamTablero.Size = new System.Drawing.Size(81, 13);
            this.linkLabelGoToMenuAddOrChangeTeamTablero.TabIndex = 0;
            this.linkLabelGoToMenuAddOrChangeTeamTablero.TabStop = true;
            this.linkLabelGoToMenuAddOrChangeTeamTablero.Text = "Cambiar Equipo";
            this.linkLabelGoToMenuAddOrChangeTeamTablero.LinkClicked += new System.Windows.Forms.LinkLabelLinkClickedEventHandler(this.linkLabelGoToMenuAddOrChangeTeamTablero_LinkClicked);
            // 
            // linkLabelGoToVerEditarElimTeam
            // 
            this.linkLabelGoToVerEditarElimTeam.AutoSize = true;
            this.linkLabelGoToVerEditarElimTeam.Location = new System.Drawing.Point(44, 78);
            this.linkLabelGoToVerEditarElimTeam.Name = "linkLabelGoToVerEditarElimTeam";
            this.linkLabelGoToVerEditarElimTeam.Size = new System.Drawing.Size(59, 13);
            this.linkLabelGoToVerEditarElimTeam.TabIndex = 1;
            this.linkLabelGoToVerEditarElimTeam.TabStop = true;
            this.linkLabelGoToVerEditarElimTeam.Text = "Ver Equipo";
            this.linkLabelGoToVerEditarElimTeam.LinkClicked += new System.Windows.Forms.LinkLabelLinkClickedEventHandler(this.linkLabelGoToVerEditarElimTeam_LinkClicked);
            // 
            // MenuSiYaTieneEquipoTablero
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(6F, 13F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.AutoSizeMode = System.Windows.Forms.AutoSizeMode.GrowAndShrink;
            this.BackColor = System.Drawing.SystemColors.GradientInactiveCaption;
            this.ClientSize = new System.Drawing.Size(147, 125);
            this.Controls.Add(this.linkLabelGoToVerEditarElimTeam);
            this.Controls.Add(this.linkLabelGoToMenuAddOrChangeTeamTablero);
            this.MaximizeBox = false;
            this.MinimizeBox = false;
            this.Name = "MenuSiYaTieneEquipoTablero";
            this.ShowIcon = false;
            this.StartPosition = System.Windows.Forms.FormStartPosition.CenterScreen;
            this.Text = "Equipo del tablero";
            this.ResumeLayout(false);
            this.PerformLayout();

        }

        #endregion

        private System.Windows.Forms.LinkLabel linkLabelGoToMenuAddOrChangeTeamTablero;
        private System.Windows.Forms.LinkLabel linkLabelGoToVerEditarElimTeam;
    }
}