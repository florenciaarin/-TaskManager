namespace Administrador_de_Tareas
{
    partial class MenuUsuario
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
            this.linkLabelGoToPerfil = new System.Windows.Forms.LinkLabel();
            this.linkLabelLogOut = new System.Windows.Forms.LinkLabel();
            this.SuspendLayout();
            // 
            // linkLabelGoToPerfil
            // 
            this.linkLabelGoToPerfil.AutoSize = true;
            this.linkLabelGoToPerfil.LinkColor = System.Drawing.Color.Navy;
            this.linkLabelGoToPerfil.Location = new System.Drawing.Point(36, 34);
            this.linkLabelGoToPerfil.Name = "linkLabelGoToPerfil";
            this.linkLabelGoToPerfil.Size = new System.Drawing.Size(48, 13);
            this.linkLabelGoToPerfil.TabIndex = 0;
            this.linkLabelGoToPerfil.TabStop = true;
            this.linkLabelGoToPerfil.Text = "Ver perfil";
            this.linkLabelGoToPerfil.LinkClicked += new System.Windows.Forms.LinkLabelLinkClickedEventHandler(this.linkLabelGoToPerfil_LinkClicked);
            // 
            // linkLabelLogOut
            // 
            this.linkLabelLogOut.AutoSize = true;
            this.linkLabelLogOut.LinkColor = System.Drawing.Color.Navy;
            this.linkLabelLogOut.Location = new System.Drawing.Point(26, 70);
            this.linkLabelLogOut.Name = "linkLabelLogOut";
            this.linkLabelLogOut.Size = new System.Drawing.Size(68, 13);
            this.linkLabelLogOut.TabIndex = 1;
            this.linkLabelLogOut.TabStop = true;
            this.linkLabelLogOut.Text = "Cerrar sesión";
            this.linkLabelLogOut.LinkClicked += new System.Windows.Forms.LinkLabelLinkClickedEventHandler(this.linkLabelLogOut_LinkClicked);
            // 
            // MenuUsuario
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(6F, 13F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.AutoSizeMode = System.Windows.Forms.AutoSizeMode.GrowAndShrink;
            this.BackColor = System.Drawing.SystemColors.GradientInactiveCaption;
            this.ClientSize = new System.Drawing.Size(120, 117);
            this.Controls.Add(this.linkLabelLogOut);
            this.Controls.Add(this.linkLabelGoToPerfil);
            this.MaximizeBox = false;
            this.MinimizeBox = false;
            this.Name = "MenuUsuario";
            this.ShowIcon = false;
            this.StartPosition = System.Windows.Forms.FormStartPosition.CenterScreen;
            this.Text = "...";
            this.ResumeLayout(false);
            this.PerformLayout();

        }

        #endregion

        private System.Windows.Forms.LinkLabel linkLabelGoToPerfil;
        private System.Windows.Forms.LinkLabel linkLabelLogOut;
    }
}