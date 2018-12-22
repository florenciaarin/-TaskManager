namespace Administrador_de_Tareas
{
    partial class VerPERFIL
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
            this.labeliniciales = new System.Windows.Forms.Label();
            this.labelName = new System.Windows.Forms.Label();
            this.labelMuestraNombreUsuario = new System.Windows.Forms.Label();
            this.labelMail = new System.Windows.Forms.Label();
            this.labelMuestraMail = new System.Windows.Forms.Label();
            this.linkLabelGoToEditarPerfilUsuario = new System.Windows.Forms.LinkLabel();
            this.SuspendLayout();
            // 
            // labeliniciales
            // 
            this.labeliniciales.AutoSize = true;
            this.labeliniciales.BackColor = System.Drawing.SystemColors.Info;
            this.labeliniciales.Font = new System.Drawing.Font("Farsi Simple Outline", 11.25F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(178)));
            this.labeliniciales.ForeColor = System.Drawing.SystemColors.AppWorkspace;
            this.labeliniciales.Location = new System.Drawing.Point(12, 16);
            this.labeliniciales.Name = "labeliniciales";
            this.labeliniciales.Size = new System.Drawing.Size(34, 33);
            this.labeliniciales.TabIndex = 1;
            this.labeliniciales.Text = "IN";
            // 
            // labelName
            // 
            this.labelName.AutoSize = true;
            this.labelName.ForeColor = System.Drawing.SystemColors.AppWorkspace;
            this.labelName.Location = new System.Drawing.Point(61, 16);
            this.labelName.Name = "labelName";
            this.labelName.Size = new System.Drawing.Size(47, 13);
            this.labelName.TabIndex = 2;
            this.labelName.Text = "Nombre:";
            // 
            // labelMuestraNombreUsuario
            // 
            this.labelMuestraNombreUsuario.AutoSize = true;
            this.labelMuestraNombreUsuario.Font = new System.Drawing.Font("Microsoft Sans Serif", 9.75F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.labelMuestraNombreUsuario.Location = new System.Drawing.Point(83, 45);
            this.labelMuestraNombreUsuario.Name = "labelMuestraNombreUsuario";
            this.labelMuestraNombreUsuario.Size = new System.Drawing.Size(112, 16);
            this.labelMuestraNombreUsuario.TabIndex = 3;
            this.labelMuestraNombreUsuario.Text = "Aparece Nombre";
            // 
            // labelMail
            // 
            this.labelMail.AutoSize = true;
            this.labelMail.ForeColor = System.Drawing.SystemColors.AppWorkspace;
            this.labelMail.Location = new System.Drawing.Point(61, 74);
            this.labelMail.Name = "labelMail";
            this.labelMail.Size = new System.Drawing.Size(29, 13);
            this.labelMail.TabIndex = 4;
            this.labelMail.Text = "Mail:";
            // 
            // labelMuestraMail
            // 
            this.labelMuestraMail.AutoSize = true;
            this.labelMuestraMail.Location = new System.Drawing.Point(83, 106);
            this.labelMuestraMail.Name = "labelMuestraMail";
            this.labelMuestraMail.Size = new System.Drawing.Size(68, 13);
            this.labelMuestraMail.TabIndex = 5;
            this.labelMuestraMail.Text = "Aparece mail";
            // 
            // linkLabelGoToEditarPerfilUsuario
            // 
            this.linkLabelGoToEditarPerfilUsuario.AutoSize = true;
            this.linkLabelGoToEditarPerfilUsuario.Location = new System.Drawing.Point(197, 139);
            this.linkLabelGoToEditarPerfilUsuario.Name = "linkLabelGoToEditarPerfilUsuario";
            this.linkLabelGoToEditarPerfilUsuario.Size = new System.Drawing.Size(34, 13);
            this.linkLabelGoToEditarPerfilUsuario.TabIndex = 6;
            this.linkLabelGoToEditarPerfilUsuario.TabStop = true;
            this.linkLabelGoToEditarPerfilUsuario.Text = "Editar";
            this.linkLabelGoToEditarPerfilUsuario.LinkClicked += new System.Windows.Forms.LinkLabelLinkClickedEventHandler(this.linkLabelGoToEditarPerfilUsuario_LinkClicked);
            // 
            // VerPERFIL
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(6F, 13F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.AutoSizeMode = System.Windows.Forms.AutoSizeMode.GrowAndShrink;
            this.BackColor = System.Drawing.SystemColors.GradientInactiveCaption;
            this.ClientSize = new System.Drawing.Size(256, 172);
            this.Controls.Add(this.linkLabelGoToEditarPerfilUsuario);
            this.Controls.Add(this.labelMuestraMail);
            this.Controls.Add(this.labelMail);
            this.Controls.Add(this.labelMuestraNombreUsuario);
            this.Controls.Add(this.labelName);
            this.Controls.Add(this.labeliniciales);
            this.MaximizeBox = false;
            this.MinimizeBox = false;
            this.Name = "VerPERFIL";
            this.ShowIcon = false;
            this.StartPosition = System.Windows.Forms.FormStartPosition.CenterParent;
            this.Text = "Perfil";
            this.Load += new System.EventHandler(this.VerPERFIL_Load);
            this.ResumeLayout(false);
            this.PerformLayout();

        }

        #endregion

        private System.Windows.Forms.Label labeliniciales;
        private System.Windows.Forms.Label labelName;
        private System.Windows.Forms.Label labelMuestraNombreUsuario;
        private System.Windows.Forms.Label labelMail;
        private System.Windows.Forms.Label labelMuestraMail;
        private System.Windows.Forms.LinkLabel linkLabelGoToEditarPerfilUsuario;
    }
}